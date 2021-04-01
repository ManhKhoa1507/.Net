CREATE DATABASE QLSV;

CREATE TABLE SINHVIEN(
	Mssv char(5),
	Ten char(20),
	SoDienThoai char(20),
	DiemToan float,
	DiemVan float,
	DiemTrungBinh float,
);

DROP TABLE SINHVIEN;

INSERT INTO SINHVIEN(Mssv,Ten,SoDienThoai,DiemToan, DiemVan, DiemTrungBinh) 
VALUES ('98532','ABC','023923',8,9,7.5)

SELECT * FROM SINHVIEN