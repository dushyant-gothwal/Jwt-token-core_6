USE [MyDbAPI]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16-06-2024 17:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 16-06-2024 17:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Position] [nvarchar](max) NOT NULL,
	[Company] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 16-06-2024 17:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Age] [int] NULL,
	[Standard] [int] NOT NULL,
	[FatherName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 16-06-2024 17:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240609081640_First', N'6.0.31')
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 
GO
INSERT [dbo].[Employees] ([Id], [Name], [Position], [Company]) VALUES (1, N'Ravi', N'Supervisor', N'Janpack')
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 
GO
INSERT [dbo].[Students] ([ID], [StudentName], [Gender], [Age], [Standard], [FatherName]) VALUES (1, N'John', N'Male', 18, 12, N'Doe')
GO
INSERT [dbo].[Students] ([ID], [StudentName], [Gender], [Age], [Standard], [FatherName]) VALUES (2, N'Jan', N'Male', 19, 11, N'Smith')
GO
INSERT [dbo].[Students] ([ID], [StudentName], [Gender], [Age], [Standard], [FatherName]) VALUES (3, N'Alice', N'Female', 20, 9, N'Johnson')
GO
INSERT [dbo].[Students] ([ID], [StudentName], [Gender], [Age], [Standard], [FatherName]) VALUES (4, N'Bob', N'Male', 18, 8, N'Williams')
GO
INSERT [dbo].[Students] ([ID], [StudentName], [Gender], [Age], [Standard], [FatherName]) VALUES (5, N'Ravi', N'Male', 18, 12, N'Kishan')
GO
INSERT [dbo].[Students] ([ID], [StudentName], [Gender], [Age], [Standard], [FatherName]) VALUES (6, N'Sohan', N'Male', 16, 8, N'Rajvir')
GO
INSERT [dbo].[Students] ([ID], [StudentName], [Gender], [Age], [Standard], [FatherName]) VALUES (7, N'nonu', N'male', 18, 12, N'Munish Vij')
GO
INSERT [dbo].[Students] ([ID], [StudentName], [Gender], [Age], [Standard], [FatherName]) VALUES (9, N'Ram', N'male', 19, 11, N'kishan singh')
GO
INSERT [dbo].[Students] ([ID], [StudentName], [Gender], [Age], [Standard], [FatherName]) VALUES (10, N'camila', N'female', 18, 11, N'jhon wick')
GO
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
INSERT [dbo].[Users] ([Id], [Name], [Email], [Password]) VALUES (N'1', N'1', N'1', N'1')
GO
INSERT [dbo].[Users] ([Id], [Name], [Email], [Password]) VALUES (N'string', N'Ram', N'Ram@gmail.com', N'123321')
GO
