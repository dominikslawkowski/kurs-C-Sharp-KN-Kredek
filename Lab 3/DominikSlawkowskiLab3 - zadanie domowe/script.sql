USE [master]
GO
/****** Object:  Database [Wypożyczalnia_samochodów]    Script Date: 20.04.2017 00:08:55 ******/
CREATE DATABASE [Wypożyczalnia_samochodów]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Wypożyczalnia_samochodów', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Wypożyczalnia_samochodów.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Wypożyczalnia_samochodów_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Wypożyczalnia_samochodów_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Wypożyczalnia_samochodów].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET ARITHABORT OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET  MULTI_USER 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Wypożyczalnia_samochodów]
GO
/****** Object:  Table [dbo].[Biblioteka]    Script Date: 20.04.2017 00:08:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Biblioteka](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](50) NULL,
	[Autor] [nvarchar](50) NULL,
	[IDUcznia] [int] NULL,
 CONSTRAINT [PK_Biblioteka] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Klienci]    Script Date: 20.04.2017 00:08:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klienci](
	[ID] [int] NOT NULL,
	[Imię] [nvarchar](50) NOT NULL,
	[Nazwisko] [nvarchar](50) NOT NULL,
	[Miejscowość] [nvarchar](50) NOT NULL,
	[Opłata z góry] [money] NOT NULL,
 CONSTRAINT [PK_Klienci] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KlubyWrocławskie]    Script Date: 20.04.2017 00:08:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KlubyWrocławskie](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa klubu] [nvarchar](50) NOT NULL,
	[Położenie] [nvarchar](50) NOT NULL,
	[Wstęp] [int] NOT NULL,
	[IDOpisu] [int] NULL,
 CONSTRAINT [PK_KlubyWrocławskie] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OpisWrocławskichKlubów]    Script Date: 20.04.2017 00:08:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OpisWrocławskichKlubów](
	[ID] [int] NOT NULL,
	[Opis] [ntext] NOT NULL,
	[Ilość gwiazdek] [int] NOT NULL,
 CONSTRAINT [PK_OpisWrocławskichKlubów] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Samochody]    Script Date: 20.04.2017 00:08:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Samochody](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Marka] [nvarchar](50) NOT NULL,
	[Rocznik] [int] NOT NULL,
	[Przebieg] [int] NOT NULL,
	[Kolor] [nvarchar](50) NOT NULL,
	[IDKlienta] [int] NULL,
 CONSTRAINT [PK_Samochody] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Uczniowie]    Script Date: 20.04.2017 00:08:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uczniowie](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Imię] [nchar](10) NOT NULL,
	[Nazwisko] [nchar](10) NOT NULL,
	[Klasa] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Uczniowie] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Biblioteka] ON 

INSERT [dbo].[Biblioteka] ([ID], [Nazwa], [Autor], [IDUcznia]) VALUES (1, N'Zemsta', N'Aleksander Fredro', 1)
INSERT [dbo].[Biblioteka] ([ID], [Nazwa], [Autor], [IDUcznia]) VALUES (2, N'Romeo i Julia', N'William Szekspir', 2)
INSERT [dbo].[Biblioteka] ([ID], [Nazwa], [Autor], [IDUcznia]) VALUES (3, N'Granica', N'Zofia Nałkowska', 3)
SET IDENTITY_INSERT [dbo].[Biblioteka] OFF
INSERT [dbo].[Klienci] ([ID], [Imię], [Nazwisko], [Miejscowość], [Opłata z góry]) VALUES (1, N'Dominik', N'Sławkowski', N'Zielona Góra', 0.0000)
INSERT [dbo].[Klienci] ([ID], [Imię], [Nazwisko], [Miejscowość], [Opłata z góry]) VALUES (2, N'Wojciech', N'Dunaj', N'Kraków', 300.0000)
INSERT [dbo].[Klienci] ([ID], [Imię], [Nazwisko], [Miejscowość], [Opłata z góry]) VALUES (3, N'Mateusz', N'Witkowski', N'Wrocław', 200.0000)
INSERT [dbo].[Klienci] ([ID], [Imię], [Nazwisko], [Miejscowość], [Opłata z góry]) VALUES (4, N'Piotr', N'Nowak', N'Zielona Góra', 0.0000)
INSERT [dbo].[Klienci] ([ID], [Imię], [Nazwisko], [Miejscowość], [Opłata z góry]) VALUES (5, N'Michał', N'Drozda', N'Poznań', 150.0000)
SET IDENTITY_INSERT [dbo].[KlubyWrocławskie] ON 

INSERT [dbo].[KlubyWrocławskie] ([ID], [Nazwa klubu], [Położenie], [Wstęp], [IDOpisu]) VALUES (1, N'Wall Street', N'Niepold', 15, 1)
INSERT [dbo].[KlubyWrocławskie] ([ID], [Nazwa klubu], [Położenie], [Wstęp], [IDOpisu]) VALUES (2, N'Bezsenność', N'Niepold', 10, 2)
INSERT [dbo].[KlubyWrocławskie] ([ID], [Nazwa klubu], [Położenie], [Wstęp], [IDOpisu]) VALUES (3, N'Mundo', N'Niepold', 15, 3)
INSERT [dbo].[KlubyWrocławskie] ([ID], [Nazwa klubu], [Położenie], [Wstęp], [IDOpisu]) VALUES (4, N'Das Lokal', N'Rynek', 30, 4)
INSERT [dbo].[KlubyWrocławskie] ([ID], [Nazwa klubu], [Położenie], [Wstęp], [IDOpisu]) VALUES (5, N'Piętro Niżej', N'Rynek', 20, 5)
INSERT [dbo].[KlubyWrocławskie] ([ID], [Nazwa klubu], [Położenie], [Wstęp], [IDOpisu]) VALUES (6, N'Banana Club', N'Rynek', 10, 6)
INSERT [dbo].[KlubyWrocławskie] ([ID], [Nazwa klubu], [Położenie], [Wstęp], [IDOpisu]) VALUES (7, N'Uff', N'Rynek', 10, 7)
SET IDENTITY_INSERT [dbo].[KlubyWrocławskie] OFF
INSERT [dbo].[OpisWrocławskichKlubów] ([ID], [Opis], [Ilość gwiazdek]) VALUES (1, N'Muzyka z szarpnięciem, ale ostatnio mało dziewczyn :((', 4)
INSERT [dbo].[OpisWrocławskichKlubów] ([ID], [Opis], [Ilość gwiazdek]) VALUES (2, N'Dużo dziewczyn, ale tłok jak pod dziekanatem', 4)
INSERT [dbo].[OpisWrocławskichKlubów] ([ID], [Opis], [Ilość gwiazdek]) VALUES (3, N'Niby fajnie, ale jakiś lewy ten klub', 3)
INSERT [dbo].[OpisWrocławskichKlubów] ([ID], [Opis], [Ilość gwiazdek]) VALUES (4, N'Techno na poziomie 8)', 5)
INSERT [dbo].[OpisWrocławskichKlubów] ([ID], [Opis], [Ilość gwiazdek]) VALUES (5, N'Jak D''n''B czy tekno wleci to nie ma co zbierać B)', 6)
INSERT [dbo].[OpisWrocławskichKlubów] ([ID], [Opis], [Ilość gwiazdek]) VALUES (6, N'Wieś', -1)
INSERT [dbo].[OpisWrocławskichKlubów] ([ID], [Opis], [Ilość gwiazdek]) VALUES (7, N'}) Wixapolu w Uffie ({ ło Jezu <3', 100)
SET IDENTITY_INSERT [dbo].[Samochody] ON 

INSERT [dbo].[Samochody] ([ID], [Marka], [Rocznik], [Przebieg], [Kolor], [IDKlienta]) VALUES (1, N'Audi', 2005, 40000, N'Czerwony', 5)
INSERT [dbo].[Samochody] ([ID], [Marka], [Rocznik], [Przebieg], [Kolor], [IDKlienta]) VALUES (2, N'BMW', 2010, 20000, N'Granatowy', 2)
INSERT [dbo].[Samochody] ([ID], [Marka], [Rocznik], [Przebieg], [Kolor], [IDKlienta]) VALUES (3, N'Ford', 1999, 65000, N'Czarny', 4)
INSERT [dbo].[Samochody] ([ID], [Marka], [Rocznik], [Przebieg], [Kolor], [IDKlienta]) VALUES (4, N'Honda', 2012, 15000, N'Szary', 3)
INSERT [dbo].[Samochody] ([ID], [Marka], [Rocznik], [Przebieg], [Kolor], [IDKlienta]) VALUES (5, N'Volkswagen', 1997, 100000, N'Czarny', 5)
SET IDENTITY_INSERT [dbo].[Samochody] OFF
SET IDENTITY_INSERT [dbo].[Uczniowie] ON 

INSERT [dbo].[Uczniowie] ([ID], [Imię], [Nazwisko], [Klasa]) VALUES (1, N'Dominik   ', N'Sławkowski', N'3d        ')
INSERT [dbo].[Uczniowie] ([ID], [Imię], [Nazwisko], [Klasa]) VALUES (2, N'Wojciech  ', N'Dunaj     ', N'3a        ')
INSERT [dbo].[Uczniowie] ([ID], [Imię], [Nazwisko], [Klasa]) VALUES (3, N'Mateusz   ', N'Witkowski ', N'3e        ')
SET IDENTITY_INSERT [dbo].[Uczniowie] OFF
ALTER TABLE [dbo].[Biblioteka]  WITH CHECK ADD  CONSTRAINT [FK_Biblioteka_Uczniowie] FOREIGN KEY([IDUcznia])
REFERENCES [dbo].[Uczniowie] ([ID])
GO
ALTER TABLE [dbo].[Biblioteka] CHECK CONSTRAINT [FK_Biblioteka_Uczniowie]
GO
ALTER TABLE [dbo].[Klienci]  WITH CHECK ADD  CONSTRAINT [FK_Klienci_Samochody] FOREIGN KEY([ID])
REFERENCES [dbo].[Samochody] ([ID])
GO
ALTER TABLE [dbo].[Klienci] CHECK CONSTRAINT [FK_Klienci_Samochody]
GO
ALTER TABLE [dbo].[KlubyWrocławskie]  WITH CHECK ADD  CONSTRAINT [FK_KlubyWrocławskie_OpisWrocławskichKlubów] FOREIGN KEY([IDOpisu])
REFERENCES [dbo].[OpisWrocławskichKlubów] ([ID])
GO
ALTER TABLE [dbo].[KlubyWrocławskie] CHECK CONSTRAINT [FK_KlubyWrocławskie_OpisWrocławskichKlubów]
GO
ALTER TABLE [dbo].[OpisWrocławskichKlubów]  WITH CHECK ADD  CONSTRAINT [FK_OpisWrocławskichKlubów_OpisWrocławskichKlubów] FOREIGN KEY([ID])
REFERENCES [dbo].[OpisWrocławskichKlubów] ([ID])
GO
ALTER TABLE [dbo].[OpisWrocławskichKlubów] CHECK CONSTRAINT [FK_OpisWrocławskichKlubów_OpisWrocławskichKlubów]
GO
ALTER TABLE [dbo].[Samochody]  WITH CHECK ADD  CONSTRAINT [FK_Samochody_Samochody] FOREIGN KEY([ID])
REFERENCES [dbo].[Samochody] ([ID])
GO
ALTER TABLE [dbo].[Samochody] CHECK CONSTRAINT [FK_Samochody_Samochody]
GO
ALTER TABLE [dbo].[Uczniowie]  WITH CHECK ADD  CONSTRAINT [FK_Uczniowie_Uczniowie] FOREIGN KEY([ID])
REFERENCES [dbo].[Uczniowie] ([ID])
GO
ALTER TABLE [dbo].[Uczniowie] CHECK CONSTRAINT [FK_Uczniowie_Uczniowie]
GO
USE [master]
GO
ALTER DATABASE [Wypożyczalnia_samochodów] SET  READ_WRITE 
GO
