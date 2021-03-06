USE [master]
GO
/****** Object:  Database [Kviz_projekat]    Script Date: 1/29/2021 1:43:38 AM ******/
CREATE DATABASE [Kviz_projekat]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kviz_projekat', FILENAME = N'D:\Instalacije programa\MSSQL15.MSSQLSERVER\MSSQL\DATA\Kviz_projekat.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kviz_projekat_log', FILENAME = N'D:\Instalacije programa\MSSQL15.MSSQLSERVER\MSSQL\DATA\Kviz_projekat_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Kviz_projekat] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kviz_projekat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kviz_projekat] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kviz_projekat] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kviz_projekat] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kviz_projekat] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kviz_projekat] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kviz_projekat] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kviz_projekat] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kviz_projekat] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kviz_projekat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kviz_projekat] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kviz_projekat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kviz_projekat] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kviz_projekat] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kviz_projekat] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kviz_projekat] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Kviz_projekat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kviz_projekat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kviz_projekat] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kviz_projekat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kviz_projekat] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kviz_projekat] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kviz_projekat] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kviz_projekat] SET RECOVERY FULL 
GO
ALTER DATABASE [Kviz_projekat] SET  MULTI_USER 
GO
ALTER DATABASE [Kviz_projekat] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kviz_projekat] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kviz_projekat] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kviz_projekat] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kviz_projekat] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kviz_projekat] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Kviz_projekat', N'ON'
GO
ALTER DATABASE [Kviz_projekat] SET QUERY_STORE = OFF
GO
USE [Kviz_projekat]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 1/29/2021 1:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[KorisnickoIme] [varchar](50) NOT NULL,
	[Sifra] [varchar](50) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[KorisnickoIme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clan]    Script Date: 1/29/2021 1:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clan](
	[TimID] [int] NOT NULL,
	[RedBr] [int] NOT NULL,
	[JMBG] [varchar](50) NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[DatumRodjenja] [datetime] NULL,
 CONSTRAINT [PK_Clan] PRIMARY KEY CLUSTERED 
(
	[TimID] ASC,
	[RedBr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Duel]    Script Date: 1/29/2021 1:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Duel](
	[DuelID] [int] NOT NULL,
	[DatumVremeOdrzavanja] [datetime] NULL,
	[Voditelj] [varchar](50) NULL,
	[Rezultat] [varchar](50) NULL,
	[Tim1Poeni] [varchar](50) NULL,
	[Tim2Poeni] [varchar](50) NULL,
	[KvizID] [int] NULL,
	[Tim1ID] [int] NULL,
	[Tim2ID] [int] NULL,
 CONSTRAINT [PK_Duel] PRIMARY KEY CLUSTERED 
(
	[DuelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kviz]    Script Date: 1/29/2021 1:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kviz](
	[KvizID] [int] NOT NULL,
	[NazivKviza] [varchar](50) NULL,
 CONSTRAINT [PK_Kviz] PRIMARY KEY CLUSTERED 
(
	[KvizID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tim]    Script Date: 1/29/2021 1:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tim](
	[TimID] [int] NOT NULL,
	[NazivTima] [varchar](50) NULL,
 CONSTRAINT [PK_Tim] PRIMARY KEY CLUSTERED 
(
	[TimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ucesce]    Script Date: 1/29/2021 1:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ucesce](
	[KvizID] [int] NOT NULL,
	[TimID] [int] NOT NULL,
	[DatumUplate] [datetime] NULL,
	[Iznos] [int] NULL,
 CONSTRAINT [PK_Ucesce] PRIMARY KEY CLUSTERED 
(
	[KvizID] ASC,
	[TimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Administrator] ([KorisnickoIme], [Sifra], [Ime], [Prezime]) VALUES (N'marija', N'marija', N'Marija', N'Panic')
GO
INSERT [dbo].[Clan] ([TimID], [RedBr], [JMBG], [Ime], [Prezime], [DatumRodjenja]) VALUES (1, 1, N'12059977805331', N'Petar', N'Peric', CAST(N'1997-12-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Clan] ([TimID], [RedBr], [JMBG], [Ime], [Prezime], [DatumRodjenja]) VALUES (1, 2, N'12059987805331', N'Luka', N'Lukic', CAST(N'2000-10-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Clan] ([TimID], [RedBr], [JMBG], [Ime], [Prezime], [DatumRodjenja]) VALUES (1, 3, N'08099977805331', N'Marko', N'Markovic', CAST(N'1997-08-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Clan] ([TimID], [RedBr], [JMBG], [Ime], [Prezime], [DatumRodjenja]) VALUES (2, 1, N'120498864654', N'Ana', N'Petric', CAST(N'1998-12-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Clan] ([TimID], [RedBr], [JMBG], [Ime], [Prezime], [DatumRodjenja]) VALUES (2, 2, N'08099941565', N'Marko', N'Petrovec', CAST(N'1994-08-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Clan] ([TimID], [RedBr], [JMBG], [Ime], [Prezime], [DatumRodjenja]) VALUES (2, 3, N'141299946544234', N'Teodora', N'Stevic', CAST(N'1998-12-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Clan] ([TimID], [RedBr], [JMBG], [Ime], [Prezime], [DatumRodjenja]) VALUES (3, 1, N'132645465328', N'Nikola', N'Nikolic', CAST(N'1997-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Clan] ([TimID], [RedBr], [JMBG], [Ime], [Prezime], [DatumRodjenja]) VALUES (3, 2, N'54651328898745', N'Andrej', N'Anaric', CAST(N'1995-10-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Clan] ([TimID], [RedBr], [JMBG], [Ime], [Prezime], [DatumRodjenja]) VALUES (3, 3, N'46843213876541', N'Aleksa', N'Karovic', CAST(N'1997-12-18T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Duel] ([DuelID], [DatumVremeOdrzavanja], [Voditelj], [Rezultat], [Tim1Poeni], [Tim2Poeni], [KvizID], [Tim1ID], [Tim2ID]) VALUES (1, CAST(N'2021-01-24T10:00:00.000' AS DateTime), N'Vlada', N'70-67', N'70', N'67', 1, 1, 2)
INSERT [dbo].[Duel] ([DuelID], [DatumVremeOdrzavanja], [Voditelj], [Rezultat], [Tim1Poeni], [Tim2Poeni], [KvizID], [Tim1ID], [Tim2ID]) VALUES (2, CAST(N'2021-01-24T12:15:00.000' AS DateTime), N'Irena', N'127-46', N'60', N'46', 3, 2, 3)
INSERT [dbo].[Duel] ([DuelID], [DatumVremeOdrzavanja], [Voditelj], [Rezultat], [Tim1Poeni], [Tim2Poeni], [KvizID], [Tim1ID], [Tim2ID]) VALUES (3, CAST(N'2020-12-12T14:00:00.000' AS DateTime), N'Majkl', N'132-121', N'62', N'75', 1, 1, 3)
INSERT [dbo].[Duel] ([DuelID], [DatumVremeOdrzavanja], [Voditelj], [Rezultat], [Tim1Poeni], [Tim2Poeni], [KvizID], [Tim1ID], [Tim2ID]) VALUES (4, CAST(N'2021-01-27T10:15:00.000' AS DateTime), N'Vlada', N'206-207', N'79', N'75', 2, 2, 1)
GO
INSERT [dbo].[Kviz] ([KvizID], [NazivKviza]) VALUES (1, N'Fudbal')
INSERT [dbo].[Kviz] ([KvizID], [NazivKviza]) VALUES (2, N'Kosarka')
INSERT [dbo].[Kviz] ([KvizID], [NazivKviza]) VALUES (3, N'Rukomet')
INSERT [dbo].[Kviz] ([KvizID], [NazivKviza]) VALUES (4, N'Futsal')
GO
INSERT [dbo].[Tim] ([TimID], [NazivTima]) VALUES (1, N'Real Madrid')
INSERT [dbo].[Tim] ([TimID], [NazivTima]) VALUES (2, N'Barselona')
INSERT [dbo].[Tim] ([TimID], [NazivTima]) VALUES (3, N'Celzi')
GO
INSERT [dbo].[Ucesce] ([KvizID], [TimID], [DatumUplate], [Iznos]) VALUES (1, 1, CAST(N'2021-01-27T00:00:00.000' AS DateTime), 500)
INSERT [dbo].[Ucesce] ([KvizID], [TimID], [DatumUplate], [Iznos]) VALUES (1, 2, CAST(N'2020-12-10T00:00:00.000' AS DateTime), 1000)
INSERT [dbo].[Ucesce] ([KvizID], [TimID], [DatumUplate], [Iznos]) VALUES (1, 3, CAST(N'2020-12-11T00:00:00.000' AS DateTime), 1500)
INSERT [dbo].[Ucesce] ([KvizID], [TimID], [DatumUplate], [Iznos]) VALUES (2, 1, CAST(N'2021-01-10T00:00:00.000' AS DateTime), 1500)
GO
USE [master]
GO
ALTER DATABASE [Kviz_projekat] SET  READ_WRITE 
GO
