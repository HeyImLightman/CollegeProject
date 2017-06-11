USE [school]
GO

/****** Object:  Table [dbo].[Lessens]    Script Date: 11.06.2017 21:44:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Lessens](
	[ID] [decimal](9, 0) NOT NULL,
	[TeacherID] [decimal](9, 0) NOT NULL,
	[ClassID] [decimal](9, 0) NOT NULL,
 CONSTRAINT [PK_Lessens] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Lessens]  WITH CHECK ADD  CONSTRAINT [FK_Lessens_Classes] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Classes] ([ID])
GO

ALTER TABLE [dbo].[Lessens] CHECK CONSTRAINT [FK_Lessens_Classes]
GO

ALTER TABLE [dbo].[Lessens]  WITH CHECK ADD  CONSTRAINT [FK_Lessens_Teachers] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teachers] ([ID])
GO

ALTER TABLE [dbo].[Lessens] CHECK CONSTRAINT [FK_Lessens_Teachers]
GO

