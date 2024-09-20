IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Brans] (
    [Id] uniqueidentifier NOT NULL,
    [BransAdi] nvarchar(100) NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    CONSTRAINT [PK_Brans] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Donem] (
    [Id] uniqueidentifier NOT NULL,
    [DonemAdi] nvarchar(100) NOT NULL,
    [DonemBaslangicTarihi] date NOT NULL,
    [DonemBitisTarihi] date NOT NULL,
    [DonemYil] int NOT NULL,
    [DonemAy] int NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    CONSTRAINT [PK_Donem] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [EkdersKodu] (
    [Id] uniqueidentifier NOT NULL,
    [KodAd] nvarchar(100) NOT NULL,
    [Kodu] nvarchar(100) NOT NULL,
    [Aciklama] nvarchar(500) NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    CONSTRAINT [PK_EkdersKodu] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Gorev] (
    [Id] uniqueidentifier NOT NULL,
    [GorevAd] nvarchar(500) NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    CONSTRAINT [PK_Gorev] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [IzinTuru] (
    [Id] uniqueidentifier NOT NULL,
    [TurAdi] nvarchar(500) NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    CONSTRAINT [PK_IzinTuru] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [KurumBilgi] (
    [Id] uniqueidentifier NOT NULL,
    [Etiket] nvarchar(200) NOT NULL,
    [Deger] nvarchar(500) NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    CONSTRAINT [PK_KurumBilgi] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Tatil] (
    [Id] uniqueidentifier NOT NULL,
    [TatilAd] nvarchar(500) NOT NULL,
    [TatilTuru] nvarchar(max) NOT NULL,
    [BaslangicTarihi] date NOT NULL,
    [Yarimgunvarmi] bit NOT NULL,
    [GunSayisi] int NOT NULL,
    [EkDersKesilirmi] bit NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    CONSTRAINT [PK_Tatil] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Personel] (
    [Id] uniqueidentifier NOT NULL,
    [Ad] nvarchar(50) NOT NULL,
    [Soyad] nvarchar(50) NOT NULL,
    [TCKN] nvarchar(50) NOT NULL,
    [Telefon] nvarchar(500) NOT NULL,
    [GorevId] uniqueidentifier NOT NULL,
    [BransId] uniqueidentifier NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    CONSTRAINT [PK_Personel] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Personel_Brans_BransId] FOREIGN KEY ([BransId]) REFERENCES [Brans] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Personel_Gorev_GorevId] FOREIGN KEY ([GorevId]) REFERENCES [Gorev] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [EkdersResult] (
    [Id] uniqueidentifier NOT NULL,
    [PersonelId] uniqueidentifier NOT NULL,
    [KodId] uniqueidentifier NOT NULL,
    [DonemId] uniqueidentifier NOT NULL,
    [Data] nvarchar(max) NOT NULL,
    [Gun0] int NOT NULL,
    [Gun1] int NOT NULL,
    [Gun2] int NOT NULL,
    [Gun3] int NOT NULL,
    [Gun4] int NOT NULL,
    [Gun5] int NOT NULL,
    [Gun6] int NOT NULL,
    [Gun7] int NOT NULL,
    [Gun8] int NOT NULL,
    [Gun9] int NOT NULL,
    [Gun10] int NOT NULL,
    [Gun11] int NOT NULL,
    [Gun13] int NOT NULL,
    [Gun14] int NOT NULL,
    [Gun15] int NOT NULL,
    [Gun16] int NOT NULL,
    [Gun17] int NOT NULL,
    [Gun18] int NOT NULL,
    [Gun19] int NOT NULL,
    [Gun20] int NOT NULL,
    [Gun21] int NOT NULL,
    [Gun22] int NOT NULL,
    [Gun23] int NOT NULL,
    [Gun24] int NOT NULL,
    [Gun25] int NOT NULL,
    [Gun26] int NOT NULL,
    [Gun27] int NOT NULL,
    [Gun28] int NOT NULL,
    [Gun29] int NOT NULL,
    [Gun30] int NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    CONSTRAINT [PK_EkdersResult] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_EkdersResult_Donem_DonemId] FOREIGN KEY ([DonemId]) REFERENCES [Donem] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EkdersResult_EkdersKodu_KodId] FOREIGN KEY ([KodId]) REFERENCES [EkdersKodu] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EkdersResult_Personel_PersonelId] FOREIGN KEY ([PersonelId]) REFERENCES [Personel] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Izin] (
    [Id] uniqueidentifier NOT NULL,
    [BaslagicTarihi] date NOT NULL,
    [GunSayisi] int NOT NULL,
    [Aciklama] nvarchar(500) NOT NULL,
    [EkDerskesilecekmi] bit NOT NULL,
    [IzinTuruId] uniqueidentifier NOT NULL,
    [PersonelId] uniqueidentifier NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    CONSTRAINT [PK_Izin] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Izin_IzinTuru_IzinTuruId] FOREIGN KEY ([IzinTuruId]) REFERENCES [IzinTuru] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Izin_Personel_PersonelId] FOREIGN KEY ([PersonelId]) REFERENCES [Personel] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreateDate', N'GorevAd', N'IsDeleted') AND [object_id] = OBJECT_ID(N'[Gorev]'))
    SET IDENTITY_INSERT [Gorev] ON;
INSERT INTO [Gorev] ([Id], [CreateDate], [GorevAd], [IsDeleted])
VALUES ('0c30e774-4b13-4ec4-b354-157728ffb11c', '2024-09-19T21:21:54.1999151+03:00', N'Müdür', CAST(0 AS bit)),
('35084397-55c0-47bb-b1fe-17f02ff27601', '2024-09-19T21:21:54.1999186+03:00', N'Öğretmen', CAST(0 AS bit)),
('3b4dcbef-c723-40be-b73e-19cd09604c59', '2024-09-19T21:21:54.1999169+03:00', N'Müdür Yardımcısı', CAST(0 AS bit)),
('9b12ff59-0858-4fa2-9c20-f1ecd1c60098', '2024-09-19T21:21:54.1999187+03:00', N'Uzman Öğretmen', CAST(0 AS bit)),
('ac86700e-3f47-4b67-b0cd-06c038065ca7', '2024-09-19T21:21:54.1999189+03:00', N'Baş Öğretmen', CAST(0 AS bit));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreateDate', N'GorevAd', N'IsDeleted') AND [object_id] = OBJECT_ID(N'[Gorev]'))
    SET IDENTITY_INSERT [Gorev] OFF;
GO

CREATE INDEX [IX_EkdersResult_DonemId] ON [EkdersResult] ([DonemId]);
GO

CREATE INDEX [IX_EkdersResult_KodId] ON [EkdersResult] ([KodId]);
GO

CREATE INDEX [IX_EkdersResult_PersonelId] ON [EkdersResult] ([PersonelId]);
GO

CREATE INDEX [IX_Izin_IzinTuruId] ON [Izin] ([IzinTuruId]);
GO

CREATE INDEX [IX_Izin_PersonelId] ON [Izin] ([PersonelId]);
GO

CREATE INDEX [IX_Personel_BransId] ON [Personel] ([BransId]);
GO

CREATE INDEX [IX_Personel_GorevId] ON [Personel] ([GorevId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240919182154_bir', N'8.0.8');
GO

COMMIT;
GO

