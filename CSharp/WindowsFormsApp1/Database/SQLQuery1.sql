USE master
GO

DROP DATABASE IF EXISTS C2109I1
CREATE DATABASE C2109I1
GO

USE C2109I1
GO

DROP TABLE IF EXISTS Student
CREATE TABLE Student
(
	Id int primary key identity,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Gender tinyint,
	DOB date
)
GO

INSERT INTO Student(FirstName, LastName, Gender, DOB)
VALUES (N'Nhật', N'Hoàng', 1, '2003-09-28')
GO 10
