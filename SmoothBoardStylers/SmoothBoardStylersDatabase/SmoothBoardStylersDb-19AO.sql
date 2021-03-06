USE [master]
GO
CREATE DATABASE [SmoothBoardStylersDb-19AO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SmoothBoardStylersDb-19AO', FILENAME = N'SmoothBoardStylersDb-19AO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SmoothBoardStylersDb-19AO_log', FILENAME = N'SmoothBoardStylersDb-19AO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SmoothBoardStylersDb-19AO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET ARITHABORT OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET  MULTI_USER 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET QUERY_STORE = OFF
GO
USE [SmoothBoardStylersDb-19AO]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [SmoothBoardStylersDb-19AO]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Naam] [nvarchar](80) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacten]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacten](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmailAdres] [nvarchar](max) NULL,
 CONSTRAINT [PK_Contacten] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactSurfboard]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactSurfboard](
	[InteresseContactenId] [int] NOT NULL,
	[SurfBoardInteressesId] [int] NOT NULL,
 CONSTRAINT [PK_ContactSurfboard] PRIMARY KEY CLUSTERED 
(
	[InteresseContactenId] ASC,
	[SurfBoardInteressesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faqs]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faqs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Vraag] [nvarchar](120) NULL,
	[Antwoord] [nvarchar](max) NULL,
 CONSTRAINT [PK_Faqs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Filialen]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Filialen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naam] [nvarchar](80) NULL,
	[Adres] [nvarchar](120) NULL,
	[Woonplaats] [nvarchar](120) NULL,
 CONSTRAINT [PK_Filialen] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materialen]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materialen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naam] [nvarchar](80) NULL,
 CONSTRAINT [PK_Materialen] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Surfboards]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Surfboards](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naam] [nvarchar](80) NULL,
	[Beschrijving] [nvarchar](max) NULL,
	[MateriaalId] [int] NOT NULL,
	[Prijs] [decimal](18, 2) NOT NULL,
	[FotoUrl] [nvarchar](128) NULL,
 CONSTRAINT [PK_Surfboards] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voorraad]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voorraad](
	[SurfboardId] [int] NOT NULL,
	[FiliaalId] [int] NOT NULL,
	[Aantal] [int] NOT NULL,
 CONSTRAINT [PK_Voorraad] PRIMARY KEY CLUSTERED 
(
	[SurfboardId] ASC,
	[FiliaalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vragen]    Script Date: 23-3-2021 16:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vragen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tekst] [nvarchar](max) NULL,
	[VraagstellerId] [int] NOT NULL,
 CONSTRAINT [PK_Vragen] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'25d8ffd9-d72a-482a-b820-1b6b09865638', N'Admin', N'ADMIN', N'33081e33-8afc-4a79-9130-6c5f8cc182d9')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3973b1b9-d35d-4953-bf4c-b8d89a7b6e80', N'25d8ffd9-d72a-482a-b820-1b6b09865638')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bacad7b2-7160-4ab4-98b3-5eca3f684791', N'25d8ffd9-d72a-482a-b820-1b6b09865638')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Naam]) VALUES (N'3973b1b9-d35d-4953-bf4c-b8d89a7b6e80', N'marian@smoothboardstylers.com', N'MARIAN@SMOOTHBOARDSTYLERS.COM', N'marian@smoothboardstylers.com', N'MARIAN@SMOOTHBOARDSTYLERS.COM', 1, N'AQAAAAEAACcQAAAAEKU7cKLXJ8SNC2e4bzw8Ul5cxC7bzjlp6B8F4htun9q0mbNugDzaiUxSPfPCLxuMaA==', N'P3PU7MKJJRD5LR4SF5ESTQS4SPZ56JKL', N'c66f8a4c-1753-4cb9-b722-84a17e7a4c45', NULL, 0, 0, NULL, 1, 0, N'Marian Jensen')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Naam]) VALUES (N'bacad7b2-7160-4ab4-98b3-5eca3f684791', N'sean@smoothboardstylers.com', N'SEAN@SMOOTHBOARDSTYLERS.COM', N'sean@smoothboardstylers.com', N'SEAN@SMOOTHBOARDSTYLERS.COM', 1, N'AQAAAAEAACcQAAAAEIaOGqAspDOaRd2bLVobCQnmKiy752EdPqtr/cGGLQCAzzE35HwOI95vK+WoE4LG4g==', N'72KBF7YRZM3DMHQ7Q4ZRVUJXU33IIVF3', N'9ebcd854-bc23-41a9-b4b5-6336a90aa43e', NULL, 0, 0, NULL, 1, 0, N'Sean Jensen')
