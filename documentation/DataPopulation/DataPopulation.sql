-- 01. Create Database if not exists
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'TurnsDB')
BEGIN
    CREATE DATABASE TurnsDB;
END
GO

USE TurnsDB;
GO

-- 02. Create dbo.Speciality table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Speciality')
BEGIN
    CREATE TABLE dbo.Speciality (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        [Description] NVARCHAR(100) NOT NULL
    );
END
GO

-- 03. Create dbo.Patient table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Patient')
BEGIN
    CREATE TABLE dbo.Patient (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        [Name] NVARCHAR(100) NOT NULL,
        [Surname] NVARCHAR(100) NOT NULL,
        [Address] NVARCHAR(255),
        [Phone] NVARCHAR(50),
        [Email] NVARCHAR(100) UNIQUE
    );
END
GO

-- 04. Create dbo.Physician table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Physician')
BEGIN
    CREATE TABLE dbo.Physician (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        [Name] NVARCHAR(100) NOT NULL,
        [Surname] NVARCHAR(100) NOT NULL,
        [Address] NVARCHAR(255),
        [Phone] NVARCHAR(50),
        [Email] NVARCHAR(100) UNIQUE,
        [OpeningHoursFrom] DATETIME NOT NULL,
        [OpeningHoursTo] DATETIME NOT NULL
    );
END
GO

-- 05. Insert data into dbo.Speciality
IF NOT EXISTS (SELECT 1 FROM dbo.Speciality)
BEGIN
    INSERT INTO dbo.Speciality ([Description]) 
    VALUES ('Cardiologist'),('Dentist'),('Neurologist'),('Radiologist'),('Traumatologist');
END
GO

-- 06. Insert data into dbo.Patient
IF NOT EXISTS (SELECT 1 FROM dbo.Patient)
BEGIN
    INSERT INTO dbo.Patient([Name],[Surname],[Address],[Phone],[Email]) VALUES 
    ('John','Smith','132 Street','+12323232323','john.smith@email.com'),
    ('Ariana','Grande','801 Road','+13030303030303','ariana.grande@email.com'),
    ('Polly','Jones','123 Avenue','+19090909090','polly.jones@email.com'),
    ('Debbie','Harry','575 Street','+183838383838','debbie.harry@email.com'),
    ('Harry','Styles','345 Avenue','+14545454545','harry.styles@email.com'),
    ('Michelle','Obama','584 Road','+14646464646464','michelle.obama@email.com'),
    ('Will','Smith','789 Street','+162626262626','will.smith@email.com'),
    ('Margot','Robbie','405 Road','+1959595959595','margot.robbie@email.com'),
    ('Ken','Carson','112 Street','+17878787878','ken.carson@email.com'),
    ('Barbara','Roberts','112 Street','+1767676767676','barbara.roberts@email.com'),
    ('Dwayne','Johnson','840 Avenue','+1010101010101','dwayne.johnson@email.com'),
    ('Taylor','Swift','734 Road','+1484848484848','taylor.swift@email.com');
END
GO

-- 07. Insert data into dbo.Physician
IF NOT EXISTS (SELECT 1 FROM dbo.Physician)
BEGIN
    INSERT INTO dbo.Physician([Name],[Surname],[Address],[Phone],[Email],[OpeningHoursFrom],[OpeningHoursTo]) 
    VALUES
    ('Eric','Topol','132 Street','+12323232323','eric.topol@email.com', '2023-08-01 00:00:00', '2023-12-31 23:59:00'),
    ('Joseph','Ferrara','807 Avenue','+139393939393','joseph.ferrara@email.com', '2023-08-01 00:00:00', '2023-12-31 23:59:00'),
    ('Michael','Aaro','856 Road','+1202020202020','michael.aaro@email.com', '2023-08-01 00:00:00', '2023-12-31 23:59:00');
END
GO

-- 08. Select data to verify insertion
SELECT * FROM dbo.Speciality;
SELECT * FROM dbo.Patient;
SELECT * FROM dbo.Physician;
GO
