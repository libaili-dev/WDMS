CREATE TABLE [dbo].[Configurations] (
    [ConfigId]    INT           IDENTITY (1, 1) NOT NULL,
    [ConfigKey]   NVARCHAR (50) NOT NULL,
    [ConfigValue] NVARCHAR (50) NULL,
    [ConfigGroup] NVARCHAR (50) NOT NULL,
    [Description] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Configurations] PRIMARY KEY CLUSTERED ([ConfigId] ASC)
);

