CREATE TABLE [dbo].[Fees] (
    [fid]  INT IDENTITY (1, 1) NOT NULL,
    [NAID] INT NOT NULL,
    [fees] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([fid] ASC)
);

