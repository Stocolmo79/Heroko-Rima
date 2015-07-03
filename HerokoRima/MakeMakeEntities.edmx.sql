
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/01/2015 10:54:31
-- Generated from EDMX file: C:\Users\Bernardo Cisternas\Documents\Visual Studio 2013\Projects\HerokoRima\HerokoRima\MakeMakeEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MakeMake];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tCardUsages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tCardUsages];
GO
IF OBJECT_ID(N'[dbo].[tClasses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tClasses];
GO
IF OBJECT_ID(N'[dbo].[tDropIns]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tDropIns];
GO
IF OBJECT_ID(N'[dbo].[tMembers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tMembers];
GO
IF OBJECT_ID(N'[dbo].[tMonths]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tMonths];
GO
IF OBJECT_ID(N'[dbo].[tStaffs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tStaffs];
GO
IF OBJECT_ID(N'[dbo].[tTickets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tTickets];
GO
IF OBJECT_ID(N'[dbo].[tCards]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tCards];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tCardUsages'
CREATE TABLE [dbo].[tCardUsages] (
    [CUId] bigint IDENTITY(1,1) NOT NULL,
    [CardId] bigint  NOT NULL,
    [EntranceDate] datetime  NULL
);
GO

-- Creating table 'tClasses'
CREATE TABLE [dbo].[tClasses] (
    [ClassId] bigint  NOT NULL,
    [TypeId] int  NULL,
    [ClassDate] datetime  NOT NULL,
    [MaxAttendance] int  NULL,
    [Attendance] int  NULL
);
GO

-- Creating table 'tDropIns'
CREATE TABLE [dbo].[tDropIns] (
    [DropInId] bigint IDENTITY(1,1) NOT NULL,
    [PriceId] int  NULL,
    [Quantity] int  NULL
);
GO

-- Creating table 'tMembers'
CREATE TABLE [dbo].[tMembers] (
    [RUT] varchar(10)  NOT NULL,
    [Firstname] varchar(250)  NOT NULL,
    [Lastname] varchar(250)  NOT NULL,
    [Cellphone] varchar(10)  NOT NULL,
    [MemberId] bigint  NULL
);
GO

-- Creating table 'tMonths'
CREATE TABLE [dbo].[tMonths] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [CardId] bigint  NOT NULL,
    [Purchased] datetime  NULL,
    [Amount] bigint  NULL
);
GO

-- Creating table 'tStaffs'
CREATE TABLE [dbo].[tStaffs] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [RUT] varchar(10)  NULL,
    [Firstname] varchar(250)  NULL,
    [Lastname] varchar(250)  NULL,
    [Area] varchar(250)  NULL,
    [Phone] varchar(12)  NOT NULL
);
GO

-- Creating table 'tTickets'
CREATE TABLE [dbo].[tTickets] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [CardNo] bigint  NOT NULL,
    [Quantity] bigint  NULL,
    [Purchased] datetime  NULL,
    [Amount] bigint  NULL
);
GO

-- Creating table 'tCards'
CREATE TABLE [dbo].[tCards] (
    [CardId] bigint  NOT NULL,
    [Monthly] bit  NOT NULL,
    [StartDate] datetime  NULL,
    [EndDate] datetime  NULL,
    [Tickets] int  NULL,
    [Changed] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CUId] in table 'tCardUsages'
ALTER TABLE [dbo].[tCardUsages]
ADD CONSTRAINT [PK_tCardUsages]
    PRIMARY KEY CLUSTERED ([CUId] ASC);
GO

-- Creating primary key on [ClassId] in table 'tClasses'
ALTER TABLE [dbo].[tClasses]
ADD CONSTRAINT [PK_tClasses]
    PRIMARY KEY CLUSTERED ([ClassId] ASC);
GO

-- Creating primary key on [DropInId] in table 'tDropIns'
ALTER TABLE [dbo].[tDropIns]
ADD CONSTRAINT [PK_tDropIns]
    PRIMARY KEY CLUSTERED ([DropInId] ASC);
GO

-- Creating primary key on [RUT] in table 'tMembers'
ALTER TABLE [dbo].[tMembers]
ADD CONSTRAINT [PK_tMembers]
    PRIMARY KEY CLUSTERED ([RUT] ASC);
GO

-- Creating primary key on [Id] in table 'tMonths'
ALTER TABLE [dbo].[tMonths]
ADD CONSTRAINT [PK_tMonths]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tStaffs'
ALTER TABLE [dbo].[tStaffs]
ADD CONSTRAINT [PK_tStaffs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tTickets'
ALTER TABLE [dbo].[tTickets]
ADD CONSTRAINT [PK_tTickets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [CardId], [Monthly], [Changed] in table 'tCards'
ALTER TABLE [dbo].[tCards]
ADD CONSTRAINT [PK_tCards]
    PRIMARY KEY CLUSTERED ([CardId], [Monthly], [Changed] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------