SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[ThemMoiSinhhVien]

@FullName nvarchar(200),

@Date date,
@Sex nvarchar(50),
@Adress nvarchar(500),
@Phone varchar(30),
@DiemToan float,
@DiemVan float,
@DiemAnh float,
@HocLuc nvarchar(50)
AS
  BEGIN
  INSERT INTO SinhVien
  (
  
   FullName,

   Ngay,
   Sex,
   Adress,
   Phone,
   DiemToan,
   DiemVan,
   DiemAnh,
   HocLuc
   )VALUES(
   
   @FullName,

   @Date,
   @Sex,
   @Adress,
   @Phone,
   @DiemToan,
   @DiemVan,
   @DiemAnh,
   @HocLuc
   )
   IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
   ELSE BEGIN RETURN 0 END;
  END
GO