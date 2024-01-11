﻿
-- Tạo CSDL QLBH ---
CREATE DATABASE QLBH;

-- Câu 1-- 
-- Tạo bảng NHANVIEN -- 
CREATE TABLE NHANVIEN (
	MANV char(4) PRIMARY KEY,
	HOTEN varchar(40),
	SODT varchar(20),
	NGVL smalldatetime
);

-- Tạo bảng KHACHHANG -- 
CREATE TABLE KHACHHANG (
	MAKH char(4) PRIMARY KEY,
	HOTEN varchar(40),
	DCHI varchar(50),
	SODT varchar(20),
	NGSINH smalldatetime,
	DOANHSO money,
	NGDK smalldatetime
);

-- Tạo bảng SANPHAM  -- 
CREATE TABLE SANPHAM (
	MASP char(4) PRIMARY KEY,
	TENSP varchar(40),
	DVT varchar(20),
	NUOCSX varchar(40),
	GIA money
);

-- Tạo bảng HOADON -- 
CREATE TABLE HOADON (
	SOHD int PRIMARY KEY,
	NGHD smalldatetime,
	MAKH char(4) FOREIGN KEY REFERENCES KHACHHANG(MAKH),
	MANV char(4) FOREIGN KEY REFERENCES NHANVIEN(MANV),
	TRIGIA money
);

-- Tạo bảng CTHD -- 
CREATE TABLE CTHD (
	SOHD int FOREIGN KEY REFERENCES HOADON(SOHD),
	MASP char(4) FOREIGN KEY REFERENCES SANPHAM(MASP),
	SL int,
	constraint PK_CTHD PRIMARY KEY(SOHD,MASP)
);

-- Câu 2 -- 
ALTER TABLE SANPHAM ADD GHICHU varchar(20);

-- Câu 3 --
ALTER TABLE KHACHHANG ADD LOAIKH tinyint;

-- Câu 4 --
ALTER TABLE SANPHAM ALTER COLUMN GHICHU varchar(100);

-- Câu 5 --
ALTER TABLE SANPHAM DROP COLUMN GHICHU;

-- Câu 6 --
ALTER TABLE KHACHHANG ALTER COLUMN LOAIKH varchar(50);

-- Câu 7 --
ALTER TABLE SANPHAM ADD constraint CK_DVT CHECK (DVT IN ('cay','hop','cai','quyen','chuc'));

-- Câu 8 --
ALTER TABLE SANPHAM ADD constraint CK_GIA CHECK (GIA >= 500);

-- Câu 9 --
ALTER TABLE CTHD ADD constraint CK_SL CHECK( SL >= 1);

-- Câu 10 --
ALTER TABLE KHACHHANG ADD constraint CK_NGDK_NGSINH CHECK ( NGDK > NGSINH );

