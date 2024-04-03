CREATE TABLE [dbo].[HocSinh] (
    [Ten]    VARCHAR (100) NOT NULL,
    [ID]     VARCHAR (100) NOT NULL,
    [Diachi] VARCHAR (255) NULL,
    [Cmnd]   VARCHAR (100) NOT NULL,
    [DiemTB] FLOAT (53)    NULL,
    [DoB]    DATETIME2 (7) NULL,
    [Email]  VARCHAR (100) NULL,
    [Phone]  VARCHAR (100) NULL,
    [Gender] VARCHAR (100) NULL,
    CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED ([ID] ASC)
);