GO
SET IDENTITY_INSERT [dbo].[Contacten] ON 

INSERT [dbo].[Contacten] ([Id], [EmailAdres]) VALUES (1, N'surf@branding.com')
INSERT [dbo].[Contacten] ([Id], [EmailAdres]) VALUES (2, N'jos@deklos.com')
INSERT [dbo].[Contacten] ([Id], [EmailAdres]) VALUES (3, N'jaap.het.schaap@farm.de')
INSERT [dbo].[Contacten] ([Id], [EmailAdres]) VALUES (4, N'jos@deklos.nl')
INSERT [dbo].[Contacten] ([Id], [EmailAdres]) VALUES (5, N'fons.despons@koraalrif.aus')
INSERT [dbo].[Contacten] ([Id], [EmailAdres]) VALUES (6, N'leo.de.meeuw@seagull.sea')
INSERT [dbo].[Contacten] ([Id], [EmailAdres]) VALUES (7, N'sjaan.de.banaan@plantage.bos')
INSERT [dbo].[Contacten] ([Id], [EmailAdres]) VALUES (8, N'sjoerd.de.boer@boerderij.wei')
INSERT [dbo].[Contacten] ([Id], [EmailAdres]) VALUES (9, N'ali.minimum@metaal.com')
INSERT [dbo].[Contacten] ([Id], [EmailAdres]) VALUES (10, N'wave.surfer@seashell.com')
SET IDENTITY_INSERT [dbo].[Contacten] OFF
GO
SET IDENTITY_INSERT [dbo].[Faqs] ON 

INSERT [dbo].[Faqs] ([Id], [Vraag], [Antwoord]) VALUES (1, N'Wie zijn Smoothboard Stylers?', N'Smoothboard Stylers is een bedrijf van Sean Jensen. Sean is naast een ervaren surfer ook een uitstekend artiest die zijn creatieve ideeën vertaald naar fantastische ontwerpen voor surfboards. Van idee tot uitvoering, Sean doet alles zelf. Naast het ‘painten’ van surfboards verkoopt Smoothboard Stylers sinds kort ook surfboards.')
INSERT [dbo].[Faqs] ([Id], [Vraag], [Antwoord]) VALUES (2, N'Kan ik zelf ook een eigen design aanleveren?', N'Ja dat kan, mits digitaal aangeleverd.')
INSERT [dbo].[Faqs] ([Id], [Vraag], [Antwoord]) VALUES (3, N'Hoe lang duurt het ''''customizen'''' van een surfboard?''', N'Na ontvangst van het board, hebben we twee dagen nodig om het te bewerken. In drukke perioden kan dit oplopen tot max. 1 week.')
SET IDENTITY_INSERT [dbo].[Faqs] OFF
GO
SET IDENTITY_INSERT [dbo].[Filialen] ON 

INSERT [dbo].[Filialen] ([Id], [Naam], [Adres], [Woonplaats]) VALUES (1, N'Sean', N'1e Calle Poniente 45', N'Ceru Colorado - ARUBA')
INSERT [dbo].[Filialen] ([Id], [Naam], [Adres], [Woonplaats]) VALUES (2, N'Marian', N'Royal Palm Galleries 26F', N'Kralendijk - BONAIRE')
SET IDENTITY_INSERT [dbo].[Filialen] OFF
GO
SET IDENTITY_INSERT [dbo].[Materialen] ON 

