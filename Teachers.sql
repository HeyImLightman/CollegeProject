USE [school]
GO

/****** Object:  Table [dbo].[Teachers]    Script Date: 19.06.2017 15:21:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Teachers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[Number] [nvarchar](50) NULL,
	[Adress] [nvarchar](50) NULL,
	[DOB] [datetime] NULL,
	[SubjectName] [nvarchar](50) NOT NULL,
	[SubjectID] [int] NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Subjects] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([ID])
GO

ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_Subjects]
GO

