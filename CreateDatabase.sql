--------------------------------------------------------------------------------------------------
-- Database creation script.
--------------------------------------------------------------------------------------------------
USE [Assessment]
GO

CREATE TABLE [dbo].[Carriers](
	[CarrierID] [int] IDENTITY(1,1) NOT NULL,
	[CarrierName] [varchar](256) NOT NULL,
	[Address] [varchar](256) NOT NULL,
	[Address2] [varchar](256) NULL,
	[City] [varchar](256) NOT NULL,
	[State] [varchar](256) NOT NULL,
	[Zip] [varchar](16) NOT NULL,
	[Contact] [varchar](256) NOT NULL,
	[Phone] [varchar](16) NOT NULL,
	[Fax] [varchar](16) NULL,
	[Email] [varchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CarrierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

create procedure [dbo].[Carriers_GetByID](@CarrierID int)
as
select [CarrierID], [CarrierName], [Address], [Address2], [City], [State], [Zip], [Contact], [Phone], [Fax], [Email]
from Carriers
where [CarrierID] = @CarrierID

GO

create procedure [dbo].[Carriers_GetAll]
as
select [CarrierID], [CarrierName], [Address], [Address2], [City], [State], [Zip], [Contact], [Phone], [Fax], [Email]
from Carriers

GO

CREATE procedure [dbo].[Carriers_Insert](@CarrierName varchar(256), @Address varchar(256), @Address2 varchar(256) = null, @City varchar(256), 
@State varchar(256), @Zip varchar(16), @Contact varchar(256), @Phone varchar(16), @Fax varchar(16) = null, @Email varchar(256))
as

insert into Carriers([CarrierName], [Address], [Address2], [City], [State], [Zip], [Contact], [Phone], [Fax], [Email])
values (@CarrierName, @Address, @Address, @City, @State, @Zip, @Contact, @Phone, @Fax, @Email)

declare @CarrierID int = @@Identity

select [CarrierID], [CarrierName], [Address], [Address2], [City], [State], [Zip], [Contact], [Phone], [Fax], [Email]
from Carriers
where [CarrierID] = @CarrierID
GO

CREATE proc [dbo].[Carriers_Update](@CarrierID int, @CarrierName varchar(256), @Address varchar(256), @Address2 varchar(256) = null, @City varchar(256), 
@State varchar(256), @Zip varchar(16), @Contact varchar(256), @Phone varchar(16), @Fax varchar(16) = null, @Email varchar(256))
as
update Carriers
set [CarrierName] = @CarrierName, [Address] = @Address, [Address2] = @Address2, [City] = @City, [State] = @State,
[Zip] = @Zip, [Contact] = @Contact, [Phone] = @Phone, [Fax] = @Fax, [Email] = @Email
where [CarrierID] = @CarrierID
GO

CREATE procedure [dbo].[Carriers_Delete](@CarrierID int)
as
delete from Carriers
where [CarrierID] = @CarrierID

select @@ROWCOUNT
GO

