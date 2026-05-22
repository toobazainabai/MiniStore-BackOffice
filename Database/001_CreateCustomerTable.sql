-- Create Customer Table for MiniStore Database
-- Run this script in SQL Server Management Studio against the 'ministore' database

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customer]') AND type in (N'U'))
BEGIN
	CREATE TABLE [dbo].[Customer] (
		[Id] NVARCHAR(9) PRIMARY KEY NOT NULL,
		[Name] NVARCHAR(100) NOT NULL,
		[Address] NVARCHAR(255),
		[Phone] NVARCHAR(20),
		[Email] NVARCHAR(100),
		[CreatedDate] DATETIME DEFAULT GETUTCDATE()
	);

	-- Create index on Email for faster searches
	CREATE INDEX IX_Customer_Email ON [dbo].[Customer] ([Email]);

	-- Create index on Phone for faster searches
	CREATE INDEX IX_Customer_Phone ON [dbo].[Customer] ([Phone]);

	PRINT 'Customer table created successfully!';
END
ELSE
BEGIN
	PRINT 'Customer table already exists.';
END
