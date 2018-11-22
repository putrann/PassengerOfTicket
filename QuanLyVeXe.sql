﻿use master
go
if DB_ID ('QuanLyVeXe') is not null
drop database QuanLyVeXe
go
create database QuanLyVeXe
go
use QuanLyVeXe
go

create table Ghe
(
	id_ghe varchar(10),
	dong int,
	cot int,
	tang int, 
	so_ghe int,  
	Xe_XeID varchar(10),
	constraint ghe_pk
	PRIMARY KEY (id_ghe)
)	

create table Ve
(
	id_ve varchar(10),
	ghe_id_ghe varchar(10),
	chuyen_id_chuyen varchar(10),
	tinhtrang int,
	giatien smallmoney,
	khachhang_id_khachhang varchar(10),
	ngayxuatve datetime,
	ghichu varchar(40),
	constraint ve_ghe_pk
	PRIMARY KEY (id_ve)
)	
create table KhachHang
(
	id_khachhang varchar(10) ,
	hoten nvarchar(4000),
	dienthoai varchar(4000),
	email varchar(4000),
	loai int
	constraint khachhang_pk
	PRIMARY KEY (id_khachhang)
)
create table Tai_Xe
(
	id_taixe varchar(10),
	tentaixe nvarchar(100),
	banglai varchar(100),
	constraint taixe_pk
	PRIMARY KEY (id_taixe)
)
create table Tram_trung_gian
(
	tuyen_id_tuyen varchar(10),
	tram_id_tram varchar(10),
	thu_tu int,
	constraint tram_trung_gian_pk
	PRIMARY KEY (tuyen_id_tuyen,tram_id_tram)
)
create table Tuyen 
(
	id_tuyen varchar(10),
	khoang_cach float,
	thoigianchay int,
	tram_id_tram1 varchar(10),
	tram_id_tram varchar(10)
	constraint tuyen_pk
	PRIMARY KEY (id_tuyen)
)

create table Tram
(
	id_tram varchar(10),
	ten_tram nvarchar(4000),
	dia_diem nvarchar(4000),
	constraint tram_pk
	PRIMARY KEY (id_tram)
)

create table LoaiXe
(
	id_loaixe varchar(10),
	tenloai nvarchar(4000)
	constraint loaixe_pk
	PRIMARY KEY (id_loaixe)
)
create table Xe
(
	xe_id varchar(10), 
	ten_xe nvarchar(4000),
	so_dang_ky varchar(4000),
	loaixe_id_loaixe varchar(10),
	constraint xe_pk
	PRIMARY KEY (xe_id)
)

create table Chuyen 
(
	id_chuyen varchar(10),
	tuyen_id_tuyen varchar(10),
	giokhoihanh datetime,
	ghichu nvarchar(4000),
	xe_xeid varchar(10),
	tai_xe_id_taixe varchar(10),
	constraint chuyen_pk
	PRIMARY KEY (id_chuyen)
)
--khoa ngoai 
ALTER TABLE Ve
ADD 
CONSTRAINT ve_ghe_fk
FOREIGN KEY(ghe_id_ghe)
REFERENCES Ghe,
CONSTRAINT ve_chuyen_fk
FOREIGN KEY(chuyen_id_chuyen)
REFERENCES Chuyen,
CONSTRAINT ve_khachhang1_fk
FOREIGN KEY(khachhang_id_khachhang)
REFERENCES KhachHang

ALTER TABLE Ghe
ADD 
CONSTRAINT ghe1_xe_fk
FOREIGN KEY(Xe_XeID)
REFERENCES Xe

ALTER TABLE Xe
ADD 
CONSTRAINT xe_loaixe_fk
FOREIGN KEY(loaixe_id_loaixe)
REFERENCES LoaiXe

ALTER TABLE Chuyen
ADD 
CONSTRAINT chuyen_taixe_fk
FOREIGN KEY(tai_xe_id_taixe)
REFERENCES Tai_Xe,
CONSTRAINT chuyen_tuyen_fk
FOREIGN KEY(tuyen_id_tuyen)
REFERENCES Tuyen,
CONSTRAINT ve_khachhang_fk
FOREIGN KEY(xe_xeid)
REFERENCES Xe

ALTER TABLE Tuyen
ADD 
CONSTRAINT tuyen_tram_fk
FOREIGN KEY(tram_id_tram)
REFERENCES Tram,
CONSTRAINT chuyen_tram2_fk
FOREIGN KEY(tram_id_tram1)
REFERENCES Tram

ALTER TABLE Tram_trung_gian
ADD 
CONSTRAINT ttg_tuyen_fk
FOREIGN KEY(tuyen_id_tuyen)
REFERENCES Tuyen,
CONSTRAINT ttg_tram_fk
FOREIGN KEY(tram_id_tram)
REFERENCES Tram

