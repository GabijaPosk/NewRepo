CREATE TABLE [dbo].[StudentTBL2] (
    [Stdid]     INT          IDENTITY (1, 1) NOT NULL,
    [StVardas]  VARCHAR (50) NOT NULL,
    [StPavardė] VARCHAR (50) NOT NULL,
    [StGrupė]   VARCHAR (50) NOT NULL,
    [StMetai]   DATE         NULL,
    [StDalykas] VARCHAR (50) NOT NULL,
    [StPažymys] INT          NULL,
    PRIMARY KEY CLUSTERED ([Stdid] ASC)
);

