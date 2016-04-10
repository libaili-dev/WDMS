CREATE TABLE [dbo].[Inventory] (
    [InventoryId]  INT             IDENTITY (1, 1) NOT NULL,
    [StyleId]      INT             NOT NULL,
    [Size]         NCHAR (10)      NULL,
    [TotalCount]   INT             CONSTRAINT [DF_Inventory_TotalCount] DEFAULT ((1)) NOT NULL,
    [RentingCount] INT             CONSTRAINT [DF_Inventory_RentingCount] DEFAULT ((0)) NOT NULL,
    [WashingCount] INT             CONSTRAINT [DF_Inventory_WashingCount] DEFAULT ((0)) NOT NULL,
    [Status]       NVARCHAR (50)   NOT NULL,
    [RentPrice]    DECIMAL (15, 2) NULL,
    [SellPrice]    DECIMAL (15, 2) NULL,
    [Remark]       NVARCHAR (500)  NULL,
    [CreateTime]   DATETIME        NULL DEFAULT (getdate()),
    [UpdateTime]   DATETIME         NULL,
    [Operator]     INT             NOT NULL, 
    CONSTRAINT [PK_Inventory] PRIMARY KEY ([InventoryId])
);

