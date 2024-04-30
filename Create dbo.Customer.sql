USE [LongChauWeb]
GO
/****** Object: Table [dbo].[Customer] Script Date: 4/30/2024 12:31:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[Customer] (
    [CustomerID]  INT IDENTITY(1,1) PRIMARY KEY,
    [UserName]    VARCHAR (50) NULL,
    [PassWord]    VARCHAR (50) NULL,
    [FisrtName]   VARCHAR (50) NULL,
    [LastName]    VARCHAR (50) NULL,
    [BirthDay]    DATETIME     NULL,
    [Gender]      VARCHAR (50) NULL,
    [Email]       VARCHAR (50) NULL,
    [PhoneNumber] INT          NULL,
    [Address]     VARCHAR (50) NULL,
    [Photo]       VARCHAR (50) NULL
);


