IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20170803144839_Initial')
BEGIN
    CREATE TABLE [labTest] (
        [ID] nvarchar(450) NOT NULL,
        [Category] int NOT NULL,
        [Description] nvarchar(max),
        [Price] decimal(18, 2) NOT NULL,
        [testCode] nvarchar(max),
        CONSTRAINT [PK_labTest] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20170803144839_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20170803144839_Initial', N'1.1.2');
END;

GO

