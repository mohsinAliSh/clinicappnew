USE [master]
GO
/****** Object:  Database [ClinicDB]    Script Date: 12/12/2021 11:11:34 am ******/
CREATE DATABASE [ClinicDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ClinicDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ClinicDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ClinicDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ClinicDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ClinicDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClinicDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ClinicDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ClinicDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ClinicDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ClinicDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ClinicDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ClinicDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ClinicDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ClinicDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ClinicDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ClinicDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ClinicDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ClinicDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ClinicDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ClinicDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ClinicDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ClinicDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ClinicDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ClinicDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ClinicDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ClinicDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ClinicDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ClinicDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ClinicDB] SET RECOVERY FULL 
GO
ALTER DATABASE [ClinicDB] SET  MULTI_USER 
GO
ALTER DATABASE [ClinicDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ClinicDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ClinicDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ClinicDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ClinicDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ClinicDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ClinicDB', N'ON'
GO
ALTER DATABASE [ClinicDB] SET QUERY_STORE = OFF
GO
USE [ClinicDB]
GO
/****** Object:  Table [dbo].[ClinicExpense]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClinicExpense](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseCategory] [varchar](100) NULL,
	[ExpenseDescription] [varchar](200) NULL,
	[ExpenseAmount] [decimal](18, 2) NULL,
	[ExpenseDate] [datetime] NULL,
 CONSTRAINT [PK_ClinicExpense] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClinicStaff]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClinicStaff](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StaffName] [varchar](100) NOT NULL,
	[StaffContact] [varchar](15) NULL,
	[StaffNic] [varchar](20) NULL,
	[StaffAddress] [varchar](200) NULL,
	[StaffType] [varchar](20) NOT NULL,
	[DateModified] [datetime] NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_ClinicStaff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonationEntry]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonationEntry](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DonatorID] [int] NOT NULL,
	[DonationAmount] [decimal](18, 2) NOT NULL,
	[DonationDate] [datetime] NULL,
	[Remarks] [varchar](200) NULL,
	[DonatorType] [varchar](100) NULL,
 CONSTRAINT [PK_DonationEntry] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donator]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donator](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DonatorName] [varchar](100) NOT NULL,
	[DonatorNic] [varchar](20) NULL,
	[DonatorAddress] [varchar](200) NULL,
	[DateModified] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpenseCategory]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpenseCategory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseCategory] [varchar](100) NULL,
 CONSTRAINT [PK_ExpenseCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ketsData]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ketsData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ketsQuantity] [int] NOT NULL,
	[ketsDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[ID] [int] IDENTITY(1001,1) NOT NULL,
	[PatientName] [varchar](100) NOT NULL,
	[PNIC] [varchar](20) NOT NULL,
	[PAddress] [varchar](200) NULL,
	[PCity] [varchar](50) NULL,
	[PCountry] [varchar](50) NULL,
	[PContact] [varchar](15) NULL,
	[PEmergencyContact] [varchar](15) NULL,
	[PGender] [varchar](10) NULL,
	[PMaritulStatus] [varchar](20) NULL,
	[PEmail] [varchar](50) NULL,
	[PDob] [datetime] NULL,
	[Active] [bit] NULL,
	[DateCreated] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientFeeEntry]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientFeeEntry](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[DoctorFee] [decimal](18, 2) NULL,
	[ClinicalFee] [decimal](18, 2) NULL,
	[DonationAmount] [decimal](18, 2) NULL,
	[NetFee] [decimal](18, 2) NULL,
	[PaymentType] [int] NOT NULL,
	[KetType] [int] NOT NULL,
 CONSTRAINT [PK_PatientFeeEntry] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ClinicStaff] ADD  CONSTRAINT [DF_ClinicStaff_DateModified]  DEFAULT ('1900-01-01 00:00:00') FOR [DateModified]
GO
ALTER TABLE [dbo].[ClinicStaff] ADD  CONSTRAINT [DF_ClinicStaff_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[DonationEntry] ADD  CONSTRAINT [DF_Table_1_Amount]  DEFAULT ((0)) FOR [DonationAmount]
GO
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_PDob]  DEFAULT ('1900-01-01 00:00:00') FOR [PDob]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddDonation]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Shakir>
-- Create date: <27 OCT 2021>
-- Description:	<Add  patients list>
-- =============================================
CREATE PROCEDURE [dbo].[sp_AddDonation]
	-- Add the parameters for the stored procedure here
 @DonatorId int =1,
 @DonatorName varchar(100)
 ,@DonatorAddress varchar(100)
 ,@DonatorNic varchar(100)
 ,@DonatorDate datetime



AS
BEGIN
	

	set @DonatorDate=getdate() 
	INSERT INTO [dbo].[Donator]([DonatorName],[DonatorNic],[DonatorAddress],[DateModified])
     VALUES(@DonatorName,@DonatorNic,@DonatorAddress,@DonatorDate)

END

GO
/****** Object:  StoredProcedure [dbo].[sp_AddExpense]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Shakir>
-- Create date: <27 OCT 2021>
-- Description:	<Add  patients list>
-- =============================================
CREATE PROCEDURE [dbo].[sp_AddExpense]
	-- Add the parameters for the stored procedure here
@eId int=null,
@eCategory varchar(100)='',
@eDascription varchar(200),
@eAmount decimal,
@eDate datetime


AS
BEGIN
	


	begin
	INSERT INTO [dbo].[ClinicExpense]([ExpenseCategory],[ExpenseDescription],[ExpenseAmount],[ExpenseDate])VALUES(@eCategory,@eDascription,@eAmount,@eDate)
	end
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AddPatientRecord]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Shakir>
-- Create date: <27 OCT 2021>
-- Description:	<Add  patients list>
-- =============================================
CREATE PROCEDURE [dbo].[sp_AddPatientRecord]
	-- Add the parameters for the stored procedure here
@pId int=null
,@pName varchar(100)=''
,@pCnic varchar(20)=''
,@pAddress varchar(200)=''
,@pCity varchar(50)='Kohat'
,@pCountry varchar(50)='Pakistan'
,@pContact varchar(15)=''
,@pEConatct varchar(15)=''
,@pGender varchar(10)=''
,@pMaritulStatus varchar(20)=''
,@pEmail varchar(50)=''
,@pDob datetime
,@pActive bit
,@pDateCreated datetime,
@pModifiedDate datetime

AS
BEGIN

set @pDateCreated=GETDATE()
	
	INSERT INTO [dbo].[Patient]([PatientName],[PNIC],[PAddress],[PCity],[PCountry],[PContact],[PEmergencyContact],
	[PGender],[PMaritulStatus],[PEmail],[PDob],[Active],[DateCreated],[ModifiedDate])
	VALUES(@pName,@pCnic,@pAddress,@pCity,@pCountry,@pContact,@pEConatct,@pGender,@pMaritulStatus,
	@pEmail,@pDob,@pActive,@pDateCreated,@pModifiedDate)

	

	
	
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetCurrentMonthPatient]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Asim>
-- Create date: <6 May 2021>
-- Description:	<Get current month patients list>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetCurrentMonthPatient]
	-- Add the parameters for the stored procedure here
@month datetime=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

if (@month is not null)
	begin
	select ID,PatientName,PNIC,PAddress,PCity,PCountry,PContact,PEmergencyContact,PGender,PMaritulStatus,
	PEmail,PDob,Active,DateCreated,ModifiedDate from Patient where MONTH(DateCreated)=MONTH(@month) and  year(DateCreated)=year(@month)
	end
END

GO
/****** Object:  StoredProcedure [dbo].[spAddKets]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAddKets]
@id int = 1,
@addKets int

AS
begin
declare @kdate datetime 
set @kdate = GETDATE()

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT on;
	INSERT INTO [dbo].[ketsData]([ketsQuantity],[ketsDate])
     VALUES(@addKets,@kdate)

END
GO
/****** Object:  StoredProcedure [dbo].[spGet_expanse]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGet_expanse]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from dbo.ClinicExpense
END
GO
/****** Object:  StoredProcedure [dbo].[spGetDonatorInfo]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetDonatorInfo]
AS
BEGIN

	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from dbo.Donator
END
GO
/****** Object:  StoredProcedure [dbo].[spGetKets]    Script Date: 12/12/2021 11:11:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetKets]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from dbo.ketsData
END
GO
USE [master]
GO
ALTER DATABASE [ClinicDB] SET  READ_WRITE 
GO
