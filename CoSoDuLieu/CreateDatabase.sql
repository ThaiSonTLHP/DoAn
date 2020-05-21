
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
	ID nvarchar(5) primary key not null,
	Ten nvarchar(50) not null,
	Loai nvarchar(50) not null
)

create table QuanHuyen(
	ID nvarchar(5) primary key not null,
	Ten nvarchar(50) not null,
	Loai nvarchar(30) not null,
	TinhThanh nvarchar(5) references TinhThanh(ID) not null
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

create table LoaiTaiKhoan(
	ID int primary key identity not null,
	Ten nvarchar(30) not null,
	ChucNang ntext
)

create table TaiKhoan(
	ID int primary key identity not null,
	MatKhau nvarchar(20) not null,
	Ten nvarchar(30) not null,
	GioiTinh bit not null,
	Email nvarchar(30) not null,
	SoDienThoai nvarchar(15) not null,
	DiaChi nvarchar(50),
	SoDuVi float not null,
	LoaiTaiKhoan int references LoaiTaiKhoan(ID) not null
)

create table TinTuc(
	ID int primary key identity not null,
	TieuDe nvarchar(50) not null,
	NgayDang datetime not null,
	NguoiDang int references TaiKhoan(ID) not null,
	NoiDung ntext not null,
	LoaiTinTuc int references LoaiTinTuc(ID) not null
)

create table TinBatDongSan(
	ID int primary key identity not null,
	LoaiTin int references LoaiTinBatDongSan(ID) not null,
	NgayDang datetime not null,
	TrangThaiGiaoDich bit not null,
	TrangThaiDuyet bit not null,
	TrangThaiXacNhan bit not null,
	NguoiDang int references TaiKhoan(ID),
	GoiTin int references GoiTin(ID),
	LoaiBatDongSan int references LoaiBatDongSan(ID) not null,
	TinhThanh nvarchar(5) references TinhThanh(ID) not null,
	QuanHuyen nvarchar(5) references QuanHuyen(ID) not null,
	Gia float not null,
	MucGia int references MucGia(ID),
	DienTich float not null,
	MucDienTich int references MucDienTich(ID) not null,
	Huong int references Huong(ID) not null,
	MoTa ntext not null
)

create table HinhAnh(
	ID int primary key identity not null,
	Anh image not null,
	AnhChinh bit not null,
	TinBatDongSan int references TinBatDongSan(ID) not null
)