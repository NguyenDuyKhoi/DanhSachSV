SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[updateSV]
@ID int,
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
UPDATE SinhVien
SET
FullName=@FullName,

Ngay=@Date,
Sex=@Sex,
Adress=@Adress,
Phone=@Phone,
DiemToan=@DiemToan,
DiemVan=@DiemVan,
DiemAnh=@DiemAnh,
HocLuc=@HocLuc
where ID=@ID
IF @@ROWCOUNT >0 BEGIN RETURN 1 END
ELSE BEGIN RETURN 0 END;
END
GO