CREATE TABLE [dbo].[Customer] (
    [CustomerId]       INT           IDENTITY (1, 1) NOT NULL,
    [CustomerTypeId]   INT           NOT NULL,
    [CustomerName]     NCHAR (10)    NULL,
    [Gender]           INT           CONSTRAINT [DF_Customer_Gender] DEFAULT ((0)) NULL,
    [Mobile]           NVARCHAR (20) NULL,
    [FittingDate]      DATE          NULL,
    [FinalFittingDate] DATE          NULL,
    [WeddingDate]      DATE          NULL,
    [CreateTime]       DATETIME      DEFAULT (getdate()) NULL,
    [Operator]         INT           NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId] ASC),
    CONSTRAINT [FK_Customer_CustomerType] FOREIGN KEY ([CustomerTypeId]) REFERENCES [dbo].[CustomerType] ([CustomerTypeId])
);



