USE [QuanLyCuaHang]
GO
/****** Object:  Table [dbo].[LOAI]    Script Date: 07/02/2016 01:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAI](
	[MALOAI] [nvarchar](10) NOT NULL,
	[TENLOAI] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LOAI] ([MALOAI], [TENLOAI]) VALUES (N'DESKTOP', N'Máy tính bàn')
INSERT [dbo].[LOAI] ([MALOAI], [TENLOAI]) VALUES (N'DTDD', N'Điện thoại di động')
INSERT [dbo].[LOAI] ([MALOAI], [TENLOAI]) VALUES (N'LAPTOP', N'Máy tính xách tay')
INSERT [dbo].[LOAI] ([MALOAI], [TENLOAI]) VALUES (N'MTB', N'Máy tính bảng')
INSERT [dbo].[LOAI] ([MALOAI], [TENLOAI]) VALUES (N'PK', N'Phụ kiện')
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 07/02/2016 01:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [nvarchar](15) NOT NULL,
	[TENKH] [nvarchar](30) NULL,
	[NGAYSINH] [smalldatetime] NULL,
	[DIACHI] [nvarchar](50) NULL,
	[SDT] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [DIACHI], [SDT]) VALUES (N'KH00001', N'Nguyễn Thành Nhân', CAST(0x8A260000 AS SmallDateTime), N'TP.HCM', N'01233334325')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [DIACHI], [SDT]) VALUES (N'KH00002', N'Phạm Thành Chung', CAST(0x80F40000 AS SmallDateTime), N'Tiền Giang', N'0979989985')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [DIACHI], [SDT]) VALUES (N'KH00003', N'Trần Lê Hữu Phúc', CAST(0x8C9C0000 AS SmallDateTime), N'Tây Ninh', N'01684523566')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [DIACHI], [SDT]) VALUES (N'KH00004', N'Lê Hoàng Mỹ', CAST(0x8A2A0000 AS SmallDateTime), N'TP.HCM', N'01645455554')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [DIACHI], [SDT]) VALUES (N'KH00005', N'Nguyễn Thị Kim Quý', CAST(0x89850000 AS SmallDateTime), N'Tiền Giang', N'0964435344')
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 07/02/2016 01:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASP] [nvarchar](15) NOT NULL,
	[MALOAI] [nvarchar](10) NULL,
	[TENSP] [nvarchar](40) NULL,
	[NOIDUNG] [nvarchar](255) NULL,
	[HANGSX] [nvarchar](50) NULL,
	[NGAYDANG] [smalldatetime] NULL,
	[TRANGTHAI] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [TENSP], [NOIDUNG], [HANGSX], [NGAYDANG], [TRANGTHAI]) VALUES (N'HP8470P', N'LAPTOP', N'HP 8470P', N'Với phiên bản HP EliteBook 8470p tích hợp con chip được mong đợi nhất, Intel Ivy Bridge, HP một lần nữa khiến giới công nghệ phải chú ý.', N'HP', CAST(0xA6370000 AS SmallDateTime), N'Còn hàng')
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [TENSP], [NOIDUNG], [HANGSX], [NGAYDANG], [TRANGTHAI]) VALUES (N'IPADAIR', N'MTB', N'iPad Air', N'iPad Air 16GB Wifi Cellular có camera 5 MP và được trang bị cảm biến BSI cho khả năng chụp ảnh thiếu sáng hiệu quả hơn.', N'APPLE', CAST(0xA6370000 AS SmallDateTime), N'Còn hàng')
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [TENSP], [NOIDUNG], [HANGSX], [NGAYDANG], [TRANGTHAI]) VALUES (N'IPADAIR2', N'MTB', N'iPad Air 2', N'Máy tính bảng iPad Air 2 siêu phẩm mới nhất của nhà sản xuất Apple. iPad Air 2 sở hữu một thiết kế cao cấp với độ mỏng 6,1 mm, cấu hình cao chạy hệ điều IOS 9 mới nhất.', N'APPLE', CAST(0xA6370000 AS SmallDateTime), N'Còn hàng')
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [TENSP], [NOIDUNG], [HANGSX], [NGAYDANG], [TRANGTHAI]) VALUES (N'IPHONE5', N'DTDD', N'iPhone 5', N'Nếu là một tín đồ của Apple thì iPhone 5 là sản phẩm mà bạn không thể bỏ qua, đây cũng là chiếc điện thoại thông minh tốt nhất phổ biến nhất trên thị trường.', N'APPLE', CAST(0xA6370000 AS SmallDateTime), N'Còn hàng')
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [TENSP], [NOIDUNG], [HANGSX], [NGAYDANG], [TRANGTHAI]) VALUES (N'IPHONE5S', N'DTDD', N'iPhone 5S', N'iPhone 5s 16GB được trang bị màn hình 4.0 inch với độ phân giải cao. Máy chạy trên nên iOS 9 mới nhất. 5S sở hữu camera 8 MP với 2 đèn led flash.', N'APPLE', CAST(0xA6370000 AS SmallDateTime), N'Còn hàng')
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [TENSP], [NOIDUNG], [HANGSX], [NGAYDANG], [TRANGTHAI]) VALUES (N'IPHONE6', N'DTDD', N'iPhone 6', N'iPhone 6 ra mắt với sự thay đổi lớn về mặt thiết kế và cấu hình so với các thế hệ trước. iPhone 6 có màn hình lớn đến 4,7 inch và Camera chống rung quang học OIS.', N'APPLE', CAST(0xA6370000 AS SmallDateTime), N'Còn hàng')
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [TENSP], [NOIDUNG], [HANGSX], [NGAYDANG], [TRANGTHAI]) VALUES (N'IPHONE6P', N'DTDD', N'iPhone 6 Plus', N'iPhone 6 plus phiên bản cỡ lớn của iPhone 6 cùng nhiều tính năng vượt trội. iPhone 6 plus sử dụng hệ điều hành iOS 8, màn hình 5.5 inch, pin khủng.', N'APPLE', CAST(0xA6370000 AS SmallDateTime), N'Còn hàng')
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [TENSP], [NOIDUNG], [HANGSX], [NGAYDANG], [TRANGTHAI]) VALUES (N'NOTE4', N'DTDD', N'Samsung Galaxy Note 4', N'SAMSUNG Galaxy Note4 sở hữu màn hình 5.7 inch Super AMOLED QuadHD 2K cho trải nghiệm hình ảnh sống động.', N'SAMSUNG', CAST(0xA6370000 AS SmallDateTime), N'Còn hàng')
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [TENSP], [NOIDUNG], [HANGSX], [NGAYDANG], [TRANGTHAI]) VALUES (N'NOTE5', N'DTDD', N'Samsung Galaxt Note 5', N'Samsung Galaxy Note 5 CPU Exynos 7 Octa core Ram 4GB màn hình 5.7 inch độ phân giải 2K camera 16MP.', N'SAMSUNG', CAST(0xA6370000 AS SmallDateTime), N'Còn hàng')
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [TENSP], [NOIDUNG], [HANGSX], [NGAYDANG], [TRANGTHAI]) VALUES (N'SSS6', N'DTDD', N'Samsung Galaxy S6', N'Samsung Galaxy S6 điện thoại cao cấp dòng S thiết kế từ kính và nhôm.', N'SAMSUNG', CAST(0xA6370000 AS SmallDateTime), N'Còn hàng')
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [TENSP], [NOIDUNG], [HANGSX], [NGAYDANG], [TRANGTHAI]) VALUES (N'XPS13', N'LAPTOP', N'DELL XPS 13', N'Dell XPS 13 là phiên bản mới nhất trong dòng máy tính giải trí di động XPS được giới thiệu lần đầu tiên tại triển lãm CES 2015 vừa qua.', N'DELL', CAST(0xA6370000 AS SmallDateTime), N'Còn hàng')
/****** Object:  Table [dbo].[HOADON]    Script Date: 07/02/2016 01:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHD] [nvarchar](15) NOT NULL,
	[MAKH] [nvarchar](15) NULL,
	[NGAYLAP] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HOADON] ([MAHD], [MAKH], [NGAYLAP]) VALUES (N'HD000001', N'KH00001', CAST(0xA5960000 AS SmallDateTime))
INSERT [dbo].[HOADON] ([MAHD], [MAKH], [NGAYLAP]) VALUES (N'HD000002', N'KH00003', CAST(0xA5A10000 AS SmallDateTime))
INSERT [dbo].[HOADON] ([MAHD], [MAKH], [NGAYLAP]) VALUES (N'HD000003', N'KH00004', CAST(0xA60F0000 AS SmallDateTime))
INSERT [dbo].[HOADON] ([MAHD], [MAKH], [NGAYLAP]) VALUES (N'HD000004', N'KH00002', CAST(0xA5F80000 AS SmallDateTime))
INSERT [dbo].[HOADON] ([MAHD], [MAKH], [NGAYLAP]) VALUES (N'HD000005', N'KH00005', CAST(0xA5B40000 AS SmallDateTime))
/****** Object:  Table [dbo].[CHITIETHD]    Script Date: 07/02/2016 01:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHD](
	[MAHD] [nvarchar](15) NOT NULL,
	[MASP] [nvarchar](15) NOT NULL,
	[NGAYMUA] [smalldatetime] NULL,
	[NGAYGIAOHANG] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC,
	[MASP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETHD] ([MAHD], [MASP], [NGAYMUA], [NGAYGIAOHANG]) VALUES (N'HD000001', N'IPHONE5S', CAST(0xA58F0000 AS SmallDateTime), CAST(0xA58F0000 AS SmallDateTime))
INSERT [dbo].[CHITIETHD] ([MAHD], [MASP], [NGAYMUA], [NGAYGIAOHANG]) VALUES (N'HD000002', N'IPADAIR', CAST(0xA5AA0000 AS SmallDateTime), CAST(0xA5AA0000 AS SmallDateTime))
INSERT [dbo].[CHITIETHD] ([MAHD], [MASP], [NGAYMUA], [NGAYGIAOHANG]) VALUES (N'HD000003', N'NOTE4', CAST(0xA5DF0000 AS SmallDateTime), CAST(0xA5DF0000 AS SmallDateTime))
INSERT [dbo].[CHITIETHD] ([MAHD], [MASP], [NGAYMUA], [NGAYGIAOHANG]) VALUES (N'HD000004', N'SSS6', CAST(0xA60D0000 AS SmallDateTime), CAST(0xA60D0000 AS SmallDateTime))
INSERT [dbo].[CHITIETHD] ([MAHD], [MASP], [NGAYMUA], [NGAYGIAOHANG]) VALUES (N'HD000005', N'XPS13', CAST(0xA5D30000 AS SmallDateTime), CAST(0xA5D30000 AS SmallDateTime))
/****** Object:  ForeignKey [FK_CHITIETMUON_HOADONMUON]    Script Date: 07/02/2016 01:16:25 ******/
ALTER TABLE [dbo].[CHITIETHD]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETMUON_HOADONMUON] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HOADON] ([MAHD])
GO
ALTER TABLE [dbo].[CHITIETHD] CHECK CONSTRAINT [FK_CHITIETMUON_HOADONMUON]
GO
/****** Object:  ForeignKey [FK_CHITIETMUON_SACH]    Script Date: 07/02/2016 01:16:25 ******/
ALTER TABLE [dbo].[CHITIETHD]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETMUON_SACH] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CHITIETHD] CHECK CONSTRAINT [FK_CHITIETMUON_SACH]
GO
/****** Object:  ForeignKey [FK_HOADONMUON_KHACHHANG]    Script Date: 07/02/2016 01:16:25 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADONMUON_KHACHHANG] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADONMUON_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_SACH_THELOAI]    Script Date: 07/02/2016 01:16:25 ******/
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SACH_THELOAI] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAI] ([MALOAI])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SACH_THELOAI]
GO
