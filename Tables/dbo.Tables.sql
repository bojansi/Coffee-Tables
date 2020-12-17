CREATE TABLE [dbo].[Tables] (
    [Id]          INT            NOT NULL,
    [Number]      INT            NOT NULL,
    [Taken]       BIT            NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

