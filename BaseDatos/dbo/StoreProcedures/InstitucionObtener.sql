
--==============================================================================================
--Author      ============== Jeaustin Sandoval
--Create date ============== 04/3/22
--Description ============== Procedimiento que devuelve el listado de las instituciones
--==============================================================================================


CREATE PROCEDURE [dbo].[InstitucionObtener]
	@Id_Institucion Int = null
	AS
BEGIN

	SET NOCOUNT ON 

	SELECT 
    Id_Institucion ,Codigo,Nombre ,Telefono ,Estado 
	FROM 
	dbo.Institucion
	WHERE 
	(@Id_Institucion is null or  Id_Institucion = @Id_Institucion)

END
RETURN 0


