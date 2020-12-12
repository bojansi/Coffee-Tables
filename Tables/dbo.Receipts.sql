CREATE TABLE [dbo].[Receipts] (
    [Id]       INT            NOT NULL,
    [WaiterId] INT            NOT NULL,
    [TableId]  INT            NOT NULL,
    [Items]    NVARCHAR (MAX) NOT NULL,
    [Date]     DATE           NOT NULL,
    [Cost]     DECIMAL (18)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Receipts_ToWaiters] FOREIGN KEY ([WaiterId]) REFERENCES [dbo].[Waiters] ([Id]),
    CONSTRAINT [FK_Receipts_ToTables] FOREIGN KEY ([TableId]) REFERENCES [dbo].[Tables] ([Id])
);

