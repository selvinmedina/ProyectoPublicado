USE [ERP_GMEDINA]
GO
/****** Object:  StoredProcedure [rrhh].[UDP_RRHH_tbAreas_Update]    Script Date: 10/12/2019 10:46:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [rrhh].[UDP_RRHH_tbAreas_Update]
  (
    @area_Id int,
    @Car_Descripcion nvarchar(50),
    @suc_Id int,
    @area_Descripcion nvarchar(50),
    @area_Usuariomodifica int,
    @area_Fechamodifica datetime
  )
  AS 
  SET NOCOUNT ON;
  BEGIN
   declare @car_Id int
    BEGIN TRY
      BEGIN TRAN
      DECLARE @Id INT
      SET @Id = @area_Id
      UPDATE [RRHH].tbAreas
      SET
      suc_Id = @suc_Id,
      area_Descripcion = @area_Descripcion,
      area_Usuariomodifica = @area_Usuariomodifica,
      area_Fechamodifica = @area_Fechamodifica,
	  @car_Id=car_Id
      WHERE area_Id = @area_Id
      AND area_Estado = 1
	  UPDATE [rrhh].[tbCargos]
	  SET
		[car_Descripcion]=@Car_Descripcion
	  WHERE [car_Id]=@car_Id
      SELECT
        CAST(@Id AS VARCHAR) AS MensajeError
      COMMIT TRAN
    END TRY
    BEGIN CATCH
      ROLLBACK TRAN
      SELECT
        '-1 ' + ERROR_MESSAGE() AS MensajeError
    END CATCH
  END
