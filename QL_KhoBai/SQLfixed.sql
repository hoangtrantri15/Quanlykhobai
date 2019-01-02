-- Create a new database called 'DatabaseName'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
	SELECT name
		FROM sys.databases
		WHERE name = N'QLKHOBAI'
)
CREATE DATABASE QLKHOBAI
GO
USE QLKHOBAI
GO
CREATE TABLE KHACHHANG
(
	MAKHACHHANG CHAR(2) PRIMARY KEY,
	TENKHACHHANG NVARCHAR(60),
	SOCMND NVARCHAR(15),
	SODT NVARCHAR(15),
	CONGNO INT,
)
GO
CREATE TABLE KHUVUC
(
	MAKHUVUC NVARCHAR(5) PRIMARY KEY,
	TENQUANHUYEN NVARCHAR(50),
	TENPHUONGXA NVARCHAR(50),
)
GO
CREATE TABLE KHOBAI
(
	MAKHO CHAR(5) PRIMARY KEY,
	TENKHO NVARCHAR(50),
	DIACHIKHO NVARCHAR(100),
	MAKHUVUC NVARCHAR(5),
	FOREIGN KEY(MAKHUVUC) references KHUVUC(MAKHUVUC),
	DONGIA1M3NGAY BIGINT,
)
GO
CREATE TABLE HOPDONG
(
	SOHD INT PRIMARY KEY,
	NGAYKYHD DATE,
	NGAYBDT DATE,
	TONGM3 BIGINT,
	MAKHACHTHUE CHAR(2),
	FOREIGN KEY(MAKHACHTHUE) references KHACHHANG(MAKHACHHANG),
---NHÂP LIỆU
)
GO
CREATE TABLE CHITIETHOPDONG
(
	STTCHITIET INT IDENTITY(1,1) PRIMARY KEY,
	SOHD INT,
	MAKHO CHAR(5),
	NGAYKETTHUC DATE ,
	foreign key(SOHD) references HOPDONG(SOHD),
	foreign key(MAKHO) references KHOBAI(MAKHO),
)
GO
CREATE TABLE THANHTOAN
(
	SOPHIEU INT IDENTITY(1, 1) PRIMARY KEY,
	NGAYLAPPHIEU DATE,
	SOTIENTHU BIGINT,
	STTCHITIET INT,
	FOREIGN KEY(STTCHITIET) references CHITIETHOPDONG(STTCHITIET),
)

CREATE TABLE ACCOUNT
(
	id INT IDENTITY,
	usernameAcc VARCHAR(50) NOT NULL,
	nameDisplay VARCHAR(50) NOT NULL,
	passwordAcc VARCHAR(10) NOT NULL,
	typeAcc INT NOT NULL DEFAULT 1,
	PRIMARY KEY(usernameAcc)
)
GO 


GO
SELECT * FROM KHACHHANG
INSERT KHACHHANG VALUES ('M1', N'THIẾT PHIẾN CÔNG CHÚA', N'3290123', N'09090988', 1000)
INSERT KHACHHANG VALUES ('M2', N'NGƯU MA VƯƠNG(CON TRÂU NGU NGỐC)', N'3290324', N'09090999', 8000)
GO
INSERT KHUVUC VALUES (N'KV1', N'ABC', N'XYZ')
INSERT KHUVUC VALUES (N'KV2', N'QUẬN CAM', N'ABC')
SELECT * FROM KHUVUC
GO
INSERT KHOBAI VALUES ('KHO81', N'KHO 81', N'QUẬN CAM', N'KV2', 10000)
INSERT KHOBAI VALUES ('KHO69', N'KHO 69', N'ABC', N'KV1', 5000)
SELECT * FROM KHOBAI
GO
INSERT HOPDONG VALUES (1, '12/23/2018', '01/02/2019', '15', 'M2')
INSERT HOPDONG VALUES (2, '12/23/2018', '01/21/2019', '10', 'M2')
SELECT * FROM HOPDONG
GO
INSERT CHITIETHOPDONG VALUES (2, 'KHO69', '05/20/2019')
INSERT CHITIETHOPDONG VALUES (1, 'KHO81', '06/20/2020')
SELECT * FROM CHITIETHOPDONG
GO
INSERT THANHTOAN VALUES (GETDATE(), 25000, 2)
INSERT THANHTOAN VALUES (GETDATE(), 30000, 1)
SELECT * FROM THANHTOAN
GO

