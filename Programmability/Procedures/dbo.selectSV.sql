SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
create procedure [dbo].[selectSV]
@ID INT
AS 
BEGIN
SELECT
FullName,

Ngay,
Sex,
Adress,
Phone,
DiemToan,
DiemVan,
DiemAnh,
HocLuc
FROM SinhVien
WHERE ID=@ID;
END 
GO