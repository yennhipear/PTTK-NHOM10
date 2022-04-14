--Môn: Phân tích thiết kế hệ thống thông tin
--Đồ án thực hành
--Nhóm: 10

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
	HANGVACXIN nvarchar(50),
	MOTA nvarchar(500),
	SLTON int
)

GO

INSERT INTO VACXIN(TENVACXIN, LOAIVACXIN, HANGVACXIN, MOTA, SLTON)
VALUES		
('Moderna', 'mRNA', 'ModernaTX, Inc', N'Số mũi tiêm: 2 liều trong loạt tiêm chính, cách nhau 4-8 tuần.
Những người từ 18 tuổi trở lên bị suy giảm miễn dịch vừa hoặc nặng nên tiêm liều thứ ba ít nhất 4 tuần sau liều thứ hai.', 200),
('Pfizer-BioNTech', 'mRNA', N'Pfizer, Inc. và BioNTech', N'Số mũi tiêm: 2 liều trong loạt tiêm chính, cách nhau 3-8 tuần.
Những người từ 5 tuổi trở lên bị suy giảm miễn dịch vừa hoặc nặng nên tiêm liều thứ ba ít nhất 4 tuần sau liều thứ hai.', 500)