USE [school]
GO

/****** Object:  Table [dbo].[Teachers]    Script Date: 11.06.2017 21:45:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Teachers](
	[ID] [decimal](9, 0) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[Number] [nvarchar](50) NULL,
	[Adress] [nvarchar](50) NULL,
	[DOB] [datetime] NULL,
	[SubjectID] [decimal](9, 0) NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Subjects] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([Id])
GO

ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_Subjects]
GO

