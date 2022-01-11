create database BanDongHo
go 
use BanDongHo
go

create table NhanVien(
	maNV varchar(7) primary key,
	tenNV nvarchar(50),
	tenDN varchar(25),
	matKhau varchar(25)
)


insert into NhanVien values
('NV00001',N'Lâm Trường Trương','truong1','12345'),
('NV00002',N'Quỳnh Nga Ngô','nga2','12345'),
('NV00003',N'Thiên Ðức Phan','duc3','12345'),
('NV00004',N'Ðăng Khánh Trịnh','khanh4','12345'),
('NV00005',N'Thanh Loan Vương','ThanhLoan70','12345'),
('NV00006',N'Trường Phát Vương','phattruong02','12345')


create table KhachHang(
	maKH varchar(7) primary key,
	tenKH nvarchar(50),
	SoTienDaDung int default 0,
	namSinh int ,
	diaChi nvarchar(50)
)
insert into KhachHang values
('KH00000',N'Khách vãn lai',default,0,''),
('KH00001',N'Quốc Tuấn',default,2001,N'Thừa Thiên Huế'),
('KH00002',N'Văn Hoàng',default,1999,N'Đà Nẵng'),
('KH00003',N'Thu Hằng',default,1989,N'Kom Tum'),
('KH00004',N'Thu Hiền',default,2002,N'Đắk Lắk'),
('KH00005',N'Ngọc Diễm',default,2005,N'Đà Nẵng'),
('KH00006',N'Thế Hoàng',default,1992,N'Đà Nẵng'),
('KH00007',N'Huỳnh Trí',default,1970,N'Hà Tĩnh'),
('KH00008',N'Văn Duy',default,1990,N'Hải Phòng')


create table  DanhMucSanPham(
	maDM varchar(7) primary key,
	tenDM nvarchar(50)
)

insert into DanhMucSanPham values
('DM00001',N'Đồng hồ điện tử'),
('DM00002',N'Đồng hồ kim'),
('DM00003',N'Đồng hồ thông minh')


create table  ChiTietSanPham(
	maSP varchar(7) primary key,
	tenSP nvarchar(50),
	soLuong int,
	chiTiet nvarchar(50),
	maDMSP varchar(7),
	gia int
)

insert into ChiTietSanPham values
('SP00001','Casio E300',23,N'Kiểu dáng đep','DM00001',300000),
('SP00002','Casio N1001',23,N'Thiết kế mới, sang trọng','DM00001',550000),
('SP00003','Casio N900',23,N'Thiết kế mới, sang trọng','DM00001',480000),
('SP00004','G-Shock 107',23,N'Đảm bảo chính hãng','DM00001',1122000),
('SP00005','Seiko A383',23,N'Chất lượng đi cùng năm tháng','DM00002',1230000),
('SP00006','Seiko A387',23,N'Đồng hồ cao cấp','DM00002',1400000),
('SP00007','Hublot Super',23,N'Đảm bảo chính hãng','DM00002',4500000),
('SP00008','Rolex Luxury',23,N'Đảm bảo chính hãng','DM00002',3000000),
('SP00009','Apple Watch 4',23,N'Tích hợp nhiều công nghệ hiện đại','DM00003',4000000),
('SP00010','Huawei Watch 11',23,N'Hiện đại, sang trọng, tinh tế','DM00003',1500000),
('SP00011','Mi band 6',23,N'Ngon, bổ , rẻ','DM00003',746000)

create table  HoaDonNhapXuat(
	maHD varchar(50) primary key,
	maNV varchar(7),
	maKH varchar(7),
	LoaiHD varchar(1)
)
insert into HoaDonNhapXuat values
('HD00001','NV00001','KH00001','N')


create table ChiTietHoaDon(
maHD varchar(7),
maSP varchar(7),
soLuong int,
DonGia int
)
insert into ChiTietHoaDon values
('HD00001','NS00001',1,10000)









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

CREATE PROCEDURE UpdateData 
AS 
BEGIN TRY  
    if exists(select * from KhachHang where maKH ='KH00001')
	begin
		print('1 \')
	end else
	print('3')
END TRY  
BEGIN CATCH  
		print('2') 
END CATCH 