INSERT dbo.ACCOUNT VALUES ('admin', 'admin', '123456', 1)
INSERT dbo.ACCOUNT VALUES ('star', 'star', '654321', 0)
--SHOW TABLE KHACHHANG
Select * from KHACHHANG
--Khách Hàng
	-- Thêm Khách Hàng
	Create PROC USP_InsertKhachHang (@maKhachHang VARCHAR(10), @tenKhachHang NVARCHAR(100), @soCMND NVARCHAR(10),@soDT NVARCHAR(10), @congNo INT)
	AS
    BEGIN
		INSERT dbo.KHACHHANG (MAKHACHHANG, TENKHACHHANG, SOCMND,SODT, CONGNO) 
		VALUES (@maKhachHang, @tenKhachHang, @soCMND, @soDt, @congNo)
	END
	GO
	-- Sửa Khách hàng
	CREATE PROC USP_UpdateKhachHang (@maKhachHang VARCHAR(10), @tenKhachHang NVARCHAR(100), @soCMND NVARCHAR(10),@soDT NVARCHAR(10), @congNo FLOAT)
	AS
    BEGIN
		UPDATE dbo.KHACHHANG SET tenKhachHang = @tenKhachHang, SOCMND=@soCMND, SODT=@soDT, CONGNO=@congNo WHERE maKhachHang = @maKhachHang
	END
    GO

	-- Xóa Khách Hàng
	CREATE PROC USP_DeleteKhachHang (@maKhachHang VARCHAR(10))
	AS
    BEGIN
        DELETE dbo.KHACHHANG WHERE maKhachHang = @maKhachHang
    END
	GO
--HỢP ĐỒNG
	--SHOW TABLE
