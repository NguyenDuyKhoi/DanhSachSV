SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
create proc [dbo].[DeleteSV]
@ID varchar(50)
as
begin
delete from SinhVien where ID= @ID
if(@@ROWCOUNT >0) return 1;
else return 0;
end
GO