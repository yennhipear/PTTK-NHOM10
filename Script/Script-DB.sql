--Môn: Phân tích thiết kế hệ thống thông tin
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
	GIABAN bigint
)

GO

CREATE TABLE KHACHHANG
(
	MAKH INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	HOTENKH NVARCHAR(100) NOT NULL,
	DIACHIKH NVARCHAR(100),
	GIOITINHKH NVARCHAR(4),
	CMNDKH NCHAR(12),
	NGAYSINHKH DATETIME,
	SDTKH NCHAR(10)
)
INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN)
VALUES		
('Moderna', 'mRNA', 'ModernaTX, Inc', 'COVID19', N'Số mũi tiêm: 2 liều trong loạt tiêm chính, cách nhau 4-8 tuần.
Những người từ 18 tuổi trở lên bị suy giảm miễn dịch vừa hoặc nặng nên tiêm liều thứ ba ít nhất 4 tuần sau liều thứ hai.', 200, 600000)

INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN)
VALUES
('Pfizer-BioNTech', 'mRNA', N'Pfizer, Inc. và BioNTech', 'COVID19', N'Số mũi tiêm: 2 liều trong loạt tiêm chính, cách nhau 3-8 tuần.
Những người từ 5 tuổi trở lên bị suy giảm miễn dịch vừa hoặc nặng nên tiêm liều thứ ba ít nhất 4 tuần sau liều thứ hai.', 500, 400000)

INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN)
VALUES
('Varivax', null, N'Merck Sharp & Dohme, Hoa Kỳ', N'Thủy đậu', N'Tiêm 2 liều 0.5mL/liều, mỗi liều cách nhau 4 - 8 tuần.', 70,  1000000)

INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN)
VALUES
('Tetanus', N'Giải độc tố', N'Sanofi Pasteur, Pháp', N'Uốn ván', N'Khi trẻ từ 2 - 4 tháng tuổi cần tiêm 03 mũi vắc-xin 5in1 (bao gồm bạch hầu, ho gà, uốn ván,bại liệt và viêm não do vi khuẩn HIB) hoặc 6 in1( bao gồm bạch hầu, ho gà , uốn ván, bại liệt , HiB và viêm gan B)
18 tháng tuổi trẻ sẽ được tiêm nhắc lại mũi vắc xin bạch hầu, ho gà, uốn ván ( 5 in 1 hoặc 6 in 1)
Sau khoảng thời gian từ 05 - 10 năm nên tiêm nhắc lại.', 400,  1000000)

INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN)
VALUES
('Verorab', null, N'Sanofi Pasteur, Pháp', N'Dại', N'Vắc xin Verorab được chỉ định tiêm phòng cho các đối tượng nguy cơ phơi nhiễm cao như:
Nhân viên làm phòng thí nghiệm, nghiên cứu, sản xuất liên quan đến virus dại. Với đối tượng này cứ mỗi 6 tháng làm chuẩn đoán huyết thanh 1 lần. Tiêm vắc xin nhắc lại khi định lượng kháng thể dưới ngưỡng bảo vệ 0,5IU/ml.', 100,  388000)

INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN)
VALUES
('Abhayrab', null, N'Human Biologigical Institute, Ấn Độ', N'Dại', N'Abhayrab giúp tạo miễn dịch chủ động chống lại virus dại cho cả người lớn và trẻ em, để dự phòng và điều trị sau khi bị phơi nhiễm (sau khi tiếp xúc với con vật bị dại hoặc nghi ngờ bị dại).
Abhayrab có thể sử dụng cho tất cả các lứa tuổi.', 200,  200000)

INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, NGUABENH, MOTA, SLTON, GIABAN)
VALUES
('mORCVAX', N'Bất hoạt', N'Vabiotech, Việt Nam', N'Tả', N'Cả người lớn và trẻ em đều uống liều 1,5ml.
Lịch cơ bản: Uống 2 liều, khoảng cách giữa 2 liều là 14 ngày. Thời gian bảo vệ khi uốn đủ 2 liều cơ bản là 24 tháng.
Uống nhắc lại: Trước mùa dịch tả, phác đồ uống nhắc lại vẫn là uống 2 liều và khoảng cách giữa 2 liều là 14 ngày.', 200,  200000)

--select * from VACXIN

CREATE TABLE LICHRANH
(
	MALICHRANH INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	MANHANVIEN INT NOT NULL,
	MATUAN INT NOT NULL,
	NGAY TINYINT NOT NULL CHECK (NGAY > -1 and NGAY < 6),
	CA TINYINT NOT NULL CHECK (CA > -1 and CA < 3)
)
GO
INSERT INTO LICHRANH VALUES (1, 1, 2, 1), (1, 1, 3, 2);

--select * from LICHRANH
