USE [school]
GO

/****** Object:  Table [dbo].[Rooms]    Script Date: 11.06.2017 21:45:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rooms](
	[ID] [decimal](9, 0) NOT NULL,
	[Number] [decimal](9, 0) NOT NULL,
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

