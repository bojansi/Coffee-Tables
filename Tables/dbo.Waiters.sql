CREATE TABLE [dbo].[Waiters] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Surname]     NVARCHAR (50)  NOT NULL,
    [Email]       NVARCHAR (100) NOT NULL,
    [Address]     NVARCHAR (100) NULL,
    [PhoneNumber] NVARCHAR (15)  NOT NULL,
    [Username]    NVARCHAR (25)  NOT NULL,
    [Password]    NVARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

