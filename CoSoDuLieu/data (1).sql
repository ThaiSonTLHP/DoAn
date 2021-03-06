USE [master]
GO
/****** Object:  Database [QuanLyBatDongSan]    Script Date: 6/13/2020 9:17:39 PM ******/
CREATE DATABASE [QuanLyBatDongSan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBatDongSan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyBatDongSan.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyBatDongSan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyBatDongSan_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyBatDongSan] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBatDongSan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBatDongSan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBatDongSan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBatDongSan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyBatDongSan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBatDongSan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyBatDongSan] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBatDongSan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBatDongSan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBatDongSan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBatDongSan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyBatDongSan] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyBatDongSan] SET QUERY_STORE = OFF
GO
USE [QuanLyBatDongSan]
GO
/****** Object:  Table [dbo].[GoiTin]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoiTin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[MucPhi] [float] NOT NULL,
 CONSTRAINT [PK_GoiTin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HinhAnh]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhAnh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[Anh] [varbinary](max) NULL,
	[AnhChinh] [bit] NOT NULL,
	[TinBatDongSan] [int] NULL,
	[TinTuc] [int] NULL,
 CONSTRAINT [PK_HinhAnh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Huong]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Huong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NULL,
 CONSTRAINT [PK_Huong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiBatDongSan]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiBatDongSan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiBatDongSan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTaiKhoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[ChucNang] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTinBatDongSan]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTinBatDongSan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiTinBatDongSan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTinTuc]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTinTuc](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[MoTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiTinTuc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LuuTinBatDongSan]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuuTinBatDongSan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TaiKhoan] [int] NOT NULL,
	[TinBatDongSan] [int] NOT NULL,
 CONSTRAINT [PK_LuuTinBatDongSan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MucDienTich]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MucDienTich](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[Min] [float] NOT NULL,
	[Max] [float] NOT NULL,
 CONSTRAINT [PK_MucDienTich] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MucGia]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MucGia](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[Min] [float] NOT NULL,
	[Max] [float] NOT NULL,
 CONSTRAINT [PK_MucGia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanHuyen]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanHuyen](
	[ID] [nvarchar](450) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[Loai] [nvarchar](max) NULL,
	[TinhThanh] [nvarchar](max) NULL,
 CONSTRAINT [PK_QuanHuyen] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MatKhau] [nvarchar](max) NULL,
	[Ten] [nvarchar](max) NULL,
	[GioiTinh] [bit] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[SoDienThoai] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[LoaiTaiKhoan] [int] NOT NULL,
	[SoDuVi] [float] NOT NULL,
	[XacThuc] [bit] NOT NULL,
	[AnhDaiDien] [varbinary](max) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinBatDongSan]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinBatDongSan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoaiTin] [int] NOT NULL,
	[NgayDang] [datetime2](7) NOT NULL,
	[TrangThaiGiaoDich] [bit] NOT NULL,
	[TrangThaiDuyet] [bit] NOT NULL,
	[TrangThaiXacNhan] [bit] NOT NULL,
	[NguoiDang] [int] NOT NULL,
	[GoiTin] [int] NOT NULL,
	[LoaiBatDongSan] [int] NOT NULL,
	[TinhThanh] [nvarchar](max) NULL,
	[QuanHuyen] [nvarchar](max) NULL,
	[Gia] [nvarchar](max) NULL,
	[MucGia] [int] NOT NULL,
	[DienTich] [nvarchar](max) NULL,
	[MucDienTich] [int] NOT NULL,
	[Huong] [int] NOT NULL,
	[MoTa] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TinBatDongSan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinTuc]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinTuc](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TieuDe] [nvarchar](max) NULL,
	[NgayDang] [datetime2](7) NOT NULL,
	[NguoiDang] [int] NOT NULL,
	[NoiDung] [nvarchar](max) NULL,
	[LoaiTinTuc] [int] NOT NULL,
 CONSTRAINT [PK_TinTuc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhThanh]    Script Date: 6/13/2020 9:17:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhThanh](
	[ID] [nvarchar](450) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[Loai] [nvarchar](max) NULL,
 CONSTRAINT [PK_TinhThanh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[GoiTin] ON 


use [aspnet-BatDongSanId-94F5C9D4-1F25-4019-BEB2-B740BB8A9635]

SET IDENTITY_INSERT [dbo].[TinBatDongSan] ON 
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (7, 1, CAST(N'2020-05-20T17:06:07.7766667' AS DateTime2), 0, 1, 1, 4, 3, 1, N'01', N'001', N'300000000', 2, N'35', 1, 1, N'Cần bán nhà khu vực quận Ba Đình')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (8, 1, CAST(N'2020-05-23T20:12:01.4800000' AS DateTime2), 0, 1, 0, 6, 1, 1, N'01', N'001', N'300000000', 2, N'35', 1, 2, N'Cần bán nhà khu vực quận Ba Đình')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (9, 3, CAST(N'2020-05-23T22:48:06.8333333' AS DateTime2), 0, 1, 1, 6, 1, 1, N'01', N'004', N'300000000', 2, N'35', 1, 1, N'Cần bán nhà khu vực quận Ba Đình')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (10, 2, CAST(N'2020-05-31T21:56:01.1133333' AS DateTime2), 0, 1, 0, 4, 3, 1, N'87', N'867', N'400000000', 2, N'35', 1, 2, N'Cần bán nhà khu vực quận Ba Đình')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (12, 1, CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), 0, 1, 1, 19, 2, 2, N'TP Hồ Chí Minh', N'Quận 10', N'16400000000', 18, N'68', 3, 4, N'Gia đình xuất cảnh bán gấp nhà góc 2 mặt tiền đường Hồ Thị Kỷ và Hùng Vương, nhà tọa lạc ngay vị trí đẹp nhất đường Hồ Thị Kỷ đoạn đường trước nhà 12m có quy hoạch làm chợ hoa lớn nhất Sài Gòn thí điểm du lịch hàng đầu thành phố.
DT: 14 x 4m, nhà công nhận hết không lộ giới góc 2 mặt tiền thoáng mát.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (13, 1, CAST(N'2020-06-10T00:00:00.0000000' AS DateTime2), 0, 1, 1, 20, 1, 5, N'Lâm Đồng', N'Đà Lạt', N'25000000000', 19, N'115.67', 6, 2, N'Vị trí: trung tâm đắc địa nhất thành phố, ngay chợ Đà Lạt, Hồ Xuân Hương, khách sạn Ngọc Lan...view bờ hồ đẹp và thoáng mát.
- Diện tích: 115.67m2; diện tích khuôn viên đất có thể sử dụng thực tế lên đến 119 m2, mặt tiền 6.21m nở hậu 6.58m. Đã có giấy phép xây dựng với mật độ xây dựng 100% và diện tích sử dụng 592 m2 gồm 1 trệt + 4 lầu + áp mái (chưa kể hầm).
- Hướng: MT hướng Nam, lô đất chếch nhẹ hướng Tây Nam không đáng kể nên hợp mệnh Đông tứ trạch.
- Lợi thế : 2 mặt tiền đường và hẻm oto sau lưng đất. Phù hợp kinh doanh khách sạn, cà phê, văn phòng...')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (16, 1, CAST(N'2020-06-10T00:00:00.0000000' AS DateTime2), 0, 1, 1, 21, 1, 1, N'TP Hồ Chí Minh', N'Thủ Đức', N'1850000000', 15, N'62', 3, 6, N'Mới bàn giao, nhà mới tinh như hình, nội thất cực xịn chờ bạn sở hữu đây. Ngân hàng hỗ trợ vay mua nhà.
Ngân hàng Agribank cho vay 70% trên giá trị HĐMB gốc. Lãi suất ưu đãi năm đầu 7.9%/năm, các năm sau 10.5 - 11%/năm.
- Hồ sơ cần chuẩn bị: Bảng sao kê lương 6 tháng gần nhất, CMND, hộ khẩu, các hồ sơ tài liệu liên quan đến BĐS và các giấy tờ chứng minh thu nhập khác (nếu có).')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (17, 1, CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), 0, 1, 1, 22, 2, 4, N'TP Hồ Chí Minh', N'Quận 12', N'3750000000', 5, N'50', 2, 5, N'Cần bán nhà 2 lầu, 1 trệt, cách Quốc Lộ 1A 500m, trường đại học Nguyễn Tất Thành, khu dân cư đông đúc an ninh, bờ sông Sài Gòn, đường rộng 20m, thuận tiện đi các quận trung tâm (Tặng toàn bộ nội thất).
Thương lượng nhanh bớt lộc.
Sổ hồng bao sang tên.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (18, 2, CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), 0, 1, 1, 23, 1, 1, N'77', N'751', N'16000000/ tháng', 7, N'52', 3, 4, N'Siêu phẩm Hồ Tràm Complex mang đến không gian sống tràn đầy năng lượng với gió và biển tươi mát. Với Hồ Tràm Complex quý khách hàng đang sở hữu kênh đầu tư khôn ngoan cả về tài sản lẫn sức khỏe. Đó là món quà vô giá và ý nghĩa nhất cuộc sống bạn có được.
Tọa lạc tại vị trí Hồ Tràm Xuyên Mộc, Bà Rịa Vũng Tàu ngay mặt tiền QL51 thừa hưởng trọn vẹn lợi thế ưu đãi từ thiên nhiên và khu phức hợp Resort nghỉ dưỡng 5* như: The Ho Tram Strip, Sông Ray Resort. VietsowPetro, Hồ Tràm Casino,..
Tổng quan dự án Ho Tram Complex.
Tên dự án: Ho Tram Complex.
Chủ đầu tư: Công ty TNHH Du lịch Minh Tuấn Sông Ray.
Đơn vị phát triển dự án: Hưng Thịnh Land.
Đơn vị phân phối độc quyền: PropertyX.
Tổng thầu xây dựng: Hưng Thịnh Incons.
Vị trí: Đường Ven Biển, Xã Phước Thuận, Huyện Xuyên Mộc, Tỉnh Bà Rịa Vũng Tàu.
Tổng diện tích: 75,459m2.
Số Block: 7 block.
Số tầng: 21 tầng.
Tổng số căn hộ: 3292 căn. Đối với người Việt Nam: Sổ hồng sở hữu vĩnh viễn.
Đối với người nước ngoài: Sở hữu 50 năm.
Bàn giao: Nội thất hoàn thiện cơ bản 70%, tặng full bộ bếp cao cấp Malloca.
Tiến độ thanh toán dự án Ho Tram Complex.
Ký HĐ thanh toán đợt 1 chỉ 8.5%.
Thanh toán trả chậm trong vòng 45 tháng không lãi suất.
Trả góp theo từng đợt 45 ngày chỉ 1.5%.
Chiết khấu hấp dẫn cho khách giữ chỗ trước từ 3% - 18%.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (19, 1, CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), 0, 1, 1, 24, 1, 1, N'TP Hồ Chí Minh', N'Quận 8', N'2230000000', 16, N'62', 3, 3, N'Chính chủ cần bán gấp căn hộ The Pegasuite, tầng trung, view thoáng, 2 phòng ngủ.
Căn hộ được trang bị đầy đủ nội thất cao cấp, an ninh 24/24.
Tiện ích đầy đủ: Sân vườn, công viên, phố đi bộ, siêu thị, gym, cafe, quán ăn, hồ bơi,...')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (20, 1, CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), 0, 1, 1, 25, 1, 7, N'75', N'742', N'650000000', 13, N'1000', 11, 2, N'Chính chủ gửi bán lô đất CLN ngang 30 dài 32
VỊ TRÍ: - Lô đất vuông vức cao ráo nằm tãi xã Phước Khánh huyện Nhơn Trạch.
-Cách đường Cao Tốc Bến Lức Long Thành và đường Cát Lái chỉ 1km
- Khu vực rất thuận tiện di chuyển, tương lai khi có cầu di chuyển về Q2, Q9 chỉ mất 15p. PHÁP LÝ: - Sổ hồng, pháp lý an toàn, không tranh chấp. - Mua bán với chính chủ, công chứng trong ngày.
Đất Phước Khánh Nhơn Trạch
Đa dạng diện tích và thể loại phụ hợp đầu tư lâu dài. lướt sóng
Bán lô nào là có sổ sẵn cọc là nhận ngay sổ về nhà
Gần các công trình trọng điểm Quốc Gia
Sân Bay Long Thành. Cầu Cát Lái. Đường Vành Đai 3. Cao Tốc Bến Lức Long Thành.
Sát bên Cụm KCN Ông Kèo rộng 855ha của xã Phước Khánh.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (21, 1, CAST(N'2020-06-03T00:00:00.0000000' AS DateTime2), 0, 1, 1, 26, 1, 4, N'TP Hồ Chí Minh', N'Quận 10', N'12500000000', 18, N'99', 5, 3, N'Chính chủ bán nhà HXH 196/22 Tô hiến Thành, f15, q10.
Dt: Chữ L (99,2 m2) nhà 1 trệt, 2 lầu, 1 trần áp mái.
Nhà có: 5 PN, 4 toilet, 1 phòng thờ, 2 sân thượng trồng rau xanh.
Giá 12.5 tỷ (thương lượng).
Nhà gần chợ thuốc tây, tiện cho việc kinh doanh và cho thuê.
Khu vực an ninh, đông dân cư.
Có nhiều tiện ích xung quanh như trường học, siêu thị, bệnh viện, . . .')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (22, 1, CAST(N'2020-06-04T00:00:00.0000000' AS DateTime2), 0, 1, 1, 27, 1, 5, N'Bình Định', N'Quy Nhơn', N'1800000000', 15, N'180', 7, 3, N'Chính chủ bán 2 lô đất sổ đỏ liền kề mặt phố Võ Thị Yến (thuộc khu đô thị - dịch vụ - du lịch phía tây đường An Dương Vương), phường Nguyễn Văn Cừ, thành phố Quy Nhơn, tỉnh Bình Định.

Tổng diện tích là 180m2, mặt tiền 10m, hướng Đông Nam, ngay cạnh khu quần thể du lịch nghỉ dưỡng FLC Seatower Quy Nhơn, nơi khu thu hút rất nhiều khách du lịch.

Vị trí cực đẹp cách biển 200m đối diện khách sạn Hải Âu. Đây là khu vực mang lại tỷ suất lợi nhuận rất cao trong thời gian ngắn tới.
')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1011, 1, CAST(N'2020-06-12T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1015, 1, 5, N'Bình Định', N'Quy Nhơn', N'1500000000', 15, N'80', 5, 5, N'Chính chủ cần bán lô đất nền Mặt tiền Ql 19B.
Diện tích lô đất: 5x16m.
Giá 18 triệu/m2.
Đất sổ đỏ riêng biệt')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1012, 1, CAST(N'2020-06-12T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1016, 1, 4, N'Hà Nội', N'Quận Tây Hồ', N'5300000000', 17, N'56.5', 2, 3, N'Chính chủ cần bán nhà tại AN DƯƠNG VƯƠNG - TÂY HỒ - HÀ NỘI, HƯỚNG BẮC Ô TÔ SEDAN ĐỖ CỬA diện tích 56,5m2 x 5,5 tầng = 300m2, móng thi công cho nhà 7 tầng, thiết kế Châu Âu hiện đại, có thang máy siêu vip, đầy đủ tiện nghi, nội thất hiện đại, khách chỉ việc mang quần áo vào ở, xe ô tô đỗ cửa, xây mới gồm:
- Tầng 1: 1 gara ô tô - 1 phòng ngủ cho giúp việc.
- Tầng 2: 1 phòng khách - 1 phòng ngủ.
- Tầng 3: 1 phòng ngủ master - 1 phòng ngủ em bé.
- Tầng 4: 2 phòng ngủ.
- Tầng 5: 1 phòng bếp - 1 phòng sân phơi, bếp ngoài trời.
- Tum: Vườn rau.
Vị trí gần trường cấp 1, cấp 2, cấp 3 Tây Hồ, gần chợ, tiếp giáp khu đô thị Ciputra và tổ hợp Sunshine Tây Hồ đẳng cấp, khu vực có không khí trong lành nhất thủ đô. Thông tin pháp lý: Sổ đỏ chính chủ.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1013, 1, CAST(N'2020-06-12T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1017, 1, 4, N'TP Hồ Chí Minh', N'Quận Tân Phú', N'5100000000', 17, N'44', 2, 4, N'Các ưu điểm nổi bật của nhà chính chủ bán:
- Nhà thiết kế đẹp, xây dựng chắc chắn, phong cách hiện đại, vật liệu chuẩn cao cấp để ở.
- Không gian rộng rãi, thoáng mát
- Hệ thống điện nước chuẩn, có hệ thống nước nóng năng lượng mặt trời
- Nhà 4 tầng gồm 3 phòng ngủ, một phòng khách, một lửng, một bếp, 2 nhà kho, 1 phòng thuê, 1 sân thượng.
- Sàn gỗ căm xe, cầu thang gỗ cam xe loại 1

Vị trí:
- Ngay khu chợ vải Lê Văn Phan
- Đi bộ 5 phút ra ngay các trường điểm: THCS Lê Anh Xuân và THPT Trần Phú (trường cấp 2 và cấp 3 điểm của quận Tân Phú và Hồ Chí Minh)
- Nhà hướng Đông Nam
- Gần UBND phường Phú Thọ Hòa
- Gần Công an Phường Phú Thọ Hòa - Rất an ninh
- Hẻm xe tải lớn ra vào thoải mái
- Hàng xóm trí thức, thân thiện.

Nhà hiện đang cho một công ty nội thất thuê làm kho nội thất và cho thuê đặt trạm viễn thông, mỗi tháng thu nhập 15tr/tháng ngay cả thời buổi Covid như thế này.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1014, 1, CAST(N'2020-06-10T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1018, 1, 1, N'TP Hồ Chí Minh', N'Quận 7', N'4490000000', 16, N'98', 5, 1, N'Cần tiền nhanh bán gấp căn hộ Hưng Phúc, Phú Mỹ Hưng, Q7.
Căn góc 3 mặt tiền sông và biệt thự.
Nằm ngay trung tâm Phú Mỹ Hưng, phía sau lưng là khu biệt thự trăm tỷ.
Lầu 17 cao, không che view về sau này, nhà luôn đón gió mát.
Giao thô.
Diện tích sàn 98m2 - 3PN và diện tích ô đậu xe 12,5m2 đã mua vĩnh viễn (phải có suất mới mua được, có thể cho thuê lại 2tr/tháng nếu không sử dụng), đã ra sổ.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1015, 1, CAST(N'2020-06-09T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1019, 1, 1, N'TP Hồ Chí Minh', N'Quận Tân Bình', N'3900000000', 16, N'73.6', 5, 6, N'Căn hộ mặt tiền Phổ Quang Novaland - căn hộ The Botanica, view sân bay siêu đẹp
- Free hồ bơi và phòng tập gym, hầm đậu xe hơi, công viên trẻ em, siêu thị.
- View sân bay, lầu 9.
- 1PK, 2PN, 2 ban công.
- Full nội thất, máy rửa chén mini, lò viba, tủ lạnh 2 cửa âm 21 độ, Ti Vi , khóa từ, xách vali ở ngay.
- Giá: 3 tỷ 9, còn thương lượng thêm cho khách thiện chí. Giao dịch nhanh')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1016, 1, CAST(N'2020-06-09T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1020, 1, 1, N'Hà Nội', N'Quận Hà Đông', N'3350000000', 16, N'134', 6, 3, N'Chính chủ bán căn hộ cao cấp Hyundai Hillstate 134m2 3 phòng ngủ, 2 toilet, 1 phòng khách, 1 bếp. Nội thất cơ bản: Tủ, trần thạch cao, rèm, 5 điều hoà, bếp hồng ngoại, đèn chùm,...')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1017, 1, CAST(N'2020-06-10T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1021, 1, 5, N'77', N'750', N'6680000000', 17, N'1869', 11, 4, N'Bán gấp lô đất đẹp cách dự án Vin Group xã Bình Ba, H. Châu Đức, BR_ VT
- DT: 47x41m.
- Vị trí: Mặt tiền đường nhựa 14m đang làm. Cách đường Q lô56 chỉ 1,4 km, cách đường Bình Giã Đá Bạc 0,75 km ( Mảnh đất nằm Mt đường nối Ql056 và đường Bình Giã Đá Bạc)
- Tiềm năng: Vin Group chắc chắn sẽ đầu tư, đất đang tăng giá từng ngày, có thể phân được 10 lô, tiềm năng sinh lời rất cao.
- Đất gần đầy đủ các tiện ích bán kính 1,5km
- Pháp lý: sổ sách Đầy đủ, sang tên ngay và luôn.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1018, 1, CAST(N'2020-06-05T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1022, 1, 4, N'TP Hồ Chí Minh', N'Quận Thủ Đức', N'5800000000', 17, N'60', 2, 1, N'Tôi chính chủ cần bán nhà mới xây sổ hồng riêng.

- Giá chỉ 5,8 tỷ/căn.
- Sổ hồng riêng.

- Vị trí: Ngay chợ Thủ Đức.
- Kết cấu nhà: 1 trệt, 2 lầu.
* DT: 4 x 15m = 60m2.
* DT sử dụng lên tới 150m2.
* Sổ hồng riêng và đã hoàn công.
* Đường trước nhà 7m.
* Nhà đã hoàn thiện và bao gồm nội thất cơ bản dọn vào ở ngay hoặc đầu tư cho thuê.
- Cam kết.
* Bảo hành nhà 5 năm cho khách.
* Đường xung quanh dự án không ngập nước.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1019, 1, CAST(N'2020-06-04T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1023, 1, 4, N'TP Hồ Chí Minh', N'Quận Gò Vấp', N'5700000000', 17, N'57', 2, 4, N'Kết cấu:
- DT: 4 x 14m.
- Nhà mới xây, 1 trệt 3 lầu đúc, 4 phòng ngủ, 5 WC, BTCT, khách mua chỉ cần xách Vali vào ở ngay.
- Hướng đông bắc, đường trước nhà trải nhựa, hẻm xe tải, nội thất sang trọng.
- Nhà chính chủ xây ở nên tặng hết nội thất: 1 Sofa, bộ bàn ăn, 4 máy lạnh, 2 máy quạt.. Đều mới..
- Vị trí rộng rãi, thoáng mát, thông ra Quang Trung, Cây Trâm cách mặt tiền 20 mét, thuận tiện đi lại các Quận trung tâm.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1020, 1, CAST(N'2020-06-04T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1024, 2, 3, N'31', N'303', N'8200000000', 17, N'144', 6, 4, N'Do công việc gia đình chúng tôi cần nhượng lại căn biệt thự song lập Mahattan.
Diện tích đất: 144m2.
Xây dựng: 87m2/sàn x 3 tầng + 1 tum.
Hướng: Tây Nam.
Vị trí: Cạnh căn đầu mom, gần công viên, khu vui chơi trẻ em và khu mua sắm shophouse.
Giá: 8.2 tỷ bao mọi loại phí.
Tình trạng: Đã nhận bàn giao nhà, đã có sổ đỏ.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1021, 1, CAST(N'2020-06-03T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1025, 2, 5, N'31', N'308', N'5000000000', 17, N'205', 8, 3, N'Chính chủ cần bán đất khu du lịch Đồ Sơn. Vị trí đắc địa, đẹp bậc nhất miền biển. View ra biển, nằm trên tuyến đường huyết mạch lưu thông ra khu bãi tắm, khu 2, khu 3, siêu dự án Đồi Rồng. Tuyến đường tập trung đông người đi bộ, tập trung tất cả các cửa hàng hải sản của Đồ Sơn.
Diện tích 205m2 ngang 15m. Nằm giữa 2 con đường độc đạo, khách du lịch đến và về đều phải đi qua nên kinh doanh buôn bán cực tốt, thích hợp xây nhà hàng, khách sạn.
Đặc biệt có chỗ để xe ô tô thoái mái, rất tiện lợi phục vụ cho khách hàng.
Hãy liên hệ ngay để sở hữu 1 vị trí có 1 không có 2 này. Không có mảnh thứ như này đâu ạ.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1022, 1, CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1026, 1, 3, N'31', N'312', N'3200000000', 16, N'132', 6, 3, N'Cần bán căn biệt thự của gia đình để đoàn tụ với con ở nước ngoài.
Nhà bao gồm 3 mặt tiền, cửa chính hướng Đông giáp ngõ đi chung cửa sảnh phụ quay ra sân hướng Đông Nam.
Nhà 3 tầng diện tích bằng 131m2 diện tích sử dụng 330m2; Tầng 1 diện tích 110 1 phòng ngủ, 1 phòng khách, 1 phòng bếp và 1 sảnh phụ, 1 nhà vệ sinh. Tầng 2: 110m2 3 phòng ngủ, 2 nhà vệ sinh, 1 ban công. Tầng 3: Diện tích 110m2 1 phòng ngủ, 1 phòng thờ, 1 sân phơi, 2 ban công. xe ô tô vào tận sân.
Sân thượng có có tum sàn lát gạch.
Cửa chính tầng 1 2 cửa cuốn 1 của cường lực, tầng 2 1 cửa phòng cửa sổ các tầng đều bằng gỗ Lim Nam Phi.
Nhà xây tháng 10/2017 sổ hồng chính chủ tài sản gắn liền với đất các phòng đều lắp điều hòa + bình nóng lạnh, giường tủ để lại hết cho chủ mới.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1023, 1, CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1027, 1, 4, N'31', N'306', N'1560000000', 15, N'41', 2, 6, N'Bán nhà độc lập ngõ 58 Đằng Hải. Có ảnh chụp từ móng.
Diện tích: 41m2 * 3 tầng, 3 phòng ngủ, 3 WC, tất cả các phòng đều có cửa sổ.
Sổ đỏ chính chủ.
Hướng Đông.
Vị trí: Gần trường học các cấp, Big C... Cách Lê Hồng Phong 300m.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1024, 1, CAST(N'2020-06-10T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1028, 1, 4, N'31', N'305', N'1950000000', 15, N'50', 2, 4, N'Nhà 4T x 50m2 mặt ngõ đường Thiên Lôi, giá chỉ 1 tỷ 950tr.
- Ngõ trước nhà cực nông, đi thẳng vài bước ra mặt đường. Ô tô vào tận cửa.
- Diện tích 50m2 (ngang 5,5m) xây 4 tầng. Thiết kế hiện đại gồm phòng khách rộng rãi, bếp, 4 phòng ngủ, 3WC, sân phơi, phòng thờ.
- Vị trí thuận lợi, khu dân cư đông đúc gần chợ Đôn, chợ Hàng, trường học các cấp, bến xe Niệm Nghĩa,...
- Bìa hồng chính chủ, GPXD đầy đủ.
- Giá bán: 1 tỷ 950 triệu có thương lượng.
Thông tin pháp lý: Bìa hồng.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1025, 1, CAST(N'2020-06-03T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1029, 3, 4, N'31', N'306', N'1850000000', 15, N'44', 2, 1, N'Bán nhà 4 tầng tổng diện tích 180m2
- Diện tích mặt bằng 44m2
- Mặt tiền: 4m
- Gồm 1 phòng khách, 4 phòng ngủ, 3 WC
- Hướng Đông
- Ôtô vào tận nơi
- Sân chung có 4 gia đình (gần 200m2)
- Gần trường học, trung tâm TP, giao thông thuận tiện .....')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1026, 1, CAST(N'2020-06-03T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1030, 1, 9, N'31', N'305', N'7000000000', 17, N'105', 6, 3, N'Vinhomes Marina - Thiên đường nghỉ dưỡng đáng sống số 1 tại TP. Hải Phòng chính thức trình làng. Tiếp nối sự thành công của Vinhomes Imperia, chủ đầu tư Vingroup tiếp tục khẳng định sự đầu tư mạnh mẽ của mình trên quê hương Hoa phượng đỏ. Là khu phức hợp đầu tiên tại Hải Phòng mang phong cách Địa Trung Hải và Hy Lạp sang quý, thiết kế mái vòm thoáng rộng như một cung điện thu nhỏ, mang đến không gian sống tinh xảo và hoàn mỹ trong từng đường nét. Vinhomes Cầu Rào 2 hứa hẹn sẽ trở thành biểu tượng mới cho cuộc sống đẳng cấp nơi đất cảng phồn vinh. Đồng thời mở ra một cơ hội đầu tư, kinh doanh bất động sản hot trong thời gian sắp tới.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1028, 1, CAST(N'2020-06-03T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1031, 3, 4, N'31', N'312', N'710000000', 13, N'50', 2, 4, N'Nhà 1 tầng mái bằng, móng chắc chắn lên tầng 2.
Thiết kế hiện đại gồm 1 phòng khách, 2 phòng ngủ, 1 nhà VS, 1 bếp, 1 sân phơi, 1 kho, chỗ để xe.
Vị trí trung tâm thị trấn An Dương, đối diện cổng bệnh viện huyện An Dương.
Tiện ích đầy đủ trường, chợ, bệnh viện, trung tâm hành chính trong vòng 500m.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1030, 1, CAST(N'2020-06-02T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1032, 1, 4, N'31', N'304', N'3050000000', 16, N'58', 2, 3, N'Gia Đình Chuyển Công Tác Nên Cần Bán Căn Nhà Phố An Đà Gần Ngã Ba Bà Sáo.

- Nhà Xây 3 Tầng, Kiên Cố, Chắc Chắn, Công Năng Sử Dụng Cao. Có Sân Chung Rộng Rãi An Ninh, Yên Tĩnh. Hàng Xóm Thân Thiện, Dân Trí Cao.

- Nhà Gồm: Phòng Khách, Phòng Ăn, 3 Phòng Ngủ, Sân Phơi, Phòng Thờ, 3 Toilet.

- Nằm Trong Khu Trung Tâm Thành Phố, Di Chuyển Ra Các Tuyến Đường Rất Thuận Tiện, Gần Bigc, Lê Hồng Phong, lạch Tray, Gần Dự Án Mở Rộng Đường Hồ Sen -.

Cầu Rào 2, Siêu Thị Aeon, Gần Trường Học Các Cấp, Gần Chợ An Đà, Đông Khê.

- Khu Dân Cư Đông Đúc An Ninh An Toàn Tốt, Tập Trung Nhiều Tiện Ích Công Cộng Xung Quanh, Đáp Ứng Mọi Nhu Cầu Học Tập Làm Việc, Vui Chơi Giải Trí, Mua Sắm.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1031, 1, CAST(N'2020-06-02T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1033, 1, 4, N'31', N'305', N'6200000000', 17, N'96', 5, 4, N'- Nhà 5 tầng, DT 96m2 (4.7mx20.5m), Hướng Tây Nam, độc lập, được thiết kế hiện đại, có cầu thang máy thông suốt từ tầng 1 đến tầng 5, gồm: phòng khách, phòng ăn, phòng thờ, 7 phòng ngủ, sân phơi, sân chơi, ga ra ô tô, 8 toilet.

- Bố trí các phòng rộng rãi, nhà vệ sinh khép kín, thiết bị vật liệu cao cấp, cửa sổ rộng ánh sáng chan hòa, có ban công không gian thoáng mát vô cùng.

- Gần Đài Truyền Hình Hải Phòng, trường Đại Học Hàng Hải, Trường Dân Lập hải Phòng, Khách sạn sinh viên Dân Lập, gần Siêu thị AEON Mall, Viện Y Học Biển, khu dân cư đông đúc, sầm uất, văn minh, giao thông, sinh hoạt thuận tiện, anh ninh tốt.

- Nhà mặt đường rộng ô tô tránh nhau thoải mái, vỉa hè 3m, rất phù hợp an cư lạc nghiệp, mở văn phòng hoặc kinh doanh, buôn bán, tất cả các ngành nghề.
 sổ đỏ chính chủ.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1038, 1, CAST(N'2020-06-02T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1035, 1, 3, N'31', N'303', N'11535000000', 18, N'198m²', 7, 2, N'Xây dựng 100m2/sàn, 3 tầng + 1 tum.
Hướng Đông Nam.
Phía trước và sau nhà đều là công viên vườn hoa, lại có view sông. Buổi tối lung linh khỏi chê, đảm bảo đến xem là thích. Gia đình đã lựa chọn rất kĩ thời điểm đầu, tâm huyết bán đi cũng tiếc lắm.
Các bác đừng so sánh với mấy căn dãy 01 không có công viên chán lắm.
Giá trên hợp đồng: 11,535 tỷ, nay bán nguyên giá. Chịu lỗ thêm 300tr bao phí sang tên. Bớt thêm cho người thiện chí.
Có chính sách vay VP Bank hỗ trợ lãi đến 21/8/2020.
Thanh toán 4,035 tỷ và chuyển tên hồ sơ vay 7,5 tỷ')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1039, 1, CAST(N'2020-06-02T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1036, 1, 4, N'31', N'305', N'16000000000', 18, N'85', 5, 3, N'Nhà xây 4 tầng, độc lập, vị trí đẹp, phố trung tâm, khu dân cư đông đúc, kinh doanh sầm uất, vỉa hè rộng, an ninh tốt, có sổ đỏ.
Diện tích 86m2, chiều rộng 4,1m, giá bán 16 tỷ. Thông tin pháp lý: Sổ đỏ.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1041, 1, CAST(N'2020-06-02T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1037, 1, 4, N'31', N'305', N'3800000000', 16, N'100', 6, 3, N'Chính chủ cần bán nhà số 68/346 Thiên Lôi, đằng sau siêu thị Phúc Tăng, quận Lê Chân, Hải Phòng
Nhà 3 tầng kiên cố, chắc chắn, độc lập, có thể đi ngõ 512 Nguyễn Văn Linh, ngõ rộng ô tô vào tận cửa. Diện tích sử dụng là 100m2, diện tích trong bìa đỏ là 80m2. Ngang 5m
Cấu trúc nhà gồm: phòng khách, 3 phòng ngủ, phòng thờ, phòng ăn, sân phơi, sân chơi, 4 toilet.
Tiện nghi: điện, nước, truyền hình cáp, điện thoại, internet, máy lạnh, bình nóng lạ
Vị trí thông thoáng thuận tiện giao thông qua lại, gần trường, gần chợ, gần bến xe, gần các khu vui chơi giải trí, khu dân cư văn hóa, hàng xóm vui vẻ hòa đồng an ninh tốt.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1042, 1, CAST(N'2020-06-13T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1038, 1, 4, N'31', N'305', N'3100000000', 16, N'54', 2, 4, N'Bán gấp nhà ngõ to đường Chùa Hàng, mua để ở nhưng chưa có nhu cầu sử dụng (bán lỗ).
- 1 căn duy nhất.
- Thiết kế nhà theo phong cách Vinhomes, hiện đại, không lỗi mốt.
- Cấu trúc: Riêng móng riêng tường, 1 phòng khách 4 ngủ, 3 vệ sinh, phòng thờ, sân phơi, giếng trời hút gió.
- Hướng: Bắc (Đông tứ trạch).
- Vị trí trung tâm, 5p ra đến Tô Hiệu, gần trường học các cấp, ra chợ 2p. Thông tin pháp lý: Sổ đỏ chính chủ.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1043, 1, CAST(N'2020-06-01T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1038, 3, 4, N'31', N'305', N'2850000000', 16, N'52', 2, 3, N'Bán nhà mặt ngõ to đường Chợ Hàng.
Diện tích: 52m2.
Ô tô đỗ tận cửa.
Nhà xây chắc chắn, khung cột riêng, riêng móng riêng tường.
Cấu trúc: 1 phòng khách rộng, 1 bếp, 4 ngủ, 3 vệ sinh, phòng thờ, sân phơi,
Gần chợ, trường học các cấp.
Gần trung tâm thương mại Aeon Mall, lên trung tâm TP 2km.
Vị trí giao thông thuận lợi, dân cư an ninh.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1044, 1, CAST(N'2020-06-13T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1039, 1, 4, N'31', N'305', N'2550000000', 16, N'40', 2, 1, N'- DT 40m2, mặt tiền 5,8m.
- Nhà xây 4 tầng kiên cố, chắc chắn, độc lập, ngõ thông ra 72 Lạch Tray và 122 Đình Đông, khu dân cư đông đúc, sầm uất, dân trí cao, gần trường, chợ, an ninh tốt, thuận tiện giao thông, sinh hoạt, sổ đỏ chính chủ.
- Cấu trúc nhà gồm: Phòng khách, bếp, 4 phòng ngủ, phòng thờ, sân phơi, 3 toilet.
- Tiện nghi: Điện, nước, truyền hình cáp, internet, 5 điều hòa, bình nóng lạnh.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1045, 1, CAST(N'2020-06-13T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1040, 1, 4, N'31', N'305', N'3700000000', 16, N'65', 3, 4, N'Gia chủ chuyển công tác cần bán nhanh căn nhà trong ngõ to đường Tô Hiệu.

Diện tích 65m2.
Mặt tiền 4m.
Hướng Nam.
Sổ đỏ chính chủ.

Kết cấu 3 phòng ngủ 3 toilet, phòng thờ.
Ngõ trước nhà rộng 4m.

Khu dân cư văn minh, an ninh cao.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1046, 1, CAST(N'2020-06-13T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1040, 1, 4, N'31', N'305', N'3800000000', 16, N'50', 2, 1, N'Chủ nhà cực thiện chí bán căn nhà mặt ngõ to đường Trần Nguyên Hãn, gần bến xe Niệm Nghĩa.
Thông số:
Diện tích: 50m2.
Mặt tiền: 7,8m.
Hướng: Đông Bắc.
Pháp lý: Sổ đỏ chính chủ.
Giá: 3.8 tỷ (có thỏa thuận).
Mô tả:
- Nhà 3 tầng mới thiết kế phong cách hiện đại, gồm 4 phòng ngủ và 2 WC.
- Nhà nằm mặt to, ô tô ra vào thoải mái, trong ngõ toàn khu nhà ở cao cấp.
- Ngõ thông ra Vũ Chí Thắng, kinh doanh cực kỳ thuận tiện.
- Gần trường, chợ, bệnh viện, bến xe, đầy đủ mọi tiện ích sinh hoạt.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1047, 1, CAST(N'2020-06-13T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1041, 2, 4, N'31', N'305', N'870000000', 13, N'25', 1, 1, N'Bán căn nhà trong ngõ 201 Trần Nguyên Hãn. Nhà nhỏ xinh về ở luôn không phải sửa sang gì thêm.
* Diện tích: 25m2.
* Hướng Bắc.
* Sổ đỏ chính chủ. Nhà 1 phòng ngủ, 1 phòng thờ, 1 phòng khách và phòng bếp riêng biệt. Ngõ to thông ra hồ. Giao thông thuận tiện.')
INSERT [dbo].[TinBatDongSan] ([ID], [LoaiTin], [NgayDang], [TrangThaiGiaoDich], [TrangThaiDuyet], [TrangThaiXacNhan], [NguoiDang], [GoiTin], [LoaiBatDongSan], [TinhThanh], [QuanHuyen], [Gia], [MucGia], [DienTich], [MucDienTich], [Huong], [MoTa]) VALUES (1048, 1, CAST(N'2020-06-13T00:00:00.0000000' AS DateTime2), 0, 1, 1, 1042, 1, 4, N'31', N'305', N'3800000000', 16, N'50', 2, 6, N'Nhà xây 3 tầng kiên cố chắc chắn, ngõ rộng rãi, sân cổng riêng, không gian thoáng mát, khu dân cư đông đúc, gần trường học các cấp, chợ, ngã 4 đông người qua lại, thuận tiện giao thông, sinh hoạt, an ninh tốt, phố trung tâm, sầm uất.
Cấu trúc nhà bao gồm: Phòng khách, 4 phòng ngủ, phòng thờ, phòng ăn, sân chơi, sân phơi, 2 toilet.
Tiện nghi: Điện, nước, truyền hình cáp, internet, máy lạnh, bình nóng lạnh.
Cơ hội nắm bắt quý khách liên hệ ngay.')
SET IDENTITY_INSERT [dbo].[TinBatDongSan] OFF
SET IDENTITY_INSERT [dbo].[TinTuc] ON 

INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (2, N'5 kiến thức phong thủy cơ bản môi giới bất động sản nên biết', CAST(N'2020-05-15T00:00:00.0000000' AS DateTime2), 9, N'Trong “biển” kiến thức về phong thủy, môi giới bất động sản cần nắm vững 5 kiến thức cơ bản dưới đây để tư vấn đúng cho khách hàng, nâng cao uy tín nghề nghiệp.
 1. Xác định được hướng nhà, tâm nhà

Xác định tâm nhà là bước rất quan trọng để “phân cung điểm hướng”, từ đó định ra các phương vị của ngôi nhà và bố trí các khu chức năng phù hợp.

Tâm nhà được định nghĩa là một điểm mà tại đó các lực cân bằng nhau. Do đó, tâm nhà không đơn giản chỉ là tâm của hình vuông hay hình chữ nhật mà có thể coi như cách tính tâm của miếng cứng.

Với các căn nhà khuyết góc, nhà có hình dạng phức tạp… thì phải sử dụng các phần mềm chuyên dụng để tính tâm, không tính thủ công như nhà vuông vắn. Khi xác định tâm nhà cũng chỉ tính trên phần diện tích nhà có mái che, không tính phần sân vườn hoặc phần ban công, sân thượng không có mái.

Với hướng nhà, cần lưu ý, không chỉ nhà đất thổ cư mà với cả căn hộ chung cư, hướng nhà cũng tính là hướng cửa ra vào - nơi “nạp khí” cho căn hộ. Không nên lấy hướng ban công hay mặt thoáng của phòng khách làm hướng chung cư.

Hướng nhà là hướng vuông góc với mặt tiền nhà theo chiều từ trong nhà nhìn ra. Nên sử dụng la bàn chuyên dụng để xác định hướng nhà và chú ý tránh các tác động của từ trường. Nên đo ở nhiều vị trí khác nhau và tổng hợp kết quả để tăng độ chính xác. Các phần mềm la bàn trên điện thoại có độ sai số rất lớn không nên sử dụng.

Ngoài ra, cũng cần lưu ý là tâm nhà chỉ tính trên phần diện tích nhà có mái che, không tính phần sân vườn hoặc phần ban công, sân thượng không có mái.

2. Cách tính cung mệnh

Cung mệnh của mỗi người sẽ giúp xác định người đó hợp với trạch nhà nào, được tính dựa vào năm sinh và trên nhiều trang web có sẵn bảng tra cứu nhưng có thể có các sai số hoặc nhầm lẫn. Vì vậy các môi giới nên nắm rõ cách tính cung mệnh như sau:

Bước 1: Xác định năm sinh Âm Lịch và cộng các con số trong năm sinh.

Bước 2: Cộng các con số của kết quả đến khi được số có 1 chữ số.

Bước 3:
+ Nếu là Nam lấy 11 - (số có 1 chữ số vừa tính được ở bước 2) = X
+ Nếu là Nữ lấy 15 - X = Y

Sau khi tìm được X hoặc Y, tra thông số trong đồ hình Lạc Thư để biết người đó phi cung gì và thuộc Đông tứ mệnh hay Tây tứ mệnh.3. Xem tuổi làm nhà

Làm nhà liên quan đến thủ tục động thổ, tác động lớn đến địa khí của một khu đất, do đó cần xem tuổi gia chủ có phù hợp động thổ hay không.

Gia chủ phù hợp động thổ làm nhà khi tuổi âm lịch trong năm dự định làm nhà không phạm vào các hạn Tam tai, Kim lâu, Hoang ốc. Cách tính các hạn này như sau:

- Kim lâu: Lấy số tuổi Âm Lịch chia cho 9, nếu số dư là 1, 3, 6, 8 là phạm Kim Lâu. Nếu tuổi chia hết cho 9 hoặc ra các số dư khác là không phạm. Trong đó, dư 1 là phạm Kim lâu Thân (hại mình); dư 3 là phạm Kim lâu Thê (hại vợ); dư 6 là phạm Kim lâu Tử (hại con); dư 8 là Kim lâu Lục súc (hại vật nuôi).

Hoặc có thể ghi nhớ những tuổi phạm Kim lâu tra sẵn: 12, 15, 17, 19, 21, 24, 26, 28, 30, 33, 35, 37, 39, 42, 44, 46, 48, 51, 53, 55, 57, 60, 62, 64, 66, 69, 71, 73, 75.

- Hoang ốc: nếu làm nhà vào năm phạm hạn Hoang ốc thì căn nhà dễ bị bỏ hoang hoặc ở nhưng phạm vào những vấn đề không may mắn trong cuộc sống.

Hoang Ốc chia làm 6 cung: Nhất cát; Nhị nghi; Tam địa sát; Tứ tấn tài; Ngũ thọ tử; Lục hoang ốc. 4. Nguyên tắc “nhất vị nhị hướng”

Yếu tố Hướng theo quan điểm của Bát trạch là quan trọng. Tuy nhiên về đại cục, yếu tố về vị trí, về địa điểm là yếu tố hàng đầu.

Vị trí của công trình phải đặt lên hàng đầu, sau đó mới tính đến hướng theo Bát trạch. Đối với nhà đất thổ cư ưu tiên vị trí xem công trình có vượng khí không. Kế đến là cấu trúc, hình thể của công trình. Hướng xấu có thể hóa giải được theo nguyên tắc “đa cát thắng tiểu hung”.

5. Nhận biết và cách hóa giải một số thế sát thường gặp

Theo Bát quái, ngôi nhà được phân ra làm 8 phương vị đại diện cho các thành viên gia đình và các mặt trong đời sống của gia chủ. Nhà khuyết góc quá nhiều hoặc nhà vừa khuyết góc vừa thóp hậu thì tốt nhất không nên lựa chọn.

Nhà khuyết góc tạo ra nhiều góc cạnh gây sát khí không tốt. Ngoài ra nhà khuyết cung nào sẽ ảnh hưởng đến từng mặt cụ thể, chẳng hạn cung Đông Nam ảnh hưởng đến tài chính, cung Bắc ảnh hưởng đến quan lộc, cung Tây ảnh hưởng đến con cái…

Một số thế sát thường gặp với nhà ở thổ cư:

- Thương sát: chỉ những ngôi nhà bị đường đâm thẳng vào. Ở trong những ngôi nhà này, gia chủ dễ ảnh hưởng đến sức khỏe, dễ có tai nạn thương tật

Hóa giải: Tạo khoảng đệm (sân vườn phía trước), thiết kế tiểu cảnh nước hoặc treo gương cầu lồi, trồng cây xanh để điều tiết bớt dòng khí.

 Tuy nhiên khi xem xét định vị ngôi nhà có phạm thương sát hay không cần dựa vào độ dài ngắn, lưu lượng đi lại trên con đường, tương quan giữa độ lớn của con đường và tòa nhà để luận tốt xấu.

- Xung bối sát: chỉ những ngôi nhà bị đường đâm phía sau lưng. Nếu sống trong ngôi nhà này, gia chủ nhà dễ gặp họa tiểu nhân.

Hóa giải: Tạo khoảng đệm (sân vườn phía sau) hoặc treo gương cầu lồi trồng cây xanh để che chắn.

- Cắt cước sát: chỉ những ngôi nhà nằm ở vị trí quá gần xa lộ, cao tốc. Sống ở đây, chủ nhà hay thay đổi bất định, tài vận trồi sụt thất thường, tiền bạc đến rồi đi không giữ được.

Hóa giải: Thiết kế một khoảng đệm phía trước nhà. Nếu là nhà tầng, nên để trống toàn bộ tầng 1 làm khoảng đệm.

- Liêm đao sát: chỉ những ngôi nhà bị con đường hay dòng sông uốn lượn có phần phản cung hướng về phía nhà giống như lưỡi đao chém tới. Sống ở những ngôi nhà này gia chủ nhà dễ bị thương tật.

Hóa giải: Phía trước nhà nên trồng thêm cây xanh che chắn. Treo thêm gương cầu lồi

- Đao trảm sát: chỉ những ngôi nhà bị con đường giống như đao chém tới (hình chữ L ngược). Sống trong nhà này, chủ nhà dễ gặp tổn hại về người.

Hóa giải: Phía trước nhà nên trồng thêm cây xanh che chắn. Treo thêm gương cầu lồi.

- Thiên trảm sát: chỉ ngôi nhà đối diện với khoảng trống do hai căn nhà phía trước tạo ra. Chủ nhân những ngôi nhà này dễ bị bệnh tật, tiền bạc không giữ được.

Hóa giải: Treo gương cầu lồi hoặc trồng cây ở vị trí khe hở chiếu vào nhà để hóa giải. Nếu được nên thiết kế cửa chính tránh đối trực diện với khe hở.

- Độc âm sát: chỉ những ngôi nhà quá gần nghĩa trang, bệnh viện, nhà tang lễ. Người sống trong những ngôi nhà này tính cách dễ cô độc, khí vận kém, ngủ hay nằm mơ.

Hóa giải: Nên trồng thêm cây tre trúc vì loại cây này có nhiều khí dương, giúp hấp thụ khí âm. Ngoài ra gia chủ có thể nuôi thêm chó cảnh, chim cảnh… cũng giúp tăng cường dương khí.', 6)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (3, N'5 nguyên tắc về phong thủy cầu thang nhất định bạn phải biết
', CAST(N'2019-11-27T00:00:00.0000000' AS DateTime2), 9, N'Trong phong thủy nhà ở, phong thủy cầu thang giữ vai trò rất quan trọng, vì cầu thang là nơi dẫn khí và tiếp khí cho các khu chức năng ở tầng trên. Để cầu thang phát huy tốt chức năng này, gia chủ cần lưu ý 5 nguyên tắc về phong thủy như sau:
5 nguyên tắc cơ bản để thiết kế cầu thang hợp phong thủy
Để thiết kế được một cầu thang hợp phong thủy, gia chủ cần lưu ý 5 nguyên tắc sau đây:

1. Chọn hình dáng cầu thang hợp phong thủy
- Hình dáng tốt nhất của cầu thang là loại thẳng. Cầu thang xoắn tuy rất đẹp mắt và độc đáo, tốn ít diện tích nhưng không tốt về mặt phong thủy. Theo đó, loại cầu thang này tạo ra luồng khí xoắn, không tốt cho gia chủ và các thành viên trong nhà, nhất là nam giới. 

Cầu thang xoắn sẽ tác động xấu tới các thành viên tùy vào vị trí đặt ở phương vị nào. Ví dụ, đặt tại phương vị Càn thì không tốt cho người cha; ở phương vị Chấn không tốt cho con trai trưởng; ở phương vị Khôn không tốt cho người mẹ; ở phương vị Đoài không tốt cho con út… - Không làm cầu thang đứt đoạn. Ví dụ ở tầng 1 cầu thang đặt phía đầu hành lang nhưng lên tầng 2-3 lại đặt ở vị trí cuối hành lang hoặc vị trí khác. Cách bố trí này làm cho khí trường bị đứt đoạn, không thông suốt, là một cách cục xấu về phong thủy.

- Độ dốc của cầu thang chỉ nên ở mức vừa phải, đảm bảo sự thuận tiện cho tất cả các thành viên trong gia đình. Với những cầu thang cần các khúc cua để đi lên nhiều tầng thì nên bố trí chiều cua theo chiều kim đồng hồ.

- Cầu thang nên có các bậc lên xuống khép kín, không bị hở vì sẽ gây thoái khí. Cầu thang là nơi dẫn khí do đó các bậc kín mới đảm bảo tính chứa và dẫn khí.

 - Cầu thang phải có lan can hai bên, hoặc một bên ốp vào tường, một bên có lan can để tránh bị ngã. Không chỉ đảm bảo tính an toàn, lan can cầu thang còn tạo cảm giác an tâm, tin cậy cho người đi lại. Cầu thang kiểu xương cá không có lan can hai bên hay có dây văng mảnh tuy đẹp nhưng thiếu an toàn và dễ bị thoái hết khí.

Ngoài ra, nên bố trí thêm điện chiếu sáng để tăng năng lượng phong thủy cầu thang trong nhà, cụ thể là tăng dương khí và cảm giác an toàn khi đi lại, nên chọn ánh sáng dịu nhẹ hoặc ánh sáng vàng ấm áp. 2. Chọn kích thước cầu thang hợp phong thủy
Chọn kích thước cầu thang phong thủy trước tiên cần tuân thủ kích thước kỹ thuật để việc sử dụng, đi lại được thuận tiện. Gia chủ có thể chọn kích thước cầu thang theo bảng dưới đây:

Chiều rộng của thân thang

Khoảng 0,8m đến 1,2m hoặc 1,5m

Độ dốc của cầu thang (tùy thuộc vào tỷ lệ chiều cao và chiều rộng bậc thang)

Độ cao bậc thang thường từ 15 – 18 cm

Chiều rộng tương ứng từ 24 – 30 cm

Chiều cao của lan can

Khoảng 85 – 90cm

Chiếu nghỉ

Chiều rộng chiếu nghỉ bằng chiều rộng của thân thang.

Cụ thể cách tính toán và lựa chọn kích thước cầu thang:

- Chiều rộng của bản thang: Kích thước phổ biến thường từ 0,8m đến khoảng 1,2m, với nhà biệt thự có thể là 1,5m hoặc hơn.

- Độ dốc của cầu thang: 

Công thức tính độ dốc của cầu thang: 2h + b = 600 mm (trong đó h là chiều cao bậc thang; b là chiều rộng bậc thang).

Thông thường, chiều cao của bậc thang là từ 150 - 180 mm, chiều rộng tương ứng từ 250 - 300 mm.

- Kích thước của chiếu nghỉ: Chiếu nghỉ phải có chiều rộng bằng hoặc lớn hơn chiều rộng của thân thang. Kích thước chiếu nghỉ cũng phải cân đối để không gây bất tiện khi vận chuyển, đi lại.

- Chiều cao của lan can: bất kể cầu thang có độ dốc hay chiều rộng như thế nào thì lan can cầu thang vẫn cần có chiều cao tiêu chuẩn trên 80cm, tối đa 90cm, tính từ mặt bậc lên tới tay vịn lan can.

- Phong thủy bậc cầu thang, có 2 cách tính:

+ Số bậc cầu thang ở mỗi tầng nên là con số chia hết cho 4 và dư 1 như 5, 9, 13, 17 hoặc 21, 25.

+ Số bậc của mỗi tầng và của toàn bộ thang khi đếm theo Sinh – Lão – Bệnh – Tử nên rơi vào cung Sinh là tốt nhất, hoặc tính theo công thức 4n+1 (n là số lần chu kì lặp lại khi đếm bậc từ 1 đến 4). 

Lưu ý số lượng bậc thang được tính từ bậc đầu tiên đến điểm kết thúc (chiếu tới, hành lang). Chiếu nghỉ tại các tầng cũng được tính là một bậc thang.

Để có phong thủy cầu thang nhà ở tốt cũng không nên làm cầu thang quá dài từ tầng này lên tầng khác, vì cầu thang càng dài thì khí dẫn lên trên càng yếu.

3. Chọn vị trí cầu thang hợp phong thủy
Vị trí đặt cầu thang trong nhà ngoài việc phù hợp với diện tích, bố cục các khu chức năng trong nhà và thuận tiện khi di chuyển cần đảm bảo một số lưu ý khác về phong thủy như sau:

- Trước hết phải chọn đặt cầu thang ở nơi thoáng đãng, sinh khí dồi dào. Vị trí chân cầu thang nên đi từ hướng tốt lên, không nên đặt cầu thang bắt đầu từ phía sau nhà đi lên bởi sẽ khiến các tầng trên lần lượt suy khí.

- Khi điểm cung thần sát cho ngôi nhà, nên bố trí cầu thang nằm tại các cung: Âm quý nhân, Dương Quý Nhân, Thiên mã, Thiên Lộc, Đào Hoa, tránh các cung có Thiên hình, Đại sát. 

- Không đặt cầu thang chính giữa nhà. Khi phân cực lập hướng, ngôi nhà được chia làm 9 cung, chính giữa là trung cung. Vị trí này thuộc hành Thổ, trong khi cầu thang thuộc hành Mộc, nếu đặt cầu thang ở đây sẽ tạo ra năng lượng xung đột.

Trường hợp không tìm được vị trí thích hợp hơn cũng nên cố gắng không đặt bậc cầu thang đầu tiên vào giữa nhà. - Không bố trí cầu thang thẳng hàng với cửa ra vào. Cách bố trí này sẽ khiến năng lượng từ cửa chính xộc thẳng lên cầu thang, tạo sự bất ổn. Trong khi đó, khí trong phong thủy cần đi chậm để phân bố đều vào các không gian. Nếu không có lựa chọn tốt hơn, có thể khắc phục bằng cách dựng một vách ngăn nhẹ hoặc tủ kệ phía chân cầu thang. Đặt quả cầu thủy tinh hoặc cây xanh phía chân cầu thang cũng giúp làm giảm tốc độ của luồng khí.

- Không đặt cầu thang đối diện với nhà vệ sinh ở cả điểm đầu và điểm cuối vì cầu thang sẽ dẫn những năng lượng xấu, các xú uế từ nhà vệ sinh đi tới các phòng. Tương tự, phòng bếp cũng không nên bố trí ở đầu hoặc cuối cầu thang.

- Không xây nhà vệ sinh ở gầm cầu thang: cầu thang mang cát khí tới các phòng nên cần đặt tại các vị trí tốt, nhà vệ sinh lại là nơi có nhiều uế khí, cần đặt tại vị trí hung của ngôi nhà. Do đó, nếu đặt nhà vệ sinh dưới gầm cầu thang sẽ làm giảm cát khí của cầu thang. Những không gian chức năng khác như phòng bếp, phòng ngủ, phòng ăn, phòng thay đồ cũng không thích hợp đặt dưới gầm cầu thang.

Tiểu cảnh nước như bể cá, non bộ… cũng không thích hợp đặt dưới gầm cầu thang bởi khu vực này thường thiếu sáng, dễ sinh ra những năng lượng tiêu cực.

Nếu muốn tận dụng diện tích gầm thang, chỉ nên bố trí kệ đựng đồ hoặc tiểu cảnh khô đơn giản. 4. Chọn chất liệu cầu thang hợp phong thủy
Cầu thang trong phong thủy có chức năng dẫn khí, nhưng chức năng quan trọng nhất vẫn là phục vụ lưu thông, đi lại. Do đó, cầu thang phải được làm bằng các chất liệu vững chắc, có độ bền cao.

Cầu thang nên được xây bằng gạch hoặc đúc bê tông kiên cố, các bậc thang có thể ốp đá hoặc gỗ, lan can làm bằng gỗ, kim loại để tăng tính thẩm mỹ.

Gia chủ cũng có thể chọn chất liệu cầu thang theo vị trí đặt. Ví dụ, cầu thang bằng gỗ thích hợp với hướng Nam, Đông và Đông Nam, cầu thang kim loại thích hợp ở hướng Bắc, cầu thang xây bằng gạch, bê tông thích hợp với hướng Đông Bắc, Tây Nam, Tây và Tây Bắc của ngôi nhà.

Tuy nhiên cần lưu ý, với chất liệu gỗ, chỉ nên sử dụng cho cầu thang dẫn lên gác xép, tầng lửng có ít bậc thang, với nhà nhiều tầng hoặc biệt thự thì kết cấu này không đủ chắc chắn. 

Dù sử dụng chất liệu nào thì ở mỗi đầu cầu thang cũng nên có một khoảng lùi nhỏ làm nơi định hướng, nơi giao tiếp của các luồng người đi. Nếu diện tích không đủ làm khoảng lùi hãy đặt cây cảnh hoặc chuông gió giúp báo hiệu cho người qua lại, tránh va chạm.

5. Chọn màu sắc cầu thang hợp phong thủy
Màu sắc cầu thang về cơ bản cần hài hòa với phong cách nội thất, kiến trúc và màu sắc các khu chức năng khác trong nhà. Liên quan đến phong thủy, gia chủ có thể chọn màu sắc cầu thang theo bản mệnh như sau:

- Với những chủ nhà mệnh Kim: có thể chọn những màu tương sinh cho bản mệnh, là màu có ngũ hành thuộc Thổ, như nâu, nâu đất, vàng đậm... Ngoài ra, những màu có ngũ hành thuộc Kim cũng là một phương án tốt, như bạc, trắng, xám...

- Với những chủ nhà mệnh Mộc: nên chọn màu tương sinh có ngũ hành thuộc Thuỷ như xanh da trời, xanh nước biển... hoặc các màu thuộc Mộc như xanh lá, cẩm thạch.

- Với những chủ nhà mệnh Thuỷ: màu tương sinh với bản mệnh này là những màu có ngũ hành thuộc Kim như trắng, bạc, xám… hoặc những màu thuộc hành Thủy như xanh da trời, xanh nước biển.

- Với những chủ nhà mệnh Hoả: những màu có ngũ hành thuộc Mộc hoặc Hỏa là phương án nên chọn, như xanh lá cây, xanh rêu, đỏ, cam... Không nên chọn những màu có ngũ hành thuộc Thủy như xanh nước biển, xanh da trời.

- Với những chủ nhà mệnh Thổ: màu sắc tương sinh của bản mệnh này là những màu có ngũ hành Hỏa như đỏ, hồng, tím… hoặc có thể chọn màu thuộc Thổ như nâu, vàng nhạt...

Chọn màu sắc cầu thang theo mệnh chỉ là một phương án tham khảo, gia chủ có thể lựa chọn màu sắc theo sở thích, chỉ cần đảm bảo sự cân bằng, hài hòa với tổng thể chung, tránh dùng quá nhiều màu nóng như đỏ, cam, tím… hay màu u ám như màu đen.', 6)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (4, N'Ý nghĩa phong thủy cây phát lộc
', CAST(N'2020-07-06T00:00:00.0000000' AS DateTime2), 13, N'Cây phát lộc là biểu tượng của may mắn, sức khỏe và thịnh vượng. Loài cây này không chỉ làm tăng nguồn năng lượng tích cực cho không gian sinh sống mà còn có tác dụng làm phục hồi các dòng năng lượng bị trì trệ trong không gian, giúp cho ngôi nhà hoặc văn phòng căng đầy sinh khí, mang đến nhiều vận may về lộc tài và hạnh phúc cho người cư ngụ.
Sử dụng cây phát lộc thế nào đúng phong thủy?

Một cây phát lộc đẹp về phong thủy cần phải hội tụ đủ 5 ngũ hành: Kim, Mộc, Thủy, Hỏa, Thổ

Kim: Bình trồng cây (nếu được làm bằng thủy tinh được coi là yếu tố kim) hoặc bạn có thể gắn một hình kim loại nhỏ hay thả các đồng xu vào bình.
Mộc: Cây phát lộc tượng trưng cho hành Mộc
Thủy: Nước trong bình
Hỏa: Ruy băng đỏ buộc quanh thân cây hoặc bình
Thổ: Đá hoặc sỏi trang trí trong bình. Nên đặt ở phòng khách, không đặt trong phòng ngủ. Nên đặt vào các nơi có bộ sao phi tinh 1-4 (Văn xương) hay 1-6 (Quan lộc) để phát huy tác dụng tốt nhất; hoặc đặt vào vị trí phía Đông, Đông Nam của căn nhà, hoặc phòng làm việc để tăng sinh khí.

Có thể đặt cây trên bàn hình vuông, chữ nhật hoặc trên tab sofa để khí lưu chuyển thuận lợi. Số lượng cây phát lộc tượng trưng cho điều gì?

- 01 cây: Nếu trong bình chỉ có 1 cây phát lộc, ban đầu trông nó sẽ giống như một khúc gỗ không có rễ. Trong khi một đầu cắm trong nước mọc ra những chiếc rễ thì đầu còn lại sẽ mọc lá và liên tục tạo ra những chiếc lá mới. Đây là biểu tượng của một cuộc sống mạnh mẽ tràn đầy sự thịnh vượng. Nó cũng tượng trưng cho sự phát triển mạnh mẽ của doanh nghiệp mới.

- 02 cây: Cặp đôi phát lộc có ý nghĩa song hỷ, biểu tượng cho tình yêu.

- 03 cây: Biểu tượng cho Phúc - Lộc - Thọ.

- 04 cây: Biểu tượng cho sự học tập, sáng tạo. Tuy nhiên, tiếng Trung Quốc âm của số 4 (tứ) gần giống với âm chữ Tử (chết), đó là sự bất hạnh nên không mấy ai dùng 4 cành (hoặc 4 cây) trang trí trong nhà ở hoặc văn phòng.

- 05 cây: Biểu tượng cho sự cân bằng của 5 yếu tố: Cảm xúc, trực quan, tâm thần, thể xác, tâm linh.

- 06 cây: Biểu tượng cho sự may mắn về tiền bạc.

- 07 cây: Biểu tượng cho sức khỏe và những may mắn đem đến từ các mối quan hệ.

- 08 cây: Biểu tượng cho sự tăng trưởng, phát triển nhanh chóng.

- 09 cây: Biểu tượng cho sự trường tồn, thịnh vượng.

- 10 cây: Biểu tượng cho cuộc sống đầy đủ, viên mãn.

- 11 cây: Biểu tượng cuộc sống gia đình luôn may mắn.

- 21 cây: Biểu tượng  sức khỏe, may mắn, hạnh phúc cho các thành viên trong gia đình.

- Nhiều cây theo hình tháp: Tượng trưng cho sự phát triển, thịnh vượng.', 6)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (5, N'Dùng lại đồ cũ cho nhà mới có làm hỏng nội khí?
', CAST(N'2020-03-16T00:00:00.0000000' AS DateTime2), 10, N'Đa số các gia đình đều tận dụng đồ cũ cho ngôi nhà mới, trừ khi có điều kiện sắm mới toàn bộ đồ đạc. Tuy nhiên, tái sử dụng đồ cũ cần có chọn lọc, nếu không sẽ ảnh hưởng đến nội khí của không gian sống.
Các gia chủ hầu như ai cũng biết nhà kiểu nào thì đặt đồ kiểu đó cho đồng bộ. Chẳng hạn, nếu đồ đạc đa phần kiểu xưa "sập gụ tủ chè" thì không gian nhà có chất hoài niệm mới phù hợp. Trong khi đó, bàn ghế kiểu tối giản Bắc Âu lại cần không gian nội thất hiện đại, nếu làm ngược lại thì sẽ khiến cái cũ và cái mới xung khắc. Quan niệm trên dù có đúng nhưng nếu xét về mặt phong thuỷ và nghệ thuật trang trí đương đại thì chưa đủ. Bởi xưa nay, kiến trúc và phong thủy đều muốn hướng tới sự dung hòa các mặt đối lập. Tất cả những phối trộn về nội thất tựu chung đều hướng đến sự bình ổn và thuận tiện trong sử dụng, chứ không bắt buộc đồ nội thất kiểu truyền thống nhất định không được đặt trong nhà kiểu mới hay ngược lại.

Dưới đây là một số nguyên tắc giúp gia chủ chọn lọc đồ đạc để tạo sự hài hòa cho không gian sống:

- Đồ đạc thuộc hành Mộc và Thổ thiên về tính âm nên hợp với phong cách cổ điển: Những món đồ bằng chất liệu gỗ, gốm tự nhiên, có bề mặt thô mộc hợp với các không gian mang tính âm, cần yên tĩnh như không gian thờ cúng, góc tâm linh, phòng ngủ, thư phòng…

- Đồ đạc thuộc các hành Kim và Hỏa thiên về tính dương, hợp xu hướng hiện đại: Những món đồ bằng kim loại, nhựa, có màu sắc rực rỡ, đường nét sắc sảo, hoạ tiết trẻ trung… phù hợp với các không gian mang tính dương như góc học tập, phòng sinh hoạt, phòng khách kiểu hiện đại, phòng ngủ trẻ em. - Đồ đạc thuộc hành Thủy - có vai trò trung hòa, kết nối: Giống như dòng nước chảy, đồ đạc hành Thủy có tính lan tỏa, kết nối các không gian với nhau nhờ nét mềm mại linh hoạt, vừa tương sinh cho Mộc và hạn chế Hỏa, vừa được Kim sinh vượng đồng thời bị Thổ khắc bớt. Nhờ đó, hành Thủy giúp nội thất trở nên sống động, gần gũi thiên nhiên hơn. Để bổ sung Thủy cho nội thất, kết nối các hành đối lập, có thể sử dụng các mặt bàn kính uốn lượn, tiểu cảnh, bình hoa, đèn trang trí mềm mại, rèm cửa, mảng kính lóng lánh… 

- Tương hòa trong tương phản: Nếu muốn nội thất không bị thiên quá nhiều về một hành nào đó có thể dùng biện pháp tương phản để kiềm chế bớt nhờ sự hoà trộn chất liệu. Chẳng hạn, những món đồ bằng đồng, sắt uốn kiểu xưa (thuộc Kim) nếu có kiểu dáng, hoa văn mềm mại thì vẫn thích hợp với phái cổ điển. Trong khi đó, cùng là đồ gỗ mà có bề mặt màu sắc tươi tắn, kiểu dáng mới, nét giản dị thì có thể tương ứng với nhóm hiện đại. ', 6)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (6, N'Dùng gương thế nào mới là đúng phong thủy?
', CAST(N'2020-02-26T00:00:00.0000000' AS DateTime2), 9, N'Trong cuộc sống, đâu đó vẫn còn lưu truyền những kiêng kỵ liên quan đến việc sử dụng gương, như “gương là đũa thần cho nội thất” hay “dùng kính thủy coi chừng thị phi”.
Nhưng thực ra, nghệ thuật dùng gương lại có liên quan không ít đến cách thức trang trí nội thất để đảm bảo hiệu quả về sử dụng và phong thủy. Gương thực chất là một bề mặt có đặc tính phản quang, giúp phân tán ánh sáng và các luồng khí. Tuy vậy, gương phân tán được khí xấu thì cũng sẽ làm tiêu tán những khí tốt nếu đặt sai chỗ. Vì thế mới có hai nhóm ý kiến trái ngược nhau về gương. Một nhóm tin rằng, nếu treo gương hướng ra ngoài tại nơi giao tiếp nhiều thì sẽ giúp phản lại các tác nhân xấu xâm nhập (xung sát). Nhóm khác lại cho rằng, nên dùng gương để thu hút các hình ảnh bên ngoài vào nhà, tạo sự tích tụ, làm mở rộng tầm nhìn, giúp tăng thêm vật dụng và lợi ích (ví dụ dùng gương ở đằng sau quầy tính tiền của cửa hàng, quán xá để… gia tăng tiền bạc (?). Thực ra đây chỉ là những giải thích mang tính trấn an về tâm lý.

Gương có tác dụng phản quang để tạo góc nhìn rộng hơn, bổ sung thêm ánh sáng, và thực tế thì các hình ảnh phản chiếu trong gương chỉ là ảnh ảo. Do đó, nếu gương gây hiệu ứng lệch lạc về thẩm mỹ, khiến người nhìn chói mắt khó chịu, trở ngại cho giao tiếp thì nên thay đổi mà không cần đắn đo. Gương giúp cân bằng âm dương

Ánh sáng mang tính dương, để ánh sáng được dẫn truyền tốt thì gương phải đặt ở vị trí lan tỏa ánh sáng cho những chỗ khuất và tối (mang tính âm). Vì vậy, trước khi đặt gương, cần xem xét không gian theo khu vực giao tiếp nhiều hay ít, âm hay dương, để chọn ra các vị trí thuận lợi về tầm nhìn và ánh sáng.

Ví dụ, với một phòng khách có nhiều góc cạnh, nhiều chỗ thiếu sáng... gia chủ cần chú ý cách bố trí đồ nội thất, xem mở cửa lấy sáng ra sao, đặt thêm đèn chiếu sáng và chọn vị trí treo gương để ánh sáng lan tỏa hiệu quả và tạo cảm giác không gian rộng rãi hơn. Với những căn phòng bị cột án ngữ, có thể bọc gương để xử lý, tạo cảm giác như cột "biến mất" một cách hiệu quả.

Chèn gương vào những khung cửa giả cũng là một cách để tạo ra vị trí Khai Môn theo hướng hợp với tuổi của chủ nhà. Chẳng hạn, nếu gia chủ có tuổi hợp với hướng Đông nhưng hướng này lại là bức tường tiếp giáp nhà hàng xóm, không thể mở được cửa, thì gia chủ có thể tạo khung cửa giả gắn gương ở vị trí này để kích hoạt nguồn khí tốt ở phương vị hợp mệnh với mình.', 6)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (7, N'Cách dùng đá thạch anh trong phong thủy nhà ở', CAST(N'2020-04-06T00:00:00.0000000' AS DateTime2), 9, N'Thạch anh là một loại đá khá phổ biến trong tự nhiên và được sử dụng rộng rãi trong cuộc sống. Ngoài tác dụng cải thiện sức khỏe, hỗ trợ thiền định, thạch anh còn được sử dụng làm đồ trang sức và vật phẩm phong thủy. Trong phong thủy nhà ở, nên sử dụng thạch anh ra sao để loại đá này phát huy hiệu quả?
Thạch anh là một loại khoáng vật, tồn tại dưới hai dạng cấu trúc là cấu trúc Alpha (thấp) và cấu trúc Beta. Đây là một loại đá bán quý, có độ cứng chỉ xếp sau kim cương. Thạch anh được tìm thấy khá nhiều trong tự nhiên với các màu sắc phong phú nên thường được dùng làm đồ trang sức. 

Thạch anh cũng là thành phần của rất nhiều loại đá, khoáng sản, quặng, trong đó nó là thành phần chính tạo nên một số loại đá như mã não hay onix. Cũng có nhiều loại đá do thạch anh biến chất thành như quartzit, opal hay ngọc bích. Đối với ngành công nghiệp bán dẫn, các tinh thể thạch anh có độ tinh khiết cao trong tự nhiên là loại cực kỳ đắt và hiếm. Thời cổ xưa, con người đã biết dùng thạch anh tinh thể để kết nối với hội đồng tâm linh, thu hút tình yêu và sự thịnh vượng. Người xưa tin rằng, khi mang thạch anh bên người sẽ giúp gia tăng sức mạnh tinh thần, xua đuổi tà thuật. Thạch anh cũng là loại đá có tác dụng trị liệu như điều hòa các ion, giảm bức xạ, tăng năng lượng cho cơ thể, tăng khả năng thiền định, đặt trong bồn tắm giúp tăng cảm giác thư giãn…

Thời hiện đại, nhiều nghiên cứu khoa học cho thấy khi có một năng lượng sóng cơ học tác động vào tinh thể thạch anh, các phân tử thạch anh sẽ dao động với tần số tương đương sóng tác động. Điều này giúp thạch anh có thể chuyển đổi áp lực cơ khí thành năng lượng từ trường và ngược lại. Do đó, thạch anh được dùng để chuyển đổi năng lượng trong các thiết bị công nghệ hiện đại như máy siêu âm, đồng hồ, micro, máy thu phát radio, chip bộ nhớ trong máy vi tính…. Không chỉ mang năng lượng rất lớn, cấu trúc mạng tinh thể tự nhiên của thạch anh là cấu trúc chóp trụ lục lăng, là dạng hình khối có khả năng tích tụ năng lượng rất mạnh và nhanh. Chính vì vậy, loại đá này giống như một cột thu các năng lượng tích cực. Phong thủy ứng dụng đặc điểm này để dùng thạch anh đặt trong phòng làm việc, nơi ở, giúp tiêu hao các năng lượng xấu, tăng cường sự chuyển hóa năng lượng trong không gian sống, giảm hung, hóa cát.

Đặc biệt, đá thạch anh mang năng lượng dương nên được dùng để xua đuổi tà khí, hóa giải các sát khí. Thạch anh có thể thu hút năng lượng âm nên được dùng trong những không gian sống thiếu ánh sáng, tối tăm giúp tăng dương khí, cân bằng năng lượng.

Nhìn chung, đá thạch anh được biết đến nhiều qua tác dụng trị liệu và hỗ trợ thiền định, kết nối tâm linh. Về mặt phong thủy, thạch anh cũng có nhiều công dụng: chiêu tài, hóa giải sát khí, cân bằng các dòng năng lượng… Do sự đa dạng về chủng loại, màu sắc, nên trong phong thủy thạch anh cũng là một vật phẩm rất dễ sử dụng. Mỗi loại đá thạch anh có đặc trưng riêng về màu sắc và khả năng tích tụ năng lượng, do đó khi sử dụng đá thạch anh trong phong thủy nhà ở cần dùng đúng chủng loại phù hợp từng mục đích cụ thể:

Thạch anh trắng

- Đặc điểm: Thạch anh trắng có màu trắng đục, trắng sữa hoặc trong suốt. Trong dòng họ thạch anh, thạch anh trắng dược tìm thấy nhiều nhất trong tự nhiên.

- Tác dụng: Thạch anh trắng có thể điều hòa năng lượng xung quanh, giúp con người giảm căng thẳng, tăng khả năng tập trung và kích thích các chức năng hoạt động của não bộ.

- Cách dùng: Đựng các viên thạch anh trắng trong một chiếc bát lớn đặt trên nền nhà vệ sinh giúp hóa giải sát khí và cân bằng năng lượng cho nhà vệ sinh. Thực ra đây chính là một loại vật phẩm phong thủy có tên gọi là “bảo bình thủy”. 

Tinh thể thạch anh trắng có hình lục giác giống như lăng kính tự nhiên, do đó khi đặt thạch anh trắng ở cửa sổ chúng sẽ giúp phân tán năng lượng dương từ ánh nắng mặt trời đến khắp căn phòng.

Đặt thạch anh trắng gần tivi, máy tính, lò vi sóng cũng giúp giảm bớt bức xạ phát ra từ các vật dụng này. Thạch anh vàng

- Đặc điểm: Tinh thể thạch anh vàng được gọi là Citrine, có kích thước khá nhỏ trong tự nhiên. Trong sản xuất, tinh thể này được xử lý nhiệt dựa trên thạch anh tím để tạo ra màu vàng ở nền nhiệt từ 250-400 độ C.

- Tác dụng: Ngoài làm đồ trang sức, thạch anh vàng có thể tạo sự cân bằng về cảm xúc. Do có màu vàng nên trong phong thủy loại đá này có thể chiêu tài.

- Cách dùng: Trong phong thủy, thạch anh vàng được gọi là “chiêu tài thạch”, các doanh nghiệp thường đặt ở quầy thu ngân để thu hút vận may tài lộc. Thạch anh hồng

- Đặc điểm: Thạch anh hồng là một dạng tinh thể có cấu tạo phức tạp và bền vững, có màu hồng nhạt hoặc phớt hồng, trong suốt hoặc hồng đục, được cho là mang năng lượng tích cực cho tình yêu và hôn nhân.

- Tác dụng: Ngoài làm đồ trang sức, thạch anh hồng giúp tăng sự tự tin, gắn kết trong tình yêu, đặc biệt là khả năng giảm các tia bức xạ.

- Cách dùng: Đặt thạch anh hồng trong phòng ngủ, phía dưới giường nằm để có giấc ngủ ngon hơn. Đặt thạch anh hồng trên bàn làm việc, gần máy tính để giảm các tia bức xạ. Với những người còn độc thân, muốn sớm kết hôn, có thể đặt thạch anh hồng ở cung tình duyên hoặc trong phòng ngủ.

Thạch anh tím

- Đặc điểm: Thạch anh tím có màu sắc hút mắt, mang năng lượng dương cực lớn, thuộc nhóm đá quý. Đây cũng là loại thạch anh có giá trị cao nhất trong dòng đá thạch anh phong thủy.

- Tác dụng: Ngoài hỗ trợ thiền định, giúp con người kết nối tâm linh, thạch anh tím còn có thể cải thiện sức khỏe, làm tăng mức năng lượng trong cơ thể nhờ khả năng gia tăng bức xạ hồng ngoại tương ứng.

- Cách dùng: Thạch anh tím được chế tác thành dạng quả cầu hoặc hình lục trụ, đặt tại các góc nhà sẽ giúp cân bằng từ trường, giảm tà khí và tăng lưu thông không khí. Trên bàn làm việc, đặt thất tinh đồ gồm 7 quả cầu thạch anh màu tím giúp ngưng tụ năng lượng, tăng khả năng tập trung và khả năng lãnh đạo. Thạch anh đen

- Đặc điểm: Thực chất thạch anh đen chính là biến thể của thạch anh khói đen, chúng có màu đen nhạt hoặc đen bóng, là loại đá cực kỳ quý hiếm.

- Tác dụng: Thạch anh đen có thể chế ngự được các năng lượng xấu, giúp con người phát triển óc tưởng tượng và tư duy logic. Trong phong thủy, thạch anh đen giúp trấn trạch nhà ở.

- Cách dùng: Với những ngôi nhà có cửa chính đối diện đường lớn hoặc nhà ở góc đường hình chữ L, trước cửa nhà có cây to hoặc cột điện, có thể dùng chuông gió làm bằng thạch anh đen hoặc các loại thạch anh khác treo trước cửa để hóa giải sát khí. Đặt thạch anh đen trên bàn làm việc giúp tăng khả năng sáng tạo và tư duy.

Thạch anh tóc

- Đặc điểm: Sự trộn lẫn giữa những sợi (rutile) và các tinh thể rutile hình kim, hình que là cơ chế tạo nên thạch anh tóc. Ngoài ra, hiệu ứng quang học amiăng khi tiếp xúc với ánh sáng còn giúp thạch anh tóc trông lung linh, huyền ảo hơn.

- Tác dụng: Thạch anh tóc mang nguồn năng lượng dồi dào, vượt trội nhất trong dòng họ thạch anh.

- Cách dùng: Thạch anh tóc có nhiều màu sắc khác nhau, được ứng dụng tương tự như các loại thạch anh thông thường khác nhưng có năng lượng tốt hơn. Trong phong thủy nhà ở, thạch anh tóc thường được dùng để chiêu tài.', 6)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (8, N'Che chắn nhà mùa nắng: Cách dùng lam tránh nóng và cân bằng âm dương', CAST(N'2020-05-07T00:00:00.0000000' AS DateTime2), 9, N'Với đặc trưng khí hậu nhiệt đới của Việt Nam, việc chọn giải pháp chống nóng luôn là mối bận tâm của các chủ nhà. Trong đó, dùng lam che chắn là giải pháp hữu hiệu, nếu khéo còn giúp cân bằng âm dương, tăng lợi thế phong thủy cho ngôi nhà.
Lam tránh nắng thực ra đã rất phổ biến từ thời cha ông xưa, chính là những tấm phên, liếp bằng tre, lá hay rào, dậu cây xanh quanh nhà. Từ thập niên 50-70, các loại lam chắn bằng bê tông bắt đầu xuất hiện, với nhiều tạo hình phong phú, không chỉ giúp chống nắng nóng mà còn làm đẹp cho kiến trúc mặt ngoài. 

Ngoài tác dụng chắn nắng gắt, tại các đô thị, hệ lam mặt ngoài công trình còn giúp ngăn bụi, mưa tạt, giảm tiếng ồn và đảm bảo sự riêng tư cho không gian phía trong. Về mặt phong thủy, lam chắn chính là vật dụng hữu hiệu để giảm các năng lượng trực xung tác động từ phía bên ngoài, tạo ra không gian an yên cho người cư ngụ, nhất là ở những vị trí gần đường lớn. Do đó, việc sử dụng lam chắn có rất nhiều tác dụng, chứ không đơn giản chỉ là chống nắng, gia chủ nên có sự đầu tư phù hợp. Lựa chọn chất liệu, hình thức lam phù hợp hướng nhà, kiểu nhà

Gia chủ có thể căn cứ vào một vài gợi ý dưới đây để lựa chọn lam che phù hợp với nhu cầu, sở thích và khả năng kinh tế:

- Về hình thức:

Lựa chọn hình thức lam chắn, ngoài dựa vào sở thích cá nhân (có người thích vây bọc kín quanh nhà, có người thích thoáng đãng) nên căn cứ vào điều kiện ngoại cảnh phía ngoài công trình.

Cụ thể, nếu ngôi nhà có kiến trúc biệt thự, nhà vườn, xung quanh nhiều cây xanh, vườn tược, mặt nước mát mẻ… thì chỉ cần dùng lam ở mặt có nắng gắt, gió lùa, ưu tiên mặt thoáng mở về nơi có khung cảnh đẹp. Ở những hướng thuận lợi về khí hậu như Đông, Đông Nam, Nam… lam chắn chủ yếu đáp ứng tính thẩm mỹ hoặc đảm bảo riêng tư thì cần bố trí mặt rỗng nhiều hơn, tăng cảm giác gần gũi với thiên nhiên. Hệ lam nên có kiểu dáng nhẹ nhàng, tốt nhất nên chọn loại có thể di chuyển linh hoạt để giảm các tác động ngoại cảnh trực tiếp từ bên ngoài mà vẫn đảm bảo thẩm mỹ.

Ngược lại với nhà phố mặt tiền đường, xung quanh ồn ào, nhiều khói bụi, nên xử lý lam đặc nhiều hơn, chỉ cần đảm bảo phần rỗng vừa đủ để thông gió và lấy thoáng. Nếu mặt thoáng đồng thời là hướng nắng gắt, nên ưu tiên loại lam cố định như tường gạch hoa hay dạng nan dọc, xiên. Nếu mặt thoáng ở hướng khí hậu mát mẻ, có thể giảm bớt phần đặc, tăng phần rỗng, chọn loại lam có thể di động điều chỉnh khoảng hở như lam lá liễu, lam cuốn… - Về chất liệu:

Theo xu hướng phát triển của ngành xây dựng, kiến trúc, lam chắn mặt tiền nhà ngày càng đa dạng về chất liệu, kiểu dáng. Ngoài chất liệu phổ biến là bê tông còn có kính, tấm tản nhiệt, hợp kim nhôm, gỗ tự nhiên, gỗ nhựa…

Lam bằng bê tông phù hợp với những mặt tiền nhà đủ lớn, nằm ở phía khí hậu khắc nghiệt. Loại lam này có ưu điểm giá rẻ, kiểu dáng đa dạng, bền, không cần duy tu bảo dưỡng, nhược điểm là cố định, không thể điều chỉnh theo thời điểm.

Lam kính có tính thẩm mỹ cao nhưng chỉ phù hợp với những hướng khí hậu mát mẻ, nếu hướng có nhiều nắng gắt phải kết hợp thêm rèm che chắn.

Lam bằng hợp kim nhôm hoặc gỗ nhựa được ưa chuộng nhờ kiểu dáng đa dạng, giá vừa phải và có thể linh động điều chỉnh khoảng rỗng – đặc theo nhu cầu hoặc tác động của ánh nắng từng thời điểm trong ngày.

Vài năm gần đây, lam che bằng cây xanh cũng được nhiều người yêu thích nhờ tạo cảm giác mát mẻ, gần gũi thiên nhiên nhưng nhược điểm là dễ thu hút côn trùng và thường xuyên phải tu sửa, chăm sóc.

- Về kích thước:

Nên tính toán kích cỡ lam phù hợp với diện tích mặt tiếp xúc ánh nắng cũng như kiến trúc công trình. Kích thước từng loại còn dựa trên khoảng cách với không gian sử dụng bên trong, phần đặc - rỗng của lam. Với các thiết kế nhà phố hiện đại, dù việc chọn kích thước lam khá linh hoạt nhưng cũng cần tuân theo ý đồ thiết kế và công năng sử dụng cụ thể. Trong phong thủy, việc lựa chọn này chính là dựa trên nguyên tắc “hình theo thế”, giúp đảm bảo sự hài hòa giữa công năng, kiến trúc và thẩm mỹ.

Cân bằng âm dương cho những hướng nhà nhiều nắng gắt Nhà ở phía có nhiều nắng như Tây, Tây Nam, Tây Bắc sẽ có nhiều dương khí. Dương khí quá mạnh thường gây cảm giác bức bối, khó chịu cho người cư ngụ. Do đó, việc lựa chọn lam mặt ngoài nhà ra sao cũng tác động tới cân bằng âm – dương cho ngôi nhà.

- Nếu nhà ở hướng nắng gắt, nên chọn lam có khe hở nhỏ, thậm chí kết hợp khối đặc để giảm bớt bức xạ, tăng thêm bóng đổ, tức là làm giảm Dương khí cho ngôi nhà. Những hướng nhà này phù hợp với lam có cấu trúc đứng, xiên, có thể kết hợp với lam ngang.

- Nếu nhà ở hướng nắng dịu và nhiều gió mát như Đông Nam, Đông thì nên chọn lam thưa thoáng để có thể đón được ánh nắng buổi sáng. Những hướng nhà này phù hợp với lam có cấu trúc ngang.

- Nhà ở các tầng cao có tính Dương mạnh hơn nên cũng cần hệ lam dày hơn để giảm cường độ nắng nóng. Ngược lại, những ngôi nhà thấp tầng hoặc bị công trình khác quây kín,  nhà ở hướng bắc ít nắng... nên mở thêm cửa để có nhiều ánh sáng, nếu dùng lam cũng chọn loại nhẹ nhàng hơn.

Nhìn chung, để có được cấu trúc lam hợp lý, thẩm mỹ và hài hòa công năng cần phân bố hợp lý về vật liệu, tỷ lệ, số lượng, khoảng cách... các mặt đứng bên ngoài và cả không gian từ bên trong nhìn ra. Không nên dùng quá nhiều lam hoặc dùng lam ở hướng ít nắng vì không những mất thẩm mỹ mà còn làm giảm tầm nhìn, ánh sáng, khả năng thông gió cho ngôi nhà.', 6)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (9, N'Ý nghĩa của việc treo tranh đồng theo phong thủy
', CAST(N'2019-10-14T00:00:00.0000000' AS DateTime2), 12, N'Tranh đồng đang được ưa chuộng với những người sành chơi tranh. Nó không chỉ có chức năng trong việc trang trí nhà cửa mà còn mang lại ý nghĩa phong thủy lớn cho gia chủ. Tranh đồng phong thủy Song Long (hai con rồng) Hình tượng rồng thể hiện sức mạnh vũ trụ. Hai con rồng thể hiện tính bao trùm của Âm Dương cùng chầu vào biểu tượng mặt trời là Thái Cực sinh lưỡng nghi (Hai con rồng). Dùng tranh đồng có hình hai con rồng treo ở vị trí phù hợp (hướng Thanh Long) tại phòng khách trong nhà, sảnh văn phòng, phòng làm việc… giúp tạo nên long khí, một nguồn sinh khí có tác dụng to lớn trong phong thủy, giúp cuộc sống yên lành, công việc phát triển vượt bậc…
 
Tranh đồng Long Phụng (Rồng Phượng) Rồng và Phượng vốn là biểu tượng rất cao quý nằm trong bộ Tứ Linh. Rồng tiêu biểu cho cha, người chồng, người quân tử, Hoàng đế. Còn phượng là biểu tượng của người phu nhân, người vợ, Hoàng hậu. Sự kết hợp của Rồng và Phượng là biểu tượng tuyệt vời của hạnh phúc lứa đôi, sự may mắn thịnh vượng về công danh, tài lộc và địa vị xã hội. Dùng tranh Rồng Phượng treo trong phòng ngủ để đem đến một cuộc sống gia đình hoà thuận êm ấm, con cái tốt lành. Treo tại phòng khách sẽ có tác dụng chống lại hung khí, đem đến sự vượng phát tài lộc và công danh. Cũng có thể dùng trong phòng đọc sách, phòng làm việc để tăng cường trí tuệ và sự tăng tiến về học vấn, quan hệ xã hội…
 
Tranh đồng Ngũ Phúc Lâm Môn (bốn chữ) Với lòng ước mong năm mới được đón 5 điều phúc vào nhà, đó là: Phúc - Lộc - Thọ - Khang - Ninh
 
Phúc: nghĩa là những điều may mắn, tốt lành. Phúc thường đi liền với đức: “phúc đức” (những người có đức thì sẽ có phúc)
 
Lộc: nghĩa là lương của các quan lại thời phong kiến, như người ta thường nói "quyền lộc cao trọng". Lại cũng có nghĩa là của cải do Trời, Phật hay các đấng thiêng liêng ban cho, gọi là lộc trời, lộc thánh!
 
Thọ: nghĩa là sống lâu, đây là mong ước ngàn đời của con người. Ngày xưa, tuổi thọ con người rất thấp, chính vì thế mà thọ càng trở thành nỗi ao ước của con người. Người ta đi tìm thuốc trường sinh bất lão để mong kéo dài tuổi thọ. Và dù có được sống đến già, người ta vẫn yêu quý chữ thọ, vẫn muốn sống lâu…
 
Khang: nghĩa là mạnh khỏe, người ta nói rằng người khỏe mạnh thì có trăm điều mong ước, còn người ốm yếu thì chỉ có một ước mong: đó là sức khỏe! Cái mà mọi người, già, trẻ, giàu, nghèo đều mong muốn có chính là sức khỏe!
 
Ninh: nghĩa là bình yên, một cuộc sống bình yên, thanh thản là cần thiết cho bất cứ ai trên cõi đời này. Một gia đình mà vợ chồng bất hòa, con cái hư đốn thì lộc, thọ, khang có bao nhiêu đi chăng nữa cũng là vô nghĩa..
 
Tranh đồng Thuận Buồm Xuôi Gió (thuyền buồm) Thuyền buồm được xem là biểu tượng của thành công trong kinh doanh, nó tượng trưng cho gió, mang lại nhiều cuộc giao dịch kinh doanh tốt đẹp và thu được nhiều lợi nhuận.
 
Treo tranh thuyền buồm tiến về phía bạn dùng để kích hoạt vận may trong kinh doanh, tăng thêm tài lộc…
 
Tranh đồng Cửu Ngư Quần Hội (9 cá chép bên lá sen) “Sen”, chữ Hán đọc là “liên” đồng âm với “liên” (liên tục, liên tiếp, liền nhau), “cá” chữ Hán đọc là “yu” (ngư) đồng âm với “dư” (dư dả). Sen – cá biểu ý cho sự “dư dả liên tục” nghĩa là không phải lúc dư lúc thiếu. Tranh vẽ 9 con cá, lợi dụng sự đồng âm giữa 九 ‘cửu’ là chín và 久 ‘cửu’ là lâu dài để cầu chúc dư dả lâu dài.
 
Ngoài ra, cá chép là biểu tượng cho sự kiên trì, bền chí, linh thiêng và cao quý. Trong truyền thuyết thường câu chuyện cá chép vượt vũ môn hoá rồng, vì thế cá chép được coi như rồng nên cá chép còn là biểu tượng của sự tăng tiến công danh và nổi tiếng. Trong làm ăn buôn bán thì cá chép đại diện cho Thuỷ Khí tức là nguồn tài lộc dồi dào. Cá chép là một trong những vật phẩm vô cùng tốt cho cả hai phương diện công danh và tài lộc.
 
Tranh đồng Song Hạc (2 con hạc) Hạc là biểu tượng của sự may mắn và sự trường thọ bắt nguồn từ xa xưa, dưới thời của hoàng đế Phục Hy (Trung Hoa). Treo tranh hạc ở phía Nam thì sẽ sinh sôi nhiều cơ hội tốt, ở phía Tây thì nó mang vận may cho con trẻ nhà gia chủ, phía đông thì hạc chở khí tốt có lợi cho con trai và cháu trai, và nếu nằm ở phía Tây Bắc, nó kích hoạt sự trường tồn cho cả dòng tộc nhà gia chủ, đặc biệt là tuổi thọ của tộc trưởng.
', 6)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (10, N'9 vị trí tối kỵ đặt bể cá phong thủy trong nhà
', CAST(N'2020-05-09T00:00:00.0000000' AS DateTime2), 9, N'Trong phong thủy, bể cá mang tính Thủy, đại diện cho tài lộc, có tác dụng điều hòa âm dương, tăng cường sinh khí cho ngôi nhà. Tuy nhiên, bể cá cũng mang tính động do có nuôi cá bên trong nên không thể đặt tùy tiện. Để tạo ra những năng lượng tích cực khi đặt bể cá phong thủy trong nhà, cần chú ý 9 vị trí tối kỵ sau đây:
1. Không đặt bể cá phong thủy phía sau sofa phòng khách

Bể cá mang tính động, nếu đặt sau sofa, bàn ghế phòng khách - những nơi cần vững chãi và ổn định - sẽ tạo sự xung đột, bất an cho người trong gia đình, có thể ảnh hưởng đến sự ổn định gia trạch. 2. Không đặt bể cá phong thủy trong hoặc cạnh nhà vệ sinh

Muốn đặt bể cá trong nhà hợp phong thủy chắc chắn phải tránh vị trí bên trong hoặc cạnh nhà vệ sinh. Khu vực vệ sinh hay những góc tối tăm, ẩm thấp trong nhà là những nơi mang nhiều uế khí, tạp khí, mang năng lượng âm, không phù hợp đặt bể cá vốn được xem là đại diện năng lượng dương, tài lộc và hưng thịnh.

3. Không đặt bể cá phong thủy đối diện với bếp đun

Bể cá thuộc Thủy, khu vực bếp thuộc Hỏa, hai hành này có quan hệ tương khắc trong ngũ hành, vì vậy không nên đặt bể cá cạnh bếp hay đối diện với bếp nấu. 

Tại các chung cư hiện nay, do hạn chế về diện tích nên căn hộ thường có thiết kế mở, với phòng khách, khu vực ăn uống và bếp liền kề nhau. Nếu đặt bể cá trong phòng khách, cần chú ý không đặt ở vị trí tạo thành một đường thẳng với bếp đun vì sẽ tạo ra năng lượng xung đột, không tốt cho sức khỏe, nhất là với người nội trợ, hay phải ở trong bếp. 4. Không đặt bể cá phong thủy phía trước bệ thần, hay dưới ban thờ

Theo quan điểm phong thủy, nếu đặt bể cá ở trước tượng thần, như thần Tài, ban thờ sẽ bị rơi vào thế “chính thần hạ thủy”, có thể khiến gia chủ lâm cảnh tán gia bại sản. Việc đặt bể cá phía dưới ban thờ cũng không nên, vì bể cá mang tính động, trong khi khu vực ban thờ cần sự trang nghiêm, yên tĩnh. Hơn nữa, đặt bể cá ở bên dưới, khi lau dọn bàn thờ dễ làm rơi bụi nhang vào bể cá, có thể làm chết cá. 

5. Không đặt bể cá phong thủy ở cửa ra vào

Cửa chính là nơi ra vào của các luồng khí, không thích hợp để đặt bể cá, hơn nữa đặt bể cá ở đây cũng gây cản trở cho việc đi lại của mọi người trong nhà.

Nên đặt bể cá ở bên trái cửa chính, hoặc nửa phía ngoài phòng khách theo hướng hợp với gia chủ, tạo cảnh quan đẹp cho bể, giúp mọi người gần gũi hơn với thiên nhiên, tăng các năng lượng tích cực cho sức khỏe, tinh thần… Đặt bể cá ở khu sinh hoạt chung cũng giúp mọi người có cơ hội chuyện trò vui vẻ cùng nhau hoặc thuận tiện ngắm cá khi căng thẳng mệt mỏi.

6. Không đặt bể cá phong thủy trong phòng ngủ

Phòng ngủ vốn là nơi nghỉ ngơi, rất cần sự yên tĩnh, trong khi bể cá mang tính động, nếu đặt ở đây sẽ dẫn tới tình trạng “âm thịnh dương suy”. Ngoài ra, với bể cá có kích thước từ vừa tới lớn sẽ thường chứa nhiều nước, bên trong có lắp thiết bị tạo bọt, hoạt động liên tục, làm ảnh hưởng tới nhịp sinh học của con người, lâu dài gây cảm giác mệt mỏi, không tốt cho sức khỏe và tâm trạng của người trong phòng. 7. Không đặt bể cá phong thủy ở bên phải ngôi nhà

Trong phong thủy, phía bên phải ngôi nhà chính là phương vị của Bạch Hổ. Đây là khu vực kỵ có nước, do đó không thích hợp đặt bể cá.

8. Không đặt bể cá phong thủy bên dưới các đồ điện tử

Trong cuộc sống hiện đại, hầu hết các gia đình đều sử dụng các thiết bị điện tử như ti vi, điều hòa, tủ lạnh, lò vi sóng... Không nên đặt bể cá ở dưới, bên cạnh hoặc trên bề mặt những món đồ này vì hơi nước hoặc nước trong bể dây ra sẽ khiến đồ điện tử nhanh hỏng.

9. Không nên đặt bể cá phong thủy quá to ở phòng làm việc

Trên bàn làm việc có thể đặt một bể cá phong thủy mini để kích thích tư duy sáng tạo. Tuy nhiên, với một bể các kích thước lớn thì không nên đặt trong phòng làm việc, đặc biệt là phía sau bàn làm việc. Bởi vị trí này cần được giữ tĩnh để tích tụ năng lượng trong khi bể cá mang tính động. Hơn nữa, một bể cá quá lớn cũng dễ khiến mọi người mất tập trung khi làm việc.', 6)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (11, N'11 ý tưởng thiết kế nội thất đơn giản khiến nhà bạn "chất lừ"', CAST(N'2020-03-29T00:00:00.0000000' AS DateTime2), 9, N'Không quá cầu kỳ hay tốn nhiều thời gian, chi phí, những ý tưởng trang trí nội thất đơn giản nhưng sáng tạo dưới đây sẽ biến ngôi nhà của bạn thành một không gian sống ấn tượng và cá tính hơn hẳn.
1. Tường điểm nhấn Để căn phòng thêm phần sống động và thú vị, bạn không cần phải sơn hay trang trí cầu kỳ toàn bộ tường. Hãy chọn ra một bức tường để sơn hoặc trang trí bằng những tấm gỗ như trong ảnh minh họa trên. Đây sẽ là điểm nhấn của căn phòng, thu hút mọi ánh nhìn mà không khiến không gian bị ngợp.  

2. Đồ nội thất trong suốt Ý tưởng này đặc biệt hiệu quả đối với các căn hộ diện tích nhỏ, vì đồ nội thất trong suốt có thể tạo ảo giác về không gian, khiến nhà như rộng thêm, đồng thời mang đến cảm giác nhẹ nhàng và thoáng mát.  

3. Đồ nội thất DIY Chỉ với vài nguyên liệu dễ tìm như sơn, gỗ, bạn có thể biến những món đồ nội thất thông thường thành các tác phẩm thiết kế độc nhất vô nhị. Đừng ngại thử, có thể chính bạn cũng phải bất ngờ với khả năng sáng tạo của mình đấy! 

4. Gương giả cửa sổ Một chiếc gương được làm giống với cửa sổ không chỉ khiến không gian như rộng hơn mà căn phòng của bạn cũng trở nên nhẹ nhàng, thanh thoát, đặc biệt là khi bạn đặt gương đối diện với một khung cửa sổ thực sự.

5. Hoa và cây cảnh Thực vật có khả năng thổi sức sống vào các thiết kế nhà dù tẻ nhạt, nhàm chán nhất, đồng thời giúp cải thiện đáng kể chất lượng không khí trong phòng. Bạn có thể đặt những chậu hoa, cây cảnh ở các góc khác nhau của căn phòng hoặc gom tất cả lại, xếp lên một chiếc kệ trang trí.

6. Vách ngăn phòng linh hoạt Vách ngăn phòng rất hữu ích trong việc chia tách không gian của bạn thành nhiều khu vực nhỏ và gọn gàng hơn. Tuy nhiên, không nhất thiết phải lắp đặt hệ vách ngăn thực sự, bạn hoàn toàn có thể sử dụng tủ, kệ kiểu mở và linh hoạt trong cách sắp xếp, bày trí đồ để thường xuyên làm mới không gian, tránh sự nhàm chán.

7. Sách Không cần phải giấu những cuốn sách của bạn trong tủ sách, thay vào đó, hãy trưng bày sách như một món đồ trang trí nội thất thực sự. Phần gáy đầy màu sắc của những cuốn sách sẽ là một điểm nhấn thú vị cho không gian phòng khách, góc thư giãn hay phòng ngủ.  

8. Ghế nhiều kiểu Kê những chiếc ghế giống hệt nhau quanh bàn ăn là một cách sắp đặt thật lỗi thời và nhàm chán. Các chuyên gia thiết kế nội thất hiện đại gợi ý nên ứng dụng nhiều kiểu ghế trong cùng một không gian để tạo cảm giác mới lạ, thú vị hơn. Tuy nhiên, bạn không nên chọn những chiếc ghế quá khác biệt mà hãy đảm bảo chúng “hợp rơ” với nhau ở một mặt nào đó, ví dụ như màu sắc hoặc phong cách có nét tương đồng.  

9. Treo đèn sáng tạo Trong ảnh minh họa trên, không gian phòng ngủ trở nên ấm cúng và thơ mộng hơn hẳn nhờ nguồn sáng dịu mắt từ dây đèn fairy light (đèn đom đóm). Chủ nhân của căn phòng còn tận dụng dây đèn này để treo những bức ảnh nhỏ, lưu lại những khoảnh khắc đáng nhớ, tạo cảm giác bình yên và thư giãn cho không gian nghỉ ngơi sau một ngày dài. 

10. Góc thư giãn bên cửa sổ   Không gian bên cửa sổ là một nơi lý tưởng để thư giãn. Hãy đặt một chiếc ghế thật thoải mái ở vị trí này, thậm chí nếu điều kiện cho phép, bạn có thể kê hẳn một bộ sofa để nằm đọc sách hay chợp mắt khi muốn.

11. Phòng ngủ “trong rừng” Nếu thực sự yêu thiên nhiên và mong muốn làm một điều gì đấy thật “chất” cho ngôi nhà của mình, bạn có thể kết hợp yếu tố này vào không gian sống. Ví dụ, trong ảnh minh họa trên, gia chủ sử dụng hệ thống cột gỗ, treo tranh phủ kín tường theo chủ đề rừng cây và đặt một chiếc giường treo để tạo ảo giác như đây là một căn nhà kính giữa rừng. Căn phòng không chỉ khiến gia chủ rất hài lòng mà còn gây ấn tượng sâu sắc với những vị khách ghé thăm. Dù ý tưởng này cần đầu tư hơn một chút so với các gợi ý phía trên, hiệu quả đạt được thực sự xứng đáng.', 5)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (12, N'Giấc mơ "thành phố phía Đông"
', CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), 9, N'Các chuyên gia trong lĩnh vực đô thị khẳng định "Thành phố trong thành phố" hay "thành phố phía Đông" là một chủ trương đúng, một định hướng tốt về mặt đô thị của TP.HCM.
Thủ tướng Nguyễn Xuân Phúc trong buổi làm việc mới đây đã bày tỏ ủng hộ đề xuất của TP.HCM về khu đô thị sáng tạo phía Đông, một thành phố trong thành phố để “đầu tàu kinh tế” của cả nước có cơ hội đột phá trong tăng trưởng và phát triển. Ý tưởng thành lập khu đô thị sáng tạo tương tác cao phía Đông (thành phố phía đông) được lãnh đạo TP.HCM ấp ủ nhiều năm qua. TP.HCM cũng tổ chức nhiều hội nghị, hội thảo và cuộc thi ý tưởng quy hoạch quốc tế… để cụ thể hóa các ý tưởng thành bộ khung pháp lý về quy hoạch, xây dựng. 

Tại Diễn đàn kinh tế TP.HCM 2018 diễn ra vào cuối tháng 11/2018, lãnh đạo UBND TP.HCM đã nêu ý tưởng xây dựng khu đông của thành phố trở thành khu đô thị sáng tạo. Đây sẽ là hạt nhân để dẫn đầu và thúc đẩy phát triển kinh tế thành phố và khu vực phía Nam trong bối cảnh cách mạng công nghiệp 4.0. Khu đô thị sáng tạo phía đông dựa trên các trụ cột có sẵn là Khu công nghệ cao (quận 9), Đại học Quốc gia TP.HCM (quận Thủ Đức) và Khu đô thị mới Thủ Thiêm (quận 2). 

Ông Diệp Văn Sơn, Nguyên Phó Vụ trưởng Cơ quan Thường trực phía Nam của Bộ Nội vụ từng thừa nhận việc chọn hướng đột phá về Khu đô thị sáng tạo tương tác cao phía Đông TP để định hướng tổ chức lại đơn vị hành chính TP thuộc TP là phù hợp với tình hình thực tế hiện nay.

Nhìn ra thế giới thì việc đề xuất mô hình “thành phố mới” nhằm tăng tốc và đẩy mạnh phát triển một khu vực hay một quốc gia đã được sử dụng từ rất lâu vì đô thị luôn được xem là một động cơ thúc đẩy tăng trưởng và bứt phá kinh tế hữu hiệu.

Tuy nhiên, để các “thành phố mới” này có thể làm tròn nghĩa vụ của mình cần cả một hệ thống chính sách mới được đi kèm với những chiến lược phát triển hay cơ chế quản lý đặc thù được thiết lập riêng, thậm chí chấp nhận sửa đổi cả khung pháp lý nhằm tạo nên một nền tảng riêng biệt cũng như một sự “tự do” nhất định thông qua một số “đặc quyền” mà các thực thể này có được. Đơn cử, khu Phố Đông - Thượng Hải, cách đây 30 năm chỉ là bãi đất trống, nhà thấp tầng nhưng bây giờ là những tòa nhà chọc trời, quy tụ những doanh nghiệp hàng đầu tại khu trung tâm tài chính Lục Gia Thủy, nằm bên bờ sông Hoàng Phố.

Ông Gao Chengyong, Ủy viên Ủy ban Công nghệ, Cục Phát triển Đô thị Thượng Hải cho biết: "Việc xây dựng sân bay quốc tế Phố Đông đã mang đến những điều kiện thuận lợi để phát triển khu Phố Đông. Trong quá trình phát triển khu phố Đông, vì việc quy hoạch là rất quan trọng, mọi phương diện đều phải được cân nhắc kĩ lưỡng, bao gồm việc quy hoạch giao thông, ứng phó biến đổi khí hậu, và sự phát triển dân số về sau này". Ngoài ra, với nhiều chính sách thu hút đầu tư đổi mới theo tư duy thị trường như giao quyền quyết định, tự chịu trách nhiệm cho cấp chính quyền địa phương, đẩy mạnh hợp tác công tư, rút gọn thủ tục chấp thuận đầu tư trong và ngoài nước chỉ còn 7 ngày… đã giúp kinh tế khu vực này phát triển nhanh chóng, đóng góp hơn 1 nửa ngân sách cho thành phố Thượng Hải với con số hàng trăm tỷ USD mỗi năm, giúp Thượng Hải hiện trở thành là 1 trong 5 trung tâm tài chính hàng đầu trên thế giới.

Cũng theo ông Gao Chengyong, ở Phố Đông, chính sách bồi thường thiệt hại, tái định cư và ổn định đời sống dựa vào 2 tiêu chí. Thứ nhất: Tạo chỗ ở cho người dân tốt hơn nơi cũ. Theo đó, công ty khai phát đứng ra bồi thường, giải phóng mặt bằng, không giải tỏa trắng như ở ta mà cố gắng bố trí gần chỗ ở cũ. Dân thấy chỗ ở mới tốt hơn nơi cũ nên hầu hết giao đất để xây dựng Phố Đông.

Thứ hai: Tạo công ăn việc làm để dân có thu nhập sống được. Đối với người trẻ, công ty đào tạo và sắp xếp để tạo việc làm; nếu không còn tuổi lao động sẽ được hưởng chế độ BHXH để có thu nhập ổn định đến cuối đời; nếu đã lớn tuổi nhưng chưa hết tuổi lao động, chính quyền sắp xếp các công việc dịch vụ đô thị hoặc các dịch vụ khác trong khu khai phát để tạo việc làm.

Chuyên gia quy hoạch đô thị Ngô Viết Nam Sơn góp ý TP.HCM có thể tham khảo mô hình vùng đô thị Paris của Pháp. Vùng đô thị Paris của Pháp có quy mô dân số hơn 12 triệu dân, diện tích 17.000km2.

Thủ đô Paris có diện tích không lớn, chỉ 105km2 với dân số khoảng 2,3 triệu người. Nhưng ba tỉnh ráp ranh thuộc vùng đô thị Pari là Seine Saint Denis, Val de Marne và Hauts de Seine, mặc dù là độc lập nhưng phát triển theo hướng chỉ đạo chung của trung tâm thủ đô Paris. 

Nếu làm tốt thì thành phố phía Đông của TP.HCM tương lai sẽ giống với khu Hauts de Seine của Paris, là nơi bao gồm khu trung tâm mới cao tầng La Défense với những cao ốc kinh tế - tài chính, hạ tầng hiện đại và thu hút dân cư trí thức có thu nhập cao. Còn khu trung tâm hiện hữu với bề dày lịch sử sẽ được bảo tồn và đẩy mạnh phát triển du lịch. 

“Nếu TP.HCM xây dựng được thành phố phía Đông thì trong tương lai, thu nhập của người dân thành phố có thể sẽ gấp đôi hiện tại và đóng góp ngân sách thành phố cho Trung ương cũng gấp đôi”, ông Sơn kỳ vọng. 

Thành phố phía Đông dự báo sẽ đóng góp khoảng 30% GDP của TP.HCM, tương đương mức GDP của nhiều tỉnh khác cộng lại và sẽ là nguồn lực tăng trưởng mới của TP.HCM. Dự kiến, thành phố phía Đông sẽ có diện tích tự nhiên 211,5km2, quy mô dân số hơn 1,1 triệu người.', 4)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (13, N'Phân khúc bất động sản nào là điểm sáng thời kì hậu Covid-19?
', CAST(N'2020-06-09T00:00:00.0000000' AS DateTime2), 15, N'Đại dịch Covid-19 đã khiến thị trường bất động sản Việt Nam trải qua một giai đoạn khó khăn. Đến thời điểm hiện tại, Việt Nam đã cơ bản kiểm soát được dịch bệnh. Hậu Covid-19, phân khúc bất động sản nào sẽ là điểm sáng của thị trường?
Tại tọa đàm "Thăng trầm bất động sản 2010-2020 và những xu hướng sắp tới" do Hội Doanh nhân trẻ Việt Nam, Câu lạc bộ Doanh nhân Sao Đỏ phối hợp tổ chức, các chuyên gia đã đưa ra nhiều nhận định về thị trường sau dịch Covid-19. 

Theo ông Nguyễn Mạnh Hà - Phó Chủ tịch Hiệp hội Bất động sản Việt Nam thì những khó khăn của thị trường ở thời điểm hiện tại khác với những khó khăn mà thị trường phải đối mặt của 10 năm trước. Cuộc khủng hoảng bất động sản 10 năm trước có căn nguyên là sự dư thừa nguồn cung, trong khi thị trường hiện tại lại đang thiếu nguồn hàng do động thái kiểm soát nghiêm ngặt của cơ quan chức năng về việc cấp phép và siết tín dụng bất động sản. 

Ông Hà nhấn mạnh bất động sản nhà ở vẫn là nhu cầu thiết yếu. Dù Covid-19 là một cú bồi khiến thị trường thêm khó khăn nhưng nhu cầu mua ở thực vẫn luôn hiện hữu và thường trực, vấn đề chỉ là có sản phẩm phù hợp hay không. Trong phát triển sản phẩm nhà ở, cần suy tính đến nhu cầu tương lai với xu hướng nâng cao chất lượng như phát triển nhà thông minh, công trình xanh. Bên cạnh đó, ông Hà cho rằng bất động sản công nghiệp sẽ là điểm sáng của thị trường trong những năm tới. Đón sự dịch chuyển của làn sóng đầu tư, cộng hưởng với hàng loạt lợi thế như quỹ đất dồi dào, giá nhân công rẻ, chính sách ưu đãi của từng địa phương, phân khúc này chắc chắn sẽ bùng nổ. Ông Hà nhấn mạnh, điều quan trọng, doanh nghiệp, doanh nhân không nên phụ thuộc thị trường mà phải đóng vai trò dẫn dắt thị trường. 

Đồng quan điểm, bà Hà Thu Thanh, Chủ tịch Deloitte Việt Nam cho rằng dù đại dịch Covid-19 gây ra nhiều khó khăn nhưng bà vẫn lạc quan với thị trường trong tương lai. Bất động sản nhà ở, bất động sản văn phòng và bất động công nghiệp sẽ là điểm sáng của thị trường do xu hướng dịch chuyển sản xuất. Trong những phân khúc trên, bất động sản công nghiệp sẽ là điểm sáng nhất do đón làn sóng dịch chuyển, đón xu thế tái cấu trúc, Trung Quốc +1. Tuy nhiên, để bất động sản công nghiệp trở thành điểm sáng thực sự thì vấn đề không chỉ nằm ở ưu đãi thuế, giảm giá đất mà phải là sự kết nối hạ tầng, sự phát triển của logistic, công nghệ phụ trợ.

Bày tỏ quan điểm về xu hướng thị trường trong tương lai, ông Đặng Hồng Anh, Phó Chủ tịch Tập đoàn TTC cho rằng trong ngắn hạn thì hết năm nay có thể thị trường sẽ khởi sắc trở lại. Hiện thị trường đang có nhiều kênh đầu tư tốt hơn và người dân vẫn có tâm lý chờ bất động sản xuống giá. Về dài hạn, bất động sản sẽ vẫn là kênh đầu tư tiềm năng do dân số trẻ, nhu cầu nhà ở lớn và mức sống của người dân ngày càng một nâng cao. 

Nhận định về bất động sản công nghiệp, ông Trịnh Văn Quyết, chủ tịch tập đoàn FLC cho rằng nhiều chuyên gia đang lạc quan về tiềm năng lớn của bất động sản công nghiệp khi làn sóng dịch chuyển đầu tư từ Trung Quốc đổ về các nước lân cận, trong đó có Việt Nam. Tuy nhiên, ông Quyết cảnh báo xu hướng phong trào, nhà nhà đua nhau làm bất động sản công nghiệp là rất nguy hiểm. Bất động sản công nghiệp không đơn thuần chỉ là khu công nghiệp với nhà máy, công xưởng… mà cần phải được phát triển như một quần thể trong đó có nhà ở cho công nhân. “Tôi không quá lạc quan vào bất động sản công nghiệp”, người đứng đầu tập đoàn FLC chia sẻ. 

Dù không lạc quan vào bất động sản công nghiệp nhưng ông Quyết bày tỏ sự lạc quan về thị trường. Ông cho biết FLC đã có khoảng thời gian dài đồng hành cùng thị trường bất động sản Việt Nam, đã đi cùng và vượt qua những giai đoạn khủng hoảng như 2008, 2013 với kết quả tích cực. Do đó, với Covid-19, dù phải đối mặt với nhiều khó khăn, nhưng ông vẫn tin tưởng vào sự hồi phục và phát triển của thị trường trong thời gian tới. Ông nhận định đây là thời điểm vàng để xuống tiền mua bất động sản, cả với những người tích lũy ít đến đầu tư lớn. ', 4)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (14, N'Vì sao giá nhà liên tục tăng phi mã qua các năm?
', CAST(N'2020-06-08T00:00:00.0000000' AS DateTime2), 10, N'Tại tọa đàm "Thăng trầm bất động sản 2010-2020 và những xu hướng sắp tới" do Hội Doanh nhân trẻ Việt Nam, Câu lạc bộ Doanh nhân Sao Đỏ tổ chức, các diễn giả đã đưa ra lý giải về việc giá nhà tại các đô thị lớn như Hà Nội, TP.HCM liên tục tăng phi mã những năm gần đây khiến khả năng tiếp cận nhà ở của đa phần dân chúng ngày càng khó khăn. Ông Đỗ Anh Dũng, Chủ tịch Tập đoàn Tân Hoàng Minh, cho biết sở dĩ giá nhà đất liên tục tăng cao trong suốt 5 năm qua có một phần nguyên nhân lớn đến từ chính sách, pháp lý và sự biến động liên tục của chính sách tín dụng ngân hàng. Sự nhiêu khê, phức tạp của pháp lý, thủ tục hành chính đã kéo dài thời gian hoàn thiện một dự án bất động sản.

Ông Dũng dẫn chứng năm 2007, Tân Hoàng Minh có mua một khu đất để phát triển dự án. Thế nhưng sau 14 năm giải quyết hàng loạt vấn đề như giải tỏa mặt bằng, thủ tục pháp lý..., đến nay vẫn chưa xong các thủ tục và nhà vẫn chưa xây được. Vướng mắc pháp lý đã khiến tiến độ dự án bất động sản bị chậm lại. Hai năm qua, trong khi thị trường liên tục biến động thì có những chính sách không còn phù hợp với thị trường vẫn chưa thay đổi. 

“Trong kinh doanh bất động sản vị trí đóng vai trò quyết định đến giá thành, thanh khoản và lợi nhuận. Thế nhưng dù vị trí có đẹp đến đâu nhưng dự án đóng băng 10, 20 năm vì pháp lý thì vẫn lỗ vốn như thường”, ông chủ Tân Hoàng Minh nhấn mạnh.

Chủ tịch Tân Hoàng Minh kiến nghị thủ tục hành chính cần sát nhập những quy định gần nhau làm một và rút ngắn trong vòng một năm. Các chính sách của Chính phủ cũng cần mang hơi thở thị trường, cập nhật những biến động của thị trường để có thể kịp điều chỉnh cho sát thực tế. Thị trường thay đổi thì các chính sách cần coi đó như căn cứ để có sự linh hoạt thay đổi theo. Các quy luật cung cầu của thị trường cần phải được áp dụng triệt để.

Bên cạnh đó, một thách thức mà thị trường bất động sản phải đối mặt là “room” cho vay bất động sản liên tục thay đổi, không có sự nhất quán. Ông Dũng cho rằng cho vay dự án bất động sản phải là cho vay 5 năm trở lên, các chính sách tín dụng cần có sự thống nhất trong khoảng thời gian này, không được thay đổi giữa chừng.  Ông Dũng cho biết việc giá nhà lên cao liên tục trong những năm qua là bởi phải gánh chi phí đội lên, phát sinh trong quá trình chờ đợi thủ tục hành chính, gánh những biến động giữa chừng của tín dụng ngân hàng trước khi dự án được đưa vào xây dựng, vận hành. Tất cả những chi phí đó đều phải tính vào giá thành nên giá nhà liên tục tăng cao qua các năm. Những bất cập trên khiến chủ đầu tư khó khăn, người dân không được hưởng cái giá lúc đầu.

Đồng quan điểm, ông Trịnh Văn Quyết, chủ tịch Tập đoàn FLC cho biết pháp lý đang là rào cản lớn của thị trường bất động sản, là một trong những nguyên nhân lớn đẩy giá nhà lên cao. Luật pháp đi theo thị trường nhưng lại khá chậm trễ trong việc bắt nhịp thị trường. Nhiều dự án của FLC mất rất nhiều thời gian để hoàn tthiện pháp lý. Đơn cử, có những dự án quy mô lên tới hàng trăm ha, trải qua và tuân theo rất nhiều trình tự thủ tục từ đấu thầu đến đấu giá. 

Đáng nói, ở mỗi địa phương, cách hiểu về luật pháp lại khác nhau khiến doanh nghiệp vô cùng khốn đốn. FLC Sầm Sơn được khởi công từ năm 2015 nhưng phải mất đến 11 tháng vừa thi công cho từng công đoạn ép cọc, xây thân vừa hoàn thiện giấy tờ pháp lý. Ông Quyết nhấn mạnh với cơ chế như hiện nay doanh nghiệp phải mất ít nhất 3 năm mới có thể hoàn thiện giấy phép để thi công sau khi hoàn thành đầy đủ thủ tục pháp lý. Đây thực sự là một vấn đề nan giải với doanh nghiệp bất động sản. Pháp lý thực sự trở thành một nỗi sợ của doanh nghiệp bất động sản. Chính sự nhiêu khê, phức tạp của thủ tục pháp lý đang làm gia tăng hàng loạt chi phí trong quá trình phát triển sản phẩm của doanh nghiệp, buộc doanh nghiệp phải tính các chi phí này vào sản phẩm và giá nhà ngày một lên cao. ', 4)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (15, N'Lạc hậu cách định giá đất
', CAST(N'2020-06-05T00:00:00.0000000' AS DateTime2), 10, N'Mặc dù mới ban hành bảng giá đất hồi giữa tháng 1/2020 nhưng mới đây UBND TP.HCM đã yêu cầu Sở TNMT rà soát, cập nhật, sửa đổi, bổ sung bảng giá đất mới trong tháng 9/2020.
Trước đó, Đà Nẵng cũng đã sửa bảng giá đất vừa ban hành. PGS. TS. Nguyễn Văn Xa, Nguyên Cục trưởng Cục quản lý công sản - Bộ Tài chính chỉ rõ, nghiên cứu bảng giá đất một số địa phương đã bộc lộ một số vấn đề sau: Một là, giá đất phi nông nghiệp được chia nhỏ cho các loại đất: Đất ở, đất thương mại, dịch vụ; đất sản xuất kinh doanh phi nông nghiệp không phải là đất thương mại, dịch vụ (gọi tắt là đất phi nông nghiệp), chạy theo thực tế sử dụng đất, coi đất như một tài sản được quản lý bằng phép cộng, trừ; chưa coi đất và quản lý đất bằng biện pháp kinh tế đã bị lợi dụng chuyển mục đích sử dụng từ các loại đất khác sang đất ở, tránh đấu giá. Thực tế một căn nhà có thể vừa để ở, vừa làm nơi bán hàng, lớn hơn là một tòa nhà hỗn hợp (ở, thương mại, dịch vụ, hoạt động, giáo dục, đào tạo, thể dục thể thao v.v...); do đó chia nhỏ thành nhiều loại đất theo mục đích sử dụng cụ thể để quản lý là phi kinh tế.

Hai là, thực tế thị trường đất đai tại đô thị và khu dân cư nông thôn không hình thành giá các loại đất phi nông nghiệp không phải là đất ở; Vì thế, việc xác định giá đất phi nông nghiệp theo các mục đích sử dụng như quy định khung giá các loại đất, không phù hợp với việc hình thành giá đất trên thị trường. Do đó, nhiều địa phương khi xây dựng các bảng giá đất phi nông nghiệp: đất thương mại, dịch vụ; đất sản xuất kinh doanh phi nông nghiệp đều dựa vào bảng giá đất ở để bấm độn.

Tại các đô thị rất khó hoặc không thể phân biệt đâu là đất ở, đâu là các loại đất phi nông nghiệp; đất ở và các loại đất phi nông nghiệp đều là đất có công trình xây dựng đơn năng hoặc đa năng, có khu vực nhà ở xen kẽ các công trình khác; chủ sở hữu công trình sẵn sàng chuyển công năng sử dụng vì mục đích kinh tế hoặc để ở.

PGS. TS. Nguyễn Văn Xa dẫn chứng, nghiên cứu bảng giá đất của 16 địa phương thì có 14 tỉnh Thành phố trực thuộc Trung ương xác định giá đất phi nông nghiệp, đất thương mại, dịch vụ bằng tỷ lệ % trên giá đất ở liền kề cùng vị trí, cùng đường phố, cùng khu vực (đối với đất tại nông thôn) 01 địa phương quy định mức giá cụ thể tại bảng giá đất phi nông nghiệp không phải là thương mại, dịch vụ, bảng giá đất thương mại dịch vụ; song nghiên cứu kỹ thì thấy đều đúng vị trí, đường phố, khu vực của bảng giá đất ở và quan hệ giữa đất phi nông nghiệp, giá đất thương mại dịch vụ so với giá đất ở đều thống nhất theo một tỷ lệ % nhất định.

"Chỉ có 01 (một) địa phương quy định ba bảng giá đất: Đất ở, đất thương mại, dịch vụ, đất sản xuất kinh doanh phi nông nghiệp. Nhưng bảng giá đất thương mại dịch vụ và bảng giá đất sản xuất kinh doanh phi nông nghiệp đều trùng khớp đường phố hoặc khu vực (đối với đất ở nông thôn) và vị trí với bảng giá đất ở", ông Xa cho biết.

Ở khía cạnh khác, PGS.TS Ngô trí Long, Chuyên gia kinh tế chỉ rõ, toàn bộ quy trình định giá đất đều do cơ quan hành chính nhà nước thực hiện, người bị thu hồi đất đứng ngoài quy trình. "Mặc dù Điều 115 và 116 có nói đến tư vấn giá đất nhưng cũng chưa có quy định bảo đảm cho tổ chức tư vấn giá đất thực sự có vị trí độc lập... do vậy giá đất mang nặng tính “áp đặt”. Có thể nói tất cả các trường hợp (gần như tuyệt đối) giá đất đều thấp xa so với giá thị trường ở mọi thời điểm".

Ông Long dẫn chứng, Dự án Khu đô thị Thủ Thiêm là một trong những minh chứng, giá đất đền bù quá chênh lệch với giá thị trường. Dự án Khu đô thị Thủ Thiêm được triển khai đã hơn 20 năm nhưng công tác giải phóng mặt bằng vẫn chưa hoàn thành, người dân khiếu kiện tập thể kéo dài, giá đất đền bù cho người dân là 18 triệu đồng/m2, công ty bất động sản bán lại giá 350 triệu đồng/m2.

Ở các nước phát triển khi giá đất được công bố rộng rãi, mức độ sai lệch chỉ ở mức 5-7%. Trong khi đó, ở Việt Nam lại rất khác xa so với giá thị trường.

Để khắc phục những hạn chế này, đòi hỏi có thời gian và giải quyết những vấn đề có tính hệ thống, từ nghĩa vụ đến trách nhiệm độ tin cậy và chính xác của các thông tin đã cung cấp và công bố. Thông tin là yếu tố rất quan trọng, cần thiết cho công tác định giá đất. Nguồn thông tin đáng tin cậy sẽ giúp cho các cán bộ định giá đưa ra được những kết luận chính xác.', 4)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (16, N'Giải mã những hiện tượng bất động sản “cháy hàng” mùa dịch', CAST(N'2020-05-29T00:00:00.0000000' AS DateTime2), 9, N'Sau giai đoạn phát triển mạnh mẽ, khoảng 2 năm gần đây, thị trường bất động sản đang phải đối mặt với nhiều khó khăn. Từ động thái siết chặt cấp phép dự án đến kiểm soát tín dụng và tiếp đó là “cú bồi” Covid-19. Trong bối cảnh ảm đạm đó, số ít doanh nghiệp BĐS vẫn “sống khỏe”, đạt được những con số ấn tượng về doanh số, doanh thu. Những doanh nghiệp này đã tìm thấy cơ hội trong thách thức như thế nào?
Hiện tượng condotel của thị trường nghỉ dưỡng

Từ năm 2018, thị trường bất động sản nghỉ dưỡng bắt đầu giảm tốc, condotel từng làm mưa làm gió trên thị trường những năm trước đó rơi vào cảnh bão hòa nguồn cung, thanh khoản giảm mạnh. Thế nhưng Apec Mandala Wyndham Phú Yên trở thành hiện tượng của thị trường khi nhanh chóng “đỏ” bảng hàng trong các đợt mở bán và nhà đầu tư lướt chênh thành công trong thời gian ngắn. Sóng của dự án này tiếp tục lan tới Apec Mandala Wyndham Mũi Né (Bình Thuận). Trong đợt mở bán đầu tiên, Apec Mũi Né tiêu thụ được 1.800 căn chỉ sau 1h mở bán. Sau dịch Covid-19, ở đợt mở bán kế tiếp, Apec Mandala Wyndham Mũi Né tiếp tục gây ấn tượng với số booking cao, khiến giới đầu tư, phát triển bất động sản bất ngờ. Dòng condotel mà Apec đang phát triển trở thành hiện tượng của thị trường nghỉ dưỡng, bất chấp phân khúc này đang trầm lắng và thị trường sau dịch mới từng bước phục hồi. Trao đổi với Batdongsan.com.vn về những con số ấn tượng trên, ông Nguyễn Đỗ Lăng - Chủ tịch HĐQT Công ty CP đầu tư Châu Á – Thái Bình Dương (APEC), cho biết muốn làm dự án bất động sản thành công cần phải có tình yêu. Phải đặt tình yêu vào sản phẩm thì sản phẩm mới được khách hàng đón nhận. Tình yêu đó xuất phát từ sự thấu hiểu: thấu hiểu khách hàng, thấu hiểu thị trường. Có như thế, chủ đầu tư mới có thể tạo nên sản phẩm khách hàng yêu thích và mong muốn. Nói cách khác, bán bất động là bán trải nghiệm, bán cảm xúc, bán ước mơ và hiện thực hóa ước mơ đó. Điều này nghe có vẻ sách vở nhưng đó là giá trị cốt tủy của kinh doanh bất động sản.

Ông Lăng cho biết, condotel của Apec được khai sinh từ quan điểm trên. Từ việc thấu hiểu nhu cầu ngôi nhà thứ 2 của khách hàng, sản phẩm condotel được tung ra với mức giá phù hợp, chỉ từ 600 triệu đồng đến trên dưới 2 tỷ/căn. Từ việc hiểu thực trạng thị trường, Apec tìm hướng phát triển tại những thị trường nghỉ dưỡng mới nổi như Phú Yên, Bình Thuận… thay vì đổ tiền vào các thị trường nghỉ dưỡng truyền thống. Chú trọng trải nghiệm, cảm xúc của khách hàng, đơn vị này đề cao sự độc đáo trong thiết kế, tạo lập cảnh quan, lựa chọn đơn vị vận hành… Sự riêng biệt trong hướng đi đã mang đến thành công cho Apec thời gian qua, bất chấp sự ảm đạm của bất động sản nghỉ dưỡng. Do đó, không khó hiểu khi  đại dịch Covid -19 phức tạp, các công trường của Apec vẫn thi công cả 3 ca và các dự án vẫn bán được hàng. 

Ecopark và 400 căn hộ giao dịch trong một tuần Covid-19 đã khiến bất động sản Hà Nội rơi vào trạng thái trầm lặng, đóng băng. Thế nhưng tòa tháp Sky Oasis (Ecopark) mở bán đợt đầu vào trung tuần tháng 4 vừa qua tiêu thụ hết hơn 400 căn trong 1 tuần. Trong sự kiện mở bán tiếp theo vào tháng 5, 2.000 khách đã phải xếp hàng để mua căn hộ. Sky Oasis đã trở thành hiện tượng của thị trường bất động sản Hà Nội trong bối cảnh đại dịch Covid-19. 

Chia sẻ về sự thành công của Ecopark, ông Đào Ngọc Thanh, cha đẻ của dự án, Chủ tịch Hội đồng Quản trị Vinaconex cho biết, kinh doanh là bán cái ý tưởng của mình thông qua vật mình bán. Trong mọi hoàn cảnh, người kinh doanh phải đặt cái tốt đẹp nhất, nhân văn nhất vào sản phẩm. Bản chất câu chuyện kinh doanh là như vậy. Một dự án bất động sản thành công là dự án kể câu chuyện giàu tính nhân văn một cách cuốn hút. Muốn cuốn hút và hấp dẫn, người làm bất động sản phải tạo ra khác biệt, phải tìm thấy sự khác biệt, không đi vào lối mòn, thách thức sự nhàm chán. Cái đích cuối cùng của câu chuyện là phải tạo được cảm xúc cho khách hàng. 

Theo ông Thanh, Ecopark là một câu chuyện như thế. Đến ngày hôm nay, đây là khu đô thị sinh thái hiếm hoi lớn nhất miền Bắc. Với quy mô gần 500 ha, diện tích cây xanh mặt nước lên tới 100 ha, Ecopark đóng vai trò như lá phổi xanh khổng lồ ở phía Đông Nam thủ đô. Chính không gian sống trong lành hài hòa giữa thiên nhiên và con người này đã tạo nên bản sắc của Ecopark, mang đến những trải nghiệm, cảm xúc rất riêng biệt cho cư dân sống ở đây. ', 4)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (17, N'Vai trò của công nghệ đối với ngành bất động sản trong kỷ nguyên số
', CAST(N'2020-03-20T00:00:00.0000000' AS DateTime2), 1, N'Những năm gần đây, công nghệ đã và đang thể hiện vai trò, giá trị ngày càng rõ nét đối với sự phát triển của ngành bất động sản. Những khái niệm mới như proptech (công nghệ bất động sản) và contech (công nghệ xây dựng) cũng dần trở nên quen thuộc hơn với công chúng. Tuy nhiên, các chuyên gia tin rằng ngành bất động sản vẫn chưa khai thác hết tiềm năng tối đa của công nghệ.
Tại Hội nghị Thượng đỉnh Bất động sản châu Á do PropertyGuru tổ chức vào tháng 11/2019, các chuyên gia, nhà lãnh đạo, quản lý doanh nghiệp bất động sản trong khu vực Đông Nam Á đã tham gia thảo luận về cách ứng dụng công nghệ trong ngành bất động sản nhằm mang lại lợi ích cho doanh nghiệp, người tiêu dùng cũng như bảo vệ môi trường, hướng tới phát triển bền vững. Công nghệ mở đường cho thiết kế bền vững

Theo Giáo sư Jason Pomeroy, người sáng lập kiêm Hiệu trưởng Pomeroy Studio và Học viện Pomeroy chuyên đào tạo các chương trình về phát triển bền vững, công nghệ môi trường ở Singapore, ba trụ cột chính của sự bền vững – bao gồm xã hội, kinh tế và môi trường – là không đủ trong thời đại ngày nay. Tại hội nghị, ông chia sẻ rằng văn hóa, không gian và công nghệ cũng quan trọng tương đương nên có thể được coi là ba trụ cột bổ sung của sự bền vững. Cụ thể:

Văn hóa: Toàn cầu hóa với tốc độ nhanh chóng ở các khu vực đô thị lớn đồng nghĩa với sự tập hợp của các nền văn hóa đa dạng. Như vậy, bảo tồn văn hóa chính là chìa khóa của sự bền vững.

Không gian: Trong một thế giới đô thị hóa cao như hiện nay, tương lai là thứ rất khó định hình trừ khi con người có kế hoạch rõ ràng cho nó. Dự kiến đến năm 2050, có tới 75% dân số toàn cầu sẽ sống ở các đô thị. Câu hỏi đặt ra là làm thế nào để bảo tồn không gian cho sự tương tác xã hội, tránh để mỗi người chỉ dính lấy chiếc điện thoại di động của mình và chìm đắm vào cuộc sống ảo?

Công nghệ: Giáo sư Pomeroy cho rằng công nghệ nên được sử dụng một cách khôn ngoan và tiết kiệm. Mỗi công nghệ được sử dụng đều phải phù hợp với tất cả mọi người, từ trẻ em 6 tuổi cho đến những người 70 tuổi.  

Trong 3 trụ cột bổ sung này, công nghệ thể hiện vai trò ngày càng rõ nét trong sự phát triển bền vững của ngành bất động sản, ứng phó với những biến đổi về khí hậu, môi trường trong tương lai. Giáo sư Pomeroy nêu ví dụ về công nghệ thành phố nổi – một thiết kế bền vững được kì vọng sẽ giải quyết vấn đề dân số quá đông và nước biển dâng ở các đô thị lớn. 

Giáo sư Pomeroy phân tích: “Toàn bộ 35 siêu đô thị của thế giới đều nằm ở vùng đồng bằng dễ bị ngập nước. Những siêu đô thị với dân số hơn 10 triệu người này là những trụ cột thực sự của nền kinh tế toàn cầu. Thay vì cố gắng thiết kế tập trung vào tính thẩm mỹ, chúng ta nên nghĩ về sự phát triển năng động, linh hoạt hơn. Hãy nghĩ về các cộng đồng và thành phố nổi.” 

Hầu hết các thành phố lớn này đều có những bến tàu đang được sử dụng chưa tương xứng với công năng. Đây có thể trở thành địa điểm hoàn hảo để thiết lập các thành phố nổi. Chẳng hạn, tại Ijburg, Amsterdam, Hà Lan, các bến cảng đã được chuyển đổi thành một khu dân cư nổi. Đó là một hình thức đô thị hóa thay thế có giá cả phải chăng, tiết kiệm năng lượng và ứng phó với các vấn đề gây ra do biến đổi khí hậu như mực nước biển dâng cao.

Công nghệ tạo điều kiện gắn kết xã hội và cải thiện chất lượng cuộc sống

Giáo sư Nadia Magnenat Thalmann, người sáng lập kiêm Giám đốc phòng nghiên cứu MIRALab tại Đại học Geneva (Thụy Sĩ) chia sẻ đội ngũ của bà đã phát triển các mẫu robot xã hội phục vụ các lợi ích thương mại cũng như cá nhân. Một trong những robot này được gọi là robot xã hội Nadine, hiện đã hoạt động được vài tháng với tư cách là đại lý khách hàng tại công ty bảo hiểm AIA Singapore.

Được biết, robot Nadine có thể hỗ trợ các nhân viên công ty trong giờ cao điểm, xử lý các nhiệm vụ cơ bản và trả lời các câu hỏi đơn giản của khách hàng để các nhân viên đại lý khách hàng có thời gian tập trung vào các nhiệm vụ phức tạp hơn.

Ngoài môi trường thương mại, Nadine có thể phục vụ như một người bạn đồng hành lý tưởng với người già. Robot này được thiết kế với các tính năng mô phỏng người thật, có khả năng hiểu được cảm xúc, cử chỉ của người già, xử lý các tình huống cần hỗ trợ, từ đó cải thiện chất lượng cuộc sống của họ. 

Công nghệ đảm bảo sử dụng hiệu quả tài nguyên

Ông Stefan Rafael, Giám đốc Công nghệ tại One To One Display - một trung tâm trình chiếu phối cảnh các thiết kế xây dựng - cho biết thông qua công nghệ, trung tâm này có thể cải tiến giai đoạn lập kế hoạch phát triển dự án bất động sản, giúp chủ đầu tư giảm lượng khí thải carbon trong quá trình này. Nhờ công nghệ, các bên tham gia dự án có thể trải nghiệm thiết kế, không gian nội và ngoại thất ngay từ khi dự án chưa được thi công, loại bỏ nhu cầu xây dựng phòng trưng hay nhà mẫu, từ đó giảm thiểu các vật liệu bị lãng phí.

Ngành bất động sản có thể đã chấp nhận vai trò, giá trị của công nghệ trong việc tối ưu hóa hoạt động xây dựng, kinh doanh bất động sản, nâng cao chất lượng cuộc sống của người tiêu dùng. Tuy nhiên, công nghệ vẫn chưa được sử dụng hết tiềm năng của nó. Hy vọng rằng với những ý tưởng và sáng tạo được chia sẻ bởi các chuyên gia và nhà lãnh đạo, chúng ta sẽ sớm được thấy các giải pháp công nghệ vượt trội, giải quyết được những vấn đề lớn hơn của ngành bất động sản trong tương lai. ', 4)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (18, N'Người nước ngoài “lách luật” sở hữu đất tại Việt Nam: Cần tính đến việc điều chỉnh Luật
', CAST(N'2020-05-22T00:00:00.0000000' AS DateTime2), 12, N'Đã đến lúc tính đến việc điều chỉnh Luật để giải quyết vấn đề an ninh quốc phòng liên quan đến việc người nước ngoài sở hữu BĐS “đắc địa” tại Việt Nam.
 Luật không sai nên không thể xử lý
Trước thực trạng có đến 149 doanh nghiệp Trung Quốc ''sở hữu'' đất biên giới, chia sẻ với DĐDN mới đây, TS.KTS Đào Ngọc Nghiêm - Phó Chủ tịch Hội Quy hoạch Phát triển Đô thị Hà Nội cho rằng về hình thức, việc người Việt đứng tên các BĐS đắc địa và các doanh nghiệp (bao gồm cả liên doanh, FDI, cổ phần có yếu tố nước ngoài, cụ thể là Trung Quốc) được phép thuê có thời hạn các BĐS là phù hợp với các quy định của pháp luật.

Cụ thể, đối với các doanh nghiệp có dự án tại các BĐS “đắc địa”, các tổ chức của Trung Quốc lúc đầu thường có tỷ trọng sở hữu thấp, sau đó họ dần mua lại, thâu tóm khiến tỷ lệ sở hữu của người Việt Nam dần mất đi. Việc thông qua doanh nghiệp Việt Nam sở hữu các nhà ở, thuê dài hạn các dự án này hiện không trái pháp luật Việt Nam.

"Thực tế đang đặt ra vấn đề bất cập nhưng Luật Đầu tư chưa điều tiết được. Vì không sai nên không thể xử lý", TS.KTS Đào Ngọc Nghiêm cho biết.

Theo TS.KTS Đào Ngọc Nghiêm, để đảm bảo tính độc lập, quyền của người có quốc tịch Việt Nam và an ninh quốc phòng đã đến lúc tính đến việc điều chỉnh Luật. Phải có giải pháp giảm tình trạng cá nhân người nước ngoài, doanh nghiệp có yếu tố nước ngoài sở hữu các BĐS “đắc địa” và có vị trí chiến lược, đặc biệt là tại các tỉnh thành dọc biên giới hoặc ven biển.

Bên cạnh đó, phải thể chế hóa các quy định liên quan đến việc cá nhân nước ngoài và các doanh nghiệp có yếu tố nước ngoài sở hữu BĐS bằng cách trong các quy hoạch có thể xác định rõ các khu vực mà dự án đầu tư xây dựng được phép hoặc không có yếu tố nước ngoài.

Các địa phương khó quản lý
Liên quan đến câu chuyện quản lý người Việt ở nước ngoài (Việt kiều) và người nước ngoài sở hữu các BĐS tại Việt Nam, TS.KTS Đào Ngọc Nghiêm cho biết trước đây chủ trương của Việt Nam đã dành hẳn một khu riêng cho người nước ngoài và Việt kiều như khu làng Việt Kiều (tại Hà Đông, Hà Nội), quy hoạch từ đầu nên dễ quản lý. Hiện nay cho phép xen lẫn dẫn đến việc khó quản lý hơn.

Hiện nay, liên quan đến việc người nước ngoài sở hữu nhà tại Việt Nam đã có quy định các tỉnh thành phố trong cả nước cần công bố danh mục các khu vực, danh mục dự án cần đảm bảo an ninh quốc phòng và không cho phép người nước ngoài sở hữu căn hộ chung cư. Tuy nhiên, thực tế cho thấy việc thực hiện các quy định này của các địa phương chưa đồng bộ, thống nhất và triệt để. Đơn cử như UBND tỉnh Bắc Ninh vừa qua có văn bản số 707/UBND-TNMT ngày 12/3/2020 hạn chế bán căn hộ cho người nước ngoài tại một số vị trí 2 dự án của Tập đoàn BABACO tại thành phố Bắc Ninh. Trao đổi với DĐDN, ông Nguyễn Thế Chinh, Phó Tổng Giám đốc Tập đoàn Dabaco cho biết, trước khi ký văn bản, công an tỉnh đã giải thích về việc những vị trí gần tượng đài không thể để người nước ngoài có tầm quan sát, khống chế được vị trí đó.

Đối với thắc mắc của PV về việc khi tiến hành các bước trình tự đầu tư dự án thì doanh nghiệp có được Tỉnh hoặc các cơ quan chức năng thông báo, hướng dẫn về việc dự án nằm trong khu vực an ninh, quốc phòng, ông Chinh cho biết "không có thông báo nào".

Năm 2016, Bộ Xây dựng đã có văn bản yêu cầu các địa phương căn cứ nội dung Văn bản số 10328/BQP-TM ngày 19/10/2016 của Bộ Quốc phòng và Văn bản số 786/BCA-TCAN ngày 19/4/2017 của Bộ Công an, phối hợp với Công an và Bộ Chỉ huy quân sự cấp tỉnh, thành phố trực thuộc Trung ương để xác định cụ thể các khu vực cần bảo đảm an ninh, quốc phòng tại địa phương. Các thông tin này được công bố công khai trên Cổng thông tin điện tử của Sở Xây dựng các địa phương để các tổ chức, cá nhân nước ngoài, chủ đầu tư dự án xây dựng nhà ở có cơ sở thực hiện theo đúng quy định.

Nhưng trên cổng thông tin điện tử của Sở Xây dựng tỉnh Bắc Ninh chưa thấy thông tin về khu vực, danh mục danh mục dự án không cho phép tổ chức, cá nhân nước ngoài được quyền sở hữu nhà.

Về vấn đề này, TS.KTS Đào Ngọc Nghiêm cho rằng sự vào cuộc của các địa phương là rất quan trọng. Khi mỗi địa phương thực hiện tốt, đúng, nghiêm túc các quy định liên quan đến việc cá nhân, tổ chức người nước ngoài sở hữu BĐS tại Việt Nam sẽ giúp việc quản lý chung được tốt.

', 4)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (19, N'Đề xuất bỏ thu 2% phí bảo trì chung cư: Nguy cơ tạo lỗ hổng pháp lý
', CAST(N'2020-03-28T00:00:00.0000000' AS DateTime2), 12, N'Sở Xây dựng TP.HCM vừa đề xuất Bộ Xây dựng tiến tới bỏ cơ chế giao chủ đầu tư thu kinh phí bảo trì 2% phần sở hữu chung nhà chung cư như hiện nay.
Tại văn bản kiến nghị đến UBND TP.HCM và Bộ Xây dựng, Sở Xây dựng cho biết thời gian qua có rất nhiều bất cập, phức tạp trong việc quản lý và vận hành, sử dụng phí bảo trì 2%.

Bỏ hay giữ phí bảo trì?
Trong đó, nhiều chung cư cũ (ra đời trước Luật nhà ở năm 2005) thiếu nhà để xe, nhà sinh hoạt cộng đồng, hệ thống PCCC… và đặc biệt không có phí bảo trì, đến lúc trùng tu không có kinh phí để thực hiện.

Ngoài ra, tồn tại lớn hiện nay là tình trạng chủ đầu tư không tổ chức hội nghị nhà chung cư lần đầu để bầu ban quản trị; không bàn giao kinh phí bảo trì, gây khó khăn cho việc kiểm tra, bảo trì, bảo dưỡng công trình. Với các chung cư thuộc sở hữu nhà nước cũng có nhiều bất cập trong các quy định về kinh phí bảo trì và kinh phí quản lý.

Từ việc này, Sở Xây dựng TP.HCM đề xuất giải pháp bỏ cơ chế giao chủ đầu tư thu kinh phí bảo trì 2% phần sở hữu chung nhà chung cư như hiện nay.

Việc hình thành quỹ bảo trì phần sở hữu chung của từng chung cư sẽ do ban quản trị chung cư thu của các chủ sở hữu căn hộ trong quá trình quản lý, sử dụng. Số thu sẽ theo tỉ lệ % do hội nghị nhà chung cư quyết định.

Luật sư Nguyễn Thanh Hà, Chủ tịch Công ty Luật SBLaw phân tích: “Theo quy định tại Điều 108 Luật nhà ở, phí bảo trì chung cư là do Chủ đầu tư phải có trách nhiệm nộp, được trích từ giá trị hợp đồng và phải ghi rõ trong hợp đồng mua bán căn hộ. Đây được hiểu là quyền lợi được bảo hành, bảo trì của người mua căn hộ. Và đây không phải là khoản nộp bổ sung của người mua căn hộ. Khoản phí này là cần thiết để phục vụ cho hoạt động duy trì, bào trì, bảo dưỡng nhà khi đưa vào sử dụng”.

Về bản chất của các giao dịch dân sự khi mua bán hàng hóa vẫn có quy định để người bán hàng có trách nhiệm bảo hành, bảo dưỡng cho người mua hàng. Luật nhà ở cũng thể hiện rất rõ, phản ánh đúng bản chất của hợp đồng mua bán nhà ở, trách nhiệm của chủ đầu tư trong việc trích lập nguồn kinh phí bảo trì, bảo dưỡng nhà ở.

"Nếu chúng ta bỏ phần phí bảo trì này, đồng nghĩa với việc tạo ra một hành lang pháp lý để rất nhiều chủ đầu tư sẽ trốn tránh trách nhiệm phải nộp và được hưởng lợi từ 2% này, không gắn trách nhiệm của chủ đầu tư và bỏ đi quyền lợi thiết yếu của người mua nhà, đi ngược lại với bản chất của việc bảo trì, bảo dưỡng nhà theo quy định của pháp luật", ông Hà cho biết.

Cần được nghiên cứu kỹ
Nói về kinh nghiệm các nước, ông Nguyễn Mạnh Hà, Nguyên Cục trưởng Cục quản lý nhà và Thị trường Bất động sản (Bộ Xây dựng) cho biết, hầu hết các nước đều quy định các nhà chung cư cần phải có một quỹ bảo trì, sửa chữa, thay thế các phần kết cấu trang thiết bị thuộc sở hữu chung trong nhà chung cư, chỉ có điều kinh phí đóng góp như thế nào là có sự khác nhau.

Thu trước tại thời điểm bán căn hộ, hiện có Việt Nam và Trung Quốc áp dụng. Trích từ tiền phí dịch vụ hàng tháng có Singapore, Hàn Quốc, một số quốc gia thì nộp khi phát sinh công việc bảo trì.

"Ngay cả khi cư dân có đóng góp bằng cách này, cách khác vào Quỹ bảo trì chung cư, thì cũng đòi hỏi kiện toàn một hệ thống quy định pháp luật chặt chẽ hơn về Ban quản trị chung cư và người có trách nhiệm làm chủ tài khoản của Quỹ bảo trì, tránh việc một hai cá nhân trục lợi Quỹ bảo trì chung cư gây hậu quả không tốt", ông Hà cho biết.

Trước kiến nghị của Sở Xây dựng TP.HCM không nên để chủ đầu tư thu kinh phí bảo trì nhà chung cư 2%, Thứ trưởng Bộ Xây dựng Lê Quang Hùng cho rằng, việc thu phí bảo trì chung cư là nghiên cứu học tập kinh nghiệm quốc tế, khi một toà chung cư là đa sở hữu với cả diện tích chung và riêng. Những bất cập về quỹ bảo trì 2% vừa qua dẫn tới tranh chấp ở các toà chung cư là việc chủ đầu tư không bàn giao quỹ bảo trì, hoặc ban quản trị sử dụng quỹ bảo trì không đúng…

“Chúng ta mới xây dựng và quản lý chung cư được hơn 10 năm nay nên cũng đang từng bước hoàn chỉnh cơ chế quản lý. Các đề xuất về quản lý, thu hay không thu quỹ bảo trì chung cư cần phải được nghiên cứu”, Thứ trưởng Lê Quang Hùng nói.

Theo một số chuyên gia, việc thu phí bảo trì có thể không để chủ đầu tư toàn quyền nắm giữ mà cần có cơ chế đồng chủ tài khoản với sự giám sát của các cơ quan chức năng. Như vậy, chủ đầu tư không thể “tự tung tự tác” với quỹ này.

Trong trường hợp cần trích quỹ ra sửa chữa chung cư khi Ban quản trị chưa được thành lập thì cần họp cư dân lại để lấy ý kiến, các bên đồng chủ tài khoản cũng không được toàn quyền quyết định.

', 4)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (20, N'Trảng Bom: Bất động sản hưởng lợi từ hạ tầng và công nghiệp
', CAST(N'2020-05-14T00:00:00.0000000' AS DateTime2), 17, N'Chính sách phát triển công nghiệp đang giúp kinh tế - xã hội và bộ mặt đô thị của huyện Trảng Bom (Đồng Nai) thay đổi nhanh chóng trong những năm gần đây. Trong đó, hưởng lợi lớn nhất chính là lĩnh vực bất động sản.
 Điểm tựa hạ tầng, công nghiệp
Trong vài thập kỷ vừa qua, nhờ vị trí chiến lược trung tâm vùng kinh tế động lực phía Nam, tỉnh Đồng Nai rất quan tâm đầu tư phát triển hạ tầng giao thông và lĩnh vực công nghiệp. Trong đó, huyện Trảng Bom sở hữu nhiều tuyến đường chiến lược kết nối liên vùng như quốc lộ 1A, ĐT 767, 762, đường liên huyện Trảng Bom - Long Thành, Trảng Bom - Cây Gáo, đường vào khu du lịch và khu công nghiệp Giang Điền… Bao quanh còn có hệ thống giao thông giúp gắn kết thuận lợi Trảng Bom với Long Thành, TP. Biên Hòa, TP.HCM và khu vực lân cận như đường cao tốc TP.HCM – Long Thành – Dầu Giây, đường sắt cao tốc Bắc - Nam, quốc lộ 20… Hiện nay, trên địa bàn Trảng Bom cũng đang có 4 khu công nghiệp quy mô lớn là Sông Mây (473 ha), Hố Nai (523 ha), Bàu Xéo (500 ha) và Giang Điền (600 ha) cùng khá nhiều cụm công nghiệp - tiểu thủ công nghiệp. Nhờ tập trung thu hút đầu tư, kinh tế của Trảng Bom đang phát triển mạnh theo hướng ưu tiên công nghiệp, sau đó mới đến thương mại – dịch vụ và nông nghiệp. Tại Đồng Nai, tốc độ tăng trưởng kinh tế của Trảng Bom hiện nay chỉ đứng sau Biên Hòa. Tuy nhiên, Trảng Bom được dự báo sẽ tăng tốc nhanh chóng trong những năm sắp tới do có nhiều yếu tố thuận lợi. 

Thống kê cho thấy, Trảng Bom đang là địa phương có dân số đông thứ hai của Đồng Nai với khoảng 900.000 người và mỗi năm thu hút khoảng 100.000 lao động nhập cư làm việc trong các khu công nghiệp. Điều này kéo theo nhu cầu nhà ở rất lớn trong khi quỹ đất phát triển đô thị của Trảng Bom ngày càng khan hiếm. Mặt bằng giá bất động sản tại Trảng Bom cũng đang tăng vọt, nhất là sau khi Trảng Bom cùng với Long Thành, Nhơn Trạch được quy hoạch trở thành ba trung tâm logistic phục vụ sân bay quốc tế Long Thành khi đi vào hoạt động. Bởi với công suất lên đến 100 triệu lượt hành khách và 5 triệu tấn hàng hóa mỗi năm, sân bay quốc tế Long Thành chính là trung tâm trung chuyển lớn bậc nhất khu vực châu Á. Nếu cách đây 5 năm, giá đất tại Trảng Bom chỉ từ 1,5 – 2 triệu đồng/m2 thì nay tăng lên bình quân 10 - 13 triệu đồng/m2. Những khu đất có thể khai thác thương mại hay dự án lớn được đầu tư bài bản giá lên đến 15-20 triệu đồng/m2. 

Cơ hội cho thị trường bất động sản
Giai đoạn 2020 – 2025, Trảng Bom sẽ tiếp tục ưu tiên phát triển công nghiệp hỗ trợ, công nghiệp có hàm lượng chất xám cao, công nghệ xanh thân thiện với môi trường… Nhận thấy tiềm năng to lớn của thị trường bất động sản Trảng Bom, các "đại gia” bất động sản đang tìm đến đây ngày càng nhiều để tìm kiếm cơ hội đầu tư dự án. Đây được xem là thời cơ để các nhà đầu tư bất động sản sở hữu những sản phẩm có khả năng sinh lời rất tốt. Quan sát thị trường có thể thấy, “khẩu vị” của các nhà đầu tư tại Đồng Nai nói chung, Trảng Bom nói riêng thường ưa chuộng các dự án nằm gần các khu công nghiệp lớn, đặc biệt là các khu công nghiệp đã lấp đầy như Sông Mây. Bởi với mật độ dân cư đông đúc, các dự án này thường đảm bảo tính thanh khoản khá cao. Bên cạnh đó, nếu muốn, nhà đầu tư cũng có thể tiến hành khai thác kinh doanh nhiều ngành nghề như mở khách sạn, xây nhà cho thuê, nhà hàng, quán ăn, tiệm thuốc hay các dịch vụ làm đẹp…

Cũng chính vì thế, nhìn chung mặt bằng giá đất tại các dự án nằm gần khu công nghiệp hay các tuyến đường giao thương thường cao hơn, tốc độ tăng giá cũng tốt hơn hẳn so với các dự án khác. Đơn cử như tại khu vực liền kề khu công nghiệp Sông Mây giá đất có pháp lý đầy đủ hiện nay bình quân khoảng 17-19 triệu đồng/m2 trong khi các khu vực xa hơn chỉ khoảng 12-15 triệu đồng/m2. Thế nhưng, do quỹ đất dự trữ để phát triển đô thị tại đây đang khan hiếm nên mức giá này được dự báo sẽ tiếp tục tăng trong thời gian tới. Thậm chí, khu vực huyện Vĩnh Cửu giáp ranh cũng đang được nhiều nhà đầu tư tìm đến gom đất khiến thị trường “nóng” lên từng ngày.

Trên bình diện rộng hơn, ông Nguyễn Phúc Nam, Tổng giám đốc Công ty cổ phần Bất động sản PNR Holding khẳng định tiềm năng bất động sản của Trảng Bom dù đang khá tốt nhưng sắp tới sẽ còn mạnh mẽ hơn nữa khi sân bay quốc tế Long Thành đi vào hoạt động. Bởi theo quy hoạch, sẽ có trục đường thương mại kết nối trực tiếp khu công nghiệp Sông Mây với sân bay quốc Long Thành phục vụ hành khách đi đường hàng không. Mặt khác, giá đất cũng sẽ có cơ hội bứt phá khi Trảng Bom sẽ chuyển lên thị xã trong giai đoạn 2020 – 2025. ', 4)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (21, N'Cần "hệ sinh thái kinh tế ban đêm" cho bất động sản du lịch nghỉ dưỡng
', CAST(N'2020-05-15T00:00:00.0000000' AS DateTime2), 9, N'Kịch bản hồi phục hậu đại dịch COVID-19 của nền kinh tế đang đặt ra một số vấn đề cần giải quyết để bất động sản du lịch nghỉ dưỡng trở thành động lực mạnh của nền kinh tế đêm. Câu chuyện nghiên cứu, thúc đẩy kinh tế ban đêm, đặc biệt là kinh tế đêm gắn với các hoạt động du lịch vốn không quá xa lạ thời gian qua khi mà đã được nêu ra tại không ít diễn đàn và được cả Thủ tướng Chính phủ lưu ý các Bộ ngành nghiên cứu.

Cơ hội cho bất động sản du lịch nghỉ dưỡng
Rõ ràng, triển vọng của Kinh tế ban đêm là rất lớn như TS Cấn Văn Lực, Chuyên gia kinh tế trưởng ngân hàng TMCP Đầu tư và Phát triển Việt Nam (BIDV) từng cho rằng nếu làm tốt có thể khiến GDP tăng được 5 đến 8 điểm phần trăm.

Thực tế tại các quốc gia có vị trí địa lý gần Việt Nam như Singapore, Thái Lan, Trung Quốc cũng ghi nhận việc kinh tế đêm đóng góp to lớn cho kinh tế - văn hoá - du lịch với những bước chuyển mình mạnh mẽ của hàng loạt khu giải trí về đêm.

Trong kịch bản hồi phục hậu dịch COVID-19, nhiều chuyên gia nhận định ngành du lịch Việt Nam cần tạo ra nhiều hơn nữa cơ hội cho du khách “được tiêu tiền” thông qua những trải nghiệm mới giúp tăng thời gian lưu trú và mức chi tiêu mỗi ngày của khách du lịch.

Lời giải cho câu hỏi này chính là các hoạt động về đêm như tại đảo ngọc Phú Quốc thời điểm trước dịch bệnh ước tính mỗi ngày mang về cho Phú Quốc khoảng hơn 10 tỷ đồng hay các điểm như phố đêm Bùi Viện (TP.HCM) hay Tạ Hiện (Hà Nội) luôn là địa điểm hấp dẫn đông đảo du khách đến chơi và tiêu tiền.

Nắm bắt xu thế này từ khá sớm, nhiều doanh nghiệp BĐS đã sớm phát triển các mô hình kinh doanh gắn với kinh tế đêm tại các dự án BĐS của mình. Có thể kể đến một số như tổ hợp du lịch nghỉ dưỡng được phát triển định hướng gắn với nền kinh tế ban đêm như Novaworld, Thanh Long Bay (Bình Thuận), Grandworld (Phú Quốc), Sun World Bà Nà Hills (Đà Nẵng… Đây đều là những điểm nhấn đáng chú ý về sự sôi động của các hoạt động du lịch về đêm.

Nói về xu thế này, ông Phùng Văn Năng, Cố vấn cao cấp HĐQT Tập đoàn Hưng Lộc Phát cho rằng kinh tế ban đêm tác động rất lớn đến thị trường bất động sản du lịch khi nó giúp tăng thời gian lưu trú và mức chi tiêu mỗi ngày của khách du lịch, tạo cơ hội phát triển loại hình giải trí, trung tâm mua sắm, ẩm thực, giải trí, cách hoạt động vui chơi.

"Doanh nghiệp phát triển bất động sản du lịch là người đang tạo ra “cuộc chơi”, từ hệ sinh thái, tiện ích để đáp ứng nhu cầu khách hàng đến các lễ hội, sự kiện, thu hút tất cả các khách tới tham dự", ông Năng khẳng định.

Cần hành lang pháp lý để bứt phá
Với những triển vọng rất hứa hẹn nhưng theo đánh giá của nhiều chuyên gia hiện những động lực mà kinh tế ban đêm mang lại cho ngành du lịch nói chung cũng như lĩnh vực bất động sản nghỉ dưỡng du lịch nói riêng vẫn chưa đạt được kỳ vọng so với tiềm năng vốn có.

TS. Lê Đăng Doanh, Nguyên Viện trưởng Viện Nghiên cứu quản lý kinh tế Trung ương chỉ rõ, hiện nay Việt Nam đang thiếu khuôn khổ pháp lý và còn sự dè dặt của cơ quan nhà nước và địa phương trong phát triển kinh tế ban đêm.

Đồng quan điểm, TS. Nguyễn Thanh Bình - Học viện Chính sách và Phát triển (Bộ KH&ĐT) nhận định vấn đề cốt lõi là cơ quan quản lý phải tạo ra môi trường, cơ sở hạ tầng tốt để hỗ trợ cho hoạt động kinh tế ban đêm.

Ở góc độ doanh nghiệp, ông Phùng Văn Năng cho rằng, các hoạt động ban đêm sau 0h thu hút khách trẻ nước ngoài, không thể áp đặt sau 0h bắt khách đi ngủ. Chúng ta cần tạo ra hệ sinh thái kinh tế ban đêm cho bất động sản du lịch nghỉ dưỡng để thu hút khách hàng, nhà đầu tư, khách du lịch.

Những lo ngại về việc quản lý cũng như những hạn chế của hành lang pháp lý liên quan đang được xem là những trở lực đang kìm hãm sự phát triển nhanh và bền vững của cả nền kinh tế ban đêm cũng như của phân khúc bất động sản nghỉ dưỡng, du lịch gắn với trọng tâm là nền kinh tế ban đêm.

Để giải quyết vấn đề này, TS Lê Đăng Doanh cho rằng để kinh tế ban đêm có thể trở thành khu vực kinh tế hiện đại, có tính chuyên nghiệp cần thiết phải có sự kết hợp chặt chẽ hơn giữa một số tập đoàn BĐS lớn và chính quyền địa phương.

Bên cạnh đó, các chuyên gia cũng nêu khá nhiều quan điểm về việc để sớm có hành lang pháp lý tối ưu cho sự phát triển của nền kinh tế ban đêm bên cạnh việc tháo gỡ những vướng mắc về chính sách từ phía Chính phủ thì các cơ quan chức năng cũng cần tạo thêm cơ chế, đặc thù riêng.

Ở một góc nhìn khác, PGS. Phạm Trung Lương, Nguyên Phó Viện trưởng Viện nghiên cứu phát triển Du lịch, Tổng Cục Du lịch nêu quan điểm cho rằng để quản lý được các hoạt động kinh tế ban đêm có nhiều cách, trong đó có cách quy hoạch thành một khu riêng như một số nước trên thế giới. Như với Đà Nẵng có thể quy hoạch riêng khu kiểu như downtown để cung cấp đủ mọi dịch vụ về đêm. Điều này sẽ giúp thuận lợi hơn trong quản lý.

Để sớm phát triển ngành kinh tế đêm nhằm thúc đẩy mạnh mẽ du lịch, đặc biệt là sau đại dịch COVID-19, thực tế đang đặt ra yêu cầu về việc cần sớm có một điều tra toàn diện, đa chiều về nền kinh tế ban đêm, đặc biệt là trong tương quan với các dự án BĐS du lịch, nghỉ dưỡng để từ đó sớm có những điều chỉnh nhằm tạo ra một hành lang chính sách, pháp lý tối ưu cho nền kinh tế về đêm phát triển nhanh và bền vững.

', 4)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (22, N'Vì sao người Việt chuộng cất nhà đất hơn mua căn hộ chung cư?
', CAST(N'2020-02-25T00:00:00.0000000' AS DateTime2), 9, N'Nhiều người Việt chấp nhận đi vay hoặc ở nhà thuê đến khi tích cóp đủ tiền mua nhà liền thổ, dù số tiền đó có thể đủ mua ngay một căn hộ chung cư. An ninh tốt, mức giá phong phú lại đủ tiện ích nội - ngoại khu…, nhưng điều gì khiến người dân chuộng nhà đất hơn chung cư?
Nhà là của mình, chung cư là của chung
Dân gian có câu “an cư lạc nghiệp” hay “thứ nhất dương cơ, thứ nhì âm phần”, đều là chỉ vị trí quan trọng đặc biệt của ngôi nhà. Bởi lẽ không chỉ phục vụ mục đích sinh tồn, ngôi nhà trong văn hóa người Việt xưa nay còn gắn liền với cách nghĩ, nếp sống, là tiền đề để phát triển kinh tế.

Thói quen sống trên đất của mình mới là của mình, sống trên đất của người khác (chung cư) không có giá trị vĩnh viễn cũng khiến nhiều người Việt ưa ở nhà đất hơn chung cư. Nhất là gia đình có người lớn tuổi thường không thích ở chung cư bởi thiếu không gian riêng tư, lo sợ phát sinh rắc rối khi “chung đụng”.

Thêm nữa, nhà đất khiến người dân yên tâm hơn vì cảm giác được sở hữu 100%. Từ diện tích nhà ở đến sân vườn (nếu có) đều thuộc sở hữu riêng, do chính mình quản lý và toàn quyền quyết định. Chủ nhà có thể xây, sửa, thiết kế nội thất theo ý mình mình mà không cần phải hỏi ý kiến hay được sự đồng ý từ chính quyền địa phương hoặc chủ đầu tư (ngoại trừ một số khu vực có quy định về chiều cao công trình hoặc biệt thự, nhà phố trong dự án).

Trái lại, chữ “chung” trong chung cư lại biểu thị tính “sở hữu chung” khiến nhiều người Việt e ngại. Ở chung cư là sống trong một tập thể nên chủ căn hộ phải tuân thủ luật lệ chung của ban quản lý, cộng đồng dân cư. Chẳng hạn như không được sử dụng bếp than, không tụ tập khách khứa quá khuya gây ồn ào, phải hỏi ý kiến chủ đầu tư nếu muốn thay đổi thiết kế hoặc nâng cấp căn hộ…

Mua nhà là “chuyện trăm năm”
Tâm lý phải mua nhà cho con, có nhà để làm di sản thừa kế đến nay vẫn ăn sâu trong suy nghĩ của nhiều cha mẹ Việt. Vì vậy, nhiều người khó chấp nhận việc tích góp cả đời mới mua được một căn hộ, tuy sở hữu lâu dài nhưng khi công trình hết niên hạn sử dụng sẽ phụ thuộc vào chính sách của địa phương. Chưa kể một số chung cư chỉ có quyền sở hữu 50 năm, 70 năm… Các chung cư sau khi xuống cấp người dân vẫn phải bỏ tiền sửa chữa, cải tạo nhưng lại không được chủ động như nhà đất vì đây là công trình của tập thể. Trường hợp mua nhà để tính chuyện lâu dài, sau này để lại cho con cháu thì lựa chọn mua nhà đất lại càng thêm thuyết phục. Bởi lẽ, việc chuyển nhượng nhà đất thay vì căn hộ khi đó sẽ tránh được các thủ tục phức tạp, rườm rà, giá trị tài sản sẽ được giữ ổn định hoặc tăng trong tương lai chứ không lo mất giá.

“Tấc đất tấc vàng”
Là một nước nông nghiệp nên từ xưa, “tấc đất tấc vàng” đã trở thành quan niệm xuyên suốt của nhiều thế hệ người Việt Nam. Không ít người dân thậm chí còn đo mức độ giàu có của đối phương dựa trên số thửa đất đang sở hữu. “Mua vàng thì lỗ, mua thổ thì lời”, phần lớn người Việt tin rằng đổ tiền vào nhà đất luôn mang lại sự an toàn, vì người thì tăng thêm chứ đất không thể sinh thêm nên càng ngày sẽ càng có giá.

Chứng kiến nhiều người ngẫu nhiên từ tay trắng thành tỷ phú sau 1 đêm nhờ đất tăng giá (do có quy hoạch nông thôn mới, chỉnh trang đô thị…) cũng khiến tâm lý này ngày một ăn sâu. Nhiều người dù đủ tiền mua căn hộ chung cư nhưng vẫn cố tích góp, thậm chí vay nợ “ngập đầu” để mua được nhà đất.

Mặt khác, thị trường chung cư tại Việt Nam dù ngày càng có bước phát triển đáng kể nhưng đến nay vẫn còn những hạn chế nhất định. Những vụ việc tranh chấp sở hữu chung – riêng, bất đồng về cách quản lý và cung ứng dịch vụ… khiến nhiều người dân cảm thấy bất an. Vì vậy, họ chọn cách tiết kiệm để mua được nhà riêng, hoặc ở nhà thuê đến khi nào tích lũy đủ.

Có thể thấy xu hướng người Việt ưa nhà đất hơn căn hộ chung cư phần lớn ảnh hưởng từ tâm lý, quan niệm xưa nay. Tuy nhiên, hiện nay nhiều người Việt Nam, nhất là thế hệ trẻ đã có những thay đổi trong suy nghĩ và thị trường bất động sản cũng cho thấy loại hình căn hộ ngày càng thu hút hơn.

Theo dữ liệu trực tuyến của Batdongsan.com.vn, tại TP.HCM chỉ sau 1 năm từ 2018 - 2019, giá phân khúc căn hộ đã tăng trung bình 14%. Giá căn hộ hạng B năm 2019 đã vươn lên ngưỡng 38 triệu đồng/m2, căn hộ bình dân (hạng C) cũng có giá trung bình lên tới 28 triệu đồng/m2. Như vậy, ngay cả với người có thu nhập vài chục triệu đồng/tháng cũng không dễ dàng sở hữu được một căn hộ chung cư.

Theo đó, việc lựa chọn mua căn hộ chung cư hay nhà đất không đơn thuần phụ thuộc vào quan niệm, tâm lý nữa mà còn phải cân nhắc đến khả năng tài chính, nhu cầu sử dụng cũng như mục đích mua bất động sản (để ở, cho thuê hay đầu tư) của mỗi cá nhân/gia đình. ', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (23, N'Những kịch bản lạc quan cho thị trường bất động sản
', CAST(N'2020-04-28T00:00:00.0000000' AS DateTime2), 9, N'Đã đến lúc các nhà hoạch định chính sách, bộ ngành liên quan và các doanh nghiệp cần nhanh chóng đưa ra các kịch bản cho nền kinh tế cũng như sự tồn tại của doanh nghiệp trên thị trường.
 Mới đây, Bộ Xây dựng đã có những báo cáo chuyên đề gửi đến Quốc hội trong đó đáng chú ý là các số liệu thống kê cho thấy sau giai đoạn tăng trưởng nóng, thị trường bất động sản đã suy giảm về lượng giao dịch cũng như nguồn cung. Cụ thể, lượng giao dịch bất động sản giảm 70%, nguồn cung bất động sản giảm hơn 40% so với cùng kỳ năm 2018.

Những cảnh báo từ Bộ Xây dựng
Dự báo về thị trường bất động sản năm 2020, Bộ Xây dựng cho biết thị trường sẽ tiếp tục gặp nhiều khó khăn và suy giảm so với các năm trước, cả về nguồn cung sản phẩm lẫn số lượng giao dịch.

Đánh giá về những nguyên nhân khó khăn của ngành bất động sản, Bộ Xây dựng cho rằng do ảnh hưởng của nền kinh tế vĩ mô, thủ tục cấp phép dự án mới còn nhiều ách tắc, nguồn vốn tín dụng dành cho bất động sản bị siết chặt, các ngành du lịch dịch vụ bị sụt giảm nghiêm trọng do ảnh hưởng của dịch bệnh COVID-19.

Song song những yếu tố trên việc giới đầu cơ bất động sản đã lợi dụng các chính sách như chuẩn bị quy hoạch đô thị, quy hoạch cơ sở hạ tầng, mở rộng công trình đô thị… để đẩy giá nhà đất lên cao thu lợi làm bất ổn thị trường.

Báo cáo của Bộ Xây dựng cũng chỉ rõ giá sản phẩm nhà đất hiện tại chưa ổn định, không phản ánh đúng giá trị thực (giá trị hợp lý của nhà đất là giá cho thuê phải đạt mức lợi nhuận tiền gửi ngân hàng), chưa phù hợp với khả năng chi trả của số đông người dân.

Ở góc nhìn khác, trong một báo cáo mới nhất của Sở Kế hoạch & Đầu tư TP. Đà Nẵng, số lượng doanh nghiệp thành lập mới trong 3 tháng đầu năm 2020 so với cùng kỳ năm 2019 giảm tất cả ở các ngành. Trong đó, doanh nghiệp kinh doanh bất động sản giảm 61,45%; dịch vụ lưu trú và ăn uống giảm 26,79%; giáo dục và đào tạo giảm 37,5%.

Cũng theo thống kê từ Hiệp hội bất động sản TP.HCM đã có đến 800 sàn giao dịch bất động sản trong tổng số 1.000 trên khắp cả nước phải dừng hoạt động.

Những kịch bản lạc quan 
Các chuyên gia nhìn nhận thị trường vẫn sẽ rất khó đoán định khi tình hình dịch bệnh vẫn còn diễn biến phức tạp, tuy nhiên ở góc độ của mình, TS Đinh Thế Hiển dự báo kịch bản theo 2 hướng: Hướng thứ nhất thị trường sẽ suy giảm nhẹ, tích lũy và có cơ hội tăng trưởng năm 2021. Kịch bản này xảy ra khi Chính phủ triển khai hạ tầng ở mức hợp lý trong năm 2020-2021 và vẫn sử dụng mức kiểm soát tín dụng thận trọng trong khoảng 12-15%.

Ở kịch bản thứ hai ông cho biết thị trường sẽ tăng theo sóng trong thời gian ngắn rồi sẽ gặp biến động lớn, trong trường hợp Chính phủ đẩy mạnh giải ngân tiền đền bù các dự án hạ tầng, cung tiền mạnh cho đầu tư công quá mức và tăng tín dụng trên 17% để hỗ trợ kinh tế vượt qua dịch.

TS. Nguyễn Trí Hiếu, Chuyên gia tài chính chia sẻ: “Không thể nhận định giai đoạn phục hồi của thị trường bất động sản. Đây là một cuộc khủng hoảng không xuất phát từ nền kinh tế tài chính mà đến từ dịch bệnh. Thực tế, xu hướng phục hồi của thị trường đang dần được rút gọn lại như giai đoạn 2011-2013 chỉ mất 2 năm và trước đó thị trường cần 4-5 năm để trở về quỹ đạo ban đầu”.

Dưới góc độ doanh nghiệp kinh doanh, ông Vũ Tâm - Công ty bất động sản VIP nhìn nhận thực tế và cho rằng, không chỉ các ngành khác mà bất động sản cũng đang gánh chịu những tác động nặng nề từ dịch bệnh khi doanh thu sụt giảm nghiêm trọng do không thể triển khai kinh doanh, chính vì vậy ông đã xây dựng hai phương án cho doanh nghiệp của mình để đối phó với dịch bệnh.

Phương án thứ nhất: Nếu dịch bệnh được kiểm soát vào quý 2/2020 thì ngay sau đó các hoạt động mở bán dự án, kinh doanh của công ty sẽ được triển khai bình thường và cơ hội phục hồi vào cuối năm 2020 là hoàn toàn có thể đạt được với dự báo doanh thu và lợi nhuận như đã hoạch định trong thời gian dịch bệnh.

Phương án thứ hai là: Nếu dịch bệnh được kiểm soát vào cuối năm 2020, đây được xem là trường hợp xấu, khi đó công ty sẽ không thể triển khai các hoạt động kinh doanh bình thường, gần như các sản phẩm chính của công ty đã đầu tư như đất nền, bán buôn dự án, chuyển nhượng, hoạt động môi giới… sẽ bị đình trệ và chậm lại do ảnh hưởng chung của thị trường.

Lúc đó nguồn thu gần như đóng băng và lợi nhuận bằng không, doanh nghiệp phải chuẩn bị một nguồn tiền dự phòng đủ để trang trải chi phí, lãi vay và chờ đợi.

 ', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (24, N'7 thay đổi của thị trường bất động sản trong 10 năm qua
', CAST(N'2020-02-15T00:00:00.0000000' AS DateTime2), 10, N'Theo ông Stephen Wyatt, Tổng giám đốc JLL Việt Nam, thị trường bất động sản trong thập kỷ qua đã chứng kiến những bước chuyển biến tạo nên sức ảnh hưởng lâu dài, làm thay đổi ngành bất động sản.
1. Công nghệ len lỏi sâu vào cuộc sống

Công nghệ đã thay đổi cách thị trường BĐS hoạt động một cách ngoạn mục, giờ đây công nghệ là yếu tố nhất định phải có trong việc phát triển, kinh doanh và giao dịch BĐS. Chúng ta đã chuyển từ điện thoại nắp gập sang điện thoại thông minh, và bây giờ mọi người đều có internet trong lòng bàn tay. Chiếc điện thoại nhỏ bé đã cách mạng hóa cách giao tiếp, du lịch, thanh toán và mua sắm của con người.

Tương tự với bất động sản, sự xuất hiện căn hộ thông minh, các ứng dụng quản lý tự động, Protech, Fintech đang làm thay đổi khái niệm về giao dịch và thanh toán trong kinh doanh bất động sản nói riêng và thị trường tài chính nói chung.

2. Sự bùng nổ của không gian làm việc tích hợp

Trước đây, văn phòng được tính toán trên từng mét vuông cho mục đích công việc. Ngày nay, yếu tố con người mới là điểm quyết định không gian văn phòng. Thị trường văn phòng đang tiếp nhận tư duy của ngành dịch vụ khách sạn. JLL ghi nhận lượng lớn các doanh nghiệp thuộc nhiều lĩnh vực khác nhau đã xem xét lại cách họ thiết kế, quản lý và đầu tư vào văn phòng của họ. Văn phòng không còn là nơi làm việc đơn thuần như trước đây. Đi kèm với nó là những dịch vụ và cơ sở tiện ích. Các tòa nhà đang phải thay đổi phong cách thiết kế văn phòng để giữ chân khách thuê. 3. Ngành bán lẻ trước sự cạnh tranh của thương mại trực tuyến

Sự thay đổi từ cửa hàng truyền thống sang mua sắm trực tuyến viết lại các quy tắc của ngành bán lẻ. Người tiêu dùng ưa chuộng sử dụng nhiều kênh khác nhau để mua hàng và điều này khiến các nhà bán lẻ phải linh hoạt mọi lúc mọi nơi. Các cửa hàng bán lẻ truyền thống đang thay đổi diện tích và cung cách hoạt động, các không gian bán lẻ nhỏ và chú trọng vào vị trí đang chiếm ưu thế trong việc cho thuê diện tích tại các TTTM và mặt bằng tiện ích.

4. Vai trò của quản lý dự án được nâng cao

Lượng người dịch chuyển đến các thành phố ngày càng tăng khiến cuộc sống đô thị trở nên đắt đỏ, xu hướng thuê nhà để ở cũng vì vậy mà bùng nổ. Nhưng thay vì thuê phòng ở riêng lẻ như trước đây, mô hình thuê nhà ở có dịch vụ quản lý chuyên nghiệp ngày càng có chỗ đứng. Một thập kỷ trước, không có nhiều dấu hiệu cho thấy tiềm năng của thị trường căn hộ dịch vụ, nhưng điều đó đã thay đổi khi nhu cầu thuê căn hộ tăng lên, và các tập đoàn lớn tìm kiếm cơ hội đa dạng danh mục đầu tư bất động sản thương mại.

5. Dư âm cuộc khủng hoảng tài chính

Vào năm 2010, cuộc khủng hoảng tài chính toàn cầu được khẳng định sẽ định hình lại thị trường tài chính và chính sách kinh tế. Những giải pháp kinh tế như giảm lãi suất kịch sàn, được đưa vào hoạt động năm 2009 và 2010, vẫn còn được áp dụng đến tận ngày nay. Cuộc khủng hoảng làm thay đổi chính sách tiền tệ trong thập kỷ qua. Dù qua một thập kỷ, những chính sách này vẫn tồn tại và còn trở nên lạ lùng hơn. Ngày nay, lãi suất âm đã trở thành chuyện thường ở Ngân Hàng Trung Ương Châu Âu, một điều chắc chẳng ai ngờ tới. 

6. Đầu tư bất động sản thương mại phổ biến hơn

Khi các nhà đầu tư săn lùng lợi nhuận trong bối cảnh lãi suất thấp, bất động sản thương mại trở nên vô cùng hấp dẫn. Các quỹ đầu tư quốc gia và quỹ hưu trí toàn cầu đã tăng phân bổ nguồn vốn vào dòng bất động sản này. Thị trường càng minh bạch sẽ càng thu hút được nhiều dòng vốn đa dạng, tính minh bạch sẽ giúp nhà đầu tư theo dõi được khoản đầu tư của họ tốt hơn.

7. Nhà xưởng là loại tài sản hấp dẫn

Thị trường thương mại điện tử phát triển thúc đẩy nhu cầu về kho vận, đặc biệt là các nhà xưởng hiện đại công nghệ cao. Nhà kho gần trung tâm một lần nữa là loại tài sản hấp dẫn. Các tập đoàn hiện đang xem xét đầu tư vào các kho hàng thông minh tự động hóa, nhằm bắt kịp nhu cầu giao hàng ngày càng nhanh chóng của người tiêu dùng điện tử.', 4)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (25, N'Trở ngại của thị trường bất động sản không nằm ở sức cầu
', CAST(N'2020-01-22T00:00:00.0000000' AS DateTime2), 13, N'Nhu cầu tiêu thụ BĐS tại TP.HCM vẫn rất cao nhưng tác động từ việc thiếu nguồn hàng chào bán đang khiến bức tranh toàn cảnh thị trường kém tươi sáng.
Theo báo cáo từ HoREA, trong năm 2019, toàn TP.HCM chỉ có duy nhất 1 dự án nhà ở thương mại có quyền sử dụng đất ở được UBND thành phố chấp thuận chủ trương đầu tư, giảm 92% so với năm trước. Năm nay cũng chỉ có 4 dự án nhà ở thương mại được công nhận chủ đầu tư, giảm 85%; 16 dự án nhà ở thương mại được chấp thuận đầu tư, giảm 80%. Về nguồn cung chào bán, toàn thành phố có 47 dự án với 23.485 căn hộ chung cư đủ điều kiện bán nhà, giảm 14,1% so với năm 2018. Trong đó, lượng căn hộ cao cấp lên đến 15.758 căn, chiếm tỷ lệ áp đảo 67,1%. Căn hộ trung cấp có 5.284 căn, chỉ chiếm tỷ lệ 22,5%. Dòng sản phẩm nhà ở bình dân có 2.395 căn, chỉ còn chiếm 10,2%. Số lượng dự án nhà ở tập trung nhiều nhất tại khu Đông và khu Nam. Trong đó quận 9 chiếm đến 9 dự án, quận 7 có 8 dự án. Năm 2019, thành phố không có dự án nhà ở xã hội mới và chỉ có 3 dự án cũ hoàn thành xây dựng. 

Thiếu nguồn cung chào bán cũng khiến giao dịch toàn thị trường sụt giảm. Theo thống kê của Bộ Xây dựng, tổng số giao dịch nhà đất thành công trong cả nước năm 2019 là 83.136 giao dịch, giảm 26,1% so với năm 2018; trong đó, bất động sản du lịch nghỉ dưỡng chỉ có 6.280 giao dịch, cũng giảm 20% so với năm 2018. Tuy nhiên tình hình tiêu thụ năm 2019 lại vô cùng tốt, hầu hết các phân khúc chào bán đều ghi nhận sức tiêu thụ đạt hơn 90%. Đồng thời hàng tồn kho được hấp thụ dần, khoảng 1.000 căn mỗi quý. Bất chấp giá bán tăng cao, hầu hết những dự án chào bán mới đều ghi nhận ra hàng thành công, dự án chào bán thứ cấp cũng tiêu thụ mạnh dù tăng gần 20% so với năm 2018. Điều này minh chứng rõ, vấn đề của thị trường không đến từ sức cầu mà ở yếu tố nguồn cung hạn chế.

“Tính thanh khoản của thị trường bất động sản thành phố nhìn tổng thể vẫn tốt do tổng cầu có khả năng thanh toán vẫn cao. Gần như 100% căn hộ trung cấp, căn hộ bình dân đã được tiêu thụ và có những dự án nhà ở cao cấp có tỷ lệ tiêu thụ lên đến hơn 60% trong năm 2019. Riêng hoạt động kinh doanh cho thuê nhà đã có dấu hiệu sụt giảm hiệu quả đầu tư, tỷ suất lợi nhuận chỉ đạt bằng hoặc thấp hơn lãi suất tiết kiệm, nên sẽ tác động tiêu cực đến thị trường bất động sản thứ cấp trong những năm sắp tới”, ông Lê Hoàng Châu, chủ tịch Hiệp hội BĐS TP.HCM nhìn nhận. Đồng quan điểm trên, ông Nguyễn Quốc Anh – P.TGĐ Batdongsan.com.vn cho rằng, dù giảm nhiệt nhưng thị trường BĐS không đóng băng bởi thực tế nguồn cầu vẫn rất cao. Chỉ có thể nói là thị trường chững lại vì những yếu tố liên quan đến pháp lý. Khả năng hấp thụ tại các dự án vẫn cao chứng tỏ nhu cầu của người mua là có, khả năng hấp thụ là có. Điều này cho thấy vấn đề của thị trường BĐS không đến từ sức cầu mà đến từ nguồn cung. 
 
Thống kê của Batdongsan.com.vn cũng cho thấy, riêng Hà Nội và TP.HCM cần tới 8,7 triệu m2 sàn mới mỗi năm (tương đương khoảng 12.000-14.000 căn hộ). Tăng trưởng kinh tế tốt, dân có tiền, nhu cầu lớn, lạm phát thấp, có vẻ như không có gì khiến bất động sản không phát triển được. Nhưng hiện tại cung đang trong giai đoạn kiểm soát chặt. Do vậy mới có chuyện nhu cầu lớn nhưng nguồn cung dự án mới khá chậm.

Thực trạng khan hiếm nguồn hàng kỳ vọng sẽ được giải quyết trong năm 2020 khi mà thị trường chào đón thêm dự án mới. Trong kế hoạch cho năm 2020 của nhiều doanh nghiệp địa ốc phía Nam, vẫn có khá nhiều dự án mới được triển khai trên đại bàn TP.HCM. 

Cụ thể, Tập đoàn Đại Phúc có kế hoạch trong năm 2020 sẽ đưa ra thị trường 1 dự án hoàn toàn mới tại huyện Bình Chánh, TP.HCM, diện tích trên 100 ha với dòng sản phẩm chính là nhà phố, biệt thự. Dự án Van Phuc City tại quận Thủ Đức có thêm dòng sản phẩm mới là chung cư và chào bán biệt thự cao cấp trên 100 tỷ đồng/căn. Dự kiến năm 2020, Đại Phúc sẽ đưa ra thị trường khoảng 2.000 sản phẩm. 

Tập đoàn Hưng Thịnh Corp lên kế hoạch mở bán dự án chung cư 1.000 căn hộ thuộc khu Làng đại học Quốc gia TP.HCM. Tập đoàn Vingroup sẽ tiếp tục phát triển dự án Vinhomes Grand Park, quận 9 với các phân khu còn lại, tổng số hơn 30.000 sản phẩm, gồm chung cư và hơn 2.000 nhà phố, biệt thự trong năm 2020. Cũng trong năm 2020, Vingroup sẽ hoàn thiện pháp lý để phát triển dự án nghỉ dưỡng tại biển Cần Giờ, TP.HCM. Keppel Land Vietnam sẽ triển khai dự án Saigon Sports City quận 2, TP.HCM với quy hoạch trên diện tích 64 ha, cung cấp 4.300 căn hộ cao cấp, tổ hợp thể thao, trung tâm giải trí và phong cách sống đầu tiên của Việt Nam. 

Nhìn chung, thị trường BĐS TP.HCM sẽ vẫn là thị trường điểm được giới đầu tư kỳ vọng sẽ có những thay đổi tích cực một khi cởi bỏ nút thắt nguồn cung.', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (26, N'Ì ạch cải tạo chung cư cũ: Đâu là vướng mắc?
', CAST(N'2020-01-31T00:00:00.0000000' AS DateTime2), 14, N'Việc cải tạo, xây mới các chung cư cũ trên địa bàn Hà Nội mới chỉ đạt khoảng 1% do còn tồn tại rất nhiều khó khăn và vướng mắc.
Cải tạo, xây mới chung cư cũ chỉ đạt khoảng 1%
Trên địa bàn Hà Nội hiện có khoảng 1.500 chung cư cũ đang tồn tại. Trong đó có 6 nhà thuộc diện nguy hiểm cấp D, 200 nhà xuống cấp, hư hỏng ở cấp C và 137 nhà cấp B. Lãnh đạo thành phố đã liên tục đưa ra các mục tiêu và biện pháp nhằm đẩy nhanh tiến độ triển khai việc cải tạo, xây mới chung cư cũ trên địa bàn.

6 công trình nguy hiểm cấp độ D gồm: Khu tập thể C1 Thành Công, đơn nguyên 1 chung cư 51 Huỳnh Thúc Kháng (phường Láng Hạ, quận Đống Đa), đơn nguyên 1, 2 G6A Thành Công (phường Thành Công), đơn nguyên 3 C8 Giảng Võ (phường Giảng Võ), đơn nguyên 1-3 tập thể Bộ Tư pháp (phường Cống Vị), đơn nguyên 1 nhà A Ngọc Khánh (phường Ngọc Khánh).

Tuy nhiên, theo thống kê của Sở Xây dựng Hà Nội, tính đến nay, mới chỉ có khoảng 1% số chung cư được cải tạo, xây mới. Nhiều hộ dân phải sinh sống trong các khu nhà đã xuống cấp, không đảm bảo điều kiện hạ tầng, phòng cháy chữa cháy, ảnh hưởng đến chất lượng sống cũng như an toàn tính mạng của chính người dân. Theo kết quả công tác quy hoạch kiến trúc trên địa bàn năm 2019 do Phó Giám đốc Sở Quy hoạch - Kiến trúc Hà Nội Nguyễn Trọng Kỳ Anh báo cáo mới đây, thành phố đã giao 19 nhà đầu tư tự bỏ kinh phí để nghiên cứu, lên ý tưởng cải tạo, xây dựng lại 28 khu chung cư cũ. Sau đó, 2 chung cư cũ được bổ sung nâng tổng số chung cư lên 30 khu.

UBND thành phố yêu cầu các nhà đầu tư cần phối hợp với UBND các quận, phường để khảo sát việc lên ý tưởng quy hoạch theo 2 phương án. Phương án thứ nhất là tầng cao và chỉ tiêu dân số sẽ tuân theo đúng quy hoạch, quy chế cao tầng được duyệt. Phương án thứ hai là điều chỉnh chiều cao và chỉ tiêu để cân đối tài chính dự án. Hầu hết các nhà đầu tư đề xuất phương án 2 và tăng khung chiều cao so với quy định.

Đâu là vướng mắc?
Đối với việc cải tạo chung cư cũ, ông Nguyễn Chí Dũng, Phó Giám đốc Sở Xây dựng Hà Nội, Tổ phó Tổ chuyên gia nghiên cứu về cải tạo xây dựng mới chung cư TP. Hà Nội cho biết, khó khăn nhất là vướng về dân số. Phần lớn chung cư cũ đều thuộc khu vực nội đô nên số dân ở chung cư sau khi cải tạo bị giới hạn. Một trở ngại khác là vấn đề đền bù.

Ông Nguyễn Mạnh Khởi, Phó Cục trưởng Cục Quản lý Nhà và Thị trường bất động sản (Bộ Xây dựng) cũng nhấn mạnh, khâu bố trí tạm cư đang gặp phải vướng mắc. Liên quan đến vấn đề này là niềm tin của người dân vào năng lực tài chính và kinh nghiệm của nhà đầu tư. Vì vậy, các bộ, ngành, doanh nghiệp, các nhà khoa học và người dân cần vào cuộc và chung tay trong việc cải tạo chung cư cũ.

Cũng đưa ra 2 vấn đề quan trọng nhất của việc cải tạo chung cư cũ, ông Nguyễn Quốc Hiệp, Chủ tịch Hiệp hội Nhà thầu Việt Nam cho rằng, vấn đề thứ nhất là hệ số đền bù để thỏa thuận với cư dân, nhất là tầng 1. Hệ số đền bù là bao nhiêu? Một điều bất hợp lý là người dân đòi đền bù gấp rưỡi, gấp đôi dù không mất tiền xây dựng. Bên cạnh đó, ông Hiệp bày tỏ băn khoăn về những căn hộ có diện tích chỉ khoảng 12m2: “Bây giờ dù có đền bù lên hệ số 2 thì vẫn chưa đủ theo quy định diện tích tối thiểu chung cư là 40m2. Từ diện tích đền bù lên đến diện tích tối thiểu theo quy chế ai sẽ trả tiền chênh lệch”.

Vấn đề thứ hai là việc đầu tư phải đảm bảo chỉ tiêu quy hoạch phát triển hạ tầng, không gây ách tắc, quá tải, nhưng với doanh nghiệp, họ chỉ thực hiện nếu thu được lãi 10% nên sẽ có sự chênh lệch giữa quy hoạch mà chủ đầu tư muốn và quy hoạch được duyệt. Ông Hiệp nói: "Nếu tăng chiều cao thì sẽ ách tắc. Nếu không cho tăng thì phải bù cho chủ đầu tư đất ở chỗ khác. Chính quyền cần phải vào cuộc với doanh nghiệp". ', 4)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (27, N'Bất động sản du lịch: "Miếng bánh" ngon nhưng có dễ ăn?
', CAST(N'2020-11-21T00:00:00.0000000' AS DateTime2), 10, N'Mới đây, tại Toạ đàm Những xu hướng mới của thị trường bất động sản du lịch Việt Nam, nhiều chuyên gia cho rằng, bất động sản du lịch đang là lĩnh vực hấp dẫn và năng động bậc nhất trên thị trường.
"Miếng bánh" ngon nhưng không dễ ăn
Chủ tịch Hiệp hội Bất động sản Việt Nam (VNRea) Nguyễn Trần Nam đánh giá, bất động sản du lịch hiện có tiềm năng phát triển rất lớn. Theo ông Nam, hạ tầng du lịch tại nhiều địa phương đang được chú trọng đầu tư. Giá bất động sản du lịch ở Việt Nam cũng thấp hơn các quốc gia có cùng tiềm năng du lịch. Hơn nữa, lượng khách du lịch đến Việt Nam cũng đang tăng trưởng tốt, trung bình mỗi năm có 15 triệu khách du lịch nước ngoài, trong khi 10 năm trước chỉ có 4 triệu khách.

Chủ tịch VNRea đánh giá: "Trong trung hạn, với trên 20 triệu khách quốc tế tới Việt Nam mỗi năm có thời gian nghỉ trung bình từ 5-7 ngày cho mỗi kỳ nghỉ, và khách trong nước khoảng 85 triệu người có thời gian nghỉ từ 3-4 ngày, du lịch Việt Nam cần thêm nhiều hơn nữa các dự án đầu tư theo dạng hệ sinh thái, quần thể, tích hợp cả du lịch, giải trí, nghỉ dưỡng, mua sắm". Do đó, trong trung và dài hạn, trên thị trường, bất động sản du lịch, nghỉ dưỡng, đặc biệt là khu vực ven biển vẫn là một điểm sáng. Cho rằng bất động sản du lịch là "miếng bánh" rất ngon trên thị trường nhưng theo ông Nam, không phải ai cũng "ăn" được. Nguyên nhân là bởi khác với đầu tư nhà ở, đầu tư bất động sản du lịch có khó khăn hơn là không phải cứ bán là xong mà quan trọng hơn là vận hành thế nào để hiệu quả.

Thị trường muốn phát triển bền vững cần có những nhà đầu tư có tâm, có tầm. Chủ tịch Hiệp hội Bất động sản Việt Nam nhấn mạnh: "Bản thân những chủ đầu tư bất động sản du lịch, nghỉ dưỡng lớn cũng chính là "sếu đầu đàn" trong lĩnh vực du lịch. Vì vậy, họ sẽ biết đầu tư vào vị trí nào, cách làm ra sao, bố trí các sản phẩm bổ trợ nhau để tạo sức cạnh tranh, thu hút mạnh mẽ khách du lịch”.

Xuất hiện những xu hướng mới
Ông Nam cho rằng, trong trung và dài hạn, nếu chỉ phát triển dự án kiểu truyền thống thì sẽ không đảm bảo tính cạnh tranh và sự phù hợp với nhu cầu của khách hàng. Một dự án muốn tạo sự hấp dẫn cần xây dựng hệ sinh thái tiện ích - dịch vụ đa dạng.

Chung quan điểm, chuyên gia Nguyễn Minh Phong nói: "Hiện nay, một số chủ đầu tư đã tiên phong nhập cuộc và sẵn sàng kiến tạo các loại hình sản phẩm mới, kết hợp các xu hướng mới vào dự án trong tương lai, hướng tới đa trải nghiệm cho khách hàng và tạo ra “dấu ấn riêng” cho dự án. Bên cạnh đó, làn sóng đầu tư vào các thị trường mới đang lan rộng với sự dẫn dắt của các nhà phát triển du lịch, các doanh nghiệp lớn tiên phong".

Về xu hướng mới trên thị trường, ông Nguyễn Văn Đính, Phó Chủ tịch kiêm Tổng Thư ký Hội Môi giới Bất động sản Việt Nam cho biết, thị trường bất động sản du lịch từ nửa cuối năm 2018 đến nay đã xuất hiện xu hướng các doanh nghiệp phát triển các dự án phức hợp, gắn đầy đủ các dịch vụ nghỉ dưỡng, lưu trú, thể thao, mua sắm, giải trí để mang đến cho du khách một điểm đến "All-in-one".

Dưới góc độ doanh nghiệp, Phó Tổng Giám đốc Tập đoàn Crystal Bay, ông Ngô Hữu Trường cho biết, trên thế giới, mô hình "All-in-one" đã được phát triển rất thành công với những dự án thu hút hàng triệu lượt khách mỗi năm như: Genting tại Malaysia, Sentosa tại Singapore, The Plam Atlantic of DuBai tại UAE… Và Việt Nam cũng không nằm ngoài xu hướng này.

Vị lãnh đạo này nói, các dự án "All-in-one" sẽ thu hút khách du lịch quốc tế đến Việt Nam nhiều hơn, phục vụ nhu cầu nghỉ dưỡng - trải nghiệm - khám phá - giải trí. Điều này sẽ giúp kéo dài thời gian lưu trú và tăng khoản chi tiêu của khách, khách sẽ trở lại lần 2, thậm chí nhiều lần hơn.

', 4)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (28, N'Điêu đứng vì biểu tình, Hồng Kông vẫn là thị trường nhà ở đắt nhất thế giới
', CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), 14, N'Theo báo cáo của CBRE, Hồng Kông tiếp tục giữ vững vị trí hàng đầu trong số những thị trường nhà ở đắt nhất thế giới, với mức giá trung bình là 1,25 triệu USD. Ngoài ra, ba đại diện khác của châu Á là Singapore, Thượng Hải và Thâm Quyến cũng góp mặt trong top 5.
Cụ thể, phiên bản mới nhất của báo cáo Global Living 2020 do CBRE công bố gần đây cho biết Hồng Kông đã vượt qua 38 thành phố lớn khác để giữ vững vị thế thị trường nhà ở đắt nhất toàn cầu, bất chấp những ảnh hưởng tiêu cực của các cuộc biểu tình kéo dài suốt năm 2019. Trong năm qua, giá nhà trung bình tại đặc khu kinh tế này đạt 1,25 triệu USD, tăng 4,7%. Xếp sau Hồng Kông là Munich với mức giá trung bình khoảng 1 triệu USD, tăng 11%. 

Singapore - đối thủ cạnh tranh trực tiếp danh hiệu trung tâm tài chính châu Á với Hồng Kông - xếp hạng 3 với mức giá  915.601 USD, tăng 2,7%. Hai vị trí còn lại trong top 5 lần lượt thuộc về Thượng Hải và Thâm Quyến - những đại diện nổi bật của thị trường bất động sản Trung Quốc.  Bà Jennet Siebrits, Giám đốc Nghiên cứu thị trường nhà ở của CBRE Anh, nhận định: “Một lần nữa, Hồng Kông lại là thị trường bất động sản đắt nhất thế giới. Giá nhà trung bình tại đây hầu như không bị ảnh hưởng bởi suy thoái kinh tế dù tình trạng bất ổn chính trị, các cuộc biểu tình thường xuyên làm gián đoạn hoạt động của doanh nghiệp bất động sản, khiến việc kinh doanh gặp nhiều khó khăn.” 

CBRE dự báo trong thời gian tới, giá nhà ở Hồng Kông vẫn sẽ thuộc nhóm đắt đỏ hàng đầu thế giới. Tuy nhiên, tình trạng căng thẳng từ những cuộc biểu tình và đại dịch Covid-19 vẫn tiềm tàng nguy cơ bùng phát trở lại, thị trường này có thể sẽ suy yếu phần nào.  

Trong khi đó, ông Simon Smith, Giám đốc cấp cao kiêm Trưởng phòng Nghiên cứu và Tư vấn của Savills, cho rằng lãi suất thấp và khoảng cách lớn giữa cung và cầu có khả năng giữ cho giá nhà tại Hồng Kông không bị giảm mạnh.

Không chỉ ghi nhận giá bán nhà ở mức cực kỳ đắt đỏ, Hồng Kông cũng xếp thứ 3 trong số các thị trường có giá thuê nhà đắt nhất, chỉ sau New York và Abu Dhabi.', 7)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (29, N'Ngành bất động sản được kỳ vọng sẽ chèo lái kinh tế Mỹ phục hồi
', CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), 14, N'Các dữ liệu nhà ở gần đây của Mỹ cho thấy vai trò quan trọng của ngành bất động sản trong quá trình phục hồi nền kinh tế lớn nhất thế giới sau đại dịch Covid-19.
Báo cáo chỉ số thị trường nhà ở mới nhất của Hiệp hội các nhà thầu xây dựng Mỹ (NAHB) cho biết thị trường bất động sản nước này đang có dấu hiệu ổn định và dần phục hồi sau đại dịch. Cụ thể, chỉ số niềm tin của nhà thầu xây dựng đối với thị trường nhà đơn lẻ xây mới đã đạt 37 điểm trong tháng 5, tăng 7 điểm so với tháng 4.  Đây được coi là tín hiệu tốt đối với thị trường bất động sản Mỹ, hứa hẹn nhu cầu xây dựng nhà ở sẽ gia tăng trong thời gian tới, góp phần tạo ra việc làm, thúc đẩy sản xuất trong giai đoạn phục hồi kinh tế sau “bão” Covid-19. Sau nhiều tháng trầm lắng vì đại dịch, ngành bất động sản được kỳ vọng sẽ là đầu tàu dẫn dắt nền kinh tế nước này phục hồi.

Ông Dean Mon, Chủ tịch NAHB, cho biết: "NAHB dự đoán rằng bất động sản, cụ thể là nhà ở, sẽ giúp dẫn dắt nền kinh tế thoát khỏi thời kỳ bất ổn này và có khả năng phục hồi nhanh hơn các ngành khác. Nhu cầu nhà ở bị dồn nén trong thời gian cách ly kéo dài vì đại dịch và lãi suất thấp có thể mở đường cho ngành bất động sản phục hồi khi nước Mỹ bước vào những tháng mùa hè."

Dù các quy định yêu cầu người dân ở trong nhà vẫn tiếp tục được dỡ bỏ trên toàn quốc, ngành bất động sản Mỹ đang nỗ lực thay đổi môi trường kinh doanh để đảm bảo tất cả các biện pháp phòng ngừa an toàn được thực hiện trong suốt quá trình xây dựng và mua nhà. Đặc biệt, nhiều doanh nghiệp đã chú trọng phát triển các dịch vụ xem nhà và chốt giao dịch từ xa thông qua các ứng dụng công nghệ thực tế ảo.  Ông Mon nói thêm: "Sở hữu nhà vẫn luôn là nền tảng của “Giấc mơ Mỹ”. Năm nay, khi không gian sống của chúng ta đều đã biến thành văn phòng, trường học hay sân chơi vì đại dịch, có một nơi để gọi là nhà trở thành điều quan trọng hơn bao giờ hết. Hậu Covid-19, nhu cầu sở hữu nhà nhiều khả năng sẽ gia tăng đáng kể."', 7)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (30, N'Vì sao người Trung Quốc rải tiền gom bất động sản khắp toàn cầu?
', CAST(N'2020-06-01T00:00:00.0000000' AS DateTime2), 9, N'Những năm gần đây, người Trung Quốc đã trở thành nhóm khách hàng nổi bật nhất trên thị trường bất động sản khắp toàn cầu. Từ các nước láng giềng đến những miền đất xa xôi ở nửa kia Trái Đất, đâu đâu cũng ghi nhận làn sóng người Trung Quốc đầu tư nhà đất. Vậy đâu là những yếu tố tạo nên niềm đam mê bất động sản xuyên biên giới của người dân nước này?
Là đất nước đông dân nhất thế giới với dân số gần 1,4 tỷ người, Trung Quốc luôn ghi nhận nhu cầu sử dụng các nguồn lực tài nguyên và sản phẩm tiêu dùng ở mức rất cao. Bất động sản cũng không phải ngoại lệ. Trên thực tế, thị trường bất động sản Trung Quốc là một trong những thị trường lớn nhất thế giới, thậm chí còn lớn hơn nữa nếu tính cả Hồng Kông. Sở hữu bất động sản là nhu cầu đã tồn tại từ lâu, được ưu tiên cao trong tâm trí người Trung Quốc do những ảnh hưởng về văn hóa, tư tưởng truyền thống cũng như chính sách quản lý của chính phủ. Khi thị trường trong nước là không đủ với người dân Trung Quốc, họ bắt đầu nhìn xa hơn, tìm kiếm những khoản đầu tư xuyên biên giới và trở thành nhóm khách hàng nổi bật nhất thị trường toàn cầu. Cùng lý giải nguyên nhân vì sao người Trung Quốc lại đam mê bất động sản nước ngoài đến vậy ở bài viết dưới đây. Chênh lệch giá

Từ năm 2005 đến 2009, giá trung bình của bất động sản ở Trung Quốc đại lục đã tăng lên gấp 3 lần. Đến năm 2011, giá mới bắt đầu ghi nhận xu hướng giảm. Nhiều người tin rằng nguyên nhân bong bóng bất động sản vỡ là do tầng lớp trung lưu không đủ khả năng mua nhà ở các thành phố lớn như Bắc Kinh và Thượng Hải. Những năm sau đó, giá nhà đất lại leo thang chóng mặt, thị trường được cho là đã bão hòa, mức độ quan tâm của người dân đối với bất động sản trong nước giảm dần. Họ bắt đầu tìm kiếm các khoản đầu tư ở nước ngoài. 

Chỉ riêng trong năm 2015, dân Trung Quốc đã chi hơn 28 triệu USD để sở hữu nhà đất ở Mỹ. Trong khi đó, ở Australia, tổng giá trị các khoản đầu tư vào bất động sản thương mại và nhà ở dưới tên người Trung Quốc cũng đạt 32 tỷ AUD. Ngoài các thị trường lớn, nhà đầu tư Trung Quốc cũng đổ tiền vào các thị trường mới nổi như Philippines, Thái Lan và Indonesia – những nơi có mức giá cơ sở thấp hơn, hứa hẹn lợi nhuận cao hơn. 

Chính sách hạn chế của chính phủ

Hầu hết các vùng đất ở Trung Quốc đều thuộc sở hữu của nhà nước. Theo luật bất động sản nước này, mọi người có quyền sử dụng nhưng không được sở hữu đất đai trong nước. Thông thường, công dân được trao quyền sử dụng một khu đất lên tới 70 năm cho mục đích cư trú và 40-50 năm đối với mục đích thương mại và công nghiệp. 

Dưới ảnh hưởng của tư tưởng truyền thống, đa số người Trung Quốc luôn muốn để lại tài sản cho con cháu. Do vậy, nếu chỉ được sở hữu bất động sản trong một khoảng thời gian, đó không phải là một khoản đầu tư lý tưởng. Để tạo dựng nền tảng giàu có cho các thế hệ tương lai, dân Trung Quốc tìm kiếm những bất động sản có thể sở hữu vĩnh viễn. Do vậy, họ bị hấp dẫn bởi những quốc gia có luật sở hữu bất động sản nhẹ nhàng hơn như ở Pháp, Italia và Australia.

Đa dạng lựa chọn

Trung Quốc là một đất nước rộng lớn với diện tích xếp thứ 4 trên thế giới, sau Nga, Mỹ và Canada. Tuy vậy, thị trường bất động sản trong nước vẫn là không đủ đối với một bộ phận nhà đầu tư Trung Quốc. Những lý do như luật pháp và quy định nghiêm ngặt, các loại hình bất động sản khá hạn chế và giá cả đắt đỏ, kém linh hoạt khiến nhiều người Trung Quốc từ chối các dịch vụ bất động sản của nước họ.

Trong khi đó, sở hữu bất động sản ở nước ngoài là một cách khá hiệu quả để đa dạng hóa đầu tư. Mỗi quốc gia có tốc độ tăng trưởng kinh tế và các yếu tố ảnh hưởng khác nhau, do vậy lợi suất cho thuê hay lợi tức đầu tư (ROI) cũng khác nhau. Có rất nhiều lựa chọn ở nước ngoài phù hợp với mong muốn của bất kỳ nhà đầu tư bất động sản nào ở Trung Quốc. Thị trường tại các quốc gia đang phát triển có thể mang lại lợi nhuận tốt hơn so với các quốc gia phát triển, tức là giá rẻ hơn đáng kể nhưng tốc độ tăng trưởng lại cao hơn. 

Ví dụ, tại Đông Nam Á, các quốc gia có lợi suất cho thuê hàng đầu hứa hẹn lợi suất lên tới 8%, cao hơn hẳn mức 1,5% của Thượng Hải năm 2017. Tăng trưởng kinh tế của mỗi quốc gia là một trong những yếu tố lớn nhất quyết định lợi nhuận của đầu tư nói chung, đầu tư bất động sản nói riêng. Những con số này thu hút nhiều nhà đầu tư bất động sản Trung Quốc, khiến họ không ngừng săn tìm nhà đất ở nước ngoài.

Thay đổi môi trường sống

Một trong những lý do rõ ràng nhất khiến người Trung Quốc mua bất động sản ở nước ngoài là họ có kế hoạch rời khỏi đất nước. Lý do của việc di cư khá đa dạng, trong đó, thay đổi để hướng tới môi trường  sống tốt hơn được cho là một nguyên nhân khá phổ biến. Ô nhiễm không khí tại các thành phố lớn ở Trung Quốc là một vấn đề nghiêm trọng, khiến người dân nước này lo lắng cho sức khỏe, an toàn của bản thân và gia đình. Ngoài ra, mức sống cũng là một vấn đề được dân Trung Quốc quan tâm. Các gia đình có địa vị trong xã hội thích cho con theo học các trường danh tiếng ở nước ngoài. Điều này chủ yếu nhằm đảm bảo tương lai của con cái, hay trong một số trường hợp là chính họ. Con cái ra nước ngoài học, tạo lập sự nghiệp và nền tảng xã hội để rồi chính các phụ huynh cũng di cư theo con. Tương tự, những người thuộc tầng lớp trí thức như các kỹ sư, chuyên gia cũng chọn theo đuổi sự nghiệp ở các nước phát triển để có cơ hội tốt hơn. Với các doanh nhân, thành lập công ty khởi nghiệp ở các quốc gia ít cạnh tranh và thị trường lành mạnh hơn cũng mang lại cơ hội thành công cao hơn.

Địa vị xã hội

Đối với người Trung Quốc, có một vị thế xã hội tốt mang lại cho họ cảm giác về thành tích và tâm lý an tâm rằng mình sẽ thành công hơn trong tương lai. Và một trong những yếu tố làm nên vị thế xã hội của một người chính là sở hữu bất động sản. Có càng nhiều nhà đất, người Trung Quốc càng được coi là giàu có, thuộc tầng lớp trên trong xã hội.  

Tuy nhiên, việc chính quyền Trung Quốc giới hạn quyền sở hữu bất động sản của công dân khiến giới nhà giàu nước này phải khẳng định sự giàu có của mình thông qua việc mua bất động sản ở nước ngoài. Thực tế cho thấy, người Trung Quốc đã trở thành nhóm khách hàng nổi bật, chi tiêu mạnh tay nhất cho bất động sản khắp thế giới, thậm chí lấn lướt dân địa phương. 

Dự kiến đến cuối năm nay, giá trị giao dịch bất động sản ở nước ngoài của người Trung Quốc sẽ đạt 220 tỷ USD. Họ chi tiền gom nhà đất khắp nhưng nhiều khi chỉ bỏ trống, không ở, khiến người dân bản địa cảm thấy khó chịu, ác cảm. Tại nhiều nơi ở Canada và Australia, nhiều cuộc biểu tình phản đối người Trung Quốc mua nhà đất đã diễn ra, khiến chính quyền địa phương đau đầu tìm cách giải quyết. ', 7)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (31, N'Australia: Xu hướng cho thuê BĐS ngắn hạn để làm việc và tự cách ly
', CAST(N'2020-04-14T00:00:00.0000000' AS DateTime2), 9, N'Đây là những sản phẩm BĐS đặc biệt được tung ra thị trường trong bối cảnh dịch bệnh diễn biến phức tạp, nhiều công ty, doanh nghiệp cho phép nhân viên làm việc tại nhà và tự cách ly để tránh rủi ro lây nhiễm bệnh cho nhau.
Tại bang Victoria, những ngôi nhà và cabin trên bãi biển vốn để phục vụ cho kinh doanh du lịch, nghỉ dưỡng nay đang được cho thuê với mức giá giảm tới 30%. Giám đốc khách sạn Valley Ranges Getaways, bà Peta Rolls cho biết nhiều dịch vụ cho thuê BĐS ở vùng Dandenong đang được mở ra và hướng tới những khách hàng muốn có một “kỳ nghỉ” cách ly.

“Đây là một cách để người thuê thiết lập sự an toàn và tự cách ly, làm việc trong môi trường với cảnh quan đẹp, không khí trong lành và căn nhà cho thuê thì luôn đầy đủ các thiết bị cho việc nấu nướng, giặt ủi” – bà Peta nói.

Chuyên gia kinh tế của Realestate.com.au, bà Nerida Conisbee cho biết mức tăng 130% dịch vụ cho thuê BĐS tại bang Victoria cho thấy các chủ sở hữu nhà nghỉ đang tìm kiếm khách thuê dài hạn thay vì khách du lịch. Oaks Hotels, Resorts & Suites - Nhà cung cấp chỗ ở với hơn 60 khách sạn chủ yếu ở Úc và New Zealand cũng đang khai thác hình thức cho thuê này với các gói phục vụ đặc biệt. Khách thuê phòng được cung cấp đầy đủ tiện nghi để sinh hoạt và làm việc từ xa với wifi tốc độ cao. Ngoài ra, họ còn có thể sử dụng Deliveroo để giao nhận hàng ngay tại phòng khách sạn.

“Trong thời gian thử thách này, điều quan trọng đối với chúng tôi là có thể cung cấp một ngôi nhà thoải mái, an toàn cho người dân Australia và khách quốc tế để tự cách ly, bảo vệ bản thân và cộng đồng” - Craig Hooley, Giám đốc điều hành của Oaks Hotels, Resorts & Suites nói.

Tại Sydneys, Q Station cũng đã biến 40 phòng khách sạn của mình thành không gian cách ly cho người Úc trở về từ nước ngoài, những người cần hoàn thành thời gian cách ly 14 ngày. Với mức giá 100 USD/đêm, khách sạn không thu được nhiều lợi nhuận, nhưng theo Giám đốc điều hành Alison Langley, đó là về việc giúp đỡ người Australia và cố gắng duy trì hoạt động kinh doanh trong bối cảnh này.', 7)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (32, N'Singapore: Giá bất động sản để ở bắt đầu tăng trở lại
 ', CAST(N'2020-01-15T00:00:00.0000000' AS DateTime2), 9, N'Ngân hàng trung ương Singapore gần đây đã đưa ra lời cảnh báo trước tình trạng “ế hàng” của thị trường bất động sản cũng như sự sụt giảm của thị trường lao động. Giá bất động sản để ở trước đó giảm mạnh sau khi chính phủ thực hiện các biện pháp kiểm soát tài sản từ tháng 7 năm ngoái, nhưng gần đây đã bắt đầu tăng trở lại. Bản đánh giá mức độ ổn định tài chính được Ngân hàng Trung ương Singapore (MAS) công bố mới đây cho thấy số lượng bất động sản tồn kho từ các dự án mới đã tăng gấp hai lần, đạt mức 4.377 đơn vị chỉ trong quý 3 vừa qua. MAS cho biết, tình trạng dư cung sẽ còn trở nên nghiêm trọng hơn trong trung hạn khi các dự án tái đầu tư được tung ra thị trường trong khi các giao dịch cũ trong 2 năm nay đi vào “ngõ cụt”. Báo cáo của MAS cũng chỉ ra rằng, hàng tồn kho gia tăng có thể sẽ kéo tụt giá bán trong trung hạn nếu nhu cầu mua nhà không tăng lên trong thời gian tới.

Sau sự sụt giảm do chính phủ áp siết chặt vòng kiểm soát bất động sản mới hồi tháng 7 năm ngoái, giá bán các bất động sản để ở gần đây đã tăng trở lại, đạt mức tăng 1,3% trong quý trước.

Theo thông tin cung cấp bởi Cơ quan Tái phát triển đô thị của Singapore, số lượng các dự án bất động sản tư nhân dang dở tăng từ  50.674 đơn vị trong quý trước lên 50.964 đơn vị cuối quý này. MAS cũng cảnh báo các cá nhân tham gia thị trường nên thận trọng hơn do sự bất ổn định của nền kinh tế cũng như sự suy giảm của thị trường lao động có thể tác động đến thu nhập hộ gia đình và làm giảm nhu cầu mua sắm bất động sản.

Cụ thể, MAS chỉ rõ: “Sự bất ổn trong triển vọng kinh tế và thị trường lao động đang đi xuống có thể sẽ gây ảnh hưởng tiêu cực đến thu nhập và nhu cầu về bất động sản của các hộ gia đình. Trong bối cảnh tốc độ tăng trưởng GDP còn chậm, việc tăng lương dự kiến sẽ bị kéo dài có thể làm giảm khả năng trả nợ của các hộ gia đình".

“Trước những bất lợi này, người mua tiềm năng nên nhận thức được những rủi ro cũng như thận trọng hơn khi đưa ra các quyết định dài hạn, chẳng hạn như mua nhà, vay mua nhà hay thế chấp bất động sản.”

Tricia Song, trưởng nhóm nghiên cứu của công ty dịch vụ bất động sản Colliers International tại Singapore cho biết doanh số của các chủ đầu tư có khả năng phục hồi khá tốt trong năm nay. Cô cũng dự báo rằng giá các căn hộ tư nhân sẽ ổn định và tăng khoảng 2% trong năm 2019.

Theo Tricia Song, trong năm 2020, giá nhà ở sẽ tiếp tục tăng trong khoảng từ 2% đến 3%, song song với mức tăng trưởng GDP. Tuy nhiên, nếu xu hướng giảm xảy ra chắc chắn sẽ kéo theo cầu giảm trong trung hạn và gây áp lực giảm giá tới các chủ đầu tư bất động sản.', 7)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (33, N'Thị trường bất động sản Úc giàu tiềm năng và cơ hội đầu tư
', CAST(N'2020-01-27T00:00:00.0000000' AS DateTime2), 9, N'Tăng trưởng ổn định, chính sách pháp lý minh bạch và cơ chế rõ ràng luôn là những yếu tố thôi thúc giới thượng lưu/các nhà đầu tư Việt Nam quyết định “xuống tiền” sở hữu bất động sản tại Úc.
Thị trường bất động sản Úc tăng trưởng nhanh và ổn định
Trong bối cảnh thị trường bất động sản đang dần trở nên “bội thực” tại các thành phố lớn, các dự án mới ngày càng bị thắt chặt nguồn cung và đặc biệt, đầu tư lướt sóng không còn mang lại nhiều lợi nhuận, xu hướng đầu tư bất động sản nước ngoài đang trở thành kênh sinh lời hấp dẫn. Trong đó, Úc sở hữu nền kinh tế - chính trị ổn định, an ninh và minh bạch trong chính sách quản lý tạo tiền đề vững chắc phát triển bất động sản.

Là quốc gia sở hữu tới 3 thành phố nằm trong Top 10 thành phố đáng sống nhất thế giới (năm 2019), không ngạc nhiên khi nhiều nhà kinh doanh bất động sản chuyên nghiệp lựa chọn Úc là địa điểm đầu tư.

Nhận định về môi trường kinh doanh tại Úc, ông Nguyễn Hoàng Việt, Chủ tịch HĐQT Son Viet Property JSC (SVP) cho biết: “So sánh hạ tầng, thiết kế, cảnh quan, nội thất và khả năng cho thuê cùng các điều kiện kinh tế-xã hội, Úc có nhiều lợi thế hơn các nước khác. Đặc biệt, Úc có một thị trường BĐS minh bạch về số liệu, có thống kê, điều tra thị trường rất rõ ràng." Ông cũng nhấn mạnh, người Việt ngày càng sở hữu nhiều bất động sản tại Úc, chủ yếu tập trung tại Melbourne và Sydney.  Theo số liệu thống kê nghiên cứu gần đây, hiện có khoảng 295.000 người Việt đang sinh sống và học tập tại Úc, đứng thứ 2 về số lượng người ngoại quốc sinh sống tại quốc gia này. Việt Nam cũng là nước có số lượng du học sinh lớn nhất tại xứ sở Kangaroo. Đặc biệt hơn, chính phủ Australia gần đây đã ban hành chính sách mở cửa giúp nhiều du học sinh Việt có điều kiện sở hữu nhà ở vĩnh viễn. Điều này đã thúc đẩy nhu cầu mua bất động sản tại Úc tăng cao.

Đáng chú ý, phần lớn nhu cầu mua nhà đất tại Úc bắt nguồn từ việc đầu tư cho con cái, do Úc là nước có nền giáo dục rất phát triển. Việc mua bất động sản tại xứ sở này phần nào là minh chứng về khả năng tài chính cho con cái tiếp tục du học, đồng thời tạo sự an tâm ổn định cư trú. 

Bên cạnh nhu cầu mua để ở, không ít nhà đầu tư mua nhà sinh lời. Theo nhận định của CBRE Việt Nam, thị trường bất động sản tại Úc là địa điểm đầu tư hàng đầu để giải ngân vốn trong vòng 3 năm tới. Nhờ giá trị nhà đất trung bình tại Úc tăng theo chu kỳ gấp đôi mỗi 7 năm mà bất động sản Úc trở thành một trong những thị trường tăng trưởng bền nhất thế giới nửa thập niên gần đây.

Cơ hội sinh lời rộng mở cho các nhà đầu tư 
Bất động sản Úc thường được các nhà đầu tư và khách hàng mua để ở ưa chuộng bởi tính an toàn, tin cậy trong giao dịch, thông tin quy hoạch, pháp lý minh bạch cũng như ưu đãi lớn từ chính phủ… Đặc biệt, các thành phố lớn của Úc với nền kinh tế - chính trị và bất động sản tăng trưởng ổn định luôn được các nhà đầu tư quan tâm. 

Theo báo cáo mới nhất của bà Nerida Conuceree - Chuyên gia kinh tế tại Realestate.com, bất động sản Úc đang đạt mức tăng giá cao nhất trong 2,5 năm vừa qua. Trong đó, Sydney và Melbourne tiếp tục giữ vị trí tiên phong. Tuy nhiên,theo nhận định của Giám đốc Finder, Graham Cooke, bất động sản tại 2 thành phố này sẽ dần hạ nhiệt và Canberra với vị trí thứ 3 rất có thể sẽ trở thành khu vực phát triển bất động sản tiềm năng trong những năm tiếp theo.

 Chiếm tới 50% thị phần các dự án bất động sản tại Canberra, tập đoàn Geocon là doanh nghiệp bất động sản tích hợp đầu tiên với kinh nghiệm dày dạn trong lĩnh vực phát triển xây dựng bất động sản, nội thất quản lý khách sạn, bán hàng và tư vấn,… Mang khát vọng tạo nên chân trời mới tại Canberra, tập đoàn Geocon đã nhanh chóng ghi dấu ấn thương hiệu tại GreenWay, Belconnen, Woden, Braddon,… Trong số đó, Black Diamond đang được xây dựng tại GreenWay thu hút được sự chú ý của giới đầu tư. 

Trong lần đầu tiên đến Việt Nam này, nhà phát triển dự án Geocon Group sẽ mang đến những thông tin hữu ích về tiềm năng thị trường bất động sản Úc và chia sẻ các cơ hội hợp tác để có được sự bứt phá về thu nhập dành cho các nhà môi giới tại Việt Nam.', 7)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (34, N'Chi phí hoàn thiện nội thất văn phòng tại Hồng Kông thấp hơn nhiều so với Tokyo và Sydney
', CAST(N'2020-01-30T00:00:00.0000000' AS DateTime2), 9, N'Một nghiên cứu mới đây cho thấy chi phí trang hoàng văn phòng mới tại Hồng Kông đang xếp sau 6 thành phố lớn ở Nhật và Úc. Điều này cũng phần nào an ủi những người đi thuê nhà tại nơi mà suốt 4 năm liền vẫn luôn đứng đầu bảng xếp hạng giá thuê thế giới.
Với mức chi phí khoảng 1.399 USD/m2, Hồng Kông hiện đang xếp thứ 7 về chi phí trang bị nội thất cho văn phòng trên bảng xếp hạng gồm 28 thành phố cửa ngõ thuộc Châu Á - Thái Bình Dương. Thông tin này nằm trong một bản hướng dẫn được được công bố bởi Cushman & Wakefield, một công ty đa quốc gia cung cấp dịch vụ bất động sản có trụ sở tại Chicago. Cụ thể hơn, con số này thấp hơn 35,6% so với Tokyo (2.174 USD/m2) và 16% so với Sydney (1.657 USD/m2). Bên cạnh đó, Đài Bắc hiện đang là nơi có mức giá phải chăng nhất với giá thuê 753 USD/m2. Tom Gibson, Giám đốc điều hành dự án và phát triển dịch vụ của Cushman & Wakefield cho biết, chi phí nhân công giá nội thất, trang thiết bị và vật liệu xây dựng là những yếu tố chính khiến chi phí hoàn thiện nội thất văn phòng ở Hồng Kông thấp hơn so với những thành phố lớn ở Nhật Bản và Úc.

Từ trước đến nay, Hồng Kông vẫn luôn là một trong những thành phố có giá thuê văn phòng đắt nhất thế giới. Theo báo cáo của Tập đoàn bất động sản CBRE của Mỹ, Hồng Kông đã 4 năm liền đứng đầu bảng xếp hạng giá thuê văn phòng tại các tòa cao cấp thuộc khu vực trung tâm. Theo các chuyên gia, việc thiếu hụt nguồn cung và nhu cầu ngày một tăng cao từ các ngân hàng và các công ty Trung Quốc đại lục đã đẩy giá thuê tăng vọt trong những năm gần đây.

Bản hướng dẫn của Cushman & Wakefield được công bố nhằm giúp người thuê văn phòng xác định ngân sách và lập kế hoạch vốn cũng như kế hoạch thi công phù hợp. Văn bản này bao gồm các phân tích cụ thể về chi phí gồm cả phí bảo trì/bảo dưỡng đối với các yếu tố cấu thành nên một văn phòng, từ đồ nội thất, trang thiết bị, hệ thống điện, thi công, đến các yếu tố về công nghệ thông tin/nghe nhìn.

Theo Bryant Cheung, Giám đốc và người chịu trách nhiệm về mảng dự án & phát triển dịch vụ tại Hồng Kông của Cushman & Wakefield, chí phi cho công nhân hay phí thi công đang là loại phí lớn nhất khi thi công văn phòng tại Hồng Kông.

“Tuy nhiên, chi phí công nghệ thông tin/nghe nhìn cũng đang tăng lên đáng kể song song với sự phát triển của các loại hình làm việc từ xa, văn phòng ảo, hay văn phòng chia sẻ.”

Tại Hồng Kông, chi phí thi công hiện đang chiếm khoảng 35% tổng chi phí thuê văn phòng, trong khi đó, các chi phí về điện và cơ khí chiếm khoảng 31%. Chi phí nội thất chiếm 18% và 10% cho các thiết bị công nghệ/nghe nhìn. Thông tin này được lấy từ báo cáo của Cushman & Wakefield. Theo thông tin lấy từ báo cáo của CBRE, một công ty nếu muốn thuê khoảng 2.800m2 văn phòng hạng A tại Hồng Kông sẽ phải đầu tư khoảng 33.5 triệu USD cho thời hạn thuê 5 năm. Báo cáo này cũng chỉ ra rằng Hồng Kông hiện đang xếp sau Tokyo và Sydney về chi phí hoàn thiện nội thất văn phòng. Cụ thể, chi phí thuê sẽ chiếm khoảng 80% tổng chi phí trong khi chi phí cho nội thất trong suốt quá trình thuê chiếm khoảng 15%.

Bà Mak Yiu Chi, Giám đốc quản lý chi phí tại JLL Châu Á - Thái Bình Dương cho biết, chi phí trang hoàng nội thất văn phòng ở Tokyo tăng cao chủ yếu là do hầu hết các chủ cho thuê ở đây thường hợp tác với nhà thầu thi công chỉ định. Theo Mak Yiu Chi, cái giá mà họ đưa ra không mang tính cạnh tranh và sẽ còn kém hơn do khủng hoảng lao động đến từ sự kiện Olympic mùa hè năm sau.

Chia sẻ thêm, Mak Yiu Chi cũng không mong muốn các khách hàng của JLL cắt giảm ngân khách cải tạo văn phòng của họ. Thực tế, ngày càng có nhiều công ty chú tâm vào vấn về sức khỏe trong thiết kế văn phòng.

“Xu hướng này càng phổ biến, khiến cả nhân viễn lẫn khách hàng có những trải nghiệm tuyệt hơn tại văn phòng làm việc. Trong khi các các nhà tuyển dụng phải “tranh giành” ứng viên tài năng với các công ty công nghệ quốc tế, việc chú trọng vào nội thất văn phòng đáp ứng văn hóa làm việc mới là cần thiết.”', 7)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (35, N'Căn hộ mặt biển Đà Nẵng: Mảnh ghép nào cho sân chơi đang “khát” nguồn cung?
', CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), 9, N'Nửa cuối năm 2020, thị trường bất động sản Đà Nẵng có những tín hiệu khả quan phục hồi sau Covid-19. Tuy nhiên, nhiều chuyên gia nhận định sẽ có sự điều chỉnh về giá trị phù hợp với nhu cầu ở thực và hiệu quả mang về cho nhà đầu tư phải rõ nét. Đặc biệt vấn đề pháp lý các dự án phải hoàn chỉnh mới đảm bảo thanh khoản.
Lúc này, căn hộ cao cấp sở hữu lâu dài ngay mặt biển Võ Nguyên Giáp – Đà Nẵng một lần nữa được xướng tên là “cầu vồng” sau mưa nhờ đáp ứng được nhu cầu mua để ở, nghỉ dưỡng và đầu tư tích lũy. Căn hộ cao cấp có pháp lý sở hữu lâu dài thì không có gì phải bàn cãi nhưng tại sao phải là mặt biển Võ Nguyên Giáp?

Mặt biển Võ Nguyên Giáp – nơi đánh thức di sản, chạm đến phồn hoa
Ba điều quan trọng nhất trong kinh doanh bất động sản là: vị trí, vị trí và vị trí. Điều này cho thấy, việc lựa chọn vị trí của bất động sản là yếu tố gần như quyết định được tính tích lũy của tài sản và địa vị xã hội của gia chủ. 

Nhắc đến Đà Nẵng, người ta sẽ nhớ ngay đến cung đường “tỷ đô” Võ Nguyên Giáp ven biển Mỹ Khê - tâm điểm phát triển kinh tế du lịch của Miền Trung, với khả năng kết nối Sơn Trà – Hội An, là nơi giao thoa giữa dòng chảy đô thị Đà Thành và vùng đất di sản phố Hội. Việc sở hữu bất động sản trên dải đất “gà đẻ trứng vàng” này là khát khao của nhiều nhà đầu tư và giới thượng lưu tinh hoa. Nghịch lý thay, căn hộ cao cấp sở hữu lâu dài tại Đà Nẵng chủ yếu phân bố ở mặt sông Hàn, biển Mỹ Khê lại là điểm tập kết của dòng sản phẩm Condotel có pháp lý sở hữu 50 năm. Khung pháp lý sổ đỏ 50 năm cho hình thức Condotel là dấu hiệu tích cực cho loại hình này được phát triển minh bạch, bền vững. Nhưng tâm lý chung của đại đa số người Việt, sở hữu bất động sản lâu dài vẫn được ưu tiên hàng đầu. 

Có thể khẳng định, nguồn cung căn hộ cao cấp Đà Nẵng không ít nhưng để tìm thấy một sản phẩm tại vị trí mặt biển, hạng sang thực sự, vượt trội với pháp lý sở hữu lâu dài thì vẫn là một bài toán nan giải. Sân chơi này vẫn còn thiếu một mảnh ghép hoàn hảo làm nên bức tranh xán lạn cho toàn thị trường địa phương nói chung. 

Mảnh ghép hoàn hảo cho san chơi “khát” nguồn cung 
Dù là sân chơi tiềm năng nhưng thị trường căn hộ cao cấp ven biển Mỹ Khê vẫn vắng bóng những sản phẩm sao sáng bởi thị trường này đòi hỏi những chủ đầu tư đủ tiềm lực “nói là làm”.

Tháng 6/2020 này, căn hộ cao cấp Premier Sky Residences đến từ chủ đầu tư Công ty TNHH Dịch vụ Du lịch và Thương mại Minh Đông sắp ra mắt được cho là “thỏi nam châm” thu hút giới thượng lưu và nhà đầu tư thông thái nhất. Minh chứng nào cho nhận định này?  Pháp lý sổ hồng lâu dài: Toàn bộ đất cấp cho dự án Premier Sky Residences đã có giấy chứng nhận quyền sử dụng đất cấp cho Công ty TNHH Minh Đông với mục đích: đất ở đô thị, thời hạn sử dụng lâu dài. Trong chấp nhận chủ trương đầu tư Số 5745/UBND-SXD do UBND TP.Đà Nẵng phê duyệt, mục tiêu của dự án là đầu tư xây dựng nhà ở thương mại ( căn hộ chung cư ) để bán và khách sạn 5 sao tiêu chuẩn để kinh doanh. Do đó, khách mua căn hộ được sử dụng ổn định lâu dài theo Quy định điều 126 Luật Đất Đai.

Vị trí đẹp và hiếm: Tọa lạc trên cung đường Võ Nguyên Giáp, một bước chân là đến biển Mỹ Khê – 1 trong 6 bãi biển quyến rũ nhất hành tinh, Premier Sky Residences cách công viên biển Phạm Văn Đồng chỉ 500m – nơi diễn ra hoạt động vui chơi, lễ hội lớn nhỏ hàng đầu Đà Nẵng. Nhờ đó, Premier Sky Residences kiến tạo nên những trải nghiệm sống thời thượng hiện đại mà vẫn mang lại cho chủ nhân cảm giác đắm mình vào thiên nhiên diệu kỳ.

Đã cất nóc và đi vào hoàn thiện: Premier Sky Residences đã được cất nóc và đang trong giai đoạn hoàn thiện với tổng vốn đầu tư hơn 2000 tỷ đồng, chứng minh cho tiềm lực tài chính của chủ đầu tư và mang đến sự tin tưởng cho khách hàng khi có thể “mắt thấy, tay sờ” những giá trị, tiện ích đi kèm, chất lượng công trình. 

Hệ thống tiện ích được nâng tầm: Tiện ích tại Premier Sky Residences không chỉ đơn thuần là lý tưởng, đáng sống mà còn được nâng tầm với: Sảnh nghệ thuật, bãi đỗ xe định danh, hệ thống smart home SPMS quản lý bởi công nghệ trí tuệ nhân tạo và big data, Gym, Spa, Yoga tầm nhìn biển, khu vui chơi trong nhà cho trẻ em, Trường mầm non quốc tế, hồ bơi vô cực, nhà hàng tinh hoa ẩm thực Việt (Vietnamese Signature Restaurant),… Đặc biệt, Premier Sky Residences tiên phong mang đến những trải nghiệm chưa từng có: Phòng thử rượu ( tasting room), Cigar lounge, Make up – hair & nails salon, dịch vụ dọn phòng 24/24…

Sẽ vẫn còn rất nhiều ưu điểm của dự án chờ đón được khám phá. Nhưng với những lợi thế vượt trội được kể đến, liệu đã đủ khẳng định Premier Sky Residences chính là mảnh ghép hoàn thiện sân chơi bất động sản cao cấp Đà Nẵng, trong bối cảnh quỹ dất ven biển Mỹ Khê tương lai sẽ khó có thêm một dự án căn hộ sở hữu lâu dài nào được cấp phép? ', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (36, N'The Emerald Golf View - Biểu tượng tự hào mới tại Bình Dương
', CAST(N'2020-06-10T00:00:00.0000000' AS DateTime2), 9, N'Một cộng đồng cư dân tinh hoa với tiêu chuẩn sống 5 sao đang dần hình thành tại The Emerald Golf View với khát vọng trở thành một biểu tượng tự hào mới ngay trung tâm đô thị Bình Dương.
Cuộc sống 5 sao bên sân golf đẳng cấp quốc tế
Ngay từ khi thiết kế kiến trúc, The Emerald Golf View đã mang tâm huyết của những chuyên gia mong muốn kiến tạo nên một sản phẩm căn hộ cao cấp đúng nghĩa. Quỹ đất hiếm hoi ngay mặt tiền Đại lộ Bình Dương bên cạnh sân Golf quốc tế Sông Bé và trực diện khu công nghiệp Vsip1 đã đòi hỏi phải có một khu căn hộ tương xứng cho vị trí hàng đầu này.  Bên cạnh thú vui ưa thích của giới thượng lưu, sân golf còn được coi là biểu tượng của những khu nghỉ dưỡng xa hoa. Và lần đầu tiên tại Bình Dương, The Emerald Golf View đã tái hiện hoàn hảo một cảm hứng sống đậm chất nghỉ dưỡng trên cao với tầm nhìn triệu đô ôm trọn sân Golf Sông Bé - một trong những sân Golf đầu tiên tại Việt Nam đạt chuẩn quốc tế được công nhân bởi Hiệp hội những người chơi Golf của Mỹ và Singapore. The Emerald Golf View là cả một thế giới “sống - thư giãn” gói gọn trong hơn 80 tiện ích đẳng cấp 5 sao được thiết kế tỉ mỉ để làm hài lòng ngay cả những chủ nhân khó tính nhất. Thỏa sức mua sắm tại trung tâm thương mại, tản bộ ngắm cảnh tại công viên chuyên đề, nâng cao sức khỏe tại câu lạc bộ Gym - Spa, tái tạo năng lượng cùng hồ bơi vô cực, thư giãn sau chuỗi ngày làm việc tại khu Family lounge, dành thời gian bên con trẻ tại khu vui chơi ngoài trời, hay vô vàn tiện ích khác để bạn có thể tận hưởng ngay trước thềm nhà mà không cần phải đi quá xa. “Chúng tôi nỗ lực kiến tạo nên một thế giới trải nghiệm - giải trí - nghỉ ngơi tại gia để biến ngôi nhà trở thành nơi đáng mong đợi nhất. Đội ngũ kiến trúc sư phải tính toán rất kỹ các tiện ích và bố trí hợp lý trong nhà cũng như ngoài trời để luôn mang lại cảm giác mới mẻ, không nhàm chán cho người sử dụng. Tại The Emerald Golf View, dù là trẻ em hay người cao tuổi, người độc thân hay gia đình trẻ, người thích yên tĩnh hay ưa vận động đều có thể tìm thấy thế giới của mình”, ông Bùi Ngươn Phong, Chủ tịch HĐQT kiêm TGĐ Công ty TNHH Đầu tư & Phát triển Lê Phong, chủ đầu tư dự án chia sẻ.

Vị trí đắc địa ngay lõi đô thị phát triển còn cho phép cư dân The Emerald Golf View dễ dàng tiếp cận hàng loạt hệ thống tiện ích từ y tế, giáo dục đến mua sắm, nổi bật như siêu thị Aeon Mall Bình Dương, hệ thống nhà hàng sân golf quốc tế Sông Bé, siêu thị Lotte Mart, siêu thị điện máy Chợ Lớn, hệ thống các ngân hàng uy tín hay hệ thống trường học các cấp… 

Căn hộ đẳng cấp thượng lưu dành cho giới chuyên gia
Bất động sản Bình Dương đang bước vào một thời kỳ mới với những sự thay đổi rất rõ nét về sản phẩm. Nếu trước đây, dự án đơn thuần chỉ là nơi để ở với thiết kế không mấy nổi bật và tiện ích đơn giản thì giờ đây, với sự gia nhập của một thế hệ khách hàng mới, các dự án đã được nâng lên một tầm cao mới theo định hướng căn hộ cao cấp. Một dự án đáp ứng đủ tiêu chí như The Emerald Golf View xuất hiện vào thời điểm này không chỉ giải được “cơn khát” căn hộ cao cấp tại Bình Dương, mà còn trở thành lựa chọn lý tưởng bậc nhất cho giới khách hàng chuyên gia. Mỗi căn hộ The Emerald Golf View có diện tích linh hoạt từ 50m2 - 115m2 được thiết kế tinh tế, tối ưu công năng, phù hợp với mọi nhu cầu sống với mức giá chỉ từ 1,8 tỷ đồng/căn. Mỗi chi tiết trong căn hộ đều được trau chuốt tỉ mỉ, toát lên sự tinh tế kết hợp cùng hệ nguyên vật liệu cao cấp mang lại một không gian sống đáng kiêu hãnh cho những người có gout thưởng thức. 

Chính vì thế, một cộng đồng cư dân tinh hoa đang dần hình thành ở The Emerald Golf View với sự đồng điệu về phong cách sống văn minh, hiện đại và đầy tính nhân văn. Đây chính là tài sản vô hình cực kỳ giá trị, nhất là khi quan niệm “chọn nhà chọn hàng xóm” trở nên phổ biến, thậm chí trở thành yếu tố quan trọng khi tìm kiếm chốn an cư. ', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (37, N'Ưu đãi hấp dẫn, phân khu River Park 1 tại đô thị Aqua City hút vốn đầu tư
', CAST(N'2020-06-08T00:00:00.0000000' AS DateTime2), 10, N'Trong bối cảnh các kênh đầu tư tài chính chứa đựng nhiều biến động thì bất động sản vẫn được xem là lựa chọn an toàn. Bởi vậy, khi một số chủ đầu tư áp dụng những chính sách linh hoạt thì nhà đầu tư sẵn sàng xuống tiền.
Tâm lý cẩn trọng khi lựa chọn sản phẩm đầu tư
Thị trường chứng khoán trong nước có những thời điểm lao dốc do chịu ảnh hưởng của chứng khoán thế giới. Thị trường vàng cũng diễn ra nhiều phiên biến động liên tục. Việc tìm kiếm kênh đầu tư an toàn là câu hỏi khiến nhà đầu tư băn khoăn trong giai đoạn này. Mặc dù bất động sản không nằm ngoài quy luật thay đổi đó, song đây vẫn được đánh giá là kênh tiềm năng và đặc biệt chứa đựng sự an toàn, ổn định nếu người mua chọn những sản phẩm tốt, có giá trị bền vững. 

Đặc biệt, kể từ sau dịch Covid -19, khi thị trường bất động sản có sự thanh lọc, thị hiếu của nhà đầu tư cũng thay đổi, nói không với việc lướt sóng mà tập trung vào đầu tư dài hạn. Đây là lý do để những dự án tọa lạc tại vị trí đắc địa, có tiềm năng sinh lời cao, đặc biệt, ở các dự án của chủ đầu tư lớn có sự linh hoạt trong việc áp dụng chính sách giới thiệu sản phẩm, mang đến nhiều lợi điểm cho nhà đầu tư dễ dàng tạo sóng trên thị trường. Điển hình có thể kể đến phân khu River Park 1 thuộc dự án Aqua City của Tập đoàn Novaland. Tại đây, doanh nghiệp đã đưa ra nhiều phương án tài chính linh hoạt phù hợp với năng lực tài chính của nhà đầu tư. Một trong những phương thức được khách hàng đánh giá mang lại nhiều ưu điểm đó là chính sách 1% mỗi tháng. Giả sử, khi đầu tư nhà phố giá 6,3 tỷ đồng, khách hàng chỉ cần 10% cho đợt đầu tiên. Dòng vốn cho các đợt tiếp theo chỉ 1% mỗi tháng. 

Như vậy, với các khách hàng lựa chọn dự án để đầu tư, chính sách này giúp giảm áp lực dòng tiền. Đặc biệt, sau 3 năm, khi đã được nhận bàn giao nhà, khách hàng có thể khai thác cho thuê sinh lợi nhuận, đảm bảo chủ sở hữu có ngay dòng tiền để sớm thanh toán, tất toán khoản vay cho ngân hàng nếu có. “Tính về lợi ích lâu dài, chính sách 1%/tháng khi đầu tư phân khu River Park 1 không chỉ nhẹ dòng tiền trong từng đợt mà còn giúp tôi dễ dàng phân bổ tài chính cho công việc kinh doanh", anh Xuân Hải, một nhà đầu tư tại Hà Nội chia sẻ. 
Hiện đơn vị này còn áp dụng nhiều chính sách ưu đãi cho khách lựa chọn sản phẩm tại phân khu River Park 1 như tặng gói bảo hiểm sức khỏe dành cho gia đình với tổng giá trị lên tới 50 triệu đồng, ưu đãi 1%/ giá trị sản phẩm dành cho khách hàng thân thiết và nhiều ưu đãi khác.

River Park 1 – Vị trí sinh lời vượt trội
Nằm tại cửa ngõ dự án Aqua City, trên trục đường Hương lộ 2 kết nối Cao tốc TP.HCM – Long Thành – Dầu Giây, River Park 1 được xem là một trong những phân khu sở hữu vị trí đắc địa tại Aqua City. Không chỉ vậy, đây còn là phân khu nằm cạnh khu dân cư hiện hữu, nơi có nhiều tiện ích đã vận hành. Vì vậy, cư dân có thể dọn về ở ngay khi nhận bàn giao nhà. Lợi thế vị trí đó của River Park 1 khiến phân khu này được đánh giá là sẽ sớm thu hút cư dân sinh sống và trở nên sôi động. Đây chính là “đòn bẩy” để khu vực này hình thành nên một trung tâm sầm uất, giao thương nhộn nhịp trong tương lai, hứa hẹn tiềm năng sinh lời cho nhà đầu tư. Cùng với lợi thế cửa ngõ, điểm đắt giá của phân khu River Park 1 còn đến từ giá trị sống sinh thái tiện nghi với hệ thống công viên, mảng xanh, mặt nước lên đến hơn 2,4 ha; hệ thống tiện ích nội khu hiện đại như clubhouse, sân tập thể thao, bể bơi tiêu chuẩn resort…
Bên cạnh đó, cư dân River Park 1 còn được tận hưởng những tiện ích chung của đô thị Aqua City như: Trường học, bệnh viện theo chuẩn quốc tế, trung tâm thương mại, bến du thuyền… chỉ cách đó vài bước chân.

Ngoài ra, River Park 1 còn thu hút nhà đầu tư bởi sản phẩm có diện tích vừa phải với đa dạng loại hình từ nhà phố thương mại, nhà phố liền kề, biệt thự… Cũng bởi vậy, mức chi phí đầu tư ban đầu vừa phải, phù hợp với khả năng tài chính của nhiều nhóm khách hàng.  
“Sở hữu nhiều lợi thế vượt trội, phân khu River Park 1 hứa hẹn là kênh đầu tư bền vững khi vừa gia tăng về giá trị, vừa mang lại lợi nhuận lâu dài cho khách hàng”, giới đầu tư nhận định.', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (38, N'Hành trình 5 năm phát triển của Van Phuc City
', CAST(N'2020-06-09T00:00:00.0000000' AS DateTime2), 9, N'Sau 5 năm hình thành và phát triển, Tập đoàn BĐS Vạn Phúc đã đổ nguồn lực đầu tư hơn 10.000 tỷ đồng, chuyển mình phát triển thần tốc, đưa KĐT Vạn Phúc trở thành đại đô thị ven sông đáng sống bậc nhất TP.HCM.
 Quy hoạch đồng bộ, phát triển bền vững: Với quy mô 198ha, KĐT Vạn Phúc là đại đô thị lớn thứ 2 của thành phố và là đô thị ven sông lớn bậc nhất khu Đông, là nơi an cư của gần 40.000 cư dân sinh sống, góp phần tích cực vào sự phát triển kinh tế, xã hội của Quận Thủ Đức cũng như TP.HCM. 

Giao thông hoàn chỉnh, kết nối thuận lợi: Năm 2020 đánh dấu cột mốc quan trọng khi chủ đầu tư hoàn thiện và thông xe 2 trục giao thông chính huyết mạch, hoàn thành tuyến kè ven sông và tuyến đường vành đai 3,4km dọc theo bờ sông Sài Gòn. Ngoài ra hơn 20km hạ tầng nội khu đã được đầu tư hoàn chỉnh đảm bảo giao thông thông suốt toàn khu đô thị. 

Môi trường sống hoàn hảo, đáng sống bậc nhất: Nơi đây được ví như một ốc đảo xanh, nằm giữa Sài Gòn hoa lệ sở hữu địa thế và cảnh quan hiếm có được ôm trọn 3 mặt bởi sông Sài Gòn xanh mát, hồ Đại Nhật rộng 16ha ở trung tâm khu đô thị cùng với kênh Sông Trăng hiền hòa dài gần 2km mang lại không gian sống tuyệt vời và môi trường sống hoàn hảo dành cho cư dân và du khách ghé thăm.

Hệ thống y tế - giáo dục hàng đầu khu vực: Chỉ sau 5 năm khu đô thị Vạn Phúc đã hiện diện hệ thống trường học hàng đầu khu vực với Trường Song ngữ Quốc tế liên cấp Emasi chất lượng, hệ thống trường công lập từ mẫu giáo đến cấp 2 và trường mầm non tư thục.  Đầu tư tiện ích đẳng cấp, tiện nghi: Chủ đầu tư chú trọng hoàn thiện các tiện ích đầy đủ, khép kín phục vụ nhu cầu an cư của cư dân bao gồm 10ha cảnh quan công viên với hồ bơi, clubhouse, khu vui chơi dành cho trẻ em, dành cho gia đình, cảnh quan công viên xanh tươi, khu tập thể thao ngoài trời, sân tennis, sân bóng đá, đường đi dạo, các khu vực mua sắm, ăn uống, thư giãn rất tiện lợi, sang trọng. Hơn 1.500 căn nhà đã được xây dựng và bàn giao: Hơn 1.500 căn nhà với khoảng 700.000m2 sàn xây dựng đã được hoàn thành và bàn giao cho khách hàng trong những năm vừa qua. Chủ đầu tư tiên phong với dòng sản phẩm shophouse cao cấp, kiến trúc hoàn mỹ với mặt tiền nhân đôi 7-9m, cao 5-6 tầng tích hợp công năng vừa ở, vừa kinh doanh, dòng sản phẩm shop villa, biệt thự ven sông, căn hộ cao cấp độc đáo, chất lượng cao.

Dân cư sung túc, nhịp sống sôi động: KĐT Vạn Phúc thành công khi được đông đảo khách hàng lựa chọn là điểm đến an cư và đầu tư dài hạn. Khách hàng mua ở đạt tỉ lệ rất cao với tỉ lệ lấp đầy giai đoạn 1 đạt trên 90% cư dân về ở. Hiện nay cộng đồng dân cư tại Vạn Phúc đã rất sung túc và gắn kết với gần 3.000 cư dân đang sinh sống tại đây.

Tâm điểm giao thương, giá trị gia tăng vượt trội: Với vị trí đắc địa ngay khu vực cửa ngõ Đông Bắc thành phố, KĐT Vạn Phúc trở thành tâm điểm giao thương với gần 300 doanh nghiệp đang hoạt động tại đây. Bên cạnh đó dọc theo các tuyến đường giao thông huyết mạch các cửa hàng mua sắm, cửa hàng dịch vụ hoạt động nhộn nhịp mang lại sinh khí và giá trị gia tăng không ngừng cho BĐS nơi đây.

Điểm đến vui chơi giải trí, gắn kết cộng đồng: Chủ đầu tư rất chú trọng đến các hoạt động cộng đồng tổ chức các lễ hội Quốc tế thiếu nhi, Tết Trung Thu, hội hoa xuân dành cho cư dân, chương trình đi bộ đồng hành cùng người nghèo hay Lễ hội cánh đồng hoa hướng dương, là điểm đến yêu thích của người dân thành phố. Pháp lý đầy đủ, minh bạch thông tin: Chủ đầu tư đã hoàn thành tất cả thủ tục pháp lý theo quy định. Tại thời điểm bàn giao nhà, Giấy chứng nhận quyền sử dụng đất ở đã được hoàn tất, sẵn sàng cho công tác hoàn công, cấp Giấy chứng nhận sở hữu nhà ở, khẳng định niềm tin và uy tín của Chủ đầu tư đối với khách hàng mua nhà.

Năm 2020, Chủ đầu tư chi 2.500 tỷ đồng với mục tiêu khánh thành đưa vào hoạt động 10 hạng mục công trình hạ tầng, tiện ích và khởi công 6 hạng mục công trình mới nhân kỷ niệm 25 năm thành lập Tập đoàn. Liên tiếp trong những năm qua, KĐT Vạn Phúc được các chuyên gia, khách hàng và bạn đọc bình chọn là Khu đô thị đáng sống nhất, không gian sống xanh hàng đầu Việt Nam.

Hành trình 5 năm phát triển của KĐT Vạn Phúc vươn lên thành KĐT sinh thái bậc nhất ven sông, không gian sống lý tưởng tại TP.HCM là sự khẳng định về tầm vóc, uy tín và thương hiệu hàng đầu của Tập đoàn Vạn Phúc trong vòng 25 năm vừa qua. ', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (39, N'Apec Group và triết lý phát triển bền vững
', CAST(N'2020-06-09T00:00:00.0000000' AS DateTime2), 9, N'Apec Group là một trong số ít những nhà phát triển dự án trong lĩnh vực bất động sản vừa phát triển về quy mô, số lượng dự án vừa chú trọng vào concept để mỗi dự án đều có một “tâm hồn” riêng.
Trở thành nhà đầu tư chiến lược tại những tỉnh thành mà Apec Group đi qua
Với chiến lược khác biệt khi tập trung vào các thị trường bất động sản lỉnh lẻ thay vì các thành phố lớn, Apec Group mang tham vọng chiếm lĩnh thị trường tỉnh. Về lí do lựa chọn lối đi riêng này, đại diện Apec chia sẻ: “Các doanh nghiệp chuyển hướng tìm đến thị trường bất động sản tỉnh, theo một cách tự nhiên, dòng vốn cũng sẽ dịch chuyển về những thị trường đầy tiềm năng này. Đó chính là lý do tiên quyết giúp chúng tôi lựa chọn hướng đi để phát triển. Tuy nhiên, một lý do khác cũng quan trọng không kém, đó chính là khát vọng kiến tạo nên những dự án tầm cỡ tại các tỉnh mà Apec Group đặt chân đến, chúng tôi hy vọng những dự án này sẽ trở thành những dự án kiểu mẫu đóng góp vào việc thay đổi không gian đô thị của tỉnh”.  Hiện nay Apec Group được coi là đơn vị đầu tư chiến lược tại tỉnh Yên Bái, Lạng Sơn, Bắc Giang, Hải Dương, Thừa Thiên Huế, Phú Yên và Bình Thuận... Các dự án của tập đoàn này đều nằm ở những vị trí đắc địa, tạo nên những điểm nhấn của thành phố. Những dự án mang lại thành công bước đầu phải kể đến: Royal Park Huế, khu đô thị xanh có quy mô 34,7ha được đánh giá là nơi đáng sống nhất miền Trung; Royal Park Bắc Ninh, dự án căn hộ khách sạn đẳng cấp 5 sao đầu tiên tại Bắc Ninh phục vụ các chuyên gia quốc tế và các cư dân thượng lưu; Aqua Park Bắc Giang, biểu tượng thượng lưu mới của Bắc Giang. Tại Phú Yên, Apec Group cũng trở thành nhà phát triển 3 dự án lớn có quy mô hành chục ha tại thành phố Tuy Hòa. Apec cũng là nhà phát triển dự án khách sạn lớn nhất tại Bình Thuận với quy mô 3.000 phòng theo tiêu chuẩn 5 sao.

Chữ “tâm” giúp doanh nghiệp phát triển bền vững
Với mỗi dự án, Apec Group đều mang đến một mô hình và màu sắc khác nhau không chỉ tạo nên một sản phẩm đầu tư sinh lời cao mà còn mang đến những giá trị nhân văn sâu sắc về niềm tự hào dân tộc, triết lý sống và tìm về bản ngã của mỗi người. Vì vậy chữ “tâm” luôn được Apec Group đặt lên hàng đầu và thể hiện qua triết lý hạnh phúc mà Apec Group đang hướng tới. Các dự án khách sạn của Apec Group đều lấy thương hiệu Mandala. Tại sao lại là Mandala? Một đại diện Apec Group chia sẻ: “Chúng tôi biết rằng, để hạnh phúc bạn phải là chính mình, nhưng không phải ai cũng hiểu được bản thân mình và biết được mình là ai? Mandala ngoài tượng trưng cho cuộc sống luân hồi, mọi vật đều có sự kết nối thì còn có nghĩa là hành trình tìm đến bản ngã của mỗi con người. Đó là triết lý mà chúng tôi đang hướng đến và chúng tôi mong muốn rằng qua kiến trúc, không gian, dịch vụ, chúng tôi sẽ đem đến cuộc hành trình tìm kiếm bên trong mỗi cá nhân.

Chúng tôi muốn kể câu chuyện về Mandala thông qua chuỗi khách sạn của Apec và mong muốn truyền những thông điệp ý nghĩa về giá trị cuộc sống, giá trị của mỗi con người tới bất cứ ai đến với khách sạn của chúng tôi”. Apec Group là một trong số ít những doanh nghiệp có triết lý rõ ràng. Triết lý được thể hiện qua văn hóa doanh nghiệp và các hoạt động xã hội mà Apec Group đang triển khai. Các hoạt động nổi bật như Siêu thị Hạnh phúc 0đ - Hệ thống siêu thị trên 22 tỉnh thành nhằm cung cấp các sản phẩm thiết yếu tới những người gặp khó khăn trong đợt dịch Covid. Chương trình “Cùng em đến trường” cấp học bổng dài hạn cho những em học sinh tại các vùng cao. Chương trình “Thư viện hạnh phúc” tại Hà Nội dành cho tất cả những người yêu sách và muốn phát triển bản thân. Hay học viên doanh nhân hạnh phúc - nơi đào tạo ra những thế hệ doanh nhân phụng sự, doanh nhân tử tế.

Mới đây Apec Group cũng giới thiệu dự án Nông nghiệp hữu cơ. Toàn bộ sản lượng nông nghiệp hữu cơ, nông nghiệp sạch công nghệ cao tại hệ thống trang trại của Apec Group sẽ được sử dụng và tiêu thụ trong toàn hệ thống khách sạn, resort thuộc chuỗi Apec Mandala trên cả nước (Mandala Bắc Ninh, Bắc Giang, Hòa Bình, Lạng Sơn, Huế, Phú Yên, Mũi Né - Bình Thuận…) hình thành chuỗi khách sạn hữu cơ - khách sạn xanh đầu tiên tại Việt Nam, đồng thời bắt đầu cung ứng sản phẩm nông nghiệp hữu cơ chất lượng cao ra ngoài thị trường. 

Cùng với các dự án xử lý rác thải, Apec Group dần hoàn thiện hệ sinh thái du lịch - khách sạn - tiêu dùng - giáo dục và bảo vệ môi trường. Apec Group xác định sứ mệnh trở thành “platform” (nền tảng) đưa sản phẩm chất lượng phổ biến rộng rãi đến với toàn xã hội.', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (40, N'Nhơn Hội - Tâm điểm đầu tư bất động sản duyên hải miền Trung
', CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), 9, N'Sau khi mở rộng quy mô và chuyển hướng phát triển vào giữa năm 2019, Khu kinh tế Nhơn Hội như được đánh thức, bừng sáng và sẵn sàng cho một tương lai dẫn đầu. Thực tế, đây là vùng đất hội tụ đầy đủ các yếu tố tạo nên địa thế vàng của bất động sản bên vịnh biển.
Sức hút từ “thỏi nam châm” Nhơn Hội 
Tháng 5/2019, đề án điều chỉnh mở rộng và chuyển hướng phát triển Khu kinh tế (KTT) Nhơn Hội chính thức được Thủ tướng phê duyệt. Từ định hướng phát triển về công nghiệp, dịch vụ, đô thị, KKT Nhơn Hội sẽ là một KKT đa ngành, trọng tâm phát triển du lịch, dịch vụ, công nghiệp, đô thị, cảng biển, năng lượng tái tạo… đưa Bình Định thành vùng kinh tế trọng điểm phía Nam của miền Trung, đầu mối giao thương trực tiếp với Tây Nguyên và trở thành trung tâm giao thương quốc tế của hành lang kinh tế Đông - Tây. Với quy mô rộng hơn 14.000ha, KKT Nhơn Hội đang sở hữu vị thế mà không phải nơi nào cũng có được, đặc biệt là đối với các dự án bất động sản tọa lạc tại đây. Nằm giữa lòng KKT này là bán đảo Phương Mai và những bờ biển đẹp nhất nhì cả nước như Kỳ Co, Eo Gió, Bãi Dứa, Hòn Sẹo… Khi các dự án đi vào hoạt động, nơi đây sẽ trở thành một vùng đất tiện nghi và năng động bậc nhất vùng duyên hải miền Trung. 

Bên cạnh đó, Nhơn Hội cũng thể hiện ưu thế lý tưởng về mặt giao thông - yếu tố cực kỳ quan trọng trong đầu tư bất động sản. Sự xuất hiện của cây cầu vượt biển Thị Nại nối toàn bộ bán đảo Phương Mai với Quy Nhơn đã mở ra cho thành phố biển một hướng giao thương khác ở phía Bắc sau tuyến Quy Nhơn - sông Cầu ở phía Nam, đưa Phương Mai trở thành điểm đến của những dự án nghìn tỷ. Quốc lộ 19 mới - dự án đường bộ có quy mô lớn nhất Bình Định vừa đi vào hoạt động giúp kết nối Nhơn Hội đến sân bay quốc tế Phù Cát nhanh chóng, có ý nghĩa chiến lược trong liên kết và giao thương với khu vực Tây Nguyên. Khi việc di chuyển được rút ngắn và trở nên thông thoáng, thuận lợi, việc thu hút khách đầu tư và khách du lịch đến với nơi đây sẽ trở thành điều tất yếu. Nhơn Hội trở thành điểm đầu tư hấp dẫn
Thời điểm trước khi cầu Thị Nại chính thức thông xe, toàn bộ bán đảo Phương Mai thuộc KKT Nhơn Hội vẫn còn là mảnh đất hoang sơ, ít ai nghĩ đến sự chuyển mình và “thay da đổi thịt” trở thành vùng đất đáng sống và đầu tư như hiện nay. Nhơn Hội đang đổi mới từng ngày với hàng loạt dự án thuộc nhiều lĩnh vực như Khu đô thị du lịch sinh thái Nhơn Hội, Nhà máy điện gió Nhơn Hội 1 và Nhơn Hội 2, Nhà máy điện mặt trời QNY, Tổ hợp vui chơi, giải trí Tini Dream, Dự án Viện đào tạo Hàng không Bamboo Airway… được triển khai. Các “ông lớn” bất động sản nhập cuộc và đổ dòng vốn hàng nghìn tỷ vào KKT Nhơn Hội nói chung cũng như bán đảo Phương Mai nói riêng. Tính đến cuối năm 2019, tỉnh Bình Định đã cấp chứng nhận đầu tư cho 15 dự án mới với số vốn lên đến gần 40.000 tỷ đồng. Việc thay đổi chiến lược phát triển Nhơn Hội như một động lực thúc đẩy nơi đây bừng tỉnh và vươn vai, sẵn sàng cho một tương lai dẫn đầu.

 Sự dẫn đầu về du lịch khi các khu nghỉ dưỡng hoàn thành và con đường dẫn đến các địa danh trở nên thuận lợi hơn bao giờ hết. Đó là dẫn đầu về công nghiệp sạch, công nghệ cao, cùng với các dịch vụ về cảng biển khi các dự án liên quan được đưa vào hoạt động. Tất cả thu hút làn sóng đầu tư bất động sản khi tiềm năng của Nhơn Hội, của Quy Nhơn đã được đánh thức và thay đổi diện mạo từng ngày. 

Câu chuyện về bất động sản biển duyên hải miền Trung bên cạnh Đà Nẵng, Khánh Hòa đã được nhắc đến trong suốt thời gian dài, sẽ có thêm KKT Nhơn Hội hay bán đảo Phương Mai. Với tầm nhìn chiến lược dài hạn đến năm 2040, Nhơn Hội chắc chắn sẽ còn được đầu tư để phát triển mạnh mẽ hơn nữa, tỷ lệ thuận với giá trị của bất động sản tọa lạc tại đây.

Nhân dịp ra mắt Khu đô thị phồn hoa bên vịnh biển - Kỳ Co Gateway vào ngày 14/6/2020, Tập đoàn Danh Khôi triển khai chương trình "Giai điệu đương đại" với nhiều ưu đãi như: Cơ hội trúng 03 xe SHi 150, 5 Iphone 11 Pro Max cùng 10 voucher trị giá 10 triệu đồng dành tặng cho khách hàng tham gia và sở hữu sản phẩm của dự án.', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (41, N'Điểm sáng đầu tư nghỉ dưỡng hậu Covid-19
', CAST(N'2020-06-10T00:00:00.0000000' AS DateTime2), 9, N'Hậu Covid-19, bất động sản nghỉ dưỡng đang từng bước phục hồi với sự gia tăng mạnh mẽ của dòng khách nội địa. Vân Đồn, Phú Quốc được giới chuyên gia nhận định sẽ là điểm sáng của thị trường nghỉ dưỡng sau dịch.
Tại tọa đàm “Tiềm năng bất động sản nghỉ dưỡng ở khu kinh tế đặc biệt trong tương lai hậu Covid-19” do Tạp chí điện tử Bất động sản Việt Nam và Viện Nghiên cứu Bất động sản Việt Nam tổ chức, các chuyên gia cùng chung nhận định Vân Đồn, Phú Quốc sẽ là điểm sáng của thị trường nghỉ dưỡng sau dịch.

Ông Nguyễn Mạnh Hà, Phó Chủ tịch Hiệp hội Bất động sản Việt Nam cho biết Covid-19 là cú sốc đối với thị trường bất động sản nói chung và phân khúc bất động sản nghỉ dưỡng nói riêng khiến thị trường đóng băng trong ngắn hạn. Tuy nhiên, việc kiểm soát được dịch bệnh khiến Việt Nam trở thành điểm sáng trong phòng chống dịch bệnh và điểm đến an toàn trong mắt bạn bè thế giới.

Sau khi dịch Covid-19 cơ bản được kiểm soát, chính phủ đã tung ra một loạt chính sách kích cầu du lịch nội địa với sự tham gia mạnh mẽ của 15 địa phương là các địa bàn trọng điểm phát triển du lịch  – đây là nền tảng quan trọng cho sự hồi phục của bất động sản nghỉ dưỡng.

Theo ông Hà, những năm qua, bên cạnh những thị trường truyền thống đã phát triển mạnh mẽ như Đà Nẵng, Nha Trang, Quảng Ninh… thì 2 điểm đến mới là Vân Đồn và Phú Quốc cũng dậy sóng và trở thành điểm dừng chân của các nhà đầu tư. Các yếu tố "mới", "lạ" và tiếp thu kinh nghiệm từ các điểm du lịch truyền thống trước đó tạo ra ưu thế kép cho vùng đất mới. Với quy hoạch đồng bộ, tầm nhìn dài hạn, Vân Đồn và Phú Quốc đang hấp lực mạnh mẽ dòng vốn đầu tư trong và ngoài nước do lợi thế về vị trí địa lý, cơ sở hạ tầng, các chính sách ưu đãi, cuộc đổ bộ của các ông lớn… Trong tương lai gần, bất động sản nghỉ dưỡng Vân Đồn và Phú Quốc sẽ bứt phá mạnh mẽ. Đây sẽ là những vùng đất chứng kiến xu hướng phát triển nghỉ dưỡng mới và làn sóng đầu tư mạnh mẽ giai đoạn hậu Covid-19. Ông Hà nhấn mạnh, với lợi thế đi sau, Phú Quốc và Vân Đồn cần tiến hành đồng bộ các giải pháp, đặc biệt, đó là sự kiên định trong lựa chọn sản phẩm để phát triển. Có như thế, cấp độ nghỉ dưỡng quy mô lớn mới có thể hình thành ở hai vùng đất này.

Đồng quan điểm, PGS. TSKH Võ Đại Lược cho rằng trong phát triển kinh tế Việt Nam nên ưu tiên phát triển các ngành dịch vụ cao cấp có lợi thế, cụ thể là khai thác dịch vụ du lịch tại những khu vực trọng điểm, giàu tiềm năng như Vân Đồn (Quảng Ninh) hay Phú Quốc (Kiên Giang)… Cả hai khu kinh tế này đều sở hữu những lợi thế lớn về cảnh quan thiên nhiên, cơ sở hạ tầng và khả năng tăng giá cao nếu khai thác tốt luồng khách quốc tế - nhóm khách hàng luôn lưu trú dài ngày và khả năng chi tiêu cao. PGS. TSKH. Võ Đại Lược đề xuất 5 giải pháp để khai thác tiềm năng tại 2 khu kinh tế này.

Thứ nhất, Vân Đồn và Phú Quốc cần có quy hoạch bài bản. Từ thực tiễn phát triển của nhiều quốc gia trên thế giới, ông Lược cho rằng 2 khu kinh tế quan trọng cần thuê các tổ chức quy hoạch hàng đầu thế giới thực hiện. Việc thuê các tổ chức quy hoạch hàng đầu còn có ý nghĩa thu hút làn sóng đầu tư của các tập đoàn lớn.

Thứ hai, Vân Đồn và Phú Quốc cần mở cửa hơn nữa để thu hút làn sóng đầu tư của các tập đoàn xuyên quốc gia hàng đầu thế giới. Chính những tập đoàn này sẽ góp phần tạo nên diện mạo mới trong phát triển của vùng.

Thứ ba, phát triển bất động sản nghỉ dưỡng tại Vân Đồn và Phú Quốc cần đa dạng trải nghiệm khách hàng, không đơn thuần và bó hẹp với tắm biển, tham quan… Cần hình thành các tổ hợp du lịch đa công năng, đa tiện ích có sự kết hợp các loại hình như thể thao, triển lãm, hội họp, an dưỡng, mua sắm… Sự đa dạng của các ngành dịch vụ mới sẽ tạo nên sức hấp dẫn du khách.

Thứ tư, thực hiện chế độ miễn thị thực rộng rãi cho các khách du lịch đến Vân Đồn và Phú Quốc nhằm thu hút mạnh mẽ làn sóng du lịch, đầu tư đổ về đây.

Thứ năm, tiếp tục nghiên cứu, xây dựng và thực hiện cơ chế quản trị hiện đại… Chỉ những cơ chế phù hợp mới có thể thu hút được nhân tài, các ông lớn trong nhiều lĩnh vực đổ về đây. Khi đó, tiềm năng của Vân Đồn và Phú Quốc mới được khai thác mạnh mẽ.', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (42, N'Sau dịch, nhiều nhà đầu tư tự tin với bất động sản nghỉ dưỡng
', CAST(N'2020-06-10T00:00:00.0000000' AS DateTime2), 9, N'Ngày 6/6 vừa qua, Chủ đầu tư PPC An Thịnh đã tổ chức lễ Giới thiệu Toà tháp căn hộ khách sạn Ethereal trong Tổ hợp Wyndham Soleil Danang, một trong những dự án BĐS nghỉ dưỡng tiêu biểu của thành phố đáng sống nhất Việt Nam, được coi là biểu tượng mới của Đà Nẵng.
Tri ân các khách hàng là chủ sở hữu của các căn hộ thuộc Toà tháp Nimbus trong Tổ hợp Wyndham Soleil Danang, buổi lễ có sự hiện diện của đông đảo khách hàng và 8 Đại lý phân phối: VHG Land, Iland, Resvico, AVLand Việt Nam, Đất Xanh Emeral, Cenland, An Vượng, Khải Minh Land.

Buổi tiệc được diễn ra trong không khí ấm áp, trang trọng và lan toả thông điệp: Wyndham Soleil Danang - Mái ấm trường tồn, biến hung thành cát và Đầu tư hôm nay, sinh lời hôm nay. Có mặt tại buổi lễ giới thiệu căn hộ khách sạn của Toà tháp Ethereal, bà Nguyễn Thị Phương, khách hàng đã đặt chỗ 2 căn hộ có view trọn vẹn biển Mỹ Khê cho biết: Tôi nhắm đến căn hộ ở đây đã lâu, vì nó quá đẹp và tinh tế, nhưng không thấy CĐT chào bán. Tôi đã nghĩ họ xây dựng khách sạn để Wyndham cho thuê phòng thôi, không ngờ CĐT PPC An Thịnh sử dụng nguồn tài chính tự có để xây dựng xong mới đưa ra thị trường. Tôi hoàn toàn hài lòng khi lựa chọn căn hộ bởi vị trí vàng của nó, với chất lượng và nội thất cho đến giờ tôi được tận mắt nhìn ngắm thì xứng đáng với đẳng cấp 5 sao. Là dân đầu tư BĐS, tôi đã mua một sản phẩm với giá cực tốt trong thời điểm hiện tại, khi mà chỉ phải chi trả khoảng 70% số tiền trên tổng giá trị căn hộ, 30% còn lại, Wyndham và các đơn vị du lịch, lữ hành đã trả thay cho tôi. Như vậy, tiền của tôi sinh lời ngay sau khi tôi đặt bút xác nhận hợp đồng.

Hiện Việt Nam lọt “Top 10” nơi làm việc tốt nhất cho chuyên gia nước ngoài. Những nỗ lực và cách thức Việt Nam chống dịch vừa qua đã “ghi điểm” rất lớn trong mắt cộng đồng quốc tế, tiếp tục là minh chứng cho bình chọn Top 10 nơi làm việc tốt nhất cho chuyên gia nước ngoài hồi cuối năm 2019 của HSBC Expat; và cũng cho thấy Việt Nam là một trong những quốc gia an toàn nhất thế giới. Cùng với các chính sách ngày càng cởi mở hơn cho người Việt Nam định cư ở nước ngoài và người nước ngoài sở hữu bất động sản tại Việt Nam, thị trường bất động sản hứa hẹn sẽ có những bước đột phá trong thời gian tới, khi dịch qua đi. Về kiều hối và xu hướng hồi hương tránh dịch của kiều bào, hiện Việt Nam có khoảng 5 triệu kiều bào và hàng trăm nghìn người Việt Nam đang định cư và lao động trên thế giới. Tổ chức Y tế thế giới (WHO) kêu gọi các nước tham khảo cách Việt Nam phòng chống dịch cũng cho thấy Việt Nam đã được cộng đồng quốc tế ghi nhận. Nếu Việt Nam tiếp tục kiểm soát dịch tốt như hiện nay và vượt qua dịch bệnh thì sẽ thu hút kiều bào về nước đầu tư và người nước ngoài đến sinh sống, làm việc.

Trước làn sóng đầu tư BĐS mới tại các thành phố du lịch lớn trong cả nước, TP. Đà Nẵng là một trong những nơi đi đầu. Theo thống kê chưa đầy đủ, ngay sau khi phát động chiến dịch với sự tham gia của hàng chục đơn vụ lữ hành, Travel trong cả nước, lượng khách du lịch nội địa đến Đà Nẵng tăng vọt về số lượng, trở lại mốc cân bằng với cùng kỳ năm 2019.

Đại diện đơn vị phân phối sản phẩm, ông Giáp Văn Kiểm, Tổng Giám đốc Công ty CP AVLand Việt Nam cho biết: Đây là Dự án mà chúng tôi nhận thấy có sự tâm huyết thực sự từ Chủ đầu tư. Chủ tịch Tập đoàn PPC An Thịnh, ông Nguyễn Kháng Chiến cùng toàn bộ các cộng sự đã dồn hết Tâm - Trí - Lực để xây dựng nên một Dự án để đời, một biểu tượng mới của BĐS nghỉ dưỡng ven biển Miền Trung. Dự án quy tụ nhiều thương hiệu danh giá về thiết kế, kiến trúc, nội thất, kĩ thuật hàng đầu thế giới và Việt Nam, là Dự án BĐS xác lập các kỷ lục BĐS ven biển cao nhất Việt Nam (50-57 tầng), Dự án có nhiều thang máy nhất (21 thang). Tất cả các khách hàng đến thăm quan dự án đều có cảm xúc rất tốt và có những đánh giá cao về tầm nhìn và sự đầu tư bài bản, hoàn hảo của Chủ đầu tư.

Được trải nghiệm dịch vụ đẳng cấp 5 sao của Wyndham Hotel ngay tại Lễ giới thiệu, được tận mắt ngắm nhìn các căn hộ về đêm với sự tinh tế trong từng chi tiết nội thất, hàng chục khách hàng đã xác nhận sẽ trở thành Chủ nhân mới của các căn hộ tại đây.

Ông Lê Xuân Tùng, chủ sở hữu căn hộ thuộc Tháp Nimbus, Wyndham Soleil Danang có mặt tại Lễ tri ân các khách hàng chia sẻ: Khi tôi kí Hợp đồng mua căn hộ có giá vài tỷ đồng, người thân ngạc nhiên hỏi tại sao với số tiền ấy lại không mua một căn nhà phố. Nhưng tôi nói tôi mua căn hộ này là vì vị trí tuyệt vời của nó với tầm nhìn sở hữu trọn vẹn biển. Đặc biệt, tôi có sự yên tâm đến từ Chủ đầu tư, từ chất lượng công trình được các nhà thầu danh tiếng trên thế giới mang lại. Và hôm nay, đứng tại Dự án, tận mắt nhìn ngắm căn hộ tinh tế trong từng đường nét, tôi và những người thân biết mình đã đặt niềm tin đúng chỗ.

', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (43, N'Thị trường bất động sản Long An đón dòng vốn đầu tư mới
', CAST(N'2020-06-10T00:00:00.0000000' AS DateTime2), 9, N'Ngay sau đợt giãn cách xã hội bởi Covid-19, thị trường bất động sản Long An bất ngờ trở nên nhộn nhịp khi đón nhận dòng vốn mới từ các nhà đầu tư.
 Giao dịch tăng mạnh
Ngay sau đợt giãn cách xã hội, thị trường bất động sản Long An đã lập tức trở nên sôi động với một loạt dự án được tung ra thị trường. Có thể kể đến như Vietuc Varea, Hiệp Phước Harbour View, The Pearl Riverside hay West Lakes Golf & Villa… Đặc biệt, sau thành công của đợt 1 với số lượng đặt chỗ gấp 6 lần giỏ hàng mở bán, Nam Long tiếp tục mở bán đợt 2 siêu dự án “thành phố bên sông” Waterpoint cũng thu hút hàng ngàn khách hàng tham quan mỗi cuối tuần. 

Với mặt bằng giá đang thấp hơn nhiều so với Đồng Nai hay Bình Dương, thị trường Long An thu hút không chỉ những người đang có nhu cầu ở mà nhiều nhà đầu tư cũng không muốn chậm chân. 

Giá đất nền tại các khu vực Long An giáp ranh TP.HCM hiện nay bình quân khoảng 10 -12 triệu đồng/m2, một số nơi lên đến 20 triệu/m2, tăng gấp đôi so với cách đây vài năm. Trong khi đó, giá đất Bình Dương và Đồng Nai đang ở mức 15-20 triệu đồng/m2; những khu vực đô thị hóa nhanh, đông dân cư có thể lên đến 30-35 triệu đồng/m2. Điều này cho thấy bất động sản Long An vẫn còn rất nhiều tiềm năng. 

Ngoài khách hàng TP.HCM muốn chuyển ra vùng ven để được hưởng không khí trong lành, Long An còn đang thiếu các dự án nhà ở dành cho người lao động trong các khu công nghiệp, nhất là các dự án nhà ở cao cấp, đầy đủ tiện ích phục vụ các doanh nhân, chuyên gia và quản lý cấp trung. Trong khi đó, tháng 5 vừa qua hai KCN Việt Phát quy mô 1.800 ha và Đức Hòa 3 gần 200 ha đã được khởi công. Tập đoàn Becamex cũng đã công bố lập quy hoạch khu công nghiệp - đô thị diện tích 3.045ha tại huyện Bến Lức. Như vậy, sắp tới lực lượng lao động dồn về Long An chắc chắn sẽ tăng mạnh, càng gây áp lực lớn lên nguồn cung nhà ở.

 Hạ tầng mở lối bất động sản
Hiện nay, Long An đang hoàn thành việc nâng cấp các tuyến quốc lộ 1A, 50, 62, N2. Các tuyến cao tốc TP.HCM – Trung Lương, Bến Lức – Long Thành giúp Long An kết nối trực tiếp với hệ thống cảng Hiệp Phước, Cát Lái, Cái Mép – Thị Vải và sân bay quốc tế Long Thành... cũng đang hứa hẹn nhiều triển vọng.

Mới đây, TP.HCM đã làm việc với các tỉnh, thành điều chỉnh lại hướng tuyến xây dựng tuyến đường sắt đi qua địa bàn TP.HCM, Long An, Tiền Giang, Vĩnh Long, Cần Thơ có tổng vốn đầu tư đến 5 tỷ USD. Tuyến đường Vành đai 4 đoạn Bến Lức - Hiệp Phước, metro 3A Bến Thành - Tân Kiên cũng đang rục rịch khởi động.

Các dự án hạ tầng nói trên không chỉ xây dựng hệ thống giao thông hiện đại cho vùng đô thị TP.HCM mà còn mở lối hình thành các đô thị vệ tinh tại Long An. Đơn cử như tại Waterpoint của chủ đầu tư Nam Long, dự án được ví như “thành phố bên sông” 355ha nằm ngay mặt tiền đường ĐT 830 và ba mặt còn lại bao quanh bởi sông Vàm Cỏ Đông. Nằm cách trung tâm TP.HCM chỉ khoảng 40 phút di chuyển, Waterpoint gây ấn tượng với tổng diện tích mảng xanh & mặt nước lên đến 95ha, bao gồm sáu hệ thống công viên, 5,8km bờ sông, 8,6ha vịnh nước ngọt kết hợp bến du thuyền, 8km kênh đào len lỏi đến từng góc phố tạo ra môi trường sống thanh khiết, tươi mát. 

Hệ thống tiện ích đẳng cấp của Waterpoint vô cùng phong phú, bao gồm 25ha công trình giáo dục liên cấp từ mầm non đến đại học chuẩn quốc tế; 3ha công trình y tế; 3ha Country Club với sân tennis, sân bóng đá, phòng tập gym, phòng hội thảo; 8ha tiện ích thể dục thể thao ngoài trời, đường chạy bộ, đường đạp xe, sân chơi vận động; 1,5ha nhà thờ, chùa; hệ thống dịch vụ bus 1,3ha, và hơn 20ha dành cho các tiện ích thương mại – giải trí, clubhouse câu lạc bộ ven sông, trung tâm nghiên cứu, trung tâm dịch vụ, nhà văn hóa, nhà cộng đồng, văn phòng làm việc…

Sự tham gia của các đối tác quốc tế như Nishi-Nippon Railroad, Lascal (Nhật); Conybeare Morrison – CM+, Royal Haskoning DHV (Úc); Aurecon (Hà Lan); Swan & Maclaren (Singapore)… đảm bảo cho dự án sẽ về đích đúng hẹn. Hiện nay những công trình đầu tiên của giai đoạn 1 đã đưa vào vận hành như làng nhà mẫu Show Village, văn phòng bán hàng Sales Gallery. Các sản phẩm Valora biệt thự đơn lập, biệt thự song lập, nhà phố vườn, nhà phố thương mại đã bán thuộc phân khu Rivera và Aquaria dự kiến bàn giao từ quý 3/2020. 

Ngoài ra, một loạt mục phục vụ vui chơi giải trí cho cộng đồng cũng đang được chủ đầu tư triển khai nhanh chóng. Cùng với việc được đầu tư bài bản và pháp lý hoàn thiện, Waterpoint đang là một điểm sáng về phát triển đô thị vệ tinh với rất nhiều kỳ vọng về một thành phố bên sông hiện đại gắn với thiên nhiên được nhiều khách hàng chờ đợi.

', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (44, N'The River – Điểm sáng mới của phân khúc căn hộ hạng sang tại Thủ Thiêm
', CAST(N'2020-06-09T00:00:00.0000000' AS DateTime2), 10, N'6 tháng đầu năm 2020, bên cạnh các dự báo tích cực về sự phát triển kinh tế, những chuyển biến tích cực về hạ tầng đã đưa Thủ Thiêm trở thành điểm đến hấp dẫn của người mua để ở lẫn đầu tư.
Thủ Thiêm đang chuyển mình mạnh mẽ 
Dự đoán tăng trưởng GDP từ 4,4 - 5,2% trong năm 2020 từ Bộ Kế hoạch & đầu tư; sự chuyển dịch sản xuất sang Việt Nam của nhiều thương hiệu lớn như Panasonic, Apple, Nintendo, … đã tạo nên những lực đẩy tích cực, giúp thị trường bất động sản ấm hơn sau thời gian gần 2 tháng tạm lắng vì dịch Covid-19, đặc biệt là tại các khu vực được quy hoạch trọng điểm như Thủ Thiêm, TP.HCM. 

Không dừng ở đó, việc một loạt các công trình khu dân cư, và hạ tầng đang được đẩy nhanh hoàn thiện tại khu vực này như cầu đi bộ nối từ khu đô thị mới Thủ Thiêm sang trung tâm Quận 1 đã được phê duyệt phương án thiết kế; Cầu Thủ Thiêm 2 dự kiến hoàn thành cuối năm 2020…. cũng đã góp phần đưa Thủ Thiêm trở thành điểm đến đáng giá trên thị trường bất động sản. Theo JLL, giá trị bất động sản tại Thủ Thiêm đã gia tăng đáng kể gấp nhiều lần trong hơn 10 năm trở lại đây. Con số này được dự đoán sẽ tiếp tục tăng mạnh trong vòng 10 – 15 năm tới, đặc biệt sau khi các dự án về cơ sở hạ tầng được hoàn thiện.

“Ngoài sự tin tưởng vào tốc độ phát triển bất động sản; sự kỳ vọng vào không gian sống xanh với 43% diện tích dành cho mảng xanh trên toàn khu vực, thì đa phần người mua nhà tại Thủ Thiêm cũng đặc biệt yêu thích các thiết kế đẳng cấp và tiện ích sang trọng tại các dự án đang mở bán", ông Hồ Quang Kiệt – Giám đốc Kinh doanh dự án The River Thu Thiem – một dự án đang nhận được sự quan tâm cao từ người mua tại Thủ Thiêm trong thời gian gần đây – cho biết.

Tiếp nối thành công từ City Garden – “Biểu tượng kiến trúc” của khu dân cư hạng sang 
Được phát triển bởi City Garden Thu Thiem, The River Thu Thiem là sự tiếp nối thành công đã đạt được từ City Garden, viết nên câu chuyện về những dự án hạng sang mang đậm dấu ấn riêng tại thành phố. Nếu City Garden là một “khu vườn” xanh mát với 6 tòa tháp hình elip - biểu tượng kiến trúc độc đáo giữa lòng đô thị hiện hữu, thì The River Thu Thiem được kỳ vọng sẽ mang đến chuẩn mực mới, khơi nguồn cảm hứng cho các dự án đẳng cấp bên sông thuộc khu Đô thị mới Thủ Thiêm. Cũng theo ông Kiệt, nhờ vào thiết kế đặc sắc và chất lượng sống vượt trội đã tạo được tại City Garden, The River Thu Thiem đã nhận được sự quan tâm cao từ các khách đã từng giao dịch hoặc biết đến chủ đầu tư dự án này – công ty City Garden Thu Thiem. Được biết, đến nay, hơn 15% khách đang giữ chỗ tại The River Thu Thiem là chủ nhân các căn hộ tại City Garden. 

Kiến tạo chuẩn mực mới cho khu Thủ Thiêm 
The River Thu Thiem tọa lạc tại một trong những mảnh đất ven sông hiếm hoi thuộc Vành Đai 1, Khu đô thị mới Thủ Thiêm. Giữa không gian đô thị nhộn nhịp, việc sở hữu tầm nhìn trực diện cùng dòng sông xanh mát, không khí trong lành trở thành mơ ước của nhiều người. 

Với số lượng giới hạn, The River Thu Thiem chỉ gồm 525 sản phẩm, bao gồm các căn hộ hạng sang, penthouse và biệt thự bể bơi. Ba tòa tháp của The River Thu Thiem được đặt tên theo các con sông chảy qua các thành phố nổi tiếng trên thế giới - Thames (London – Anh), Seine (Paris – Pháp) và Hudson (New York – Hoa Kỳ). Những căn hộ được thiết kế khéo léo xoay trục với ban công hướng tối đa về sông Sài Gòn và công viên ven sông nhằm mang đến cho cư dân tầm nhìn ấn tượng nhất. Với gần 100m mặt tiền sông và 4ha công viên, cư dân có thể thoải mái thư giãn, ung dung và tự tại dạo bộ, tận hưởng làn gió sông trong lành hiếm hoi ngay tại trung tâm thành phố. 

Để xứng tầm một dự án đẳng cấp, The River Thu Thiem được đầu tư hệ thống tiện ích đa dạng, được thiết kế tinh tế và đề cao công năng sử dụng nhằm đáp ứng được kỳ vọng khắt khe của cư dân. Với hồ bơi dài 50m đạt tiêu chuẩn Olympic, sảnh tập yoga, phòng gym hiện đại, cư dân có thể thỏa sức rèn luyện sức khỏe. 

Ngoài ra, khu sinh hoạt cộng đồng, khu tổ chức tiệc BBQ, khu hút cigar biệt lập (cigar lounge) và các sân chơi cho trẻ em, đều được The River Thu Thiem đầu tư kỹ lưỡng với đội ngũ những nhà phát triển dự án quốc tế chuyên nghiệp, danh tiếng đến từ Singapore, Mỹ... Một điểm nhấn về hệ thống tiện ích đạt chuẩn cao cấp nổi bật của The River Thu Thiem là số lượng thang máy cao, lên đến 8 thang máy cho mỗi tháp (dành cho 9 đến 16 căn hộ trên một tầng), trong đó các căn hộ 3 và 4 phòng ngủ sẽ có sảnh thang máy biệt lập. 

The River Thu Thiem được khởi công vào tháng 8/2019, đã hoàn tất phần cọc móng vào tháng 11/2019, dự kiến hoàn thành toàn bộ phần đế móng vào cuối tháng 3/2020. Dự án được dự kiến mở bán vào quý 2/2020 và bàn giao vào cuối năm 2021. ', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (45, N'Apec Điềm Thụy Center Point - Hệ sinh thái dịch vụ toàn diện cho KCN
', CAST(N'2020-06-09T00:00:00.0000000' AS DateTime2), 10, N'Apec Điềm Thụy Center Point là khu dịch vụ thuộc dự án khu công nghiệp (KCN) Apec Điềm Thụy – Thái Nguyên. Dự án đầu tư 231 shop thương mại, hạ tầng, tiện ích đồng bộ phục vụ cho KCN Apec Điềm Thụy và các KCN kế cận.
Sau Nghị định 82/2018/NĐ-CP quy định về quản lý KCN và khu kinh tế, việc quy hoạch KCN - đô thị - dịch vụ là mô hình mới đang được nhà đầu tư quan tâm. Mô hình KCN - đô thị - dịch vụ là mô hình kết hợp giữa phát triển công nghiệp với đô thị hóa, đảm bảo sự phát triển bền vững của KCN. Cụ thể, khi quy hoạch khu công nghiệp phải gắn liền với phát triển khu dân cư và các công trình xã hội, tạo được sự đồng bộ về cơ sở hạ tầng. Vì vậy, vấn đề thiết yếu được quan tâm là việc phát triển bền vững KCN phải đi đôi với phát triển khu dân cư và các tiện ích xã hội đi kèm. Riêng tại Thái Nguyên, tỉnh đứng thứ 10 cả nước về thu hút FDI với 8,331 tỷ đô vốn đầu tư cũng đang là nơi làm việc của 81.000 công nhân tại 4 khu công nghiệp và các cụm công nghiệp nhưng vẫn chưa thể giải quyết bài toán về dịch vụ, tiện ích, môi trường sống cho chuyên gia và người lao động đang làm việc tại các nhà máy. 

Để cải thiện và nâng cao đời sống văn hóa, tinh thần cho công nhân trong các KCN, đồng thời góp phần xây dựng các doanh nghiệp phát triển ổn định buộc doanh nghiệp đầu tư vào các KCN phải xây dựng các khu dịch vụ. KCN Apec Điềm Thụy – Thái Nguyên đang là một trong những dự án tiên phong đầu tư xây dựng khu dịch vụ KCN nhằm nâng cao đời sống chất lượng cho kỹ sư, công nhân làm việc tại KCN Apec Điềm Thụy và các KCN kế cận. Apec Điềm Thụy Center Point khu dịch vụ thuộc dự án khu công nghiệp Apec Điềm Thụy – Thái Nguyên. Dự án nằm trên đường cao tốc Hà Nội - Thái Nguyên, kế cận đường sắt Hà Nội - Quán Triều, Lưu Xá, Kép, Đông Triều nối với khu Gang Thép Thái Nguyên, gần đường sắt, đường hàng không,… Bên cạnh đó, dự án KCN Apec Điềm Thụy kế cận các KCN Điềm Thụy A, KCN Sông Công 1, Sông Công 2, nhà máy Samsung…

Với định hướng phát triển khu công nghiệp bền vững theo chiều sâu, đạt hiệu quả cao về kinh tế và thân thiện với nhà đầu tư, toàn khu công nghiệp Apec Điềm Thụy có diện tích đất quy hoạch 170 ha, trong đó các phân khu chức năng được phân chia như: diện tích nhà máy; trung tâm điều hành; đất dịch vụ phục vụ KCN; diện tích cây xanh, diện tích mặt nước; diện tích giao thông, bến bãi v.v… Trong đó, khu dịch vụ Apec Điềm Thụy Center Point có diện tích 28.915 m2 với 231 kiot được xây dựng từ 2-3 tầng với mục đích kinh doanh siêu thị mini, tạp hóa, nhà trẻ, trường mầm non tư thục, nhà hàng ẩm thực, ăn uống, thời trang, phòng khám, thuốc tân dược, văn phòng phẩm, vật tư tiêu hao, phòng tập thể thao, fitness, chợ đêm cuối tuần, dịch vụ làm tóc… và các dịch vụ vui chơi giải trí khác. Cùng với đó, khu dịch vụ còn được đầu tư diện tích lớn xây dựng đường dạo, cây xanh, thể thao ngoài trời…

Dự án được đầu tư đồng bộ về hạ tầng kỹ thuật, hạ tầng xã hội, quy hoạch kiến trúc hiện đại, cảnh quan đẹp, hệ sinh thái thân thiện với môi trường. Apec Điềm Thụy Center Point nói riêng, khu công nghiệp Apec Điềm Thụy nói chung hình thành một hệ sinh thái bền vững, đáp ứng nhu cầu nhà ở và môi trường sống tiện ích cho chuyên gia, kỹ sư, công nhân, cư dân làm việc tại khu công nghiệp Apec Điềm Thụy và các khu công nghiệp kế cận, đồng thời mở ra cơ hội kinh doanh ấn tượng, đầu tư sinh lời bền vững.

Nhu cầu nhà ở, khu vui chơi giải trí cho chuyên gia và người lao động tại các KCN, cụm KCN là rất lớn, không chỉ các nhu cầu tiêu dùng tất yêu, nhu cầu giải trí cũng là vấn đề đáng lưu tâm. Đây không chỉ là cơ hội tốt cho nhà đầu tư BĐS cung ứng các dịch vụ lưu trú và giải trí, góp phần phát triển kinh tế xã hội và tạo ra dòng lợi nhuận kép đầu tư mà còn là cơ hội kiếm tiền của các nhà đầu tư bất động sản thức thời.', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (46, N'Nhiều chủ hộ rao bán nhà phố mặt tiền đường
', CAST(N'2020-06-08T00:00:00.0000000' AS DateTime2), 9, N'Làn sóng rao bán nhà mặt phố tăng cao sau dịch Covid-19 khiến giá nhà mặt phố, nhà lẻ tại nội thành Sài Gòn có xu hướng giảm nhẹ trong các tháng cuối quý 2/2020.
Không cho thuê được căn nhà phố 3 tầng nằm trên mặt tiền đường Điện Biên Phủ, quận 3 dù treo biển gần 3 tháng nay, chị Bích Ngọc, chủ căn nhà quyết định rao bán đứt để xoay sở tiền trong điều kiện khó khăn. Chị Ngọc cho biết đây là quyết định cực chẳng đã vì căn nhà là tài sản để dành do cha mẹ cho vợ chồng chị lúc ra riêng lại có giá trị kinh tế lớn. Từ đầu năm đến nay khi tình hình dịch bệnh bùng phát, việc xuất nhập khẩu với Trung Quốc gặp khó khăn khiến chuyện làm ăn của gia đình ngày càng bế tắc. Cầm cự gần 4 tháng chị Nguyệt buộc phải chấp nhận bán rẻ căn nhà với giá thấp hơn gần 15% so với giá được chào mua ngoài thị trường đợt cao điểm 2019. 

Ở nội thành TP.HCM, rất hiếm có nhà mặt tiền đường lớn nào được rao bán, chủ nhà chỉ chấp nhận cho thuê dài hạn. Ở các tuyến đường thương mại thuộc trung tâm như Điện Biên Phủ, Nguyễn Đình Chiểu, Nguyễn Thị Minh Khai, Nguyễn Bỉnh Khiêm, 3/2, Nguyễn Tri Phương… nhà mặt tiền là sản phẩm có tiền cũng khó mua được. Các hộ kinh doanh tranh nhau thuê vì vị thế giao dịch tốt nên chủ nhà không mấy ai có ý định bán. Tuy nhiên hiện nay, không khó bắt gặp những tờ rơi rao bán nhà dán trước cửa, các băng rôn cho thuê hoặc bán nguyên căn treo đầy trên các căn nhà dọc theo tuyến đường này. 

 Anh Đỗ Mạnh Hùng, một môi giới nhà phố tại quận 3 cho biết: “Cách đây 1 năm có đơn vị nước ngoài muốn mua đứt 1 căn nhà mặt tiền đường 3/2, quận 10 để kinh doanh thương hiệu điện tử nhưng chẳng tìm thấy ai chấp nhận bán. Nhiều nhất là chấp nhận ký HĐ dài hạn trong vòng 20 năm. Vậy mà chỉ sau một mùa dịch, nhà phố tại TP.HCM rao bán rầm rộ. Từ nhà trong hẻm, nhà đường phụ cho đến các tuyến đường chính, trung tâm của Sài Gòn cũng rao bán ngày một nhiều hơn”. Khó khăn kinh tế bủa vây khiến không ít chủ nhà buộc phải chấp nhận bán nhà vì không còn lựa chọn nào khác.

Để cứu cánh cho hoạt động kinh doanh đang ngày càng khó khăn của gia đình, anh Toàn đành cắn răng sang nhượng lại căn nhà mặt tiền đường Ngô Thời Nhiệm, quận 3. Khoản thu từ việc cho thuê chỉ giúp gia đình trang trải được lãi suất ngân hàng hiện tại, tuy nhiên để vừa chu cấp cho con trai đang du học ở Mỹ lại phải duy trì hoạt động của công ty trong tình trạng đối tác quốc tế ngưng giao dịch khiến anh phải bán bớt những BĐS có giá trị để duy trì. “Tôi muốn bán căn nhà phố tại quận 2 nhưng chưa có người mua nên đành chấp nhận bán căn nhà phố tại quận 3 vì dễ tìm khách hơn. Tuy nhiên vì bán gấp nên giá cũng thấp hơn so với mức có thể bán vào dịp cuối năm”, anh Toàn cho biết.

Làn sóng rao bán nhà mặt phố đang lan rộng trên địa bàn TP.HCM. Nếu trước đây, giao dịch nhà chủ yếu diễn ra trên các tuyến đường phụ, hẻm thông ra đường chính, các chủ nhà sở hữu căn nhà mặt tiền sẽ không rao bán lại dù là đi xuất ngoại thì nay nhiều môi giới cho biết, nhà mặt phố được rao bán rất nhiều. Tuy nhiên nhu cầu mua lại không cao.  “Nhà phố luôn là sản phẩm có giá trị lớn, nhà phố mặt tiền đường trung tâm giá lại càng cao gấp 2-3 lần các sản phẩm khác. Vì vậy người mua phần nhiều là giới tài chính dư giả, các doanh nghiệp cần tìm mặt bằng kinh doanh dài hạn, các thương hiệu quốc tế lớn hay dân đầu tư cá mập. Tình trạng kinh tế khó khăn đang khiến không ít ông lớn thấm đòn, nhu cầu giao dịch nhà phố vì vậy cũng bị ảnh hưởng lớn. Sức mua giảm mạnh nên dù rất nhiều sản phẩm tốt chào bán nhưng nhu cầu mua không cao. Hầu hết đều phải chấp nhận thực tế giá bán không thể cao như thời điểm 2019”, anh Nguyễn Vĩnh Phát, lãnh đạo một công ty môi giới nhà phố nội thành chia sẻ. Anh Phát cho biết thêm, dù khó bán nhưng chủ nhà cũng không chịu giảm giá mạnh. 

Theo dữ liệu big data của Batdongsan.com.vn, tính riêng trong quý 1 và các tháng đầu quý 2/2020, nhu cầu giao dịch nhà phố, nhà lẻ tại TP.HCM liên tục giảm mạnh. Trong 3 tháng đầu năm, mức độ quan tâm nhà phố giảm 33% so với quý trước, giá chào thuê cũng giảm gần 11% trong khi giá bán có xu hướng đi ngang, thậm chí giảm từ 2-3% tại một số quận trung tâm như quận 1, quận 3, quận 7, quận 10. Đặc biệt, loại hình nhà phố mặt tiền đường có mức độ quan tâm giảm mạnh hơn so với các căn nhà riêng lẻ nằm trong các tuyến đường nhỏ, đưởng hẻm. Trong 2 tháng đầu của quý 2, giá bán nhà lẻ, nhà phố chưa có dấu hiệu cải thiện. Nếu so với giá bán cao điểm giữa năm 2019, giá nhà mặt phố tiếp tục hạ nhiệt trung bình đến 2%. Trong khi nhà riêng, nhà hẻm có giá bán đi ngang thì các tuyến đường chính lại chào bán giá thấp hơn từ 3-5% so với cùng kỳ. 

Tình trạng khó khăn được dự báo sẽ kéo dài đến hết năm 2020 khi áp lực tài chính vào giai đoạn này sẽ gay gắt hơn do các khoản quyết toán với ngân hàng. Hoạt động kinh doanh ảm đạm khiến việc cho thuê mặt bằng khó khăn, làn sóng rao bán nhà phố sẽ còn tiếp diễn trong thời gian tới.', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (47, N'Nhà Bè tăng tốc đô thị hóa, bất động sản khu Nam hưởng lợi
', CAST(N'2020-06-08T00:00:00.0000000' AS DateTime2), 9, N'Với lộ trình lên quận trong tương lai gần cùng hạ tầng phát triển mạnh mẽ đưa Nhà Bè trở thành nơi phát triển BĐS năng động của TP.HCM, liên tục đón mặt bằng giá mới.
“Giờ G” đã điểm
Trao đổi với phóng viên vào năm 2017, ông Nguyễn Văn Lưu, Bí thư kiêm Chủ tịch UBND huyện Nhà Bè từng chia sẻ: Khó khăn lớn nhất của Nhà Bè là kết cấu giao thông chưa hoàn chỉnh, từ đường giao thông nối các huyện bạn đến đường giao thông liên xã. Các trục Đông Tây, Nam Bắc đều thiếu đường giao thông chính, thiếu cầu bắc qua sông và kênh rạch. Mặt khác, tính chất nông thôn ở Nhà Bè còn chiếm tới 2/3, nghĩa là chỉ mới đô thị hoá được 1/3, do đó Nhà bè có thể đi sau Bình Chánh và Hóc Môn trong việc nâng cấp từ huyện lên quận.

Tuy nhiên, mới đây vào tháng 5/2020, ông Hoàng Tùng, Chủ tịch UBND huyện Nhà Bè đã cho biết, cả huyện Nhà Bè chỉ còn 200 hộ dân làm nông nghiệp, với số hộ dân làm nông nghiệp ít ỏi như vậy, huyện Nhà Bè sẽ có nhiều triển vọng lên quận hơn những huyện khác. Vì vậy, nếu huyện xây dựng kế hoạch rõ ràng hơn thì cuối năm 2025 sẽ trở thành một quận của thành phố. Điều này là minh chứng về tốc độ đô thị hóa đáng kinh ngạc của Nhà Bè trong thời gian chưa đến 3 năm. Đồng thời, các chương trình tập trung đầu tư kết nối, đồng bộ hệ thống hạ tầng kỹ thuật đang được quan tâm đặc biệt. Khu Nam đã hoạt động liên tục như đại công trường mang dòng vốn đầu tư lên đến hàng ngàn tỷ đồng. Mới đây, nút giao thông Nguyễn Văn Linh - Nguyễn Hữu Thọ, vốn đầu tư hơn 830 tỷ đồng vừa được khởi công giai đoạn 1 vào cuối tháng 4, công trình sẽ thúc đẩy việc kết nối toàn thành phố một cách nhanh chóng thông qua sự kết hợp giữa các trục Bắc - Nam và Đông - Tây. 

Bên cạnh đó, TP.HCM cũng không ngừng mở rộng các tuyến đường hiện hữu của khu Nam nhằm đẩy nhanh tốc độ hình thành hành lang kinh tế Nam Sài Gòn. Cụ thể như phê duyệt chủ trương mở rộng đường Nguyễn Hữu Thọ từ 4 lên 6 - 8 làn xe, xây dựng cầu số 1, cầu số 2, cầu Phước Kiểng, cầu Bà Chiêm. Trục đường Lê Văn Lương cũng sẽ được mở rộng thêm 15m và khởi công xây dựng cầu Rạch Đỉa, cầu Long Kiểng, cầu Rạch Dơi, cầu Rạch Tôm. Tuyến Nguyễn Văn Tạo quy hoạch lộ giới 60m, chiều rộng thực tế 16m đã được thành phố giao Ban quản lý khu Nam, UBND huyện Nhà Bè xây dựng kế hoạch mở rộng,… 

Theo đó, hàng loạt đô thị có quy mô lớn liên tục được hình thành. Trong đó, trục đường Nguyễn Hữu Thọ được mệnh danh là 1 trong những trục đường tỷ đô tập trung nhiều khu đô thị, siêu dự án hàng đầu thành phố, diện mạo của Nhà Bè sẽ không thua kém bất kỳ quận huyện nào.

Mạnh tay “săn” đất
Song hành cùng việc Nhà Bè hoàn tất điều kiện cần và đủ để lên quận là những biến động rõ nét của giá nhà đất trong khu vực. Tuy nhiên, đặc điểm đất của khu vực này chủ yếu là nông nghiệp diện tích lớn (từ 1.000 - 5.000m2), rất hiếm đất nền dự án. Đơn cử, năm 2014, giá đất nông nghiệp tại huyện Nhà Bè chỉ 1 - 2 triệu đồng/m2, đất thổ cư ở mức trên dưới 10 triệu đồng/m2. Sau khi khởi công tuyến cao tốc Bến Lức - Long Thành, mức giá đã tăng đáng kể. 

Từ đây, làn sóng “săn” đất nông nghiệp cũng diễn ra mạnh mẽ, khu vực xung quanh tuyến đường Nguyễn Văn Tạo, giá đất vườn từ 4 triệu đồng/m2, nay đã tăng lên mức 7 - 8 triệu đồng/m2. Bên cạnh đó, tuyến đường Lê Văn Lương thuộc xã Nhơn Đức, giá bán loại hình đất thổ vườn đạt mức 9 - 10 triệu đồng/m2. Mặc dù mức giá của loại hình đất nông nghiệp, đất vườn hiện đã tăng lên khá cao nhưng hiện nay, nhiều nhà đầu tư vẫn âm thầm “săn lùng”. 

Tuy nhiên, loại hình BĐS đặc thù này vẫn là ẩn số, bởi thủ tục pháp lý chuyển đổi từ đất nông nghiệp thành đất thổ cư thật sự không dễ dàng. Thực tế, nhiều nhà đầu tư đã phải “ngậm trái đắng” khi BĐS nông nghiệp không thể chuyển đổi mục đích sử dụng hoặc tài chính cá nhân không đủ để giữ đất đến giai đoạn tăng giá kỳ vọng.

Các chuyên gia đã phân tích rằng, để đảm bảo an toàn cho suất đầu tư, người mua đất nông nghiệp cần tìm hiểu trước về quy hoạch, chứng nhận quyền sử dụng đất và chi phí chuyển đổi mục đích sử dụng đất nhằm tránh những trục trặc hoặc thua lỗ không đáng có.

Riêng với loại hình đất thổ cư, giá đất ở một số dự án nằm trên đường Nguyễn Hữu Thọ được niêm yết khá cao. Đất nền mặt tiền đường Nguyễn Văn Tạo đang được nhiều chủ đất rao bán với giá 30 triệu đồng/m2. Sức nóng nhanh chóng lan tỏa đến các khu đô thị lân cận như Hiệp Phước, Cần Giuộc,… Trong đó, Cần Giuộc dẫn đầu về biên độ tăng giá và tiềm năng phát triển BĐS của khu vực. Điển hình, loại hình đất nền đã điều chỉnh mặt bằng giá tăng lên gấp đôi trong vòng 3 năm, từ vùng giá 8 - 9 triệu/m2 vào năm 2016, lên đến 18 - 25 triệu/m2 cuối năm 2019. Hiện nay, sản phẩm đất nền dự án tại Cần Giuộc, vị trí tiếp giáp Nhà Bè đang được nhiều nhà đầu tư lựa chọn, với mức giá từ 1,4 - 1,6 tỷ đồng, pháp lý đầy đủ và được bảo chứng bởi uy tín của đơn vị phát triển nhiều kinh nghiệm,… Đơn cử, dự án Hiep Phuoc Harbour View, tọa lạc mặt tiền đường Nguyễn Văn Tạo, giáp 2km bờ sông Soài Rạp có giá từ 1,45 tỷ đồng, được hỗ trợ thanh toán trong vòng 24 tháng, 15% giá trị đợt đầu. Với lợi thế cách Nhà Bè chỉ 1 cây cầu đã tạo ra sự kết nối thông suốt từ dự án đến đại đô thị Nam Sài Gòn. Theo khảo sát, hiện tỷ suất đầu tư sinh lợi của các sản phẩm BĐS tại Cần Giuộc trung bình từ 30 - 35%/năm.', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (48, N'Chiêm ngưỡng quảng trường nhạc nước đầu tiên tại Long An
', CAST(N'2020-06-07T00:00:00.0000000' AS DateTime2), 9, N'Light Square - quảng trường nhạc nước đầu tiên tại Long An đang thu hút nhiều sự quan tâm khi trở thành khu văn hóa giải trí hiện đại bậc nhất, tạo nên nét đẹp văn minh cho “Khu đô thị vệ tinh TP.HCM”.
Người dân và du khách đến Long An sẽ lần đầu tiên được chiêm ngưỡng những “bức tranh nước” tuyệt hảo, biến hóa sống động theo âm nhạc, ánh sáng. Với vẻ đẹp nghệ thuật tinh tế cùng công nghệ hiện đại, quảng trường nhạc nước Light Square mang đến những “bữa tiệc” của nước, ánh sáng và âm nhạc với những màn trình diễn lộng lẫy, tráng lệ. Phong cách hiện đại của toàn bộ công viên góp phần nâng tầm chất lượng cuộc sống của người dân.

Quảng trường nhạc nước tiêu chuẩn quốc tế
Quảng trường nhạc nước triệu đô được đầu tư công nghệ tiêu chuẩn Singapaore sẽ là nơi mang đến cho khán giả những màn trình diễn đẳng cấp. Đó là sự kết hợp độc đáo giữa ánh sáng, âm thanh và nghệ thuật tạo hình phun nước theo giai điệu sôi động. Hứa hẹn đây sẽ là điểm đến thư giãn hấp dẫn cho người dân vào mỗi tối, đặc biệt là dịp cuối tuần.

Được biết, quảng trường nhạc nước Light Square là một trong những tiện ích nội khu thuộc dự án khu đô thị Việt Úc Varea. Xung quanh quảng trường nhạc nước đầy hấp dẫn là các phân khu vui chơi - giải trí dành cho nhiều đối tượng.

Khu vực vui chơi dành cho thiếu nhi được thiết kế theo chuẩn quốc tế. Nơi đây được bố trí các trò chơi vừa an toàn, vừa mang đến cho các bé những trải nghiệm mới lạ, mang đến giây phút thư giãn sau giờ học tập căng thẳng.

Bên cạnh đó là một quần thể kiến trúc độc đáo bao quanh hồ cảnh quan cùng những đàn cá koi bơi lượn, kết hợp với cung đường đi bộ trải dài, uốn lượn ven hồ… Tất cả tạo nên biểu tượng cho cuộc sống hiện đại, tiện nghi. Cư dân tại đây sẽ được tận hưởng những phút giây thư giãn đúng nghĩa bên gia đình. Theo Ban quản lý dự án, hiện tại quảng trường nhạc nước đang được gấp rút hoàn thiện và sẽ đi vào hoạt động giữa quý III năm 2020. Dự kiến, trong tương lai, nơi đây không chỉ để thư giãn, giải trí cho người dân mà còn là địa điểm tổ chức các hoạt động nghệ thuật, các buổi sinh hoạt nhóm đội hay các sự kiện chính trị xã hội ở địa bàn.

Việt Úc Varea - “dự án vàng” của năm 2020
Bất động sản ở phía Tây TP.HCM đang đứng trước tiềm năng phát triển mạnh mẽ chưa từng có trong năm 2020, nhờ những bước tiến mới của các dự án hạ tầng giao thông. Đặc biệt là Long An - “thành phố vệ tinh” ngay cửa ngõ phía Tây TP.HCM. Dự án nằm trên địa bàn xã Lương Hòa, huyện Bến Lức (Long An), ngay mặt tiền đường Tỉnh lộ 830 (Vành đai 4). Đây là vị trí đắc địa nối với nhiều nút giao thông quan trọng của khu vực. Việt Úc Varea hứa hẹn sẽ là một khu đô thị đáng sống và được giới đầu tư săn đón khi có quy mô lớn 20,5ha cùng nhiều tiện ích đa dạng như Trung tâm thương mại, Quảng trường nhạc nước, Hệ thống trường học quốc tế, Công viên ven sông…

Với thông điệp “The Sound of  Life - Thanh âm cuộc sống”, Việt Úc Varea muốn mang đến một nếp sống với nét văn hóa đặc trưng, tận hưởng cuộc sống với tiện ích nơi ngưỡng cửa và gần gũi với thiên nhiên.', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (49, N'Bùng nổ giao dịch tại lễ mở bán dự án đất nền mặt biển Green Dragon City
', CAST(N'2020-06-07T00:00:00.0000000' AS DateTime2), 9, N'Ngày 07/6 vừa qua, lễ mở bán dự án Green Dragon City đã chính thức diễn ra tại khách sạn Hải Yến, TP. Cẩm Phả, Quảng Ninh. Sự kiện thu hút gần 1.000 khách hàng tham dự và ngay trong lễ mở bán, hàng trăm sản phẩm đã được giao dịch thành công.
Tại sự kiện mở bán, Green Dragon City tung ra 225 sản phẩm bất động sản cao cấp thuộc tiểu khu Little Tokyo, gồm: 33 căn biệt thự có diện tích lý tưởng từ 291m2 đến 1.149,5m2; 46 căn liền kề diện tích từ 93,5m2 đến 293,5m2 và 146 căn shophouse với diện tích từ 114m2 đến 351.4 m2, nằm trải dài trên diện tích các lô shophouse từ SH24 đến SH37, các dãy nhà liền kề từ LK70 đến LK81, và các dãy biệt thự biển từ BT17 đến BT19. Dự án được được quy hoạch thành các khu phố kinh doanh sầm uất gồm: Phố ẩm thực Nhật, phố giải trí KTV, phố Spa và tắm khoáng Onsen 7 bước kiểu Nhật, phố đi bộ và câu lạc bộ đêm… Với sức hút từ dự án, chỉ sau vài giờ mở bán chính thức, đã có hàng trăm sản phẩm giao dịch thành công. Đặc biệt, một số khách hàng còn quyết định đặt mua số lượng lớn từ 3-5 sản phẩm bởi tin tưởng vào tiềm năng sinh lời của Green Dragon City cả trong ngắn hạn, trung hạn và dài hạn.  Phát biểu tại sự kiện, đồng chí Trần Hoàng Hải - Phó Chủ tịch Hội đồng nhân dân TP. Cẩm Phả đánh giá cao dự án Green Dragon City là KĐT thúc đẩy du lịch Cẩm Phả phát triển: "Dự án không chỉ giải quyết nhu cầu về không gian sống xanh cho người dân, mà còn góp phần thay đổi diện mạo đô thị của thành phố, đồng thời, thúc đẩy du lịch địa phương phát triển thông qua cung cấp 1 loạt các dịch vụ cao cấp phục vụ nhu cầu lưu trú, ẩm thực, giải trí, mua sắm của du khách”.

Tại sự kiện, chủ đầu tư đã tung ra hàng loạt chính sách ưu đãi và quà tặng hấp dẫn như: Chiết khấu lên đến 7%, hỗ trợ lãi suất 0% khi vay ngân hàng, miễn phí quản lý vận hành trong vòng 01 năm đầu tiên kể từ ngày nhận bàn giao nhà... Đặc biệt, với chương trình trao sổ đỏ ngay tại sự kiện nếu thanh toán 100% giá trị sản phẩm, dự án đã triệt để thuyết phục các khách hàng khó tính nhất xuống tiền đầu tư mua sản phẩm tại dự án. 

Đại diện một đơn vị phân phối nhấn mạnh, được đánh giá là “tâm điểm vàng” của BĐS năm 2020, Green Dragon City sở hữu những giá trị vượt trội thuộc vào hàng hiếm trên thị trường. Chính vì vậy, trong bối cảnh trầm lắng của thị trường bất động sản sau dịch Covid-19, Green Dragon City vẫn tạo ra sức hút khó cưỡng cùng làn sóng đầu tư mạnh mẽ.  Chị Ngọc Anh, một trong hàng trăm khách hàng giao dịch thành công tại sự kiện chia sẻ: “Đối với tôi, khi đầu tư vào các dự án BĐS, điều tôi quan tâm đầu tiên chính là yếu tố vị trí. Khu đô thị - Du lịch – Dịch vụ cao cấp Green Dragon City sở hữu vị trí chiến lược, tọa lạc bên bờ vịnh Bái Tử Long – một trong những vịnh di sản đẹp nhất khu vực, tầm nhìn thoáng rộng bao trọn đại dương xanh mát. Bên cạnh đó, đây cũng là dự án ven biển hiếm hoi nằm giữa trung tâm thành phố Cẩm Phả, sở hữu những lợi thế về kết nối giao thông và hạ tầng, rất thuận lợi cho sinh hoạt của cư dân cũng như có nhiều tiềm năng để kinh doanh”.  

Sự thành công của Lễ mở bán dự án Khu đô thị - Du lịch – Dịch vụ cao cấp Green Dragon City không phải là điều quá bất ngờ bởi trước khi ra mắt, dự án đã nhận được sự quan tâm săn đón của các nhà đầu tư nhờ sở hữu hàng loạt ưu thế các yếu tố vàng quyết định giá trị của bất động sản như: Đắc địa về vị trí, đắt giá về tầm nhìn, vượt trội về kết nối, lợi thế về tiếp cận, đẳng cấp về tiện ích.  Tọa lạc tại vị trí kim cương đắt giá của TP.Cẩm Phả, ngay trong lõi đô thị của trung tâm thành phố, Green Dragon City là dự án hiếm hoi có mặt tiền hướng biển dài gần 3km, tầm nhìn panorama ngắm trọn kỳ quan kỳ vĩ. Đặc biệt dự án còn nằm trong tọa độ vàng trên trục phát triển kinh tế chiến lược Lào Cai - Hà Nội – Hạ Long - Móng Cái - Côn Minh, là cầu nối giữa các vùng kinh tế trọng điểm của miền bắc và là “điểm vàng” trong tam giấc kinh tế Hà Nội – Hải Phòng – Quảng Ninh… Với những lợi thế vượt trội, Green Dragon City được giới chuyên môn đánh giá là dự án hấp dẫn và được mong chờ bậc nhất khu vực miền Bắc trong năm 2020. ', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (50, N'Thị trường căn hộ xác lập mức giá mới
', CAST(N'2020-06-07T00:00:00.0000000' AS DateTime2), 9, N'Bất chấp sức mua giảm dưới tác động chung từ tình hình kinh tế, giá bán căn hộ tại TP.HCM vẫn tăng trưởng và xác lập một mặt bằng mới, ngày càng cao hơn qua các năm.
Thị trường bất động sản TP.HCM trải qua 4 tháng đầu năm có lượng sản phẩm mở bán mới thấp kỷ lục. Bước sang trung tuần quý 2, tình hình dịch bệnh được kiểm soát tốt, nhiều dự án căn hộ thương mại rục rịch bung hàng, cùng với đó mức giá bán mới cũng được tung ra.

Ghi nhận thực tế từ Batdongsan.com.vn cho thấy, so với cuối năm 2019, nhiều dự án mới mở bán hiện nay đang có giá bán khá cao. Mới đây, một dự án KĐT lớn trên đường Nguyễn Xiển tại quận 9 có kế hoạch chuẩn bị chào bán giai đoạn mới. Sàn môi giới chào bán dự án này cho hay, loạt sản phẩm căn hộ, nhà phố sẽ có điều chỉnh giá mới tăng mạnh so với đợt bán trước đó. Từ mức 35-40 triệu/m2 đầu năm 2019, dự kiến giá sơ cấp đợt bán tới trung bình từ 40-55 triệu/m2. Mức giá này là khá cao với một dự án được xếp vào loại hình nhà ở trung cấp, địa bàn giáp ranh Đồng Nai. 

Khu vực quận 2, nơi tập trung nhiều sản phẩm nhà ở thuộc nhiều phân khúc, từ cao cấp đến trung cấp, bình dân, giá BĐS cũng “nhảy múa” qua các năm. Tại khu Cát Lái, tập đoàn Kiến Á thông báo mở bán dự án chung cư City Grand quận 2. Giá căn hộ thấp nhất trong dự án này vào khoảng 2,2 tỷ/căn 55m2, tương đương 40 triệu/m2. Nếu so sánh với loạt căn hộ cùng triển khai ở khu vực này thời điểm 2018-2019 như Citisoho (22-25 triệu/m2), Citiesto (28-32 triệu/m2), giá bán dự án mới đã tăng khá cao.

Với dòng sản phẩm cao cấp triển khai quanh trục đường Nguyễn Thị Định, Đồng Văn Cống,  giá bán đang tăng cao so với năm 2019 do tận dụng một số dự án cầu giao thông mới vừa khởi công xây dựng. Một dự án chung cư đang triển khai trên khu vực gần Đảo Kim Cương mở bán vào tháng 1/2020 vừa qua có giá khởi điểm lên đến 85-90 triệu/m2 dù đầu năm 2019, các dự án triển khai tại đây cao nhất cũng chỉ vào khoảng 70-80 triệu/m2. Dự án Paris Hoàng Kim (quận 2, TP.HCM) mới đây mở bán với giá bình quân khoảng 75 triệu/m2 dù vị trí này không đẹp nếu so với các dự án triển khai trước đó 1-2 năm và giá chào bán chưa đến 55 triệu/m2.

 Ngoài các dự án trên, cũng có nhiều dự án khác tại TP.HCM có kế hoạch ra hàng trong quý 3/2020 như Picity High Park có giá dao động từ 34-37 triệu đồng/m2. Trong đợt mở bán vào năm 2019, giá dự án này chỉ có tầm 31-35 triệu/m2. Trong quý  4 tới đây, Tập đoàn Vạn Phúc cũng sẽ ra mắt khoảng 1.000 căn hộ chung cư cao cấp tại dự án Vạn Phúc City, Hiệp Bình Phước, Thủ Đức. Đây sẽ là dòng sản phẩm chung cư đầu tiên mà doanh nghiệp này phát triển, dự kiến giá không dưới 50 triệu/m2.

Ngoài khu Đông, dự án triển khai trên địa bàn khu Nam và khu Tây TP.HCM cũng có giá chào bán ngày càng cao qua các năm. Khu chung cư West Gate triển khai tại Bình Chánh có giá từ 35-40 triệu/m2, giá căn hộ 2 phòng ngủ tại đây lên tới 1,8 tỷ đồng. Nếu so với các dự án tương tự tại huyện Bình Chánh, thì mức giá này được nhiều nhà đầu tư đánh giá là quá cao. Bởi từ thời điểm cuối năm 2019 trở về trước, giá căn hộ tại huyện vùng ven này đều dưới 30 triệu/m2, thậm chí Bình Chánh còn được biết đến là khu vực có nhiều nhà tái định cư, nhà ở xã hội giá rẻ. Tương tự, một dự án khu dân cư trên đường Võ Văn Kiệt (quận Bình Tân) cũng đang chào bán giá 32-36 triệu/m2, trong khi vào năm 2018-2019, loạt chung cư cùng trên tuyến đường thuộc địa phần quận Bình Tân này giá cao nhất cũng chỉ khoảng 28 triệu/m2.

Báo cáo thị trường tháng 4/2020 của Batdongsan.com.vn cũng cho thấy, tùy dự án và khu vực, thị trường chung cư sơ cấp tại TP.HCM vẫn tiếp tục tăng giá từ 8-12% so với cùng kỳ 2019. Dòng nhà ở bình dân, giá chào bán đã tăng từ 28-29 triệu/m2 thời điểm đầu năm 2019 hiện đã lên mức trung bình 30-32 triệu đồng/m2. Phân khúc nhà ở trung cấp có giá bình quân lên đến 43 triệu đồng/m2 và loại hình chung cư cao cấp chạm mức 60-70 triệu/m2.

Theo báo cáo của Bộ Xây dựng, tính đến hết quý 1/2020, giá bất động sản tại TP.HCM tăng khoảng 3,5% so với cùng kỳ năm 2019. Trong đó, phân khúc căn hộ cao cấp giá tăng khoảng 2,75%, căn hộ trung cấp tăng khoảng 3,72%, căn hộ bình dân tăng khoảng 3,78%. Giá nhà ở riêng lẻ cũng tăng khoảng 8,36% so với cùng kỳ năm 2019.

Nhìn nhận về xu hướng tăng giá BĐS, giới chuyên gia cho rằng, nguồn cung khan hiếm là nguyên nhân chính khiến giá BĐS nói chung không giảm như kỳ vọng dù dịch Covid-19 làm ngưng trệ hoạt động bán hàng, quảng cáo, truyền thông của nhiều doanh nghiệp. Kể từ cuối năm 2018-2019, dù thị trường có suy giảm so với trước đó, nhưng thực tế mức giá không hề giảm mà còn tăng lên một mặt bằng mới do áp lực từ nguồn cung bị giới hạn. Bước sang quý 2/2020, do tình hình dịch bệnh đã được kiểm soát, các hoạt động mở bán dần trở lại. Sức mua cải thiện hơn khiến giao dịch sôi động và nhiều CĐT tự tin hơn khi ra hàng. Giá bán cũng có điều chỉnh so với các quý trước đó. Ngoài ra chi phí phát triển dự án ngày càng tăng cao, giá trị đất đắt đỏ khiến các dự án triển khai sau buộc phải tăng giá chào bán cao hơn các dự án trước đó thì mới có lời.', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (51, N'Điểm nóng mới của bất động sản Quảng Ninh hấp lực giới đầu tư
', CAST(N'2020-06-07T00:00:00.0000000' AS DateTime2), 9, N'Hoành Bồ đang nổi lên như một điểm nóng mới của bất động sản Quảng Ninh. Sức hút của thị trường này khởi nguồn từ việc Hoành Bồ được sáp nhập vào thành phố Hạ Long – một trong những thị trường “nóng” nhất của Quảng Ninh những năm qua.
Hoành Bồ vốn là một huyện cũ thuộc tỉnh Quảng Ninh. Ngày 17/12/2019, Ủy ban Thường vụ Quốc hội ra Nghị quyết số 837/NQ-UBTVQH về sắp xếp các đơn vị cấp huyện, cấp xã thuộc tỉnh Quảng Ninh. Theo đó, toàn bộ 843,54 km2 diện tích tự nhiên và dân số (51.003 người) của huyện Hoành Bồ được nhập vào 275,58 km2 diện tích tự nhiên và dân số (249.264 người) của thành phố Hạ Long.

Thông tin này đã khiến bất động sản Hoành Bồ trở nên nóng sốt, đặc biệt là đất thuộc một số xã ven vịnh Cửa Lục, tiếp giáp với vịnh Hạ Long. Theo khảo sát của Batdongsan.com.vn, thời điểm tháng 10/2019, giá đất tại khu vực này tăng gấp đôi, gấp ba theo giờ, theo ngày. Đơn cử, đất tại khu Bắc Cửa Lục, từ mức giá 3-4 triệu đồng/m2 của 1 tháng trước đó, nhảy vọt lên 7-11 triệu đồng/m2. Nhiều lô được rao bán 7 triệu đồng/m2 buổi sáng thì buổi chiều có người mua với giá 10 triệu đồng/m2. Diễn biến phức tạp của thị trường khi đó đã buộc chính quyền Hoành Bồ vào cuộc. UBND huyện Hoành Bồ đã có văn bản gửi các cơ quan chức năng về việc quản lí hiện trạng các khu đất và mặt bằng các dự án giao thông quan trọng trên địa bàn huyện.

Theo đó, lãnh đạo huyện Hoành Bồ yêu cầu các xã, thị trấn thực hiện quản lí chặt chẽ hiện trạng sử dụng đất phạm vi mặt bằng tuyến của các dự án và quỹ đất trong khu vực lân cận; ngăn chặn và xử lí các trường hợp san lấp mặt bằng, lấn chiếm đất đai, sử dụng đất không đúng mục đích,...

Hoàng Bồ cũng đẩy mạnh tuyên truyền, phổ biến để người dân hiểu các quy định về luật đất đai, nhằm tránh tình trạng một số đối tượng môi giới đất thổi giá, lừa gạt. Tạm dừng thụ lí, giải quyết hồ sơ đề nghị tách thửa, chuyển mục đích sử dụng đất, tạm dừng việc chuyển nhượng quyền sử dụng đất trong quy hoạch liên quan đến quỹ đất thực hiện các dự án nêu trên.

Chính nhờ những động thái đó, thị trường từng bước ổn định trở lại, không còn hiện tượng thổi giá, sốt ảo theo giờ, theo ngày. Tuy nhiên, với nền tảng sẵn có hiện tại và tiềm năng lớn trong tương lai, giá đất Hoành Bồ ghi nhận mức tăng đáng kể. Một trong những vị trí ghi nhận mức tăng tốt nhất của Hoành Bồ đến thời điểm hiện tại là các xã Lê Lợi và Thống Nhất. Thời điểm đầu năm ngoái những lô đất ở 2 xã này còn được rao giá 3-4 triệu đồng/m2 thì đến thời điểm hiện tại, giá đất tăng gấp đôi, lên mức 6-8 triệu đồng/m2. Những lô đất gần biển, gần cầu Cửa Lục, giá cũng chạm mốc 10-12 triệu đồng/m2 trong khi cùng kì năm ngoái, giá bán chỉ 7-8 triệu đồng/m2. Những lô góc, mặt biển, vị trí đắc địa tăng từ 13-14 triệu đồng/m2 lên mức 16-18 triệu đồng/m2.

Trên thực tế, trong vòng 1 năm qua, đất Hoành Bồ đã nằm trong điểm ngắm của giới đầu tư. Việc được sáp nhập vào thành phố Hạ Long – một trong những thị trường bất động sản sôi động nhất cả nước khiến giới đầu tư kì vọng kịch bản tăng trưởng của Hạ Long sẽ lập lại tại Hoành Bồ. 

Nhà đầu tư Phạm Hữu Thiện (Hạ Long, Quảng Ninh) cho biết, hơn 5 năm về trước, những lô đất tại các vị trí đẹp ở Hạ Long như mặt đường Hoàng Quốc Việt hay đất gần đường bao biển cột 5 hay đường Bạch Đằng, giá cao nhất cũng chỉ ngoài 20 hoặc xấp xỉ 30 triệu đồng/m2 thì đến nay để sở hữu được đất ở khu vực này, nhà đầu tư phải trả từ 60-95 triệu đồng/m2. Mức tăng ấn tượng này hoàn toàn có thể lặp lại tại những trục đường chính ven biển ở Hoành Bồ - khu vực mới được sáp nhập vào Hạ Long. Sức hút của Hoành Bồ là mặt bằng giá còn thấp, dư địa tăng giá cao. 

Tuy nhiên, theo ông Thiện, kì vọng vào sự nhảy vọt về giá này cần có thời gian, đi cùng với tốc độ đô thị hóa, phát triển kinh tế của vùng, sự hoàn thiện của hệ thống hạ tầng giao thông và hạ tầng xã hội. Do đó, cuộc đổ vốn vào Hoành Bồ cần xác định là trung và dài hạn, khoảng thời gian chờ đợi ngắn nhất với giới đầu tư, theo ông Thiện có thể là 2 đến 3 năm. 

', 3)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (52, N'17 xu hướng thiết kế nội thất năm 2020', CAST(N'2020-06-01T00:00:00.0000000' AS DateTime2), 9, N'Xu hướng về không gian chức năng
1. Lấy phòng bếp làm trung tâm của không gian sống

Lối sống gia đình năng động, hiện đại tạo ra xu hướng thiết kế mới đó là đặt bếp làm khu vực trung tâm của ngôi nhà, từ đó hình thành nên phong cách mở, cho phép luân chuyển hài hòa giữa chức năng của các khu vực liền kề nhau. Cách bố trí này còn kết hợp công việc sửa soạn đồ ăn với các hoạt động khác của gia đình. Nhờ vậy, người nội trợ sẽ cảm thấy thuận tiện hơn khi vừa nấu nướng, vừa có thể quan sát con cái hay giao tiếp với các thành viên khác trong gia đình.

 2. Phòng làm việc tại gia

Cũng bởi lối sống năng động cùng với thách thức về thời gian và không gian hạn chế khiến ngày càng có nhiều công ty cho phép nhân viên làm việc tại nhà, cùng với đó là sự xuất hiện của các nghề freelancer dẫn tới nhu cầu thiết kế văn phòng làm việc ngay tại nhà đang rất cao. Đây chắc chắn sẽ trở thành xu hướng thiết kế mới. Không chỉ là một căn phòng phụ, văn phòng tại nhà đòi hỏi chú trọng nhiều chức năng hơn và phải có nhiều đồ nội thất tích hợp công nghệ để thôi thúc mỗi cá nhân có thêm động lực làm việc tại nhà. Nên đầu tư vào hệ thống ánh sáng, lựa chọn bàn ghế thoải mái nhằm tận dụng không gian và gia tăng năng suất làm việc.

3. Không gian nhỏ

Những căn hộ mini với diện tích khiêm tốn ngày càng thịnh hành. Tuy xuất phát điểm của việc thiết kế căn hộ nhỏ ban đầu chỉ nhằm giải quyết vấn đề thiếu thốn về diện tích và tài chính nhưng hiện nay, các nhà thiết kế ngày càng quan tâm nhiều hơn đến các giải pháp sáng tạo và thiết thực cho không gian nhỏ. Không gian nhỏ là giải pháp cực kỳ ý nghĩa với những cư dân sống giữa trung tâm đô thị năng động vì tiết kiệm được chi phí, diện tích mà vẫn được tận hưởng đầy đủ tiện ích, chức năng của một ngôi nhà. 

Xu hướng về màu sắc
4. Gam màu trung tính lên ngôi

Những gam màu trung tính một lần nữa sẽ quay trở lại trong năm 2020. Có thể nói rằng, màu trung tính mang sắc thái khá cổ điển, yên bình và đặc biệt không quá nổi bật, gây xao nhãng. Tuy nhiên, đừng vì thế mà cho rằng gam màu này quá đơn điệu, nhàm chán. Màu trung tính và cả màu trắng, tùy vào sắc độ mà có thể là màu lạnh hoặc ấm. Năm 2020 sẽ chứng kiến sự lên ngôi của những gam màu trung tính ấm áp thay thế cho những tông màu lạnh. Đừng đánh giá thấp sức mạnh của gam màu trung tính trong trang trí. Đây sẽ là lựa chọn tuyệt vời cho tường và đồ nội thất, bao gồm cả sofa hay giường ngủ.

5. Thiết kế nội thất trắng và đen

Trắng và đen, hai điểm bắt đầu và kết thúc của quang phổ màu sắc. Thực chất, đây không phải là cặp màu tương phản rõ nét nhất nhưng bạn có thấy sự xung đột giữa ánh sáng và bóng tối (đại diện cho "dương" và "âm") lại là món quà ý nghĩa của tạo hóa đối với kiến trúc và thiết kế nội thất? Có hàng triệu cách để kết hợp xu hướng âm – dương này khi bài trí nhà cửa. Sofa và ghế tựa màu đen phối cùng gối ôm trắng, họa tiết xương cá với hai màu đen - trắng tương phản, đá cẩm thạch đen và trắng... rất nhiều ý tưởng biến tấu và tạo hoa văn khi kết hợp cặp màu này. Bước sang năm 2020, chúng ta có thể mong chờ những khả năng vô tận cho trang trí nhà cửa mà xu hướng thiết kế trắng – đen mang lại. 6. Tông màu nữ tính

Kể từ năm 2019, các đơn vị thiết kế nội thất đã bắt đầu "lăng xê" tông màu nữ tính bằng cách sử dụng rất nhiều biến thể khác nhau của màu hồng. Những gam màu này thực chất là các sắc thái khác nhau của màu hồng nhưng lại có phần tinh tế, nhẹ nhàng hơn. Nên nhớ, các màu hồng phấn, hồng khói, đồng, hồng đất hay hồng nhạt… thường phát huy hiệu quả tốt nhất trong những căn phòng trung tính. 7. Sự trở lại của màu đen

2020 đánh dấu sự quay trở lại của sắc đen cá tính. Các công ty thiết kế nội thất dự đoán rằng màu đen sẽ hiện diện ở mọi thứ, từ tủ bếp, bồn rửa, sơn tường và cả mặt bàn bếp. Những bức tường hay nội thất sơn đen sẽ khiến ngôi nhà trông sang trọng và hợp thời hơn.

Một trong những lý do khiến màu đen bị người ta “ngó lơ” trong quá khứ bởi có nhiều ý kiến cho rằng, màu đen khiến căn phòng trông nhỏ lại, thậm chí là có phần ngột ngạt, bí bách. Tuy nhiên, vấn đề này hoàn toàn có thể khắc phục được bằng cách sử dụng thêm những gam màu tương phản. Như đã đề cập trước đó, trắng và đen sẽ là cặp đôi hoàn hảo trong năm 2020. Vì thế, những điểm nhấn màu trắng hay màu sáng sẽ làm dịu mối lo ngại này. 8. Điểm nhấn xanh lá

Xanh lá là một gam màu tươi mát, do vậy, khi muốn đưa gam màu của đất và theo đuổi lối thiết kế xanh thì đừng ngần ngại kết hợp các mảng màu xanh lá vào trong nhà. Sử dụng cây xanh là cách bổ sung màu sắc hoàn hảo cho những căn phòng trung tính. Năm 2018 và 2019 chứng kiến sự gia tăng của việc tích hợp các loài cây mọng trong trang trí nội thất. Và đến năm 2020, xu hướng này sẽ càng trở nên bùng nổ hơn. Bạn cũng có thể trồng cây đa búp đỏ, cây kim phát tài hay cây lưỡi hổ để tạo nên một khu vườn nho nhỏ nhưng phong phú trong nhà. Đặc biệt, những loài cây này không đòi hỏi chăm bón thường xuyên. Nếu muốn đồng điệu với màu xanh, hãy sắm sửa bộ chăn, ga, gối hay giấy dán tường, tranh tường họa tiết lá cây. 9. Tông màu của đất

Xu hướng thiết kế nội thất 2020 chuộng những gam màu của đất. Màu sắc và kết cấu bắt chước vật liệu gỗ, kim loại và vân lá cây vốn có trong tự nhiên. Các tông màu đất như màu xanh của rừng cây, màu taupe và đất sét tự nhiên, thân thiện với môi trường tạo nên một không gian để thiền định và thư giãn sau một ngày dài. Xu hướng về chất liệu và họa tiết
10. Chất liệu nhung sang trọng và ấm áp

Chất liệu nhung có lẽ không phù hợp với khẩu vị của tất cả mọi người nhưng lại là một trong những xu hướng thiết kế nội thất năm 2020. Chất liệu này pha trộn hoàn hảo giữa tính sang trọng và sự thoải mái. Nói đến nhung, phần lớn mọi người thường nghĩ đến những chiếc sofa bọc nhung đỏ cổ điển của những năm cũ đã qua. Tuy nhiên, bước sang năm 2020 và các năm tiếp theo, nhiều thương hiệu thiết kế nội thất đã bắt đầu giới thiệu nhiều mẫu nội thất bọc nhung độc đáo hơn, đặc biệt là sofa. Tùy chọn màu sắc cũng phong phú hơn, bao gồm xanh dương, hồng, da cam và cả màu nâu be. Có thể nói rằng, sự lựa chọn nội thất nhung trong năm 2020 là vô tận. 11. Họa tiết hình học

Họa tiết hình học ngày càng được yêu thích trong vài năm trở lại đây đến mức mà chúng ta có thể bắt gặp nó ở mọi thứ và mọi nơi. Vấn đề duy nhất là họa tiết hình học quá phổ biến, hiện diện ở mọi thứ - từ cốc chén, sổ, giấy dán tường, sofa, giường ngủ, tranh ảnh, sàn nhà, đèn trang trí... nên nếu xử lý không khéo, quá lạm dụng có thể gây phản tác dụng. Chính vì thế, xu hướng nội thất 2020 chính là cân bằng họa tiết hình học. Bạn vẫn có thể tạo điểm nhấn cho ngôi nhà với những họa tiết hình học ấn tượng và sống động. Bí quyết là hãy trung thành với kiểu họa tiết cổ điển và đương đại cho các chi tiết như ghế tựa và gối ôm, sau đó chọn một khu vực trong nhà mà bạn muốn làm nổi bật với họa tiết hình học, đó có thể là sàn phòng tắm, một bức tường điểm nhấn (accent wall)...

12. Nội thất kim loại

Kim loại sẽ hiện diện ở khắp mọi nơi vào năm 2020. Các chất liệu được sử dụng phổ biến gồm bạc, vàng, thiếc và đồng. Trong đó, thiếc được dự đoán sẽ trở thành lựa chọn phổ biến cho nhà bếp. Xu hướng trang trí kim loại hỗn hợp cũng được nhiều người yêu thích. Đặc biệt, kim loại màu ánh bạc và ánh đồng sẽ kết hợp ăn ý với nhau, chẳng hạn như sắt với vàng hoặc đồng. Lưu ý, không nên kết hợp quá 3 kim loại trong một không gian để tránh làm căn phòng trở nên rối mắt và choáng ngợp. 13. Giấy dán tường họa tiết hoa lá

Giấy hay vải dán tường họa tiết hoa lá là một trong những xu hướng nội thất hiện đại được mong chờ sẽ quay trở lại trong năm nay. Xét về mặt kỹ thuật, họa tiết hoa lá đã xuất hiện từ lâu nhưng xu thế sử dụng họa tiết hoa lá của năm 2020 có sự khác biệt lớn. Họa tiết hoa lá phát huy hiệu quả tốt nhất khi được ứng dụng cho giấy dán tường. Và xu hướng giấy dán tường ngày nay thường kết hợp các mẫu hoa có kích thước, màu sắc và kiểu dáng khác nhau. Bằng cách kết hợp các gam màu rực rỡ với nhau, chẳng hạn như màu vàng và một màu tương phản sẽ khiến bức tường thực sự nổi bật.  Xu hướng về phong cách thiết kế
14. Thiết kế Biophilic

Thiết kế Biophilic, hiểu đơn giản là thiết kế xanh, một ý tưởng sáng tạo mới cho những nơi chúng ta sống, học tập và làm việc. Ở đó, lối thiết kế và các thành phần tự nhiên hòa quyện vào nhau tùy theo từng bối cảnh nhất định chứ không hề rập khuôn máy móc.

Trong suốt nhiều năm qua, xã hội loài người đã và đang phải vật lộn với biến đổi khí hậu, phát triển bền vững. Không ít gia chủ muốn sở hữu một ngôi nhà phong cách nhưng vẫn kết hợp các yếu tố hữu cơ từ môi trường. Thật may mắn, các đơn vị thiết kế nội thất đã chú ý đến xu hướng thiết kế xanh. Gỗ tái chế được sử dụng làm ghế tựa, làm bàn ăn hay làm ván lát sàn, còn cây xanh góp phần tôn lên vẻ đẹp thẩm mỹ hữu cơ cho ngôi nhà, thanh lọc không khí, tạo nên không gian sống thân thiện với môi trường. Dù những ngôi nhà công nghệ cao đang hiện hữu và ngày càng phổ biến thì năm 2020, mọi thứ sẽ quay trở lại với tự nhiên. Phòng tắm và phòng ngủ sẽ trở thành những nơi thoát tục, sử dụng các yếu tố có nguồn gốc tự nhiên như kim loại, gỗ và đá.

15. Thiết kế backsplash họa tiết bắt mắt

Một trong những cách hiệu quả nhất giúp bếp và phòng tắm thật sự nổi bật trong năm mới là thiết kế tấm ốp tường (backsplash) sống động. Xu hướng thiết kế nội thất năm 2020 chuộng gạch ốp lát màu sắc, hoa văn bắt mắt. Nhờ vậy, căn bếp sẽ trở nên nổi bật, thu hút ánh nhìn của bất cứ ai ghé thăm nhà. 16. Phong cách tối đa

Phong cách nội thất tối giản bắt đầu bước vào giai đoạn thoái trào, nhường chỗ cho phong cách tối đa. Nếu như chủ nghĩa tối giản hướng tới giảm bớt nội thất, đồ đạc, làm cho không gian trở nên đơn giản, tường minh hơn thì chủ nghĩa tối đa lại hoàn toàn ngược lại. Chủ nghĩa tối đa có nghĩa là càng nhiều càng tốt (more is more). Rõ ràng, các nhà thiết kế nội thất sẽ có thêm nhiều đất diễn với xu hướng này: Màu sắc cùng hoa văn tươi sáng, mạnh mẽ và ấn tượng, đồ trang trí xa hoa, tranh trừu tượng đầy màu sắc... 17. Thiết kế nội thất công nghệ môi trường

Xu hướng công nghệ môi trường xanh kết hợp hai thành phần tương phản là công nghệ và tự nhiên. Khoa học và công nghệ đã được ứng dụng nhằm tạo ra những món đồ bền vững vừa mang tính thẩm mỹ cao, vừa có lợi cho môi trường. Người ta có thể tái chế đồ gỗ cũ, nhựa đã qua sử dụng, mang đến "cuộc đời" mới cho chúng. Vì bền vững không có nghĩa là lỗi thời nên các nhà khoa học và các nhà thiết kế nội thất sẽ tiếp tục hợp tác hiệu quả với nhau để sản xuất ra những món đồ tô điểm cho ngôi nhà mà không làm ảnh hưởng đến mẹ thiên nhiên.', 5)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (53, N'Bật mí màu sắc chuẩn nhất cho từng phòng trong nhà theo tâm lý học
', CAST(N'2020-05-30T00:00:00.0000000' AS DateTime2), 9, N'Theo các nhà tâm lý học, màu sắc của không gian xung quanh có thể ảnh hưởng đến cảm giác, tâm trạng của bạn. Ví dụ, màu đỏ có thể khiến bạn tập trung hơn, còn màu xanh lam giúp bạn bình tĩnh lại. Sơn phòng và một số không gian nhất định bằng màu sắc phù hợp có tác động tích cực đến tâm lý, giúp bạn cảm nhận được những điều mong muốn trong không gian đó.
Dưới đây là gợi ý những màu sơn phù hợp nhất cho từng không gian trong nhà dưới góc độ tâm lý học.

1. Phòng khách: màu cam Màu cam có thể khiến con người cảm thấy phấn khích, nhiệt tình, đồng thời cũng gợi lên cảm giác ấm áp. Do đó, các nhà tâm lý học cho rằng màu cam phù hợp nhất để sơn, trang trí phòng khách hoặc các khu vực cốt lõi trong nhà bạn.

2. Phòng bếp: màu vàng Màu vàng kích thích cơ thể tăng sản xuất serotonin – loại “hóc-môn vui vẻ” khiến tâm trạng thoải mái, gia tăng cảm giác thèm ăn nên vàng chính là màu sắc phù hợp nhất cho thiết kế phòng bếp. Đây cũng là lý do tại sao hầu hết các nhà hàng chọn vàng là màu sắc chủ đạo khi thiết kế nội thất.

3. Phòng làm việc tại nhà hoặc phòng gym: đỏ Theo các chuyên gia, màu đỏ có thể khiến mọi người làm việc năng suất hơn nhờ tập trung. Khi làm việc trong căn phòng màu đỏ, tốc độ và khả năng phản ứng của một người được tăng lên đáng kể. Tương tự, nếu bạn đang băn khoăn chưa biết sơn màu gì cho phòng gym của mình, màu đỏ là một gợi ý rất đáng cân nhắc.

4. Phòng ngủ: màu xanh lam Màu xanh lam có sức mạnh giúp tâm lý con người trở nên bình tĩnh, thư giãn, thanh thản. Đây chính là một trong những màu sắc thư giãn nhất đối với đôi mắt, gợi lên cảm xúc nhẹ nhàng, bình yên nên rất phù hợp cho phòng ngủ và những không gian thư giãn, “góc chill” trong nhà bạn. Đặc biệt, màu xanh lam cổ điển chính là màu của năm 2020. Nếu bạn đang có kế hoạch sơn lại phòng ngủ, tại sao không thử phương án này?

5. Lối vào hoặc hành lang: màu xám Theo nhà thiết kế nội thất nổi tiếng Susan Bednar Long, màu xám phù hợp nhất cho lối vào và hành lang vì những không gian này đóng vai trò trung tính so với các phòng khác trong nhà. Màu xám rất đơn giản nhưng thanh lịch, có thể thay đổi tông màu, sắc độ theo cường độ ánh sáng nên sẽ mang đến cho ngôi nhà của bạn vẻ ngoài độc đáo, linh hoạt. Đồng thời, màu xám cũng có tác dụng cân bằng thị giác, làm dịu mắt, khiến bạn không bị mệt mỏi sau khi liên tục nhìn những màu nổi ở các không gian khác. 

6. Phòng học: tím lilac Màu tím lilac có mối liên hệ sâu sắc với trí tưởng tượng và sáng tạo. Ngoài ra, danh họa Leonardo da Vinci tin rằng sức mạnh của thiền tăng gấp 10 lần khi được thực hiện dưới ánh sáng tím. Vì vậy, để thúc đẩy khả năng sáng tạo trong những không gian như phòng học, phòng làm đồ thủ công, DIY, bạn hãy sơn phòng màu tím lilac. 

7. Phòng trẻ em: màu xanh lá cây Màu sắc bạn lựa chọn để sơn phòng cho con trẻ thực sự có thể ảnh hưởng đến sự phát triển của các bé. Các nhà tâm lý cho rằng màu sắc phù hợp nhất cho khu vực “vườn ươm” này chính là màu xanh lá cây. Màu này có tác dụng làm dịu tâm lý, giảm áp lực và góp phần giúp em bé ngủ ngon.', 5)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (54, N'Từ A đến Z các bước sơn nhà cơ bản, đúng kỹ thuật
', CAST(N'2020-05-10T00:00:00.0000000' AS DateTime2), 9, N'Các bước sơn nhà được ví như quá trình khoác áo mới cho công trình. Lớp áo này ngoài tác dụng trang trí, tô điểm còn có nhiệm vụ bảo vệ công trình khỏi tác động của môi trường trong suốt một thời gian dài.
Để có một lớp áo đẹp, chất lượng tốt và bền màu, bên cạnh yếu tố về chất lượng sơn thì quá trình thực hiện các bước sơn nhà ra sao cũng quan trọng không kém. Việc tuân thủ nghiêm ngặt các bước để sơn nhà có thể tốn khá nhiều thời gian nhưng bù lại, ngôi nhà sẽ được bảo vệ lâu hơn, kéo dài thời gian sử dụng cho tới lần sơn lại tiếp theo.

Chọn thời điểm sơn nhà
Thời điểm thích hợp nhất để sơn nhà là vào đúng tiết thu của miền Bắc với đặc thù mát mẻ, khô ráo. Bạn nên sơn nhà vào khoảng cuối tháng 8, tháng 9, tháng 10 dương lịch là hợp nhất. Tuy nhiên, việc đòi hỏi thời tiết lý tưởng như vậy là điều rất khó với các vùng miền khác nhau ở nước ta, đồng thời cũng không đáp ứng được nhu cầu xây dựng quanh năm. Bạn vẫn có thể sơn nhà vào mùa xuân, mùa hạ và mùa đông nhưng tránh thời điểm trời mưa kéo dài hay khi độ ẩm không khí tăng cao. Bởi khi đó, công trình sẽ lâu khô và gặp nhiều sự cố như bong tróc, ngấm ẩm. Mặt khác, cũng không nên sơn nhà khi trời nắng quá bởi sơn cần một thời gian nhất định để có thể bám dính chắc chắn vào bề mặt tường. Dung môi bay hơi nhanh hơn khi nhiệt độ cao làm giảm độ bám khiến màng sơn bị bong tróc, dễ rạn, nứt, nhăn nhúm.

Lựa chọn màu sắc phù hợp
Màu sơn gồm một số màu gốc, các màu sắc khác đều được pha chế từ màu gốc. Hầu hết các hãng sơn đều có bảng màu phong phú để khách hàng lựa chọn. Xét về lý thuyết, màu của các hãng là giống nhau, tuy nhiên, màu thực tế có thể thay đổi vào chất lượng sơn, hệ thống sơn và tay nghề thợ thi công. Ánh sáng cũng là yếu tố quyết định đến màu sơn, cùng một màu sơn nhưng nếu bạn quan sát dưới ánh sáng tự nhiên sẽ khác với khi quan sát dưới ánh sáng điện. 

Sơn có nhiều nhãn hiệu, chủng loại nhưng đa phần là sơn gốc nước. Bạn cần xác định tông màu trang trí, khả năng chi trả để lựa chọn sản phẩm sơn phù hợp. 

Cuối cùng, đừng quên tham khảo ý kiến của các chuyên gia để phối kết hợp màu sắc sao cho độc đáo và đẹp mắt.', 5)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (55, N'4 cách giúp tăng tối đa lợi nhuận từ việc cho thuê nhà
', CAST(N'2020-05-30T00:00:00.0000000' AS DateTime2), 10, N'Xây nhà trọ cho thuê là kênh đầu tư rất được ưa chuộng tại các thành phố lớn do nhu cầu thuê cao. Tuy nhiên, để tối ưu hóa doanh thu, tăng thêm lợi nhuận ngoài tiền cho thuê nhà, gia chủ không nên bỏ qua 4 kinh nghiệm sau đây.
1. Cải tạo để tối ưu hóa lợi nhuận căn nhà

Khi việc kinh doanh phòng trọ đã trở nên phổ biến, nguồn cung nhiều thì việc thiết kế phòng ốc sao cho tiện nghi, sắp xếp hợp lý sẽ là yếu tố giúp khu trọ của bạn trở nên nổi bật hơn so với các đối thủ trên địa bàn.

Chủ nhà cần xem xét vị trí nhà trọ ở đâu để lựa chọn hình thức xây dựng phù hợp, ví dụ: Đất trung tâm có thể xây phòng trọ cao cấp, căn hộ mini với giá thuê trung bình/cao; đất nằm gần khu công nghiệp, các trường Cao đằng, Đại học nên xây dãy trọ nhiều tầng, có thể khép kín hoặc không, giá thuê thấp hơn để hướng đến đối tượng là sinh viên, công nhân, người thu nhập thấp…

Ngoài ra, tùy vào việc xác định đối tượng khách thuê mà chủ nhà cần sắm những trang thiết bị, tiện nghi phù hợp với nhu cầu sử dụng. Cùng một diện tích phòng trọ nhưng một số chủ nhà có thể thiết kế thêm gác xép để tận dụng tối đa diện tích và tăng giá cho thuê. 

2. Vận hành và quản lý thông minh, hiệu quả

Hiện nay có nhiều phương án quản lý nhà trọ như: chủ nhà tự quản lý, thuê dịch vụ/người quản lý hoặc sử dụng các phần mềm quản lý kinh doanh nhà trọ. Việc lựa chọn phương án nào còn tùy thuộc vào tình hình tài chính, mô hình kinh doanh lớn/nhỏ của chủ nhà. Tuy nhiên, dù quản lý theo hình thức nào thì ngay từ đầu, chủ nhà cũng cần đặt ra nội quy chi tiết về giới hạn số lượng người ở, việc sử dụng các thiết bị chung…

Ví dụ, khi khách thuê phát sinh thêm người đến ở trong một thời gian dài thì tiền thuê nhà phải tăng lên do tính đến khấu hao thiết bị, đồ nội thất. Nhưng tốt nhất, các quy định này nên thỏa thuận trước với khách hàng và ghi rõ trong hợp đồng để tránh việc xảy ra bất đồng, tranh cãi.

Tăng giá thuê nhà hợp lý cũng là một cách để gia chủ tăng thêm doanh thu từ việc cho thuê. Nếu khách thuê ký hợp đồng thuê nhà dài hạn, chủ nhà nên thảo luận để có điều khoản tăng tiền thuê định kỳ. Thời điểm ký mới hợp đồng cũng là lúc thích hợp để gia chủ tăng tiền thuê nhà, tuy nhiên lý do đưa ra phải thật hợp lý và giải thích khéo léo để người thuê chấp thuận.

3. Chăm sóc khách thuê tiềm năng

Chủ nhà cần chăm sóc khách thuê một cách tốt nhất nhằm mang lại nhiều hơn những khách hàng tiềm năng do được giới thiệu khu nhà trọ của mình. Bởi lẽ, khách hàng chính là yếu tố quan trọng quyết định công việc kinh doanh nhà trọ có thành công hay không. Việc tìm được khách thuê nhanh chóng sẽ giúp rút ngắn thời gian phòng trọ để trống, nhờ vậy giảm bớt thiệt hại cho chủ nhà.

Ngoài ra, khi đã sống một thời gian đủ lâu ở nhà thuê, khách hàng thường khá ngại chuyển đi vì rất phiền phức. Chưa kể họ đã quá quen với cuộc sống hiện tại nên sẽ không có đòi hỏi quá cao về việc tân trang hay sửa chữa lại nhà như các khách thuê mới. Tận dụng điều này, chủ nhà nên xây dựng mối quan hệ tốt với khách thuê hiện tại để tăng thêm cơ hội ký hợp đồng lâu dài, không tốn thời gian và chi phí để tìm khách thuê mới cũng như đầu tư xây sửa.

 4. Kinh doanh dịch vụ đi kèm
Phương án tiếp theo giúp chủ nhà gia tăng doanh thu cho khu trọ đó là đa dạng hóa các loại hình dịch vụ cung cấp. Một số dịch vụ đi kèm mà chủ nhà có thể kinh doanh thêm như: Dọn vệ sinh hàng tuần/tháng, bảo trì hệ thống điện/nước, vệ sinh điều hòa, bán hàng tạp hóa/đồ gia dụng để khách thuê tiện mua mà không phải đi xa…

Lưu ý, để khách thuê vui vẻ rút thêm hầu bao sử dụng dịch vụ đi kèm, chủ nhà phải cung cấp những dịch vụ hữu ích và giá thành hợp lý. Thái độ phục vụ phải niềm nở để khách thuê hài lòng, tin cậy và sử dụng các dịch vụ đó lâu dài hơn.', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (56, N'4 lưu ý khi sang nhượng cửa hàng
', CAST(N'2020-02-26T00:00:00.0000000' AS DateTime2), 11, N'Tìm thuê mặt bằng kinh doanh với giá tốt tại các thành phố lớn vốn không dễ dàng. Vì vậy, nhiều người chọn hình thức sang nhượng cửa hàng nhằm tiết kiệm công sức, thời gian lại tận dụng được cơ sở vật chất và lượng khách hàng cũ. Tuy nhiên, người thuê cần lưu ý 4 điều dưới đây để tránh một số phiền toái khi nhận sang nhượng cửa hàng:
Tìm hiểu lý do chủ cũ sang nhượng
Thông thường có 2 lý do khiến chủ cửa hàng muốn sang nhượng mặt bằng kinh doanh:

Lý do thứ nhất là họ chuyển đổi nơi ở hoặc gặp biến cố về tài chính nên cần nhượng lại cửa hàng gấp. Khi đó, bạn có thể nhận sang nhượng mặt bằng với giá hấp dẫn mà quên mất việc phải xác minh thông tin. Không loại trừ trường hợp chủ cũ sang nhượng gấp cửa hàng để trốn nợ và khi chủ nợ đến quán quấy phá thì chủ mới sẽ là người chịu thiệt hại.  

Lý do thứ hai là công việc kinh doanh không tốt nên họ buộc phải chuyển đi. Trong trường hợp này, bạn lưu ý phải tìm hiểu kỹ xem họ kinh doanh không tốt vì những yếu tố nào, nếu liên quan đến vấn đề mặt bằng (địa điểm ít người qua lại, không thuận tiện dừng đỗ xe…) thì nên cân nhắc lại việc sang nhượng, vì sau này bạn cũng rất khó để kinh doanh hiệu quả.

Để tìm hiểu lý do sang nhượng cửa hàng, bạn có thể hỏi trực tiếp chủ cũ khi đến xem mặt bằng, hoặc lân la hỏi hàng xóm xung quanh. Qua đó đánh giá về khả năng kinh doanh tại cửa hàng sang nhượng, tính khả thi và an toàn khi nhận sang nhượng mặt bằng tại đây. Xác định chủ thể chuyển nhượng cửa hàng
Cần làm rõ thông tin của người chuyển nhượng cửa hàng cho bạn xem họ là chủ sở hữu mặt bằng hay chỉ là người thuê mặt bằng rồi cho thuê lại. Nếu là chủ sở hữu thì có thể an tâm, nhưng nếu chỉ là người thuê mặt bằng thì bạn cần phải suy xét kỹ hơn. Hãy yêu cầu người đó cung cấp đầy đủ giấy tờ trong hợp đồng thuê mặt bằng của họ và chủ sở hữu để đảm bảo rằng thời hạn sử dụng còn dài lâu và người sang nhượng được phép chuyển quyền kinh doanh. Một số loại giấy tờ cơ bản mà bạn phải yêu cầu bên sang nhượng cửa hàng cung cấp bao gồm: hợp đồng cho thuê mặt bằng kinh doanh đã được công chứng và có chữ ký của chủ nhà và người thuê, giấy đăng ký kinh doanh có chứng nhận của cơ quan Nhà nước, giấy chứng nhận hình thức kinh doanh...

Ngoài ra, hãy đảm bảo rằng người sang nhượng lại cửa hàng không sang nhượng lại cho nhiều người khác nếu không bạn sẽ dễ bị lừa khi giao tiền chuyển quyền kinh doanh. Bạn cũng cần phải xem xét cửa hàng được sang nhượng thuộc hình thức kinh doanh nào (kinh doanh hộ cá thể, doanh nghiệp tư nhân, công ty...) để có những thủ tục pháp lý phù hợp.

Kiểm tra cơ sở vật chất, định giá sang nhượng
Thông thường khi sang nhượng cửa hàng sẽ có kèm luôn cả tài sản vật chất. Tuy nhiên giao dịch này vẫn cần có các thỏa thuận kỹ về những vật dụng, đồ đạc để lại trong quá trình sang nhượng, tính giá hay không, nếu tính thì tính như thế nào và có biên bản liệt kê chi tiết kèm theo với hợp đồng khi ký kết.

Điều đó có nghĩa, việc định giá sang nhượng cửa hàng sẽ liên quan đến các yếu tố như hệ thống an ninh sẵn có, hàng hóa thanh lý, máy móc thiết bị, tên thương hiệu… Bạn cần phải xem xét kỹ và đánh giá chất lượng cũ, mới, khả năng tái sử dụng của những cơ sở vật chất đó để quyết định xem có mua thanh lý hay không, nếu mua thì mức giá như thế nào.

Lưu ý với những cửa hàng sử dụng điện, nước nhiều và thường xuyên như cửa hàng giặt là, cửa hàng sửa chữa…, bạn nên chắc chắn rằng họ đã thanh toán các chi phi duy trì và phí dịch vụ khác trước khi chuyển đi. Vì nếu lơ là chi phí này, bạn sẽ thiệt hại một khoản khá lớn khi thanh toán vào cuối tháng. Trường hợp họ quên hoặc chuyển đi khi chưa đến hạn thanh toán, bạn có thể đề xuất việc thanh toán hộ và nhận tiền trước để đảm bảo không xảy ra tranh cãi sau này. Xem xét kỹ hợp đồng sang nhượng
 Hợp đồng sang nhượng cửa hàng phải đảm bảo có đủ các thông tin như: Đối tượng chuyển nhượng và nhận chuyển nhượng, các loại tài sản hữu hình và vô hình hiện có, những quy định, điều khoản, quyền lợi và nghĩa vụ của hai bên, thời hạn sang nhượng trong bao lâu, chi phí sang nhượng là bao nhiêu… Lưu ý những điều khoản này càng chi tiết càng tốt bởi nó sẽ góp phần bảo vệ quyền lợi của bạn một cách tốt nhất.

Để hạn chế tối đa rủi ro có thể xảy ra, bạn đừng quên đưa vào điều khoản về việc chấm dứt hợp đồng, giải quyết vi phạm hợp đồng, phạt hợp đồng khi một trong 2 bên không tuân thủ các nghĩa vụ đã cam kết. Hợp đồng ký kết phải có chữ ký của 2 bên và nên được công chứng để đảm bảo hơn về giá trị pháp lý khi chuyển nhượng cửa hàng.', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (57, N'Cần lưu ý gì khi chọn nhà nguyên căn để cho thuê lại?
', CAST(N'2020-01-31T00:00:00.0000000' AS DateTime2), 9, N'Thuê nhà nguyên căn rồi cho thuê lại được xem là một trong những cách “hốt bạc” của không ít nhà đầu tư. Tuy nhiên, để đảm bảo tỷ lệ lấp đầy phòng và lợi nhuận thu được, nhà đầu tư cần đặc biệt lưu ý khi lựa chọn sản phẩm để xuống tiền.
Đã nhiều năm thuê nhà để sinh sống và làm việc tại Hà Nội, chị Hằng là nhân viên tại một công ty truyền thông nhưng vì tính cách năng động và yêu thích kinh doanh nên chị quyết định tìm hiểu và săn tìm thuê nhà nguyên căn để cho thuê lại. Bỏ thời gian tìm kiếm và nhờ cả người quen hỗ trợ, chị tìm được một căn nhà nằm trong làng bún Phú Đô, Mễ Trì. Căn nhà gồm 4 tầng với 8 phòng có giá thuê mỗi tháng là 14 triệu đồng, thanh toán trước 6 tháng, hợp đồng 1 năm gia hạn 1 lần.

Chị Hằng tính, với giá thuê mỗi phòng chị phải trả là 1,75 triệu/tháng thì chị sẽ cho thuê lại với giá khoảng 2-2,5 triệu/tháng/phòng. Như vậy, mỗi tháng chị thu được vài ba triệu, coi như không mất tiền thuê nhà.

Chơi lớn hơn, anh Trần Hiếu (TP.HCM) đã gắn bó với công việc tìm thuê nhà nguyên căn rồi cho thuê lại suốt nhiều năm. Nhận thấy tiềm năng của kênh đầu tư này trước nhu cầu thuê nhà ngày càng tăng, anh Hiếu cùng nhóm bạn tập trung đi tìm nhà khắp các ngõ ngách, sau đó tân trang, tách phòng rồi cho thuê. Anh Hiếu cho biết, giá thuê nhà nguyên căn khoảng 10-15 triệu/tháng, thêm chi phí sửa sang khoảng 40 triệu. Nếu chia nhà thành 6-7 phòng, giá thuê mỗi phòng khoảng 3 triệu thì tiền thu về sau khi trừ tiền trả cho chủ nhà là 8-10 triệu/tháng. Như vậy, chỉ cần 3-4 tháng là có thể lấy lại số tiền bỏ ra để sửa nhà. Anh Hiếu cũng cho hay anh có vài căn nhà cho thuê như vậy, mỗi tháng thu về hàng chục triệu đồng.

 Với số vốn đầu tư ban đầu không nhiều, chỉ cần chưa đến 100 triệu đồng nên việc thuê nhà nguyên căn rồi tách phòng và cho thuê lại trở thành kênh đầu tư hấp dẫn, thu hồi vốn nhanh và giúp mang lại khoản thu nhập thụ động hàng chục, thậm chí hàng trăm triệu đồng mỗi tháng.

Tuy nhiên, để có thể "hốt bạc" từ hình thức đầu tư này, nhà đầu tư cần thực sự sáng suốt và cân nhắc kỹ khi lựa chọn sản phẩm.

Thứ nhất, trước khi tìm nhà, nhà đầu tư cần căn cứ vào số vốn sẵn có để xác định chính xác phân khúc và nhóm khách hàng mà mình hướng đến là sinh viên, công nhân hay những gia đình trẻ... Việc xác định rõ ràng đối tượng khách hàng sẽ giúp nhà đầu tư dễ cân đối chi phí, từ đó rút ngắn thời gian thu hồi vốn.

Thứ hai, sau khi xác định nhóm khách hàng, nhà đầu tư cần khoanh vùng những vị trí thích hợp nhất. Đó nên là vị trí nằm gần các khu dân cư hiện hữu, xung quanh có đầy đủ hạ tầng tiện ích, gần trường học, các khu văn phòng, các tuyến đường lớn...

Thứ ba, những ngôi nhà được chọn nên có cấu trúc đơn giản để thuận tiện cho việc cải tạo, tách phòng, tránh làm hư hại tổng thể ngôi nhà và gia tăng chi phí đầu tư.

Thứ tư, sau khi chọn được căn nhà ưng ý, nhà đầu tư cần lên kế hoạch chi tiết về các khoản chi phí gồm: chi phí thuê nhà, chi phí sửa sang nhà, chi phí quảng cáo và chi phí dự phòng. Từ các khoản chi phí này, nhà đầu tư sẽ tính toán và đưa ra mức giá thuê hợp lý căn cứ vào diện tích và nội thất của mỗi phòng.

Thứ năm, nhà đầu tư cũng cần tìm hiểu kỹ về tính pháp lý của ngôi nhà. Bên cạnh đó, khi ký hợp đồng thuê nhà, nhà đầu tư cần xem xét kỹ các điều khoản, thỏa thuận về việc sửa chữa nhà, tách phòng và người chịu trách nhiệm khi xảy ra sự chố cháy nổ, hỏng hóc trong nhà... Việc tìm hiểu tính pháp lý và thỏa thuận kỹ các điều khoản trong hợp đồng sẽ hạn chế tối đa các tổn thất và tranh chấp với chủ nhà trong quá trình cho thuê.

', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (58, N'4 sai lầm thường gặp khi cải tạo nhà ở để cho thuê
', CAST(N'2020-02-03T00:00:00.0000000' AS DateTime2), 9, N'Tại những khu vực đông dân, nhu cầu thuê cao, nhiều gia đình muốn cải tạo nhà ở để có thêm phòng cho thuê, tận dụng không gian ít sử dụng để tăng thu nhập. Tuy nhiên, việc cải tạo, nâng cấp có thể phản tác dụng nếu chủ nhà mắc phải những sai lầm dưới đây.
1. Không có kế hoạch cụ thể
Sai lầm này sẽ khiến việc nâng cấp, cải tạo nhà rất mất thời gian, thiếu hiệu quả. Do đó, trước khi sửa chữa nhà cho thuê, bạn phải lập một bản kế hoạch cụ thể, trong đó hoạch định chi tiết những nội dung như:

- Mức độ cần sửa chữa: Xác định rõ tình trạng ngôi nhà để có hình thức sửa chữa, cải tạo phù hợp. Lên danh sách những hạng mục cần tu sửa, tránh tình trạng sửa chữa tràn lan làm phát sinh chi phí và thâm hụt ngân sách. 

- Thời gian sửa chữa: Tính toán thời gian bắt đầu, thời gian kết thúc việc sửa chữa để có kế hoạch phù hợp, nên chọn thời gian thuận lợi về thời tiết, dễ tìm thợ.

- Dự trù kinh phí: Tính toán kỹ chi phí trước khi sửa nhà bởi chi phí này thường có phát sinh so với dự toán ban đầu. So sánh giữa chi phí bỏ ra và lợi nhuận thu được để quyết định nên bỏ ra bao nhiêu chi phí là hợp lý.

- Chọn đơn vị thi công: Trong trường hợp việc cải tạo nhà quá phức tạp và bạn không có thời gian hay khả năng để tự thực hiện, hãy thuê một đơn vị uy tín để thiết kế, thi công.

 2. Thu hẹp nhà xe để làm phòng mới
Nhiều người muốn cơi nới nhà ở hoặc nhà trọ đang cho thuê nhằm tăng lợi nhuận, nên đã ngăn một góc của nhà xe làm thành phòng nhỏ cho thuê. Những phòng này thường có giá rẻ hơn vì diện tích chật chội, bí bách, lại phải chịu khói xe, tiếng ồn. Dù đáp ứng được nhu cầu của một số khách thuê ngân sách hạn hẹp, nhưng trong nhiều trường hợp, việc cơi nới thêm những phòng trọ cạnh nhà xe lại là một sai lầm. Lý do là số lượng phòng lớn trong khi nhà xe bị thu hẹp sẽ khiến quá tải sức chứa. Khách thuê sẽ rất khó chịu vì mỗi lần lấy xe rất mất công sức và thời gian, lâu dài có thể mất khách. 

3. Không đảm bảo mỹ quan chung 
Cải tạo nhà ở cho thuê không hề đơn giản, thậm chí còn phức tạp hơn cả việc xây mới vì nó đòi hỏi phải tính toán cẩn trọng để không làm ảnh hưởng đến cấu trúc, không gian tổng thể của ngôi nhà. Quá trình tu sửa chắc chắn không tránh khỏi việc sử dụng các vật liệu mới để phù hợp với điều kiện xây dựng tại mỗi thời điểm. Tuy nhiên, bạn cần chú ý đến vấn đề thẩm mỹ, tránh tình trạng bên được cải tạo và bên cũ lệch pha nhau, khiến cả bạn và khách thuê đều không ưng ý.

Để tiết kiệm chi phí sơn sửa, nhiều người khi cải tạo phòng cho thuê đã chọn cách sử dụng giấy dán tường. Ưu điểm của loại giấy này là có thể che được những khuyết điểm trên bề mặt tường. Tuy nhiên, không nên lạm dụng giấy dán tường bởi giấy rất dễ bong tróc ở nơi ẩm thấp, chỉ nên dùng ở những phòng khô ráo, chọn gam màu trung tính, ít hoạ tiết để phù hợp với nhiều đối tượng thuê nhà.

4. Không cân nhắc các vấn đề khi thi công - Tiếng ồn: Do cải tạo nhà ở đang cho thuê nên không thể tránh khỏi việc gây ồn ào, phiền toái đến hàng xóm xung quanh và khách trọ. Vì vậy, trước khi thi công, bạn cần chú ý tính toán xem những hạng mục gây tiếng ồn và mức độ tiếng ồn ra sao. Từ đó xác định được việc nào nên làm trước, việc nào làm sau, thực hiện vào khung giờ nào để thuận lợi nhất và không ảnh hưởng đến nhiều người nhất. Lưu ý tránh thi công vào giờ nghỉ trưa hoặc buổi tối bởi đây là thời gian mọi người cần thư giãn, nghỉ ngơi. Tiếng ồn từ việc xây sửa sẽ khiến họ trở nên bực bội hơn bao giờ hết.

- Vệ sinh môi trường: Dù quá trình thi công khó tránh khỏi bụi bặm, lộn xộn, nhưng chủ nhà cần chú ý dùng mọi biện pháp che chắn để giảm thiểu tối đa tình trạng này. Không có khách thuê nhà nào chấp nhận việc căn phòng của mình bị nhiễm khói bụi từ công trình, hoặc mỗi lần dắt xe qua khu vực tu sửa là bị lấm lem những xi măng, vôi vữa…

- Đảm bảo an toàn cho người thi công và người thuê nhà: Đây là vấn đề đáng quan tâm hàng đầu tại mỗi công trình cải tạo nhà ở đang có người thuê. Sẽ không ai cảm thấy an toàn với những vật liệu sắt, thép, đinh ốc nằm ngổn ngang trên lối đi của họ. Vì vậy, chủ nhà cần phải có sự sắp xếp và cất giữ vật liệu ở nơi phù hợp, che đậy cẩn thận và có dán thông báo để đảm bảo an toàn cho mọi người. ', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (59, N'5 kinh nghiệm nhất định phải biết khi tìm thuê văn phòng
', CAST(N'2020-04-13T00:00:00.0000000' AS DateTime2), 9, N'Bất cứ doanh nghiệp nào cũng muốn thuê được một văn phòng làm việc ưng ý, giá cả phải chăng. Để đạt được điều đó, hãy ghi nhớ 5 kinh nghiệm tìm thuê văn phòng dưới đây:
1. Xem xét vị trí và diện tích văn phòng cho thuê
Vị trí
Một văn phòng lý tưởng thường phải hội tụ các yếu tố như sạch sẽ, ánh sáng đầy đủ, cảnh quan đẹp đẽ và đường phố thuận lợi cho giao thông. Tòa nhà đặt văn phòng cần có vị trí phù hợp với tính chất hoạt động kinh doanh của công ty, nhằm tạo hiệu quả cho việc quảng cáo và phát triển thương hiệu.

Ví dụ, văn phòng làm việc của một công ty chuyên về thời trang, mua sắm, giải trí… thì nên chọn khu vực đông đúc, nhiều cư dân. Ngược lại, nếu công ty thiên về ngành giáo dục, văn hóa, mỹ thuật… thì nên chọn khu vực có đường phố rộng thoáng, dân cư yên tĩnh, nhiều cảnh quan như sông hồ, khuôn viên xanh…

Ngoài ra, theo phong thủy, vị trí văn phòng nên tránh mặt trước/sau lưng là chợ búa, nơi đổ rác, ao tù nước đọng… Bởi những khu vực này dễ phát sinh uế khí, khiến công ty khó thành công về danh tiếng và hiệu quả kinh doanh. Diện tích
Thuê văn phòng không chỉ tính đến chuyện trước mắt mà còn phải xem xét xu hướng phát triển, quy mô mở rộng của công ty đó trong tương lai. Vì vậy, nên tìm thuê văn phòng có diện tích đáp ứng được yêu cầu về không gian làm việc cho công ty trong ít nhất là 2 năm tới. Thông thường, việc thuê officetel hay căn hộ chung cư để làm việc chỉ phù hợp với những công ty nhỏ, startup và ít thành viên. Còn những công ty có quy mô từ khoảng 20 người trở lên thì nên chọn thuê văn phòng ở các tòa nhà, cao ốc.

2. Cân nhắc giá văn phòng cho thuê
Thuê văn phòng sang trọng tại các tòa nhà hoành tráng, vị trí đắc địa luôn là sự lựa chọn hấp dẫn với các doanh nghiệp. Tuy nhiên, chi phí thuê văn phòng ở đó sẽ rất cao, nếu công ty không đủ tiềm lực tài chính sẽ dẫn đến gánh nặng về chi phí. Vì vậy, doanh nghiệp cần cân nhắc thật kỹ về giá cả cũng như khả năng chi trả trước khi quyết định thuê văn phòng.

Lưu ý, khi thuê văn phòng tại các tòa nhà, bên cạnh giá thuê hàng tháng phải thanh toán cho chủ đầu tư, doanh nghiệp còn phải trả phí dịch vụ nằm ngoài diện tích thuê như: Phí lễ tân, bảo vệ, dịch vụ vệ sinh, thang máy, điều hòa, đèn chiếu sáng…

3. Tìm hiểu về chủ đầu tư dự án cho thuê/ Người cho thuê
Để hạn chế tối đa rủi ro, chủ doanh nghiệp cần xem xét và tìm hiểu kỹ về sự uy tín và tin cậy của người cho thuê hoặc chủ đầu tư dự án cho thuê văn phòng. Việc xác định này có thể dựa trên các thông tin trên mạng, người quen, đồng thời cũng có thể đánh giá qua những dự án trước đây của chủ đầu tư đó. Lựa chọn một chủ đầu tư lớn, có uy tín trên thị trường sẽ đảm bảo cho bên thuê về vấn đề pháp lý cũng như chất lượng văn phòng.

4. Tiện ích tòa nhà/ khu vực xung quanh văn phòng cho thuê
Tiện ích nội khu: Xem xét chất lượng sử dụng của hệ thống điện, điều hòa, hệ thống camera, khu vực để xe…

Tiện ích ngoại khu: Xem xét môi trường xung quanh có đảm bảo vệ sinh sạch sẽ không, có tình trạng ngập úng không…

Bên cạnh đó, bên thuê cũng cần quan tâm đến vấn đề nội quy, giờ giấc làm việc của bên cho thuê. Nếu doanh nghiệp thuê biệt thự hay nhà riêng thì vấn đề này hoàn toàn thoải mái. Tuy nhiên nếu là tòa nhà cho thuê có quy định chỉ làm trong giờ hành chính từ thứ 2 đến thứ 7, thì khi công ty có tăng ca hoặc làm việc vào Chủ nhật, cần phải trao đổi rõ với bên quản lý tòa nhà. 5. Lưu ý khi ký hợp đồng thuê văn phòng
Khi ký kết hợp đồng thuê văn phòng, phải xem xét kỹ các điều khoản như số tiền đặt cọc, mức giá cho thuê, tiền thuê có tăng định kỳ không, nếu có thì tăng ở mức nào, trách nhiệm sửa chữa thiết bị như điều hòa, cửa kính thuộc về bên nào, thời hạn thuê kéo dài trong bao lâu, mức bồi thường là bao nhiêu nếu một trong hai bên chấm dứt hợp đồng thuê văn phòng trước thời hạn...

Về vấn đề đặt cọc, người thuê không nên đặt cọc giữ chỗ nếu chưa đàm phán hợp đồng. Sự vội vàng này có thể khiến khách thuê rơi vào thế yếu hơn trong cuộc đàm phán và thương lượng về các điều khoản cũng như giá cả. Tốt nhất hãy yêu cầu chủ đầu tư tòa nhà dự thảo hợp đồng và đàm phán mọi vấn đề về chi phí, khi đã thỏa thuận xong mới tiến hành đặt cọc.

', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (60, N'Officetel là gì? Có nên đầu tư căn hộ Officetel không?
', CAST(N'2020-03-13T00:00:00.0000000' AS DateTime2), 9, N'Officetel đang là một trong những mô hình bất động sản được giới đầu tư quan tâm. Dù đã xuất hiện từ lâu trên thế giới, nhưng Officetel đối với người Việt vẫn còn là thuật ngữ xa lạ. Vậy Officetel là gì? căn hộ Officetel có đặc điểm như thế nào? Mời độc giả tham khảo bài viết dưới đây để có thêm thông tin chi tiết.
1. Officetel là gì?
Officetel là thuật ngữ được ghép bởi 2 từ tiếng anh gốc là Office và Hotel. Mô hình này đang ngày càng trở nên phổ biến bởi vừa có đủ các tính năng văn phòng, vừa có đủ các tính năng của khách sạn và nhà ở. Nói một cách dễ hiểu hơn, đây vừa là nơi làm việc, vừa có thể cư trú. Sự ra đời của Officetel ít nhiều đã mang lại lợi ích về liên kết cộng đồng, khi giải quyết được vấn đề thương mại, dân cư với văn hóa và công nghiệp. Là mô hình hướng đến sự tiện nghi và hiện đại nên Officetel luôn tạo được cảm giác thoải mái, dễ chịu cho người sử dụng. Nó khác hẳn với sự gò bó, ngột ngạt như kiểu văn phòng truyền thống trước đây. Bạn có thể vừa làm việc, vừa thư giãn, giống như đang ở nhà.

Ngày nay, rất nhiều đối tượng khách hàng tìm đến Officetel, chủ yếu là những doanh nghiệp, công ty vừa và nhỏ, cần thuê không gian để làm việc. Họ thường đầu tư vào đây để sử dụng làm văn phòng đại diện hoặc triển khai kinh doanh kiếm lời. Nhìn chung, hầu hết các căn Officetel đều có khả năng đáp ứng được đầy đủ chức năng cho nhu cầu sống tiện nghi và làm việc thoải mái.  

2. Căn hộ Officetel là gì?
Khi tìm hiểu Officetel là gì, chúng ta thường được nghe đến cụm từ căn hộ Officetel. Vậy thực chất căn hộ Officetel là gì?

Căn Hộ Officetel sở hữu nhiều tính năng đa dạng và được biết đến như một loại hình căn hộ đa năng. Mô hình đã được tập đoàn Korea Development Corporation cho triển khai xây dựng vào những năm cuối thế kỷ 20 trong khuôn viên thành phố Seoul, thủ đô Hàn Quốc.

Nhận thấy những ưu điểm lớn của căn hộ Officetel trong quá trình hiện đại hóa, mô hình sau đó đã được nhân rộng. Không chỉ tại Hàn Quốc, các nước phát triển lân cận mà còn vang xa tới tận phương Tây. Dù đã xuất hiện rất lâu trên thị trường bất động sản thế giới, nhưng căn hộ Officetel chỉ mới được biết đến tại Việt Nam. Mỗi căn thường có diện tích không lớn, dao động trong khoảng từ 25 đến 50 mét vuông, nhưng lại đáp ứng được đầy đủ chức năng của một căn hộ và văn phòng. 3. Đặc điểm tiện ích và pháp lý của căn hộ Officetel?
Officetel đang ngày càng trở nên thu hút giới đầu tư nhờ sở hữu những đặc điểm nổi trội. Vì vậy, nếu đã tìm hiểu Officetel là gì, thì đừng bỏ qua những đặc điểm nổi bật của mô hình này ngay sau đây.

Đặc điểm về tiện ích của căn Officetel
Do ở mỗi quốc gia Officetel có những đặc thù riêng nên khi du nhập vào Việt Nam mô hình này cũng có những khác biệt.

- Tiện ích văn phòng mà các căn hộ Officetel tại Việt Nam sở hữu luôn đạt tiêu chuẩn chất lượng cao. Bao gồm thang máy, lối đi riêng, quầy lễ tân tiếp khách, khu vực bàn làm việc và bảng tên của công ty,…

- Không giới hạn giờ giao dịch khi người dùng đăng ký nghỉ ngơi qua đêm hay đăng ký tạm trú.

- Được sử dụng đa dạng tiện ích của toà nhà như hồ bơi, phòng sinh hoạt, phòng tập thể hình, hay khu vui chơi,...

- Diện tích tối thiểu của Officetel là 25m2, tối đa là 200m2. Nhìn chung, diện tích xây dựng còn phụ thuộc vào mục đích nhà nhu cầu sử dụng.

- Giá của một căn Officetel thường dao động trong khoảng từ 1,5 tỷ đến 3 tỷ đồng. Lãi suất cho thuê thường cao hơn các loại căn hộ khác. Đặc điểm pháp lý của Officetel
Cũng giống như một số nước đang phát triển, Nhà nước Việt Nam đã đưa ra một số giới hạn pháp lý đối với mô hình căn hộ Officetel. Vậy pháp lý của căn hộ Officetel là gì?

Theo đó, thời gian tối đa có thể sử dụng căn hộ này là 50 năm. Tuy nhiên, nếu công ty hay doanh nghiệp, chính xác hơn là chủ đầu tư vẫn muốn tiếp tục hoạt động, thì có thể gia hạn thêm thời gian sử dụng Officetel sau 50 năm.

Việc hạn chế sử dụng tối đa 50 năm trong pháp lý Officetel hoàn toàn không vô lý. Bởi hình thức sở hữu như thế có thể đảm bảo được quỹ đất, đồng thời đa dạng hóa các hình thức nhà ở trong tương lai. Hơn nữa, những dự án Officetel sau 50 năm chắc chắn sẽ xuống cấp hay thậm chí là tụt hậu. Nếu chủ đầu tư không có ý sửa chữa hay tiếp tục kinh doanh, thì việc chuyển nhượng là hoàn toàn hợp lý.

4. Mô hình Officetel được ưa chuộng do đâu?
Du nhập vào Việt Nam chưa lâu nhưng mô hình Officetel lại được nhiều khách hàng tìm đến để đầu tư. Bởi thực tế, họ nhận thấy căn hộ dịch vụ Officetel đáp ứng được nhiều nhu cầu cần thiết với người sử dụng. Bao gồm những tiện nghi hiện đại, tiện ích cao cấp, giá cả phải chăng. Trước hết, Officetel là mô hình bất động sản được đánh giá khá cao về vị trí cũng như tiện ích nó sở hữu. Bởi hầu hết các căn hộ này đều được xây dựng trong những khu chung cư tòa cao ốc. Đây đều là những khu vực có những tiện ích nội khu và ngoại khu cao cấp, mà người đang sống và làm việc tại Officetel cũng được cấp quyền sử dụng.

Officetel đa năng và không lạc hậu. Như đã đề cập ở trên, là mô hình kết hợp giữa nơi làm việc và nhà ở. Do vậy mà người sử dụng vừa có thể làm việc, lại vừa có thể nghỉ ngơi. Giá thành phải trả lại tương đối rẻ, phù hợp với nhiều đối tượng. Chủ đầu tư có thể là startup với 3 - 4 nhân viên, hay một công ty bất kỳ đang muốn tìm nơi đặt văn phòng đại diện.

Song, do Officetel thường sở hữu vị trí khá đẹp, giao thông thuận lợi, nên nhiều chủ đầu tư chọn đây là địa chỉ kinh doanh bất động sản kiếm lời lý tưởng. Đó cũng là lý do vì sao dự án căn hộ Officetel hiện đang được nhiều chủ đầu tư quan tâm.

5. Có nên đầu tư vào Officetel trong thời buổi hiện nay
Sau khi đã tìm hiểu căn hộ Officetel là gì và những đặc điểm, tiện ích mà nó mang lại, có thể hiểu vì sao mô hình bất động sản này lại nhận được nhiều sự quan tâm đến thế. Tuy nhiên, Officetel có thực sự là “gà đẻ trứng vàng” hay không? Có nên đầu tư vào Officetel ở thời điểm hiện tại?

Theo chuyên gia Bất Động Sản, căn hộ Officetel là dự án rất tiềm năm trong tương lai. Với lý do khởi đầu chính là thị trường Officetel vẫn chưa thực sự nhộn nhịp. Nhận thấy những lợi ích và sự tiện lợi, chắc hẳn trong tương lai sẽ có rất nhiều người chọn sử dụng căn hộ kiểu này. Họ sẽ không chỉ là một công ty hay doanh nghiệp cỡ vừa, mà họ có thể là một hộ gia đình có nhu cầu sinh sống. Bên cạnh đó, giá để sở hữu một căn hộ trong vòng 50 năm kiểu này lại rẻ hơn nhiều so với các căn hộ thông thường, từ 7% đến 10%. Chủ đầu tư cũng có thể cho thuê lại, vẫn đảm bảo sinh lời hiệu quả.

Bên cạnh nhu cầu trong nước, hiện nhiều nhóm người nước ngoài đang sinh sống tại Việt Nam cũng rất hứng thú với loại hình này. Và đây cũng là nguồn khách hàng tiềm năng của nhiều chủ đầu tư trong tương lai.

Dự án Officetel được giới chuyên gia nhận định rằng đang phát triển và sẽ tiếp tục nhận được nhiều sự quan tâm trong thời gian tới. Vì vậy, nếu đang có ý định mua bán, kinh doanh mô hình này thì bạn có thể cân nhắc để sớm đưa ra quyết định.

Tham khảo một số dự án căn hộ Officetel nổi bật tại Hà Nội và TP.HCM hiện nay đếu bạn đang có ý định mua bán, đầu tư vào mô hình này:

Một số dự án Officetel Hà Nội nổi bật:
 
Soho C2 D’Capitale, Trần Duy Hưng, Cầu Giấy.
Hongkong Tower, 243A Đê La Thành, Đống Đa.
Vinhomes Green Bay Mễ Trì, Đại Lộ Thăng Long, Nam Từ Liêm.
Vinhomes Sky lake Phạm Hùng, Mỹ Đình, Nam Từ Liêm.
Vinhomes Metropolis Liễu Giai, Liễu Giai, Ba Đình.
EcoLife Capitol, 58 Tố Hữu, Nam Từ Liêm.
The Lotus Center, Võ Chí Công, KĐT Ciputra, Tây Hồ.

Một số dự án Officetel TPHCM nổi bật:
 
Southgate Tower, đường Nguyễn Thị Thập, Phường Bình Thuận, Quận 7.
Sunrise Cityview quận 7, 33 Đường Nguyễn Hữu Thọ, Tân Hưng, Quận 7.
Căn hộ Rivergate, 151 Bến Vân Đồn, Quận 4.
Sky Center, Số 10 Phổ Quang, Phường 2, Quận Tân Bình.
The Sun Avenue, 62 Đường Mai Chí Thọ, An Phú, Quận 2.
căn hộ Masteri Millennium, 132 Bến Vân Đồn, Phường 6, Quận 4.
Madison Thi Sách, 15 Thi Sách, Bến Nghé, Quận 1.
Charmington La Pointe, 181 Cao Thắng, Phường 12, Quận 10.
Orchard Garden, 128 Hồng Hà, Phường 9, Phú Nhuận
Centana Thủ Thiêm, đường Mai Chí Thọ, Phường An Phú, Quận 2
Officetel là gì hay căn Officetel là gì và những điểm nổi bật đã được Batdongsan.com.vn được giải đáp trong bài viết trên đây. Hy vọng với những thông tin trên, bạn sẽ có cái nhìn toàn diện và đa chiều hơn về loại hình bất động sản này.', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (61, N'4 sai lầm phổ biến khiến nhà đầu tư BĐS “ném tiền qua cửa sổ”
', CAST(N'2020-03-19T00:00:00.0000000' AS DateTime2), 9, N'“Rót tiền” vào bất động sản được xem là kênh đầu tư thông minh, sinh lời hấp dẫn; tuy nhiên phải đúng cách, đúng thời điểm nếu không muốn “tiền mất tật mang”. Dưới đây là 4 sai lầm phổ biến mà nhiều nhà đầu tư thường mắc phải khi bỏ vốn vào thị trường đầy hứa hẹn này.
1. Mơ hồ về thị trường

Việc cho rằng người khác kiếm được lợi nhuận thì mình cũng có thể “hái ra tiền” từ bất động sản mà không cần kiến thức là suy nghĩ hoàn toàn sai lầm. Dù không có kinh nghiệm nhưng trước khi “rót tiền” vào lĩnh vực này, nhà đầu tư cần phải nắm được các kiến thức cơ bản như: Pháp lý nhà, đất; giá cả, xu hướng thị trường; rủi ro tiềm ẩn... Những kiến thức này có thể giúp nhà đầu tư tự đánh giá sản phẩm bất động sản và đưa ra quyết định đúng đắn hơn, thay vì chỉ nghe theo lời giới thiệu từ chủ đầu tư hay môi giới dự án.

Học hỏi kinh nghiệm từ người đi trước hoặc nhờ đến sự tư vấn của luật sư (đối với vấn đề pháp lý), môi giới bất động sản (vấn đề về giá cả, thị trường) cũng là một cách để nhà đầu tư nghiệp dư yên tâm hơn về tính an toàn và khả năng sinh lời của giao dịch. 2. Quá phụ thuộc vào đòn bẩy tài chính

Đòn bẩy tài chính là việc nhà đầu tư thế chấp bất động sản của mình để vay tiền, mua thêm nhà đất khác, và cứ thế lặp lại quá trình này liên tiếp. Về lý thuyết, cách đầu tư này rất hấp dẫn song trên thực tế, việc sử dụng đòn bẩy tài chính chỉ hiệu quả khi nhà đầu tư chọn đúng sản phẩm bất động sản. Nếu rót vốn “nhầm” vào những bất động sản thanh khoản kém, ít giá trị, nhà đầu tư rất dễ bị mắc kẹt, thậm chí vỡ nợ vì tài sản mất giá, khó bán ra nhưng tiền nợ, lãi ngân hàng vẫn phải trả đều.

Để không quá phụ thuộc vào đòn bẩy tài chính dẫn đến “tiền mất tật mang”, nhà đầu tư nên lưu ý quy tắc 50%, nghĩa là tiền vay không vượt quá 50% giá sản phẩm và tiền trả hàng tháng không vượt quá 50% tổng thu nhập. Ngoài ra, nhà đầu tư cần phải sáng suốt lựa chọn sản phẩm bất động sản tiềm năng, nên nhờ đến sự tư vấn của chuyên gia, môi giới bất động sản hoặc những người có kinh nghiệm để đưa ra những quyết định đầu tư phù hợp, hiệu quả nhất. 

3. Đầu tư theo đám đông

Không ít nhà đầu tư mỏng vốn, non kinh nghiệm hay thiếu kiến thức thị trường nhưng vẫn liều lĩnh chạy theo đám đông với mong muốn nhanh có lãi. Nhóm đầu tư này thường đổ vốn vào những khu vực có đông người mua bán, với suy nghĩ nếu không có lợi sao người khác lại đổ xô vào thị trường này. Trước những lời quảng cáo như “rót mật vào tai”, thậm chí là luồng thông tin truyền miệng thổi phồng thị trường, “bánh vẽ” về sản phẩm bất động sản, họ đều dễ dàng tin ngay. Cách đưa ra quyết định đầu tư này hoàn toàn dựa trên cảm tính nhất thời thay vì phân tích và đánh giá cụ thể.

Nhưng trên thực tế, rất nhiều nhà đầu tư đã phải “ngậm trái đắng” vì chạy theo tâm lý đám đông. Ông Nguyễn Lộc Hạnh, Tổng giám đốc Công ty CP Đầu tư Bất động sản Ngọc Châu Á cho rằng khi thị trường nóng sốt, có thể xuất hiện cùng lúc nhiều nhà đầu tư chạy theo đám đông. Tuy nhiên, sau đợt tăng nóng và sốt đất, thị trường sẽ dần đào thải những nhà đầu tư cảm tính này. Do vậy, thay vì vội vàng chạy theo đám đông, nhà đầu tư cần tham khảo thông tin một cách sáng suốt bởi không phải dữ liệu nào cũng chính xác và phản ánh đúng tình hình thị trường. 4. Tâm lý “được ăn cả ngã về không”

Dồn hết tiền vào một chỗ là cách đầu tư rất mạo hiểm dễ khiến nhà đầu tư mất tiền oan. Bởi lẽ giao dịch bất động sản thường có giá trị lớn, nếu nhà đầu tư “đặt hết trứng vào một giỏ” với tâm lý “được ăn cả ngã về không”, thì khi gặp biến cố bất ngờ hoặc đúng thời điểm thị trường khó khăn sẽ không kịp xoay sở.

Thay vì dồn hết tiền vào một chỗ, nhà đầu tư nên phân tán ngân sách vào nhiều danh mục đầu tư, đa dạng hóa loại hình/ phân khúc/ khu vực bất động sản để giảm thiểu rủi ro. Trong đó, cần xác định 1 – 2 danh mục chủ đạo, có tiềm năng sinh lời hiệu quả nhất để ưu tiên dòng tiền. Đừng quên lập kế hoạch chi tiết để xác định kỳ vọng lợi nhuận mà dòng sản phẩm mang lại, nguồn tài chính dành cho dòng sản phẩm này cũng như mức độ chịu đựng rủi ro có thể xảy ra để luôn chủ động trong mọi tình huống.

', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (62, N'Đất nền là gì? Loại đất nền nào nhà đầu tư nên “né”
 ', CAST(N'2020-04-29T00:00:00.0000000' AS DateTime2), 9, N'Dù không còn xa lạ đối với dân chuyên, nhưng nhiều nhà đầu tư bất động sản mới vào nghề vẫn còn bỡ ngỡ với khái niệm đất nền. Vậy, đất nền là gì? Loại đất nền nào nên tránh đầu tư? Bài viết dưới đây sẽ giải thích các khái niệm liên quan và liệt kê các loại đất nền, giúp nhà đầu tư có được định hướng tốt nhất.
1. Đất nền là gì? Các loại đất nền thường gặp
Đất nền là gì? Có phải đơn giản chỉ là kênh đầu tư có lời hấp dẫn. Để tránh mắc phải những sai lầm, cùng chúng tôi tìm hiểu khái niệm đất nền và các loại đất nền thường gặp.

Khái niệm đất nền
Đất nền là những lô đất nguyên vẹn, chưa có bất kỳ sự tác động nào từ con người như: đào bới, san lấp hay khởi công xây dựng,... Điều này có nghĩa là, đất nền là đất được giữ nguyên hiện trạng ban đầu và đất đã xây nhà thì sẽ không còn được gọi là đất nền nữa. Các loại đất nền thường gặp và đặc điểm
Đất nền thường có rất nhiều loại, tùy vào mục đích sử dụng mà người ta phân chia. Trong đó, có 3 loại đất nền mà chúng ta thường gặp, đó là đất nền dự án, đất nền thổ cư và đất nền liền kề.

Đất nền dự án là gì?
Đất nền dự án là những lô đất nằm trong một dự án đang được quy hoạch. Những lô đất này vẫn giữ nguyên hiện trạng và chưa chịu tác động từ con người. Đất nền dự án thường được sử dụng trong các dự án xây dựng quy mô lớn với nhiều tiện ích bao quanh. Đó có thể là khu dân cư, các dự án nhà ở, công ty, nhà xưởng, văn phòng hay khu sinh thái.

Đến đây, nhiều người thường thắc mắc quy hoạch đất ở dự án là gì? Dựa trên khái niệm về đất nền dự án mà người ta xác định được quy hoạch đất ở dự án là gì. Theo đó, các khu đất trong dự án thường được quy hoạch một cách minh bạch, công khai. Chủ đầu tư sẽ là người đứng ra chịu toàn bộ trách nhiệm nếu xảy ra tình trạng phải đền bù. Đất nền thổ cư là gì?
Đất thổ cư là đất được khai thác để ở. Đây là loại đất thuộc nhóm đất phi nông nghiệp, thường xuất hiện ở rất nhiều nơi, từ nông thôn đến thành thị.

Đất nền thổ cư thường được dùng để xây nhà, xây vườn gắn với nhà, hoặc các công trình phúc lợi xã hội. Đất nền liền kề là gì?
Đất nền liền kề là những lô đất, mảnh đất nằm trong cùng một khu vực thi công dự án. Chúng thường có diện tích tương đương nhau, nằm gần nhau với một kết cấu nhất định.

Cách phân biệt đất nền dự án, đất nền thổ cư, đất nền liền kề
Người ta thường phân biệt đất nền dự án, đất nền thổ cư, đất nền liền kề bằng 2 yếu tố sau:

Tính pháp lý
Xét về góc độ pháp lý, 3 loại đất nền đều có những sự khác biệt nhất định:

- Đất nền dự án: Là loại đất được quy hoạch một cách minh bạch, công khai, sau khi có sự kiểm tra và cấp phép từ các đơn vị chức năng, cơ quan nhà nước.

- Đất nền thổ cư: Trái với đất nền dự án, tính pháp lý của đất nền thổ cư thường tiềm ẩn rủi ro. Bởi trong nhiều trường hợp, các mảnh đất thường chỉ có giấy ký kết giữa 2 bên, mà không được kiểm chứng và cấp phép bởi cơ quan chức năng. Những mảnh đất không có giấy tờ như thế sẽ gây khó dễ cho việc sở hữu, mua bán hoặc trao đổi trong tương lai.

- Đất nền liền kề: Tương tự như đất nền dự án, đất nền liền kề được phân lô, phân khu một cách rõ ràng, minh bạch, có giấy phép đến từ các đơn vị chức năng, có sổ đỏ,....

Tiện ích sử dụng
Bên cạnh tính pháp lý, thì một trong những yếu tố khác có thể giúp phân biệt 3 loại đất nền này chính là những tiện ích sử dụng:

- Đất nền dự án: Đây là mô hình được bao quanh bởi nhiều tiện ích. Các nhà đầu tư không chỉ chú trọng đầu tư và phát triển hệ thống cơ sở hạ tầng như hệ thống điện nước, phòng cháy chữa cháy,... mà còn chú trọng tới hệ thống tiện ích như: trường học, trung tâm thương mại, công viên,...

- Đất nền thổ cư: Vì chủ yếu là đất để xây nhà ở với quy mô nhỏ, nên nhà đầu tư thường không quá chú trọng vào hệ thống tiện ích xung quanh.

- Đất nền liền kề: Giống như đất nền dự án, đất nền liền kề cũng là loại đất được chủ đầu tư chú trọng về hệ thống tiện ích như: trung tâm thương mại, bệnh viện, trường học, hệ thống giao thông,...

Nắm được đất nền là gì và các thông tin liên quan là cần thiết, giúp nhà đầu tư có được định hướng khi lựa chọn. Tuy nhiên, liệu có phải loại đất nền nào cũng có thể đầu tư sinh lời? Batdongsan.com.vn sẽ phân tích về vấn đề này ở phần tiếp theo của bài viết.

2. Loại đất nền nào tuyệt đối nên tránh khi đầu tư bất động sản
Để không đầu tư nhầm chỗ, tiền mất tật mang thì nhà đầu tư cần phân biệt được bốn loại đất nền cần tránh. Bao gồm:

Đất nền dự án ma
Dự án ma là thuật ngữ không quá xa lạ trong giới đầu tư bất động sản. Thuật ngữ này dùng để chỉ các dự án hoàn toàn ảo, không có thật và đặc biệt không tồn tại trên pháp lý. Trên thực tế đây chỉ là một chiêu trò dụ dỗ khách hàng bỏ tiền mua dự án mà chính nhà đầu tư hay “cò” đất vẽ lên để chiếm đoạt tiền cọc. Tuy nhiên, những dự án này thường không có giấy phép hay bất cứ một loại giấy tờ gì liên quan đến mặt pháp lý, nên người mua cần tìm hiểu thật kỹ. Người mua cũng có thể chủ động tìm đến vị trí khu đất để thăm dò.

Đất nền phân lô nhưng chưa được cấp phép
Đất nền chưa phân lô thường mang đến nhiều rủi ro cho người mua. Đối với những khách hàng mua đất để đầu tư kinh doanh, thì đất nền theo kiểu này rất khó bán, chưa kể thường hay bị kẹt vốn không kiếm được lời. Đối với những khách hàng mua nhà ở thực, sẽ không được sở hữu sổ đỏ. Như vậy, rủi ro khi mua phải đất nền chưa phân lô là tương đối lớn.

Vì vậy để đảm bảo được quyền lợi của người mua, nên chọn đất nền đã có sổ đỏ (giấy chứng nhận quyền sử dụng đất). Có như vậy khi xảy ra tranh chấp hay thu hồi thì người mua sẽ được đền bù.

Đất nền đang bị cầm cố ngân hàng bởi chủ đầu tư
Nhiều nhà đầu tư đã phải ngậm ngùi cay đắng khi mua về những lô đất này. Bởi sổ đỏ thì đã bị người bán cầm cố, xây nhà hay sang nhượng cũng bây giờ thì chẳng có quyền. Tuy nhiên, đấy chỉ là điều đáng lo, quan trọng hơn nếu chủ đầu tư phá sản hay ngân hàng phát mãi đất nền, thì còn là đáng tiếc. Nhà đầu tư chắc chắn sẽ ra về tay không, không có lời, lại chẳng có cả vốn.

 Đất nền được thanh lý giá rẻ
Nhiều sàn môi giới nhỏ lẻ hay cá nhân đã lợi dụng lòng tin đối với khách hàng bằng cách đánh vào tâm lý giá rẻ để thu hút khách tìm mua. Tuy nhiên, trên thực tế các loại đất này thường nằm ở những nơi xa xôi hẻo lánh, chưa kể đến việc bị dính tranh chấp, nên bạn có thể mất trắng nếu không thận trọng.

3. Những lưu ý khi đầu tư đất nền
Ngoài việc tìm hiểu đất nền là gì, nếu đang có ý định tìm mua loại bất động sản này thì bạn cũng cần nắm được những lưu ý dưới đây.

Quan tâm đến chủ đầu tư của dự án đất nền
Đừng phớt lờ hay nghe chiêu trò dụ dỗ của bất kỳ ai, mà không tìm hiểu kỹ chủ đầu tư đó như thế nào. Trên thị trường có rất nhiều nguồn thông tin khác nhau nhưng đa phần không rõ ràng, thông tin ảo, không có thật,... Để chắc chắn hơn thì bạn cần tìm hiểu tính khả thi và năng lực hoàn thiện của chủ dự án.

Hãy bắt đầu từ việc chọn lựa chủ đầu tư uy tín: có tiểu sử tốt, thành tích làm việc tốt, và tiềm lực tài chính dồi dào. Bạn nên tham khảo dự án đã được triển khai trước đây để có định hướng tốt hơn.

Thủ tục, giấy tờ, hồ sơ pháp lý của đất nền
Bên cạnh việc phải lựa một chủ đầu tư uy tín, thì điều quan trọng tiếp theo chính là tính pháp lý của đất nền. Trước khi mua phần đất nào, bạn cần chắc chắn rằng đã có quyết định giao đất của các cơ quan có thẩm quyền và được phê duyệt quy hoạch.

Tìm hiểu kỹ hồ sơ pháp lý trước khi chọn mua đất nền
Để an toàn trong quá trình sở hữu thì bạn nên chọn mua những khu đất đã có sổ đỏ. Nếu xảy ra tranh chấp hay thu hồi, thì bạn cũng sẽ có lợi từ công tác đền bù.

Hồ sơ pháp lý của đất nền dự án thường bao gồm:

Các văn bản chứng minh khu đất nền đã được giao đất bởi các cơ quan nhà nước có thẩm quyền.
Giấy tờ chứng minh chủ đầu tư đã được cấp sổ đỏ cho khu đất nền đó.
Văn bản thỏa thuận địa điểm quy hoạch dự án được cấp bởi phòng kiến trúc sư trưởng.
Nếu trong trường hợp phải đem bu thì cần có chứng minh lô đất nền đã hoàn tất giải tỏa đền bù.
Một số giấy tờ có trong hồ sơ chấp thuận của UBND quận, huyện chuyển tới văn phòng kiến trúc sư trưởng. Kèm theo văn bản kiến trúc sư.

Xem xét kỹ hợp đồng và tiến độ thanh toán
Thời gian để mua đất nền với giá tốt đến trực tiếp từ chủ đầu tư khoảng từ 2 đến 3 năm. Đây thực chất là một quãng thời gian khá dài vì vậy mà nhiều người thường mua đất nền qua trung tâm sẽ nhanh gọn hơn. Nếu như bạn ở trong trường hợp này thì cần phải lưu ý về hợp đồng giá cả và tiến độ thanh toán.

Trước hết bạn cần xem xét kỹ lưỡng những thông tin có trong hợp đồng, để tránh xảy ra những tranh chấp bất đồng sau này. Để ý đến những cam kết về tiến độ xây dựng, thanh toán của dự án, để có thể khởi kiện khi chủ đầu tư không thực hiện đúng.

4. Đất nền thương mại là gì?
Ngày nay, nhiều nhà đầu tư thường rót tiền vào các dự án đất nền thương mại. Vậy đất nền thương mại là gì? Đất nền thương mại thực chất là các lô đất thuộc nhóm phi nông nghiệp, được sử dụng để xây dựng các cơ sở kinh doanh thương mại, hoắc các công trình phục vụ cho quá trình kinh doanh thương mại. Những mảnh đất này hiện được ví như “gà đẻ trứng vàng”, có thể giúp nhà đầu tư kiếm lời nhanh chóng. Lý do khá đơn giản, bởi đất nền thương mại thường được tọa lạc ở các khu vực giao thông thuận tiện nên thu hút được nhiều đầu tư. Bên cạnh đó, khoản vốn để rót vào đầu tư lại thấp nhưng tốc độ giá tăng lại rất nhanh. Do vậy mà đất nền thương mại thường mang lại nhiều nguồn lợi nhuận hấp dẫn cho nhà đầu tư.

Không chỉ riêng đất nền thương mại, thực tế các loại đất nền nói chung hiện đang là phân khúc hái ra tiền trong năm nay và các năm sau nữa. Đặc biệt là ở các khu vực ven thành phố Hồ Chí Minh, các huyện lên quận ở thành phố Hà Nội, và các khu vực có thị trường nghỉ dưỡng mới. Như vậy, đầu tư kiếm lời bằng đất nền không khó, nhưng các nhà đầu tư phải biết tận dụng thời cơ và nắm bắt được thị trường.

Hy vọng bài viết trên đã giúp các nhà đầu tư mới nắm được khái niệm đất nền là gì, đặc trưng cơ bản của các loại đất nền và những lưu ý khi đầu tư. Ngoài ra, nhà đầu tư cũng cần tìm hiểu thêm các khái niệm về bất động sản khác để có thể nhìn nhận, đánh giá khách quan về thị trường trước khi đưa ra quyết định. ', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (63, N'Tất tần tật những điều cần biết khi ký gửi nhà đất
', CAST(N'2020-03-03T00:00:00.0000000' AS DateTime2), 9, N'Do thiếu kinh nghiệm giao dịch nên nhiều người có bất động sản muốn cho thuê hoặc bán nhưng không biết thực hiện như thế nào. Gỡ rối khúc mắc này, dịch vụ ký gửi nhà đất ra đời như một hình thức môi giới giúp cho bên mua và bên bán có thể kết nối với nhau và giao dịch một cách nhanh chóng, dễ dàng hơn.
1. Lợi ích khi ký gửi nhà đất 
Ký gửi nhà đất là việc các cá nhân, đơn vị hay tổ chức gửi bán nhà đất tại nơi có khả năng quảng cáo, phân phối và bán giúp sản phẩm này. Hình thức ký gửi nhà đất đóng vai trò như một cầu nối trung gian, đưa những sản phẩm bất động sản lên sàn giao dịch, qua đó giúp mua bán diễn ra thuận lợi, nhanh chóng và dễ dàng hơn.

Bên ký gửi thông qua dịch vụ này sẽ tìm được khách hàng phù hợp. Người mua, người thuê sẽ được tư vấn và tìm được nhà, đất hợp ý. Đồng thời, nhận ký gửi cũng thu được tiền hoa hồng. Đây là một dịch vụ bất động sản tất cả các bên từ người ký gửi, bên nhận ký gửi và cả khách hàng mua nhà đất cùng có lợi.

Một số dịch vụ nhận ký gửi nhà đất còn hỗ trợ bên bán và bên mua về thủ tục, giấy tờ pháp lý để giao dịch diễn ra nhanh chóng và thuận lợi hơn. Điều này đặc biệt cần thiết với những người không rành hay có kinh nghiệm giao dịch bất động sản. 

 2. Thủ tục ký gửi nhà đất 
Mỗi công ty, sàn giao dịch bất động sản sẽ có những quy định và thủ tục ký gửi nhà đất khác nhau, tuy nhiên, khách hàng đều cần phải chuẩn bị những giấy tờ sau: 

- Hồ sơ liên quan đến bất động sản: Giấy chứng nhận quyền sở hữu (sổ đỏ, sổ hồng), địa chỉ, loại bất động sản (nhà riêng, biệt thự, chung cư, đất dự án, đất nền…), diện tích, vị trí, giá cả,… 

- Hồ sơ liên quan đến chủ bất động sản: Chứng minh thư nhân dân, sổ hộ khẩu…

Sau khi tiếp nhận những thông tin trên của khách hàng, bên nhận ký gửi sẽ tiến hành xem xét, tư vấn giá trị giao dịch và thỏa thuận hợp đồng ký gửi nhà đất giữa 2 bên. Nội dung hợp đồng sẽ bao gồm những cam kết về công việc, thời gian, hoa hồng môi giới nhà đất và phí môi giới bán nhà, cho thuê nhà đầy đủ. Nếu chấp thuận thỏa thuận thì bên ký gửi và bên nhận sẽ cùng ký tên và mỗi bên giữ 1 bản hợp đồng này. 

3. Lưu ý khi ký gửi nhà đất
• Chọn nơi ký gửi uy tín

Điều quan trọng nhất khi mua bán, thuê và cho thuê bất động sản thông qua hình thức ký gửi nhà đất đó là bạn phải chọn được nơi ký gửi uy tín, hoạt động chuyên nghiệp và có ký kết hợp đồng rõ ràng. Để biết được dịch vụ kí gửi nhà đất nào uy tín và hiệu quả nhất bạn cần lưu ý một số điểm như: 

- Không nâng kế giá bán sai lệch so với khi thỏa thuận với người ký gửi và so với giá trị của bất động sản
- Không bao giờ nhận kí gửi những sản phẩm bất động sản có pháp lí chưa rõ ràng, hoặc những dự án không đầy đủ giấy tờ
- Không nhận kí gửi hoặc mua bán qua dịch vụ trung gian nào khác
- Không gây khó dễ với khách hàng để giảm giá thành sản phẩm nhằm trục lợi

Ngoài ra, để tìm hiểu xem công ty nhận ký gửi nhà đất đó có uy tín hay không, bạn có thể xem xét đến các yếu tố: Công ty có tuổi đời lâu năm chưa? Có thể hiện sự chuyên nghiệp và đạo đức kinh doanh khi giao dịch với khách hàng không? Truyền thông và những khách hàng đã từng trải nghiệm dịch vụ ở công ty đó như thế nào?...

 ắm rõ thủ tục và lường trước rủi ro tiềm ẩn

Hầu hết việc mua bán bất động sản qua dịch vụ ký gửi khá an toàn do có ký kết hợp đồng và rõ ràng về thông tin giao dịch. Tuy nhiên, khách hàng lưu ý phân biệt giữa ký gửi nhà đất qua công ty môi giới với “ký gửi, ký chờ” nhà đất với các cá nhân, tổ chức không được cấp quyền thực nhận ký gửi. Khi đó, việc ký gửi nhà đất sẽ là trái pháp luật và tiềm ẩn rất nhiều rủi ro.

Theo đó, người mua và người bán đất sẽ cùng đến văn phòng công chứng để làm thủ tục công chứng, nhưng thỏa thuận với công chứng viên làm hồ sơ chỉ có chữ ký của người bán rồi đem gửi tại tổ chức hành nghề công chứng. Hồ sơ này không được vào sổ, không lưu trữ vào hệ thống dữ liệu giao dịch của các tổ chức hành nghề công chứng. Đất sẽ được mua bán quay vòng nhiều lần cho đến khi người cuối cùng mua đất thực hiện thủ tục sang tên tại Chi nhánh Văn phòng Đăng ký đất đai các quận, huyện.

Như vậy, thuế thu nhập cá nhân và thuế trước bạ sẽ chỉ tính một lần, người mua ở giữa sẽ không phải chịu tiền thuế trước bạ cũng như tiền thuế thu nhập cá nhân khi bán lại mảnh đất ấy. 

Mặc dù giúp người bán và mua có thể lách một phần tiền thuế, song những cuộc mua bán này chỉ thực hiện giao ước bằng niềm tin, giấy tờ công chứng chỉ có chữ ký của người bán nên nếu xảy ra rủi ro thì bên mua hoàn toàn không nhận được sự bảo vệ của pháp luật.

• Tìm hiểu kỹ về phí dịch vụ

Thông tin về chi phí phải trả khi ký gửi nhà đất phải được thỏa thuận và quy định rõ ràng trong hợp đồng giữa bên ký gửi và bên nhận ký gửi. Chi phí này phụ thuộc vào thỏa thuận trong hợp đồng ký gửi bất động sản, tuy nhiên bạn cũng cần lưu ý một số chi phí phát sinh khi sử dụng dịch vụ nhận ký gửi nhà đất như: Hoa hồng cho môi giới nhà đất, phí môi giới bán nhà, cho thuê nhà…

Trong quá trình giao dịch ký gửi nhà đất, bên nhận ký gửi có quyền yêu cầu khách hàng cung cấp hồ sơ, thông tin về bất động sản để đưa lên sàn giao dịch; từ chối nhận ký gửi bất động sản không đủ điều kiện và yêu cầu khách hàng bồi thường thiệt hại do lỗi mà khách hàng gây ra.

Về phía khách hàng, trong quá trình ký gửi có quyền đề nghị dừng giao dịch nếu phát hiện sự cố bất trắc do lỗi của bên nhận ký gửi, hoặc nhận thấy không minh bạch thông tin. Khách hàng cũng có quyền khiếu nại nếu bên nhận ký gửi tự ý đổi giá sản phẩm khác với thỏa thuận để ăn chênh lệch. ', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (64, N'Có nên bán nhà đang ở trước khi tìm được nhà mới?
', CAST(N'2020-01-12T00:00:00.0000000' AS DateTime2), 13, N'Đa số những người muốn đổi nhà thường tiến hành song song việc bán nhà cũ và mua nhà mới, tạo thành chuỗi giao dịch bất động sản. Tuy nhiên, cũng có những người chấp nhận rủi ro, bán nhà đang ở trước khi tìm thấy nhà mới muốn mua và được hưởng những lợi thế bất ngờ.
Cùng đặt lên bàn cân những ưu và nhược điểm của việc bán nhà trước khi tìm được nhà mới để xem liệu phương án này có phù hợp với kế hoạch đổi nhà của bạn hay không nhé!

Ưu điểm

Bạn có được vị thế mạnh mẽ hơn khi mua nhà mới. Trong hầu hết trường hợp, người bán căn nhà mà bạn muốn mua chắc chắn sẽ thích bán nhà cho người mua đang có sẵn tiền trong tay và có thể thanh toán luôn. So với những người cũng quan tâm đến ngôi nhà nhưng còn phải chờ bán nhà của họ để gom tiền hay vay ngân hàng, bạn dễ được người bán “chấm điểm” cao hơn. 

Bạn kiểm soát việc bán nhà tốt hơn. Do không chịu áp lực phải bán nhanh để kịp trả tiền mua nhà mới đã đặt cọc hoặc thực hiện các thỏa thuận thanh toán khác, bạn sẽ có lợi thế hơn khi bán nhà cũ, có thể kiên nhẫn chờ bán được với mức giá mong muốn thay vì chấp nhận bán rẻ.

Kinh nghiệm bán nhà Bạn biết chính xác số tiền mình có từ việc bán nhà, từ đó có thể cân nhắc chọn mua nhà mới phù hợp với tình hình tài chính của mình. Nhiều người đặt cọc mua nhà mới rồi vội vàng bán nhà cũ nhưng số tiền thu được không như mong đợi, phải gấp rút tính phương án huy động thêm tiền để trả cho người bán nhà mới.   

Bạn có thể mua được nhà với giá hời trong trường hợp may mắn bán nhà cũ khi được giá và tìm được nhà mới ưng ý khi thị trường nhà đất “hạ nhiệt”, giảm giá. Ngoài ra, bạn cũng có thể thỏa thuận được giá tốt hơn nếu tìm thấy một người bán đang muốn bán nhanh để mua nhà khác, trong khi bạn không vội vàng gì.

Nhược điểm

Bạn có thể phải thuê nhà trong thời gian dài nếu không tìm được nhà mới ưng ý. Ngôi nhà cũ đã bán nên bạn bắt buộc phải tìm chỗ ở tạm thời trong thời gian chờ mua nhà mới. Thời gian này có thể kéo dài hơn dự kiến nếu việc tìm nhà không thuận lợi, hoặc bạn đã mua được nhà mới nhưng cần thời gian cải tạo, sửa chữa. Việc thuê nhà thông thường đã có thể khiến bạn không thoải mái, nếu phải chịu thêm áp lực phải sớm mua được nhà mới, bạn dễ bị căng thẳng, mệt mỏi hơn. Thêm vào đó, tiền thuê nhà cũng sẽ “ngốn” của bạn một khoản kha khá.  Tiền bán nhà có thể bị mất giá vì tình trạng lạm phát hoặc thị trường bất động sản nơi bạn ở đang trong thời kỳ “sốt” giá. Khi đó, giá nhà sẽ tăng nhanh, số tiền bạn thu về từ ngôi nhà đã bán có thể không đủ để mua nhà mới như tính toán trước đó. Tiền thuê nhà cũng theo đà tăng lên, khiến bạn mất thêm tiền trong khi ngôi nhà mới vẫn chưa thấy đâu. 

Một số lưu ý khi bán nhà trước khi mua nhà mới

Nếu bạn quyết định sẽ bán nhà đang ở trước khi mua nhà mới, hãy tham khảo những lưu ý dưới đây để quá trình bán-mua diễn ra suôn sẻ nhất có thể và hạn chế rủi ro: 

Khảo sát, nghiên cứu kĩ lưỡng trước khi quyết định bạn bán nhà. Dù chưa chốt được ngôi nhà cụ thể, ít nhất bạn phải quyết định xong khu vực, loại nhà, diện tích, khoảng giá mà bạn muốn mua. Bạn cũng cần tìm hiểu các gói vay mua nhà và chọn được phương án phù hợp để khi tìm thấy ngôi nhà ưng ý là tiến hành mua ngay.

Quyết định xem bạn sẽ tự bán hay nhờ môi giới. Khi bạn đã sẵn sàng bán nhà và quyết định mức giá mong muốn, bạn có thể nhờ đến sự trợ giúp của các môi giới, đại lý bất động sản để bán nhà nhanh hơn. Nếu muốn tiết kiệm chi phí và tự tin vào bản thân, bạn có thể tự bán nhà thông qua các trang tin rao bất động sản trực tuyến như Batdongsan.com.vn, kết hợp với các kênh truyền thông xã hội để mở rộng phạm vi tìm kiếm người mua tiềm năng. 

Thường xuyên theo dõi thị trường bất động sản trong khi quá trình bán nhà để kịp chớp thời cơ khi ngôi nhà “trong mơ” của bạn xuất hiện.  

Làm chậm quá trình bán nhà, ví dụ như đồng ý thỏa thuận một khoảng thời gian tương đối dài cho người mua chuẩn bị tiền thanh toán sau khi đã đặt cọc. Trong thời gian này, bạn có thêm cơ hội sớm tìm thấy ngôi nhà mới ưng ý để tiến hành mua.  ', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (65, N'Hẻm nhỏ xây nhà hoành tráng: Ở không được bán không xong
', CAST(N'2020-01-14T00:00:00.0000000' AS DateTime2), 13, N'Nhà trong hẻm nhỏ thường có giá mềm hơn so với những ngôi nhà mặt ngõ hoặc trong ngõ to. Những người tài chính eo hẹp thường chọn loại tài sản này vì phù hợp túi tiền. Ngược lại có những người đủ tài chính vẫn ham rẻ mua nhà lớn trong ngõ nhỏ, hậu quả là ở không được bán không xong.
Ở không được bán không xong
Cách đây hơn chục năm, bố mẹ chồng chị Vân mua một mảnh đất hơn 60m2 nằm trong hẻm nhỏ ở quận Thanh Xuân. Bố mẹ chị kể khi đó nhà cửa còn khá thưa, xung quanh thoáng đãng. Ông bà tính lâu dài, chia khu đất làm hai phần, xây 2 ngôi nhà 4 tầng, mỗi căn khoảng 30m2, chừa một khoảng sân nhỏ phía trước làm chỗ dắt xe vào nhà. Ông bà có hai người con là chồng chị Vân và một chị gái nên chỉ ở hết một ngôi nhà, căn còn lại cho thuê.

Lúc chị Vân về ở thì chị gái cũng đi lấy chồng nên hai vợ chồng chị ở cùng ông bà. Đang quen ở chung cư rộng rãi, chị Vân thấy rất bức bí với ngôi nhà 4 tầng, chỉ đi lên đi xuống và lau dọn cũng đủ mệt. Ngại nhất là nhà nằm trong con ngõ nhỏ xíu, ra vào rất bất tiện, lại vướng cột điện, dây nhợ, hàng xóm đua ra phía trước khiến không gian sống rất ngột ngạt.

Mấy năm nay ngôi nhà đã xuống cấp nhưng gia đình chị Vân muốn xây mới cũng dở. Ngõ vào quá nhỏ, nếu muốn xây dựng phải đổ nguyên liệu ở tít phía ngoài nhà văn hóa thôn, đêm sẽ dùng xe nhỏ chở vào, chi phí thuê nhân công rất tốn kém.

 Chị Vân từng bàn với ông bà bán cả 2 nhà mua chỗ khác có diện tích nhỏ hơn, ngõ to hơn để thuận tiện sinh hoạt và xây sửa nếu cần. Tuy nhiên, dù nhiều lần rao bán nhưng đều không thành công. Người trả rẻ quá, người chê nhà xuống cấp, tốn kém chi phí xây lại. Nếu bán lẻ từng ngôi nhà cũng không ai muốn mua, vì hai nhà xây tường chung. Đến nay gia đình chị Vân vẫn phải bám trụ trong căn nhà này vì chưa đủ tài chính xây mới, bán rẻ quá cũng tiếc. Ai nhìn vào cũng lắc đầu, tiếc miếng đất vuông vắn, rộng rãi mà kẹt trong con hẻm nhỏ, ở khổ, bán khó.

Cũng mua nhà ngõ nhỏ lại xa trung tâm, anh Phương kể đã rất hối hận với quyết định này. Năm 2010, anh dồn tiền mua đất xây nhà 4 tầng trong ngõ nhỏ ở quận Bắc Từ Liêm với tổng số tiền 2 tỉ đồng, đây là con số khá lớn tại thời điểm đó. Vậy nhưng, chỉ sau 1 năm ở, anh Phương đã thấy hối hận vô cùng về quyết định này. Ngõ nhỏ khiến việc đi lại bất tiện lại xa trung tâm nên dù nhà to anh vẫn thấy cuộc sống không được như ý, chỉ thấy lãng phí. Hầu như nhà anh chỉ ở tầng 1 và nửa tầng 2, còn lại toàn bộ tầng 3-4 bỏ không. Vì nằm trong ngõ nhỏ nên qua nhiều năm ngôi nhà của anh Phương thậm chí còn bị sụt giảm giá trị, hiện giờ nếu bán cũng chỉ được gần 2 tỷ. Anh Phương cho biết, nếu được chọn lại anh sẽ mua căn hộ 60-70m2 gần trung tâm tiện cho việc đi làm.

Nếu chỉ đủ tiền mua nhà trong hẻm nhỏ cần lưu ý gì?
Tuy nhà trong hẻm nhỏ có nhiều bất lợi nhưng không phải ai cũng đủ tài chính để mua nhà trong hẻm xe hơi. Vậy nếu chỉ đủ điều kiện mua nhà hẻm nhỏ, người mua cần lưu ý những gì? Theo chia sẻ từ nhiều bạn đọc, Batdongsan.com.vn nhận thấy có 5 yếu tố người mua cần lưu ý khi mua nhà trong hẻm nhỏ như sau:

1. Lộ giới hẻm
 “Lộ giới” hay “chỉ giới đường đỏ” là thuật ngữ được dùng để chỉ ranh giới quy hoạch mở đường hoặc mở hẻm. Theo quy định, chiều rộng tối thiểu của hẻm phải đạt 3,5m. Do đó nếu hẻm dưới 3,5m cần lưu ý mốc lộ giới và người dân không được phép lấn chiếm, xây nhà đè lên mốc lộ giới này. Tuy nhiên, một số chủ nhà muốn tăng diện tích ở vẫn cố tình xây lấn lên lộ giới nên nếu không tìm hiểu kỹ, sau này khi mở rộng hẻm bạn sẽ bị mất phần nhà và đất xây sai phạm. Nếu mua đất trong hẻm rồi tự xây nhà bạn cũng cần kiểm tra kỹ thông tin lộ giới để không xây đè lên phần đất này. 2. Hẻm quá nhỏ
Không nên mua nhà trong những con hẻm chỉ có 1 xe máy đi qua được, không chỉ bất tiện trong sinh hoạt, vận chuyển hàng hóa mà còn nguy hiểm khi có cháy nổ. Nếu hẻm nhỏ nhưng ngắn, lưu thông ra ngõ hoặc đường lớn dễ dàng thì có thể cân nhắc.

3. Diện tích thực của ngôi nhà
Những ngôi nhà trong ngõ hay có tình trạng lấn chiếm đất xây thêm, vì vậy cần kiểm tra kỹ diện tích thực căn nhà và diện tích trên sổ đỏ. Nếu diện tích thực lớn hơn nghĩa là chủ nhà đã lấn chiếm. Với những ngôi nhà này, người mua có thể thương lượng chỉ tính tiền mua phần diện tích có trong sổ đỏ. Nếu là nhà cấp 4, diện tích dưới 30m2 thì cần có giấy phép xây dựng vì người mua sẽ mất thêm khá nhiều chi phí để xin được giấy này. 

4. Vị trí nhà
Không nên chọn nhà nằm ở những vị trí bất lợi như ngõ cụt, xung quanh nhà hàng xóm đua ra che kín mặt thoáng…

5. Pháp lý ngôi nhà
Những ngôi nhà nằm sâu trong ngõ người dân thường dễ xây chui nên khi mua cần kiểm tra kỹ yếu tố pháp lý, giấy hoàn công, nhà có xây không phép hay đất dính quy hoạch không… Các thông tin này có thể kiểm tra ở địa chính phường và hỏi hàng xóm xung quanh. ', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (66, N'Mua nhà qua vi bằng: Đừng tiện tay, hãy đề phòng 3 rủi ro này
', CAST(N'2020-06-02T00:00:00.0000000' AS DateTime2), 10, N'Theo quy định của Luật Nhà ở, Luật Đất đai, việc mua bán, chuyển nhượng nhà đất phải được lập thành hợp đồng tại các tổ chức hành nghề công chứng. Tuy nhiên, nhiều người lầm tưởng vi bằng do thừa phát lại lập có giá trị tương đương công chứng nên liều lĩnh mua nhà theo hình thức này. Khi đó, người mua có thể phải đối diện với 3 rủi ro sau đây:
1. Một ngôi nhà bán cho nhiều người

Vi bằng là biên bản do văn phòng Thừa Phát Lại tại địa phương cấp, ghi nhận vào ngày giờ, địa điểm nhất định, giữa các bên liên quan có cam kết một nội dung nào đó với nhau. Trong mua bán nhà đất, việc lập vi bằng của Thừa phát lại chỉ ghi nhận hành vi, sự kiện giao nhận tiền, giấy tờ giữa các bên. Còn lại, các bên phải tự tìm hiểu về nguồn gốc, pháp lý nhà đất chứ Thừa phát lại không ghi nhận điều đó. Nói cách khác, vi bằng không có giá trị thay thế hợp đồng công chứng, chứng thực và không phải là cơ sở để thực hiện sang tên đổi chủ trong giao dịch bất động sản.

Lợi dụng sự thiếu hiểu biết của nhiều người mua về vấn đề này, các đối tượng xấu thường thu gom đất xây nhà, rao bán bằng vi bằng do thừa phát lại lập để trục lợi. Thậm chí là lập vi bằng để bán một căn nhà cùng lúc cho nhiều người. Khi có tranh chấp xảy ra, người mua mới biết mình bị lừa, trong khi kẻ lừa đảo đã ôm tiền cao chạy xa bay. 2. Nhà được bán đã đem thế chấp ngân hàng

Nguy hiểm hơn là, có chủ sở hữu nhà, đất vẫn lập vi bằng chuyển nhượng bất động sản dù sổ đỏ đã thế chấp ở ngân hàng, cầm cố hoặc chuyển nhượng cho người khác (bằng giấy tay). Như trường hợp của chị May (Quận 7, TP HCM) có mua một trong 4 căn nhà được người chủ xây dựng trên khu đất rộng 120m2. Vì diện tích mỗi căn đều nhỏ hơn so với quy định được tách sổ nên cả 4 căn đều chung một sổ hồng. Người bán hứa sau khi 4 người mua đều giao tiền đầy đủ, anh ta sẽ đưa tên cả 4 người vào sổ hồng.

Chung giấy tờ pháp lý như vậy nên khi mua nhà, chị May không thể làm hợp đồng công chứng sang tên đổi chủ, mà chỉ cùng người bán ra văn phòng thừa phát lại để giao tiền và lập vi bằng ghi nhận giao dịch này. Tuy nhiên, dọn về nhà mới chưa đầy nửa năm, chị May và 3 chủ hộ còn lại bất ngờ nhận được thông báo siết nợ khu đất của ngân hàng. Lý do là chủ nhà cũ đã đem thế chấp sổ hồng và hiện tại mất khả năng trả nợ.

Vi bằng lúc này chỉ có thể đưa ra làm chứng nếu chị May khởi kiện chủ nhà cũ tội lừa đảo, còn không có giá trị chứng minh ngôi nhà đã được chuyển quyền sở hữu cho chị May. Khi ngân hàng siết nợ, gia đình chị sẽ buộc phải rời khỏi ngôi nhà này. Việc khởi kiện người bán nhà tội lừa đảo cũng sẽ mất rất nhiều công sức, thời gian, nhất là khi người này đang mất khả năng trả nợ.

3. Người thuê nhà lấy nhà đi bán

Nhiều người vì ham lợi nhuận trước mắt mà liều lĩnh mua nhà qua vi bằng với giá thấp, sau đó cho thuê lại để đầu tư sinh lời. Nhưng vì là nhà giấy tờ tay nên không loại trừ khả năng khách thuê sẽ mượn bản photo giấy tờ này (lấy lý do làm thủ tục đăng ký tạm trú) để làm giả một số tài liệu, sau đó đem bán nhà cho người khác cũng thông qua hình thức lập vi bằng.

Cả người mua và văn phòng Thừa phát lại đều dễ bị lừa bởi căn nhà đó chỉ có giấy tờ tay, chưa có sổ hồng nên khó có thể tra cứu được chủ nhân thật sự. Sau khi bán nhà xong thì người đi thuê nhà cao chạy xa bay, còn người cho thuê nhà và người mua lại nhà sẽ vướng vào cuộc chiến tranh giành tài sản. Ngay cả bên cho thuê cũng khó giành được phần thắng do nhà giấy tờ tay, sẽ rất khó khăn trong việc chứng minh đó là tài sản của mình.', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (67, N'3 rủi ro khi vay ngân hàng mua nhà trả góp
', CAST(N'2020-05-23T00:00:00.0000000' AS DateTime2), 13, N'1. Rủi ro lãi suất

Đây là rủi ro lớn nhất mà khách hàng có nguy cơ gặp phải khi mua nhà trả góp mà không tìm hiểu kỹ về khoản vay cũng như chính sách cho vay của ngân hàng. Tâm lý đi vay ai cũng mong được lãi suất thấp nhất, tuy nhiên lãi suất thấp luôn kéo theo nhiều điều kiện và chưa chắc đã an toàn. Hầu hết khách hàng chỉ quan tâm đến lãi suất ưu đãi trong giai đoạn đầu tiên mà không biết rằng hết kỳ hạn đó, lãi suất sẽ được “thả nổi”, thay đổi tùy theo biên độ và quy định của từng ngân hàng. Kể cả con số cho vay lãi suất 0% tưởng “béo bở” nhưng hết thời hạn hỗ trợ có thể tăng tới 10 - 12%, nếu người mua không đủ khả năng tài chính sẽ rất dễ sa lầy trong nợ.

Đó là chưa kể thời hạn vay càng dài thì khoản trả gốc mỗi tháng càng ít và số lãi phải trả cuối kỳ càng cao. Tuy nhiên, không tính toán mà vội vàng chọn khoản vay ngắn hạn cũng khiến nhiều người bị stress vì áp lực chi trả, đặc biệt là những khách hàng có thu nhập không ổn định sẽ rất khó để trả hết nợ gốc và lãi chỉ trong thời gian ngắn. Vì vậy, người mua phải tìm hiểu xem lãi suất gói vay đó áp dụng như thế nào, chọn thời hạn vay ra sao để đảm bảo khả năng chi trả. 2. Rủi ro tài chính
Rủi ro này thường xuất phát từ việc khách hàng xác định khoản vay mua nhà chưa hợp lý hoặc không đọc kỹ các điều khoản trước khi ký kết hợp đồng vay tiền ngân hàng. Việc vay nhiều hay ít còn tùy thuộc vào nguồn vốn hiện có cũng như khả năng chi trả của mỗi người. Tuy nhiên, nếu ngân sách hạn hẹp mà vẫn cố vay một khoản lớn để mua nhà to, người mua rất dễ rơi vào “bẫy” tài chính do tự mình đặt ra. Theo các chuyên gia, để hạn chế tối đa áp lực chi trả, người mua nên chọn gói vay sao cho việc trả nợ chỉ chiếm khoảng 30% tổng thu nhập trong tháng. Sau khi vay tiền, người mua phải cân đối thu chi hàng tháng đồng thời lên kế hoạch chi tiết lộ trình trả nợ để tránh rủi ro “lãi mẹ đẻ lãi con”.

Không đọc kỹ hợp đồng vay tiền ngân hàng cũng khiến nhiều người mua bất ngờ gặp rắc rối và phải trả một khoản tiền không nhỏ vì tất toán trước hạn. Cụ thể, do quá mệt mỏi vì những khoản nợ phải đều đặn chi trả hàng tháng, nhiều người quyết định trả dứt nợ trước thời hạn trong hợp đồng với ngân hàng. Kết quả là bị ngân hàng phạt thanh toán trước hạn, với số tiền phạt được tính theo công thức: (Tỷ lệ phí trả nợ trước hạn) x (Số tiền trả trước). Trong đó, tỷ lệ phí trả nợ trước hạn là phần trăm sẽ bị phạt được ghi trong hợp đồng, số tiền trả trước là số tiền khách hàng còn vay và giờ trả hết (số tiền còn nợ). Như vậy, tỷ lệ phí trả trước hạn càng cao thì người vay phải trả số tiền phạt càng lớn. 3. Rủi ro pháp lý
Trong trường hợp người mua đã tính toán cẩn thận các vấn đề tài chính, không lo rủi ro lãi suất hay việc trả nợ thì một rủi ro khác vẫn có thể xuất hiện, liên quan đến vấn đề pháp lý dự án như:

- Người mua nhà đã đặt cọc, nộp tiền mua theo đúng tiến độ, nhưng sau đó, dự án bị treo. Lý do có thể là chủ đầu tư không thể gom đủ số tiền huy động vốn, hoặc có hành vi vi phạm pháp luật, bị truy cứu trách nhiệm hình sự… nên không thể tiếp tục thực hiện dự án. Để tránh rơi vào tình trạng này, người mua cần tìm hiểu kỹ về dự án và chủ đầu tư (tên tuổi, uy tín, kinh nghiệm…), đặc biệt không chủ quan mua nhà theo tâm lý đám đông để rồi hối không kịp.

- Người mua nhà đã hoàn thành nghĩa vụ trả tiền nhưng chưa nhận đủ giấy tờ nhà. Điều này sẽ gây khó khăn cho những người mới mua nhà xong nhưng cần tiền nên muốn bán gấp. Khi đó, việc giao dịch sẽ gặp bất lợi vì chẳng ai đủ tin tưởng và muốn mua một căn hộ chưa có đầy đủ giấy tờ pháp lý.

- Người mua thiếu kinh nghiệm, kiến thức pháp luật trong khi hợp đồng mua bán căn hộ tồn tại nhiều kẽ hở, không rõ ràng các điều khoản như diện tích sử dụng, tiện ích chung/riêng, tổng số tiền cần thanh toán đã bao gồm phí bảo trì hay chưa… Để hạn chế tối đa rủi ro này, người mua cần tìm hiểu những kiến thức pháp luật cần thiết liên quan việc mua nhà để có thể đọc, hiểu hợp đồng, hoặc nhờ đến các dịch vụ pháp lý, người có kinh nghiệm tư vấn thêm nhằm đảm bảo quyền và lợi ích hợp pháp của mình.', 1)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (68, N'Cách xây nhà tiết kiệm chi phí nhất: 5 kinh nghiệm không phải ai cũng biết
', CAST(N'2020-03-20T00:00:00.0000000' AS DateTime2), 9, N'Thông thường, muốn xây nhà tiết kiệm chi phí nhất thì cần sử dụng vật liệu giá rẻ, nhà thầu xây dựng không chuyên nghiệp; còn muốn có một căn nhà đẹp, chất lượng đảm bảo mà vẫn tiết giảm được chi phí mới là điều khó khăn. Tuy nhiên, khó không có nghĩa là không thể.
Xây nhà chắc chắn sẽ tốn kém một khoản tiền không hề nhỏ, nhưng vẫn có nhiều bí quyết xây nhà tiết kiệm. Bằng cách vạch ra kế hoạch đúng đắn, quyết định thông minh và thấu đáo, bạn có thể dựng xây lên ngôi nhà mơ ước trong khoảng ngân sách dự trù.

Dưới đây là 5 kinh nghiệm tiết kiệm chi phí xây nhà mà bạn có thể tham khảo và áp dụng.

Chọn đất dễ thi công, xây dựng
Phần lớn mọi người đều có sẵn đất trước khi xây nhà. Tuy nhiên, trong trường hợp bạn chưa có sẵn đất, hãy cân nhắc thật kỹ càng để lựa chọn được mảnh đất dễ thi công, xây dựng. Một mảnh đất được đánh giá là thuận lợi để xây nhà không chỉ ở vị trí giao thông thuận tiện, có giấy tờ pháp lý đầy đủ mà còn nằm ở đặc điểm thổ nhưỡng, địa chất. 

Hãy lựa chọn mảnh đất trống, bằng phẳng, vuông vức, nền đất tốt cho phép giảm bớt chi phí tháo dỡ, san lấp, dễ dàng tận dụng không gian thiết kế, đồng thời giảm đáng kể phần chi phí làm móng nhà.  Tốt hơn hết, hãy tham khảo ý kiến của các chuyên gia địa chất, những người am hiểu về mảnh đất mà bạn sắp mua để tránh mua phải những khu đất sét, đất nhão, đất cát, đất có địa tầng yếu, khu vực dễ sụt lún, sạt lở, gần mạch nước ngầm, dễ ngập úng… Bởi khi xây nhà trên những nền đất này, chủ nhà bắt buộc phải gia cố móng kỹ lưỡng và tốn kém để đảm bảo sự chắc chắn cho công trình. Mặt khác, khi xây nhà, bạn nên tính đến nhu cầu phát sinh sau này để khi xây thêm tầng, thêm phòng thì không phải làm lại móng nữa.

Bên cạnh đó, cần tìm hiểu hệ thống thoát nước tại khu vực đó. Nếu đã có sẵn hệ thống thoát nước thì bạn sẽ tiết kiệm đáng kể chi phí làm cống, ống dẫn nước.

Chọn thiết kế nhà tiết kiệm chi phí
Thiết kế nhà tiết kiệm chi phí khác với thiết kế nhà giá rẻ. Điều chúng tôi muốn đề cập ở đây là cần có sự cân nhắc mẫu thiết kế nhà phù hợp, diện tích đủ dùng, số tầng hợp lý, phong cách đơn giản nhưng vẫn toát lên vẻ tinh tế. 

Thiết kế với kích thước tiêu chuẩn, càng chi tiết, rõ ràng càng tốt

Nhiều năm trước đây, bản vẽ thiết kế nhà ít được coi trọng. Thậm chí, nhiều chủ đầu tư vẫn xây nhà mà không cần tới bản vẽ. Tuy nhiên, giờ đây mọi thứ đã thay đổi. Bản vẽ thiết kế chi tiết, rõ ràng không chỉ giúp chủ nhà dễ dàng hình dung ra hình dáng của ngôi nhà tương lai mà còn giúp họ tiết kiệm đáng kể chi phí nhờ vào việc:

Giúp đội thợ thi công nhanh chóng, dễ dàng hơn, tránh những sai sót không đáng có dẫn đến phải đập phá, mất thời gian, tốn nhân công, vật tư, đội chi phí.
Giúp chủ nhà dễ dàng tính toán, lựa chọn vật tư phù hợp.
Vì thế, hãy dành thời gian để trao đổi với các kiến trúc sư về bản thiết kế. Nếu thuê chuyên gia phong thủy, hãy để kiến trúc sư và chuyên gia phong thủy làm việc trực tiếp với nhau để tránh phải sửa đổi thiết kế trong suốt quá trình thi công.

Xây nhà tiết kiệm chi phí bằng cách chồng tầng

Xây nhà rộng theo chiều ngang sẽ tốn nhiều chi phí hơn cho phần mái và móng. Do vậy, nếu muốn có nhiều không gian chức năng hơn, có một cách làm nhà tiết kiệm chi phí là chồng thêm tầng. Với một gia đình tiêu chuẩn, nhà xây 2-3 tầng là lựa chọn hợp lý.

Chọn phong cách đơn giản

Lựa chọn phong cách thiết kế nhà phù hợp cũng là một kinh nghiệm xây nhà tiết kiệm chi phí được nhiều người áp dụng. Thông thường, phong cách cổ điển sẽ tốn nhiều chi phí nhân công, thời gian thi công vì có quá nhiều đường phào chỉ, hoa văn và đi kèm nội thất cổ điển. Chính vì thế, phong cách hiện đại, tối giản đã trở thành xu hướng kiến trúc trong vài năm trở lại đây. Một ngôi nhà đơn giản không đồng nghĩa là không đẹp hay kém phần sang trọng mà vẫn giúp chủ nhà tiết kiệm đáng kể chi phí hoàn thiện. Xây nhà với diện tích phù hợp

Trước khi xây nhà, cần xác định nhu cầu sử dụng của gia đình, từ đó tính toán diện tích xây dựng, phân bổ số phòng cho phù hợp, tránh lãng phí. Đừng xây một ngôi nhà quá to, đồ sộ trong khi gia đình bạn chỉ sử dụng 2-3 phòng. 

Chọn vật liệu xây nhà tiết kiệm
Tất nhiên, chọn liệu xây nhà tiết kiệm không có nghĩa là chọn vật liệu rẻ tiền, chất lượng kém mà là lựa chọn, đầu tư vào những thứ mang lại giá trị cao nhất cho ngôi nhà, tránh sử dụng quá nhiều vật liệu chỉ mang ý nghĩa trang trí hoặc chỉ mang tính chất tạm thời. 

Vật liệu xây dựng ảnh hưởng rất lớn đến chi phí xây nhà, nhưng để tiết kiệm chi phí chúng ta chọn những vật liệu giá rẻ, xuất xứ không rõ ràng mà chúng ta sẽ lựa chọn vật liệu một cách khoa học.

Chọn vật tư nội hay ngoại?

Nhiều người có tư tưởng "sính ngoại", cho rằng các vật liệu nhập khẩu, nhãn hiệu nước ngoài mới chất lượng, làm dấy lên những tranh cãi không hồi kết về hàng nội hay hàng ngoại. Trên thực tế, nhiều loại vật tư trong nước có chất lượng tương đương vật tư ngoại nhưng giá thành rẻ hơn nhiều lần. Như vậy, trong bài toán chi phí, rõ ràng hàng nội đang chiếm ưu thế. Chỉ cần chọn đúng sản phẩm chất lượng, có nguồn gốc, xuất xứ rõ ràng.

Nhà cung cấp vật tư

Thông thường, đa phần vật tư thô như cát, gạch, xi măng, đá, dây điện, ống nước… hay vật tư hoàn thiện như tủ, cửa, gạch lót sàn, sơn, thiết bị vệ sinh… đều có thể mua được với mức giá rẻ hơn nếu bạn chịu khó đi khảo giá tại một số cửa hàng vật liệu xây dựng khác nhau. Tuy nhiên, cần lựa chọn nhà cung cấp vật tư uy tín để tránh mua phải hàng giả, hàng nhái.

Số lượng phù hợp

Cần xác định chuẩn loại vật liệu và số lượng tương ứng. Chỉ nên mua đúng số lượng vật tư cần sử dụng để tránh lãng phí. Bạn có thể nhờ kiến trúc sư tính toán chính xác số lượng của từng chủng loại vật tư.

Thời điểm xây nhà
Trong số 12 tháng của năm thì tháng nào là thời điểm lý tưởng nhất để khởi công xây nhà? Hãy cùng phân tích:

Tháng 1, 2 là khoảng thời gian Tết  Âm lịch. Lúc này, nhân công rất khan hiếm, cần tránh khởi công vì chi phí nhân công sẽ rất cao.
Khoảng thời gian lý tưởng để khởi công xây nhà là từ tháng 3 đến tháng 7. Thời điểm này là mùa khô, ít mưa, nếu thi công nhanh sẽ tiết kiệm đáng kể chi phí nhân công.
Trong khi đó, tháng 8, 9, 10 mưa nhiều, quá trình thi công sẽ bị gián đoạn. Tuy vậy, trời mưa lại giúp bạn dễ dàng kiểm tra phần chống thấm và thoát nước của công trình.
Cuối tháng 11, 12 là thời điểm cận Tết Âm lịch, chỉ phù hợp để sửa chữa nhà.
 
Lựa chọn nhà thầu để xây nhà tiết kiệm chi phí
Hiện nay có rất nhiều nhà thầu xây dựng cung cấp các gói xây nhà ở với chi phí cạnh tranh. Nhận báo giá từ một số nhà thầu xây dựng và so sánh, đánh giá để tìm ra lựa chọn phù hợp nhất. Giá cả là yếu tố cần quan tâm nhưng uy tín mới là điểm mấu chốt để quyết định. Chọn được nhà thầu có tâm, có tầm đồng nghĩa rằng ngôi nhà của bạn sẽ được hoàn thành đúng thời gian dự kiến và tiết kiệm chi phí nhất. Trong hợp đồng làm việc với nhà thầu, cần đưa ra những điều khoản và cam kết về thời gian thi công, chất lượng, chi phí và bảo hành.

 Tự làm những việc có thể

Nếu có thời gian và kinh nghiệm để thực hiện một hạng mục nào đó trong quá trình thi công, bạn có thể tham gia với tư cách nhà thầu phụ cho hạng mục này. Nhờ vậy, bạn sẽ tiết kiệm một khoản phí không hề nhỏ. Hơn nữa, việc bỏ thời gian, công sức để chăm chút cho chính ngôi nhà của mình cũng sẽ khiến bạn cảm thấy vui vẻ và gắn bó với nó nhiều hơn.

Tham khảo kinh nghiệm từ hàng xóm

Dù là bí quyết xây nhà tiết kiệm chi phí mang tính truyền thống nhưng tham khảo ý kiến từ những người đi trước cũng mang lại hiệu quả đáng kể. ', 2)
INSERT [dbo].[TinTuc] ([ID], [TieuDe], [NgayDang], [NguoiDang], [NoiDung], [LoaiTinTuc]) VALUES (70, N'Nhà cấp 4 là gì? Đặc điểm nổi bật và một số mẫu nhà cấp 4 được ưa chuộng
', CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), 9, N'Là một trong những loại hình nhà ở phổ biến tại Việt Nam, nhưng khái niệm nhà cấp 4 là gì thì không phải ai cũng nắm rõ. Vì vậy, trong bài viết này, Batdongsan.com.vn sẽ chia sẻ một số thông tin giúp độc giả hiểu nhà cấp 4 là loại nhà như thế nào và các loại nhà cấp 4 thịnh hành hiện nay.
 1. Nhà cấp 4 là gì?
Hầu hết mỗi người sẽ có những nhận xét và quan điểm riêng khi trả lời câu hỏi “nhà cấp 4 là gì”? Trong đó, các ý kiến chính về mô hình nhà ở này bao gồm:

Nhà cấp 4 là nhà như thế nào theo khái niệm truyền thống?
Nhà cấp 4 được hiểu là nhà có kết cấu chịu lực, được làm từ gỗ hoặc gạch, với thời gian sử dụng trong khoảng 30 năm. Những ngôi nhà cấp 4 thường có tường bao che chắn hoặc các vách tường ngăn làm bằng gạch hay hàng rào cây. Trong đó, hệ thống mái nhà thường có vật liệu là ngói, tấm lợp xi măng tổng hợp hay đơn giản hơn là tre, nứa, rơm,…

Nhà cấp 4 là gì theo khái niệm ngày nay?
Hiện nay, nhà cấp 4 được định nghĩa rõ ràng hơn và đã được ban hành cụ thể bằng các văn bản. Vậy theo khái niệm ngày nay, nhà cấp 4 là nhà như thế nào?

Theo nghị định số 209.2004.NĐ-CP, nhà cấp 4 được định nghĩa là những căn nhà có chiều cao nhỏ hơn 3 tầng hoặc có tổng diện tích sử dụng dưới 1.000m2. Theo khái niệm này, có thể nhận thấy, phần lớn các căn nhà được xây dựng tại Việt Nam đều theo mô hình nhà cấp 4.

Tuy nhiên, với thông tư số 03/2016/TT-BXD thì nhà cấp 4 lại có khái niệm là nhà có chiều cao xây dựng từ 1 tầng đổ xuống và có diện tích sử dụng nhỏ hơn 1.000m2. Và đây được cho là quy chuẩn chính xác nhất về nhà cấp 4. 2. Những đặc điểm nổi bật của nhà cấp 4 là gì?
Dù thiết kế không quá rộng nhưng nhà cấp 4 lại là sự lựa chọn thích hợp với nhiều hộ gia đình. Bởi những đặc điểm sau:

Thời gian xây dựng
Xét về tính năng và thiết kế thi công của nhà cấp 4 đều rất đơn giản, do đó mô hình nhà ở này có thời gian thi công ngắn hạn và khả năng đưa vào sử dụng nhanh chóng. Đây cũng là đặc điểm đặc điểm nổi bật nhất của nhà cấp 4.

Chi phí hợp lý
Nhà cấp 4 có rất nhiều mẫu thiết kế khác nhau, do đó, mức chi phí xây dựng thường không cố định và có sự dao động nhất định. Tuy nhiên, hầu hết các mẫu nhà cấp 4 đều có mức chi phí thấp, phù hợp với mức kinh tế của đa số các gia đình Việt.

Kiến trúc
Nói về nhà cấp 4 chắc hẳn nhiều người đã hình dung được lối thiết kế đặc trưng mà không cần thắc mắc kiến trúc nhà cấp 4 là gì, có gì nổi bật không? Các yếu tố kiến trúc - thiết kế hay yếu tố kỹ thuật của nhà cấp 4 là không quá cầu kỳ song, vẫn đảm bảo được kết cấu ổn định, chắc chắn và tính thẩm mỹ cho gia chủ. Đây là ưu điểm nổi bật của nhà cấp 4 so với nhiều mô hình nhà ở khác.

Thiết kế
Nhà cấp 4 có thể thiết kế với nhiều phong cách khác nhau, từ kiến trúc Châu Á hay kiến trúc Châu Âu, kiến trúc cải biến,… Tất cả đều vô cùng đa dạng, hài hòa và thân thiện với nền văn hóa của người Việt Nam.

Vật liệu xây dựng
Đặc điểm về nguyên - vật liệu xây dựng của nhà cấp 4 là như thế nào? Thông thường, các vật liệu này thường không quá cầu kỳ, nhưng vẫn đảm bảo sự an toàn và độ bền sử dụng nhà lên đến gần 30 năm cho người sử dụng. Không những vậy, gia chủ có thể tận dụng tối đa các khối vật liệu khi xây dựng để bổ sung và hoàn thiện các kết cấu ngôi nhà.

3. Các mẫu thiết kế nhà cấp 4 được ưa chuộng hiện nay
Sau khi đã tìm hiểu nhà cấp 4 là gì và các đặc trưng cơ bản, có thể thấy nhà cấp 4 luôn có sự đa dạng, linh hoạt trong thiết kế, vừa đảm bảo tính thẩm mỹ, vừa có khả năng vận dụng tối đa các công năng sử dụng. Dưới đây là các loại nhà cấp 4 được ưa chuộng nhất hiện nay gia chủ có thể tham khảo.

Nhà cấp 4 có thiết kế mái bằng
Các mẫu nhà cấp 4 có thiết kế mái bằng thường được xây dựng với vật liệu là bê tông cốt thép, có khả năng chịu lực mạnh, độ bền cao. Chính vì vậy, tuổi thọ sử dụng được đánh giá là vượt trội hơi so với nhiều mô hình thiết kế khác. Tuy nhiên, ngôi nhà của bạn vẫn đảm bảo được tính thẩm mỹ cao, hợp thời đại.

Ưu điểm đối với thiết kế này là khả năng chống nắng, chống dột tốt. Ngoài ra, phần mái còn có thể tận dụng tối ưu để đặt các thiết bị có kích thước và tải trọng nặng như bình nước nóng năng lượng mặt trời, các tấm pin năng lượng,…

 Nhà cấp 4 thiết kế mái thái
Đây là mẫu nhà cấp 4 phổ biến nhất ở nước ta. Ưu điểm nổi bật của thiết kế dạng mái thái là khả năng chống nóng, chống ẩm tốt, độ dốc của mái giúp ngôi nhà thoát mưa hữu hiệu, tránh tình trạng ứ đọng,… Mái thái sử dụng với nhà cấp 4 là đa dạng về về mẫu mã như mái giả đá, mái ngói, mái sóng nhỏ, mái giật cấp. Những thiết kế nhà mái thái thường tạo cho ngôi nhà phong cách hiện đại, sang trọng. Tuy nhiên, nhà cấp 4 mái thái thường có nhược điểm là chi phí cao, đồng thời, cũng đòi hỏi sự kỹ lưỡng, tỉ mỉ và thời gian thi công dài hơn so với các thiết kế khác.

Nhà cấp bốn với mẫu thiết kế mái lửng
Thiết kế mái lửng là một trong những thiết kế đẹp và được nhiều người ưa chuộng bởi thiết kế này giúp tăng hiệu quả không gian sống và diện tích sử dụng cho ngôi nhà của gia chủ. Tùy theo nhu cầu sử dụng của gia chủ mà gác lửng được biến tấu khác nhau có thể trở thành một căn phòng hoặc làm ban công thông với bên ngoài.

Khi bạn muốn thiết kế mẫu nhà cấp 4 tầng lửng cần đảm bảo sự thông thoáng cho ngôi nhà với những lưu ý như sau:

- Bố trí mái nhà cao hơn thông thường.

- Tăng cường bố trí cửa sổ, các loại cửa kính để lưu thông không khí và tận dụng ánh sáng triệt để.

- Cầu thang đi lên tầng lửng nên sử dụng các vật liệu gọn - nhẹ giúp giảm cảm giác nặng nề, chiếm không gian. Mẫu nhà cấp 4 kết hợp sân vườn
Việc kết hợp sân vườn hoặc gara để ô tô là thiết kế vô cùng hoàn hảo, giúp đáp ứng nhiều nhu cầu sinh hoạt của gia đình. Mẫu nhà này đặc biệt thích hợp với vùng nông thôn hoặc những nơi có diện tích rộng. Thông thường mẫu nhà cấp 4 kết hợp sân vườn được thiết kế theo phong cách Châu Âu, cổ điển, hiện đại hoặc tân cổ điển,…

Khi lựa chọn mẫu nhà này, bạn nên chú ý những điều sau:

Nên lấy ngôi nhà làm trung tâm, từ đó phát triển các ý tưởng sân vườn. Tránh tình trạng quá tập trung vào sân vườn mà làm chìm đi thiết kế của ngôi nhà.
Bố trí - sắp xếp không gian sân vườn thích hợp, không quá rườm rà, chi tiết. Vì điều này có thể khiến người nhìn cảm thấy rối mắt,.
Nên sử dụng các loại cây nhỏ, đan xen thảm cỏ giúp tạo cảm giác thông thông thoáng nhất có thể. ', 2)
SET IDENTITY_INSERT [dbo].[TinTuc] OFF

ALTER TABLE [dbo].[HinhAnh]  WITH CHECK ADD FOREIGN KEY([TinBatDongSan])
REFERENCES [dbo].[TinBatDongSan] ([ID])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([LoaiTaiKhoan])
REFERENCES [dbo].[LoaiTaiKhoan] ([ID])
GO
ALTER TABLE [dbo].[TinBatDongSan]  WITH CHECK ADD FOREIGN KEY([GoiTin])
REFERENCES [dbo].[GoiTin] ([ID])
GO
ALTER TABLE [dbo].[TinBatDongSan]  WITH CHECK ADD FOREIGN KEY([Huong])
REFERENCES [dbo].[Huong] ([ID])
GO
ALTER TABLE [dbo].[TinBatDongSan]  WITH CHECK ADD FOREIGN KEY([LoaiBatDongSan])
REFERENCES [dbo].[LoaiBatDongSan] ([ID])
GO
ALTER TABLE [dbo].[TinBatDongSan]  WITH CHECK ADD FOREIGN KEY([LoaiTin])
REFERENCES [dbo].[LoaiTinBatDongSan] ([ID])
GO
ALTER TABLE [dbo].[TinBatDongSan]  WITH CHECK ADD FOREIGN KEY([MucDienTich])
REFERENCES [dbo].[MucDienTich] ([ID])
GO
ALTER TABLE [dbo].[TinBatDongSan]  WITH CHECK ADD FOREIGN KEY([MucGia])
REFERENCES [dbo].[MucGia] ([ID])
GO
ALTER TABLE [dbo].[TinBatDongSan]  WITH CHECK ADD FOREIGN KEY([NguoiDang])
REFERENCES [dbo].[TaiKhoan] ([ID])
GO
ALTER TABLE [dbo].[TinTuc]  WITH CHECK ADD FOREIGN KEY([LoaiTinTuc])
REFERENCES [dbo].[LoaiTinTuc] ([ID])
GO
ALTER TABLE [dbo].[TinTuc]  WITH CHECK ADD FOREIGN KEY([NguoiDang])
REFERENCES [dbo].[TaiKhoan] ([ID])
GO
USE [master]
GO
ALTER DATABASE [QuanLyBatDongSan] SET  READ_WRITE 
GO
