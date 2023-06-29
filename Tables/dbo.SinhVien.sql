CREATE TABLE [dbo].[SinhVien] (
  [ID] [int] IDENTITY,
  [FullName] [nvarchar](200) NULL,
  [Age] [int] NULL,
  [Ngay] [date] NULL,
  [Sex] [nvarchar](50) NULL,
  [Adress] [nvarchar](500) NULL,
  [Phone] [varchar](30) NULL,
  [DiemToan] [float] NULL,
  [DiemVan] [float] NULL,
  [DiemAnh] [float] NULL,
  [HocLuc] [nvarchar](50) NULL,
  CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED ([ID])
)
ON [PRIMARY]
GO