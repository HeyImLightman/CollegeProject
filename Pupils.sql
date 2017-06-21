USE [school]
GO

/****** Object:  Table [dbo].[Pupils]    Script Date: 21.06.2017 22:19:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pupils](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[ClassID] [int] NOT NULL,
	[Number] [nvarchar](50) NULL,
	[Adress] [nvarchar](50) NULL,
	[DOB] [datetime] NULL,
 CONSTRAINT [PK_Ucheniks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

