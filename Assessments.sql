USE [school]
GO

/****** Object:  Table [dbo].[Assessments]    Script Date: 21.06.2017 22:18:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Assessments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NamePupil] [nvarchar](50) NOT NULL,
	[PupilsID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[Subject] [nvarchar](50) NOT NULL,
	[Attendance] [bit] NULL,
	[Assessment] [int] NULL,
 CONSTRAINT [PK_Assessments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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