INSERT [dbo].[Materialen] ([Id], [Naam]) VALUES (1, N'Koahout')
INSERT [dbo].[Materialen] ([Id], [Naam]) VALUES (2, N'Polystyreen')
INSERT [dbo].[Materialen] ([Id], [Naam]) VALUES (3, N'Kevlar')
INSERT [dbo].[Materialen] ([Id], [Naam]) VALUES (4, N'Carbon Fiber')
INSERT [dbo].[Materialen] ([Id], [Naam]) VALUES (5, N'Epoxy')
INSERT [dbo].[Materialen] ([Id], [Naam]) VALUES (6, N'Polyester')
SET IDENTITY_INSERT [dbo].[Materialen] OFF
GO
SET IDENTITY_INSERT [dbo].[Surfboards] ON 

INSERT [dbo].[Surfboards] ([Id], [Naam], [Beschrijving], [MateriaalId], [Prijs], [FotoUrl]) VALUES (1, N'Rainbow Warrior', N'Coole glanzende surfboard met regenboogpatroon. Be Inclusive, be Proud!', 5, CAST(450.00 AS Decimal(18, 2)), N'RAINBOW-BOARDSPORTS-SURF-RSC-SURFBOARDS-SURFBOARDS-CLSSHDRAIN_1.jfif')
INSERT [dbo].[Surfboards] ([Id], [Naam], [Beschrijving], [MateriaalId], [Prijs], [FotoUrl]) VALUES (2, N'Green Apple', N'De droom van de liefhebers van groene sappige apples', 3, CAST(780.00 AS Decimal(18, 2)), N'surfboard-image-15.png')
INSERT [dbo].[Surfboards] ([Id], [Naam], [Beschrijving], [MateriaalId], [Prijs], [FotoUrl]) VALUES (3, N'Classic Wood', N'Ideale surfboard voor beginners die de blits willen maken met een vintage surfboard', 1, CAST(310.75 AS Decimal(18, 2)), N'USL12652_01.jpg')
INSERT [dbo].[Surfboards] ([Id], [Naam], [Beschrijving], [MateriaalId], [Prijs], [FotoUrl]) VALUES (4, N'Fast white', N'Snel surfboard om de hoogste golven te bedwingen', 5, CAST(456.56 AS Decimal(18, 2)), N'3PEATTEST.jpg')
SET IDENTITY_INSERT [dbo].[Surfboards] OFF
GO
INSERT [dbo].[Voorraad] ([SurfboardId], [FiliaalId], [Aantal]) VALUES (1, 1, 3)
INSERT [dbo].[Voorraad] ([SurfboardId], [FiliaalId], [Aantal]) VALUES (2, 1, 7)
INSERT [dbo].[Voorraad] ([SurfboardId], [FiliaalId], [Aantal]) VALUES (2, 2, 13)
INSERT [dbo].[Voorraad] ([SurfboardId], [FiliaalId], [Aantal]) VALUES (3, 1, 10)
INSERT [dbo].[Voorraad] ([SurfboardId], [FiliaalId], [Aantal]) VALUES (3, 2, 3)
INSERT [dbo].[Voorraad] ([SurfboardId], [FiliaalId], [Aantal]) VALUES (4, 1, 2)
GO
SET IDENTITY_INSERT [dbo].[Vragen] ON 

