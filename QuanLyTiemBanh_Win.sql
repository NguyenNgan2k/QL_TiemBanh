	USE master
	GO
	CREATE DATABASE QLTiemBanh
	GO
	USE QLTiemBanh
	GO
	CREATE TABLE TaiKhoan
	(
		tenTK varchar(30) NOT NULL PRIMARY KEY,
		matKhau varchar(8) NOT NULL,
		hoTen nvarchar(30),
		dienThoai varchar(12)
	)
	GO
	INSERT INTO TaiKhoan
	VALUES
	('nguyenngan','12345678',N'Nguyễn Thị Ngân','0869133678'),
	('lananh','23456789',N'Trần Lan Anh','09331333687')
	go
	INSERT INTO TaiKhoan
	VALUES
	('Admin','123',N'Nguyễn A','123456789012')
	go
	CREATE TABLE PhieuNhap
	(
		maPN varchar(20) NOT NULL PRIMARY KEY,
		nhaCC nvarchar(50),
		ngayLap datetime
	)
	GO
	INSERT INTO PhieuNhap
	VALUES
	('PN001',N'Hồng Hà',CAST(N'2021-11-01'AS DATE)),
	('PN002',N'Trường An',CAST(N'2021-01-21'AS DATE)),
	('PN003',N'Blue Ocean',CAST(N'2021-08-09'AS DATE))
	GO
	CREATE TABLE NguyenLieu
	(
		maNL varchar(20) NOT NULL PRIMARY KEY,
		tenNL nvarchar(50) NOT NULL,
		tenDVT nvarchar(20), 
		soLuongC float,
	) 
	INSERT INTO NguyenLieu
	VALUES
	('NL001',N'Bột mì','Kg',300),
	('NL002',N'Đường','Kg',400),
	('NL003',N'Trứng',N'Quả',100),
	('NL004',N'Bơ',N'Hộp',30),
	('NL005',N'Sữa tươi',N'Lít',40),
	('NL006',N'Sữa chua',N'Hộp',100),
	('NL007',N'Hương liệu',N'Ml',50)
	GO
	

	CREATE TABLE CT_PhieuNhap
	(
		maPN varchar(20) NOT NULL,
		maNL varchar(20) NOT NULL,
		soLuongN float,
		donGiaNL float, 
		FOREIGN KEY (maPN) REFERENCES PhieuNhap(maPN) ON UPDATE CASCADE ON DELETE CASCADE,
		FOREIGN KEY (maNL) REFERENCES NguyenLieu(maNL) ON UPDATE CASCADE ON DELETE CASCADE,
		PRIMARY KEY (maPN,maNL)
	)
	GO
	INSERT INTO CT_PhieuNhap
	VALUES
	('PN001','NL001',300,8000),
	('PN001','NL002',400,15000),
	('PN002','NL003',100,25000),
    ('PN002','NL004',30,36000),
	('PN003','NL005',40,30000),
	('PN003','NL006',100,5000),
	('PN003','NL007',50,4000)
	GO
	 
	 
	
	CREATE TABLE Banh
	(
		maBanh varchar(20) NOT NULL PRIMARY KEY,
		tenBanh nvarchar(50) NOT NULL,
		dVT nvarchar(20),
		donGia float
		
	)
	GO
	INSERT INTO Banh
	VALUES
	('B0001',N'Bánh Kem',N'Cái',200000),
	('B0002',N'Bánh Mochi',N'Cái',10000),
	('B0003',N'Bánh Flan',N'Cái',12000), 
	('B0004',N'Bánh Cupcake lá dứa',N'Cái',20000),
	('B0005',N'Bánh Mì Nhật Bản',N'Cái',25000),
	('B0006',N'Bánh Bao',N'Cái',5000),
	('B0007',N'Bánh Bông lan bí đỏ',N'Cái',15000)
	GO
	CREATE TABLE HoaDon
	(
		maHD varchar(20) NOT NULL PRIMARY KEY,
		tenKH nvarchar(30),
		ngayLapHD datetime,
	)
	GO
	INSERT INTO HoaDon
	VALUES 
	('HD001',N'Nguyễn Thị Lan',CAST(N'2021-02-02' AS DATE)),
	('HD002',N'Nguyễn Văn An',CAST (N'2021-10-12' AS DATE)),
	('HD003',N'Nguyễn Thị Lan',CAST(N'2021-04-23' AS DATE))
	Go
	CREATE TABLE CT_HoaDon
	(
		maHD varchar(20) NOT NULL,
		maBanh varchar(20) NOT NULL,
		soLuongB float,
		thanhTien float,
		FOREIGN KEY (maBanh) REFERENCES Banh(maBanh) ON UPDATE CASCADE ON DELETE CASCADE,
		FOREIGN KEY (maHD) REFERENCES HoaDon(maHD) ON UPDATE CASCADE ON DELETE CASCADE,
		PRIMARY KEY (maHD,maBanh)
	)
	GO
	INSERT INTO CT_HoaDon
	VALUES
	('HD001','B0001',2,400000),
	('HD001','B0006',5,25000),
	('HD001','B0007',2,30000),
	('HD002','B0002',5,50000),
	('HD003','B0002',2,20000),
	('HD003','B0004',2,40000)
	GO
	CREATE TRIGGER nl_insert
	ON CT_PhieuNhap
	FOR INSERT
	AS begin
	DECLARE @slc int;
	DECLARE @sln int;
	DECLARE @maNL varchar(5) ;
	Select @maNL=maNL,@sln=soLuongN from inserted
	Select @slc=soLuongC from NguyenLieu where maNL=@maNL
	update NguyenLieu set soLuongC=@slc+@sln where maNL=@maNL
	end
	GO
	 
	