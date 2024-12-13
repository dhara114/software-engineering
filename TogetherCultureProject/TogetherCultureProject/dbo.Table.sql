CREATE TABLE [dbo].[User]
(
	[UserID] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [PhoneNumber] INT NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Address] NVARCHAR(50) NULL, 
    [Town/City] NVARCHAR(50) NULL, 
    [Postcode] NVARCHAR(8) NULL, 
    [Password] NCHAR(10) NULL
)
