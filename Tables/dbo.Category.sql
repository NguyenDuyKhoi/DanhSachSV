CREATE TABLE [dbo].[Category] (
  [Title] [nvarchar](50) NOT NULL,
  [Name] [nvarchar](50) NULL,
  CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([Title])
)
ON [PRIMARY]
GO