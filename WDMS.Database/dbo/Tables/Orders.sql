CREATE TABLE [dbo].[Orders] (
    [OrderBatchId] INT           IDENTITY (1, 1) NOT NULL,
    [CustomerId]   INT           NOT NULL,
    [Status]       NVARCHAR (50) NULL,
    [Operator]     INT           NOT NULL,
    [Assistant]    INT           NULL,
    [CreateTime]   DATETIME      CONSTRAINT [DF_Orders_CreateTime] DEFAULT (getdate()) NOT NULL,
    [UpdateTime]   DATETIME      NULL
);

