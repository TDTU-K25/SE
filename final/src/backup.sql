USE [master]
GO
/****** Object:  Database [QLHTTTSV_TDT]    Script Date: 12/4/2023 6:05:31 PM ******/
CREATE DATABASE [QLHTTTSV_TDT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLHTTTSV_TDT', FILENAME = N'D:\App\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLHTTTSV_TDT.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLHTTTSV_TDT_log', FILENAME = N'D:\App\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLHTTTSV_TDT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLHTTTSV_TDT] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLHTTTSV_TDT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLHTTTSV_TDT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET RECOVERY FULL 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET  MULTI_USER 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLHTTTSV_TDT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLHTTTSV_TDT] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLHTTTSV_TDT', N'ON'
GO
ALTER DATABASE [QLHTTTSV_TDT] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLHTTTSV_TDT] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLHTTTSV_TDT]
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateAccountID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[GenerateAccountID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewID VARCHAR(10)
    
    DECLARE @MaxID INT

    SELECT @MaxID = MAX(CAST(RIGHT(account_id, 4) AS INT))
    FROM Account

    -- Nếu không có bản ghi nào trong bảng "MonHoc," @MaxID sẽ là NULL, vì vậy chúng ta cần kiểm tra và xử lý nó.
    IF @MaxID IS NULL
    BEGIN
        SET @MaxID = 0
    END

    SET @NewID = 'AC' + RIGHT('0000' + CAST(@MaxID + 1 AS VARCHAR), 4)

    RETURN @NewID
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateDD_ID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----- GeneratDDSV
CREATE   FUNCTION [dbo].[GenerateDD_ID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewDDID VARCHAR(10)

	SELECT @NewDDID = 'DD' + RIGHT('0000' + CAST((ISNULL(MAX(CAST(SUBSTRING(diemdanh_id, 4, 4) AS INT)), 0) + 1) AS VARCHAR), 4)
    FROM DiemDanh

    RETURN @NewDDID
END

----- Get Last DD_id
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateGiangVienID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[GenerateGiangVienID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewID VARCHAR(10)
    
    DECLARE @MaxID INT

    SELECT @MaxID = MAX(CAST(RIGHT(gv_id, 4) AS INT))
    FROM GiangVien

    -- Nếu không có bản ghi nào trong bảng "MonHoc," @MaxID sẽ là NULL, vì vậy chúng ta cần kiểm tra và xử lý nó.
    IF @MaxID IS NULL
    BEGIN
        SET @MaxID = 0
    END

    SET @NewID = 'GV' + RIGHT('0000' + CAST(@MaxID + 1 AS VARCHAR), 4)

    RETURN @NewID
END;

GO
/****** Object:  UserDefinedFunction [dbo].[GenerateHoaDonChiTietID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   FUNCTION [dbo].[GenerateHoaDonChiTietID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewID VARCHAR(10)
    
    DECLARE @MaxID INT

    SELECT @MaxID = MAX(CAST(RIGHT(CTHD_id, 4) AS INT))
    FROM ChiTietHoaDon

    IF @MaxID IS NULL
    BEGIN
        SET @MaxID = 0
    END

	SET @NewID = 'CTHD' + RIGHT('0000' + CAST(@MaxID + 1 AS VARCHAR), 4)

    RETURN @NewID
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateHoaDonID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   FUNCTION [dbo].[GenerateHoaDonID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewID VARCHAR(10)

    DECLARE @MaxID INT

    SELECT @MaxID = MAX(CAST(RIGHT(hoadon_id, 4) AS INT))
    FROM HoaDon

    IF @MaxID IS NULL
    BEGIN
        SET @MaxID = 0
    END

	SET @NewID = 'HD' + RIGHT('0000' + CAST(@MaxID + 1 AS VARCHAR), 4)
    RETURN @NewID
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateKSMHID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Add KSMH với monhoc_id và SinhVIen_id
CREATE   FUNCTION [dbo].[GenerateKSMHID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewID VARCHAR(10)
    
    DECLARE @MaxID INT

    SELECT @MaxID = MAX(CAST(RIGHT(ksmh_id, 4) AS INT))
    FROM KhaoSatMonHoc

    -- Nếu không có bản ghi nào trong bảng "MonHoc," @MaxID sẽ là NULL, vì vậy chúng ta cần kiểm tra và xử lý nó.
    IF @MaxID IS NULL
    BEGIN
        SET @MaxID = 0
    END

    SET @NewID = 'KSMH' + RIGHT('0000' + CAST(@MaxID + 1 AS VARCHAR), 4)

    RETURN @NewID
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateLichHocID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[GenerateLichHocID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewID VARCHAR(10)
    
    DECLARE @MaxID INT

    SELECT @MaxID = MAX(CAST(RIGHT(licHoc_id, 4) AS INT))
    FROM LichHoc

    -- Nếu không có bản ghi nào trong bảng "MonHoc," @MaxID sẽ là NULL, vì vậy chúng ta cần kiểm tra và xử lý nó.
    IF @MaxID IS NULL
    BEGIN
        SET @MaxID = 0
    END

    SET @NewID = 'LH' + RIGHT('0000' + CAST(@MaxID + 1 AS VARCHAR), 4)

    RETURN @NewID
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateLichThiID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   FUNCTION [dbo].[GenerateLichThiID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewLichThiID VARCHAR(10)

	SELECT @NewLichThiID = 'LT' + RIGHT('0000' + CAST((ISNULL(MAX(CAST(SUBSTRING(lichthi_id, 3, 4) AS INT)), 0) + 1) AS VARCHAR), 4)
    FROM LichThi

    RETURN @NewLichThiID
END
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateMHID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[GenerateMHID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewID VARCHAR(10)

    SELECT @NewID = 'KSMH' + RIGHT('0000' + CAST((COUNT(*) + 1) AS VARCHAR), 4)
    FROM KhaoSatMonHoc

    RETURN @NewID
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateMonHocID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Add MonHoc
CREATE   FUNCTION [dbo].[GenerateMonHocID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewID VARCHAR(10)
    
    DECLARE @MaxID INT

    SELECT @MaxID = MAX(CAST(RIGHT(monhoc_id, 4) AS INT))
    FROM MonHoc

    -- Nếu không có bản ghi nào trong bảng "MonHoc," @MaxID sẽ là NULL, vì vậy chúng ta cần kiểm tra và xử lý nó.
    IF @MaxID IS NULL
    BEGIN
        SET @MaxID = 0
    END

    SET @NewID = 'MH' + RIGHT('0000' + CAST(@MaxID + 1 AS VARCHAR), 4)

    RETURN @NewID
END;


GO
/****** Object:  UserDefinedFunction [dbo].[GenerateSinhVienID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[GenerateSinhVienID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewID VARCHAR(10)

	SELECT @NewID = 'SV' + RIGHT('0000' + CAST((ISNULL(MAX(CAST(SUBSTRING(sv_id, 3, 4) AS INT)), 0) + 1) AS VARCHAR), 4)
    FROM SinhVien

    RETURN @NewID
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateSKDRL_ID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[GenerateSKDRL_ID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewSKDRLID VARCHAR(10)

	SELECT @NewSKDRLID = 'DRL' + RIGHT('0000' + CAST((ISNULL(MAX(CAST(SUBSTRING(DRL_id, 4, 4) AS INT)), 0) + 1) AS VARCHAR), 4)
    FROM SKDRL

    RETURN @NewSKDRLID
END
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateSuKienDrlID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[GenerateSuKienDrlID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewID VARCHAR(10)

    
    
    DECLARE @MaxID INT

    SELECT @MaxID = MAX(CAST(RIGHT(DRL_id, 4) AS INT))
    FROM SKDRL

    IF @MaxID IS NULL
    BEGIN
        SET @MaxID = 0
    END

	SET @NewID = 'DRL' + RIGHT('0000' + CAST(@MaxID + 1 AS VARCHAR), 4)

    RETURN @NewID

END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateThongBaoID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[GenerateThongBaoID]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewID VARCHAR(10)
    
    DECLARE @MaxID INT

    SELECT @MaxID = MAX(CAST(RIGHT(tb_id, 4) AS INT))
    FROM ThongBao

    -- Nếu không có bản ghi nào trong bảng "MonHoc," @MaxID sẽ là NULL, vì vậy chúng ta cần kiểm tra và xử lý nó.
    IF @MaxID IS NULL
    BEGIN
        SET @MaxID = 0
    END

    SET @NewID = 'TB' + RIGHT('0000' + CAST(@MaxID + 1 AS VARCHAR), 4)

    RETURN @NewID
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateUserID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[GenerateUserID]()

RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NewID VARCHAR(10)
    
    DECLARE @MaxID INT

    SELECT @MaxID = MAX(CAST(RIGHT(user_id, 4) AS INT))
    FROM User_sub

    -- Nếu không có bản ghi nào trong bảng "MonHoc," @MaxID sẽ là NULL, vì vậy chúng ta cần kiểm tra và xử lý nó.
    IF @MaxID IS NULL
    BEGIN
        SET @MaxID = 0
    END

    SET @NewID = 'US' + RIGHT('0000' + CAST(@MaxID + 1 AS VARCHAR), 4)

    RETURN @NewID
END;
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[account_id] [varchar](10) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[CTHD_id] [varchar](10) NOT NULL,
	[monhoc_id] [varchar](10) NOT NULL,
	[hoadon_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CTHD_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiemDanh]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemDanh](
	[diemdanh_id] [varchar](10) NOT NULL,
	[ngayDiemDanh] [date] NOT NULL,
	[trangThai] [nvarchar](20) NOT NULL,
	[monhoc_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[diemdanh_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiemThi]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemThi](
	[diem_id] [varchar](10) NOT NULL,
	[diemQT1] [float] NOT NULL,
	[diemQT2] [float] NOT NULL,
	[diemCuoiKi] [float] NOT NULL,
	[diemGiuaKi] [float] NOT NULL,
	[diemTb] [float] NOT NULL,
	[user_id] [varchar](10) NOT NULL,
	[monhoc_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[diem_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[gv_id] [varchar](10) NOT NULL,
	[loaiGv] [nvarchar](50) NOT NULL,
	[user_id] [varchar](10) NOT NULL,
	[khoa_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[gv_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[gv_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GV_MH]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GV_MH](
	[monhoc_id] [varchar](10) NOT NULL,
	[user_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[monhoc_id] ASC,
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[hoadon_id] [varchar](10) NOT NULL,
	[Tongtiencacmon] [int] NOT NULL,
	[ngaytao] [date] NOT NULL,
	[trangThai] [nvarchar](20) NOT NULL,
	[Sotiendathanhtoan] [int] NOT NULL,
	[Ngaythanhtoan] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[hoadon_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhaoSatMonHoc]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhaoSatMonHoc](
	[ksmh_id] [varchar](10) NOT NULL,
	[nhanxet] [nvarchar](4000) NOT NULL,
	[monhoc_id] [varchar](10) NOT NULL,
	[user_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ksmh_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[khoa_id] [varchar](10) NOT NULL,
	[tenKhoa] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[khoa_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichHoc]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichHoc](
	[licHoc_id] [varchar](10) NOT NULL,
	[ca] [int] NOT NULL,
	[phongHoc] [nvarchar](50) NOT NULL,
	[thu] [nvarchar](10) NOT NULL,
	[monhoc_id] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[licHoc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichThi]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichThi](
	[lichthi_id] [varchar](10) NOT NULL,
	[ngayThi] [date] NOT NULL,
	[thoiGianThi] [time](7) NOT NULL,
	[diaDiemThi] [nvarchar](20) NOT NULL,
	[hinhthucthi] [nvarchar](20) NOT NULL,
	[user_id] [varchar](10) NOT NULL,
	[monhoc_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[lichthi_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[Lop_id] [varchar](10) NOT NULL,
	[tenLop] [nvarchar](15) NOT NULL,
	[khoa_id] [varchar](10) NOT NULL,
	[monhoc_id] [varchar](10) NOT NULL,
	[user_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Lop_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[monhoc_id] [varchar](10) NOT NULL,
	[tenMonhoc] [nvarchar](50) NOT NULL,
	[tinChi] [int] NOT NULL,
	[hocPhiMon] [int] NOT NULL,
	[ngaybatdau] [date] NOT NULL,
	[ngayketthuc] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[monhoc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QTV]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QTV](
	[QTV_id] [varchar](10) NOT NULL,
	[user_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[QTV_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[sv_id] [varchar](10) NOT NULL,
	[loaiSv] [nvarchar](50) NOT NULL,
	[user_id] [varchar](10) NOT NULL,
	[khoa_id] [varchar](10) NOT NULL,
	[hoadon_id] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[sv_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SKDRL]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SKDRL](
	[DRL_id] [varchar](10) NOT NULL,
	[loaiDRL] [nvarchar](20) NOT NULL,
	[TenSK] [nvarchar](50) NOT NULL,
	[Diem] [int] NOT NULL,
	[ngaytochuc] [date] NULL,
	[thoigiantochuc] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DRL_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SV_DD]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SV_DD](
	[user_id] [varchar](10) NOT NULL,
	[diemdanh_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC,
	[diemdanh_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SV_Lop]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SV_Lop](
	[user_id] [varchar](10) NOT NULL,
	[Lop_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC,
	[Lop_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SV_MH]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SV_MH](
	[monhoc_id] [varchar](10) NOT NULL,
	[user_id] [varchar](10) NOT NULL,
	[ngaydangki] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[monhoc_id] ASC,
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SV_SKDRL]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SV_SKDRL](
	[user_id] [varchar](10) NOT NULL,
	[DRL_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC,
	[DRL_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongBao]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongBao](
	[tb_id] [varchar](10) NOT NULL,
	[ngayTao] [date] NOT NULL,
	[ngayCapNhat] [date] NOT NULL,
	[noiDung] [nvarchar](4000) NOT NULL,
	[loaiThongBao] [nvarchar](20) NOT NULL,
	[doiTuong] [nvarchar](20) NOT NULL,
	[ngayHetHan] [date] NOT NULL,
	[khoa_id] [varchar](10) NOT NULL,
	[user_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tb_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_sub]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_sub](
	[user_id] [varchar](10) NOT NULL,
	[hovaten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[numberPhone] [varchar](15) NOT NULL,
	[gioitinh] [nvarchar](10) NOT NULL,
	[Ngaysinh] [date] NOT NULL,
	[email] [varchar](50) NOT NULL,
	[role] [nvarchar](20) NOT NULL,
	[account_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([hoadon_id])
REFERENCES [dbo].[HoaDon] ([hoadon_id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([monhoc_id])
REFERENCES [dbo].[MonHoc] ([monhoc_id])
GO
ALTER TABLE [dbo].[DiemDanh]  WITH CHECK ADD FOREIGN KEY([monhoc_id])
REFERENCES [dbo].[MonHoc] ([monhoc_id])
GO
ALTER TABLE [dbo].[DiemThi]  WITH CHECK ADD FOREIGN KEY([monhoc_id])
REFERENCES [dbo].[MonHoc] ([monhoc_id])
GO
ALTER TABLE [dbo].[DiemThi]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[SinhVien] ([user_id])
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD FOREIGN KEY([khoa_id])
REFERENCES [dbo].[Khoa] ([khoa_id])
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[User_sub] ([user_id])
GO
ALTER TABLE [dbo].[GV_MH]  WITH CHECK ADD FOREIGN KEY([monhoc_id])
REFERENCES [dbo].[MonHoc] ([monhoc_id])
GO
ALTER TABLE [dbo].[GV_MH]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[GiangVien] ([user_id])
GO
ALTER TABLE [dbo].[KhaoSatMonHoc]  WITH CHECK ADD FOREIGN KEY([monhoc_id])
REFERENCES [dbo].[MonHoc] ([monhoc_id])
GO
ALTER TABLE [dbo].[KhaoSatMonHoc]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[SinhVien] ([user_id])
GO
ALTER TABLE [dbo].[LichHoc]  WITH CHECK ADD FOREIGN KEY([monhoc_id])
REFERENCES [dbo].[MonHoc] ([monhoc_id])
GO
ALTER TABLE [dbo].[LichThi]  WITH CHECK ADD FOREIGN KEY([monhoc_id])
REFERENCES [dbo].[MonHoc] ([monhoc_id])
GO
ALTER TABLE [dbo].[LichThi]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[SinhVien] ([user_id])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([khoa_id])
REFERENCES [dbo].[Khoa] ([khoa_id])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([monhoc_id])
REFERENCES [dbo].[MonHoc] ([monhoc_id])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[GiangVien] ([user_id])
GO
ALTER TABLE [dbo].[QTV]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[User_sub] ([user_id])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([hoadon_id])
REFERENCES [dbo].[HoaDon] ([hoadon_id])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([khoa_id])
REFERENCES [dbo].[Khoa] ([khoa_id])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[User_sub] ([user_id])
GO
ALTER TABLE [dbo].[SV_DD]  WITH CHECK ADD FOREIGN KEY([diemdanh_id])
REFERENCES [dbo].[DiemDanh] ([diemdanh_id])
GO
ALTER TABLE [dbo].[SV_DD]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[SinhVien] ([user_id])
GO
ALTER TABLE [dbo].[SV_Lop]  WITH CHECK ADD FOREIGN KEY([Lop_id])
REFERENCES [dbo].[Lop] ([Lop_id])
GO
ALTER TABLE [dbo].[SV_Lop]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[SinhVien] ([user_id])
GO
ALTER TABLE [dbo].[SV_MH]  WITH CHECK ADD FOREIGN KEY([monhoc_id])
REFERENCES [dbo].[MonHoc] ([monhoc_id])
GO
ALTER TABLE [dbo].[SV_MH]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[SinhVien] ([user_id])
GO
ALTER TABLE [dbo].[SV_SKDRL]  WITH CHECK ADD FOREIGN KEY([DRL_id])
REFERENCES [dbo].[SKDRL] ([DRL_id])
GO
ALTER TABLE [dbo].[SV_SKDRL]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[SinhVien] ([user_id])
GO
ALTER TABLE [dbo].[ThongBao]  WITH CHECK ADD FOREIGN KEY([khoa_id])
REFERENCES [dbo].[Khoa] ([khoa_id])
GO
ALTER TABLE [dbo].[ThongBao]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[QTV] ([user_id])
GO
ALTER TABLE [dbo].[User_sub]  WITH CHECK ADD FOREIGN KEY([account_id])
REFERENCES [dbo].[Account] ([account_id])
GO
/****** Object:  StoredProcedure [dbo].[AddKhaoSatMonHoc]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[AddKhaoSatMonHoc]
    @nhanxet NVARCHAR(4000),
    @monhoc_id VARCHAR(10),
    @user_id VARCHAR(10)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra xem monhoc_id và user_id đã tồn tại trong các bảng MonHoc và SinhVien
        IF EXISTS (SELECT 1 FROM MonHoc WHERE monhoc_id = @monhoc_id) 
            AND EXISTS (SELECT 1 FROM SinhVien WHERE user_id = @user_id)
        BEGIN
			DECLARE   @ksmh_id VARCHAR(10)
			SET @ksmh_id = dbo.GenerateMHID()
            -- Thêm dữ liệu vào bảng KhaoSatMonHoc
            INSERT INTO KhaoSatMonHoc (ksmh_id, nhanxet, monhoc_id, user_id)
            VALUES (@ksmh_id, @nhanxet, @monhoc_id, @user_id);

            COMMIT TRANSACTION;
            PRINT 'Dữ liệu KhaoSatMonHoc với ksmh_id ' + @ksmh_id + ' đã được thêm thành công.';
        END
        ELSE
        BEGIN
            ROLLBACK TRANSACTION;
            PRINT 'monhoc_id hoặc user_id không tồn tại.';
        END
    END TRY
    BEGIN CATCH
        PRINT ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteKhaoSatMonHoc]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[DeleteKhaoSatMonHoc]
    @ksmh_id VARCHAR(10),
    @monhoc_id VARCHAR(10),
    @user_id VARCHAR(10)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra xem monhoc_id và user_id đã tồn tại trong các bảng MonHoc và SinhVien
        IF EXISTS (SELECT 1 FROM MonHoc WHERE monhoc_id = @monhoc_id) 
            AND EXISTS (SELECT 1 FROM SinhVien WHERE user_id = @user_id)
        BEGIN
            -- Kiểm tra xem ksmh_id đã tồn tại trong bảng KhaoSatMonHoc
            IF EXISTS (SELECT 1 FROM KhaoSatMonHoc WHERE ksmh_id = @ksmh_id)
            BEGIN
                -- Xóa dữ liệu trong bảng KhaoSatMonHoc
                DELETE FROM KhaoSatMonHoc
                WHERE ksmh_id = @ksmh_id;

                COMMIT TRANSACTION;
                PRINT 'Dữ liệu KhaoSatMonHoc với ksmh_id ' + @ksmh_id + ' đã được xóa thành công.';
            END
            ELSE
            BEGIN
                ROLLBACK TRANSACTION;
                PRINT 'KSMH không tồn tại.';
            END
        END
        ELSE
        BEGIN
            ROLLBACK TRANSACTION;
            PRINT 'monhoc_id hoặc user_id không tồn tại.';
        END
    END TRY
    BEGIN CATCH
        PRINT ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserByID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--Update User
/*
CREATE OR ALTER PROCEDURE InsertOrUpdateUser
	@user_id VARCHAR(10),
	@hovaten NVARCHAR(50),
	@diachi NVARCHAR(50),
	@numberPhone VARCHAR(15),
	@gioitinh NVARCHAR(10),
	@Ngaysinh DATE,
	@email VARCHAR(50),
	@role NVARCHAR(20),
	@account_id VARCHAR(10)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION;

		IF EXISTS (SELECT * FROM Account WHERE account_id = @account_id)
		BEGIN
			IF NOT EXISTS (SELECT * FROM User_sub WHERE user_id = @user_id)
			BEGIN
				
				INSERT INTO User_sub (user_id, hovaten, diachi, numberPhone, gioitinh, Ngaysinh, email, role, account_id)
				VALUES (@user_id, @hovaten, @diachi, @numberPhone, @gioitinh, @Ngaysinh, @email, @role, @account_id);
				
				COMMIT TRANSACTION;
				PRINT 'Người dùng đã được thêm thành công.';
			END
			ELSE
			BEGIN
			
				UPDATE User_sub
				SET hovaten = @hovaten,
					diachi = @diachi,
					numberPhone = @numberPhone,
					gioitinh = @gioitinh,
					Ngaysinh = @Ngaysinh,
					email = @email,
					role = @role
				WHERE user_id = @user_id;

				COMMIT TRANSACTION;
				PRINT 'Thông tin người dùng đã được cập nhật thành công.';
			END
		END
		ELSE
		BEGIN
		
			ROLLBACK TRANSACTION;
			PRINT 'Account không tồn tại.';
		END
	END TRY
	BEGIN CATCH
		
		PRINT ERROR_MESSAGE();
		ROLLBACK TRANSACTION;
	END CATCH;
END;

*/
--Xóa User
CREATE   PROCEDURE [dbo].[DeleteUserByID]
    @user_id VARCHAR(10)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;


        IF EXISTS (SELECT 1 FROM User_sub WHERE user_id = @user_id)
        BEGIN
          
            DELETE FROM User_sub WHERE user_id = @user_id;

            COMMIT TRANSACTION;
            PRINT 'Người dùng với user_id ' + @user_id + ' đã được xóa thành công.';
        END
        ELSE
        BEGIN
   
            ROLLBACK TRANSACTION;
            PRINT 'Không tìm thấy người dùng với user_id ' + @user_id + '.';
        END
    END TRY
    BEGIN CATCH
   
        PRINT ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[GenerateLichThi_ID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[GenerateLichThi_ID]
AS
BEGIN 
	Select dbo.GenerateLichThiID()
END

GO
/****** Object:  StoredProcedure [dbo].[GenerateSinhVien_ID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[GenerateSinhVien_ID]
AS
BEGIN 
	Select dbo.GenerateSinhvienID()
END

GO
/****** Object:  StoredProcedure [dbo].[GenerateSKDRLID]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[GenerateSKDRLID]
AS
BEGIN 
	Select dbo.GenerateSKDRL_ID()
END
GO
/****** Object:  StoredProcedure [dbo].[InsertAccount]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[InsertAccount]

@username VARCHAR(50),
@password VARCHAR(50)

AS 

BEGIN
	DECLARE @account_id VARCHAR(10)
	SET @account_id = dbo.GenerateAccountID()

	INSERT INTO Account(account_id,username,password)
	VALUES (@account_id,@username,@password)

RETURN @account_id
END;

GO
/****** Object:  StoredProcedure [dbo].[InsertUser]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[InsertUser]
    @hovaten NVARCHAR(50),
    @diachi NVARCHAR(50),
    @numberPhone VARCHAR(15),
    @gioitinh NVARCHAR(10),
    @Ngaysinh DATE,
    @email VARCHAR(50),
    @role NVARCHAR(20),
    @account_id VARCHAR(10)
AS 
BEGIN
    DECLARE @user_id VARCHAR(10)

    BEGIN TRY
        BEGIN TRANSACTION;

        IF EXISTS (SELECT * FROM Account WHERE account_id = @account_id)
        BEGIN
            SET @user_id = dbo.GenerateUserID()

            IF NOT EXISTS (SELECT * FROM User_sub WHERE user_id = @user_id)
            BEGIN
                INSERT INTO User_sub (user_id, hovaten, diachi, numberPhone, gioitinh, Ngaysinh, email, role, account_id)
                VALUES (@user_id, @hovaten, @diachi, @numberPhone, @gioitinh, @Ngaysinh, @email, @role, @account_id);
                
                COMMIT TRANSACTION;
                PRINT 'Người dùng đã được thêm thành công. ID mới: ' + @user_id;
            END
            ELSE
            BEGIN
                ROLLBACK TRANSACTION;
                PRINT 'Người dùng đã tồn tại.';
            END
        END
        ELSE
        BEGIN
            ROLLBACK TRANSACTION;
            PRINT 'Account không tồn tại.';
        END
    END TRY
    BEGIN CATCH
        PRINT ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[proc_cap_nhat_info_sv]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_cap_nhat_info_sv]
(@user_id VARCHAR(10),
	@hovaten NVARCHAR(50),
	@diachi NVARCHAR(50), 
	@numberPhone VARCHAR(15), 
	@gioitinh NVARCHAR(10),
	@Ngaysinh DATE, 
	@email VARCHAR(50)
)
AS
BEGIN
	UPDATE User_sub SET
	hovaten = @hovaten,
	diachi = @diachi,
	numberPhone = @numberPhone,
	gioitinh = @gioitinh,
	Ngaysinh = @Ngaysinh,
	email = @email
	WHERE user_id = @user_id
END
GO
/****** Object:  StoredProcedure [dbo].[proc_create_SKRDL]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_create_SKRDL]
(@loaiDRL NVARCHAR(20),
  @TenSK NVARCHAR(50),
  @Diem INT,
  @ngaytochuc DATE ,
  @thoigiantochuc TIME)
AS 
	DECLARE @DRL_id VARCHAR(10)
	SET @DRL_id = dbo.GenerateSKDRL_ID()
	INSERT INTO SKDRL (DRL_id, loaiDRL, TenSK, Diem, ngaytochuc, thoigiantochuc)
VALUES
(@DRL_id, @loaiDRL,@TenSK, @Diem, @ngaytochuc, @thoigiantochuc)
GO
/****** Object:  StoredProcedure [dbo].[proc_delete_register_subjects]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_delete_register_subjects]
(@user_id VARCHAR(10))
AS
	DELETE FROM SV_MH WHERE user_id = @user_id
GO
/****** Object:  StoredProcedure [dbo].[proc_get_all_cthd_by_hd]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_get_all_cthd_by_hd]
(@hd_id VARCHAR(10))
AS
	SELECT mh.monhoc_id, mh.tenMonhoc, mh.hocPhiMon FROM ChiTietHoaDon cthd INNER JOIN MonHoc mh ON cthd.monhoc_id = mh.monhoc_id 
	WHERE cthd.hoadon_id = @hd_id
GO
/****** Object:  StoredProcedure [dbo].[proc_get_all_id_subject_register]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_get_all_id_subject_register]
(@user_id VARCHAR(10))
AS
	SELECT monhoc_id FROM SV_MH WHERE user_id = @user_id
GO
/****** Object:  StoredProcedure [dbo].[proc_get_all_sv_by_drl_va_dtb]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[proc_get_all_sv_by_drl_va_dtb]
(@drl int, @dtb float) 
AS
SELECT us.*, sv.loaiSv, sv.khoa_id, sv.hoadon_id
FROM (
    SELECT user_id, AVG(diemTb) AS 'dtb'
    FROM DiemThi
    GROUP BY user_id
    HAVING AVG(diemTb) > @dtb
) dt
JOIN (
    SELECT SV_SKDRL.user_id, SUM(SKDRL.Diem) as 'tong_drl'
    FROM SV_SKDRL
    INNER JOIN SKDRL ON SV_SKDRL.DRL_id = SKDRL.DRL_id
    GROUP BY SV_SKDRL.user_id
    HAVING SUM(SKDRL.Diem) > @drl
) drl ON dt.user_id = drl.user_id
INNER JOIN User_sub us ON us.user_id = dt.user_id 
INNER JOIN SinhVien sv ON sv.user_id = us.user_id
GO
/****** Object:  StoredProcedure [dbo].[proc_get_all_sv_by_trang_thai_hoa_don]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[proc_get_all_sv_by_trang_thai_hoa_don]
(@trangThai NVARCHAR(30))
AS
	SELECT User_sub.*, sv.loaiSv, sv.khoa_id, sv.hoadon_id FROM SinhVien sv INNER JOIN User_sub ON sv.user_id = User_sub.user_id WHERE sv.hoadon_id in (SELECT hoadon_id FROM HoaDon WHERE trangThai = @trangThai)
GO
/****** Object:  StoredProcedure [dbo].[proc_get_hoa_don_sv]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 11) Xem tat ca hoa don
CREATE   PROCEDURE [dbo].[proc_get_hoa_don_sv]
@maSV VARCHAR(10)
AS
	SELECT * FROM HoaDon hd INNER JOIN SinhVien sv ON hd.hoadon_id = sv.hoadon_id WHERE sv.user_id = @maSV

GO
/****** Object:  StoredProcedure [dbo].[proc_get_id_latest_DD]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_get_id_latest_DD]
AS
	SELECT diemdanh_id FROM DiemDanh ORDER BY diemdanh_id DESC
GO
/****** Object:  StoredProcedure [dbo].[proc_get_id_latest_SKDRL]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[proc_get_id_latest_SKDRL]
AS
	SELECT DRL_id FROM SKDRL ORDER BY DRL_id DESC
GO
/****** Object:  StoredProcedure [dbo].[proc_get_mh_dk_cua_sv]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[proc_get_mh_dk_cua_sv] @maSV VARCHAR(10)
AS
	BEGIN
		SELECT * FROM SV_MH
		INNER JOIN MonHoc ON SV_MH.monhoc_id = MonHoc.monhoc_id
		INNER JOIN LichHoc ON	MonHoc.monhoc_id = LichHoc.monhoc_id
		WHERE SV_MH.user_id = @maSV
	END
GO
/****** Object:  StoredProcedure [dbo].[proc_get_role]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[proc_get_role]
@account_id VARCHAR(10)
AS
BEGIN 
	SELECT * FROM User_sub WHERE account_id = @account_id
END

GO
/****** Object:  StoredProcedure [dbo].[proc_insert_sv_drl]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[proc_insert_sv_drl]
(@drl_id VARCHAR(10),
@maSV VARCHAR(10))
AS
	INSERT INTO SV_SKDRL (DRL_id, user_id) VALUES(@drl_id, @maSV)
GO
/****** Object:  StoredProcedure [dbo].[proc_lich_thi_ck_cua_sv]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 16) Xem lich thi CK cua moi sv
CREATE   PROCEDURE [dbo].[proc_lich_thi_ck_cua_sv]
@user_id VARCHAR(10)
AS
	SELECT lt.* FROM LichThi lt 
	INNER JOIN MonHoc mh ON lt.monhoc_id = mh.monhoc_id
	INNER JOIN SV_MH svmh ON svmh.monhoc_id = mh.monhoc_id
	INNER JOIN SinhVien sv ON sv.user_id = svmh.user_id
	WHERE hinhthucthi = N'Thi Cuối Kỳ' and sv.user_id = @user_id
GO
/****** Object:  StoredProcedure [dbo].[proc_lich_thi_gk_cua_sv]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 15) Xem lich thi GK cua moi sv
CREATE   PROCEDURE [dbo].[proc_lich_thi_gk_cua_sv]
@user_id VARCHAR(10)
AS
	SELECT lt.* FROM LichThi lt 
	INNER JOIN MonHoc mh ON lt.monhoc_id = mh.monhoc_id
	INNER JOIN SV_MH svmh ON svmh.monhoc_id = mh.monhoc_id
	INNER JOIN SinhVien sv ON sv.user_id = svmh.user_id
	WHERE hinhthucthi = N'Thi Giữa Kỳ' and sv.user_id = @user_id

GO
/****** Object:  StoredProcedure [dbo].[proc_login]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_login]
@username VARCHAR(50),
@password VARCHAR(50)
AS
BEGIN 
	SELECT * FROM Account WHERE username = @username AND password = @password
END

GO
/****** Object:  StoredProcedure [dbo].[proc_register_subject]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_register_subject] 
  (@user_id VARCHAR(10),
  @monhoc_id VARCHAR(10)
  )
AS
	INSERT INTO SV_MH(user_id, monhoc_id, ngaydangki)
	VALUES(@user_id, @monhoc_id, GETDATE())
GO
/****** Object:  StoredProcedure [dbo].[proc_select_all_mon_hoc]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_select_all_mon_hoc]
AS
	SELECT m.monhoc_id N'Mã môn', m.tenMonhoc N'Tên môn', m.tinChi N'Số tín chỉ', m.hocPhiMon 'Học phí môn' ,m.ngaybatdau N'Ngày bắt đầu' ,m.ngayketthuc N'Ngày kết thúc',l.licHoc_id 'Mã Lịch Học',l.ca 'Ca học' ,l.phongHoc N'Phòng hoc',l.thu 'Thứ',gm.user_id 'Mã user' FROM MonHoc m inner join LichHoc l on m.monhoc_id = l.monhoc_id inner join GV_MH gm on gm.monhoc_id=m.monhoc_id 
GO
/****** Object:  StoredProcedure [dbo].[proc_select_all_sv]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 1) Lay dssv
CREATE   PROCEDURE [dbo].[proc_select_all_sv]
AS
	SELECT u.*, sv.* FROM User_sub u INNER JOIN SinhVien sv on u.user_id = sv.user_id
GO
/****** Object:  StoredProcedure [dbo].[proc_select_all_thong_bao]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 13) Xem tat ca thong bao
CREATE   PROCEDURE [dbo].[proc_select_all_thong_bao]
AS
	SELECT * FROM ThongBao
GO
/****** Object:  StoredProcedure [dbo].[proc_select_diem_cua_SV]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 5) Lay danh sach diem cua sinh vien
CREATE   PROCEDURE [dbo].[proc_select_diem_cua_SV] @maSV VARCHAR(10)
AS
SELECT mh.monhoc_id, mh.tenMonhoc, mh.tinChi, dt.diemQT1, dt.diemQT2, dt.diemGiuaKi, dt.diemCuoiKi, dt.diemTb FROM DiemThi dt 
	INNER JOIN MonHoc mh on dt.monhoc_id = mh.monhoc_id 
	WHERE dt.user_id = @maSV

GO
/****** Object:  StoredProcedure [dbo].[proc_select_dsmh_cua_sv]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 4) Lay danh sach mon hoc sv dk
CREATE   PROCEDURE [dbo].[proc_select_dsmh_cua_sv] @maSV VARCHAR(10)
AS
SELECT * FROM SV_MH svmh 
	INNER JOIN SinhVien sv ON svmh.user_id = sv.user_id 
	INNER JOIN MonHoc mh on svmh.monhoc_id = mh.monhoc_id 
	WHERE svmh.user_id = @maSV

GO
/****** Object:  StoredProcedure [dbo].[proc_select_getmonByGVid]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_select_getmonByGVid]
	@gv_id VARCHAR(10)
AS
		SELECT m.monhoc_id N'Mã môn', m.tenMonhoc N'Tên môn', l.ca 'Ca học' , l.phongHoc N'Phòng hoc', l.thu 'Thứ' FROM MonHoc m inner join LichHoc l on m.monhoc_id = l.monhoc_id inner join GV_MH gm on gm.monhoc_id=m.monhoc_id WHERE gm.user_id = @gv_id
GO
/****** Object:  StoredProcedure [dbo].[proc_select_getSvByMonHocId]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_select_getSvByMonHocId]
@monhoc_id VARCHAR(10)
AS
	select us.user_id, us.hovaten, us.gioitinh, dt.diemQT1, dt.diemQT2, dt.diemGiuaKi, dt.diemCuoiKi, dt.diemTb 
	From User_sub us inner join DiemThi dt on dt.user_id=us.user_id where dt.monhoc_id = @monhoc_id
GO
/****** Object:  StoredProcedure [dbo].[proc_select_getSvStudyMonHocId]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_select_getSvStudyMonHocId]
	@monhoc_id VARCHAR(10)
AS
	SELECT DISTINCT us.user_id, us.hovaten
	FROM User_sub us
	INNER JOIN SV_MH svmh ON svmh.user_id = us.user_id
	WHERE svmh.monhoc_id = @monhoc_id
GO
/****** Object:  StoredProcedure [dbo].[proc_select_gv_theo_account_id]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_select_gv_theo_account_id]
@account_id VARCHAR(10)
AS
SELECT u.*, gv.* FROM User_sub u INNER JOIN GiangVien gv on u.user_id = gv.user_id
INNER JOIN Account a ON a.account_id = u.account_id WHERE a.account_id = @account_id

GO
/****** Object:  StoredProcedure [dbo].[proc_select_hoat_dong_drl_cua_sv]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 7) Xem SV tham gia nhung hoat dong DRL
CREATE   PROCEDURE [dbo].[proc_select_hoat_dong_drl_cua_sv] @maSV VARCHAR(10)
AS
SELECT drl.DRL_id, drl.TenSK, drl.loaiDRL, drl.Diem, drl.ngaytochuc, drl.thoigiantochuc FROM SV_SKDRL sv_drl
	INNER JOIN SKDRL drl on sv_drl.DRL_id = drl.DRL_id
	WHERE sv_drl.user_id = @maSV
GO
/****** Object:  StoredProcedure [dbo].[proc_select_khaosat_monhoc]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[proc_select_khaosat_monhoc] @maMH VARCHAR(10)
AS
	SELECT * FROM KhaoSatMonHoc
	WHERE KhaoSatMonHoc.monhoc_id = @maMH
GO
/****** Object:  StoredProcedure [dbo].[proc_select_mh_theo_id]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[proc_select_mh_theo_id]
(@mh_id VARCHAR(10))
AS
	SELECT * FROM MonHoc WHERE monhoc_id = @mh_id
GO
/****** Object:  StoredProcedure [dbo].[proc_select_sv_theo_account_id]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_select_sv_theo_account_id]
@account_id VARCHAR(10)
AS
SELECT u.*, sv.* FROM User_sub u INNER JOIN SinhVien sv on u.user_id = sv.user_id
INNER JOIN Account a ON a.account_id = u.account_id WHERE a.account_id = @account_id
GO
/****** Object:  StoredProcedure [dbo].[proc_select_sv_user_id]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[proc_select_sv_user_id]
	@userId VARCHAR(10)
AS
SELECT * FROM User_sub WHERE user_id = @userId

GO
/****** Object:  StoredProcedure [dbo].[proc_tao_hoa_don_cho_sv]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[proc_tao_hoa_don_cho_sv]
(@Tongtiencacmon int,
@user_id VARCHAR(10)
)
AS
	DECLARE @hd_id VARCHAR(10)
	SET @hd_id = dbo.GenerateHoaDonID()
	INSERT INTO HoaDon(hoadon_id, Tongtiencacmon, ngaytao, trangThai, Sotiendathanhtoan, Ngaythanhtoan) 
		VALUES (@hd_id, @Tongtiencacmon, GETDATE(), N'Chưa thanh toán', 0, NULL);
	UPDATE SinhVien SET hoadon_id = @hd_id WHERE user_id = @user_id
GO
/****** Object:  StoredProcedure [dbo].[proc_thanh_toan_hoc_phi]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[proc_thanh_toan_hoc_phi]
(@hd_id VARCHAR(10),
@tongSoTienThanhToan int)
AS
	UPDATE HoaDon SET Sotiendathanhtoan = @tongSoTienThanhToan, Ngaythanhtoan = GETDATE(), trangThai = N'Đã thanh toán' WHERE hoadon_id = @hd_id
GO
/****** Object:  StoredProcedure [dbo].[proc_them_hoa_don_chi_tiet_cua_hd]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[proc_them_hoa_don_chi_tiet_cua_hd]
(@hd_id VARCHAR(10),
@monhoc_id VARCHAR(10))
AS
	DECLARE @cthd_id VARCHAR(10)
	SET @cthd_id = dbo.GenerateHoaDonChiTietID()
	INSERT INTO ChiTietHoaDon (CTHD_id, monhoc_id, hoadon_id) VALUES (@cthd_id, @monhoc_id, @hd_id)
GO
/****** Object:  StoredProcedure [dbo].[proc_tinh_trung_binh_diem_truong]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[proc_tinh_trung_binh_diem_truong]
AS
	SELECT AVG(dtb) AS 'dtb_truong' FROM (SELECT user_id, AVG(diemTb) AS 'dtb' FROM DiemThi GROUP BY user_id) as tmp
GO
/****** Object:  StoredProcedure [dbo].[proc_tinh_trung_binh_drl]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[proc_tinh_trung_binh_drl]
AS
	SELECT AVG(tong_drl) as 'dtb' FROM (SELECT SV_SKDRL.user_id, SUM(SKDRL.Diem) as 'tong_drl' FROM SV_SKDRL INNER JOIN SKDRL on SV_SKDRL.DRL_id = SKDRL.DRL_id GROUP BY SV_SKDRL.user_id) as tmp
GO
/****** Object:  StoredProcedure [dbo].[selectAllGiangVien]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 2) Lay ds giang vien
CREATE   PROCEDURE [dbo].[selectAllGiangVien]
AS
SELECT u.*, gv.* FROM User_sub u INNER JOIN GiangVien gv on u.user_id = gv.user_id
GO
/****** Object:  StoredProcedure [dbo].[selectAllLichThi]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[selectAllLichThi] 
AS
SELECT u.*, lt.* FROM User_sub u INNER JOIN LichThi lt on u.user_id = lt.user_id

GO
/****** Object:  StoredProcedure [dbo].[selectAllSKDRL]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[selectAllSKDRL]
AS
SELECT * FROM SKDRL
GO
/****** Object:  StoredProcedure [dbo].[selectCacLoaiDRL]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 10) Lay danh sach loai DRL
CREATE   PROCEDURE [dbo].[selectCacLoaiDRL]
AS
	SELECT DISTINCT(loaiDRL) FROM SKDRL
GO
/****** Object:  StoredProcedure [dbo].[selectChiTietHoaDon]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 12) Xem chi tiet 1 hoa don
CREATE   PROCEDURE [dbo].[selectChiTietHoaDon] @maHD VARCHAR(10)
AS
	SELECT hd.hoadon_id, mh.* FROM HoaDon hd 
	INNER JOIN ChiTietHoaDon cthd ON hd.hoadon_id = cthd.hoadon_id 
	INNER JOIN MonHoc mh ON cthd.monhoc_id = mh.monhoc_id
	WHERE hd.hoadon_id = @maHD

GO
/****** Object:  StoredProcedure [dbo].[selectDiemDanhMH]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 3) Lay ds diem danh cua 1 mon hoc
CREATE   PROCEDURE [dbo].[selectDiemDanhMH] @maMH VARCHAR(10)
AS
SELECT svdd.user_id, dd.ngayDiemDanh, dd.trangThai, dd.monhoc_id FROM SV_DD svdd INNER JOIN DiemDanh dd ON svdd.diemdanh_id = dd.diemdanh_id WHERE dd.monhoc_id = @maMH	
GO
/****** Object:  StoredProcedure [dbo].[selectKhaoSatMHCuaSV]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 9) Xem cac mon hoc sinh vien da khao sat
CREATE   PROCEDURE [dbo].[selectKhaoSatMHCuaSV] @maSV VARCHAR(10)
AS
SELECT * FROM KhaoSatMonHoc ksmh
	WHERE ksmh.user_id = @maSV
GO
/****** Object:  StoredProcedure [dbo].[selectLichThiCuaSV]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 6) Xem lich thi cua sv
CREATE   PROCEDURE [dbo].[selectLichThiCuaSV] @maSV VARCHAR(10)
AS
SELECT mh.monhoc_id, mh.tenMonhoc, lt.ngayThi, lt.thoiGianThi, lt.diaDiemThi, lt.hinhthucthi FROM LichThi lt 
	INNER JOIN MonHoc mh on lt.monhoc_id = mh.monhoc_id 
	WHERE lt.user_id = @maSV

GO
/****** Object:  StoredProcedure [dbo].[selectMHGiangVienDay]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 8) Xem giang vien day nhung mon hoc nao
CREATE   PROCEDURE [dbo].[selectMHGiangVienDay] @maGV VARCHAR(10)
AS
SELECT mh.* FROM GV_MH gvmh
	INNER JOIN MonHoc mh on gvmh.monhoc_id = mh.monhoc_id 
	WHERE gvmh.user_id = @maGV

GO
/****** Object:  StoredProcedure [dbo].[SuaDiemThi]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE    PROCEDURE [dbo].[SuaDiemThi](
   @diemQT1 FLOAT,
   @diemQT2 FLOAT,
   @diemCuoiKi FLOAT,
   @diemGiuaKi FLOAT,
   @diemTb FLOAT,
   @user_id VARCHAR(10),
   @monhoc_id VARCHAR(10)
)
AS
BEGIN
  UPDATE DiemThi
  SET diemQT1 = @diemQT1,
      diemQT2 = @diemQT2,
      diemCuoiKi = @diemCuoiKi,
      diemGiuaKi = @diemGiuaKi,
      diemTb = @diemTb
  WHERE user_id = @user_id and monhoc_id= @monhoc_id
END 
select * from DiemThi
GO
/****** Object:  StoredProcedure [dbo].[SuaGiangVien]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[SuaGiangVien]
    @gv_id VARCHAR(10),
	--@user_id VARCHAR(10),
	--@account_id VARCHAR(10),
    @new_loaiGv NVARCHAR(50),
    --@new_user_id VARCHAR(10),
    @new_khoa_id VARCHAR(10),
	@new_hovaten NVARCHAR(50),
	@new_diachi NVARCHAR(50), 
	@new_numberPhone VARCHAR(15), 
	@new_gioitinh NVARCHAR(10),
	@new_Ngaysinh DATE, 
	@new_email VARCHAR(50), 
	@new_role NVARCHAR(20),
	--@new_account_id VARCHAR(10),
	@new_username VARCHAR(50)

as
Begin
Declare @tmp_user_id VARCHAR(10) = (Select user_id From GiangVien Where gv_id = @gv_id)
Declare @tmp_account_id VARCHAR(10) = (Select account_id From User_sub Where user_id = @tmp_user_id)

PRINT @tmp_account_id
UPDATE Account
SET 
username = @new_username
WHERE account_id = @tmp_account_id

UPDATE User_sub
SET
hovaten = @new_hovaten, 
diachi = @new_diachi, 
numberPhone = @new_numberPhone, 
gioitinh = @new_gioitinh, 
Ngaysinh = @new_Ngaysinh, 
email = @new_email, 
role = @new_role, 
account_id = @tmp_account_id
WHERE user_id = @tmp_user_id;

UPDATE GiangVien
SET loaiGv = @new_loaiGv,
user_id = @tmp_user_id,
khoa_id = @new_khoa_id
WHERE gv_id = @gv_id;
END
GO
/****** Object:  StoredProcedure [dbo].[SuaLichThi]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[SuaLichThi]
	@lt_id VARCHAR(10),
	@ngayThi DATE,
	@thoiGianThi TIME,
	@diaDiemThi NVARCHAR(20),
	@hinhthucthi NVARCHAR(20),
	@user_id VARCHAR(10),
	@monhoc_id VARCHAR(10)
AS
BEGIN

	--DECLARE @lt_id VARCHAR(10) = 
	UPDATE LichThi
	SET lichthi_id = @lt_id,
		ngayThi = @ngayThi,
		thoiGianThi = @thoiGianThi,
		diaDiemThi = @diaDiemThi,
		hinhthucthi = @hinhthucthi,
		user_id = @user_id,
		monhoc_id = @monhoc_id
	WHERE lichthi_id = @lt_id;
END
GO
/****** Object:  StoredProcedure [dbo].[SuaMonHoc]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE   PROCEDURE [dbo].[SuaMonHoc]
(
  @monhoc_id VARCHAR(10),
  @tenMonhoc NVARCHAR(50),
  @tinChi INT,
  @hocPhiMon INT,
  @ngaybatdau DATE,
  @ngayketthuc DATE,
  @licHoc_id VARCHAR(10),
  @ca INT,
  @phongHoc NVARCHAR(50),
  @thu NVARCHAR(10),
  @user_id VARCHAR(10)
  )

AS
BEGIN
  SET NOCOUNT ON;

  -- Sửa thông tin trong bảng MonHoc
  UPDATE MonHoc
  SET
    tenMonhoc = @tenMonhoc,
    tinChi = @tinChi,
    hocPhiMon = @hocPhiMon,
    ngaybatdau = @ngaybatdau,
    ngayketthuc = @ngayketthuc
  WHERE
    monhoc_id = @monhoc_id;

  -- Sửa thông tin trong bảng LichHoc
  UPDATE LichHoc
  SET
    ca = @ca,
    phongHoc = @phongHoc,
    thu = @thu
  WHERE
    licHoc_id = @licHoc_id;
  UPDATE GV_MH
  SET
	user_id=@user_id
  WHERE 
	monhoc_id=@monhoc_id
END;
GO
/****** Object:  StoredProcedure [dbo].[SuaSinhVien]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[SuaSinhVien]
    @sv_id VARCHAR(10),
	--@user_id VARCHAR(10),
	--@account_id VARCHAR(10),
    @new_loaiSv NVARCHAR(50),
    --@new_user_id VARCHAR(10),
    @new_khoa_id VARCHAR(10),
	@new_hoadon_id VARCHAR(10),
	@new_hovaten NVARCHAR(50),
	@new_diachi NVARCHAR(50), 
	@new_numberPhone VARCHAR(15), 
	@new_gioitinh NVARCHAR(10),
	@new_Ngaysinh DATE, 
	@new_email VARCHAR(50), 
	@new_role NVARCHAR(20),
	--@new_account_id VARCHAR(10),
	@new_username VARCHAR(50)

as
Begin
Declare @tmp_user_id VARCHAR(10) = (Select user_id From SinhVien Where sv_id = @sv_id)
Declare @tmp_account_id VARCHAR(10) = (Select account_id From User_sub Where user_id = @tmp_user_id)

PRINT @tmp_account_id
UPDATE Account
SET 
username = @new_username
WHERE account_id = @tmp_account_id

UPDATE User_sub
SET
hovaten = @new_hovaten, 
diachi = @new_diachi, 
numberPhone = @new_numberPhone, 
gioitinh = @new_gioitinh, 
Ngaysinh = @new_Ngaysinh, 
email = @new_email, 
role = @new_role, 
account_id = @tmp_account_id
WHERE user_id = @tmp_user_id;

UPDATE SinhVien
SET loaiSv = @new_loaiSv,
user_id = @tmp_user_id,
khoa_id = @new_khoa_id
WHERE sv_id = @sv_id;
END
GO
/****** Object:  StoredProcedure [dbo].[SuaSKDRL]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[SuaSKDRL]
	@DRL_id VARCHAR(10),
	@loaiDRL NVARCHAR(20),
	@TenSK NVARCHAR(50),
	@Diem INT,
	@ngaytochuc DATE,
	@thoigiantochuc TIME
AS
BEGIN
	UPDATE SKDRL
	SET loaiDRL = @loaiDRL,
		TenSK = @TenSK,
		Diem = @Diem,
		ngaytochuc = @ngaytochuc,
		thoigiantochuc = @thoigiantochuc
	WHERE DRL_id = @DRL_id;

END
GO
/****** Object:  StoredProcedure [dbo].[SuaThongBao]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create   PROCEDURE [dbo].[SuaThongBao]
    @tb_id VARCHAR(10),
   
    @noiDung NVARCHAR(4000),
    @loaiThongBao NVARCHAR(20),
    @doiTuong NVARCHAR(20),
    @ngayHetHan DATE,
    @khoa_id VARCHAR(10),
    @user_id VARCHAR(10)
AS
BEGIN
    UPDATE ThongBao
    SET 
		noiDung = @noiDung,
        loaiThongBao = @loaiThongBao,
        doiTuong = @doiTuong,
        ngayHetHan = @ngayHetHan,
        khoa_id = @khoa_id,
        user_id = @user_id
    WHERE tb_id = @tb_id;
END;
GO
/****** Object:  StoredProcedure [dbo].[ThemDiemDanhSV]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[ThemDiemDanhSV]
	@monhoc_id VARCHAR(10)
AS
BEGIN
	DECLARE @DD_id VARCHAR(10)
	SET @DD_id = dbo.GenerateDD_ID()

	DECLARE @ngayDiemDanh VARCHAR(10)
	SET @ngayDiemDanh = (SELECT FORMAT(GETDATE(), 'yyyy-MM-dd') AS FormattedDate)

	INSERT INTO DiemDanh (diemdanh_id, ngayDiemDanh, trangThai, monhoc_id)
	VALUES (@DD_id, @ngayDiemDanh, N'Đã Điểm Danh', @monhoc_id);

END

--- Thêm SV_DD
GO
/****** Object:  StoredProcedure [dbo].[ThemGiangVien]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[ThemGiangVien] (
    @loaiGv NVARCHAR(50),
    @user_id VARCHAR(10),
    @khoa_id VARCHAR(10)
)
AS
BEGIN
    -- Kiểm tra xem user_id đã tồn tại trong bảng User_sub
    DECLARE @existing_user_id VARCHAR(10)
    SET @existing_user_id = (SELECT user_id FROM User_sub WHERE user_id = @user_id)

    -- Kiểm tra xem khoa_id đã tồn tại trong bảng Khoa
    DECLARE @existing_khoa_id VARCHAR(10)
    SET @existing_khoa_id = (SELECT khoa_id FROM Khoa WHERE khoa_id = @khoa_id)

    -- Nếu user_id và khoa_id tồn tại, thực hiện INSERT
    IF @existing_user_id IS NOT NULL AND @existing_khoa_id IS NOT NULL
    BEGIN
	DECLARE    @gv_id VARCHAR(10)
	SET @gv_id = dbo.GenerateGiangVienID()

        BEGIN TRY
            BEGIN TRANSACTION;

            -- Kiểm tra xem GiangVien đã tồn tại hay chưa
            IF NOT EXISTS (SELECT * FROM GiangVien WHERE user_id = @user_id AND khoa_id = @khoa_id)
            BEGIN
                -- Thêm GiangVien mới
                INSERT INTO GiangVien (gv_id, loaiGv, user_id, khoa_id)
                VALUES (@gv_id, @loaiGv, @user_id, @khoa_id);

                COMMIT TRANSACTION;
                PRINT 'GiangVien đã được thêm thành công.';
            END
            ELSE
            BEGIN
                -- GiangVien đã tồn tại
                ROLLBACK TRANSACTION;
                PRINT 'GiangVien đã tồn tại.';
            END
        END TRY
        BEGIN CATCH
            -- Xử lý lỗi nếu có
            PRINT ERROR_MESSAGE();
            ROLLBACK TRANSACTION;
        END CATCH;
    END
    ELSE
    BEGIN
        -- user_id hoặc khoa_id không tồn tại
        PRINT 'user_id hoặc khoa_id không tồn tại.';
    END
END;

GO
/****** Object:  StoredProcedure [dbo].[ThemLichThi]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[ThemLichThi]
	@ngayThi DATE ,
	@thoiGianThi TIME ,
	@diaDiemThi NVARCHAR(20) ,
	@hinhthucthi NVARCHAR(20) ,
	@user_id VARCHAR(10) ,
	@monhoc_id VARCHAR(10)
	
AS
BEGIN 
	DECLARE @lichthi_id VARCHAR(10)
	SET @lichthi_id = dbo.GenerateLichThiID()

	INSERT INTO LichThi(lichthi_id,ngayThi,thoiGianThi,diaDiemThi,hinhthucthi,user_id,monhoc_id)
	VALUES (@lichthi_id,@ngaythi,@thoiGianThi,@diaDiemThi,@hinhthucthi,@user_id,@monhoc_id)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemMonHoc]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Create or alter PROCEDURE ThemMonHoc
  
--    @tenMonhoc NVARCHAR(50),
--    @tinChi INT,
--    @hocPhiMon INT,	
--	@phonghoc NVARCHAR(50),
--	@ca int,
--	@thu NVARCHAR(10),
--    @ngaybatdau DATE,
--    @ngayketthuc DATE
--AS
--BEGIN
--	DECLARE @monhoc_id VARCHAR(10)
--	DECLARE @lichhoc_id VARCHAR(10)
--	SET @monhoc_id = dbo.GenerateMonHocID()
--	SET @lichhoc_id = dbo.GenerateLichHocID()
	
--    INSERT INTO MonHoc (monhoc_id, tenMonhoc, tinChi, hocPhiMon, ngaybatdau, ngayketthuc)
--    VALUES (@monhoc_id, @tenMonhoc, @tinChi, @hocPhiMon, @ngaybatdau, @ngayketthuc)
--	INSERT INTO LichHoc (licHoc_id, ca, phongHoc, thu, monhoc_id)
--    VALUES (@lichhoc_id, @ca, @phonghoc, @thu, @monhoc_id)
--END
CREATE   PROCEDURE [dbo].[ThemMonHoc]
    @tenMonhoc NVARCHAR(50),
    @tinChi INT,
    @hocPhiMon INT,
    @phonghoc NVARCHAR(50),
    @ca INT,
    @thu NVARCHAR(10),
    @ngaybatdau DATE,
    @ngayketthuc DATE,
    @user_id VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @monhoc_id VARCHAR(10)
	DECLARE @lichhoc_id VARCHAR(10)
	SET @monhoc_id = dbo.GenerateMonHocID()
	SET @lichhoc_id = dbo.GenerateLichHocID()
    
    -- Thêm thông tin môn học vào bảng MonHoc
    INSERT INTO MonHoc (monhoc_id, tenMonhoc, tinChi, hocPhiMon, ngaybatdau, ngayketthuc)
    VALUES (@monhoc_id, @tenMonhoc, @tinChi, @hocPhiMon, @ngaybatdau, @ngayketthuc);

    -- Thêm lịch học cho môn học vào bảng LichHoc
    INSERT INTO LichHoc (licHoc_id, ca, phongHoc, thu, monhoc_id)
    VALUES (@lichhoc_id, @ca, @phonghoc, @thu, @monhoc_id);

    INSERT INTO GV_MH (monhoc_id, user_id)
    VALUES (@monhoc_id, @user_id);

    SELECT @monhoc_id AS monhoc_id;
END;
--Update MonHoc
SELECT m.monhoc_id N'Mã môn', m.tenMonhoc N'Tên môn', m.tinChi N'Số tín chỉ', m.hocPhiMon 'Học phí môn' ,m.ngaybatdau N'Ngày bắt đầu' ,m.ngayketthuc N'Ngày kết thúc' ,l.ca 'Ca học' ,l.phongHoc N'Phòng hoc',l.thu 'Thứ',gm.user_id 'Mã user' FROM MonHoc m inner join LichHoc l on m.monhoc_id = l.monhoc_id inner join GV_MH gm on gm.monhoc_id=m.monhoc_id 

GO
/****** Object:  StoredProcedure [dbo].[ThemSinhVien]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[ThemSinhVien] (
	@username VARCHAR(50), 
    @loaiSv NVARCHAR(50),
    @khoa_id VARCHAR(10),
	@hoadon_id VARCHAR(10),
	@hovaten NVARCHAR(50),
	@diachi NVARCHAR(50), 
	@numberPhone VARCHAR(15), 
	@gioitinh NVARCHAR(10),
	@Ngaysinh DATE, 
	@email VARCHAR(50), 
	@role NVARCHAR(20)
)
AS
BEGIN
    BEGIN
	DECLARE    @sv_id VARCHAR(10)
	SET @sv_id = dbo.GenerateSinhVienID()
	DECLARE    @account_id VARCHAR(10)
	SET @account_id = dbo.GenerateAccountID()
	DECLARE    @user_id VARCHAR(10)
	SET @user_id = dbo.GenerateUserID()
				
				PRINT @sv_id
				PRINT @account_id
				PRINT @user_id

				DECLARE @position INT = CHARINDEX('@', @username);
				DECLARE @password NVARCHAR(50)
				DECLARE @username_part NVARCHAR(50)
				DECLARE @year_of_birth VARCHAR(20)

				-- Tách phần của username trước dấu '@'
				SET @username_part =(Select LEFT(@username, @position - 1));
				--PRINT @username_part

				-- Lấy năm sinh
				SET @year_of_birth = REPLACE(@Ngaysinh, '-', '');
				--PRINT @year_of_birth

    
				-- Tạo mật khẩu bằng cách kết hợp các yếu tố
				SET @password = CONCAT(@username_part, @year_of_birth);
				--PRINT @password

                -- Thêm SinhVien mới
				INSERT INTO Account(account_id, username, password)
				VALUES (@account_id, @username, @password)

				INSERT INTO User_sub(user_id, hovaten, diachi, numberPhone, gioitinh, Ngaysinh, email, role, account_id)
				VALUES (@user_id, @hovaten, @diachi, @numberPhone, @gioitinh, @Ngaysinh, @email, @role, @account_id)

				PRINT @user_id
				DECLARE @tmp VARCHAR(10)
				SELECT @tmp = @user_id
				
                INSERT INTO SinhVien(sv_id, loaiSv, user_id, khoa_id, hoadon_id)
                VALUES (@sv_id, @loaiSv,  @tmp, @khoa_id, null)
				PRINT @tmp


                PRINT 'SinhVien đã được thêm thành công.';
	END;
END;
GO
/****** Object:  StoredProcedure [dbo].[ThemSKDRL]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[ThemSKDRL]
	@loaiDRL NVARCHAR(20),
	@TenSK NVARCHAR(50),
	@Diem INT,
	@ngaytochuc DATE,
	@thoigiantochuc TIME
AS
BEGIN
	DECLARE @DRL_id VARCHAR(10)
	SET @DRL_id = dbo.GenerateSKDRL_ID()

	INSERT SKDRL(DRL_id, loaiDRL, TenSK, Diem, ngaytochuc, thoigiantochuc)
	VALUES (@DRL_id, @loaiDRL, @TenSK, @Diem, @ngaytochuc, @thoigiantochuc);

END
GO
/****** Object:  StoredProcedure [dbo].[ThemSV_DD]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[ThemSV_DD]
	@user_id VARCHAR(10),
	@DD_id VARCHAR(10)

AS
BEGIN
	INSERT INTO SV_DD (user_id, diemdanh_id)
	VALUES (@user_id, @DD_id)

END
GO
/****** Object:  StoredProcedure [dbo].[themThongBao]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create   PROCEDURE [dbo].[themThongBao]
	@noiDung NVARCHAR(4000),
    @loaiThongBao NVARCHAR(20) ,
    @doiTuong NVARCHAR(20) ,
	@ngayHetHan DATE,
    @khoa_id VARCHAR(10),
	@user_id VARCHAR(10)
AS
BEGIN
	DECLARE @tb_id VARCHAR(10)
	SET @tb_id = dbo.GenerateThongBaoID()
	INSERT INTO ThongBao (tb_id, ngayTao, ngayCapNhat, noiDung, loaiThongBao, doiTuong, ngayHetHan, khoa_id, user_id)
	VALUES (@tb_id ,GETDATE(), GETDATE(), @noiDung, @loaiThongBao, @doiTuong ,@ngayHetHan , @khoa_id ,@user_id)
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateAccount]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Alter update account
CREATE   PROCEDURE [dbo].[UpdateAccount]
	@account_id VARCHAR(10),
	@new_username VARCHAR(50),
	@new_password VARCHAR(50)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION;

		IF EXISTS (SELECT * FROM Account WHERE account_id = @account_id)
		BEGIN
			UPDATE Account
			SET username = @new_username,
				password = @new_password
			WHERE account_id = @account_id;
			
			COMMIT TRANSACTION;
			PRINT N'Tài khoản đã được cập nhật thành công.';
		END
		ELSE
		BEGIN
			ROLLBACK TRANSACTION;
			PRINT N'Không tìm thấy tài khoản với ID đã cung cấp.';
		END
	END TRY
	BEGIN CATCH

		PRINT ERROR_MESSAGE();
		ROLLBACK TRANSACTION;
	END CATCH;
END;


GO
/****** Object:  StoredProcedure [dbo].[UpdateSV_SKDRL]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[UpdateSV_SKDRL]
    @user_id VARCHAR(10),
    @DRL_id VARCHAR(10),
	@newDRL_id VARCHAR(10)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra xem user_id và DRL_id đã tồn tại trong các bảng SinhVien và DRL
        IF EXISTS (SELECT 1 FROM SinhVien WHERE user_id = @user_id) 
            AND EXISTS (SELECT 1 FROM SKDRL WHERE DRL_id = @DRL_id)
        BEGIN
            -- Kiểm tra xem dữ liệu cần cập nhật đã tồn tại trong bảng SV_SKDRL
            IF EXISTS (SELECT 1 FROM SV_SKDRL WHERE user_id = @user_id AND DRL_id = @DRL_id)
            BEGIN
                -- Thực hiện cập nhật dữ liệu trong bảng SV_SKDRL
                UPDATE SV_SKDRL
                SET DRL_id = @newDRL_id
                    
                WHERE user_id = @user_id AND DRL_id = @DRL_id;

                COMMIT TRANSACTION;
                PRINT 'Dữ liệu SV_SKDRL với user_id ' + @user_id + ' và DRL_id ' + @DRL_id + ' đã được cập nhật thành công.';
            END
            ELSE
            BEGIN
                ROLLBACK TRANSACTION;
                PRINT 'Dữ liệu SV_SKDRL không tồn tại.';
            END
        END
        ELSE
        BEGIN
            ROLLBACK TRANSACTION;
            PRINT 'user_id hoặc DRL_id không tồn tại.';
        END
    END TRY
    BEGIN CATCH
        PRINT ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[XoaGiangVien]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[XoaGiangVien] (
    @gv_id VARCHAR(10)
)
AS
BEGIN
	Declare @tmp VARCHAR(10)
	Declare @account VARCHAR(10)
	Set @tmp =  (Select user_id From GiangVien Where gv_id = @gv_id) 
	Set @account = (Select account_id From User_sub Where user_id = @tmp)

	DELETE FROM Lop WHERE user_id = @tmp
    DELETE FROM GiangVien WHERE gv_id = @gv_id

	DELETE FROM User_sub WHERE User_sub.user_id = @tmp
	DELETE FROM Account WHERE Account.account_id = @account
END
GO
/****** Object:  StoredProcedure [dbo].[XoaLichThi]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[XoaLichThi]
	@lt_id VARCHAR(10)
AS
BEGIN
	DELETE FROM LichThi
	WHERE lichthi_id = @lt_id; 
END;
GO
/****** Object:  StoredProcedure [dbo].[XoaMonHoc]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaMonHoc]
    @monhoc_id VARCHAR(10)
AS
BEGIN
	DELETE FROM LichThi
    WHERE monhoc_id = @monhoc_id
	DELETE FROM DiemThi
    WHERE monhoc_id = @monhoc_id
	DELETE FROM SV_MH
    WHERE monhoc_id = @monhoc_id
	DELETE FROM GV_MH
    WHERE monhoc_id = @monhoc_id
	DELETE FROM KhaoSatMonHoc
    WHERE monhoc_id = @monhoc_id
	DELETE FROM SV_DD
    WHERE diemdanh_id in (select diemdanh_id from DiemDanh
    WHERE monhoc_id = @monhoc_id)

	DELETE FROM DiemDanh
    WHERE monhoc_id = @monhoc_id
	DELETE FROM ChiTietHoaDon
    WHERE monhoc_id = @monhoc_id
	DELETE FROM SV_Lop
    WHERE Lop_id in (select Lop_id from  Lop
    WHERE monhoc_id = @monhoc_id)
	DELETE FROM Lop
    WHERE monhoc_id = @monhoc_id
	DELETE FROM LichHoc
    WHERE monhoc_id = @monhoc_id
    DELETE FROM MonHoc
    WHERE monhoc_id = @monhoc_id
END
GO
/****** Object:  StoredProcedure [dbo].[XoaSinhVien]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[XoaSinhVien] (
    @sv_id VARCHAR(10)
)
AS
BEGIN
	-- Lấy thuộc tính từ các table để Xóa
	Declare @tmp_user_id VARCHAR(10)
	Declare @account VARCHAR(10)
	Set @tmp_user_id =  (Select user_id From SinhVien Where sv_id = @sv_id)
	PRINT @tmp_user_id
	Set @account = (Select account_id From User_sub Where user_id = @tmp_user_id)
	PRINT @account

 --   DELETE FROM SinhVien WHERE SinhVien.sv_id = @sv_id
	--DELETE FROM User_sub WHERE User_sub.user_id = @tmp_user_id
	--PRINT @tmp_user_id
	--DELETE FROM Account WHERE Account.account_id = @account
	PRINT @tmp_user_id
    DELETE FROM SV_Lop WHERE SV_Lop.user_id = @tmp_user_id
	PRINT @tmp_user_id
	DELETE FROM Lop WHERE Lop.user_id = @tmp_user_id
	PRINT @tmp_user_id
	DELETE FROM KhaoSatMonHoc WHERE KhaoSatMonHoc.user_id = @tmp_user_id
	PRINT @tmp_user_id
    DELETE FROM SV_MH WHERE SV_MH.user_id = @tmp_user_id
	PRINT @tmp_user_id
    DELETE FROM SV_DD WHERE SV_DD.user_id = @tmp_user_id
	PRINT @tmp_user_id
    DELETE FROM SV_SKDRL WHERE SV_SKDRL.user_id = @tmp_user_id
	PRINT @tmp_user_id
	DELETE FROM DiemThi WHERE DiemThi.user_id = @tmp_user_id
	PRINT @tmp_user_id
    DELETE FROM LichThi WHERE LichThi.user_id = @tmp_user_id
	DELETE FROM SinhVien WHERE SinhVien.sv_id = @sv_id
	DELETE FROM User_sub WHERE User_sub.user_id = @tmp_user_id
	PRINT @tmp_user_id
	DELETE FROM Account WHERE Account.account_id = @account
END
GO
/****** Object:  StoredProcedure [dbo].[XoaSKDRL]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[XoaSKDRL]
	@DRL_id VARCHAR(10)
AS
BEGIN

	DELETE FROM SV_SKDRL
	WHERE DRL_id = @DRL_id;

	DELETE FROM SKDRL
	WHERE DRL_id = @DRL_id;

END
GO
/****** Object:  StoredProcedure [dbo].[XoaThongBao]    Script Date: 12/4/2023 6:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create   PROCEDURE [dbo].[XoaThongBao]
  @tb_id VARCHAR(10)
AS
BEGIN
  DELETE FROM ThongBao WHERE tb_id = @tb_id;
END
GO
USE [master]
GO
ALTER DATABASE [QLHTTTSV_TDT] SET  READ_WRITE 
GO
