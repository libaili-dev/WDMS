CREATE TABLE [dbo].[Styles] (
    [StyleId]     INT             NOT NULL,
    [StyleNo]     NVARCHAR (20)   NOT NULL,
    [Images]      NVARCHAR (1000) NULL,
    [Status]      NVARCHAR (50)   NULL,
    [Description] NVARCHAR (50)   NULL,
    [CreateTime]  DATETIME        CONSTRAINT [DF_Styles_CreateTime] DEFAULT (getdate()) NULL
);

