 USE [HRapp]
GO
/****** Object:  Table [dbo].[dbo_admin]    Script Date: 5/18/2022 12:43:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbo_admin](
	[admin] [nchar](30) NOT NULL,
	[password] [nchar](30) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleave]    Script Date: 5/18/2022 12:43:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleave](
	[leave_id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [int] NOT NULL,
	[name] [nchar](10) NOT NULL,
	[lastname] [nchar](10) NOT NULL,
	[cin] [nchar](10) NOT NULL,
	[type] [nchar](30) NOT NULL,
	[request_date] [date] NOT NULL,
	[start_date] [date] NOT NULL,
	[end_date] [date] NOT NULL,
 CONSTRAINT [PK_empleave] PRIMARY KEY CLUSTERED 
(
	[leave_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 5/18/2022 12:43:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[ename] [nchar](10) NOT NULL,
	[lastname] [nchar](10) NOT NULL,
	[age] [int] NOT NULL,
	[sex] [nchar](10) NOT NULL,
	[dob] [date] NOT NULL,
	[nationality] [nchar](15) NOT NULL,
	[cin] [nchar](10) NOT NULL,
	[phone] [nchar](15) NOT NULL,
	[email] [nchar](30) NOT NULL,
	[address] [nchar](30) NULL,
	[family_status] [nchar](30) NOT NULL,
	[cnss_id] [nchar](30) NOT NULL,
	[position] [nchar](30) NOT NULL,
	[company_name] [nchar](30) NOT NULL,
	[hiring_date] [date] NOT NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[empleave]  WITH CHECK ADD  CONSTRAINT [FK_empleave_employee] FOREIGN KEY([employee_id])
REFERENCES [dbo].[employee] ([employee_id])
GO
ALTER TABLE [dbo].[empleave] CHECK CONSTRAINT [FK_empleave_employee]
GO
