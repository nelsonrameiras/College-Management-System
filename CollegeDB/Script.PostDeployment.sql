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
           ('Demo Student',
		   'Mother Demo',
		   'Male',
		   '21 de dezembro de 1975',
           900000000,
           'demo@demo.at',
           '3rd Semester',
           'R',
           'AEMS',
           '2020-2023',
           'R. Mário Sacramento');

INSERT INTO [dbo].[Fees]
			([NAID],
			[fees])
		VALUES
			(1,
			10000);

INSERT INTO [dbo].[Teachers]
           ([fullName]
           ,[motherName]
           ,[gender]
           ,[dateOfBirth]
           ,[mobileNumber]
           ,[email]
           ,[semester]
           ,[programmingLanguage]
           ,[duration]
           ,[addresss])
     VALUES
           ('Demo Teacher',
		   'Mother Demo',
		   'Male',
		   '13 de abril de 1963',
           900000123,
           'demot@demo.at',
           '4th Semester',
           'Kotlin',
           '2021-2024',
           'R. Mário Sacramento');

INSERT INTO [dbo].[UsersLogin]
           ([username]
           ,[password]
           ,[fullName]
           )
     VALUES
           ('admin',
		   'admin',
		   'Demo User'
		   );
GO