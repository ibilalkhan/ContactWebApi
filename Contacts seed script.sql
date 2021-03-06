USE [ContactDb]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 8/27/2021 2:25:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Address] [varchar](200) NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Contact] ON 

INSERT [dbo].[Contact] ([Id], [FirstName], [LastName], [Phone], [Address]) VALUES (1, N'Bilal', N'Khan', N'9516604433', N'2415 Hemingway Ln, Roswell, GA')
INSERT [dbo].[Contact] ([Id], [FirstName], [LastName], [Phone], [Address]) VALUES (2, N'John', N'Doe', N'9516604422', N'2272 Hemingway Ln, Roswell, GA')
INSERT [dbo].[Contact] ([Id], [FirstName], [LastName], [Phone], [Address]) VALUES (3, N'Alan', N'Diaz', N'9516604411', N'1727 Hemingway Ln, Roswell, GA')
SET IDENTITY_INSERT [dbo].[Contact] OFF
