USE [WareHouseDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 30.09.2022 00:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventories]    Script Date: 30.09.2022 00:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[inventoryName] [nvarchar](max) NULL,
	[WarehouseId] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Inventories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WareHouses]    Script Date: 30.09.2022 00:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WareHouses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[wareHouseName] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_WareHouses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220927195538_FirstMig', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220929200443_edit', N'5.0.17')
SET IDENTITY_INSERT [dbo].[Inventories] ON 

INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (1, N'Hammadde Stoku', 10, 1)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (2, N'Yarı Mamül Stoku', 2, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (3, NULL, 2, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (4, NULL, 1, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (5, NULL, 1, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (6, NULL, 3, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (7, NULL, 2, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (8, NULL, 1, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (9, NULL, 2, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (10, NULL, 2, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (11, N'Çevrim Stoku', 3, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (12, N'Eniyet Stoku', 3, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (13, N'Çevrim Stoku', 1, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (14, N'Emniyet Stoku', 2, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (15, N'Tampon Stoku', 1, 0)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (16, N'Tampon Stoğu', 3, 1)
INSERT [dbo].[Inventories] ([Id], [inventoryName], [WarehouseId], [Status]) VALUES (17, N'Yarı Mamül Stoğu', 8, 1)
SET IDENTITY_INSERT [dbo].[Inventories] OFF
SET IDENTITY_INSERT [dbo].[WareHouses] ON 

INSERT [dbo].[WareHouses] ([Id], [wareHouseName], [Status]) VALUES (1, N'Soğuk Hava Depoları', 0)
INSERT [dbo].[WareHouses] ([Id], [wareHouseName], [Status]) VALUES (2, N'Açık Hava Depoları', 0)
INSERT [dbo].[WareHouses] ([Id], [wareHouseName], [Status]) VALUES (3, N'Kapalı Depoları', 0)
INSERT [dbo].[WareHouses] ([Id], [wareHouseName], [Status]) VALUES (4, N'Soğuk Hava Depolarıı', 0)
INSERT [dbo].[WareHouses] ([Id], [wareHouseName], [Status]) VALUES (5, N'Soğuk Hava Depolar', 0)
INSERT [dbo].[WareHouses] ([Id], [wareHouseName], [Status]) VALUES (6, N'Soğuk Hava Depolar', 0)
INSERT [dbo].[WareHouses] ([Id], [wareHouseName], [Status]) VALUES (7, N'Soğuk Hava Depolar', 0)
INSERT [dbo].[WareHouses] ([Id], [wareHouseName], [Status]) VALUES (8, N'Açık  Hava Depolar', 1)
INSERT [dbo].[WareHouses] ([Id], [wareHouseName], [Status]) VALUES (9, N'Kapalı Hava Depoları', 1)
INSERT [dbo].[WareHouses] ([Id], [wareHouseName], [Status]) VALUES (10, N'Geleneksel Depolar', 1)
SET IDENTITY_INSERT [dbo].[WareHouses] OFF
ALTER TABLE [dbo].[Inventories]  WITH CHECK ADD  CONSTRAINT [FK_Inventories_WareHouses_WarehouseId] FOREIGN KEY([WarehouseId])
REFERENCES [dbo].[WareHouses] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inventories] CHECK CONSTRAINT [FK_Inventories_WareHouses_WarehouseId]
GO
