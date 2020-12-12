CREATE TABLE [dbo].[Tables] (
    [Id]     INT            NOT NULL,
    [Number] INT            NOT NULL,
    [Items]  NVARCHAR (MAX) NULL,
    [Taken]  BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

