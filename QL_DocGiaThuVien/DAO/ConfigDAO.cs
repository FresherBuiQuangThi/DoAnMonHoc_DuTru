using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ConfigDAO
    {
        public static bool setConfig(string key)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["DAO.Properties.Settings.QL_ThuVienConnectionString"].ConnectionString = key;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("DAO.Properties.Settings.QL_ThuVienConnectionString");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static string getConfig()
        {
            try
            {
                return DAO.Properties.Settings.Default.QL_ThuVienConnectionString;
            }
            catch
            {
                return "";
            }
        }
    }
}
