﻿CREATE TABLE [dbo].[Fees]
(
	fid INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	NAID INT NOT NULL,
	fees INT NOT NULL
)