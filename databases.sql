USE [master]
GO
/****** Object:  Database [warung]    Script Date: 07/04/2023 12.51.37 ******/
CREATE DATABASE [warung]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'warung', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\warung.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'warung_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\warung_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [warung] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [warung].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [warung] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [warung] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [warung] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [warung] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [warung] SET ARITHABORT OFF 
GO
ALTER DATABASE [warung] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [warung] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [warung] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [warung] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [warung] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [warung] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [warung] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [warung] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [warung] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [warung] SET  DISABLE_BROKER 
GO
ALTER DATABASE [warung] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [warung] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [warung] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [warung] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [warung] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [warung] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [warung] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [warung] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [warung] SET  MULTI_USER 
GO
ALTER DATABASE [warung] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [warung] SET DB_CHAINING OFF 
GO
ALTER DATABASE [warung] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [warung] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [warung] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [warung] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [warung] SET QUERY_STORE = ON
GO
ALTER DATABASE [warung] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [warung]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 07/04/2023 12.51.38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[IdMenu] [int] NOT NULL,
	[Nama] [varchar](64) NULL,
	[Harga] [varchar](10) NULL,
	[Gambar] [image] NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[IdMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[passwd]    Script Date: 07/04/2023 12.51.38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[passwd](
	[userid] [varchar](100) NOT NULL,
	[password] [varchar](100) NULL,
	[role] [varchar](50) NOT NULL,
 CONSTRAINT [PK_passwd] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transaksi]    Script Date: 07/04/2023 12.51.38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transaksi](
	[kode] [bigint] NOT NULL,
	[id] [bigint] NULL,
	[nama] [varchar](50) NULL,
	[jumlah] [int] NULL,
	[tanggal] [varchar](50) NULL,
	[total_harga] [int] NULL,
 CONSTRAINT [PK_transaksi] PRIMARY KEY CLUSTERED 
(
	[kode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [warung] SET  READ_WRITE 
GO