Select * from HOPDONG
	--Thêm hợp đồng
	Create PROC USP_InsertHopDong (@soHD VARCHAR(10), @ngayKyHD date, @NgayBDT date,@tongM3 float, @maKhachThue nvarchar(10))
	AS
    BEGIN
		INSERT dbo.HOPDONG(SOHD,NGAYKYHD,NGAYBDT,TONGM3,MAKHACHTHUE) 
		VALUES (@soHD, @ngayKyHD, @NgayBDT,@tongM3, @maKhachThue)
	END
	GO
	--SỬA HỢP ĐỒNG
	CREATE PROC USP_UpdateHopDong (@soHD VARCHAR(10), @ngayKyHD date, @ngayBDT date,@tongM3 float, @maKhachThue nvarchar(10))
	AS
    BEGIN
		UPDATE dbo.HOPDONG SET NGAYKYHD = @ngayKyHD, NGAYBDT = @ngayBDT, TONGM3= @tongM3, MAKHACHTHUE=@maKhachThue WHERE SOHD = @soHD
	END
    GO
	--XÓA HỢP ĐỒNG
	CREATE PROC USP_DeleteHopDong(@soHD VARCHAR(10))
	AS
    BEGIN
        DELETE dbo.HOPDONG WHERE SOHD = @soHD
    END
	GO
	---KHO BÃI
		--SHOW TALBE
		Select * from KHOBAI
		--THÊM KHO BÃI
	Create PROC USP_InsertKhoBai (@maKho VARCHAR(10), @tenKho nvarchar(100), @diaChiKho nvarchar(100),@maKhuVuc nvarchar(10), @dongGia1m3Ngay float)
	AS
    BEGIN
		INSERT dbo.KHOBAI(MAKHO,TENKHO,DIACHIKHO,MAKHUVUC,DONGIA1M3NGAY) 
		VALUES (@maKho,@tenKho,@diaChiKho,@maKhuVuc,@dongGia1m3Ngay)
	END
	GO
		--SỮA THÔNG TIN KHO BÃI
			CREATE PROC USP_UpdateKhoBai (@maKho VARCHAR(10), @tenKho nvarchar(100), @diaChiKho nvarchar(100),@maKhuVuc nvarchar(10), @dongGia1m3Ngay float)
	AS
    BEGIN
		UPDATE dbo.KHOBAI SET TENKHO= @tenKho,DIACHIKHO=@diaChiKho,MAKHUVUC=@maKhuVuc,DONGIA1M3NGAY=@dongGia1m3Ngay WHERE MAKHO = @maKho
	END
    GO
		--XÓA KHO BÃI
		CREATE PROC USP_DeleteKhoBai(@maKho VARCHAR(10))
	AS
    BEGIN
        DELETE dbo.KHOBAI WHERE MAKHO = @maKho
    END
	GO
	---CHI TIẾT HỢP ĐỒNG
	--SHOW TABLE
	Select * from CHITIETHOPDONG
	--THÊM CTHĐ
	Create PROC USP_InsertChiTietHopDong (@soHD nvarchar(10), @maKho nvarchar(10), @ngayKetThuc date)
	AS
    BEGIN
		INSERT dbo.CHITIETHOPDONG(SOHD,MAKHO,NGAYKETTHUC) 
		VALUES (@soHD,@maKho,@ngayKetThuc)
	END
	GO
	--SỮA CTHĐ
			CREATE PROC USP_UpdateChiTietHopDing (@soHD nvarchar(10), @maKho nvarchar(10), @ngayKetThuc date)
	AS
    BEGIN
		UPDATE dbo.CHITIETHOPDONG SET MAKHO=@maKho, NGAYKETTHUC=@ngayKetThuc where SOHD = @soHD
	END
    GO
	--XÓA CTHĐ
		CREATE PROC USP_DeleteChiTietHopDong(@soHD nvarchar(10))
	AS
    BEGIN
        DELETE dbo.CHITIETHOPDONG WHERE SOHD = @soHD
    END
	GO

	---KHU VỰC
	 --SHOW TABLE
	 Select * from KHUVUC
	 --THÊM KHU VUC
	 Create PROC USP_InsertKhuVuc (@maKhuVuc nvarchar(10), @tenQuanHuyen nvarchar(100), @tenPhuongXa nvarchar(100))
	AS
    BEGIN
		INSERT dbo.KHUVUC(MAKHUVUC,TENQUANHUYEN,TENPHUONGXA) 
		VALUES (@maKhuVuc,@tenQuanHuyen,@tenPhuongXa)
	END
	GO
	 --SỮA KHU VỰC
	 		CREATE PROC USP_UpdateKhuVuc (@maKhuVuc nvarchar(10), @tenQuanHuyen nvarchar(100), @tenPhuongXa nvarchar(100))
	AS
    BEGIN
		UPDATE dbo.KHUVUC SET TENQUANHUYEN=@tenQuanHuyen,TENPHUONGXA=@tenPhuongXa where MAKHUVUC = @maKhuVuc
	END
    GO
	 --XÓA KHU VỰC
	 	CREATE PROC USP_DeleteKhuVuc(@maKhuVuc nvarchar(10))
	AS
    BEGIN
        DELETE dbo.KHUVUC WHERE MAKHUVUC=@maKhuVuc
    END
	GO

	---THANH TOÁN
	 --TABLE
	 Select * from THANHTOAN 
	 --THÊM
	  Create PROC USP_InsertThanhToan (@ngayLapPhieu date,@soTienThu bigint,@sttChiTiet nvarchar(10))
	AS
    BEGIN
		INSERT dbo.THANHTOAN(NGAYLAPPHIEU,SOTIENTHU,STTCHITIET) 
		VALUES (@ngayLapPhieu,@soTienThu,@sttChiTiet)
	END
	GO
	 --SỬA
	 	CREATE PROC USP_UpdateThanhToan (@ngayLapPhieu date,@soTienThu bigint,@sttChiTiet nvarchar(10))
	AS
    BEGIN
		UPDATE dbo.THANHTOAN SET SOTIENTHU=@soTienThu,STTCHITIET=@sttChiTiet where NGAYLAPPHIEU = @ngayLapPhieu
	END
    GO
	 --XÓA
	 	CREATE PROC USP_DeleteThanhToan(@ngayLapPhieu date)
	AS
    BEGIN
        DELETE dbo.THANHTOAN WHERE NGAYLAPPHIEU=@ngayLapPhieu
    END
	GO