insert Chuyen
values
('C01','T01','08:00',N'TPHCM -QUY NHƠN ','X01','TX01'),
('C02','T01','10:00',N'TPHCM -QUY NHƠN ','X02','TX02'),
('C03','T01','17:00',N'TPHCM -QUY NHƠN ','X03','TX03'),
('C04','T02','08:00',N'QUY NHƠN- TPHCM','X04','TX04'),
('C05','T02','10:00',N'QUY NHƠN - TPHCM ','X05','TX05'),
('C06','T02','19:00',N'QUY NHƠN - TPHCM ','X06','TX06'),
('C07','T03','08:00',N'TPHCM -VŨNG TÀU ','X07','TX07'),
('C08','T03','10:00',N'TPHCM -VŨNG TÀU ','X08','TX08'),
('C09','T03','20:00',N'TPHCM -VŨNG TÀU ','X09','TX09'),
('C10','T04','08:00',N'VŨNG TÀU -TPHCM ','X10','TX10'),
('C11','T04','10:00',N'VŨNG TÀU -TPHCM','X01','TX09'),
('C12','T04','20:00',N'VŨNG TÀU -TPHCM','X07','TX12'),
('C13','T05','08:00',N'TPHCM -ĐÀ NẴNG ','X01','TX01'),
('C14','T05','10:00',N'TPHCM -ĐÀ NẴNG ','X02','TX02'),
('C15','T05','20:00',N'TPHCM -ĐÀ NẴNG ','X03','TX03'),
('C16','T06','08:00',N'ĐÀ NẴNG-TPHCM ','X04','TX04'),
('C17','T06','17:00',N'ĐÀ NẴNG-TPHCM ','X05','TX05'),
('C18','T06','20:00',N'ĐÀ NẴNG-TPHCM ','X06','TX06')

insert Tai_Xe
values 
('TX01',N'Nguyễn Mai Thi',N'bằng A2'),
('TX02',N'Nguyễn Thanh Phong',N'bằng A2'),
('TX03',N'Nguyễn Thị Thìn',N'bằng A2'),
('TX04',N'Trần Thị Bích Phương',N'bằng A2'),
('TX05',N'Nguyễn Thị An Toàn',N'bằng A2'),
('TX06',N'Nguyễn Văn Tốc',N'bằng A2'),
('TX07',N'Nguyễn Văn Độ',N'bằng A2'),
('TX08',N'Trần Đua',N'bằng A2'),
('TX09',N'Nguyễn Xe',N'bằng A2'),
('TX10',N'Nguyễn Văn Rớt Môn',N'bằng A2')

insert Xe
values 
('X01',N'BA THI','S01','LX01'),
('X02',N'HAI PHONG','S02','LX02'),
('X03',N'LAMBOGHINI ','S03','LX03'),
('X04',N'BỐN TÈO','S04','LX01'),
('X05',N'NĂM TÍ','S05','LX02'),
('X06',N'SÁU','S06','LX03'),
('X07',N'BẢY TỴ','S07','LX01'),
('X08',N'TÁM MÙ','77-D1','LX02'),
('X09',N'CHÍN MỊT','77-D2','LX03'),
('X10',N'MƯỜI KHÓ','77-D4','LX01')

INSERT LoaiXe
VALUES
('LX01',N'30 CHỖ'),
('LX02',N'45 CHỖ'),
('LX03',N'GIƯỜNG NẰM')

INSERT Ghe
VALUES
('G01',1,1,1,30,'X01'),
('G02',2,1,1,30,'X01'),
('G03',4,1,1,30,'X01'),
('G04',5,1,1,30,'X02'),
('G05',6,1,1,30,'X02'),
('G06',1,2,3,30,'X03'),
('G07',2,2,3,30,'X03'),
('G08',3,2,3,30,'X04'),
('G09',4,1,2,30,'X04'),
('G10',7,1,2,30,'X04'),
('G11',8,1,1,30,'X05'),
('G12',1,5,1,30,'X06'),
('G13',2,5,1,30,'X06'),
('G14',3,5,1,30,'X06'),
('G15',4,5,2,30,'X07'),
('G16',5,5,2,30,'X10')

INSERT Ve
VALUES
('V01','G01','C01',1,200000.0,'KH01','2018/11/30',N'KHÔNG ĐƯỢC LÀM RÁCH VÉ'),
('V02','G02','C01',1,200000.0,'KH01','2018/11/30',N'KHÔNG ĐƯỢC LÀM RÁCH VÉ'),
('V03','G01','C01',1,200000.0,'KH02','2018/11/30',N'KHÔNG ĐƯỢC LÀM RÁCH VÉ'), 
('V04','G04','C02',1,300000.0,'KH03','2018/12/01',N'KHÔNG ĐƯỢC LÀM RÁCH VÉ'),
('V05','G05','C02',0,300000.0,'KH04','2018/12/01',N'KHÔNG ĐƯỢC LÀM RÁCH VÉ')

insert KhachHang
values
('KH01',N'Trần Thị Bích Phương','0783478386','b123@gmail.com',1),
('KH02',N'Nguyễn Thị Thìn',N'0783478386','b123@gmail.com',1),
('KH03',N'Nguyễn Thị',N'0783478386','b123@gmail.com',1),
('KH04',N'Trần Thị Bích Phương','0783478386','b123@gmail.com',1),
('KH05',N'Nguyễn Thị Thìn',N'0783478386','b123@gmail.com',1),
('KH06',N'Nguyễn Thị',N'0783478386','b123@gmail.com',1)

insert 




