CREATE TABLE [dbo].[Patient] (
    [PatientId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50)  NOT NULL,
    [Surname]   VARCHAR (50)  NOT NULL,
    [Address]   VARCHAR (250) NOT NULL,
    [Phone]     VARCHAR (20)  NOT NULL,
    [Email]     VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED ([PatientId] ASC)
);

