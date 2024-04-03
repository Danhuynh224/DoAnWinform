CREATE TABLE [dbo].[GiaoVien] (
    [Ten]    VARCHAR (100) NULL,
    [ID]     VARCHAR (100) NOT NULL,
    [Diachi] VARCHAR (255) NULL,
    [Cmnd]   VARCHAR (100) NOT NULL,
    [Mon]    VARCHAR (100) NULL,
    [DoB]    DATETIME2 (7) NULL,
    [Email]  VARCHAR (100) NULL,
    [Phone]  VARCHAR (100) NULL,
    [Gender] VARCHAR (100) NULL,
    CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED ([ID] ASC)
);

