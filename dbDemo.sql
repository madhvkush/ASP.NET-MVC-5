USE [dbDemo]
GO
/****** Object:  Table [dbo].[tblStudent]    Script Date: 10/26/2015 13:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblStudent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](200) NULL,
	[course] [varchar](200) NULL,
	[age] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblStudent] ON
INSERT [dbo].[tblStudent] ([Id], [name], [course], [age]) VALUES (1, N'Madhv', N'B.Tech', 23)
INSERT [dbo].[tblStudent] ([Id], [name], [course], [age]) VALUES (2, N'John', N'B.Tech', 25)
INSERT [dbo].[tblStudent] ([Id], [name], [course], [age]) VALUES (3, N'Miler', N'Biology', 22)
INSERT [dbo].[tblStudent] ([Id], [name], [course], [age]) VALUES (4, N'Kally', N'B.E', 23)
SET IDENTITY_INSERT [dbo].[tblStudent] OFF
