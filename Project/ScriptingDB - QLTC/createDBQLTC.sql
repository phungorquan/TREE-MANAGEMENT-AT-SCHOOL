USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLCayCanh')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLCayCanh') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLCayCanh]
END
GO


CREATE DATABASE [QLCayCanh]
GO
USE [QLCayCanh]
GO

CREATE TABLE [dbo].[tblCayCanh](
	[maCay] [nvarchar](8) NOT NULL,
	[tenCay] [nvarchar](50) NOT NULL,
	[maloaicay] [int] NOT NULL,
	[ngayTrong] [datetime2] NOT NULL,
	[mavitri] [int] NOT NULL,
	[tinhTrang] [int] NOT NULL,
 CONSTRAINT [PK_tblKieuNau] PRIMARY KEY CLUSTERED 
(
	[maCay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLCayCanh]
GO
CREATE TABLE [dbo].[VITRI](
	[mavitri] [int] NOT NULL,
	[tenvitri] [nvarchar](50) NOT NULL,
      [soluong] int NOT NULL,
 CONSTRAINT [PK_VITRI] PRIMARY KEY CLUSTERED 
(
	[mavitri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLCayCanh]
GO
CREATE TABLE [dbo].[TINHTRANG](
	[matinhtrang] [int] NOT NULL,
	[tentinhtrang] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TINHTRANG] PRIMARY KEY CLUSTERED 
(
	[matinhtrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLCayCanh]
GO
CREATE TABLE [dbo].[THAMSO](
	[SoLuongCayCanhToiDa] [int] NOT NULL,
	[SoTienMuaToiDa] [int] NOT NULL
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[TINHTRANGCAYCANH](
	[matinhtrangthang] [nvarchar](8) NOT NULL,
	[thangtt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TINHTRANGCAYCANH] PRIMARY KEY CLUSTERED 
(
	[matinhtrangthang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLCayCanh]
GO

CREATE TABLE [dbo].[LOAICAY](
	[maloaicay] [int] NOT NULL,
	[tenloaicay] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LOAICAY] PRIMARY KEY CLUSTERED 
(
	[maloaicay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO










USE [QLCayCanh]
GO
CREATE TABLE [dbo].[VATTU](
	[mavattu] [int] NOT NULL,
	[tenvattu] [nvarchar](50) NOT NULL,
	[diachiban] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_VATTU] PRIMARY KEY CLUSTERED 
(
	[mavattu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [QLCayCanh]
GO

CREATE TABLE [dbo].[GIAVATTU](
	[magiavattu] [int] NOT NULL,
	[giavattu] [int] NOT NULL,
	[mavattu] [int] NOT NULL,
 CONSTRAINT [PK_GIAVATTU] PRIMARY KEY CLUSTERED 
(
	[magiavattu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLCayCanh]
GO
CREATE TABLE [dbo].[DONVITINH](
	[madonvitinh] [int] NOT NULL,
	[tendonvitinh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DONVITINH] PRIMARY KEY CLUSTERED 
(
	[madonvitinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLCayCanh]
GO
CREATE TABLE [dbo].[PHIEUMUAVATTU](
	[maphieumua] [nvarchar](8) NOT NULL,
	[mavattu] [int] NOT NULL,
	[madonvitinh] [int] NOT NULL,
	[diachimua] [nvarchar](50) NOT NULL,
	[soluong] [int] NOT NULL,
	[sotien] [int] NOT NULL,
	[ngaymua] [datetime2] NOT NULL,
 CONSTRAINT [PK_PHIEUMUAVATTU] PRIMARY KEY CLUSTERED 
(
	[maphieumua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO




USE [QLCayCanh]
GO
CREATE TABLE [dbo].[CHIPHICHAMSOCTHANG](
	[machiphithang] [nvarchar](8) NOT NULL,
	[thang] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_CHIPHICHAMSOCTHANG] PRIMARY KEY CLUSTERED 
(
	[machiphithang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLCayCanh]
GO
CREATE TABLE [dbo].[CTCHIPHICHAMSOCTHANG](
	[mactchiphithang] [nvarchar](8) NOT NULL,
	[machiphithang] [nvarchar](8) NOT NULL,
	[mavattu] [int] NOT NULL,
	[sophieumua] [int] NOT NULL,
	[tongtrigia] [int] NOT NULL,
	[tyle] [double] NOT NULL,
 CONSTRAINT [PK_CTCHIPHICHAMSOCTHANG] PRIMARY KEY CLUSTERED 
(
	[mactchiphithang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [QLCayCanh]
GO

USE [QLCayCanh]
GO
CREATE TABLE [dbo].[CTTINHTRANGCAYCANH](
	[macttinhtrangcay] [nvarchar](8) NOT NULL,
	[matinhtrangthang] [nvarchar](8) NOT NULL,
	[macay] [nvarchar](8) NOT NULL,
	[maloaicay] [int] NOT NULL,
	[matinhtrang] [int] NOT NULL,
 CONSTRAINT [PK_CTTINHTRANGCAYCANH] PRIMARY KEY CLUSTERED 
(
	[macttinhtrangcay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [QLCayCanh]
GO
CREATE TABLE [dbo].[LICHCHAMSOC](
	[machamsoc] [nvarchar](8) NOT NULL,
	[thoigian] [BIGINT] NOT NULL,
	[mavattu] [int] NOT NULL,
	[madonvitinh] [int] NOT NULL,
	[soluong] [int] NOT NULL,
	[ghichu] [nvarchar](50) NOT NULL,
	[macay] [nvarchar](8) NOT NULL,
	[ngaylaplich] [date] NOT NULL,

 CONSTRAINT [PK_LICHCHAMSOC] PRIMARY KEY CLUSTERED 
(
	[machamsoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/**************Them vao database******************/
USE [QLCayCanh]
GO

INSERT INTO [dbo].[LOAICAY]
           ([maloaicay]
           ,[tenloaicay])
     VALUES
           (1
           ,N'Cần Ánh Sáng')
GO

USE [QLCayCanh]
GO

INSERT INTO [dbo].[LOAICAY]
           ([maloaicay]
           ,[tenloaicay])
     VALUES
           (2
           ,N'Bóng Râm')
GO

USE [QLCayCanh]
GO

INSERT INTO [dbo].[TINHTRANG]
           ([matinhtrang]
           ,[tentinhtrang])
     VALUES
           (1
           ,N'Đã Chăm Sóc')
GO

USE [QLCayCanh]
GO

INSERT INTO [dbo].[TINHTRANG]
           ([matinhtrang]
           ,[tentinhtrang])
     VALUES
           (2
           ,N'Chưa Được Chăm Sóc')
GO

USE [QLCayCanh]
GO

INSERT INTO [dbo].[DONVITINH]
           ([madonvitinh]
           ,[tendonvitinh])
     VALUES
           (1
           ,N'Lít')
GO

USE [QLCayCanh]
GO

INSERT INTO [dbo].[DONVITINH]
           ([madonvitinh]
           ,[tendonvitinh])
     VALUES
           (2
           ,N'Gam')
GO


USE [QLCayCanh]
GO

INSERT INTO [dbo].[THAMSO]
           ([SoLuongCayCanhToiDa]
           ,[SoTienMuaToiDa])
     VALUES
           (4,100000)
GO

USE [QLCayCanh]
GO

INSERT INTO [dbo].[VATTU]
           ([mavattu]
           ,[tenvattu]
           ,[diachiban])
     VALUES
           (1
           ,N'Nước','a')
GO

USE [QLCayCanh]
GO

INSERT INTO [dbo].[VATTU]
           ([mavattu]
           ,[tenvattu]
           ,[diachiban])
     VALUES
           (2
           ,N'Phân Đạm','b')
GO

USE [QLCayCanh]
GO

INSERT INTO [dbo].[GIAVATTU]
           ([magiavattu]
           ,[giavattu]
           ,[mavattu])
     VALUES
           (1,20000,1)
GO

USE [QLCayCanh]
GO

INSERT INTO [dbo].[GIAVATTU]
           ([magiavattu]
           ,[giavattu]
           ,[mavattu])
     VALUES
           (2,40000,2)
GO

USE [QLCayCanh]
GO

INSERT INTO [dbo].[VITRI]
           ([mavitri]
           ,[tenvitri]
           ,[soluong])
     VALUES
           (1
           ,N'Ban Công',0)
GO

USE [QLCayCanh]
GO

INSERT INTO [dbo].[VITRI]
           ([mavitri]
           ,[tenvitri]
           ,[soluong])
     VALUES
           (2
           ,N'Cửa Sổ',0)
GO

USE [QLCayCanh]
GO

INSERT INTO [dbo].[VITRI]
           ([mavitri]
           ,[tenvitri]
           ,[soluong])
     VALUES
           (3
           ,N'Trước Cổng',0)
GO



