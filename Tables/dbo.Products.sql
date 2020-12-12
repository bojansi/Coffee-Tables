CREATE TABLE [dbo].[Products] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [Name]  NVARCHAR (50)  NOT NULL,
    [Price] DECIMAL (18)   NOT NULL,
    [Type]  NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

