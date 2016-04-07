CREATE TABLE [dbo].[Customer] (
    [CustomerId]       INT           IDENTITY (1, 1) NOT NULL,
    [CustomerTypeId]   INT           NOT NULL,
    [CustomerName]     NCHAR (10)    NULL,
    [Gender]           INT           CONSTRAINT [DF_Customer_Gender] DEFAULT ((0)) NULL,
    [Mobile]           NVARCHAR (20) NULL,
    [FittingDate]      DATE          NULL,
    [FinalFittingDate] DATE          NULL,
    [WeddingDate]      DATE          NULL,
    [CreateTime]       DATETIME      NULL,
    [Operator]         INT           NOT NULL
);

