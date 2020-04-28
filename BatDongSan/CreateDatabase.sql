
use QuanLyBatDongSan

create table LoaiTinTuc(
	ID int primary key identity not null,
	Ten nvarchar(30) not null,
	MoTa ntext
)

create table LoaiTinBatDongSan(
	ID int primary key identity not null,
	Ten nvarchar(50) not null
)

create table GoiTin(
	ID int primary key identity not null,
	Ten nvarchar(50) not null,
	MucPhi float not null
)

create table LoaiBatDongSan(
	ID int primary key identity not null,
	Ten nvarchar(50) not null
)
create table TinhThanh(
	ID int primary key identity not null,
	Ten nvarchar(50) not null
)

create table QuanHuyen(
	ID int primary key identity not null,
	Ten nvarchar(50) not null,
	TinhThanh int references TinhThanh(ID) not null
)

create table MucGia(
	ID int primary key identity not null,
	Ten nvarchar(30) not null,
	Min float not null,
	Max float not null
)

create table MucDienTich(
	ID int primary key identity not null,
	Ten nvarchar(50) not null,
	Min float not null,
	Max float not null
)

create table Huong(
	ID int primary key identity not null,
	Ten nvarchar(30) not null
)

create table ChucVu(
	ID int primary key identity not null,
	Ten nvarchar(30) not null,
	MoTa ntext
)

create table NguoiDung(
	ID nvarchar(30) primary key not null,
	Ten nvarchar(30) not null,
	ChucVu int references ChucVu(ID) not null,
	DiaChi nvarchar(50),
	SoDienThoai nvarchar(15),
	Email nvarchar(30),
	SoBaiDang int
)

create table LoaiTaiKhoan(
	ID int primary key identity not null,
	Ten nvarchar(30) not null,
	ChucNang nvarchar(50)
)

create table TaiKhoan(
	ID nvarchar(30) primary key not null,
	MatKhau nvarchar(20) not null,
	NguoiDung nvarchar(30) references NguoiDung(ID) not null,
	LoaiTaiKhoan int references LoaiTaiKhoan(ID) not null
)


create table TinTuc(
	ID int primary key identity not null,
	TieuDe nvarchar(50) not null,
	NgayDang datetime not null,
	NguoiDang nvarchar(30) references NguoiDung(ID) not null,
	NoiDung ntext,
	LoaiTinTuc int references LoaiTinTuc(ID) not null
)

create table TinBatDongSan(
	ID int primary key identity not null,
	LoaiTin int references LoaiTinBatDongSan(ID) not null,
	NgayDang datetime not null,
	TrangThaiGiaoDich bit not null,
	TrangThaiXacNhan bit not null,
	NguoiDang nvarchar(30) references NguoiDung(ID),
	GoiTin int references GoiTin(ID),
	LoaiBatDongSan int references LoaiBatDongSan(ID) not null,
	TinhThanh int references TinhThanh(ID) not null,
	QuanHuyen int references QuanHuyen(ID) not null,
	Gia nvarchar(30) not null,
	MucGia int references MucGia(ID),
	DienTich float not null,
	MucDienTich int references MucDienTich(ID) not null,
	Huong int references Huong(ID) not null,
	MoTa ntext
)