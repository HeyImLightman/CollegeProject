USE [school]
GO

/****** Object:  Table [dbo].[Ucheniks]    Script Date: 11.06.2017 21:46:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ucheniks](
	[ID] [decimal](9, 0) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[ClassID] [decimal](9, 0) NOT NULL,
	[Number] [nvarchar](50) NULL,
	[Adress] [nvarchar](50) NULL,
	[DOB] [datetime] NULL,
 CONSTRAINT [PK_Ucheniks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Ucheniks]  WITH CHECK ADD  CONSTRAINT [FK_Ucheniks_Classes] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Classes] ([ID])
GO

ALTER TABLE [dbo].[Ucheniks] CHECK CONSTRAINT [FK_Ucheniks_Classes]
GO

