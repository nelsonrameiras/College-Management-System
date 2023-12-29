CREATE TABLE [dbo].[UsersLogin]
(
	[uId] INT NOT NULL Identity(1,1) PRIMARY KEY,
	[username] varchar(150) NOT NULL,
	[password] varchar(150) NOT NULL,
	[fullName] varchar(250) NOT NULL
)
