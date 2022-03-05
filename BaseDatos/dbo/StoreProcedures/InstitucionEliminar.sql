
--==============================================================================================
--Author      ============== Jeaustin Sandoval
--Create date ============== 04/3/22
--Description ============== Procedimiento que elimina las instituciones
--==============================================================================================

CREATE PROCEDURE [dbo].[InstitucionEliminar]
	@Id_Institucion INT
AS
BEGIN 

	SET NOCOUNT ON 
	BEGIN TRANSACTION TRASA
	BEGIN TRY
	Delete from dbo.Institucion where Id_Institucion = @Id_Institucion
	
	COMMIT TRANSACTION TRASA
	SELECT 0 AS CodError, '' AS MsgError
	END TRY

	BEGIN CATCH 
	SELECT 
		ERROR_NUMBER () AS CodeError,
		ERROR_MESSAGE() AS MsgError

	ROLLBACK TRANSACTION TRASA

	END CATCH

END
