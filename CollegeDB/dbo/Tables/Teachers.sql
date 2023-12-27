CREATE TABLE [dbo].[Teachers] (
    [tid]                 INT           IDENTITY (1, 1) NOT NULL,
    [fullName]            VARCHAR (250) NOT NULL,
    [motherName]          VARCHAR (250) NOT NULL,
    [gender]              VARCHAR (10)  NOT NULL,
    [dateOfBirth]         VARCHAR (50)  NOT NULL,
    [mobileNumber]        BIGINT        NOT NULL,
    [email]               VARCHAR (150) NOT NULL,
    [semester]            VARCHAR (150) NOT NULL,
    [programmingLanguage] VARCHAR (150) NOT NULL,
    [duration]            VARCHAR (120) NOT NULL,
    [addresss]            VARCHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([tid] ASC)
);

