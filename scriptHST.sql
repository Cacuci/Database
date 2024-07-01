Create Procedure [dbo].[ChangeUENumber] @UEOld varchar(20) , @UENew varchar(20)
As
begin

  Set nocount on

  Declare @ID_UndMoviment bigint

  Select @ID_UndMoviment = ID 
    from UndMoviment
   Where TypeUnd = 'UE'
     and Number = @UEOld
  if @@ROWCOUNT = 1
  begin
     
	 Update UndMoviment Set Number = @UENew where ID = @ID_UndMoviment

  end

end