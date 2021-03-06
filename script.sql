USE [ceylon_petroleum]
GO
/****** Object:  Table [dbo].[Daily_trans]    Script Date: 5/23/2021 12:59:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Daily_trans](
	[Date] [date] NULL,
	[Month] [varchar](50) NULL,
	[Tripe] [varchar](50) NULL,
	[Browser_type] [varchar](50) NULL,
	[Low_Km] [float] NULL,
	[Up_Km] [float] NULL,
	[Net_Amount] [float] NULL,
	[Vehicel_id] [varchar](50) NULL,
	[Transaction_Id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[driver_sal]    Script Date: 5/23/2021 12:59:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[driver_sal](
	[employee_id] [varchar](50) NULL,
	[open_date] [varchar](50) NULL,
	[end_date] [varchar](50) NULL,
	[commission] [int] NULL,
	[advance] [int] NULL,
	[salary_payable] [float] NULL,
	[Index_no] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee_details]    Script Date: 5/23/2021 12:59:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee_details](
	[F_name] [varchar](50) NULL,
	[Job_Start_date] [varchar](50) NULL,
	[Employee_Id] [varchar](50) NULL,
	[NIC] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Mobile_No] [int] NULL,
	[Gender] [varchar](50) NULL,
	[DOB] [varchar](50) NULL,
	[Job_Title] [varchar](50) NULL,
	[Index_No] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[expenditure]    Script Date: 5/23/2021 12:59:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[expenditure](
	[Exp_type] [varchar](50) NULL,
	[Vehicle_Id] [varchar](50) NULL,
	[Date] [varchar](50) NULL,
	[Amount] [int] NULL,
	[Index_No] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[helper_sal]    Script Date: 5/23/2021 12:59:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[helper_sal](
	[employee_id] [varchar](50) NULL,
	[open_date] [varchar](50) NULL,
	[end_date] [varchar](50) NULL,
	[commission] [varchar](20) NULL,
	[advance] [int] NULL,
	[salary_payable] [float] NULL,
	[Total] [int] NULL,
	[Index_No] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[monthlytrans]    Script Date: 5/23/2021 12:59:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[monthlytrans](
	[Month] [varchar](50) NOT NULL,
	[Year] [varchar](50) NOT NULL,
	[Income] [float] NOT NULL,
	[Date] [varchar](50) NOT NULL,
	[Index_No] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profit]    Script Date: 5/23/2021 12:59:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profit](
	[Index_No] [int] NULL,
	[Year] [int] NULL,
	[Month] [varchar](50) NULL,
	[Income] [float] NULL,
	[Mon_Sal_Expe] [float] NULL,
	[Net_Income] [float] NULL,
	[Profit] [float] NULL,
	[Total_Expe] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vehicle_details]    Script Date: 5/23/2021 12:59:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vehicle_details](
	[VehicleID] [nvarchar](50) NOT NULL,
	[TyreSerialNo1] [varchar](30) NULL,
	[StartDate] [varchar](30) NULL,
	[NoOfTyres] [varchar](20) NULL,
	[AssignDriverID] [nvarchar](50) NOT NULL,
	[TyreSerialNo2] [varchar](30) NULL,
	[TyreSerialNo3] [varchar](50) NULL,
	[Browser_Type] [varchar](50) NULL,
	[Index_No] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_vehicle_details] PRIMARY KEY CLUSTERED 
(
	[VehicleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
