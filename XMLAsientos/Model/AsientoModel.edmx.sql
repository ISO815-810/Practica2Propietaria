
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/02/2019 09:06:10
-- Generated from EDMX file: C:\Users\Carlos\Downloads\XMLAsientos\XMLAsientos\Model\AsientoModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AsientosContables];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AsientoContableSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AsientoContableSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AsientoContableSet'
CREATE TABLE [dbo].[AsientoContableSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NoAsiento] int  NOT NULL,
    [DescripcionAsiento] nvarchar(300)  NOT NULL,
    [FechaAsiento] datetime  NOT NULL,
    [TipoMovimiento] int  NOT NULL,
    [Monto] decimal(18,0)  NOT NULL,
    [CuentaContable] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AsientoContableSet'
ALTER TABLE [dbo].[AsientoContableSet]
ADD CONSTRAINT [PK_AsientoContableSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------