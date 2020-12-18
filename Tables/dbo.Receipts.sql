CREATE TABLE [dbo].[Receipts] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [WaiterId] INT          NOT NULL,
    [TableId]  INT          NOT NULL,
    [Date]     DATE         NOT NULL,
    [Total]    DECIMAL (18) NOT NULL,
    [Paid]     BIT          NOT NULL DEFAULT 0,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Receipts_ToWaiters] FOREIGN KEY ([WaiterId]) REFERENCES [dbo].[Waiters] ([Id]),
    CONSTRAINT [FK_Receipts_ToTables] FOREIGN KEY ([TableId]) REFERENCES [dbo].[Tables] ([Id])
);

