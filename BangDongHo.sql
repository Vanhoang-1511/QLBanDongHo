create database BanNongSan
go 
use BanNongSan
go

create table NhanVien_table(
	maNV varchar(7) primary key,
	tenNV nvarchar(50),
	tenDN varchar(25),
	matKhau varchar(25)
)


insert into NhanVien_table values
('NV00001','Lâm Trường Trương','truong1','12345'),
('NV00002','Quỳnh Nga Ngô','nga2','12345'),
('NV00003','Thiên Ðức Phan','duc3','12345'),
('NV00004','Ðăng Khánh Trịnh','khanh4','12345'),
('NV00005','Thanh Loan Vương','ThanhLoan70','12345'),
('NV00006','Trường Phát Vương','phattruong02','12345')


create table KhachHang_table(
	maKH varchar(7) primary key,
	tenKH nvarchar(50),
	SoTienDaDung int default 0,
	namSinh int ,
	diaChi nvarchar(50)
)
insert into KhachHang_table values
('KH00000','Vãn Lai',default,0,''),
('KH00001',N'Trần Đại',default,2001,N'Quảng Ngãi'),
('KH00002',N'Thu Hòa',default,1999,N'Quảng Nam'),
('KH00003',N'Thu Hằng',default,1989,N'Kom Tum'),
('KH00004',N'Thu Hiền',default,2002,N'Đắk Lắk'),
('KH00005',N'NHật Nga',default,2005,N'Đà Nẵng'),
('KH00006',N'Hùng Hoàng',default,1992,N'Đà Nẵng'),
('KH00007',N'Huỳnh Trí',default,1970,N'Hà Tĩnh'),
('KH00008',N'Đõ Nghĩa',default,1990,N'Huế')


create table  DanhMucNongSan_table(
	maDM varchar(7) primary key,
	tenDM nvarchar(50)
)

insert into DanhMucNongSan_table values
('DM00001',N'Đồng hồ điện tử'),
('DM00002',N'Đồng hồ kim'),
('DM00003',N'Đồng hồ thông minh')


create table  ChiTietNongSan_table(
	maNS varchar(7) primary key,
	tenNS nvarchar(50),
	soLuong int,
	chiTiet nvarchar(50),
	maSMNS varchar(7),
	gia int



)
insert into ChiTietNongSan_table values
('NS00001','Casio E300',23,'Kiểu dáng đep','DM00001',300000),
('NS00002','Casio N1001',23,'Thiết kế mới, sang trọng','DM00001',550000),
('NS00003','Casio N900',23,'Thiết kế mới, sang trọng','DM00001',480000),
('NS00004','G-Shock 107',23,'Đảm bảo chính hãng','DM00001',1122000),
('NS00005','Seiko A383',23,'Chất lượng đi cùng năm tháng','DM00002',1230000),
('NS00006','Seiko A387',23,'Đồng hồ cao cấp','DM00002',1400000),
('NS00007','Hublot Super',23,'Đảm bảo chính hãng','DM00002',4500000),
('NS00008','Rolex Luxury',23,'Đảm bảo chính hãng','DM00002',3000000),
('NS00009','Apple Watch 4',23,'Tích hợp nhiều công nghệ hiện đại','DM00003',4000000),
('NS00010','Huawei Watch 11',23,'Hiện đại, sang trọng, tinh tế','DM00003',1500000),
('NS00011','Mi band 6',23,'Ngon, bổ , rẻ','DM00003',746000)

create table  HoaDonNhapXuat_table(
	maHD varchar(50) primary key,
	maNV varchar(7),
	maKH varchar(7),
	LoaiHD varchar(1)
)
insert into HoaDonNhapXuat_table values
('HD00001','NV00001','KH00001','N')


create table ChiTietHoaDon_table(
maHD varchar(7),
maNS varchar(7),
soLuong int,
DonGia int
)
insert into ChiTietHoaDon_table values
('HD00001','NS00001',1,10000)




DELETE FROM KhachHang_table
DELETE FROM ChiTietNongSan_table
DELETE FROM ChiTietHoaDon_table
DELETE FROM HoaDonNhapXuat_table
DELETE FROM DanhMucNongSan_table
DELETE FROM NhanVien_table




DROP DATABASE BanNongSan

/*
CREATE PROCEDURE UpdateData 
AS 
BEGIN
	BEGIN TRY
	print('1')
	END TRY
	BEGIN CATCH
	END CATCH



END
*/
drop procedure UpdateData
CREATE PROCEDURE UpdateData 
AS 
/*
BEGIN
	
END
*/



BEGIN TRY  
    if exists(select * from KhachHang_table where maKH ='KH00001')
	begin
		print('1 \')
	end else
	print('3')
END TRY  
BEGIN CATCH  
		print('2') 
END CATCH 
/*
insert into KhachHang_table values
('KH00001','Tr?n D?i','0'),
('KH00002','THu Hòa','0'),
('KH00003','Thu H?ng','0'),
('KH00004','Thu Hi?n','0'),
('KH00005','NH?t Nga','0'),
('KH00006','Hùng Hoàng','0'),
('KH00007','Hu?nh Trí','0'),
('KH00008','Do Nghia','0')
*/
