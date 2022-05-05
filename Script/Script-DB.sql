﻿--Môn: Phân tích thiết kế hệ thống thông tin
--Đồ án thực hành
--Nhóm: 10

--Xóa DB
ALTER DATABASE DB_HeThongDangKyTiemChung
SET SINGLE_USER WITH ROLLBACK IMMEDIATE
USE master
DROP DATABASE DB_HeThongDangKyTiemChung
GO

--B1: Tạo cơ sở dữ liệu

CREATE DATABASE DB_HeThongDangKyTiemChung
GO
USE DB_HeThongDangKyTiemChung
GO

--B2: Tạo tất cả Tables (kèm PK)
CREATE TABLE VACXIN
(
	MAVACXIN INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TENVACXIN nvarchar(100) NOT NULL,
	LOAIVACXIN nvarchar(50),
	HANGVACXIN nvarchar(70),
	NGUABENH nvarchar(100),
	MOTA nvarchar(500),
	SLTON int,
	GIABAN bigint,
	SLTiem int
)
GO

CREATE TABLE GOIVACXIN(
	MAGOIVACXIN int IDENTITY(1,1) NOT NULL,
	TENGOIVACXIN nvarchar(100) NOT NULL,
	MOTA nvarchar(500) NULL,
	GIABAN bigint NULL,
	SLTiem int NULL,
	PRIMARY KEY (MAGOIVACXIN)
)
GO

CREATE TABLE VACXINNGOAI
(
	MAVACXIN INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TENVACXIN nvarchar(100) NOT NULL,
	LOAIVACXIN nvarchar(50),
	HANGVACXIN nvarchar(70)
)
GO

CREATE TABLE CTGOIVACXIN(
	MAGOIVACXIN int NOT NULL,
	MAVACXIN int NOT NULL,
	PRIMARY KEY
	(
		MAGOIVACXIN,
		MAVACXIN
	)
)
GO

CREATE TABLE KHACHHANG
(
	MAKH INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	HOTENKH NVARCHAR(30) NOT NULL,
	DIACHIKH NVARCHAR(100),
	GIOITINHKH NVARCHAR(4),
	EMAILKH VARCHAR(50),
	CMNDKH NCHAR(12),
	NGAYSINHKH DATETIME,
	SDTKH NCHAR(10),
	USERNAME CHAR(100),
	PASS CHAR(200) 
)
GO

CREATE TABLE LICHRANH
(
	MANHANVIEN INT NOT NULL,
	NGAY DATE NOT NULL,
	CA TINYINT NOT NULL CHECK (CA > -1 and CA < 3)
	PRIMARY KEY (MANHANVIEN, NGAY, CA)
)
GO

CREATE TABLE NHANVIEN
(
	MANHANVIEN INT IDENTITY(1,1) NOT NULL,
	HOTEN NVARCHAR(30) NOT NULL,
	EMAIL VARCHAR(50),
	SDT VARCHAR(15),
	MACN INT,
	USERNAME CHAR(100),
	PASS CHAR(200),
	PRIMARY KEY (MANHANVIEN)
)
GO

CREATE TABLE PHIEU_DATMUA
(
	MAPDM INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	NGAYMUA DATETIME,
	MAKH INT,
	TRANGTHAI BIT
)

CREATE TABLE CHITIET_PHIEUDATMUA
(
	MAPDM INT,
	MAVACXIN INT,
	SOLUONG INT,

	CONSTRAINT PK_CT_PDM
	PRIMARY KEY (MAPDM, MAVACXIN)
)
GO


CREATE TABLE DANHSACHDATMUA
(
	MADSDATMUA INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	NGAYLAP DATETIME
)
GO

CREATE TABLE CHITIET_DSDATMUA
(
	MADSDATMUA INT,
	MAVACXIN INT,
	SOLUONG INT,
	CONSTRAINT PK_CT_DSDM
	PRIMARY KEY (MADSDATMUA, MAVACXIN)
)

GO

CREATE TABLE CHINHANH
(
	MACN INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TENCN nvarchar(100) NOT NULL,
	DIACHICN nvarchar(100)	
)
GO

