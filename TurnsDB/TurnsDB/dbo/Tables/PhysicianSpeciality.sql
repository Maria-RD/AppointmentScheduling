CREATE TABLE [dbo].[PhysicianSpeciality] (
    [PhysicianId]  INT NOT NULL,
    [SpecialityId] INT NOT NULL,
    CONSTRAINT [PK_PhysicianSpeciality] PRIMARY KEY CLUSTERED ([PhysicianId] ASC, [SpecialityId] ASC),
    CONSTRAINT [FK_PhysicianSpeciality_Physician_PhysicianId] FOREIGN KEY ([PhysicianId]) REFERENCES [dbo].[Physician] ([PhysicianId]) ON DELETE CASCADE,
    CONSTRAINT [FK_PhysicianSpeciality_Speciality_SpecialityId] FOREIGN KEY ([SpecialityId]) REFERENCES [dbo].[Speciality] ([SpecialityId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_PhysicianSpeciality_SpecialityId]
    ON [dbo].[PhysicianSpeciality]([SpecialityId] ASC);

