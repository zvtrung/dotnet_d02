USE [BookMan]
GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 28-Mar-22 2:08:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[MaNhaXuatBan] [int] NOT NULL,
	[TenNhaXuatBan] [nvarchar](100) NULL,
 CONSTRAINT [PK_NhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[MaNhaXuatBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NhaXuatBan] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (1, N'Nhà xuất bản Kim Đồng')
GO
INSERT [dbo].[NhaXuatBan] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (2, N'Nhà xuất bản Trẻ 1235')
GO
INSERT [dbo].[NhaXuatBan] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (3, N'Nhà xuất bản Lao động')
GO
INSERT [dbo].[NhaXuatBan] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (4, N'Nhà xuất bản Thuận Hoá')
GO
INSERT [dbo].[NhaXuatBan] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (9, N'Nhà xuất bản Giáo dục')
GO
INSERT [dbo].[NhaXuatBan] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (99, N'Nhà xuất bản Kỹ thuật')
GO
/****** Object:  StoredProcedure [dbo].[spGetNhaXuatBanList]    Script Date: 28-Mar-22 2:08:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		trung nguyen
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[spGetNhaXuatBanList] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT MaNhaXuatBan, TenNhaXuatBan
	FROM NhaXuatBan
	ORDER BY TenNhaXuatBan
END
GO