CREATE TABLE PHIEUDANGKYTIEMCHUNG
(
	MAPDK INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	MAKH INT,

	HOTENNT nvarchar(30),
	CMNDNT char(12),
	DIACHINT nvarchar(100),
	NGSINHNT date,
	GIOITINHNT NVARCHAR(4),
	SDTNT char(10),
	
	QUANHE nvarchar(30),

	THOIGIANDK date,
	TINHTRANG nvarchar(20)
)
GO

CREATE TABLE CTPHIEUDKTC
(
	MAPDK INT,
	MAGOIVACXIN INT,
	LANTIEM INT,
	MACN INT,

	PRIMARY KEY (MAPDK, MAGOIVACXIN, LANTIEM)
)
GO

--CREATE TABLE THONGTINTHANHTOAN
--(
--	MATT INT,
--	MAPDK INT,
--	MAPTT INT,
--	DICHVU CHAR(4),
--	THANHTIEN BIGINT,
--	HANTHANHTOAN DATE

--)
--GO

--B3: Tạo tất cả contraints 
ALTER TABLE CTGOIVACXIN  
ADD CONSTRAINT FK_CTGOIVACXIN_GOIVACXIN FOREIGN KEY(MAGOIVACXIN)
REFERENCES GOIVACXIN (MAGOIVACXIN)

ALTER TABLE CTGOIVACXIN 
ADD CONSTRAINT FK_CTGOIVACXIN_VACXIN FOREIGN KEY(MAVACXIN)
REFERENCES VACXIN (MAVACXIN)

ALTER TABLE NHANVIEN 
ADD CONSTRAINT FK_NHANVIEN_CHINHANH FOREIGN KEY(MACN)
REFERENCES CHINHANH (MACN)

ALTER TABLE PHIEUDANGKYTIEMCHUNG 
ADD CONSTRAINT FK_PHIEUDANGKYTIEMCHUNG_KHACHHANG FOREIGN KEY(MAKH)
REFERENCES KHACHHANG (MAKH)

ALTER TABLE CTPHIEUDKTC 
ADD CONSTRAINT FK_CTPHIEUDKTC_PHIEUDANGKYTIEMCHUNG FOREIGN KEY(MAPDK)
REFERENCES PHIEUDANGKYTIEMCHUNG (MAPDK)

ALTER TABLE CTPHIEUDKTC 
ADD CONSTRAINT FK_CTPHIEUDKTC_GOIVACXIN FOREIGN KEY(MAGOIVACXIN)
REFERENCES GOIVACXIN (MAGOIVACXIN)

ALTER TABLE CTPHIEUDKTC 
ADD CONSTRAINT FK_CTPHIEUDKTC_CHINHANH FOREIGN KEY(MACN)
REFERENCES CHINHANH (MACN)
GO


--B4: Thêm dữ liệu
-- Thêm dữ liệu: VACXIN
INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN, SLTiem)
VALUES		
('Moderna', 'mRNA', 'ModernaTX, Inc', 'COVID19', N'Số mũi tiêm: 2 liều trong loạt tiêm chính, cách nhau 4-8 tuần.
Những người từ 18 tuổi trở lên bị suy giảm miễn dịch vừa hoặc nặng nên tiêm liều thứ ba ít nhất 4 tuần sau liều thứ hai.', 200, 600000, 2)

INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN, SLTiem)
VALUES
('Pfizer-BioNTech', 'mRNA', N'Pfizer, Inc. và BioNTech', 'COVID19', N'Số mũi tiêm: 2 liều trong loạt tiêm chính, cách nhau 3-8 tuần.
Những người từ 5 tuổi trở lên bị suy giảm miễn dịch vừa hoặc nặng nên tiêm liều thứ ba ít nhất 4 tuần sau liều thứ hai.', 500, 400000, 2)

INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN, SLTiem)
VALUES
('Varivax', null, N'Merck Sharp & Dohme, Hoa Kỳ', N'Thủy đậu', N'Tiêm 2 liều 0.5mL/liều, mỗi liều cách nhau 4 - 8 tuần.', 70,  1000000, 2)

INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN, SLTiem)
VALUES
('Tetanus', N'Giải độc tố', N'Sanofi Pasteur, Pháp', N'Uốn ván', N'Khi trẻ từ 2 - 4 tháng tuổi cần tiêm 03 mũi vắc-xin 5in1 (bao gồm bạch hầu, ho gà, uốn ván,bại liệt và viêm não do vi khuẩn HIB) hoặc 6 in1( bao gồm bạch hầu, ho gà , uốn ván, bại liệt , HiB và viêm gan B)
18 tháng tuổi trẻ sẽ được tiêm nhắc lại mũi vắc xin bạch hầu, ho gà, uốn ván ( 5 in 1 hoặc 6 in 1)
Sau khoảng thời gian từ 05 - 10 năm nên tiêm nhắc lại.', 400,  1000000, 3)

INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN, SLTiem)
VALUES
('Verorab', null, N'Sanofi Pasteur, Pháp', N'Dại', N'Vắc xin Verorab được chỉ định tiêm phòng cho các đối tượng nguy cơ phơi nhiễm cao như:
Nhân viên làm phòng thí nghiệm, nghiên cứu, sản xuất liên quan đến virus dại. Với đối tượng này cứ mỗi 6 tháng làm chuẩn đoán huyết thanh 1 lần. Tiêm vắc xin nhắc lại khi định lượng kháng thể dưới ngưỡng bảo vệ 0,5IU/ml.', 100,  388000, 5)

INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN, SLTiem)
VALUES
('Abhayrab', null, N'Human Biologigical Institute, Ấn Độ', N'Dại', N'Abhayrab giúp tạo miễn dịch chủ động chống lại virus dại cho cả người lớn và trẻ em, để dự phòng và điều trị sau khi bị phơi nhiễm (sau khi tiếp xúc với con vật bị dại hoặc nghi ngờ bị dại).
Abhayrab có thể sử dụng cho tất cả các lứa tuổi.', 200,  200000, 3)

INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN, SLTiem)
VALUES
('mORCVAX', N'Bất hoạt', N'Vabiotech, Việt Nam', N'Tả', N'Cả người lớn và trẻ em đều uống liều 1,5ml.
Lịch cơ bản: Uống 2 liều, khoảng cách giữa 2 liều là 14 ngày. Thời gian bảo vệ khi uốn đủ 2 liều cơ bản là 24 tháng.
Uống nhắc lại: Trước mùa dịch tả, phác đồ uống nhắc lại vẫn là uống 2 liều và khoảng cách giữa 2 liều là 14 ngày.', 200,  200000, 2)

INSERT VACXIN (TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN, SLTiem) VALUES (N'Rotarix', NULL, N'Bỉ', N'Tiêu chảy do Rota', N'Trẻ từ 6 tuần tuổi trở lên có thể sử dụng vắc-xin chủng ngừa virus Rota
Liều đầu tiên: khi trẻ được 6 tuần tuổi
Liều thứ 2: sau liều đầu tiên tối thiểu 4 tuần
Kết thúc 2 liều trước khi trẻ được 24 tuần tuổi
Nếu liều đầu tiên sử dụng vắc-xin Rotarix thì liều thứ 2 bắt buộc phải tiếp tục dùng Rotarix.', 600, 700000, 2)
GO


--Thêm dữ liệu: VACXINNGOAI

-- Thêm dữ liệu: DANHSACHDATMUA
INSERT INTO DANHSACHDATMUA(NGAYLAP) VALUES (14/11/2021)
INSERT INTO DANHSACHDATMUA(NGAYLAP) VALUES (26/3/2022)
INSERT INTO DANHSACHDATMUA(NGAYLAP) VALUES (17/4/2022)
GO

-- Thêm dữ liệu: CHITIET_DSDATMUA
INSERT INTO CHITIET_DSDATMUA(MADSDATMUA,MAVACXIN,SOLUONG) VALUES (1,1,10)
INSERT INTO CHITIET_DSDATMUA(MADSDATMUA,MAVACXIN,SOLUONG) VALUES (1,2,23)
INSERT INTO CHITIET_DSDATMUA(MADSDATMUA,MAVACXIN,SOLUONG) VALUES (2,2,6)
INSERT INTO CHITIET_DSDATMUA(MADSDATMUA,MAVACXIN,SOLUONG) VALUES (3,5,8)
GO
-- Thêm dữ liệu: CHINHANH
INSERT INTO CHINHANH(TENCN, DIACHICN) VALUES (N'CN Hoàng Văn Thụ', N'198 Hoàng Văn Thụ, P.9, Q.Phú Nhuận, TP.HCM')
INSERT INTO CHINHANH(TENCN, DIACHICN) VALUES (N'CN Lê Đại Hành', N'Lầu 1, Trung tâm thương mại Flemington, Cao ốc Bảo Gia, 184 Lê Đại Hành, P.15, Q.11, TP.HCM')
INSERT INTO CHINHANH(TENCN, DIACHICN) VALUES (N'CN Bình Tân', N'Số 179 Vành Đai Trong, P.Bình Trị Đông B, Q.Bình Tân, TP.HCM')
INSERT INTO CHINHANH(TENCN, DIACHICN) VALUES (N'CN Tân Phú', N'Tầng 1, toà nhà Oriental Plaza, 685 Âu Cơ, P.Tân Thành, Q.Tân Phú, TP.HCM')
GO
-- Thêm dữ liệu: KHACHHANG
INSERT INTO KHACHHANG(HOTENKH,DIACHIKH, GIOITINHKH, EMAILKH, CMNDKH, NGAYSINHKH, SDTKH, USERNAME, PASS) 
VALUES (N'Trần Thị Huế Minh', N'51 Nguyễn Bá Tòng, P11, Tân Bình, TP.HCM', N'Nữ', 'tranthihueminh14112001@gmail.com','072301003501', 11/14/2001, '0912277533', 'minhhue', 'minhhue')
INSERT INTO KHACHHANG(HOTENKH,DIACHIKH, GIOITINHKH, EMAILKH, CMNDKH, NGAYSINHKH, SDTKH, USERNAME, PASS) 
VALUES (N'Lê Yến Nhi', N'73 Trần Hưng Đạo, P.Đa Kao, Q.1', N'Nữ', 'lynhi@gmail.com','0283782382', 19/2/2001, '0283828221', 'yennhile', 'yennhile')
GO

-- Thêm dữ liệu: NHANVIEN
INSERT INTO NHANVIEN(HOTEN, EMAIL, SDT, MACN, USERNAME, PASS) 
VALUES (N'Du Mỹ', 'longmydu@gmail.com', '0123456789', 1, 'longmydu', 'longmydu')
INSERT INTO NHANVIEN(HOTEN, EMAIL, SDT, MACN, USERNAME, PASS) 
VALUES (N'Duy Khánh', 'khanhduy@gmail.com', '0353456789', 2, 'khanhduy', 'khanhduy')
GO

-- Thêm dữ liệu: PHIEU_DATMUA
INSERT INTO PHIEU_DATMUA(NGAYMUA,MAKH) VALUES (04/17/2022, 1)
GO

-- Thêm dữ liệu: CHITIET_PHIEUDATMUA

GO

-- Thêm dữ liệu: GOIVACXIN
INSERT GOIVACXIN (TENGOIVACXIN, MOTA, GIABAN, SLTiem) VALUES (N'Gói trẻ em', N'Gói vắc xin đầy đủ cho trẻ em', 15000000, 5)
INSERT GOIVACXIN (TENGOIVACXIN, MOTA, GIABAN, SLTiem) VALUES (N'Gói Moderna', N'Gói bao gồm 2 lần tiêm vắc xin Moderna phòng COVID19', 600000, 2)
INSERT GOIVACXIN (TENGOIVACXIN, MOTA, GIABAN, SLTiem) VALUES (N'Gói Pfizer', N'Gói bao gồm 2 lần tiêm vắc xin Pfizer phòng COVID19', 400000, 2)
INSERT GOIVACXIN (TENGOIVACXIN, MOTA, GIABAN, SLTiem) VALUES (N'Gói nhắc lại thủy đậu', N'Gói dành cho người lớn muốn tiêm nhắc lại phòng bệnh thủy đậu', 1000000, 2)
INSERT GOIVACXIN (TENGOIVACXIN, MOTA, GIABAN, SLTiem) VALUES (N'Gói nhắc lại ngừa uốn ván', N'Gói dành cho người lớn muốn tiêm nhắc lại phòng bệnh uốn ván', 1000000, 3)
INSERT GOIVACXIN (TENGOIVACXIN, MOTA, GIABAN, SLTiem) VALUES (N'Gói nhắc lại ngừa dại', N'Gói dành cho người lớn muốn tiêm nhắc lại phòng bệnh dại', 388000, 5)
GO

-- Thêm dữ liệu: CTGOIVACXIN
INSERT CTGOIVACXIN (MAGOIVACXIN, MAVACXIN) VALUES (1, 4)
INSERT CTGOIVACXIN (MAGOIVACXIN, MAVACXIN) VALUES (1, 6)
INSERT CTGOIVACXIN (MAGOIVACXIN, MAVACXIN) VALUES (1, 8)
INSERT CTGOIVACXIN (MAGOIVACXIN, MAVACXIN) VALUES (2, 1)
INSERT CTGOIVACXIN (MAGOIVACXIN, MAVACXIN) VALUES (3, 2)
INSERT CTGOIVACXIN (MAGOIVACXIN, MAVACXIN) VALUES (4, 3)
INSERT CTGOIVACXIN (MAGOIVACXIN, MAVACXIN) VALUES (5, 4)
INSERT CTGOIVACXIN (MAGOIVACXIN, MAVACXIN) VALUES (6, 5)
GO

-- Thêm dữ liệu: PHIEUDANGKYTIEMCHUNG
INSERT PHIEUDANGKYTIEMCHUNG (MAKH, HOTENNT, CMNDNT,	DIACHINT,NGSINHNT, GIOITINHNT, SDTNT, QUANHE, THOIGIANDK, TINHTRANG)
VALUES (1, N'Long Mỹ Du', '012345678901', N'227 Nguyễn Văn Cừ, P.6, Q.5, TP.HCM', '12-02-2001', N'Nữ', '0123456789', N'Bạn', '04-25-2022', N'Chờ duyệt')

INSERT PHIEUDANGKYTIEMCHUNG (MAKH, THOIGIANDK, TINHTRANG)
VALUES (2, '05-03-2022', N'Đã duyệt')
GO

-- Thêm dữ liệu: CTPHIEUDKTC
INSERT CTPHIEUDKTC (MAPDK, MAGOIVACXIN, LANTIEM, MACN) VALUES (1, 5, 1, 1)
INSERT CTPHIEUDKTC (MAPDK, MAGOIVACXIN, LANTIEM, MACN) VALUES (1, 5, 2, 1)
INSERT CTPHIEUDKTC (MAPDK, MAGOIVACXIN, LANTIEM, MACN) VALUES (1, 5, 3, 1)

INSERT CTPHIEUDKTC (MAPDK, MAGOIVACXIN, LANTIEM, MACN) VALUES (2, 1, 1, 1)
INSERT CTPHIEUDKTC (MAPDK, MAGOIVACXIN, LANTIEM, MACN) VALUES (2, 1, 2, 2)
INSERT CTPHIEUDKTC (MAPDK, MAGOIVACXIN, LANTIEM, MACN) VALUES (2, 1, 3, 3)
INSERT CTPHIEUDKTC (MAPDK, MAGOIVACXIN, LANTIEM, MACN) VALUES (2, 1, 4, 3)
INSERT CTPHIEUDKTC (MAPDK, MAGOIVACXIN, LANTIEM, MACN) VALUES (2, 1, 5, 3)
GO



-- Nháp 
--SELECT * FROM PHIEU_DATMUA
--SELECT * FROM CHITIET_PHIEUDATMUA

--select * from GOIVACXIN
--select * from PHIEUDANGKYTIEMCHUNG

--select * from CTPHIEUDKTC where MAPDK = 27
--select * from VACXIN
--INSERT INTO LICHRANH VALUES (1, "2022-04-11", 1), (1, "2022-04-12", 2);

--select * from LICHRANH

--Select * from CHINHANH

--select * from KHACHHANG
--SELECT * FROM NHANVIEN
----Select TENCN from CHINHANH

select * from KHACHHANG where username = 'minhhue';

--select * from VACXINNGOAI;
UPDATE PHIEUDANGKYTIEMCHUNG SET TINHTRANG = N'Chờ duyệt' WHERE MaPDK = 1
