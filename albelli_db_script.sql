USE [master]
GO
/****** Object:  Database [albelli]    Script Date: 3/21/2022 1:07:08 AM ******/
CREATE DATABASE [albelli]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'albelli', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\albelli.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'albelli_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\albelli_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [albelli] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [albelli].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [albelli] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [albelli] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [albelli] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [albelli] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [albelli] SET ARITHABORT OFF 
GO
ALTER DATABASE [albelli] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [albelli] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [albelli] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [albelli] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [albelli] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [albelli] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [albelli] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [albelli] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [albelli] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [albelli] SET  ENABLE_BROKER 
GO
ALTER DATABASE [albelli] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [albelli] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [albelli] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [albelli] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [albelli] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [albelli] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [albelli] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [albelli] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [albelli] SET  MULTI_USER 
GO
ALTER DATABASE [albelli] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [albelli] SET DB_CHAINING OFF 
GO
ALTER DATABASE [albelli] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [albelli] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [albelli] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [albelli] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [albelli] SET QUERY_STORE = OFF
GO
USE [albelli]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/21/2022 1:07:08 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Products]    Script Date: 3/21/2022 1:07:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Order_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderInfomation]    Script Date: 3/21/2022 1:07:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderInfomation](
	[OrderId] [int] NOT NULL,
 CONSTRAINT [PK_OrderInfomation] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProdcutTypes]    Script Date: 3/21/2022 1:07:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProdcutTypes](
	[ProdcutId] [int] IDENTITY(1,1) NOT NULL,
	[ProdcutName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ProdcutTypes] PRIMARY KEY CLUSTERED 
(
	[ProdcutId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220320044616_InitialMigration', N'6.0.3')
GO
SET IDENTITY_INSERT [dbo].[Order_Products] ON 
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (1, 355, 1, 2)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (2, 355, 4, 2)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (3, 355, 3, 4)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (4, 355, 2, 3)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (5, 355, 5, 3)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (6, 210, 1, 2)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (7, 210, 3, 4)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (8, 210, 2, 3)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (9, 210, 5, 2)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (10, 313, 1, 1)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (11, 313, 2, 2)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (12, 313, 5, 1)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (13, 314, 1, 1)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (14, 314, 2, 2)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (15, 314, 5, 4)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (16, 315, 1, 1)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (17, 315, 2, 2)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (18, 315, 5, 5)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (19, 316, 1, 1)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (20, 316, 2, 2)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (21, 316, 5, 5)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (22, 316, 4, 5)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (1002, 414, 1, 1)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (1003, 414, 2, 2)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (1004, 414, 5, 5)
GO
INSERT [dbo].[Order_Products] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (1005, 414, 4, 5)
GO
SET IDENTITY_INSERT [dbo].[Order_Products] OFF
GO
INSERT [dbo].[OrderInfomation] ([OrderId]) VALUES (210)
GO
INSERT [dbo].[OrderInfomation] ([OrderId]) VALUES (313)
GO
INSERT [dbo].[OrderInfomation] ([OrderId]) VALUES (314)
GO
INSERT [dbo].[OrderInfomation] ([OrderId]) VALUES (315)
GO
INSERT [dbo].[OrderInfomation] ([OrderId]) VALUES (316)
GO
INSERT [dbo].[OrderInfomation] ([OrderId]) VALUES (355)
GO
INSERT [dbo].[OrderInfomation] ([OrderId]) VALUES (414)
GO
SET IDENTITY_INSERT [dbo].[ProdcutTypes] ON 
GO
INSERT [dbo].[ProdcutTypes] ([ProdcutId], [ProdcutName]) VALUES (1, N'Photo Book')
GO
INSERT [dbo].[ProdcutTypes] ([ProdcutId], [ProdcutName]) VALUES (2, N'Calendar')
GO
INSERT [dbo].[ProdcutTypes] ([ProdcutId], [ProdcutName]) VALUES (3, N'')
GO
INSERT [dbo].[ProdcutTypes] ([ProdcutId], [ProdcutName]) VALUES (4, N'Cards')
GO
INSERT [dbo].[ProdcutTypes] ([ProdcutId], [ProdcutName]) VALUES (5, N'Mug')
GO
SET IDENTITY_INSERT [dbo].[ProdcutTypes] OFF
GO
/****** Object:  Index [IX_Order_Products_OrderId]    Script Date: 3/21/2022 1:07:08 AM ******/
CREATE NONCLUSTERED INDEX [IX_Order_Products_OrderId] ON [dbo].[Order_Products]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Order_Products_ProductId]    Script Date: 3/21/2022 1:07:08 AM ******/
CREATE NONCLUSTERED INDEX [IX_Order_Products_ProductId] ON [dbo].[Order_Products]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Order_Products]  WITH CHECK ADD  CONSTRAINT [FK_Order_Products_OrderInfomation_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[OrderInfomation] ([OrderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order_Products] CHECK CONSTRAINT [FK_Order_Products_OrderInfomation_OrderId]
GO
ALTER TABLE [dbo].[Order_Products]  WITH CHECK ADD  CONSTRAINT [FK_Order_Products_ProdcutTypes_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[ProdcutTypes] ([ProdcutId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order_Products] CHECK CONSTRAINT [FK_Order_Products_ProdcutTypes_ProductId]
GO
USE [master]
GO
ALTER DATABASE [albelli] SET  READ_WRITE 
GO
