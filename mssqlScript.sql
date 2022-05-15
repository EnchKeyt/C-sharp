USE [master]
GO
/****** Object:  Database [ws08]    Script Date: 18.02.2022 10:49:15 ******/
CREATE DATABASE [ws08]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'wsdemo8', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\wsdemo8.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'wsdemo8_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\wsdemo8_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ws08] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ws08].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ws08] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ws08] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ws08] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ws08] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ws08] SET ARITHABORT OFF 
GO
ALTER DATABASE [ws08] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ws08] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ws08] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ws08] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ws08] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ws08] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ws08] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ws08] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ws08] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ws08] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ws08] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ws08] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ws08] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ws08] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ws08] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ws08] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ws08] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ws08] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ws08] SET  MULTI_USER 
GO
ALTER DATABASE [ws08] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ws08] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ws08] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ws08] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ws08] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ws08] SET QUERY_STORE = OFF
GO
USE [ws08]
GO
/****** Object:  User [ws08]    Script Date: 18.02.2022 10:49:16 ******/
CREATE USER [ws08] FOR LOGIN [ws08] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [ws08]
GO
/****** Object:  Table [dbo].[AbonentDevices]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AbonentDevices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SerNumber] [nvarchar](100) NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Ports] [nvarchar](100) NOT NULL,
	[StandartMove] [nvarchar](500) NOT NULL,
	[Speed] [nvarchar](100) NOT NULL,
	[Location] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_AbonentDevices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Abonents]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abonents](
	[IdAbonent] [int] IDENTITY(1,1) NOT NULL,
	[LFM] [nvarchar](150) NOT NULL,
	[IdMF] [int] NOT NULL,
	[Birthday] [date] NOT NULL,
	[NumberPhone] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
	[AdressPasport] [nvarchar](150) NOT NULL,
	[AdressReal] [nvarchar](150) NOT NULL,
	[SerAndNumPasport] [nvarchar](50) NOT NULL,
	[CodePPasport] [nvarchar](10) NOT NULL,
	[WhoDropPasport] [nvarchar](150) NOT NULL,
	[DateDropPasport] [date] NOT NULL,
	[NumberDoc] [nvarchar](50) NOT NULL,
	[DateCreateDoc] [date] NOT NULL,
	[IdTypeDoc] [int] NOT NULL,
	[CommentDestroyDoc] [nvarchar](50) NULL,
	[LS] [nvarchar](50) NOT NULL,
	[IdServices] [int] NOT NULL,
	[DateDestroyDoc] [date] NULL,
	[DocArend] [nvarchar](50) NULL,
	[SerNumDevice] [nvarchar](50) NOT NULL,
	[NumberAbonent] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Abonents] PRIMARY KEY CLUSTERED 
(
	[IdAbonent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComboTarifs]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComboTarifs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ComboTarifs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Devices]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SerNumber] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Devices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LineDevices]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LineDevices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SerNumber] [nvarchar](50) NOT NULL,
	[Port] [int] NOT NULL,
	[StandartMoveData] [nvarchar](50) NOT NULL,
	[Chast] [nvarchar](50) NOT NULL,
	[Interfaces] [nvarchar](50) NOT NULL,
	[SpeedMoveData] [nvarchar](50) NOT NULL,
	[Location] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LineDevices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Magistrals]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Magistrals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Chast] [nvarchar](30) NOT NULL,
	[CaefZatyx] [int] NULL,
	[TehMoveData] [nvarchar](30) NOT NULL,
	[Location] [nvarchar](100) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[SerNumber] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Magistrals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MF]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MF](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MF] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderCRM]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderCRM](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumberOrder] [nvarchar](100) NOT NULL,
	[DateCreate] [date] NOT NULL,
	[LS] [nvarchar](50) NOT NULL,
	[Services] [nvarchar](50) NOT NULL,
	[VidServices] [nvarchar](150) NOT NULL,
	[TypeServices] [nvarchar](150) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
	[Problem] [nvarchar](150) NULL,
	[DateClose] [date] NULL,
	[TypeProblem] [nvarchar](50) NOT NULL,
	[Device] [nvarchar](100) NULL,
 CONSTRAINT [PK_OrderCRM] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[IdRole] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[IdRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staffs](
	[IdStaff] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
	[IdRole] [int] NOT NULL,
	[PhotoPatch] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Staffs] PRIMARY KEY CLUSTERED 
(
	[IdStaff] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StreetSPB]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StreetSPB](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameStreet] [nvarchar](50) NOT NULL,
	[Ploshad] [nvarchar](50) NOT NULL,
	[CountPeople] [int] NOT NULL,
	[CountMetro] [int] NOT NULL,
	[TypeBuild] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StreetSPB] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarifs]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarifs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdService] [int] NOT NULL,
	[NameTarif] [nvarchar](50) NOT NULL,
	[Yslov] [nvarchar](100) NOT NULL,
	[Price] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tarifs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypesDoc]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypesDoc](
	[IdTypeDoc] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TypesDoc] PRIMARY KEY CLUSTERED 
(
	[IdTypeDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 18.02.2022 10:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LoginNumber] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[FIO] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AbonentDevices] ON 

INSERT [dbo].[AbonentDevices] ([Id], [SerNumber], [Name], [Ports], [StandartMove], [Speed], [Location]) VALUES (1, N'АО567-ТНС-11', N'Точка доступа HP ProCurve ', N'RG 45
', N'802.11', N'до 35 Мбит/с', N'1077:10:18;8002Б:5:13;1155:11:12;1253:6:18;1675:1:25;1155:0:19;1070:0:16;8007:45:20;8002В:0:26;7507:0:26;1078:4:17;1083:2:15;1088:10:61;1249А:1:3;1675:1:23;1690:4:10;1675:1:39;7507:15:58;1720:3:13;8004:0:107;1686:3:5;8002Б:6:45; ')
INSERT [dbo].[AbonentDevices] ([Id], [SerNumber], [Name], [Ports], [StandartMove], [Speed], [Location]) VALUES (2, N'АО567-ТНС-12', N'Точка доступа TP-Link TL-WA701ND ', N'RG 45, Thunderbolt, USB
', N'802.11', N'до 45 Мбит/с', N'1005:11:9;1658:11:12;1257:3:33;1688:3:29;1006:4:5;1006:4:3;1079:0:21;1622:6:60;1634:0:31;7501Б:66:148;1005:0:87;1657:0:73;8002В:0:52;1154:0:32;1069:0:30;1664:0:95;1089:2:32;1094:0:29;1675:1:1;1664:34:82')
INSERT [dbo].[AbonentDevices] ([Id], [SerNumber], [Name], [Ports], [StandartMove], [Speed], [Location]) VALUES (3, N'АО567-ТНС-13', N'Точка доступа Sitecom WLX-2000 ', N'RG 45
', N'802.11', N'100 Мбит/с', N'1720:3:12;1004:5:26;7507:0:57;1079:0:14;1079:0:18;1616:7:23;1616:7:24;1617:1002:43;1247:0:24;1663:27:51;1163:7:17;1247:5:7;1719:0:11;1720:0:14;1720:0:16;7503:0:29;8002В:0:9;7501Б:75:52;7501Б:74:131;8006:28:39;1634:0:29;1070:0:20')
INSERT [dbo].[AbonentDevices] ([Id], [SerNumber], [Name], [Ports], [StandartMove], [Speed], [Location]) VALUES (4, N'АО567-ТНС-14', N'Точка доступа Buffalo AirStation N300 Dual Band ', N'45', N'802.11', N'до 300 Мбит/с', N'1617:21:19;1687:5:15;1165:3:10;1058:35:29;1161:2:3;8006:0:16;8006:0:24;8007:0:47;1675:0:15;1675:0:46;1676:0:25;1676:0:27;1676:0:42;1676:0:5;1678:0:16;1719:0:87;1059:0:172;1155:0:52;1291:26:14;1253:5:14;1072:2:14;1155:12:14;1079:9:10;1657:17:10;1253:5:15')
SET IDENTITY_INSERT [dbo].[AbonentDevices] OFF
GO
SET IDENTITY_INSERT [dbo].[Abonents] ON 

INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (33, N'Маслака Жанна Петровна', 2, CAST(N'1981-10-22' AS Date), N'+7 (969) 681-71-93', N'janna22101981@mail.ru', N'Россия, г. Ставрополь, ЯнкиКупалы ул., д. 16 кв.118', N'1077:10:18', N'4282 450721', N'610-512', N'ОВД России по г. Артем', CAST(N'2021-05-11' AS Date), N'78А000001-1 - 2018', CAST(N'2018-01-01' AS Date), 1, N'', N'785493417', 1, NULL, N'', N'АО567-ТНС-11', N'78А000001')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (34, N'Янов Игнатий Тимофеевич', 1, CAST(N'1987-09-04' AS Date), N'+7 (907) 675-91-40', N'ignatiy1987@yandex.ru', N'Россия, г. Дербент, Речной пер., д. 16 кв.51', N'1155:11:12', N'4439 706015', N'200-608', N'Отделением УФМС России в г. Тольятти', CAST(N'2013-01-01' AS Date), N'78А000003-3 - 2018', CAST(N'2018-03-03' AS Date), 1, N'', N'785493419', 1, NULL, N'', N'АО567-ТНС-13', N'78А000003')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (35, N'Быкова Ольга Герасимовна', 2, CAST(N'1971-04-28' AS Date), N'+7 (980) 165-72-86', N'olga21@yandex.ru', N'Россия, г. Люберцы, Максима Горького ул., д. 4 кв.144', N'1155:0:19', N'4774 849631', N'770-592', N'Управление внутренних дел по г. Пушкино', CAST(N'2020-08-05' AS Date), N'78А000006-6 - 2019', CAST(N'2019-06-06' AS Date), 1, N'', N'785493422', 1, NULL, N'', N'АО567-ТНС-12', N'78А000006')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (36, N'Илюшин Тимофей Савванович', 1, CAST(N'1965-09-05' AS Date), N'+7 (927) 221-17-95', N'timofey05091965@yandex.ru', N'Россия, г. Щёлково, Дружбы ул., д. 17 кв.19', N'8007:45:20', N'4085 748295', N'170-522', N'Отделом УФМС России по г. Брянск', CAST(N'2019-04-25' AS Date), N'78А000008-8 - 2019', CAST(N'2019-08-08' AS Date), 2, N'', N'785493424', 1, NULL, N'', N'АО567-ТНС-14', N'78А000008')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (37, N'Левковича Василиса Вячеславовна', 2, CAST(N'1988-11-16' AS Date), N'+7 (938) 249-10-91', N'vasilisa1988@yandex.ru', N'Россия, г. Владимир, Чапаева ул., д. 7 кв.212', N'7507:0:26', N'4071 593651', N'250-758', N'Отделением УФМС России по г. Йошкар-Ола', CAST(N'2014-08-04' AS Date), N'78А000010-10 - 2019', CAST(N'2019-10-10' AS Date), 1, N'Переезд', N'785493426', 1, CAST(N'2020-10-12' AS Date), N'', N'АО567-ТНС-12', N'78А000010')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (38, N'Шеляпин Роман Викторович', 1, CAST(N'1968-05-10' AS Date), N'+7 (933) 954-75-29', N'roman10051968@hotmail.com', N'Россия, г. Ярославль, Первомайская ул., д. 19 кв.122', N'1088:10:61', N'4148 271134', N'570-755', N'Отделением УФМС России по г. Москва', CAST(N'2012-09-02' AS Date), N'78А000013-5 - 2019', CAST(N'2019-05-13' AS Date), 1, N'Переезд', N'785493429', 1, CAST(N'2021-07-22' AS Date), N'', N'АО567-ТНС-11', N'78А000013')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (39, N'Стукалов Яков Ильич', 1, CAST(N'1966-05-21' AS Date), N'+7 (940) 476-89-72', N'yakov2699@outlook.com', N'Россия, г. Пушкино, Радужная ул., д. 20 кв.100', N'1006:4:5', N'4098 479713', N'900-684', N'Управление внутренних дел по г. Йошкар-Ола', CAST(N'2012-05-27' AS Date), N'78А000016-8 - 2019', CAST(N'2019-08-16' AS Date), 1, N'', N'785493432', 1, NULL, N'', N'АО567-ТНС-14', N'78А000016')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (40, N'Золотова Рада Юлиановна', 2, CAST(N'1984-07-01' AS Date), N'+7 (982) 913-95-79', N'rada29@rambler.ru', N'Россия, г. Нальчик, Гагарина ул., д. 12 кв.155', N'1622:6:60', N'4438 240819', N'720-540', N'ОУФМС России по г. Долгопрудный', CAST(N'2019-09-03' AS Date), N'78А000020-8 - 2018', CAST(N'2018-08-20' AS Date), 1, N'Переезд', N'785493436', 1, CAST(N'2019-06-17' AS Date), N'', N'АО567-ТНС-14', N'78А000020')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (41, N'Ярмоленко Ева Серафимовна', 2, CAST(N'1992-02-17' AS Date), N'+7 (954) 426-46-81', N'eva1992@ya.ru', N'Россия, г. Екатеринбург, Октябрьский пер., д. 12 кв.21', N'1657:0:73', N'4677 708908', N'880-626', N'Отделением УФМС России по г. Элиста', CAST(N'2015-08-05' AS Date), N'78А000024-4 - 2020', CAST(N'2020-04-24' AS Date), 1, N'', N'785493440', 1, NULL, N'', N'АО567-ТНС-14', N'78А000024')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (42, N'Тизенгаузена Светлана Георгьевна', 2, CAST(N'1973-02-22' AS Date), N'+7 (912) 930-82-23', N'svetlana57@gmail.com', N'Россия, г. Новошахтинск, Гагарина ул., д. 21 кв.101', N'1069:0:30', N'4321 448056', N'530-343', N'Отделом внутренних дел России по г. Брянск', CAST(N'2014-04-27' AS Date), N'78А000027-2 - 2020', CAST(N'2020-02-27' AS Date), 1, N'', N'785493443', 1, NULL, N'', N'АО567-ТНС-13', N'78А000027')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (43, N'Ёжиков Валерий Давидович', 1, CAST(N'1982-09-03' AS Date), N'+7 (947) 786-92-96', N'valeriy77@yandex.ru', N'Россия, г. Коломна, Ленина В.И.ул., д. 14 кв.87', N'1094:0:29', N'4716 277897', N'110-284', N'Отделом УФМС России по г. Орёл', CAST(N'2012-05-06' AS Date), N'78А000030-5 - 2020', CAST(N'2020-05-02' AS Date), 1, N'', N'785493446', 1, NULL, N'', N'АО567-ТНС-12', N'78А000030')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (44, N'Сазонтов Илья Панкратович', 1, CAST(N'1968-10-01' AS Date), N'+7 (939) 963-15-37', N'ilya86@hotmail.com', N'Россия, г. Тюмень, Колхозная ул., д. 16 кв.219', N'1675:1:23', N'4078 955891', N'430-593', N'Отделением УФМС России по г. Улан-Удэ', CAST(N'2019-11-24' AS Date), N'78П000002-7 - 2020', CAST(N'2020-07-04' AS Date), 1, N'', N'785493448', 1, NULL, N'', N'АО567-ТНС-14', N'78П000002')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (45, N'Корявина Екатерина Васильевна', 2, CAST(N'1968-05-07' AS Date), N'+7 (972) 832-62-78', N'ekaterina2832@outlook.com', N'Россия, г. Подольск, Озерный пер., д. 3 кв.180', N'7507:15:58', N'4674 163981', N'440-136', N'Отделом УФМС России по г. Краснодар', CAST(N'2017-11-21' AS Date), N'78П000005-10 - 2020', CAST(N'2020-10-07' AS Date), 1, N'', N'785493451', 1, NULL, N'', N'АО567-ТНС-13', N'78П000005')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (46, N'Коровин Прохор Яковеевичевич', 1, CAST(N'1967-06-01' AS Date), N'+7 (976) 211-74-35', N'prohor7239@rambler.ru', N'Россия, г. Саратов, Октябрьская ул., д. 22 кв.205', N'1686:3:5', N'4881 213142', N'560-494', N'Отделением УФМС России по г. Тула', CAST(N'2020-11-11' AS Date), N'78П000008-5 - 2020', CAST(N'2020-05-10' AS Date), 1, N'Переезд', N'785493454', 1, CAST(N'2020-12-25' AS Date), N'', N'АО567-ТНС-12', N'78П000008')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (47, N'Сотникова Рада Алексеевна', 2, CAST(N'1969-02-08' AS Date), N'+7 (961) 256-78-85', N'rada.sotnikova@outlook.com', N'Россия, г. Петропавловск-Камчатский, Центральный пер., д. 15 кв.55', N'1005:11:9', N'4214 784297', N'900-632', N'Отделением УФМС России в г. Первоуральск', CAST(N'2015-03-03' AS Date), N'78П000010-7 - 2020', CAST(N'2020-07-12' AS Date), 1, N'', N'785493456', 1, NULL, N'', N'АО567-ТНС-14', N'78П000010')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (48, N'Онипченко Иван Яковлевич', 1, CAST(N'1981-02-17' AS Date), N'+7 (976) 919-27-53', N'ivan8381@hotmail.com', N'Россия, г. Шахты, Мирная ул., д. 2 кв.89', N'1720:3:12', N'4312 568195', N'310-996', N'Отделением УФМС России по г. Петропавловск-Камчатский', CAST(N'2013-01-29' AS Date), N'78П000014-7 - 2020', CAST(N'2020-07-16' AS Date), 1, N'', N'785493460', 1, NULL, N'', N'АО567-ТНС-14', N'78П000014')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (49, N'Сазонтова Инна Никитьевна', 2, CAST(N'1965-01-20' AS Date), N'+7 (963) 328-58-26', N'inna20011965@mail.ru', N'Россия, г. Улан-Удэ, Озерная ул., д. 22 кв.22', N'1004:5:26', N'4066 999471', N'450-296', N'ОВД России по г. Ноябрьск', CAST(N'2020-03-17' AS Date), N'78П000015-8 - 2020', CAST(N'2020-08-17' AS Date), 1, N'', N'785493461', 1, NULL, N'Договор аренды от 17.8.2020', N'АО567-ТНС-11', N'78П000015')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (50, N'Викашева Юлиана Прокловна', 2, CAST(N'1965-05-01' AS Date), N'+7 (986) 669-21-71', N'yuliana01051965@outlook.com', N'Россия, г. Реутов, Цветочная ул., д. 22 кв.60', N'1079:0:14', N'4944 608863', N'520-843', N'Отделением УФМС России в г. Мурманск', CAST(N'2015-09-17' AS Date), N'78П000017-2 - 2018', CAST(N'2018-02-19' AS Date), 1, N'', N'785493463', 1, NULL, N'', N'АО567-ТНС-13', N'78П000017')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (51, N'Забирова Анастасия Ильиновна', 2, CAST(N'1988-01-20' AS Date), N'+7 (920) 761-80-24', N'anastasiya5199@mail.ru', N'Россия, г. Вологда, Севернаяул., д. 23 кв.192', N'1079:0:18', N'4977 360062', N'320-709', N'ОУФМС России по г. Королёв', CAST(N'2018-06-04' AS Date), N'78П000018-3 - 2018', CAST(N'2018-03-20' AS Date), 1, N'', N'785493464', 1, NULL, N'', N'АО567-ТНС-14', N'78П000018')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (52, N'Чилаев Филипп Власович', 1, CAST(N'1974-11-08' AS Date), N'+7 (953) 968-77-22', N'filipp84@ya.ru', N'Россия, г. Березники, Луговая ул., д. 22 кв.29', N'1616:7:23', N'4764 148660', N'240-212', N'Отделом УФМС России по г. Салават', CAST(N'2019-04-13' AS Date), N'78П000019-4 - 2018', CAST(N'2018-04-21' AS Date), 1, N'', N'785493465', 1, NULL, N'', N'АО567-ТНС-11', N'78П000019')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (53, N'Типалова Альбина Вениаминовна', 2, CAST(N'1966-02-20' AS Date), N'+7 (922) 357-70-81', N'albina1966@hotmail.com', N'Россия, г. Рыбинск, Первомайский пер., д. 11 кв.87', N'1163:7:17', N'4448 309925', N'620-263', N'Отделом внутренних дел России по г. Красноярск', CAST(N'2012-01-19' AS Date), N'78П000024-4 - 2019', CAST(N'2019-04-26' AS Date), 1, N'', N'785493470', 1, NULL, N'', N'АО567-ТНС-12', N'78П000024')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (54, N'Унгерн Данила Гаврннлович', 1, CAST(N'1964-07-09' AS Date), N'+7 (968) 529-93-71', N'danila35@gmail.com', N'Россия, г. Омск, Почтовая ул., д. 13 кв.182', N'1720:0:14', N'4558 533085', N'150-752', N'Отделением УФМС России по г. Сызрань', CAST(N'2017-04-28' AS Date), N'78П000027-7 - 2019', CAST(N'2019-07-04' AS Date), 1, N'', N'785493473', 1, NULL, N'', N'АО567-ТНС-11', N'78П000027')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (55, N'Трохина Антонина Климентьевна', 2, CAST(N'1976-04-26' AS Date), N'+7 (995) 641-58-36', N'antonina8270@mail.ru', N'Россия, г. Владикавказ, Луговой пер., д. 14 кв.211', N'7503:0:29', N'4756 531306', N'790-365', N'Отделом УФМС России по г. Кемерово', CAST(N'2012-05-30' AS Date), N'78П000029-9 - 2019', CAST(N'2019-09-06' AS Date), 1, N'', N'785493475', 1, NULL, N'', N'АО567-ТНС-13', N'78П000029')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (56, N'Жванецкий Савва Феоктистович', 1, CAST(N'1984-11-13' AS Date), N'+7 (907) 504-86-73', N'savva.jvaneckiy@mail.ru', N'Россия, г. Курган, Спортивная ул., д. 18 кв.63', N'8006:0:16', N'4315 284633', N'250-607', N'Отделом УФМС России по г. Северск', CAST(N'2019-09-29' AS Date), N'78В00011-1 - 2020', CAST(N'2020-01-18' AS Date), 1, N'', N'785493487', 1, NULL, N'', N'АО567-ТНС-13', N'78В00011')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (57, N'Оборин Петр Нифонтович', 1, CAST(N'1979-12-18' AS Date), N'+7 (968) 813-14-51', N'petr.oborin@yandex.ru', N'Россия, г. Саранск, Парковая ул., д. 18 кв.92', N'8006:0:24', N'4042 735498', N'160-536', N'Управление внутренних дел по г. Санкт-Петербург', CAST(N'2018-09-14' AS Date), N'78В00012-2 - 2020', CAST(N'2020-02-19' AS Date), 1, N'', N'785493488', 1, NULL, N'', N'АО567-ТНС-14', N'78В00012')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (58, N'Мичурина Маргарита Феоктистовна', 2, CAST(N'1980-09-02' AS Date), N'+7 (926) 967-88-84', N'margarita26@hotmail.com', N'Россия, г. Рыбинск, Интернациональная ул., д. 12 кв.51', N'8007:0:47', N'4659 666209', N'770-332', N'Отделением УФМС России по г. Старый Оскол', CAST(N'2017-02-21' AS Date), N'78В00013-3 - 2020', CAST(N'2020-03-20' AS Date), 1, N'', N'785493489', 1, NULL, N'', N'АО567-ТНС-11', N'78В00013')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (59, N'Кожевин Прохор Никанорович', 1, CAST(N'1967-01-05' AS Date), N'+7 (994) 825-60-23', N'prohor1967@hotmail.com', N'Россия, г. Стерлитамак, Молодежный пер., д. 15 кв.115', N'1675:0:46', N'4356 138139', N'990-733', N'ОВД России по г. Бердск', CAST(N'2014-05-29' AS Date), N'78В00015-5 - 2020', CAST(N'2020-05-22' AS Date), 1, N'', N'785493491', 1, NULL, N'', N'АО567-ТНС-13', N'78В00015')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (60, N'Саврасова Лариса Ефремовна', 2, CAST(N'1992-05-23' AS Date), N'+7 (972) 970-41-38', N'larisa.savrasova@mail.ru', N'Россия, г. Альметьевск, Полевой пер., д. 8 кв.77', N'1676:0:25', N'4982 966896', N'610-241', N'Отделением УФМС России по г. Батайск', CAST(N'2018-05-19' AS Date), N'78В00016-1 - 2020', CAST(N'2020-01-23' AS Date), 1, N'', N'785493492', 1, NULL, N'', N'АО567-ТНС-14', N'78В00016')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (61, N'Рыбакова Вероника Филипповна', 2, CAST(N'1965-02-26' AS Date), N'+7 (980) 793-71-73', N'veronika1965@hotmail.com', N'Россия, г. Тула, Первомайский пер., д. 20 кв.209', N'1676:0:27', N'4675 570112', N'470-311', N'ОУФМС России по г. Владикавказ', CAST(N'2019-07-18' AS Date), N'78В00017-2 - 2020', CAST(N'2020-02-24' AS Date), 2, N'', N'785493493', 1, NULL, N'', N'АО567-ТНС-11', N'78В00017')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (62, N'Емельяненко Марина Ивановна', 2, CAST(N'1980-12-25' AS Date), N'+7 (931) 962-20-15', N'marina88@yandex.ru', N'Россия, г. Волжский, Севернаяул., д. 17 кв.20', N'1678:0:16', N'4413 882242', N'410-299', N'Отделом внутренних дел России по г. Ангарск', CAST(N'2017-01-29' AS Date), N'78В00020-5 - 2020', CAST(N'2020-05-27' AS Date), 1, N'', N'785493496', 1, NULL, N'', N'АО567-ТНС-14', N'78В00020')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (63, N'Савенков Герасим Емельянович', 1, CAST(N'1979-01-12' AS Date), N'+7 (961) 296-50-28', N'gerasim1979@hotmail.com', N'Россия, г. Орехово-Зуево, Пролетарская ул., д. 12 кв.109', N'1155:0:52', N'4748 514770', N'670-637', N'Управление внутренних дел по г. Архангельск', CAST(N'2020-12-31' AS Date), N'78В00023-8 - 2020', CAST(N'2020-08-15' AS Date), 1, N'', N'785493499', 1, NULL, N'', N'АО567-ТНС-13', N'78В00023')
INSERT [dbo].[Abonents] ([IdAbonent], [LFM], [IdMF], [Birthday], [NumberPhone], [Email], [AdressPasport], [AdressReal], [SerAndNumPasport], [CodePPasport], [WhoDropPasport], [DateDropPasport], [NumberDoc], [DateCreateDoc], [IdTypeDoc], [CommentDestroyDoc], [LS], [IdServices], [DateDestroyDoc], [DocArend], [SerNumDevice], [NumberAbonent]) VALUES (64, N'Корявова Марфа Феоктистовна', 2, CAST(N'1981-03-15' AS Date), N'+7 (952) 835-52-37', N'marfa.koryavova@ya.ru', N'Россия, г. Калуга, Дачная ул., д. 6 кв.146', N'1079:9:10', N'4465 579021', N'960-397', N'Отделом УФМС России по г. Ессентуки', CAST(N'2021-06-27' AS Date), N'78В00028-5 - 2021', CAST(N'2021-05-12' AS Date), 1, N'', N'785493504', 1, NULL, N'', N'АО567-ТНС-14', N'78В00028')
SET IDENTITY_INSERT [dbo].[Abonents] OFF
GO
SET IDENTITY_INSERT [dbo].[Devices] ON 

INSERT [dbo].[Devices] ([Id], [SerNumber], [Name]) VALUES (2, N'М0123ТНС312', N'Транспондер TS-100E, ')
INSERT [dbo].[Devices] ([Id], [SerNumber], [Name]) VALUES (3, N'М234ТНС12', N'Агрегирующий транспондер MS-100E-Т10')
INSERT [dbo].[Devices] ([Id], [SerNumber], [Name]) VALUES (4, N'М567ТНС87', N'Транспондер ТS-40E')
INSERT [dbo].[Devices] ([Id], [SerNumber], [Name]) VALUES (5, N'М455ТНС567', N'Агрегирующий транспондер MS-40E-Q10')
INSERT [dbo].[Devices] ([Id], [SerNumber], [Name]) VALUES (6, N'М8888ТНС231', N'Транспондер TD-10E')
INSERT [dbo].[Devices] ([Id], [SerNumber], [Name]) VALUES (7, N'М67ТНС98008', N'Агрегатор MS-10FX')
INSERT [dbo].[Devices] ([Id], [SerNumber], [Name]) VALUES (8, N'М43535ТНС2677', N'Транспондер TD-3F')
INSERT [dbo].[Devices] ([Id], [SerNumber], [Name]) VALUES (9, N'М535623ТНС8899', N'Агрегатор MD-D3FS')
INSERT [dbo].[Devices] ([Id], [SerNumber], [Name]) VALUES (10, N'М431ТНС7647', N'Оптические волоконные усилители ')
INSERT [dbo].[Devices] ([Id], [SerNumber], [Name]) VALUES (11, N'М654ТНС878', N'CM-S-2G-6')
INSERT [dbo].[Devices] ([Id], [SerNumber], [Name]) VALUES (12, N'М634ТНС67', N'SW-2G-8')
INSERT [dbo].[Devices] ([Id], [SerNumber], [Name]) VALUES (13, N'М877ТНС132', N'«ИРТЫШ»')
SET IDENTITY_INSERT [dbo].[Devices] OFF
GO
SET IDENTITY_INSERT [dbo].[LineDevices] ON 

INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (1, N'СД12ТНС_01', 24, N'IEEE 802.1p', N'17,6', N'SSI', N'1 Гбит', N'СПб, В.О., 4 линия, д. 41', N'Точка доступа Cisco AIR-SAP702I ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (2, N'СД12ТНС_02', 48, N'IEEE 802.2p', N'22', N'UART', N'2 Гбит', N'СПб, Малая Монетная ул., д. 2а', N'Точка доступа Cisco ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (3, N'СД12ТНС_03', 36, N'IEEE 802.1p', N'17,4', N'FC, FCoE, iSCSI, Infiniband, SAS', N'1 Гбит', N'СПб, Каменноостровский пр., д. 10', N'Точка доступа Cisco ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (4, N'СД12ТНС_04', 16, N'IEEE 802.1p', N'21', N'UART', N'1 Гбит', N'СПб, Петроградская наб., д. 18', N'Точка доступа Cisco AIR-SAP2602E ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (5, N'СД12ТНС_05', 16, N'IEEE 802.1p', N'15', N'SSI', N'1 Гбит', N'СПб, ул. Академика Лебедева, д. 4', N'Трансивер X2-10GB-LX4 Cisco ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (6, N'СД12ТНС_06', 24, N'IEEE 802.2p', N'3', N'SSI, UART, FCoE', N'1 Гбит', N'СПб, Большая Монетная ул., за д. 34', N'Точка доступа Cisco ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (7, N'СД12ТНС_07', 24, N'IEEE 802.1p', N'12,1', N'FC, FCoE, iSCSI, Infiniband, SAS', N'2 Гбит', N'СПб, Введенская ул,. д. 10а', N'Коммутатор Cisco ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (9, N'СД12ТНС_09', 24, N'IEEE 802.1p', N'11,2', N'UART', N'2 Гбит', N'СПб, ул. Комиссара Смирнова, д. 15', N'Точка доступа Cisco ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (10, N'СД12ТНС_10', 48, N'IEEE 802.2p', N'11,2', N'FC, FCoE, iSCSI, Infiniband, SAS', N'2 Гбит', N'СПб, Финляндский пр., д. 4-А', N'Коммутатор Switch D-Link DES-1008D ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (11, N'СД12ТНС_11', 48, N'IEEE 802.1p', N'17,3', N'SSI', N'2 Гбит', N'СПб, ул. Чапаева, д. 15', N'Интернет маршрутизатор D-Link DIR-815 ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (12, N'СД12ТНС_12', 48, N'IEEE 802.1p', N'14,3', N'SSI, UART, FCoE', N'2 Гбит', N'СПб, Моховая ул., д. 1', N'Интернет маршрутизатор D-Link DIR-842 ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (13, N'СД12ТНС_13', 48, N'IEEE 802.2p', N'15,2', N'UART', N'2 Гбит', N'СПб, Петроградская наб., за д. 36а', N'Интернет маршрутизатор D-Link DIR-825 ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (14, N'СД12ТНС_14', 24, N'IEEE 802.1p', N'15,3', N'SSI, UART, FCoE', N'2 Гбит', N'СПб, Гельсингфорсская ул., д. 2', N'Коммутатор D-Link DES-1008P ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (15, N'СД12ТНС_15', 24, N'IEEE 802.1p', N'11,3', N'FC, FCoE, iSCSI, Infiniband, SAS', N'2 Гбит', N'СПб, Мичуринская ул., д. 19', N'Интернет маршрутизатор D-Link DIR-825 ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (16, N'СД12ТНС_16', 24, N'IEEE 802.2p', N'15,6', N'SSI', N'2 Гбит', N'СПб, ул. Фокина, д. 1', N'Коммутатор Switch D-Link DGS-1008MP ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (17, N'СД12ТНС_17', 24, N'IEEE 802.1p', N'15,3', N'UART', N'2 Гбит', N'СПб, ул. Чайковского, д. 11 / Моховая ул., д. 2', N'Интернет маршрутизатор D-link DWR-921 ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (18, N'СД12ТНС_18', 48, N'IEEE 802.2p', N'10,2', N'SSI, UART, FCoE', N'2 Гбит', N'СПб, Литейный пр., д. 5', N'Коммутатор D-Link DES-3200-28 ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (19, N'СД12ТНС_19', 48, N'IEEE 802.1p', N'10,6', N'FC, FCoE, iSCSI, Infiniband, SAS', N'2 Гбит', N'СПб, Финляндский пр., д. 4-А', N'Интернет маршрутизатор D-Link DIR-645 ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (20, N'СД12ТНС_20', 48, N'IEEE 802.1p', N'10,2', N'SSI, UART, FCoE', N'1 Гбит', N'СПб, ул. Шамшева, д. 8', N'Коммутатор D-Link DGS-1210-28P ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (21, N'СД12ТНС_21', 48, N'IEEE 802.2p', N'10,3', N'FC, FCoE, iSCSI, Infiniband, SAS', N'1 Гбит', N'СПб, Чкаловский пр., д. 15', N'Коммутатор Switch D-Link ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (23, N'СД12ТНС_23', 24, N'IEEE 802.1p', N'15,8', N'SSI, UART, FCoE', N'1 Гбит', N'СПб, Чкаловский пр., д. 9', N'Коммутатор HP OfficeConnect 1420-8G ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (24, N'СД12ТНС_24', 16, N'IEEE 802.2p', N'14,6', N'UART', N'1 Гбит', N'СПб, Чкаловский пр., д. 46', N'Точка доступа HP ProCurve ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (25, N'СД12ТНС_25', 16, N'IEEE 802.1p', N'15,3', N'FC, FCoE, iSCSI, Infiniband, SAS', N'2 Гбит', N'СПб, В.О., 7 линия, д. 84-а', N'Коммутатор HP 1420-24G-2SFP')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (26, N'СД12ТНС_26', 16, N'IEEE 802.1p', N'15,4', N'SSI, UART, FCoE', N'1 Гбит', N'СПб, Зверинская ул., д. 15', N'Коммутатор HP 3100-24 v2 EI ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (27, N'СД12ТНС_27', 16, N'IEEE 802.2p', N'12,3', N'SSI', N'1 Гбит', N'СПб, В.О., Кадетская линия, между домами 27 и 29', N'Коммутатор HP 5500-24G EI #JD377A')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (28, N'СД12ТНС_28', 16, N'IEEE 802.1p', N'12,9', N'SSI', N'2 Гбит', N'СПб, В.О., 1-я линия, д. 40 и д. 42', N'Коммутатор HP Enterprise 1950-24G-2SFP+-2XGT ')
INSERT [dbo].[LineDevices] ([Id], [SerNumber], [Port], [StandartMoveData], [Chast], [Interfaces], [SpeedMoveData], [Location], [Name]) VALUES (30, N'СД12ТНС_30', 48, N'IEEE 802.1p', N'14', N'SSI, UART, FCoE', N'1 Гбит', N'СПб, Шпалерная ул., д. 26', N'Коммутатор HP Aruba 2530-48-PoE+  ')
SET IDENTITY_INSERT [dbo].[LineDevices] OFF
GO
SET IDENTITY_INSERT [dbo].[Magistrals] ON 

INSERT [dbo].[Magistrals] ([Id], [Chast], [CaefZatyx], [TehMoveData], [Location], [Name], [SerNumber]) VALUES (28, N'17', 3, N' WDM', N' СПб  Кронверкский пр.  д. 5', N'Транспондер TS-100E', N'М0123ТНС312')
INSERT [dbo].[Magistrals] ([Id], [Chast], [CaefZatyx], [TehMoveData], [Location], [Name], [SerNumber]) VALUES (29, N'14', NULL, N' GPON', N' СПб  ул. Блохина  д. 9', N'Агрегирующий транспондер MS-100E-Т10', N'М234ТНС12')
INSERT [dbo].[Magistrals] ([Id], [Chast], [CaefZatyx], [TehMoveData], [Location], [Name], [SerNumber]) VALUES (30, N'14', 66, N' DWDM', N' СПб  Александровский парк  д. 7', N'Транспондер ТS-40E', N'М567ТНС87')
INSERT [dbo].[Magistrals] ([Id], [Chast], [CaefZatyx], [TehMoveData], [Location], [Name], [SerNumber]) VALUES (31, N' 25.6', NULL, N' PON', N' СПб  Гагаринская ул.  д. 3', N'Агрегирующий транспондер MS-40E-Q10', N'М455ТНС567')
INSERT [dbo].[Magistrals] ([Id], [Chast], [CaefZatyx], [TehMoveData], [Location], [Name], [SerNumber]) VALUES (32, N' 15.5', NULL, N' DWDM', N' СПб  В.О.  2-я линия  д. 61/30 лит. А', N'Транспондер TD-10E', N'М8888ТНС231')
INSERT [dbo].[Magistrals] ([Id], [Chast], [CaefZatyx], [TehMoveData], [Location], [Name], [SerNumber]) VALUES (33, N' 65.25', NULL, N' PON', N' СПб  Миллионная ул.  д. 5', N'Агрегатор MS-10FX', N'М67ТНС98008')
INSERT [dbo].[Magistrals] ([Id], [Chast], [CaefZatyx], [TehMoveData], [Location], [Name], [SerNumber]) VALUES (34, N' 45.2', NULL, N' DWDM', N' СПб  Петровская наб.  д. 8', N'Транспондер TD-3F', N'М43535ТНС2677')
INSERT [dbo].[Magistrals] ([Id], [Chast], [CaefZatyx], [TehMoveData], [Location], [Name], [SerNumber]) VALUES (35, N' 25.3', NULL, N' PON', N' СПб  Соляной пер.  д. 9 ', N'Агрегатор MD-D3FS', N'М535623ТНС8899')
INSERT [dbo].[Magistrals] ([Id], [Chast], [CaefZatyx], [TehMoveData], [Location], [Name], [SerNumber]) VALUES (36, N' 12.3', NULL, N' WDM', N' СПб  Малый пр. П.С.  д. 10', N'Оптические волоконные усилители EDFA и RAU', N'М431ТНС7647')
INSERT [dbo].[Magistrals] ([Id], [Chast], [CaefZatyx], [TehMoveData], [Location], [Name], [SerNumber]) VALUES (37, N' 12.6', NULL, N' WDM', N' СПб  ул. Профессора Попова  д. 15/17', N'CM-S-2G-6', N'М654ТНС878')
INSERT [dbo].[Magistrals] ([Id], [Chast], [CaefZatyx], [TehMoveData], [Location], [Name], [SerNumber]) VALUES (38, N' 14.6', NULL, N' PON', N' СПб  Кронверкская ул.  д. 23', N'SW-2G-8', N'М634ТНС67')
INSERT [dbo].[Magistrals] ([Id], [Chast], [CaefZatyx], [TehMoveData], [Location], [Name], [SerNumber]) VALUES (39, N' 12.3', NULL, N' WDM', N' СПб  Крестовский о-в  Депутатская ул.  д. 8', N'«ИРТЫШ»', N'М877ТНС132')
SET IDENTITY_INSERT [dbo].[Magistrals] OFF
GO
SET IDENTITY_INSERT [dbo].[MF] ON 

INSERT [dbo].[MF] ([Id], [Name]) VALUES (1, N'Мужчина
')
INSERT [dbo].[MF] ([Id], [Name]) VALUES (2, N'Женщина
')
SET IDENTITY_INSERT [dbo].[MF] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderCRM] ON 

INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (77, N'785493421/12/08/2021', CAST(N'2021-08-12' AS Date), N'785493421', N'Видеонаблюдение', N'Подключение', N'Подключение услуг на существующей инфраструктуре', N'Новая', N'Подключить услугу, разводка до двери есть, порт 12', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (78, N'785493429/25/08/2021', CAST(N'2021-08-25' AS Date), N'785493429', N'Интернет', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (79, N'785493434/26/08/2021', CAST(N'2021-08-26' AS Date), N'785493434', N'Интернет', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (80, N'785493424/24/08/2021', CAST(N'2021-08-24' AS Date), N'785493424', N'Интернет', N'Диагностика и настройка оборудования/подключения', N'Низкая скорость соединения', N'Требует выезд', N'', CAST(N'2021-08-25' AS Date), N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (81, N'785493424/25/08/2021', CAST(N'2021-08-25' AS Date), N'785493424', N'Видеонаблюдение', N'Подключение', N'Подключение услуг на новой инфраструктуре', N'Закрыта', N'', CAST(N'2021-08-25' AS Date), N'консультация', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (82, N'785493431/18/08/2021', CAST(N'2021-08-18' AS Date), N'785493431', N'Интернет', N'Диагностика и настройка оборудования/подключения', N'Низкая скорость соединения', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (83, N'785493427/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493427', N'Видеонаблюдение', N'Диагностика и настройка оборудования/подключения', N'Низкая скорость соединения', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (84, N'785493428/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493428', N'Видеонаблюдение', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (85, N'785493431/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493431', N'ТВ', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (86, N'785493453/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493453', N'Интернет', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (87, N'785493457/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493457', N'Интернет', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (88, N'785493464/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493464', N'Интернет', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (89, N'785493469/30/08/2021', CAST(N'2021-08-28' AS Date), N'785493469', N'Видеонаблюдение', N'Подключение', N'Подключение на новой инфраструктуре', N'Требует выезд', N'От распределительного шкафа в подвале', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (90, N'785493494/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493494', N'Видеонаблюдение', N'Подключение', N'Подключение на новой инфраструктуре', N'Требует выезд', N'От распределительного шкафа в подвале', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (91, N'785493495/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493495', N'Видеонаблюдение', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (92, N'78549349628/08/2021', CAST(N'2021-08-28' AS Date), N'785493496', N'Интернет', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (93, N'785493497/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493497', N'ТВ', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (94, N'785493498/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493498', N'ТВ', N'Подключение', N'Подключение на новой инфраструктуре', N'Требует выезд', N'От распределительного шкафа в подвале', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (95, N'785493499/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493499', N'Интернет', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (96, N'785493500/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493500', N'Интернет', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (97, N'785493501/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493501', N'ТВ', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (98, N'785493502/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493502', N'ТВ', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (99, N'785493503/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493503', N'Интернет', N'Подключение', N'Подключение на новой инфраструктуре', N'Требует выезд', N'От распределительного шкафа в подвале', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (100, N'785493504/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493504', N'Интернет', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (101, N'785493505/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493505', N'Видеонаблюдение', N'Подключение', N'Подключение на новой инфраструктуре', N'Требует выезд', N'От распределительного шкафа в подвале', NULL, N'ТО', NULL)
INSERT [dbo].[OrderCRM] ([Id], [NumberOrder], [DateCreate], [LS], [Services], [VidServices], [TypeServices], [State], [Problem], [DateClose], [TypeProblem], [Device]) VALUES (102, N'785493506/28/08/2021', CAST(N'2021-08-28' AS Date), N'785493506', N'Интернет', N'Диагностика и настройка оборудования/подключения', N'Нет доступа к услуге', N'Требует выезд', N'', NULL, N'ТО', NULL)
SET IDENTITY_INSERT [dbo].[OrderCRM] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([IdRole], [Name]) VALUES (1, N'Руководитель отдела по работе с клиентами
')
INSERT [dbo].[Roles] ([IdRole], [Name]) VALUES (2, N'Менеджер по работе с клиентами
')
INSERT [dbo].[Roles] ([IdRole], [Name]) VALUES (3, N'Руководитель отдела технической поддержки
')
INSERT [dbo].[Roles] ([IdRole], [Name]) VALUES (4, N'Специалист технической поддержки
')
INSERT [dbo].[Roles] ([IdRole], [Name]) VALUES (5, N'Бухгалтер
')
INSERT [dbo].[Roles] ([IdRole], [Name]) VALUES (6, N'Директор по развитию
')
INSERT [dbo].[Roles] ([IdRole], [Name]) VALUES (7, N'Сотрудник технического департамента
')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([Id], [Name]) VALUES (1, N'Интернет')
INSERT [dbo].[Services] ([Id], [Name]) VALUES (2, N'Видеонаблюдение')
INSERT [dbo].[Services] ([Id], [Name]) VALUES (3, N'Телевидение')
INSERT [dbo].[Services] ([Id], [Name]) VALUES (4, N'Мобильная связь')
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[Staffs] ON 

INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (1, N'Шилов', N'Вольдемар', N'Степанович', 1, N'ID1516')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (2, N'Мясников', N'Власий', N'Лаврентьевич', 3, N'ID1517')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (3, N'Макаров', N'Овидий', N'Вячеславович', 4, N'ID1518')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (4, N'Рябов', N'Валентин', N'Миронович', 4, N'ID1519')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (5, N'Архипов', N'Валентин', N'Богуславович', 4, N'ID1520')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (6, N'Федосеев', N'Август', N'Аристархович', 4, N'ID1521')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (7, N'Козлов', N'Азарий', N'Владимирович', 4, N'ID1522')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (8, N'Кондратьев', N'Владислав', N'Агафонович', 4, N'ID1523')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (9, N'Лапин', N'Альфред', N'Александрович', 4, N'ID1524')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (10, N'Тимофеев', N'Май', N'Филиппович', 4, N'ID1525')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (11, N'Сидоров', N'Арсений', N'Богуславович', 6, N'ID1526')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (12, N'Самсонов', N'Егор', N'Тимофеевич', 7, N'ID1527')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (13, N'Журавлёв', N'Панкрат', N'Валерьянович', 7, N'ID1528')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (14, N'Жуков', N'Виталий', N'Проклович', 7, N'ID1529')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (15, N'Якушев', N'Гордий', N'Гордеевич', 7, N'ID1530')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (16, N'Симонова', N'Сильвия', N'Валерьевна', 5, N'ID1531')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (17, N'Дмитриева', N'Вероника', N'Прокловна', 5, N'ID1532')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (18, N'Панова', N'Марина', N'Викторовна', 5, N'ID1533')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (19, N'Афанасьева', N'Дарина', N'Львовна', 2, N'ID1534')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (20, N'Шубина', N'Мелитта', N'Тарасовна', 2, N'ID1535')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (21, N'Белякова', N'Элла', N'Игнатьевна', 2, N'ID1536')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (22, N'Осипова', N'Индира', N'Оскаровна', 2, N'ID1537')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (23, N'Ефремова', N'Анна', N'Николаевна', 2, N'ID1538')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (24, N'Симонова', N'Герда', N'Наумовна', 2, N'ID1539')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (25, N'Авдеева', N'Нега', N'Евгеньевна', 2, N'ID1540')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (26, N'Никифорова', N'Алиса', N'Робертовна', 2, N'ID1541')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (27, N'Семёнова', N'Габриэлла', N'Иринеевна', 2, N'ID1542')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (28, N'Авдеева', N'Таисия', N'Анатольевна', 2, N'ID1543')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (29, N'Мухина', N'Доминика', N'Лукьяновна', 2, N'ID1544')
INSERT [dbo].[Staffs] ([IdStaff], [LastName], [FirstName], [MiddleName], [IdRole], [PhotoPatch]) VALUES (30, N'Муравьёва', N'Римма', N'Максовна', 2, N'ID1545')
SET IDENTITY_INSERT [dbo].[Staffs] OFF
GO
SET IDENTITY_INSERT [dbo].[StreetSPB] ON 

INSERT [dbo].[StreetSPB] ([Id], [NameStreet], [Ploshad], [CountPeople], [CountMetro], [TypeBuild]) VALUES (1, N'Василеостровский', N'16,64', 211048, 3, N'Плотная городская застройка')
INSERT [dbo].[StreetSPB] ([Id], [NameStreet], [Ploshad], [CountPeople], [CountMetro], [TypeBuild]) VALUES (2, N'Петроградский', N'24', 125731, 4, N'Средняя городская застройка')
INSERT [dbo].[StreetSPB] ([Id], [NameStreet], [Ploshad], [CountPeople], [CountMetro], [TypeBuild]) VALUES (3, N'Адмиралтейский', N'13,82', 156958, 6, N'Плотная городская застройка')
SET IDENTITY_INSERT [dbo].[StreetSPB] OFF
GO
SET IDENTITY_INSERT [dbo].[Tarifs] ON 

INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (1, 1, N'Стандарт ', N'15 Мбит/с', N'100')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (2, 1, N'Оптима', N'45 Мбит/с', N'200')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (3, 1, N'Супер', N'100 Мбит/с', N'600')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (4, 2, N'Базовый', N'2 точки наблюдения', N'200')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (5, 2, N'Базовый Плюс', N'2 точки наблюдения, хранение записи 1 месяц', N'400')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (6, 2, N'Оптимальный', N'4 точки наблюдения', N'400')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (7, 2, N'Оптимальный Плюс', N'4 точки наблюдения, хранение записи 1 месяц', N'600')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (8, 3, N'Чуть-чуть смотри', N'10 каналов', N'200')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (9, 3, N'Побольше смотри', N'20 каналов', N'315')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (10, 3, N'Много смотри', N'100 каналов', N'400')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (11, 3, N'Смотри и овощи', N'150 каналов', N'500')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (12, 4, N'Никому не звони', N'10 минут, 20 SMS', N'49,9')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (13, 4, N'Звони только маме', N'50 минут, 20 SMS', N'67,9')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (14, 4, N'Звони родным', N'120 минут, 20 SMS', N'78,99')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (15, 4, N'Болтай без умолку', N'1000 минут, 20 SMS', N'400,91')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (16, 1, N'Активный
', N'Интернет до 50 Мбит/с,Телевидение - 50 каналов
 
', N'600')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (17, 1, N'Позитивный
', N'Интернет до 100 Мбит/с
,Телевидение 100 каналов
,Видеонаблюдение - 2 точки
', N'980')
INSERT [dbo].[Tarifs] ([Id], [IdService], [NameTarif], [Yslov], [Price]) VALUES (20, 1, N'Космический
', N'Интернет до 100 Мбит/с
,Телевидение 100 каналов
,Видеонаблюдение - 4 точки
', N'1200')
SET IDENTITY_INSERT [dbo].[Tarifs] OFF
GO
INSERT [dbo].[TypesDoc] ([IdTypeDoc], [Name]) VALUES (1, N'с пролонгацией
')
INSERT [dbo].[TypesDoc] ([IdTypeDoc], [Name]) VALUES (2, N'без пролонгации
')
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [LoginNumber], [Password], [FIO]) VALUES (1, N'1234561', N'1234561', N'Макаров Овидий Вячеславович
')
INSERT [dbo].[Users] ([Id], [LoginNumber], [Password], [FIO]) VALUES (2, N'1234562', N'1234562', N'Рябов Валентин Миронович
')
INSERT [dbo].[Users] ([Id], [LoginNumber], [Password], [FIO]) VALUES (3, N'1234563', N'1234563', N'Архипов Валентин Богуславович
')
INSERT [dbo].[Users] ([Id], [LoginNumber], [Password], [FIO]) VALUES (4, N'1234564', N'1234564', N'Федосеев Август Аристархович
')
INSERT [dbo].[Users] ([Id], [LoginNumber], [Password], [FIO]) VALUES (5, N'1234565', N'1234565', N'Козлов Азарий Владимирович')
INSERT [dbo].[Users] ([Id], [LoginNumber], [Password], [FIO]) VALUES (6, N'1234566', N'1234566', N'Кондратьев Владислав Агафонович')
INSERT [dbo].[Users] ([Id], [LoginNumber], [Password], [FIO]) VALUES (7, N'1234567', N'1234567', N'Лапин Альфред Александрович')
INSERT [dbo].[Users] ([Id], [LoginNumber], [Password], [FIO]) VALUES (8, N'1234568', N'1234568', N'Тимофеев Май Филиппович')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Abonents]  WITH CHECK ADD  CONSTRAINT [FK_Abonents_MF1] FOREIGN KEY([IdMF])
REFERENCES [dbo].[MF] ([Id])
GO
ALTER TABLE [dbo].[Abonents] CHECK CONSTRAINT [FK_Abonents_MF1]
GO
ALTER TABLE [dbo].[Abonents]  WITH CHECK ADD  CONSTRAINT [FK_Abonents_Services] FOREIGN KEY([IdServices])
REFERENCES [dbo].[Services] ([Id])
GO
ALTER TABLE [dbo].[Abonents] CHECK CONSTRAINT [FK_Abonents_Services]
GO
ALTER TABLE [dbo].[Abonents]  WITH CHECK ADD  CONSTRAINT [FK_Abonents_TypesDoc] FOREIGN KEY([IdTypeDoc])
REFERENCES [dbo].[TypesDoc] ([IdTypeDoc])
GO
ALTER TABLE [dbo].[Abonents] CHECK CONSTRAINT [FK_Abonents_TypesDoc]
GO
ALTER TABLE [dbo].[Staffs]  WITH CHECK ADD  CONSTRAINT [FK_Staffs_Roles] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Roles] ([IdRole])
GO
ALTER TABLE [dbo].[Staffs] CHECK CONSTRAINT [FK_Staffs_Roles]
GO
ALTER TABLE [dbo].[Tarifs]  WITH CHECK ADD  CONSTRAINT [FK_Tarifs_Services] FOREIGN KEY([IdService])
REFERENCES [dbo].[Services] ([Id])
GO
ALTER TABLE [dbo].[Tarifs] CHECK CONSTRAINT [FK_Tarifs_Services]
GO
USE [master]
GO
ALTER DATABASE [ws08] SET  READ_WRITE 
GO
