USE [master]
GO
/****** Object:  Database [DominikSlawkowskiLab3]    Script Date: 23.11.2017 22:00:31 ******/
CREATE DATABASE [DominikSlawkowskiLab3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DominikSlawkowskiLab3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DominikSlawkowskiLab3.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DominikSlawkowskiLab3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DominikSlawkowskiLab3_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DominikSlawkowskiLab3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET ARITHABORT OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET  MULTI_USER 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DominikSlawkowskiLab3]
GO
/****** Object:  Table [dbo].[Actor]    Script Date: 23.11.2017 22:00:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](31) NULL,
	[Surname] [nvarchar](31) NULL,
	[BirthDate] [date] NULL,
 CONSTRAINT [PK_Actor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cast]    Script Date: 23.11.2017 22:00:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cast](
	[Id] [int] NOT NULL,
	[FilmId] [int] NOT NULL,
	[ActorId] [int] NOT NULL,
 CONSTRAINT [PK_Cast] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Film]    Script Date: 23.11.2017 22:00:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](63) NOT NULL,
	[ProductionYear] [smallint] NOT NULL,
	[Duration] [smallint] NOT NULL,
 CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Actor] ON 

INSERT [dbo].[Actor] ([Id], [Name], [Surname], [BirthDate]) VALUES (1, N'Dominik', N'Sławkowski', CAST(N'1997-04-14' AS Date))
INSERT [dbo].[Actor] ([Id], [Name], [Surname], [BirthDate]) VALUES (2, N'Mateusz', N'Kowalski', CAST(N'1998-05-03' AS Date))
INSERT [dbo].[Actor] ([Id], [Name], [Surname], [BirthDate]) VALUES (3, N'Ala', N'Zalewska', CAST(N'1996-03-21' AS Date))
INSERT [dbo].[Actor] ([Id], [Name], [Surname], [BirthDate]) VALUES (4, N'Wojtek', N'Dunaj', CAST(N'1997-06-20' AS Date))
SET IDENTITY_INSERT [dbo].[Actor] OFF
INSERT [dbo].[Cast] ([Id], [FilmId], [ActorId]) VALUES (1, 1, 2)
INSERT [dbo].[Cast] ([Id], [FilmId], [ActorId]) VALUES (2, 2, 1)
INSERT [dbo].[Cast] ([Id], [FilmId], [ActorId]) VALUES (3, 1, 1)
INSERT [dbo].[Cast] ([Id], [FilmId], [ActorId]) VALUES (4, 3, 3)
INSERT [dbo].[Film] ([Id], [Name], [ProductionYear], [Duration]) VALUES (1, N'Milczenie owiec', 2010, 200)
INSERT [dbo].[Film] ([Id], [Name], [ProductionYear], [Duration]) VALUES (2, N'Dzikie historie', 2012, 180)
INSERT [dbo].[Film] ([Id], [Name], [ProductionYear], [Duration]) VALUES (3, N'Pitbull', 2015, 220)
USE [master]
GO
ALTER DATABASE [DominikSlawkowskiLab3] SET  READ_WRITE 
GO
