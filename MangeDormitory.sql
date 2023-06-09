USE [master]
GO
/****** Object:  Database [ManageDormitory]    Script Date: 20/5/2023 8:44:02 PM ******/
CREATE DATABASE [ManageDormitory]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ManageDormitory', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ManageDormitory.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ManageDormitory_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ManageDormitory_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ManageDormitory] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ManageDormitory].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ManageDormitory] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ManageDormitory] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ManageDormitory] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ManageDormitory] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ManageDormitory] SET ARITHABORT OFF 
GO
ALTER DATABASE [ManageDormitory] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ManageDormitory] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ManageDormitory] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ManageDormitory] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ManageDormitory] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ManageDormitory] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ManageDormitory] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ManageDormitory] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ManageDormitory] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ManageDormitory] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ManageDormitory] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ManageDormitory] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ManageDormitory] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ManageDormitory] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ManageDormitory] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ManageDormitory] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ManageDormitory] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ManageDormitory] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ManageDormitory] SET  MULTI_USER 
GO
ALTER DATABASE [ManageDormitory] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ManageDormitory] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ManageDormitory] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ManageDormitory] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ManageDormitory] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ManageDormitory]
GO
/****** Object:  Table [dbo].[BoardingBill]    Script Date: 20/5/2023 8:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoardingBill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](1000) NOT NULL,
	[date_founded] [datetime] NOT NULL,
	[total] [money] NOT NULL,
	[student_id] [nvarchar](10) NULL,
	[note] [nvarchar](300) NULL,
	[status] [nvarchar](500) NULL,
	[payment_date] [datetime] NULL,
 CONSTRAINT [PK_BoardingBill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ElectricityWaterBill]    Script Date: 20/5/2023 8:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ElectricityWaterBill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[date_founded] [datetime] NOT NULL,
	[old_power_indicator] [int] NOT NULL,
	[new_power_indicator] [int] NOT NULL,
	[amount_electricity_consumed] [float] NULL,
	[old_water_index] [int] NULL,
	[new_water_index] [int] NULL,
	[amount_water_consumed] [int] NULL,
	[electricity_money] [money] NOT NULL,
	[water_money] [money] NOT NULL,
	[environmental_charges] [money] NOT NULL,
	[into_money] [money] NOT NULL,
	[status] [nvarchar](200) NOT NULL,
	[payment_date] [datetime] NULL,
	[room_id] [nvarchar](10) NULL,
	[note] [nvarchar](300) NULL,
 CONSTRAINT [PK_ElectricityWaterBill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 20/5/2023 8:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[id] [nvarchar](10) NOT NULL,
	[area] [nvarchar](10) NOT NULL,
	[type] [nvarchar](50) NOT NULL,
	[price] [money] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
	[range] [nvarchar](50) NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 20/5/2023 8:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[id] [nvarchar](10) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[gender] [bit] NOT NULL,
	[birthdate] [datetime] NOT NULL,
	[address] [nvarchar](255) NULL,
	[citizen_identification] [nvarchar](50) NOT NULL,
	[date_issue] [date] NULL,
	[place_issue] [nvarchar](200) NULL,
	[school] [nvarchar](255) NOT NULL,
	[course] [nvarchar](5) NULL,
	[industry] [nvarchar](50) NULL,
	[phone] [nvarchar](10) NULL,
	[email] [nvarchar](200) NULL,
	[room_id] [nvarchar](10) NULL,
	[contract_signing_date] [datetime] NULL,
	[avatar] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BoardingBill] ADD  CONSTRAINT [DF_BoardingBill_date_founded]  DEFAULT (getdate()) FOR [date_founded]
GO
ALTER TABLE [dbo].[BoardingBill] ADD  CONSTRAINT [DF_BoardingBill_status]  DEFAULT (N'Chờ thanh toán') FOR [status]
GO
ALTER TABLE [dbo].[ElectricityWaterBill] ADD  CONSTRAINT [DF_ElectricityWaterBill_date_founded]  DEFAULT (getdate()) FOR [date_founded]
GO
ALTER TABLE [dbo].[ElectricityWaterBill] ADD  CONSTRAINT [DF_ElectricityWaterBill_status]  DEFAULT (N'Chờ thanh toán') FOR [status]
GO
ALTER TABLE [dbo].[Room] ADD  CONSTRAINT [DF_Room_quantity]  DEFAULT ((8)) FOR [quantity]
GO
ALTER TABLE [dbo].[BoardingBill]  WITH CHECK ADD  CONSTRAINT [FK_BoardingBill_Student] FOREIGN KEY([student_id])
REFERENCES [dbo].[Student] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[BoardingBill] CHECK CONSTRAINT [FK_BoardingBill_Student]
GO
ALTER TABLE [dbo].[ElectricityWaterBill]  WITH CHECK ADD  CONSTRAINT [FK_ElectricityWaterBill_Room] FOREIGN KEY([room_id])
REFERENCES [dbo].[Room] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[ElectricityWaterBill] CHECK CONSTRAINT [FK_ElectricityWaterBill_Room]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Room] FOREIGN KEY([room_id])
REFERENCES [dbo].[Room] ([id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Room]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'mã hóa đơn' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tên hóa đơn' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ngày lập ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'date_founded'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'chỉ số tiêu thụ điện cũ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'old_power_indicator'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'chỉ số tiêu thụ điện mới' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'new_power_indicator'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'lượng điện tiêu thụ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'amount_electricity_consumed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'chỉ số nước cũ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'old_water_index'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'chỉ số nước mới' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'new_water_index'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'lượng nước tiêu thụ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'amount_water_consumed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tiền điện' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'electricity_money'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tiền nước' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'water_money'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'phí môi trường' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'environmental_charges'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'thành tiền' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'into_money'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'trạng thái hóa đơn' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ngày đóng tiền' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'payment_date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'mã phòng khóa ngoại' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ElectricityWaterBill', @level2type=N'COLUMN',@level2name=N'room_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'mã phòng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Room', @level2type=N'COLUMN',@level2name=N'id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'khu' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Room', @level2type=N'COLUMN',@level2name=N'area'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'loại phòng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Room', @level2type=N'COLUMN',@level2name=N'type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tiền phòng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Room', @level2type=N'COLUMN',@level2name=N'price'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'trạng thái ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Room', @level2type=N'COLUMN',@level2name=N'status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'dãy phòng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Room', @level2type=N'COLUMN',@level2name=N'range'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'số lượng sinh viên tối đa được ở' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Room', @level2type=N'COLUMN',@level2name=N'quantity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã sinh viên' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Họ và tên sinh viên' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'giới tính' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'gender'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ngày sinh' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'birthdate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'địa chỉ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'căn cước công dân' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'citizen_identification'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ngày cấp cccd' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'date_issue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nơi cấp cccd' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'place_issue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nơi học' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'school'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'khóa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'course'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ngành' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'industry'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'số điện thoại' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'mã phòng khóa ngoại' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'room_id'
GO
USE [master]
GO
ALTER DATABASE [ManageDormitory] SET  READ_WRITE 
GO
