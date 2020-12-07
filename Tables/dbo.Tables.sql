CREATE TABLE [dbo].[Tables]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TableNumber] INT NOT NULL, 
    [TableItems] NVARCHAR(MAX) NOT NULL, 
    [TableTaken] BIT NOT NULL
)
