create database QLNHAHANG
use QLNHAHANG

create table Login (
	TaiKhoan varchar(10) primary key,
	MatKhau varchar(10) not null
)

insert into Login (TaiKhoan,MatKhau)
values ('admin2','admin2')


create table Thongtinban
(
	STT int identity (1,1) primary key,
	TenHang nvarchar(20) not null,
	SoLuong int,
	DonGia int,
	ThanhTien int A
)


insert into Thongtinban(STT,TenHang,SoLuong,DonGia,ThanhTien)
values('1',N'Khăn','10','2000','20000')
insert into Thongtinban(STT,TenHang,SoLuong,DonGia,ThanhTien)
values('2',N'Bánh','4','4000','16000')
insert into Thongtinban(STT,TenHang,SoLuong,DonGia,ThanhTien)
values('3',N'Gà hấp hành','1','300000','300000')
insert into Thongtinban(STT,TenHang,SoLuong,DonGia,ThanhTien)
values('4',N'Gà nướng','1','300000','300000')
insert into Thongtinban(STT,TenHang,SoLuong,DonGia,ThanhTien)
values('5',N'Heineken','32','20000','640000')
insert into Thongtinban(STT,TenHang,SoLuong,DonGia,ThanhTien)
values('6',N'Nước ngọt','4','14000','56000')

