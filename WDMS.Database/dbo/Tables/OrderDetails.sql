CREATE TABLE [dbo].[OrderDetails] (
    [OrderDatailId] INT             IDENTITY (1, 1) NOT NULL,
    [OrderBatchId]  INT             NOT NULL,
    [OrderType]     NVARCHAR (50)   NULL,
    [InventoryId]   INT             NOT NULL,
    [DeliveryWay]   NVARCHAR (10)   NULL,
    [ExpressNo]     NVARCHAR (50)   NULL,
    [Price]         DECIMAL (15, 2) NULL,
    [Status]        NVARCHAR (50)   NULL,
    [CreateTime]    DATETIME        CONSTRAINT [DF_OrderDetails_CreateTime] DEFAULT (getdate()) NOT NULL,
    [UpdateTime]    DATETIME        NULL,
    [Remark]        NVARCHAR (200)  NULL,
    CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED ([OrderDatailId] ASC),
    CONSTRAINT [FK_OrderDetails_Inventory] FOREIGN KEY ([InventoryId]) REFERENCES [dbo].[Inventory] ([InventoryId]),
    CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY ([OrderBatchId]) REFERENCES [dbo].[Orders] ([OrderBatchId])
);





