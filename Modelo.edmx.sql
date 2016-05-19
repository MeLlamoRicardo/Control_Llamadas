
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/18/2016 22:38:51
-- Generated from EDMX file: C:\Users\HP\documents\visual studio 2015\Projects\Control_Llamadas\Control_Llamadas\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Control_Llamadas];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Llamadas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Llamadas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Llamadas'
CREATE TABLE [dbo].[Llamadas] (
    [ID_Llamada] int  NOT NULL Identity(1,1),
    [Usuario] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Observaciones] nvarchar(max)  NOT NULL,
    [Fecha] nvarchar(max)  NOT NULL,
    [Hora_Inicio] nvarchar(max)  NOT NULL,
    [Hora_Fin] nvarchar(max)  NOT NULL,
    [Tiempo_Total] nvarchar(max)  NOT NULL,
    [ID_Dia] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID_Llamada] in table 'Llamadas'
ALTER TABLE [dbo].[Llamadas]
ADD CONSTRAINT [PK_Llamadas]
    PRIMARY KEY CLUSTERED ([ID_Llamada] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------