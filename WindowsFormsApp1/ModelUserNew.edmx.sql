
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/10/2023 22:40:37
-- Generated from EDMX file: C:\Users\Boban\source\repos\GamesMySqlWPFApp\WindowsFormsApp1\ModelUserNew.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EFDbNewUser];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserNew]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserNew];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserNews'
CREATE TABLE [dbo].[UserNews] (
    [UserNewId] int IDENTITY(1,1) NOT NULL,
    [UserNewName] nchar(50)  NULL,
    [UserNewBalance] int  NULL,
    [UserNewPassword] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserNewId] in table 'UserNews'
ALTER TABLE [dbo].[UserNews]
ADD CONSTRAINT [PK_UserNews]
    PRIMARY KEY CLUSTERED ([UserNewId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------