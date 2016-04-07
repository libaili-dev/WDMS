CREATE TABLE [dbo].[AdminRole] (
    [RoleId]        INT           IDENTITY (1, 1) NOT NULL,
    [RoleName]      NVARCHAR (50) NOT NULL,
    [RoleAuthority] NVARCHAR (50) NULL,
    [Decription]    NCHAR (10)    NULL
);

