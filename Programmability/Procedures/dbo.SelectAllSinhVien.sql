SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[SelectAllSinhVien]
AS
select 
ID,
FullName,

Ngay,
Sex,
Adress,
Phone,
DiemToan,
DiemVan,
DiemAnh,
HocLuc
from SinhVien
GO