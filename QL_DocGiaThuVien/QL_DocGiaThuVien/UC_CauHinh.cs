using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using DAO;

namespace QL_DocGiaThuVien
{
    public partial class UC_CauHinh : UserControl
    {
        public UC_CauHinh()
        {
            InitializeComponent();
        }

        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }

        private void UC_CauHinh_Load(object sender, EventArgs e)
        {
            DataTable dt = GetServerName();
            cmbSeverName.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                cmbSeverName.Items.Add(row[0].ToString() + "\\" + row[1].ToString());
            }
        }
        private void EnableControl(bool b)
        {
            txtUserName.Enabled = b;
            txtPassword.Enabled = b;
            lbUserName.Enabled = b;
            lbPassword.Enabled = b;
        }

        public string name;
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 0)
            {
                EnableControl(false);
            }
            else
            {
                EnableControl(true);
            }

            if (cmbAuthentication.Text == "Windows Authentication")
            {
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }

        private void btnGetDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = null;
                name = cmbSeverName.Text;
                if (cmbAuthentication.SelectedIndex == 0)
                {
                    connectionString = @"Data Source=" + name + ";Initial Catalog=master;Integrated Security=True";
                }
                else
                {
                    connectionString = @"Data Source=" + name + ";Initial Catalog=master;User ID=" + txtUserName.Text.Trim() + ";password=" + txtPassword.Text.Trim();
                }
                SqlConnection connection = new SqlConnection(connectionString);

                try
                {
                    connection.Open();

                    SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sys.databases WHERE name not in('master','model','msdb','tempdb')", connection);

                    DataTable table = new DataTable();
                    da.Fill(table);

                    da.Dispose();

                    connection.Close();

                    cmbDatabase.DataSource = table;
                    cmbDatabase.DisplayMember = "name";
                    cmbDatabase.ValueMember = "name";

                    label5.Enabled = true;
                    cmbDatabase.Enabled = true;

                    btnGetDatabase.Enabled = false;
                    btnKetNoi.Enabled = true;

                    label1.Enabled = false;
                    cmbSeverName.Enabled = false;

                    cmbAuthentication.Enabled = false;

                    EnableControl(false);
                }
                catch (Exception ex)
                {
                    btnKetNoi.Enabled = false;
                    MessageBox.Show(ex.Message);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn ServerName!!!");
                cmbSeverName.Focus();
            }
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (cmbDatabase.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một CSDL");
                return;
            }
            string connectionString = null;
            if (cmbAuthentication.SelectedIndex == 0)
            {
                connectionString = @"Data Source=" + name + ";Initial Catalog=" + cmbDatabase.SelectedValue.ToString() + ";Integrated Security=True";
            }
            else
            {
                connectionString = @"Data Source=" + name + ";Initial Catalog=" + cmbDatabase.SelectedValue.ToString() + ";User ID=" + txtUserName.Text.Trim() + ";password=" + txtPassword.Text.Trim();
            }

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("KIEMTRA_TABLE", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader ren = cmd.ExecuteReader();
                bool flag = false;
                while (ren.Read())
                {
                    string ca = ren[0].ToString();
                    if (ren[0].ToString().Equals("True"))
                    {
                        flag = true;
                    }
                    break;
                }
                connection.Close();
                if (flag)
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    connectionStringsSection.ConnectionStrings["QL_DocGiaThuVien.Properties.Settings.QL_ThuVienConnectionString"].ConnectionString = connectionString;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("QL_DocGiaThuVien.Properties.Settings.QL_ThuVienConnectionString");

                    ConfigDAO.setConfig(connectionString);

                    string c = Properties.Settings.Default.QL_ThuVienConnectionString;
                    MessageBox.Show("Kết nối CSDL thành công !");

                    frm_CauHinh frm_dangnhap = new frm_CauHinh();
                    frm_dangnhap.Hide();


                }
                else
                {
                    MessageBox.Show("Ket noi CSDL that bai!\n Chon lai DataBase nhe!");
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Chon sai DataBase! Hay chon CSDL phu hop voi phan mem!!!");
                return;
            }
        }
    }
}
