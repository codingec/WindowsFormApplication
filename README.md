"#WindowsFormApplication" 
Create a dable Products with the next values, or you could also just copy and paste this code and run it to create your table.

CREATE TABLE [dbo].[Products] (
    [Id]          INT        IDENTITY (100, 10) NOT NULL,
    [product]     NCHAR (10) NULL,
    [description] NCHAR (10) NULL,
    [price]       NCHAR (10) NULL,
    [quantity]    NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
