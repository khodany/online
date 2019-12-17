# online


/** on the web.cofg file change the conection string to target the server u are connectinh to **/
/****** Object:  Table [dbo].[BooleanQuestions]    Script Date: 2019/12/10 14:53:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BooleanQuestions](
	[Qid] [int] IDENTITY(1,1) NOT NULL,
	[Question] [varchar](50) NULL,
	[Option1] [bit] NULL,
	[Option2] [bit] NULL,
	[CorrectAnswer] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Qid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NumericalQuestions]    Script Date: 2019/12/10 14:53:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NumericalQuestions](
	[Qid] [int] IDENTITY(1,1) NOT NULL,
	[Question] [varchar](150) NULL,
	[Answer] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Qid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TextQuestions]    Script Date: 2019/12/10 14:53:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TextQuestions](
	[Qid] [int] IDENTITY(1,1) NOT NULL,
	[Question] [varchar](200) NULL,
	[Answer] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Qid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BooleanQuestions] ON 

INSERT [dbo].[BooleanQuestions] ([Qid], [Question], [Option1], [Option2], [CorrectAnswer]) VALUES (1, N'100 multiply by 2 is equal to 120', 0, 1, 0)
INSERT [dbo].[BooleanQuestions] ([Qid], [Question], [Option1], [Option2], [CorrectAnswer]) VALUES (2, N'Cyril Ramaphosa is RSA President', 0, 1, 1)
SET IDENTITY_INSERT [dbo].[BooleanQuestions] OFF
SET IDENTITY_INSERT [dbo].[NumericalQuestions] ON 

INSERT [dbo].[NumericalQuestions] ([Qid], [Question], [Answer]) VALUES (1, N'100 X 2', N'200')
INSERT [dbo].[NumericalQuestions] ([Qid], [Question], [Answer]) VALUES (2, N'2 / 2', N'1')
SET IDENTITY_INSERT [dbo].[NumericalQuestions] OFF
SET IDENTITY_INSERT [dbo].[TextQuestions] ON 

INSERT [dbo].[TextQuestions] ([Qid], [Question], [Answer]) VALUES (1, N'What is the past tense of the word ''Think''', N'THOUGHT')
INSERT [dbo].[TextQuestions] ([Qid], [Question], [Answer]) VALUES (2, N'What is the name of Miss Universe 2019', N'ZOZIBINI TUNZI')
SET IDENTITY_INSERT [dbo].[TextQuestions] OFF
