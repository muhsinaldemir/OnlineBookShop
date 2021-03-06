/****** Object:  Database [bookshop]    Script Date: 5/28/2019 6:19:16 PM ******/
CREATE DATABASE [bookshop]  (EDITION = 'Standard', SERVICE_OBJECTIVE = 'S0', MAXSIZE = 250 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS;
GO
ALTER DATABASE [bookshop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bookshop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bookshop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bookshop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bookshop] SET ARITHABORT OFF 
GO
ALTER DATABASE [bookshop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bookshop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bookshop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bookshop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bookshop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bookshop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bookshop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bookshop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bookshop] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [bookshop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bookshop] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [bookshop] SET  MULTI_USER 
GO
ALTER DATABASE [bookshop] SET ENCRYPTION ON
GO
ALTER DATABASE [bookshop] SET QUERY_STORE = ON
GO
ALTER DATABASE [bookshop] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO)
GO
/****** Object:  Table [dbo].[BookTable]    Script Date: 5/28/2019 6:19:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[price] [float] NULL,
	[stock] [int] NULL,
	[isbn] [nvarchar](50) NULL,
	[author] [nvarchar](50) NULL,
	[publisher] [nvarchar](50) NULL,
	[page] [int] NULL,
	[cover_page_picture] [nvarchar](50) NULL,
 CONSTRAINT [PK_BookTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerTable]    Script Date: 5/28/2019 6:19:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[address] [nvarchar](250) NULL,
	[email] [nvarchar](50) NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[isadmin] [bit] NOT NULL,
	[isconfirmed] [bit] NULL,
 CONSTRAINT [PK_CustomerTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MagazineTable]    Script Date: 5/28/2019 6:19:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MagazineTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[price] [float] NULL,
	[stock] [int] NULL,
	[issue] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[cover_page_picture] [nvarchar](50) NULL,
 CONSTRAINT [PK_MagazineTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusicCDsTable]    Script Date: 5/28/2019 6:19:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusicCDsTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[price] [float] NULL,
	[stock] [int] NULL,
	[singer] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[picture] [nvarchar](50) NULL,
 CONSTRAINT [PK_MusicCDsTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShoppingCartTable]    Script Date: 5/28/2019 6:19:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoppingCartTable](
	[id] [int] NULL,
	[customerid] [int] NULL,
	[itemid] [int] NULL,
	[name] [nvarchar](50) NULL,
	[itemtype] [nvarchar](50) NULL,
	[quantity] [int] NULL,
	[paymentamount] [float] NULL,
	[paymenttype] [nvarchar](50) NULL,
	[picture] [nvarchar](50) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CustomerTable] ADD  CONSTRAINT [DF_CustomerTable_isconfirmed]  DEFAULT ((0)) FOR [isconfirmed]
GO
ALTER DATABASE [bookshop] SET  READ_WRITE 
GO
