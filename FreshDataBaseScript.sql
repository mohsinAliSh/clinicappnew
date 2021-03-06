USE [master]
GO
/****** Object:  Database [ClinicDB]    Script Date: 29/12/2021 2:13:01 pm ******/
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
/****** Object:  Table [dbo].[ClinicExpense]    Script Date: 29/12/2021 2:13:01 pm ******/
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
	[ExpenseFrom] [int] NOT NULL,
 CONSTRAINT [PK_ClinicExpense] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClinicFund]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClinicFund](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clinicFundAmount] [decimal](18, 2) NOT NULL,
	[clinicFundDescription] [varchar](200) NULL,
	[clinicFundDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonationEntry]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonationEntry](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DonatorID] [int] NOT NULL,
	[DonatorType] [varchar](50) NULL,
	[DonationAmount] [int] NOT NULL,
	[Remarks] [varchar](200) NULL,
	[DonationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_DonationEntry] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donator]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donator](
	[DonatorName] [varchar](100) NOT NULL,
	[DonatorNic] [varchar](20) NULL,
	[DonatorAddress] [varchar](200) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ketsData]    Script Date: 29/12/2021 2:13:01 pm ******/
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
/****** Object:  Table [dbo].[Patient]    Script Date: 29/12/2021 2:13:01 pm ******/
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
/****** Object:  Table [dbo].[PatientFeeEntry]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientFeeEntry](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[EntryDate] [datetime] NULL,
	[ClinicalFee] [decimal](18, 2) NULL,
	[DonationAmount] [decimal](18, 2) NULL,
	[NetFee] [decimal](18, 2) NULL,
	[PaymentType] [int] NOT NULL,
	[KetType] [int] NOT NULL,
	[KetAmount] [decimal](18, 2) NULL,
 CONSTRAINT [PK_PatientFeeEntryy] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZakatEntry]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZakatEntry](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ZakatAmount] [decimal](18, 2) NOT NULL,
	[ZakatDate] [datetime] NULL,
	[ZakaterRemarks] [varchar](200) NULL,
	[ZakaterType] [varchar](50) NULL,
	[ZakaterID] [int] NOT NULL,
 CONSTRAINT [PK_ZakatEntry] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zakater]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zakater](
	[ZakaterName] [varchar](50) NULL,
	[ZakaterNic] [varchar](50) NULL,
	[ZakaterAddress] [varchar](200) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Donator] ON 

INSERT [dbo].[Donator] ([DonatorName], [DonatorNic], [DonatorAddress], [ID]) VALUES (N'Clinic Expense', N'"', N'"', 1)
INSERT [dbo].[Donator] ([DonatorName], [DonatorNic], [DonatorAddress], [ID]) VALUES (N'Clinic Fund', N'"', N'"', 2)
SET IDENTITY_INSERT [dbo].[Donator] OFF
GO
SET IDENTITY_INSERT [dbo].[Zakater] ON 

INSERT [dbo].[Zakater] ([ZakaterName], [ZakaterNic], [ZakaterAddress], [ID]) VALUES (N'Patient Dialysis', N'"', N'"', 1)
SET IDENTITY_INSERT [dbo].[Zakater] OFF
GO
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_PDob]  DEFAULT ('1900-01-01 00:00:00') FOR [PDob]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddDonator]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Shakir>
-- Create date: <27 OCT 2021>
-- Description:	<Add  patients list>
-- =============================================
CREATE PROCEDURE [dbo].[sp_AddDonator]
	-- Add the parameters for the stored procedure here
@dId int = null,
@DonatorName varchar(100),
@DonatorAddress varchar(100),
@DonatorNic varchar(100),
@DonationAmount int,
@DonatorType varchar(50),
@DonationDate datetime,
@DonationRemarks varchar(200)



AS
BEGIN
if(@DonatorType='Clinic Fund')
	begin
	insert into dbo.ClinicFund(clinicFundAmount,clinicFundDate,clinicFundDescription)
	values (@DonationAmount,@DonationDate,'Given In Clinic')
	end
	if(@DonatorType='Bank Fund')
	begin
if(@dId=0)
begin
	INSERT INTO [dbo].[Donator]([DonatorName],[DonatorNic],[DonatorAddress])
     VALUES(@DonatorName,@DonatorNic,@DonatorAddress)
	 insert into dbo.DonationEntry(DonatorID,DonationAmount,DonatorType,DonationDate,Remarks)
	 values((SELECT IDENT_CURRENT('Donator')),@DonationAmount,@DonatorType,@DonationDate,@DonationRemarks)
	 end
	 else
	 begin
	 insert into dbo.DonationEntry(DonatorID,DonationAmount,DonatorType,DonationDate,Remarks)
	 values(@dId,@DonationAmount,@DonatorType,@DonationDate,@DonationRemarks)
	 end
	 end
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AddExpense]    Script Date: 29/12/2021 2:13:01 pm ******/
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
@eDate datetime,
@eExpenseFrom int


