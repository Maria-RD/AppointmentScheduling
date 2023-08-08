USE TurnsDB

-- 01. dbo.Speciality table
INSERT INTO dbo.Speciality ([Description]) VALUES ('Cardiologist'),('Dentist'),('Neurologist'),('Radiologist'),('Traumatologist')
SELECT * FROM dbo.Speciality

-- 02. dbo.Patient table
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
('Taylor','Swift','734 Road','+1484848484848','taylor.swift@email.com')
SELECT * FROM dbo.Patient

-- 03. dbo.Physician table
INSERT INTO dbo.Physician([Name],[Surname],[Address],[Phone],[Email],[OpeningHoursFrom],[OpeningHoursTo]) VALUES
('Eric','Topol','132 Street','+12323232323','eric.topol@email.com', CONVERT(DATETIME,'2023-08-01 00:00:000',121),CONVERT(DATETIME,'2023-12-31 23:59:000',121)),
('Joseph','Ferrara','807 Avenue','+139393939393','joseph.ferrara@email.com', CONVERT(DATETIME,'2023-08-01 00:00:000',121),CONVERT(DATETIME,'2023-12-31 23:59:000',121)),
('Michael','Aaro','856 Road','+1202020202020','michael.aaro@email.com', CONVERT(DATETIME,'2023-08-01 00:00:000',121),CONVERT(DATETIME,'2023-12-31 23:59:000',121))
SELECT * FROM dbo.Physician