CREATE TABLE [dbo].[ReceiptItems] (
    [ReceiptId] INT          NOT NULL,
    [ProductId] INT          NOT NULL,
    [Quantity]  INT          NOT NULL,
    [Amount]    DECIMAL (18) NOT NULL,
    CONSTRAINT [PK_Products_PID_RID] PRIMARY KEY CLUSTERED ([ProductId] ASC, [ReceiptId] ASC),
    CONSTRAINT [item_pr_id_fk] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]),
    CONSTRAINT [item_rc_id_fk] FOREIGN KEY ([ReceiptId]) REFERENCES [dbo].[Receipts] ([Id])
);

