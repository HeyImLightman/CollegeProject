USE [school]
GO

/****** Object:  Table [dbo].[Assessments]    Script Date: 19.06.2017 15:20:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Assessments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[PupilsID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[Attendance] [bit] NULL,
	[Assessment] [int] NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Assessments]  WITH CHECK ADD  CONSTRAINT [FK_Assessments_Pupils] FOREIGN KEY([PupilsID])
REFERENCES [dbo].[Pupils] ([ID])
GO

ALTER TABLE [dbo].[Assessments] CHECK CONSTRAINT [FK_Assessments_Pupils]
GO

ALTER TABLE [dbo].[Assessments]  WITH CHECK ADD  CONSTRAINT [FK_Assessments_Subjects] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([ID])
GO

ALTER TABLE [dbo].[Assessments] CHECK CONSTRAINT [FK_Assessments_Subjects]
GO

ALTER TABLE [dbo].[Assessments]  WITH CHECK ADD  CONSTRAINT [CK_Assessments] CHECK  (([Assessment]>(1) AND [Assessment]<(6)))
GO

ALTER TABLE [dbo].[Assessments] CHECK CONSTRAINT [CK_Assessments]
GO

