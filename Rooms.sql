USE [school]
GO

/****** Object:  Table [dbo].[Rooms]    Script Date: 19.06.2017 15:21:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rooms](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
	[TableCount] [int] NOT NULL,
	[IsDigit] [bit] NOT NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_Classes] FOREIGN KEY([ID])
REFERENCES [dbo].[Classes] ([RoomID])
GO

ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Rooms_Classes]
GO

