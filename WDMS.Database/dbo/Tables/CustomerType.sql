CREATE TABLE [dbo].[CustomerType] (
    [CustomerTypeId]   INT           IDENTITY (1, 1) NOT NULL,
    [CustomerTypeName] NVARCHAR (50) NOT NULL,
    [Discount]         FLOAT (53)    NOT NULL, 
    CONSTRAINT [PK_CustomerType] PRIMARY KEY ([CustomerTypeId])
);

