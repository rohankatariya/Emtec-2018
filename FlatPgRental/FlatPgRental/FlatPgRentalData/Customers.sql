CREATE TABLE [dbo].[Customers]
(
	[CustomerId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [CustomerName] VARCHAR(50) NOT NULL, 
    [ContactNumber] DECIMAL(10) NOT NULL, 
    [EmailId] VARCHAR(100) NULL
)
