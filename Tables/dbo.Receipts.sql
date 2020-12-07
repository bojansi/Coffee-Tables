CREATE TABLE [dbo].[Receipts]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [WaiterId] INT NOT NULL, 
    [TableId] INT NOT NULL, 
    [Items] NVARCHAR(MAX) NOT NULL, 
    [Date] DATE NOT NULL, 
    [Cost] DECIMAL NOT NULL, 
    CONSTRAINT [FK_Receipts_ToWaiters] FOREIGN KEY ([WaiterId]) REFERENCES [Waiters]([Id]), 
    CONSTRAINT [FK_Receipts_ToTables] FOREIGN KEY ([TableId]) REFERENCES [Tables]([Id])
)