INSERT [dbo].[Vragen] ([Id], [Tekst], [VraagstellerId]) VALUES (1, N'Wat zijn de openingstijden?', 2)
INSERT [dbo].[Vragen] ([Id], [Tekst], [VraagstellerId]) VALUES (2, N'Hoeveel mensen werken bij Smoothboard Stylers', 5)
INSERT [dbo].[Vragen] ([Id], [Tekst], [VraagstellerId]) VALUES (3, N'Verkoop Smoothboard Stylers ook Windsurfboards en Kites?', 6)
INSERT [dbo].[Vragen] ([Id], [Tekst], [VraagstellerId]) VALUES (4, N'Waarom zijn de bananen krom', 7)
INSERT [dbo].[Vragen] ([Id], [Tekst], [VraagstellerId]) VALUES (5, N'Versturen jullie ook surfboards naar nederland?', 8)
INSERT [dbo].[Vragen] ([Id], [Tekst], [VraagstellerId]) VALUES (6, N'Gaan jullie binnenkort ook surfboards leveren van Aluminium', 9)
INSERT [dbo].[Vragen] ([Id], [Tekst], [VraagstellerId]) VALUES (7, N'Is het mogelijk om een surfboard te proberen op zee?', 10)
SET IDENTITY_INSERT [dbo].[Vragen] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 23-3-2021 16:23:00 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 23-3-2021 16:23:00 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 23-3-2021 16:23:00 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 23-3-2021 16:23:00 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 23-3-2021 16:23:00 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 23-3-2021 16:23:00 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 23-3-2021 16:23:00 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContactSurfboard_SurfBoardInteressesId]    Script Date: 23-3-2021 16:23:00 ******/
CREATE NONCLUSTERED INDEX [IX_ContactSurfboard_SurfBoardInteressesId] ON [dbo].[ContactSurfboard]
(
	[SurfBoardInteressesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Surfboards_MateriaalId]    Script Date: 23-3-2021 16:23:00 ******/
CREATE NONCLUSTERED INDEX [IX_Surfboards_MateriaalId] ON [dbo].[Surfboards]
(
	[MateriaalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Voorraad_FiliaalId]    Script Date: 23-3-2021 16:23:00 ******/
CREATE NONCLUSTERED INDEX [IX_Voorraad_FiliaalId] ON [dbo].[Voorraad]
(
	[FiliaalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Vragen_VraagstellerId]    Script Date: 23-3-2021 16:23:00 ******/
CREATE NONCLUSTERED INDEX [IX_Vragen_VraagstellerId] ON [dbo].[Vragen]
(
	[VraagstellerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Vragen] ADD  DEFAULT ((0)) FOR [VraagstellerId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ContactSurfboard]  WITH CHECK ADD  CONSTRAINT [FK_ContactSurfboard_Contacten_InteresseContactenId] FOREIGN KEY([InteresseContactenId])
REFERENCES [dbo].[Contacten] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ContactSurfboard] CHECK CONSTRAINT [FK_ContactSurfboard_Contacten_InteresseContactenId]
GO
ALTER TABLE [dbo].[ContactSurfboard]  WITH CHECK ADD  CONSTRAINT [FK_ContactSurfboard_Surfboards_SurfBoardInteressesId] FOREIGN KEY([SurfBoardInteressesId])
REFERENCES [dbo].[Surfboards] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ContactSurfboard] CHECK CONSTRAINT [FK_ContactSurfboard_Surfboards_SurfBoardInteressesId]
GO
ALTER TABLE [dbo].[Surfboards]  WITH CHECK ADD  CONSTRAINT [FK_Surfboards_Materialen_MateriaalId] FOREIGN KEY([MateriaalId])
REFERENCES [dbo].[Materialen] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Surfboards] CHECK CONSTRAINT [FK_Surfboards_Materialen_MateriaalId]
GO
ALTER TABLE [dbo].[Voorraad]  WITH CHECK ADD  CONSTRAINT [FK_Voorraad_Filialen_FiliaalId] FOREIGN KEY([FiliaalId])
REFERENCES [dbo].[Filialen] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Voorraad] CHECK CONSTRAINT [FK_Voorraad_Filialen_FiliaalId]
GO
ALTER TABLE [dbo].[Voorraad]  WITH CHECK ADD  CONSTRAINT [FK_Voorraad_Surfboards_SurfboardId] FOREIGN KEY([SurfboardId])
REFERENCES [dbo].[Surfboards] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Voorraad] CHECK CONSTRAINT [FK_Voorraad_Surfboards_SurfboardId]
GO
ALTER TABLE [dbo].[Vragen]  WITH CHECK ADD  CONSTRAINT [FK_Vragen_Contacten_VraagstellerId] FOREIGN KEY([VraagstellerId])
REFERENCES [dbo].[Contacten] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vragen] CHECK CONSTRAINT [FK_Vragen_Contacten_VraagstellerId]
GO
USE [master]
GO
ALTER DATABASE [SmoothBoardStylersDb-19AO] SET  READ_WRITE 
GO
