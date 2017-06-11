USE [school]
GO

/****** Object:  Table [dbo].[Classes]    Script Date: 11.06.2017 21:44:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Classes](
	[ID] [decimal](9, 0) NOT NULL,
	[Name] [nvarchar](4) NOT NULL,
	[RoomID] [decimal](9, 0) NOT NULL,
	[Sector] [nvarchar](3) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

