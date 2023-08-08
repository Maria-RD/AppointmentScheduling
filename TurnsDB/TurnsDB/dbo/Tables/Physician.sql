CREATE TABLE [dbo].[Physician] (
    [PhysicianId]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (50)  NOT NULL,
    [Surname]          VARCHAR (50)  NOT NULL,
    [Address]          VARCHAR (250) NOT NULL,
    [Phone]            VARCHAR (20)  NOT NULL,
    [Email]            VARCHAR (100) NOT NULL,
    [OpeningHoursFrom] DATETIME2 (7) NOT NULL,
    [OpeningHoursTo]   DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_Physician] PRIMARY KEY CLUSTERED ([PhysicianId] ASC)
);

