CREATE TABLE [dbo].[tblCustomer]
(
	[CustomerID] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(26) NOT NULL, 
    [LastName] VARCHAR(26) NOT NULL, 
    [HomeAddress] VARCHAR(51) NOT NULL, 
    [EmailAddress] VARCHAR(30) NOT NULL, 
    [Gender] VARCHAR(10) NOT NULL, 
    [PhoneNo] VARCHAR(15) NOT NULL, 
    [DOB] VARCHAR(10) NOT NULL, 
    [Active] VARCHAR(6) NOT NULL
)
