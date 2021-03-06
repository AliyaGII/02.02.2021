USE [AlifAcademy]
GO
/****** Object:  Table [dbo].[Animals]    Script Date: 03.02.2021 19:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animals](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Age] [int] NOT NULL,
	[Breed] [nvarchar](100) NOT NULL,
	[Color_Fur] [nvarchar](100) NOT NULL,
	[Action1] [nvarchar](100) NOT NULL,
	[Action2] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Animals] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
