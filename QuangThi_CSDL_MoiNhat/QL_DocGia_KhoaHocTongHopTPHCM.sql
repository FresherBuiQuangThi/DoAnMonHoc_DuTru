USE [master]
GO
/****** Object:  Database [QL_DocGia_KhoaHocTongHopTPHCM]    Script Date: 5/4/2018 1:45:22 AM ******/
CREATE DATABASE [QL_DocGia_KhoaHocTongHopTPHCM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_DocGia_KhoaHocTongHopTPHCM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QL_DocGia_KhoaHocTongHopTPHCM.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_DocGia_KhoaHocTongHopTPHCM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QL_DocGia_KhoaHocTongHopTPHCM_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_DocGia_KhoaHocTongHopTPHCM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET  MULTI_USER 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QL_DocGia_KhoaHocTongHopTPHCM]
GO
/****** Object:  Table [dbo].[CT_PHIEUMUON]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEUMUON](
	[MaPhieuMuon] [varchar](20) NOT NULL,
	[MaSach] [varchar](20) NOT NULL,
	[SoLuong1Loai] [int] NULL,
	[TinhTrangTra] [bit] NULL,
 CONSTRAINT [PK_CT_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_PHIEUTRA]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEUTRA](
	[MaPhieuTra] [varchar](20) NOT NULL,
	[MaSach] [varchar](20) NOT NULL,
	[SoLuong1Loai] [int] NULL,
 CONSTRAINT [PK_CT_PHIEUTRA] PRIMARY KEY CLUSTERED 
(
	[MaPhieuTra] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_XULYVIPHAM]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_XULYVIPHAM](
	[MaViPham] [varchar](20) NOT NULL,
	[MaSachViPham] [varchar](20) NOT NULL,
	[HanhViViPham] [varchar](20) NULL,
	[TienBoiThuong] [float] NULL,
 CONSTRAINT [PK_CT_XULYVIPHAM] PRIMARY KEY CLUSTERED 
(
	[MaViPham] ASC,
	[MaSachViPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DANTOC]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DANTOC](
	[MaDanToc] [varchar](20) NOT NULL,
	[TenDanToc] [nvarchar](100) NULL,
 CONSTRAINT [PK_DANTOC] PRIMARY KEY CLUSTERED 
(
	[MaDanToc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MaDocGia] [varchar](20) NOT NULL,
	[TenDocGia] [nvarchar](100) NULL,
	[DanToc] [varchar](20) NULL,
	[TrinhDo] [varchar](20) NULL,
	[QuocTich] [varchar](20) NULL,
	[NhomNganh] [varchar](20) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[CMND] [varchar](20) NULL,
	[NgheNghiep] [nvarchar](100) NULL,
	[NoiCongTac] [nvarchar](200) NULL,
	[SDT] [varchar](20) NULL,
	[Email] [varchar](20) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[TrangThaiLamThe] [bit] NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANHVIVIPHAM]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANHVIVIPHAM](
	[MaHanhVi] [varchar](20) NOT NULL,
	[TenHanhVi] [nvarchar](100) NULL,
	[HinhThucXuLy] [nvarchar](100) NULL,
 CONSTRAINT [PK_HANHVIVIPHAM] PRIMARY KEY CLUSTERED 
(
	[MaHanhVi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAISACH]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAISACH](
	[MaLoaiSach] [varchar](20) NOT NULL,
	[LoaiSach] [nvarchar](100) NULL,
 CONSTRAINT [PK_LOAISACH] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAITHE]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAITHE](
	[MaLoaiThe] [varchar](20) NOT NULL,
	[TenLoaiThe] [nvarchar](100) NULL,
	[PhiLamThe] [float] NULL,
 CONSTRAINT [PK_LOAITHE] PRIMARY KEY CLUSTERED 
(
	[MaLoaiThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MANHINH]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MANHINH](
	[MaManHinh] [varchar](20) NOT NULL,
	[TenManHinh] [nvarchar](100) NULL,
 CONSTRAINT [PK_MANHINH] PRIMARY KEY CLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGONNGUSACH]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGONNGUSACH](
	[MaNgonNgu] [varchar](20) NOT NULL,
	[NgonNgu] [nvarchar](100) NULL,
 CONSTRAINT [PK_NGONNGUSACH] PRIMARY KEY CLUSTERED 
(
	[MaNgonNgu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [varchar](20) NOT NULL,
	[TenNhanVien] [nvarchar](100) NULL,
	[DanToc] [varchar](20) NULL,
	[TrinhDo] [varchar](20) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[SDT] [varchar](20) NULL,
	[CMND] [varchar](20) NULL,
	[DiaChi] [nvarchar](200) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MaNhaXuatBan] [varchar](20) NOT NULL,
	[NhaXuatBan] [nvarchar](100) NULL,
 CONSTRAINT [PK_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[MaNhaXuatBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOMNGANH]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOMNGANH](
	[MaNhomNganh] [varchar](20) NOT NULL,
	[NhomNganh] [nvarchar](100) NULL,
 CONSTRAINT [PK_NHOMNGANH] PRIMARY KEY CLUSTERED 
(
	[MaNhomNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOMNHANVIEN]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOMNHANVIEN](
	[MaNhomNV] [varchar](20) NOT NULL,
	[TenNhomNV] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_NHOMNHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhomNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHANQUYENNHANVIEN]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHANQUYENNHANVIEN](
	[MaNhomNV] [varchar](20) NOT NULL,
	[MaManHinh] [varchar](20) NOT NULL,
	[XetQuyen] [bit] NULL,
 CONSTRAINT [PK_PHANQUYENNHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhomNV] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MaPhieuMuon] [varchar](20) NOT NULL,
	[NhanVienLap] [varchar](20) NULL,
	[SoTheDocGia] [varchar](20) NULL,
	[SoLuongSachMuon] [int] NULL,
	[NgayLapPM] [date] NULL,
	[ThoiHanMuonSach] [date] NULL,
	[PhiDatCoc] [float] NULL,
 CONSTRAINT [PK_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUTRA]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUTRA](
	[MaPhieuTra] [varchar](20) NOT NULL,
	[MaPhieuMuon] [varchar](20) NULL,
	[NhanVienLap] [varchar](20) NULL,
	[SoTheDocGia] [varchar](20) NULL,
	[NgayLap] [datetime] NULL,
	[SoLuongSachMuon] [int] NULL,
	[SoLuongSachTra] [int] NULL,
	[SoTienNhanLai] [float] NULL,
	[MaViPham] [varchar](20) NULL,
 CONSTRAINT [PK_PHIEUTRA] PRIMARY KEY CLUSTERED 
(
	[MaPhieuTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QUOCTICH]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QUOCTICH](
	[MaQuocTich] [varchar](20) NOT NULL,
	[QuocTich] [nchar](10) NULL,
 CONSTRAINT [PK_QUOCTICH] PRIMARY KEY CLUSTERED 
(
	[MaQuocTich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TACGIASACH]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TACGIASACH](
	[MaTacGia] [varchar](20) NOT NULL,
	[TacGia] [nvarchar](100) NULL,
 CONSTRAINT [PK_TACGIASACH] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAIKHOAN_NHOMNHANVIEN]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN_NHOMNHANVIEN](
	[TenDangNhap] [varchar](20) NOT NULL,
	[MaNhomNV] [varchar](20) NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAIKHOAN_NHOMNHANVIEN] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC,
	[MaNhomNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAIKHOANNHANVIEN]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOANNHANVIEN](
	[TenDangNhap] [varchar](20) NOT NULL,
	[MatKhau] [varchar](20) NULL,
	[HoatDong] [bit] NULL,
 CONSTRAINT [PK_TAIKHOANNHANVIEN] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THETHUVIEN]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THETHUVIEN](
	[SoThe] [varchar](20) NOT NULL,
	[MaLoai] [varchar](20) NULL,
	[MaDocGia] [varchar](20) NULL,
	[NgayLamThe] [date] NULL,
	[HanSuDung] [date] NULL,
	[MaVachThe] [varchar](100) NULL,
	[TinhTrangThe] [bit] NULL,
	[TinhTrangMuon] [bit] NULL,
 CONSTRAINT [PK_TheDocGia] PRIMARY KEY CLUSTERED 
(
	[SoThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THONGTINSACH]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THONGTINSACH](
	[MaSach] [varchar](20) NOT NULL,
	[TenSach] [nvarchar](200) NULL,
	[NgonNgu] [varchar](20) NULL,
	[TheLoai] [varchar](20) NULL,
	[NhaXB] [varchar](20) NULL,
	[NamXB] [int] NULL,
	[TacGia] [varchar](20) NULL,
	[SoLuongTon] [int] NULL,
	[GiaTriSach] [float] NULL,
	[ThongTinSach] [nvarchar](2000) NULL,
	[MaVach] [varchar](100) NULL,
 CONSTRAINT [PK_THONGTINSACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRINHDO]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRINHDO](
	[MaTrinhDo] [varchar](20) NOT NULL,
	[TenTrinhDo] [nvarchar](100) NULL,
 CONSTRAINT [PK_TRINHDO] PRIMARY KEY CLUSTERED 
(
	[MaTrinhDo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[XULYVIPHAM]    Script Date: 5/4/2018 1:45:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XULYVIPHAM](
	[MaViPham] [varchar](20) NOT NULL,
	[MaPhieuTra] [varchar](20) NULL,
	[DocGiaViPham] [varchar](20) NULL,
	[NhanVienLap] [varchar](20) NULL,
	[NgayGioLap] [datetime] NULL,
	[PhiBoiThuong] [float] NULL,
 CONSTRAINT [PK_XULYVIPHAM] PRIMARY KEY CLUSTERED 
(
	[MaViPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT001', N'Kinh')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT002', N'Hoa')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT003', N'Tày')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT004', N'Thái')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT005', N'Mường')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT006', N'Khơ-me')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT007', N'Nùng')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT008', N'Hơmông')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT009', N'Dao')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT010', N'Gia-rai')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT011', N'Ê-đê')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT012', N'Ba-na')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT013', N'Sán Cháy')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT014', N'Chăm')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT015', N'Cơ-ho')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT016', N'Mnông')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT017', N'Thổ')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT018', N'Chơ-ro')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT019', N'Kháng')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT020', N'Lào')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT021', N'Xinh-mun')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [DanToc], [TrinhDo], [QuocTich], [NhomNganh], [NgaySinh], [GioiTinh], [CMND], [NgheNghiep], [NoiCongTac], [SDT], [Email], [DiaChi], [TrangThaiLamThe]) VALUES (N'DG00000001', N'Nguyễn Văn A', N'DT001', N'TDHV001', N'QT0001', N'NN0001', CAST(N'1996-10-10' AS Date), N'Nam', N'272490456', N'Sinh Viên HUFI', N'Đại học công nghiệp thực phẩm', N'01699857542', N'anguyen@gmail.com', N'28 Nhật Tảo', 0)
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [DanToc], [TrinhDo], [QuocTich], [NhomNganh], [NgaySinh], [GioiTinh], [CMND], [NgheNghiep], [NoiCongTac], [SDT], [Email], [DiaChi], [TrangThaiLamThe]) VALUES (N'DG00000002', N'Nguyễn Thị B', N'DT002', N'TDHV002', N'QT0002', N'NN0002', CAST(N'1995-09-09' AS Date), N'Nữ', N'273564854', N'Sinh viên HUFI', N'Đại học công nghiệp thực phẩm', N'01685547542', N'bnguyen@gmail.com', N'90 Nguyễn Hồng Đào', 0)
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [DanToc], [TrinhDo], [QuocTich], [NhomNganh], [NgaySinh], [GioiTinh], [CMND], [NgheNghiep], [NoiCongTac], [SDT], [Email], [DiaChi], [TrangThaiLamThe]) VALUES (N'DG00000003', N'Nguyễn Văn C', N'DT003', N'TDHV003', N'QT0003', N'NN0003', CAST(N'1995-08-08' AS Date), N'Nam', N'273564855', N'Sinh viên HUFI', N'Đại học công nghiệp thực phẩm', N'01685547545', N'cnguyen@gmail.com', N'80 Nguyễn Hồng Đào', 0)
INSERT [dbo].[LOAISACH] ([MaLoaiSach], [LoaiSach]) VALUES (N'TLS001', N'Sách khoa học')
INSERT [dbo].[LOAISACH] ([MaLoaiSach], [LoaiSach]) VALUES (N'TLS002', N'Sách chính trị‎')
INSERT [dbo].[LOAISACH] ([MaLoaiSach], [LoaiSach]) VALUES (N'TLS003', N'Sách địa lý‎')
INSERT [dbo].[LOAISACH] ([MaLoaiSach], [LoaiSach]) VALUES (N'TLS004', N'Sách giáo khoa')
INSERT [dbo].[LOAISACH] ([MaLoaiSach], [LoaiSach]) VALUES (N'TLS005', N'Sách lịch sử‎ ')
INSERT [dbo].[LOAISACH] ([MaLoaiSach], [LoaiSach]) VALUES (N'TLS006', N'Sách phi hư cấu‎')
INSERT [dbo].[LOAISACH] ([MaLoaiSach], [LoaiSach]) VALUES (N'TLS007', N'Sách bình luận văn học‎')
INSERT [dbo].[LOAISACH] ([MaLoaiSach], [LoaiSach]) VALUES (N'TLS008', N'Sách kinh doanh')
INSERT [dbo].[LOAISACH] ([MaLoaiSach], [LoaiSach]) VALUES (N'TLS009', N'Sách thiếu nhi‎ ')
INSERT [dbo].[LOAISACH] ([MaLoaiSach], [LoaiSach]) VALUES (N'TLS010', N'Sách thiếu niên')
INSERT [dbo].[LOAISACH] ([MaLoaiSach], [LoaiSach]) VALUES (N'TLS011', N'Sách tự lực‎ ')
INSERT [dbo].[LOAISACH] ([MaLoaiSach], [LoaiSach]) VALUES (N'TLS012', N'Sách khoa học viễn tưởng‎')
INSERT [dbo].[LOAITHE] ([MaLoaiThe], [TenLoaiThe], [PhiLamThe]) VALUES (N'LT0001', N'Thẻ Đọc', 30000)
INSERT [dbo].[LOAITHE] ([MaLoaiThe], [TenLoaiThe], [PhiLamThe]) VALUES (N'LT0002', N'Thẻ Mượn', 20000)
INSERT [dbo].[LOAITHE] ([MaLoaiThe], [TenLoaiThe], [PhiLamThe]) VALUES (N'LT0003', N'Thẻ Liên Kết', 40000)
INSERT [dbo].[LOAITHE] ([MaLoaiThe], [TenLoaiThe], [PhiLamThe]) VALUES (N'LT0004', N'Thẻ Thanh Thiếu Niên', 30000)
INSERT [dbo].[LOAITHE] ([MaLoaiThe], [TenLoaiThe], [PhiLamThe]) VALUES (N'LT0005', N'Thẻ Hội Viên Doanh Nhân', 510000)
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'MH001', N'man')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'MH002', N'sds')
INSERT [dbo].[NGONNGUSACH] ([MaNgonNgu], [NgonNgu]) VALUES (N'NNS001', N'Tiếng Anh')
INSERT [dbo].[NGONNGUSACH] ([MaNgonNgu], [NgonNgu]) VALUES (N'NNS002', N'Tiếng Pháp')
INSERT [dbo].[NGONNGUSACH] ([MaNgonNgu], [NgonNgu]) VALUES (N'NNS003', N'Tiếng Việt')
INSERT [dbo].[NGONNGUSACH] ([MaNgonNgu], [NgonNgu]) VALUES (N'NNS004', N'Tiếng Đức')
INSERT [dbo].[NGONNGUSACH] ([MaNgonNgu], [NgonNgu]) VALUES (N'NNS005', N'Tiếng Trung')
INSERT [dbo].[NGONNGUSACH] ([MaNgonNgu], [NgonNgu]) VALUES (N'NNS006', N'Tiếng Nhật')
INSERT [dbo].[NGONNGUSACH] ([MaNgonNgu], [NgonNgu]) VALUES (N'NNS007', N'Tiếng Hàn')
INSERT [dbo].[NGONNGUSACH] ([MaNgonNgu], [NgonNgu]) VALUES (N'NNS008', N'Tiếng Nga')
INSERT [dbo].[NGONNGUSACH] ([MaNgonNgu], [NgonNgu]) VALUES (N'NNS009', N'Tiếng Thái')
INSERT [dbo].[NGONNGUSACH] ([MaNgonNgu], [NgonNgu]) VALUES (N'NNS010', N'Tiếng La Tinh')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [DanToc], [TrinhDo], [NgaySinh], [GioiTinh], [SDT], [CMND], [DiaChi]) VALUES (N'NV00000001', N'Bùi Quang Thi', N'DT001', N'TDHV001', CAST(N'1996-10-10' AS Date), N'Nam', N'01699725972', N'272490174', N'28 Nhật Tảo')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [DanToc], [TrinhDo], [NgaySinh], [GioiTinh], [SDT], [CMND], [DiaChi]) VALUES (N'NV00000002', N'Bùi Quang Thiện', N'DT001', N'TDHV002', CAST(N'1996-10-10' AS Date), N'Nam', N'01699725972', N'272490174', N'28 Nhật Tảo')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [DanToc], [TrinhDo], [NgaySinh], [GioiTinh], [SDT], [CMND], [DiaChi]) VALUES (N'NV00000003', N'Bùi Thị Ánh Ngọc', N'DT001', N'TDHV003', CAST(N'1996-10-10' AS Date), N'Nữ', N'01699725972', N'272490175', N'28 Nhật Tảo')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [NhaXuatBan]) VALUES (N'NXB001', N'Nhà xuất bản Giáo dục')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [NhaXuatBan]) VALUES (N'NXB002', N'Nhà xuất bản Kim Đồng')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [NhaXuatBan]) VALUES (N'NXB003', N'Nhà xuất bản Đại học Quốc gia TpHCM')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [NhaXuatBan]) VALUES (N'NXB004', N'Nhà xuất bản Đại học Quốc gia Hà Nội')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [NhaXuatBan]) VALUES (N'NXB005', N'Nhà xuất bản Chính trị Quốc gia - Sự thật')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [NhaXuatBan]) VALUES (N'NXB006', N'Nhà xuất bản Trẻ')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [NhaXuatBan]) VALUES (N'NXB007', N'Nhà xuất bản Lao động')
INSERT [dbo].[NHOMNGANH] ([MaNhomNganh], [NhomNganh]) VALUES (N'NN0001', N'An ninh quốc phòng')
INSERT [dbo].[NHOMNGANH] ([MaNhomNganh], [NhomNganh]) VALUES (N'NN0002', N'Bưu chính viễn thông')
INSERT [dbo].[NHOMNGANH] ([MaNhomNganh], [NhomNganh]) VALUES (N'NN0003', N'Báo chí phát thanh')
INSERT [dbo].[NHOMNGANH] ([MaNhomNganh], [NhomNganh]) VALUES (N'NN0004', N'Bảo tồn bảo tàng')
INSERT [dbo].[NHOMNGANH] ([MaNhomNganh], [NhomNganh]) VALUES (N'NN0005', N'Bất động sản')
INSERT [dbo].[NHOMNGANH] ([MaNhomNganh], [NhomNganh]) VALUES (N'NN0006', N'Công nghệ hóa sinh thực phẩm')
INSERT [dbo].[NHOMNGANH] ([MaNhomNganh], [NhomNganh]) VALUES (N'NN0007', N'Công nghệ thông tin')
INSERT [dbo].[NHOMNGANH] ([MaNhomNganh], [NhomNganh]) VALUES (N'NN0008', N'Cán bộ công nhân viên chức')
INSERT [dbo].[NHOMNGANH] ([MaNhomNganh], [NhomNganh]) VALUES (N'NN0009', N'Cán bộ quản lý')
INSERT [dbo].[NHOMNGANH] ([MaNhomNganh], [NhomNganh]) VALUES (N'NN0010', N'Dịch vụ')
INSERT [dbo].[NHOMNGANH] ([MaNhomNganh], [NhomNganh]) VALUES (N'NN0011', N'Dầu khí')
INSERT [dbo].[NHOMNGANH] ([MaNhomNganh], [NhomNganh]) VALUES (N'NN0012', N'Du lịch')
INSERT [dbo].[NHOMNGANH] ([MaNhomNganh], [NhomNganh]) VALUES (N'NN0013', N'Giáo dục')
INSERT [dbo].[NHOMNHANVIEN] ([MaNhomNV], [TenNhomNV], [GhiChu]) VALUES (N'NNV0000001', N'Nhóm ADMIN', NULL)
INSERT [dbo].[NHOMNHANVIEN] ([MaNhomNV], [TenNhomNV], [GhiChu]) VALUES (N'NNV0000002', N'Nhóm Thủ Thư', NULL)
INSERT [dbo].[NHOMNHANVIEN] ([MaNhomNV], [TenNhomNV], [GhiChu]) VALUES (N'NNV0000003', N'Nhóm Nhân Viên', NULL)
INSERT [dbo].[PHANQUYENNHANVIEN] ([MaNhomNV], [MaManHinh], [XetQuyen]) VALUES (N'NNV0000001', N'MH001', 1)
INSERT [dbo].[PHANQUYENNHANVIEN] ([MaNhomNV], [MaManHinh], [XetQuyen]) VALUES (N'NNV0000001', N'MH002', 1)
INSERT [dbo].[PHANQUYENNHANVIEN] ([MaNhomNV], [MaManHinh], [XetQuyen]) VALUES (N'NNV0000002', N'MH001', 0)
INSERT [dbo].[PHANQUYENNHANVIEN] ([MaNhomNV], [MaManHinh], [XetQuyen]) VALUES (N'NNV0000002', N'MH002', 1)
INSERT [dbo].[PHANQUYENNHANVIEN] ([MaNhomNV], [MaManHinh], [XetQuyen]) VALUES (N'NNV0000003', N'MH001', 0)
INSERT [dbo].[PHANQUYENNHANVIEN] ([MaNhomNV], [MaManHinh], [XetQuyen]) VALUES (N'NNV0000003', N'MH002', 1)
INSERT [dbo].[QUOCTICH] ([MaQuocTich], [QuocTich]) VALUES (N'QT0001', N'Việt Nam  ')
INSERT [dbo].[QUOCTICH] ([MaQuocTich], [QuocTich]) VALUES (N'QT0002', N'Trung Quốc')
INSERT [dbo].[QUOCTICH] ([MaQuocTich], [QuocTich]) VALUES (N'QT0003', N'Hàn Quốc  ')
INSERT [dbo].[QUOCTICH] ([MaQuocTich], [QuocTich]) VALUES (N'QT0004', N'Mỹ        ')
INSERT [dbo].[QUOCTICH] ([MaQuocTich], [QuocTich]) VALUES (N'QT0005', N'Lào       ')
INSERT [dbo].[QUOCTICH] ([MaQuocTich], [QuocTich]) VALUES (N'QT0006', N'Thái Lan  ')
INSERT [dbo].[QUOCTICH] ([MaQuocTich], [QuocTich]) VALUES (N'QT0007', N'Campuchia ')
INSERT [dbo].[QUOCTICH] ([MaQuocTich], [QuocTich]) VALUES (N'QT0008', N'Singapore ')
INSERT [dbo].[QUOCTICH] ([MaQuocTich], [QuocTich]) VALUES (N'QT0009', N'Indonesia ')
INSERT [dbo].[QUOCTICH] ([MaQuocTich], [QuocTich]) VALUES (N'QT0010', N'Malaysia  ')
INSERT [dbo].[TACGIASACH] ([MaTacGia], [TacGia]) VALUES (N'TG001', N'Nhà văn Nguyễn Nhật Ánh')
INSERT [dbo].[TACGIASACH] ([MaTacGia], [TacGia]) VALUES (N'TG002', N'Nhà văn Trang Hạ')
INSERT [dbo].[TACGIASACH] ([MaTacGia], [TacGia]) VALUES (N'TG003', N'Tác giả Nguyễn Phong Việt')
INSERT [dbo].[TACGIASACH] ([MaTacGia], [TacGia]) VALUES (N'TG004', N'Tác giả Anh Khang')
INSERT [dbo].[TACGIASACH] ([MaTacGia], [TacGia]) VALUES (N'TG005', N'Michael Heppell')
INSERT [dbo].[TACGIASACH] ([MaTacGia], [TacGia]) VALUES (N'TG006', N'Nick Vujicic')
INSERT [dbo].[TACGIASACH] ([MaTacGia], [TacGia]) VALUES (N'TG007', N'J.K.Rowling')
INSERT [dbo].[TACGIASACH] ([MaTacGia], [TacGia]) VALUES (N'TG008', N'Stephenie Meyer')
INSERT [dbo].[TACGIASACH] ([MaTacGia], [TacGia]) VALUES (N'TG009', N'Margaret Mitchell')
INSERT [dbo].[TACGIASACH] ([MaTacGia], [TacGia]) VALUES (N'TG010', N'JD Salinger')
INSERT [dbo].[TACGIASACH] ([MaTacGia], [TacGia]) VALUES (N'TG011', N'Miguel de Cervantes')
INSERT [dbo].[TACGIASACH] ([MaTacGia], [TacGia]) VALUES (N'TG012', N'Emily Brote')
INSERT [dbo].[TAIKHOAN_NHOMNHANVIEN] ([TenDangNhap], [MaNhomNV], [GhiChu]) VALUES (N'NV00000001', N'NNV0000001', N' ')
INSERT [dbo].[TAIKHOAN_NHOMNHANVIEN] ([TenDangNhap], [MaNhomNV], [GhiChu]) VALUES (N'NV00000001', N'NNV0000003', N'')
INSERT [dbo].[TAIKHOAN_NHOMNHANVIEN] ([TenDangNhap], [MaNhomNV], [GhiChu]) VALUES (N'NV00000002', N'NNV0000002', N' ')
INSERT [dbo].[TAIKHOAN_NHOMNHANVIEN] ([TenDangNhap], [MaNhomNV], [GhiChu]) VALUES (N'NV00000002', N'NNV0000003', N'')
INSERT [dbo].[TAIKHOAN_NHOMNHANVIEN] ([TenDangNhap], [MaNhomNV], [GhiChu]) VALUES (N'NV00000003', N'NNV0000003', N' ')
INSERT [dbo].[TAIKHOANNHANVIEN] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000001', N'123456', 0)
INSERT [dbo].[TAIKHOANNHANVIEN] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000002', N'123456', 0)
INSERT [dbo].[TAIKHOANNHANVIEN] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000003', N'123456', 0)
INSERT [dbo].[THONGTINSACH] ([MaSach], [TenSach], [NgonNgu], [TheLoai], [NhaXB], [NamXB], [TacGia], [SoLuongTon], [GiaTriSach], [ThongTinSach], [MaVach]) VALUES (N'SH00000001', N'Đắc Nhân Tâm', N'NNS003', N'TLS001', N'NXB001', 2010, N'TG001', 100, 100000, N'Đắc nhân tâm – How to win friends and Influence People  của Dale Carnegie là quyển sách nổi tiếng nhất, bán chạy nhất và có tầm ảnh hưởng nhất của mọi thời đại. Tác phẩm đã được chuyển ngữ sang hầu hết các thứ tiếng trên thế giới và có mặt ở hàng trăm quốc gia. 

Đây là quyển sách duy nhất về thể loại self-help liên tục đứng đầu danh mục sách bán chạy nhất (best-selling Books) do báo The New York Times bình chọn suốt 10 năm liền. Riêng bản tiếng Anh của sách đã bán được hơn 15 triệu bản trên thế giới. Tác phẩm có sức lan toả vô cùng rộng lớn – dù bạn đi đến bất cứ nơi đâu, bất kỳ quốc gia nào cũng đều có thể nhìn thấy. Tác phẩm được đánh giá là quyển sách đầu tiên và hay nhất, có ảnh hưởng làm thay đổi cuộc đời của hàng triệu người trên thế giới.

Không còn nữa khái niệm giới hạn, Đắc Nhân Tâm là nghệ thuật thu phục lòng người, là làm cho tất cả mọi người yêu mến mình. Đắc nhân tâm và cái Tài trong mỗi người chúng ta. Đắc Nhân Tâm trong ý nghĩa đó cần được thụ đắc bằng sự hiểu rõ bản thân, thành thật với chính mình, hiểu biết và quan tâm đến những người xung quanh để nhìn ra và khơi gợi những tiềm năng ẩn khuất nơi họ, giúp họ phát triển lên một tầm cao mới. Đây chính là nghệ thuật cao nhất về con người và chính là ý nghĩa sâu sắc nhất đúc kết từ những nguyên tắc vàng của Dale Carnegie.

Quyển sách Đắc nhắn tâm là cuốn sách “đầu tiên và hay nhất mọi thời đại về nghệ thuật giao tiếp và ứng xử”, quyển sách đã từng mang đến thành công và hạnh phúc cho hàng triệu người trên khắp thế giới.


Đắc Nhân Tâm là cuốn sách gối đầu giường về đối nhân xử thế.', NULL)
INSERT [dbo].[THONGTINSACH] ([MaSach], [TenSach], [NgonNgu], [TheLoai], [NhaXB], [NamXB], [TacGia], [SoLuongTon], [GiaTriSach], [ThongTinSach], [MaVach]) VALUES (N'SH00000002', N'Người Gieo Hy Vọng', N'NNS003', N'TLS001', N'NXB001', 2010, N'TG001', 100, 90000, N'Ở bất cứ quốc gia nào, nghề giáo luôn là nghề cao quý nhất. Người Gieo Hy Vọng là câu chuyện về một cô giáo với những học sinh cá biệt - một đề tài hoàn toàn không mới trong văn chương hay điện ảnh. Nhưng, bất chấp sự quen thuộc đó, Người Gieo Hy Vọng vẫn làm người đọc rung động khi sự chân thành, tình yêu thương vượt qua những rào cản của thầy trò để thấu hiểu và chia sẻ.

Giá trị sống vốn luôn tiềm ẩn trong mỗi cuộc đời, Người Gieo Hy Vọng có cái tâm thắp sáng phần lẩn khuất ấy, để đem lại cho cuộc đời những con người mang hy vọng.

Người Gieo Hy Vọng như một cánh cửa mở toang lối vào lớp học có nhiều con người, nhiều tính cách, nhiều cảm xúc. Như thế, giáo dục là một chặng đường mà trên chặng đường ấy, những người thầy vẫn cần mẫn dắt tay những đứa trẻ, chậm rãi bước đi với tấm lòng nhân hậu.

©

Người gieo hy vọng là cuốn sách có giá trị cho nghành giáo dục.

Người gieo hy vọng là những gì chúng ta cần suy nghĩ và học tập, cần biết và làm, cần thay đổi và góp phần thay đổi cách giáo dục

Người gieo hy vọng bắt đầu từ ERIN GRUWELL. Cô mới tốt nghiệp đại học, về làm giáo viên ở một trường trung học. Vượt qua những trở ngại ban đầu trong việc giao tiếp với những học sinh ngỗ nghịch - tất cả những học sinh này đều có hoàn cảnh gia đình đặc biệt éo le hoặc cảnh ngộ bất hạnh của cá nhân, cô khuyến khích họ bày tỏ nỗi niềm của mình qua những trang nhật kí, giúp họ nhận ra những giá trị sống vẫn còn tiềm ẩn, cứu họ khỏi nguy cơ sa lầy vào những tệ nạn xã hội hoặc lâm vào hoàn cảnh bi đát hơn, khiến họ thực sự trưởng thành và có vị thế trong xã hội. Cô đã gọi những học sinh cá biệt này là Những nhà văn Tự do.', NULL)
INSERT [dbo].[THONGTINSACH] ([MaSach], [TenSach], [NgonNgu], [TheLoai], [NhaXB], [NamXB], [TacGia], [SoLuongTon], [GiaTriSach], [ThongTinSach], [MaVach]) VALUES (N'SH00000003', N'Lược Sử Vạn Vật', N'NNS003', N'TLS001', N'NXB001', 2010, N'TG001', 100, 90000, N'Trong cuốn Lịch Sử Vạn Vật, tác giả Bill Bryson phải đối mặt với thử thách lớn nhất: tìm hiểu – và nếu có thể trả lời – những vấn đề to lớn nhất, xa xưa nhất mà chúng ta đặt ra về vũ trụ và bản thân con người. Từ Big Bang cho đến sự xuất hiện của nền văn minh, Bryson tìm hiểu tại sao chúng ta biến đổi từ cái hư vô thành cái có thực, loài người xuất hiện như thế nào. Để làm được điều này, ông phải dày công tìm đến các nhà khoa học nổi tiếng nhất thế giới thuộc các ngành: khảo cổ học, cổ sinh vật học, vật lý học, thiên văn học, nhân loại học, toán học; tại các văn phòng, trạm và phòng thí nghiệm của họ. Lịch Sử Vạn Vật là tập hợp toàn bộ cuộc điều nghiên này, đây là cuộc hành trình thú vị nhất trong lĩnh vực kiến thức nhân loại và chỉ Bill Bryson mới có thể làm được điều này.

“Đây là những đáp án cho những câu hỏi ngớ ngẩn nhất mà bạn thường ngại đặt ra tại các lớp học... Bryson giúp nội dung cuốn sách trở nên dí dỏm và sâu sắc hơn...”

- People​


“Lịch Sử Vạn Vật tập hợp những hiểu biết tuyệt vời nhất, và sẽ tốt hơn cho công tác giảng dạy tại nhà trường nếu cuốn sách này được đưa vào chương trình giảng dạy”.', NULL)
INSERT [dbo].[TRINHDO] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'TDHV001', N'Sau đại học')
INSERT [dbo].[TRINHDO] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'TDHV002', N'Đại học')
INSERT [dbo].[TRINHDO] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'TDHV003', N'Cao đẳng')
INSERT [dbo].[TRINHDO] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'TDHV004', N'Trung Cấp')
INSERT [dbo].[TRINHDO] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'TDHV005', N'THPT')
INSERT [dbo].[TRINHDO] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'TDHV006', N'THCS')
INSERT [dbo].[TRINHDO] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'TDHV007', N'Tiểu học')
INSERT [dbo].[TRINHDO] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'TDHV008', N'Không')
ALTER TABLE [dbo].[CT_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUON_PHIEUMUON] FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[PHIEUMUON] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[CT_PHIEUMUON] CHECK CONSTRAINT [FK_CT_PHIEUMUON_PHIEUMUON]
GO
ALTER TABLE [dbo].[CT_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUON_THONGTINSACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[THONGTINSACH] ([MaSach])
GO
ALTER TABLE [dbo].[CT_PHIEUMUON] CHECK CONSTRAINT [FK_CT_PHIEUMUON_THONGTINSACH]
GO
ALTER TABLE [dbo].[CT_PHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUTRA_PHIEUTRA] FOREIGN KEY([MaPhieuTra])
REFERENCES [dbo].[PHIEUTRA] ([MaPhieuTra])
GO
ALTER TABLE [dbo].[CT_PHIEUTRA] CHECK CONSTRAINT [FK_CT_PHIEUTRA_PHIEUTRA]
GO
ALTER TABLE [dbo].[CT_PHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUTRA_THONGTINSACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[THONGTINSACH] ([MaSach])
GO
ALTER TABLE [dbo].[CT_PHIEUTRA] CHECK CONSTRAINT [FK_CT_PHIEUTRA_THONGTINSACH]
GO
ALTER TABLE [dbo].[CT_XULYVIPHAM]  WITH CHECK ADD  CONSTRAINT [FK_CT_XULYVIPHAM_HANHVIVIPHAM] FOREIGN KEY([HanhViViPham])
REFERENCES [dbo].[HANHVIVIPHAM] ([MaHanhVi])
GO
ALTER TABLE [dbo].[CT_XULYVIPHAM] CHECK CONSTRAINT [FK_CT_XULYVIPHAM_HANHVIVIPHAM]
GO
ALTER TABLE [dbo].[CT_XULYVIPHAM]  WITH CHECK ADD  CONSTRAINT [FK_CT_XULYVIPHAM_THONGTINSACH] FOREIGN KEY([MaSachViPham])
REFERENCES [dbo].[THONGTINSACH] ([MaSach])
GO
ALTER TABLE [dbo].[CT_XULYVIPHAM] CHECK CONSTRAINT [FK_CT_XULYVIPHAM_THONGTINSACH]
GO
ALTER TABLE [dbo].[CT_XULYVIPHAM]  WITH CHECK ADD  CONSTRAINT [FK_CT_XULYVIPHAM_XULYVIPHAM] FOREIGN KEY([MaViPham])
REFERENCES [dbo].[XULYVIPHAM] ([MaViPham])
GO
ALTER TABLE [dbo].[CT_XULYVIPHAM] CHECK CONSTRAINT [FK_CT_XULYVIPHAM_XULYVIPHAM]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [FK_DOCGIA_DANTOC] FOREIGN KEY([DanToc])
REFERENCES [dbo].[DANTOC] ([MaDanToc])
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [FK_DOCGIA_DANTOC]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [FK_DOCGIA_NHOMNGANH] FOREIGN KEY([NhomNganh])
REFERENCES [dbo].[NHOMNGANH] ([MaNhomNganh])
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [FK_DOCGIA_NHOMNGANH]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [FK_DOCGIA_QUOCTICH] FOREIGN KEY([QuocTich])
REFERENCES [dbo].[QUOCTICH] ([MaQuocTich])
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [FK_DOCGIA_QUOCTICH]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [FK_DOCGIA_TRINHDO] FOREIGN KEY([TrinhDo])
REFERENCES [dbo].[TRINHDO] ([MaTrinhDo])
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [FK_DOCGIA_TRINHDO]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_DANTOC] FOREIGN KEY([DanToc])
REFERENCES [dbo].[DANTOC] ([MaDanToc])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_DANTOC]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_TRINHDO] FOREIGN KEY([TrinhDo])
REFERENCES [dbo].[TRINHDO] ([MaTrinhDo])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_TRINHDO]
GO
ALTER TABLE [dbo].[PHANQUYENNHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHANQUYENNHANVIEN_MANHINH] FOREIGN KEY([MaManHinh])
REFERENCES [dbo].[MANHINH] ([MaManHinh])
GO
ALTER TABLE [dbo].[PHANQUYENNHANVIEN] CHECK CONSTRAINT [FK_PHANQUYENNHANVIEN_MANHINH]
GO
ALTER TABLE [dbo].[PHANQUYENNHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHANQUYENNHANVIEN_NHOMNHANVIEN] FOREIGN KEY([MaNhomNV])
REFERENCES [dbo].[NHOMNHANVIEN] ([MaNhomNV])
GO
ALTER TABLE [dbo].[PHANQUYENNHANVIEN] CHECK CONSTRAINT [FK_PHANQUYENNHANVIEN_NHOMNHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_NHANVIEN] FOREIGN KEY([NhanVienLap])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_THETHUVIEN] FOREIGN KEY([SoTheDocGia])
REFERENCES [dbo].[THETHUVIEN] ([SoThe])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_THETHUVIEN]
GO
ALTER TABLE [dbo].[PHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRA_NHANVIEN] FOREIGN KEY([NhanVienLap])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUTRA] CHECK CONSTRAINT [FK_PHIEUTRA_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRA_PHIEUMUON] FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[PHIEUMUON] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[PHIEUTRA] CHECK CONSTRAINT [FK_PHIEUTRA_PHIEUMUON]
GO
ALTER TABLE [dbo].[PHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRA_THETHUVIEN] FOREIGN KEY([SoTheDocGia])
REFERENCES [dbo].[THETHUVIEN] ([SoThe])
GO
ALTER TABLE [dbo].[PHIEUTRA] CHECK CONSTRAINT [FK_PHIEUTRA_THETHUVIEN]
GO
ALTER TABLE [dbo].[TAIKHOAN_NHOMNHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_NHOMNHANVIEN_NHOMNHANVIEN] FOREIGN KEY([MaNhomNV])
REFERENCES [dbo].[NHOMNHANVIEN] ([MaNhomNV])
GO
ALTER TABLE [dbo].[TAIKHOAN_NHOMNHANVIEN] CHECK CONSTRAINT [FK_TAIKHOAN_NHOMNHANVIEN_NHOMNHANVIEN]
GO
ALTER TABLE [dbo].[TAIKHOAN_NHOMNHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_NHOMNHANVIEN_TAIKHOANNHANVIEN] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TAIKHOANNHANVIEN] ([TenDangNhap])
GO
ALTER TABLE [dbo].[TAIKHOAN_NHOMNHANVIEN] CHECK CONSTRAINT [FK_TAIKHOAN_NHOMNHANVIEN_TAIKHOANNHANVIEN]
GO
ALTER TABLE [dbo].[TAIKHOANNHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOANNHANVIEN_NHANVIEN] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[TAIKHOANNHANVIEN] CHECK CONSTRAINT [FK_TAIKHOANNHANVIEN_NHANVIEN]
GO
ALTER TABLE [dbo].[THETHUVIEN]  WITH CHECK ADD  CONSTRAINT [FK_THETHUVIEN_DOCGIA] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DOCGIA] ([MaDocGia])
GO
ALTER TABLE [dbo].[THETHUVIEN] CHECK CONSTRAINT [FK_THETHUVIEN_DOCGIA]
GO
ALTER TABLE [dbo].[THETHUVIEN]  WITH CHECK ADD  CONSTRAINT [FK_THETHUVIEN_LOAITHE] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAITHE] ([MaLoaiThe])
GO
ALTER TABLE [dbo].[THETHUVIEN] CHECK CONSTRAINT [FK_THETHUVIEN_LOAITHE]
GO
ALTER TABLE [dbo].[THONGTINSACH]  WITH CHECK ADD  CONSTRAINT [FK_THONGTINSACH_LOAISACH] FOREIGN KEY([TheLoai])
REFERENCES [dbo].[LOAISACH] ([MaLoaiSach])
GO
ALTER TABLE [dbo].[THONGTINSACH] CHECK CONSTRAINT [FK_THONGTINSACH_LOAISACH]
GO
ALTER TABLE [dbo].[THONGTINSACH]  WITH CHECK ADD  CONSTRAINT [FK_THONGTINSACH_NGONNGUSACH] FOREIGN KEY([NgonNgu])
REFERENCES [dbo].[NGONNGUSACH] ([MaNgonNgu])
GO
ALTER TABLE [dbo].[THONGTINSACH] CHECK CONSTRAINT [FK_THONGTINSACH_NGONNGUSACH]
GO
ALTER TABLE [dbo].[THONGTINSACH]  WITH CHECK ADD  CONSTRAINT [FK_THONGTINSACH_NHAXUATBAN] FOREIGN KEY([NhaXB])
REFERENCES [dbo].[NHAXUATBAN] ([MaNhaXuatBan])
GO
ALTER TABLE [dbo].[THONGTINSACH] CHECK CONSTRAINT [FK_THONGTINSACH_NHAXUATBAN]
GO
ALTER TABLE [dbo].[THONGTINSACH]  WITH CHECK ADD  CONSTRAINT [FK_THONGTINSACH_TACGIASACH] FOREIGN KEY([TacGia])
REFERENCES [dbo].[TACGIASACH] ([MaTacGia])
GO
ALTER TABLE [dbo].[THONGTINSACH] CHECK CONSTRAINT [FK_THONGTINSACH_TACGIASACH]
GO
ALTER TABLE [dbo].[XULYVIPHAM]  WITH CHECK ADD  CONSTRAINT [FK_XULYVIPHAM_NHANVIEN] FOREIGN KEY([NhanVienLap])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[XULYVIPHAM] CHECK CONSTRAINT [FK_XULYVIPHAM_NHANVIEN]
GO
ALTER TABLE [dbo].[XULYVIPHAM]  WITH CHECK ADD  CONSTRAINT [FK_XULYVIPHAM_PHIEUTRA] FOREIGN KEY([MaPhieuTra])
REFERENCES [dbo].[PHIEUTRA] ([MaPhieuTra])
GO
ALTER TABLE [dbo].[XULYVIPHAM] CHECK CONSTRAINT [FK_XULYVIPHAM_PHIEUTRA]
GO
ALTER TABLE [dbo].[XULYVIPHAM]  WITH CHECK ADD  CONSTRAINT [FK_XULYVIPHAM_THETHUVIEN] FOREIGN KEY([DocGiaViPham])
REFERENCES [dbo].[THETHUVIEN] ([SoThe])
GO
ALTER TABLE [dbo].[XULYVIPHAM] CHECK CONSTRAINT [FK_XULYVIPHAM_THETHUVIEN]
GO
USE [master]
GO
ALTER DATABASE [QL_DocGia_KhoaHocTongHopTPHCM] SET  READ_WRITE 
GO
