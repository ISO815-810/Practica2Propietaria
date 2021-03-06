USE [master]
GO
/****** Object:  Database [AsientosContables]    Script Date: 2/2/2019 9:54:26 a. m. ******/
CREATE DATABASE [AsientosContables]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AsientosContables', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\AsientosContables.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AsientosContables_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\AsientosContables_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AsientosContables] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AsientosContables].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AsientosContables] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AsientosContables] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AsientosContables] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AsientosContables] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AsientosContables] SET ARITHABORT OFF 
GO
ALTER DATABASE [AsientosContables] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AsientosContables] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AsientosContables] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AsientosContables] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AsientosContables] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AsientosContables] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AsientosContables] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AsientosContables] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AsientosContables] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AsientosContables] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AsientosContables] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AsientosContables] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AsientosContables] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AsientosContables] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AsientosContables] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AsientosContables] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AsientosContables] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AsientosContables] SET RECOVERY FULL 
GO
ALTER DATABASE [AsientosContables] SET  MULTI_USER 
GO
ALTER DATABASE [AsientosContables] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AsientosContables] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AsientosContables] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AsientosContables] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AsientosContables] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AsientosContables', N'ON'
GO
ALTER DATABASE [AsientosContables] SET QUERY_STORE = OFF
GO
USE [AsientosContables]
GO
/****** Object:  Table [dbo].[AsientoContableSet]    Script Date: 2/2/2019 9:54:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsientoContableSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NoAsiento] [int] NOT NULL,
	[DescripcionAsiento] [nvarchar](300) NOT NULL,
	[FechaAsiento] [datetime] NOT NULL,
	[TipoMovimiento] [int] NOT NULL,
	[Monto] [decimal](18, 0) NOT NULL,
	[CuentaContable] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_AsientoContableSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AsientoContableSet] ON 

INSERT [dbo].[AsientoContableSet] ([Id], [NoAsiento], [DescripcionAsiento], [FechaAsiento], [TipoMovimiento], [Monto], [CuentaContable]) VALUES (1, 123, N'primer', CAST(N'2019-02-01T00:00:00.000' AS DateTime), 0, CAST(2300 AS Decimal(18, 0)), N'23')
INSERT [dbo].[AsientoContableSet] ([Id], [NoAsiento], [DescripcionAsiento], [FechaAsiento], [TipoMovimiento], [Monto], [CuentaContable]) VALUES (2, 1, N'lorem ipsum', CAST(N'2018-11-06T00:00:00.000' AS DateTime), 0, CAST(100000 AS Decimal(18, 0)), N'1101')
INSERT [dbo].[AsientoContableSet] ([Id], [NoAsiento], [DescripcionAsiento], [FechaAsiento], [TipoMovimiento], [Monto], [CuentaContable]) VALUES (3, 2, N'dolor sit amet', CAST(N'2019-01-01T00:00:00.000' AS DateTime), 1, CAST(500000 AS Decimal(18, 0)), N'1250')
INSERT [dbo].[AsientoContableSet] ([Id], [NoAsiento], [DescripcionAsiento], [FechaAsiento], [TipoMovimiento], [Monto], [CuentaContable]) VALUES (4, 2, N'loqueseawawawa', CAST(N'2019-12-02T00:00:00.000' AS DateTime), 1, CAST(2300000 AS Decimal(18, 0)), N'1100')
INSERT [dbo].[AsientoContableSet] ([Id], [NoAsiento], [DescripcionAsiento], [FechaAsiento], [TipoMovimiento], [Monto], [CuentaContable]) VALUES (5, 1, N'lorem ipsum', CAST(N'2018-11-06T00:00:00.000' AS DateTime), 0, CAST(100000 AS Decimal(18, 0)), N'1101')
INSERT [dbo].[AsientoContableSet] ([Id], [NoAsiento], [DescripcionAsiento], [FechaAsiento], [TipoMovimiento], [Monto], [CuentaContable]) VALUES (6, 2, N'dolor sit amet', CAST(N'2019-01-01T00:00:00.000' AS DateTime), 1, CAST(500000 AS Decimal(18, 0)), N'1250')
INSERT [dbo].[AsientoContableSet] ([Id], [NoAsiento], [DescripcionAsiento], [FechaAsiento], [TipoMovimiento], [Monto], [CuentaContable]) VALUES (7, 12, N'un asiento', CAST(N'2019-02-01T00:00:00.000' AS DateTime), 0, CAST(23000000000 AS Decimal(18, 0)), N'3306')
INSERT [dbo].[AsientoContableSet] ([Id], [NoAsiento], [DescripcionAsiento], [FechaAsiento], [TipoMovimiento], [Monto], [CuentaContable]) VALUES (8, 7, N'Carol Lewis', CAST(N'2018-12-15T00:00:00.000' AS DateTime), 1, CAST(90000 AS Decimal(18, 0)), N'1125')
INSERT [dbo].[AsientoContableSet] ([Id], [NoAsiento], [DescripcionAsiento], [FechaAsiento], [TipoMovimiento], [Monto], [CuentaContable]) VALUES (9, 13, N'Prro :V', CAST(N'2019-02-14T00:00:00.000' AS DateTime), 0, CAST(500 AS Decimal(18, 0)), N'3252')
SET IDENTITY_INSERT [dbo].[AsientoContableSet] OFF
USE [master]
GO
ALTER DATABASE [AsientosContables] SET  READ_WRITE 
GO