AS
BEGIN
	
	INSERT INTO [dbo].[ClinicExpense]([ExpenseCategory],[ExpenseDescription],[ExpenseAmount],[ExpenseDate],[ExpenseFrom])
	VALUES(@eCategory,@eDascription,@eAmount,@eDate,@eExpenseFrom)
	if (@eExpenseFrom = 1)
	insert into dbo.ClinicFund(clinicFundAmount,clinicFundDescription,clinicFundDate)
	values (@eAmount*-1,@eDascription,@eDate)
	else
	insert into dbo.DonationEntry(DonatorID,DonatorType,DonationAmount,DonationDate,Remarks)
	values (2,'',@eAmount*-1,@eDate,@eDascription)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_AddPatientRecord]    Script Date: 29/12/2021 2:13:01 pm ******/
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
@pModifiedDate datetime,
@ClinicalFee decimal,
@DonationAmount decimal,
@NetFee decimal,
@PaymentType int,
@KetType int,
@KetAmount decimal,
@FeeEntryDate datetime
AS
BEGIN

set @pDateCreated=GETDATE()
	if(@pId = 0)
	begin
	INSERT INTO [dbo].[Patient](PatientName,PNIC,PAddress,PCity,PCountry,PContact,PEmergencyContact,
	PGender,PMaritulStatus,PEmail,PDob,Active,DateCreated,ModifiedDate)
	VALUES(@pName,@pCnic,@pAddress,@pCity,@pCountry,@pContact,@pEConatct,@pGender,@pMaritulStatus,
	@pEmail,@pDob,@pActive,@pDateCreated,@pModifiedDate)
	insert into PatientFeeEntry (PatientID,EntryDate,ClinicalFee,DonationAmount,NetFee,PaymentType,KetType,KetAmount)
	values ((SELECT IDENT_CURRENT('Patient')),@FeeEntryDate,@ClinicalFee,@DonationAmount,@NetFee,@PaymentType,@KetType,@KetAmount)
	if (@KetType != 1)
	insert into dbo.ketsData(ketsQuantity,ketsDate)values(-1,@pDateCreated)
	if(@PaymentType=1)
	insert into dbo.ClinicFund (clinicFundAmount,clinicFundDescription,clinicFundDate)
	values((@NetFee),'Paitent Dialysis',@FeeEntryDate)
	if(@PaymentType=2)
	insert into dbo.ZakatEntry(ZakatAmount,ZakatDate,ZakaterID,ZakaterRemarks,ZakaterType)
	values(@NetFee*(-1),@FeeEntryDate,1,'paitent dailysis','person')
	if(@PaymentType=3)
	begin
		insert into dbo.ZakatEntry(ZakatAmount,ZakatDate,ZakaterID,ZakaterRemarks,ZakaterType)
	values(@DonationAmount*(-1),@FeeEntryDate,1,'paitent dailysis','person')
	insert into dbo.ClinicFund (clinicFundAmount,clinicFundDescription,clinicFundDate)
	values((@NetFee-@DonationAmount),'Paitent Dialysis',@FeeEntryDate)
	end
	end

	else
	begin
	insert into PatientFeeEntry (PatientID,EntryDate,ClinicalFee,DonationAmount,NetFee,PaymentType,KetType,KetAmount)
	values (@pId,@FeeEntryDate,@ClinicalFee,@DonationAmount,@NetFee,@PaymentType,@KetType,@KetAmount)
	if (@KetType != 1)
	insert into dbo.ketsData(ketsQuantity,ketsDate)values(-1,@pDateCreated)
	if(@PaymentType=1)
	insert into dbo.ClinicFund (clinicFundAmount,clinicFundDescription,clinicFundDate)
	values((@NetFee),'Paitent Dialysis',@FeeEntryDate)
	end
	if(@PaymentType=2)
	insert into dbo.ZakatEntry(ZakatAmount,ZakatDate,ZakaterID,ZakaterRemarks,ZakaterType)
	values(@NetFee*(-1),@FeeEntryDate,1,'paitent dailysis','person')
	if(@PaymentType=3)
	begin
		insert into dbo.ZakatEntry(ZakatAmount,ZakatDate,ZakaterID,ZakaterRemarks,ZakaterType)
	values(@DonationAmount*(-1),@FeeEntryDate,1,'paitent dailysis','person')
	insert into dbo.ClinicFund (clinicFundAmount,clinicFundDescription,clinicFundDate)
	values((@NetFee-@DonationAmount),'Paitent Dialysis',@FeeEntryDate)
	end
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetCurrentMonthPatient]    Script Date: 29/12/2021 2:13:01 pm ******/
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
begin
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

