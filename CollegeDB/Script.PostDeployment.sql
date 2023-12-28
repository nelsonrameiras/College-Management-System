USE [CollegeDB]
GO

INSERT INTO [dbo].[NewAdmission]
           ([fullName]
           ,[motherName]
           ,[gender]
           ,[dateOfBirth]
           ,[mobileNumber]
           ,[email]
           ,[semester]
           ,[programmingLanguage]
           ,[schoolName]
           ,[duration]
           ,[addresss])
     VALUES
           ('Demo User',
		   'Mother Demo',
		   'Male',
		   '21 de dezembro de 1975',
           900000000,
           'demo@demo.at',
           '3rd Semester',
           'R',
           'AEMS',
           '2020-2023',
           'R. Mário Sacramento')
GO