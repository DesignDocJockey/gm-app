IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [TimeSheets] (
    [Uuid] uniqueidentifier NOT NULL,
    [Id] int NOT NULL IDENTITY,
    [Date] datetime2 NOT NULL,
    [Client] nvarchar(max) NULL,
    [Project] nvarchar(max) NULL,
    [ProjectCode] nvarchar(max) NULL,
    [Task] nvarchar(max) NULL,
    [Hours] float NOT NULL,
    [HoursRounded] float NOT NULL,
    [IsBillable] bit NOT NULL,
    [Invoiced] bit NOT NULL,
    [Approved] bit NOT NULL,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [Department] nvarchar(max) NULL,
    [IsEmployee] bit NOT NULL,
    [BillableRate] decimal(18, 2) NOT NULL,
    [CostRate] decimal(18, 2) NOT NULL,
    [CostAmount] decimal(18, 2) NOT NULL,
    [Currency] nvarchar(max) NULL,
    [ExternalReferenceURL] nvarchar(max) NULL,
    CONSTRAINT [PK_TimeSheets] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190109043643_initial', N'2.1.4-rtm-31024');

GO