if (@month is not null)
	begin
	select Patient.PatientName,Patient.PNIC,Patient.PGender,Patient.PContact,
       PatientFeeEntry.DonationAmount,PatientFeeEntry.KetAmount,PatientFeeEntry.ClinicalFee,PatientFeeEntry.NetFee,PatientFeeEntry.EntryDate
	   from PatientFeeEntry
	--   (select from dbo.PatientFeeEntry where MONTH(PatientFeeEntry.EntryDate)=MONTH(@month) and  year(PatientFeeEntry.EntryDate)=year(@month))
	   join Patient
	   on PatientFeeEntry.PatientID=Patient.ID
	   where MONTH(PatientFeeEntry.EntryDate)=MONTH(@month) and  year(PatientFeeEntry.EntryDate)=year(@month)
 end
end
GO
/****** Object:  StoredProcedure [dbo].[spAdd_Zakat]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAdd_Zakat]
@id int=null,
@ZakatAmount decimal,
@ZakatDate datetime,
@ZakaterRemarks varchar(200),
@ZakaterType varchar(50),
@ZakaterName varchar(200),
@ZakaterNic varchar(20),
@ZakaterAddress varchar(200)



AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SELECT IDENT_CURRENT('MyTable')
	SET NOCOUNT ON;
	if(@id=0)
	begin
 insert into dbo.Zakater(ZakaterName,ZakaterNic,ZakaterAddress) 
    values (@ZakaterName,@ZakaterNic,@ZakaterAddress)
  insert into dbo.ZakatEntry(ZakaterID,ZakatAmount,ZakatDate,ZakaterRemarks,ZakaterType)
    values ((SELECT IDENT_CURRENT('Zakater')),@ZakatAmount,@ZakatDate,@ZakaterRemarks,@ZakaterType)
	end
	else 
	begin
	  insert into dbo.ZakatEntry(ZakaterID,ZakatAmount,ZakatDate,ZakaterRemarks,ZakaterType)
    values (@id,@ZakatAmount,@ZakatDate,@ZakaterRemarks,@ZakaterType)
	end
END
--SELECT IDENT_CURRENT('MyTable')
GO
/****** Object:  StoredProcedure [dbo].[spAddKets]    Script Date: 29/12/2021 2:13:01 pm ******/
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
/****** Object:  StoredProcedure [dbo].[spGet_Donator]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGet_Donator]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Donator
END
GO
/****** Object:  StoredProcedure [dbo].[spGet_expanse]    Script Date: 29/12/2021 2:13:01 pm ******/
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
@month datetime=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from dbo.ClinicExpense
	where MONTH(ClinicExpense.ExpenseDate)=MONTH(@month) and  year(ClinicExpense.ExpenseDate)=year(@month)
END
GO
/****** Object:  StoredProcedure [dbo].[spGet_Patients]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGet_Patients]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from Patient
END
GO
/****** Object:  StoredProcedure [dbo].[spGet_Zakat]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGet_Zakat]
@month datetime=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT Zakater.ZakaterName, ZakatEntry.ZakatAmount, ZakatEntry.ZakaterRemarks,ZakatEntry.ZakatDate,ZakatEntry.ZakaterType
FROM zakater JOIN ZakatEntry ON ZakatEntry.ZakaterID=Zakater.ID
where MONTH(ZakatEntry.ZakatDate)=MONTH(@month) and  year(ZakatEntry.ZakatDate)=year(@month)
  
END
GO
/****** Object:  StoredProcedure [dbo].[spGetAllZakaters]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetAllZakaters] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Zakater
END
GO
/****** Object:  StoredProcedure [dbo].[spGetDonationInfo]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetDonationInfo]
@month datetime=null
AS
BEGIN

	SET NOCOUNT ON;

	SELECT Donator.DonatorName,DonationEntry.DonationAmount,DonationEntry.Remarks,DonationEntry.DonationDate
	from DonationEntry join Donator on DonationEntry.DonatorID=Donator.ID
	where MONTH(DonationEntry.DonationDate)=MONTH(@month) and  year(DonationEntry.DonationDate)=year(@month)
END
GO
/****** Object:  StoredProcedure [dbo].[spGetKets]    Script Date: 29/12/2021 2:13:01 pm ******/
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
/****** Object:  StoredProcedure [dbo].[spTransferBankToClinic]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spTransferBankToClinic] 
	@Amount int =null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into ClinicFund(clinicFundAmount,clinicFundDate,clinicFundDescription)
	values (@Amount,GETDATE(),'From Bank')
	insert into DonationEntry(DonationAmount,DonatorType,DonationDate,DonatorID)
	values (@Amount*-1,'To Clinic',GETDATE(),2)

END
GO
/****** Object:  StoredProcedure [dbo].[spTransferFunds]    Script Date: 29/12/2021 2:13:01 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spTransferFunds]
@Amount int=null

AS
BEGIN
	SET NOCOUNT ON;
	insert into ClinicFund(clinicFundAmount,clinicFundDate,clinicFundDescription)
	values (@Amount*-1,GETDATE(),'Tranfered to Donaiton')
	insert into DonationEntry(DonationAmount,DonatorType,DonationDate,DonatorID)
	values (@Amount,'',GETDATE(),2)

END
GO
USE [master]
GO
ALTER DATABASE [ClinicDB] SET  READ_WRITE 
GO
