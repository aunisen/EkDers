USE master
GO
create database [EkdersDbV2]
go
USE [EkdersDbV2]
GO
/****** Object:  Table [dbo].[Brans]    Script Date: 25.09.2024 08:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brans](
	[Id] [uniqueidentifier] NOT NULL,
	[BransAd] [nvarchar](100) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Brans] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donem]    Script Date: 25.09.2024 08:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donem](
	[Id] [uniqueidentifier] NOT NULL,
	[DonemAd] [nvarchar](100) NOT NULL,
	[DonemBaslangicTarihi] [date] NOT NULL,
	[DonemBitisTarihi] [date] NOT NULL,
	[DonemYil] [int] NOT NULL,
	[DonemAy] [int] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Donem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EkdersKodu]    Script Date: 25.09.2024 08:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EkdersKodu](
	[Id] [uniqueidentifier] NOT NULL,
	[KodAd] [nvarchar](100) NOT NULL,
	[Kodu] [nvarchar](10) NOT NULL,
	[Aciklama] [nvarchar](500) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_EkdersKodu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gorev]    Script Date: 25.09.2024 08:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gorev](
	[Id] [uniqueidentifier] NOT NULL,
	[GorevAd] [nvarchar](500) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Gorev] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IzinTuru]    Script Date: 25.09.2024 08:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IzinTuru](
	[Id] [uniqueidentifier] NOT NULL,
	[TurAdi] [nvarchar](500) NOT NULL,
	[RaporKodu] [nvarchar](max) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_IzinTuru] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KariyerBasamagi]    Script Date: 25.09.2024 08:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KariyerBasamagi](
	[Id] [uniqueidentifier] NOT NULL,
	[Ad] [nvarchar](200) NOT NULL,
	[Aciklama] [nvarchar](500) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_KariyerBasamagi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KurumBilgi]    Script Date: 25.09.2024 08:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KurumBilgi](
	[Id] [uniqueidentifier] NOT NULL,
	[Etiket] [nvarchar](200) NOT NULL,
	[Deger] [nvarchar](500) NOT NULL,
	[Aciklama] [nvarchar](max) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_KurumBilgi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MezuniyetTuru]    Script Date: 25.09.2024 08:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MezuniyetTuru](
	[Id] [uniqueidentifier] NOT NULL,
	[MezuniyetTurAd] [nvarchar](100) NOT NULL,
	[OdemeKodu] [nvarchar](max) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_MezuniyetTuru] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogretmen]    Script Date: 25.09.2024 08:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogretmen](
	[Id] [uniqueidentifier] NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[TCKN] [nvarchar](11) NOT NULL,
	[Telefon] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[GorevId] [uniqueidentifier] NOT NULL,
	[BransId] [uniqueidentifier] NOT NULL,
	[MezuniyetTuruId] [uniqueidentifier] NOT NULL,
	[KariyerBasamagiId] [uniqueidentifier] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[KulubuVarmi] [bit] NOT NULL DEFAULT(0),
	[SinifOgretmenligiVarmi] [bit] NOT NULL DEFAULT(0),
 CONSTRAINT [PK_Ogretmen] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgretmenIzin]    Script Date: 25.09.2024 08:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgretmenIzin](
	[Id] [uniqueidentifier] NOT NULL,
	[BaslagicTarihi] [date] NOT NULL,
	[GunSayisi] [int] NOT NULL,
	[Aciklama] [nvarchar](500) NOT NULL,
	[OdenecekEkdersSaati] [int] NOT NULL,
	[IzinTuruId] [uniqueidentifier] NOT NULL,
	[OgretmenId] [uniqueidentifier] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_OgretmenIzin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgretmenProgram]    Script Date: 25.09.2024 08:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgretmenProgram](
	[Id] [uniqueidentifier] NOT NULL,
	[ProgramGroupId] [uniqueidentifier] NOT NULL,
	[OgretmenId] [uniqueidentifier] NOT NULL,
	[EkdersKoduId] [uniqueidentifier] NOT NULL,
	[PazartesiDersSaati] [int] NOT NULL,
	[SaliDersSaati] [int] NOT NULL,
	[CarsambaDersSaati] [int] NOT NULL,
	[PersembeDersSaati] [int] NOT NULL,
	[CumaDersSaati] [int] NOT NULL,
	[CumartesiDersSaati] [int] NOT NULL,
	[PazarDersSaati] [int] NOT NULL,
	[PazartesiEkdersSaati] [int] NOT NULL,
	[SaliEkdersSaati] [int] NOT NULL,
	[CarsambaEkdersSaati] [int] NOT NULL,
	[PersembeEkdersSaati] [int] NOT NULL,
	[CumaEkdersSaati] [int] NOT NULL,
	[CumartesiEkdersSaati] [int] NOT NULL,
	[PazarEkdersSaati] [int] NOT NULL,
	[DerseHazrilikEkdersSaati] [int] NOT NULL,
	[NobetGunIndex] [int] NOT NULL,
	[NobetEkdersSaati] [int] NOT NULL,
	[NobetTutuyormu] [bit] NOT NULL,
	[SinifOgremenligiKlupDersSaati] [int] NOT NULL,
	[SinifOgremenligiKlupGoreviVarmi] [bit] NOT NULL,
	[PazartesiYazilacakEkdersSaati] [int] NOT NULL,
	[SaliYazilacakEkdersSaati] [int] NOT NULL,
	[CarsambaYazilacakEkdersSaati] [int] NOT NULL,
	[PersembeYazilacakEkdersSaati] [int] NOT NULL,
	[CumaYazilacakEkdersSaati] [int] NOT NULL,
	[CumartesiYazilacakEkdersSaati] [int] NOT NULL,
	[PazarYazilacakEkdersSaati] [int] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_OgretmenProgram] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramGroup]    Script Date: 25.09.2024 08:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramGroup](
	[Id] [uniqueidentifier] NOT NULL,
	[GroupAd] [nvarchar](200) NOT NULL,
	[Aciklama] [nvarchar](500) NOT NULL,
	[BaslangicTarihi] [date] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_ProgramGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RaporItem]    Script Date: 25.09.2024 08:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RaporItem](
	[Id] [uniqueidentifier] NOT NULL,
	[OgretmenId] [uniqueidentifier] NOT NULL,
	[KodId] [uniqueidentifier] NOT NULL,
	[DonemId] [uniqueidentifier] NOT NULL,
	[GunSayisi] [int] NOT NULL,
	[Data] [varbinary](max) NOT NULL,
	[Toplam] [int] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_RaporItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tatil]    Script Date: 25.09.2024 08:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tatil](
	[Id] [uniqueidentifier] NOT NULL,
	[TatilAd] [nvarchar](500) NOT NULL,
	[TatilTuru] [nvarchar](max) NOT NULL,
	[BaslangicTarihi] [date] NOT NULL,
	[Yarimgunvarmi] [bit] NOT NULL,
	[GunSayisi] [int] NOT NULL,
	[EkDersKesilirmi] [bit] NOT NULL,
	[RaporKodu] [nvarchar](max) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Tatil] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

USE [EkdersDbV2]
GO
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'f78e931d-f45c-4cc3-8590-0566878a01a8', N'COĞRAFYA', CAST(N'2024-09-24T11:35:55.4960553' AS DateTime2), 0)
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'8f1b06f3-9897-423e-802c-125fb2526fe3', N'FİZİK', CAST(N'2024-09-24T11:36:01.9616845' AS DateTime2), 0)
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'3e903390-62de-40f9-a973-1af0fdbae730', N'REHBERLİK', CAST(N'2024-09-24T11:38:02.4277130' AS DateTime2), 0)
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'ca90d2aa-9374-44cf-ad1d-46a8d90aba57', N'BİYOLOJİ', CAST(N'2024-09-24T11:36:18.2863985' AS DateTime2), 0)
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'9a190030-a0ea-425b-826e-4a7967d94d12', N'KİMYA - KİMYA TEKNOLOJİSİ', CAST(N'2024-09-24T11:35:01.8375655' AS DateTime2), 0)
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'8b818b7b-3576-4122-a0cc-613d351f6374', N'MATEMATİK', CAST(N'2024-09-24T11:34:23.6520796' AS DateTime2), 0)
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'be41c1a5-7868-4526-a735-743b2d377807', N'TARİH', CAST(N'2024-09-24T11:35:33.7076395' AS DateTime2), 0)
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'3c652dd2-ff58-4134-9f22-9a41015a0f84', N'FELSEFE', CAST(N'2024-09-24T11:37:00.5160275' AS DateTime2), 0)
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'fbc0b348-42b3-44e4-a1b5-9d8a92b153a6', N'MÜZİK', CAST(N'2024-09-24T11:35:23.8494389' AS DateTime2), 0)
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'6dd63e53-3fe7-4214-b042-b0917877adbf', N'TÜRK DİLİ VE EDEBİYATI', CAST(N'2024-09-24T11:35:16.7871769' AS DateTime2), 0)
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'dcba34e6-2d21-417a-a07d-ba00a87f4a20', N'DİN KÜLTÜRÜ VE AHLAK BİLGİSİ', CAST(N'2024-09-24T11:34:46.4495758' AS DateTime2), 0)
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'db324a8d-c5cd-4770-bd29-c6f31ceac16d', N'GÖRSEL SANATLAR', CAST(N'2024-09-24T11:36:42.9730396' AS DateTime2), 0)
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'3a76a261-61f9-4e80-9621-d983fa2fcdc5', N'İNGİLİZCE', CAST(N'2024-09-24T11:36:09.0207565' AS DateTime2), 0)
INSERT [dbo].[Brans] ([Id], [BransAd], [CreateDate], [IsDeleted]) VALUES (N'47f8b989-32c5-4f73-9cf6-e2d385f7280e', N'BİLİŞİM TEKNOLOJİLERİ', CAST(N'2024-09-24T11:35:45.4449699' AS DateTime2), 0)
GO
INSERT [dbo].[Gorev] ([Id], [GorevAd], [CreateDate], [IsDeleted]) VALUES (N'0c30e774-4b13-4ec4-b354-157728ffb11c', N'Müdür', CAST(N'2024-09-23T15:42:43.3666469' AS DateTime2), 0)
INSERT [dbo].[Gorev] ([Id], [GorevAd], [CreateDate], [IsDeleted]) VALUES (N'35084397-55c0-47bb-b1fe-17f02ff27601', N'Öğretmen', CAST(N'2024-09-23T15:42:43.3666489' AS DateTime2), 0)
INSERT [dbo].[Gorev] ([Id], [GorevAd], [CreateDate], [IsDeleted]) VALUES (N'3b4dcbef-c723-40be-b73e-19cd09604c59', N'Müdür Yardımcısı', CAST(N'2024-09-23T15:42:43.3666488' AS DateTime2), 0)
GO
INSERT [dbo].[KariyerBasamagi] ([Id], [Ad], [Aciklama], [CreateDate], [IsDeleted]) VALUES (N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', N'Öğretmen', N'Kadrolu öğretmenler', CAST(N'2024-09-24T12:09:35.5549377' AS DateTime2), 0)
INSERT [dbo].[KariyerBasamagi] ([Id], [Ad], [Aciklama], [CreateDate], [IsDeleted]) VALUES (N'538dfd5e-e627-4823-8017-505a4629712f', N'Baş Öğretmen', N'Kadrolu öğretmenler', CAST(N'2024-09-24T12:09:35.5722035' AS DateTime2), 0)
INSERT [dbo].[KariyerBasamagi] ([Id], [Ad], [Aciklama], [CreateDate], [IsDeleted]) VALUES (N'49341a6d-ef3a-4b7d-807c-9961a8496aa0', N'Aday Öğretmen', N'Kadrolu öğretmenler', CAST(N'2024-09-24T12:09:35.5720359' AS DateTime2), 0)
INSERT [dbo].[KariyerBasamagi] ([Id], [Ad], [Aciklama], [CreateDate], [IsDeleted]) VALUES (N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', N'Uzman Öğretmen', N'Kadrolu öğretmenler', CAST(N'2024-09-24T12:09:35.5721898' AS DateTime2), 0)
GO
INSERT [dbo].[MezuniyetTuru] ([Id], [MezuniyetTurAd], [OdemeKodu], [CreateDate], [IsDeleted]) VALUES (N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'Fakülte/Üniversite', N'', CAST(N'2024-09-24T12:16:14.8293524' AS DateTime2), 0)
INSERT [dbo].[MezuniyetTuru] ([Id], [MezuniyetTurAd], [OdemeKodu], [CreateDate], [IsDeleted]) VALUES (N'64baff9b-35b5-4b15-b97e-a2c5ce6d20c8', N'Yüksek Okul/Üniversite', N'', CAST(N'2024-09-24T12:16:14.8432307' AS DateTime2), 0)
INSERT [dbo].[MezuniyetTuru] ([Id], [MezuniyetTurAd], [OdemeKodu], [CreateDate], [IsDeleted]) VALUES (N'3b4e7a55-eeaf-435a-8a00-be6bb82777be', N'Doktora/Üniversite', N'', CAST(N'2024-09-24T12:16:14.8432227' AS DateTime2), 0)
INSERT [dbo].[MezuniyetTuru] ([Id], [MezuniyetTurAd], [OdemeKodu], [CreateDate], [IsDeleted]) VALUES (N'0ade8c40-0801-49ab-8294-f019d9a9c271', N'Yüksek Lisans/Üniversite', N'', CAST(N'2024-09-24T12:16:14.8431349' AS DateTime2), 0)
GO
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'eab0044a-7004-4448-90da-063ee776c2a2', N'Levent', N'Günçe', N'33409851362', N'5062556350', N'leventgunce@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'3a76a261-61f9-4e80-9621-d983fa2fcdc5', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:11:12.9274855' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'da0d8e33-b6e5-45d6-9391-078bddd2f71c', N'Fatih', N'Çevik', N'41821609720', N'5322049593', N'fcevik77@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'8b818b7b-3576-4122-a0cc-613d351f6374', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:02:35.0362413' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'dc625534-18f9-46e3-9031-0a5c9f1e84d6', N'İnci', N'Üstüntürk', N'42904456576', N'5366131652', N'inciozyer@yahoo.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'ca90d2aa-9374-44cf-ad1d-46a8d90aba57', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T14:09:25.6788943' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'f0cd5129-297b-4e5b-8f8d-0aaa85bbeded', N'Yasemin', N'Kırıştıoğlu', N'58972249286', N'5528324737', N'yaseminongun11@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'9a190030-a0ea-425b-826e-4a7967d94d12', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T14:32:20.6028101' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'4277a291-5521-4532-ba3f-0e424110b391', N'Kübra', N'Kocaoğlu', N'25714873108', N'5064079030', N'kubrakocaoglu@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'ca90d2aa-9374-44cf-ad1d-46a8d90aba57', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:10:24.8950539' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'd704528f-3f0d-4f3a-8c3c-12c07cefa0be', N'Esra', N'Karaaslan', N'40129792172', N'5366547048', N'esrakrsln_1992@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'8b818b7b-3576-4122-a0cc-613d351f6374', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'49341a6d-ef3a-4b7d-807c-9961a8496aa0', CAST(N'2024-09-24T14:00:04.2206512' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'b3f37b62-6383-42f5-b25d-18d984bb836d', N'Fatih Selim', N'Akyürek', N'70159091440', N'5305149429', N'fatihselimakyurek@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'8b818b7b-3576-4122-a0cc-613d351f6374', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:03:33.4696021' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'a54008f2-6807-4443-83b6-193ae5a2ff9b', N'Hale', N'Aktuna', N'23522267638', N'5058118513', N'aktunahale@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'3a76a261-61f9-4e80-9621-d983fa2fcdc5', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:05:27.5182822' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'ec44fd64-aaff-404a-90fe-19862e9ffe4c', N'Hüseyin', N'Atay', N'21158633582', N'5366450644', N'atayhuseyin76@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'6dd63e53-3fe7-4214-b042-b0917877adbf', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:06:19.2736347' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'234c357e-5437-40c7-be2d-24907df5b10f', N'Fazilet', N'Kortun', N'40351509074', N'5058069981', N'faziletkortun@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'3a76a261-61f9-4e80-9621-d983fa2fcdc5', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:04:38.4454546' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'caeb9346-e3c5-4582-8a52-2f753b516f0f', N'Murat', N'Karcı', N'24793954654', N'5532038638', N'karcimurat54@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'8b818b7b-3576-4122-a0cc-613d351f6374', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T14:17:50.9575895' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'2be511b6-51f0-47a6-81d5-2fb18991f38a', N'Merve', N'Sunakan', N'35245712470', N'5077990219', N'mervemumayy@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'6dd63e53-3fe7-4214-b042-b0917877adbf', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T14:17:01.7831552' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'8e516902-e80b-44ca-b07c-325134f25ec9', N'Serdar', N'Karataş', N'30388561442', N'5053164980', N'serdarkaratas44@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'3c652dd2-ff58-4134-9f22-9a41015a0f84', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:29:07.1553375' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'ff8fa3ac-4a8a-4068-b982-3a5689cb93bc', N'Nurgül', N'Altan', N'24839010894', N'5465714370', N'nurgulmert03@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'ca90d2aa-9374-44cf-ad1d-46a8d90aba57', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T14:24:25.6163583' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'd0fcda78-24f3-4922-b950-445783af8959', N'Esra', N'Kale Tekintanğaç', N'23311287120', N'5445483118', N'amargiesra@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'f78e931d-f45c-4cc3-8590-0566878a01a8', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T13:58:23.3334576' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'34100bf5-e9cd-44f2-bd34-484ec6688932', N'Memduha', N'Erbaş', N'47278869472', N'5456287276', N'memduhanil@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'db324a8d-c5cd-4770-bd29-c6f31ceac16d', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:15:42.8203027' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'0f2f26c2-3c36-4e93-9369-50ea5e28d5a8', N'Dilek', N'Nalbantlar Erdoğan', N'40153155172', N'5383985540', N'dlk.bb.2007@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'6dd63e53-3fe7-4214-b042-b0917877adbf', N'3b4e7a55-eeaf-435a-8a00-be6bb82777be', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T13:51:44.5964367' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'5b579c6c-4850-425f-93bb-519dcfd15040', N'Abdullah', N'Ateş', N'47434140872', N'5056814287', N'abdullah262003@yahoo.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'dcba34e6-2d21-417a-a07d-ba00a87f4a20', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T13:40:03.6340146' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'3deeab4f-5811-4570-bda7-556cb5cf7ed9', N'Can Ali', N'Şeker', N'31181370958', N'5433731094', N'sekercanali@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'6dd63e53-3fe7-4214-b042-b0917877adbf', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T13:45:22.7486234' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'3c91ba8b-dd96-4925-aa03-578abffd5941', N'Merve', N'Akarsu', N'36152040236', N'5319197941', N'merveakkarsu@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'dcba34e6-2d21-417a-a07d-ba00a87f4a20', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T14:16:21.2133350' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'5f7a38f7-c3d9-4275-aca7-62d187649864', N'Bekir', N'Ünişen', N'23248064122', N'05078584794', N'aunisen@hotmail.com', N'3b4dcbef-c723-40be-b73e-19cd09604c59', N'8b818b7b-3576-4122-a0cc-613d351f6374', N'0ade8c40-0801-49ab-8294-f019d9a9c271', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T13:34:41.4716017' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'7a87b874-01a2-4567-a8e5-673bd51a68a0', N'Cengiz', N'Yılmaz', N'32803616638', N'5555645756', N'cengizmusic@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'fbc0b348-42b3-44e4-a1b5-9d8a92b153a6', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T13:47:59.8913192' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'1128d0a4-557b-4765-9abf-6936ae1dab54', N'Hüseyin Yavuz', N'Kandemir', N'72688009224', N'5424141494', N'mert_kandemir99@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'6dd63e53-3fe7-4214-b042-b0917877adbf', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T14:07:02.6810330' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'd848285e-12d4-4afb-9c1e-6bb5d388d823', N'Ebru', N'Akbal', N'41347116030', N'5055840206', N'ebruozebek@gmail.com', N'3b4dcbef-c723-40be-b73e-19cd09604c59', N'be41c1a5-7868-4526-a735-743b2d377807', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T13:54:12.2693758' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'fbc0ed4f-d569-4593-a482-6d0db007b442', N'Aydın', N'Şahin', N'20950098384', N'5053135499', N'aysah3@yahoo.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'8b818b7b-3576-4122-a0cc-613d351f6374', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T13:41:29.6726794' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'6f445dd1-e37f-4679-8b7d-754cf3f57853', N'Nevim', N'Kılıç', N'18557374628', N'5056283295', N'nk.md@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'be41c1a5-7868-4526-a735-743b2d377807', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:19:17.4412168' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'f2bd66ac-bdc0-48ac-b566-7e95b5777e4c', N'İbrahim', N'Demirok', N'51472355822', N'5056970892', N'ibrahimdemirok69@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'dcba34e6-2d21-417a-a07d-ba00a87f4a20', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:08:37.1236143' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'239445d9-c040-4699-aeaa-82dcc54c6ba2', N'Zuhal', N'Akçay Doğru', N'66595054460', N'5543078159', N'zuhal_akcy@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'8b818b7b-3576-4122-a0cc-613d351f6374', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T14:34:34.6171396' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'91fb5df6-dafa-4d04-bcbd-839a7c6fd462', N'Nuray', N'Şimşek Satır', N'21709345056', N'5386650343', N'nurann_sevenn@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'8b818b7b-3576-4122-a0cc-613d351f6374', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:23:15.3832620' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'9802b57b-d24f-4f9c-9547-842425b09413', N'Osman', N'Karakuş', N'18061988304', N'5453397687', N'karakus-23@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'f78e931d-f45c-4cc3-8590-0566878a01a8', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:26:06.5014355' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'3fd1e8db-063b-4329-83a4-8622af533c6d', N'Elveda', N'Sarak', N'14551376934', N'5436656662', N'elvedasarak@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'47f8b989-32c5-4f73-9cf6-e2d385f7280e', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T13:55:52.4005165' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'ae57b44a-4703-4ce6-8665-8e76295670d2', N'Behice', N'Erener', N'56185626504', N'5058215014', N'berener65@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'9a190030-a0ea-425b-826e-4a7967d94d12', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T13:43:17.3400676' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'9f6cda26-501e-4b93-8705-906b4f035383', N'Yavuz', N'Usta', N'28906686432', N'5065339449', N'yavuzusta1@hotmail.com', N'0c30e774-4b13-4ec4-b354-157728ffb11c', N'3c652dd2-ff58-4134-9f22-9a41015a0f84', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'538dfd5e-e627-4823-8017-505a4629712f', CAST(N'2024-09-24T14:33:00.0902360' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'6f8c35a1-ce20-40d2-9b21-9f3d3a3b4e1b', N'Nihan', N'Özel', N'10346542522', N'5556328167', N'34nihanozel@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'6dd63e53-3fe7-4214-b042-b0917877adbf', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:20:46.9860002' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'22092eec-b9b5-49a9-89b9-a449bd58c568', N'Sebil', N'Fındıklı', N'13880662992', N'5052713280', N'sebilf@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'3a76a261-61f9-4e80-9621-d983fa2fcdc5', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:26:57.2323742' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'e7200657-3b61-40ed-92a8-a6b8044c815e', N'Emine', N'Dağ', N'11352022534', N'5427360061', N'emoss_71@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'6dd63e53-3fe7-4214-b042-b0917877adbf', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T13:57:24.9198556' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'64c3e27d-3faf-47fd-80c1-a7f78c70d220', N'Yunus', N'Şendur', N'62671155182', N'5337372176', N'yns01011983@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'8b818b7b-3576-4122-a0cc-613d351f6374', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:33:47.8265788' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'17c7e198-a8eb-40e5-af42-a80644b97426', N'Elif Dilanur', N'Kurt', N'15314374884', N'5345803773', N'dilanurdzenli@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'9a190030-a0ea-425b-826e-4a7967d94d12', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T13:55:02.8031276' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'0cac568a-9149-402b-ba1f-aad23a7a136d', N'Oğuz', N'Akşahin', N'11963715474', N'5079846875', N'oguz.aksahin@hotmail.com', N'3b4dcbef-c723-40be-b73e-19cd09604c59', N'6dd63e53-3fe7-4214-b042-b0917877adbf', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:25:15.5479285' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'd85092ea-e740-4b34-890b-b85e9c5f432c', N'Nuran', N'Aslan', N'31225748170', N'5394339083', N'azizsiddik@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'dcba34e6-2d21-417a-a07d-ba00a87f4a20', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T14:21:26.4324143' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'075d23c7-4ea5-425e-b098-bbed278a4ff7', N'Nuran', N'Seven', N'25081955476', N'5316213628', N'nurann_sevenn@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'8f1b06f3-9897-423e-802c-125fb2526fe3', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T14:22:28.8062768' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'215c4aba-3c5b-47e4-8b58-bd803da4d41d', N'Mehtap', N'Bayri', N'41737182362', N'5062779388', N'mehtapyurdusevdi@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'be41c1a5-7868-4526-a735-743b2d377807', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T14:12:18.9219868' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'db7b3847-f137-4ba6-810f-c489d9275ca9', N'Melih', N'Köse', N'53626441900', N'5074458415', N'melihkose1@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'3a76a261-61f9-4e80-9621-d983fa2fcdc5', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:13:08.8960824' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'e37ae914-fd84-47cd-81cf-c4deac85e541', N'Emin', N'Kaya', N'18227522076', N'5357088786', N'kayabuusra@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'8b818b7b-3576-4122-a0cc-613d351f6374', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T13:56:36.3497655' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'1b4a55d6-7281-4efe-880b-dbea40bfadc4', N'Cemal', N'Kahraman', N'66871228448', N'5327916543', N'cemalkahraman70@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'8b818b7b-3576-4122-a0cc-613d351f6374', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'538dfd5e-e627-4823-8017-505a4629712f', CAST(N'2024-09-24T13:46:09.8852854' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'39a9bdd1-1cb4-49ba-aecd-f023bde95e0b', N'Ülkü', N'Karaoğlan', N'41017507724', N'5075776216', N'akaraoglan@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'be41c1a5-7868-4526-a735-743b2d377807', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:30:46.7544966' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'e644ecaa-e649-4946-b79a-f632bd996e17', N'Murat', N'Sulu', N'43015451238', N'5303008830', N'mmuratssulu@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'3c652dd2-ff58-4134-9f22-9a41015a0f84', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'538dfd5e-e627-4823-8017-505a4629712f', CAST(N'2024-09-24T14:18:29.7643377' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'23eab654-f7ff-45d1-b7b8-f7c241ea4f7e', N'Evrim', N'Özerdem', N'29105044566', N'5057727969', N'eozerdem73@gmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'8f1b06f3-9897-423e-802c-125fb2526fe3', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'538dfd5e-e627-4823-8017-505a4629712f', CAST(N'2024-09-24T14:00:53.7518625' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'25c7a500-6088-4ad1-850a-fe360f57819f', N'Yaprak', N'Pehlivan Biçer', N'14785068032', N'5385919206', N'yaprakpehlivan@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'8f1b06f3-9897-423e-802c-125fb2526fe3', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'0d912cc1-ac0b-4042-be72-1dc3a57a4930', CAST(N'2024-09-24T14:31:29.8661453' AS DateTime2), 0)
INSERT [dbo].[Ogretmen] ([Id], [Ad], [Soyad], [TCKN], [Telefon], [Email], [GorevId], [BransId], [MezuniyetTuruId], [KariyerBasamagiId], [CreateDate], [IsDeleted]) VALUES (N'b83893cb-f50e-4606-a614-febe3dab0380', N'Tülin', N'Kurtay', N'14272049650', N'5055494135', N'tulinkurtay@hotmail.com', N'35084397-55c0-47bb-b1fe-17f02ff27601', N'6dd63e53-3fe7-4214-b042-b0917877adbf', N'4cdd88d4-06a9-4df1-8176-89447189be7f', N'fbb8a9f0-a5c1-4411-8286-a7d7e8144cdf', CAST(N'2024-09-24T14:29:51.9047951' AS DateTime2), 0)
GO
INSERT [dbo].[EkdersKodu] ([Id], [KodAd], [Kodu], [Aciklama], [CreateDate], [IsDeleted]) VALUES (N'395e0bce-ecbb-4c05-87be-0113660ed2a4', N'Nöbet', N'119', N'Öğretmen veya İdarecilierin nöbet görevleri içindir.', CAST(N'2024-09-24T11:41:13.0080631' AS DateTime2), 0)
INSERT [dbo].[EkdersKodu] ([Id], [KodAd], [Kodu], [Aciklama], [CreateDate], [IsDeleted]) VALUES (N'8b08f510-d759-4092-adbd-318942bf213b', N'Egzersiz', N'108', N'Öğretmenlerin yaptıkları Egzersiz görevleri içindir.', CAST(N'2024-09-24T11:42:41.7463423' AS DateTime2), 0)
INSERT [dbo].[EkdersKodu] ([Id], [KodAd], [Kodu], [Aciklama], [CreateDate], [IsDeleted]) VALUES (N'66f12d6e-e698-439c-90bf-5c3ba428e404', N'Gündüz', N'101', N'Genel gündüz ek ders görevleri içindir.', CAST(N'2024-09-24T11:40:39.3217398' AS DateTime2), 0)
INSERT [dbo].[EkdersKodu] ([Id], [KodAd], [Kodu], [Aciklama], [CreateDate], [IsDeleted]) VALUES (N'00b97cb4-bc62-4139-899c-c64920f3eacb', N'Sınav Görevi', N'107', N'Kurum içinde yapılan Telafi ve Sorumluluk sınavları içindir.', CAST(N'2024-09-24T11:42:03.9070629' AS DateTime2), 0)
INSERT [dbo].[EkdersKodu] ([Id], [KodAd], [Kodu], [Aciklama], [CreateDate], [IsDeleted]) VALUES (N'bcf6c522-1a72-4c1f-8f92-dc27669396fa', N'%25 Fazla (Gündüz)', N'103', N'Doktora mezunu öğretmenlerin ek dersleri içindir.', CAST(N'2024-09-24T11:44:53.8646600' AS DateTime2), 0)
INSERT [dbo].[EkdersKodu] ([Id], [KodAd], [Kodu], [Aciklama], [CreateDate], [IsDeleted]) VALUES (N'5d914490-bddc-48f8-8166-df4261b48df0', N'Hizmet İçi Eğitim', N'109', N'Öğretmenlerin hizmet içi eğitim aldıkları seminer döemleri ve formatör öğretmenlerin verdikleri seminer görevleri içindir.', CAST(N'2024-09-24T11:43:55.6572820' AS DateTime2), 0)
INSERT [dbo].[EkdersKodu] ([Id], [KodAd], [Kodu], [Aciklama], [CreateDate], [IsDeleted]) VALUES (N'e8c5e11e-327d-4fd8-aaa4-ee993d3683d5', N'DYK', N'116', N'Öğretmenlerin verdikleri Destekleme ve Yetiştime Kursları içindir.', CAST(N'2024-09-24T11:45:44.1508923' AS DateTime2), 0)
GO
INSERT [dbo].[IzinTuru] ([Id], [TurAdi], [RaporKodu], [CreateDate], [IsDeleted]) VALUES (N'0e0eb91b-43bb-4c7b-a737-3ac1c30b395a', N'Sağlık İzni', N'', CAST(N'2024-09-24T11:46:26.9440869' AS DateTime2), 0)
INSERT [dbo].[IzinTuru] ([Id], [TurAdi], [RaporKodu], [CreateDate], [IsDeleted]) VALUES (N'79608cfe-5ad1-4e76-98ad-71a901617aaf', N'Ders İzini', N'', CAST(N'2024-09-24T11:47:20.9951174' AS DateTime2), 0)
INSERT [dbo].[IzinTuru] ([Id], [TurAdi], [RaporKodu], [CreateDate], [IsDeleted]) VALUES (N'066c1112-f68d-4866-8194-b5d39bfb37f7', N'Resmi Tatil', N'', CAST(N'2024-09-24T11:46:09.5336427' AS DateTime2), 0)
INSERT [dbo].[IzinTuru] ([Id], [TurAdi], [RaporKodu], [CreateDate], [IsDeleted]) VALUES (N'fee000bb-3f40-45bc-8877-d6e8ca81156a', N'Mazeret İzni', N'', CAST(N'2024-09-24T11:46:50.0649207' AS DateTime2), 0)
GO
