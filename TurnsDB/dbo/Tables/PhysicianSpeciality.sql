CREATE TABLE [dbo].[PhysicianSpeciality](
	[PhysicianId] [int] NOT NULL,
	[SpecialityId] [int] NOT NULL,
 CONSTRAINT [PK_PhysicianSpeciality] PRIMARY KEY CLUSTERED 
(
	[PhysicianId] ASC,
	[SpecialityId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PhysicianSpeciality]  WITH CHECK ADD  CONSTRAINT [FK_PhysicianSpeciality_Physician_PhysicianId] FOREIGN KEY([PhysicianId])
REFERENCES [dbo].[Physician] ([PhysicianId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[PhysicianSpeciality] CHECK CONSTRAINT [FK_PhysicianSpeciality_Physician_PhysicianId]
GO

ALTER TABLE [dbo].[PhysicianSpeciality]  WITH CHECK ADD  CONSTRAINT [FK_PhysicianSpeciality_Speciality_SpecialityId] FOREIGN KEY([SpecialityId])
REFERENCES [dbo].[Speciality] ([SpecialityId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[PhysicianSpeciality] CHECK CONSTRAINT [FK_PhysicianSpeciality_Speciality_SpecialityId]
GO


