CREATE TABLE [dbo].[Speciality] (
    [SpecialityId] INT           IDENTITY (1, 1) NOT NULL,
    [Description]  VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_Speciality] PRIMARY KEY CLUSTERED ([SpecialityId] ASC)
);

