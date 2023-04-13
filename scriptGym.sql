USE [CodeGym]
GO
/****** Object:  StoredProcedure [dbo].[usp_SELECT_Concepto_All]    Script Date: 6/8/2022 23:00:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_SELECT_Concepto_All]
 AS 
-- Stored Procedured Generado por SQLTool Box 
-- Version: 4.1.0.0 
 -- Fecha: 6/8/2022 22:59:59 
 	Select Id, Descripcion ,Precio ,Tipo ,Nombre  from Concepto



GO
/****** Object:  StoredProcedure [dbo].[usp_SELECT_Concepto_ByID]    Script Date: 6/8/2022 23:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_SELECT_Concepto_ByID] 
(@Id int)
AS 
-- Stored Procedured Generado por SQLTool Box 
-- Version: 4.1.0.0 
 -- Fecha: 6/8/2022 22:59:59 
 	Select Id, Descripcion ,Precio ,Tipo ,Nombre  from Concepto
	Where (Id =  @Id)




GO

/****** Object:  StoredProcedure [dbo].[usp_ObtenerExamenByFiltro]    Script Date: 7/8/2022 01:06:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_ObtenerUsuarioByFiltro]
	@filtro nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	select * from  [Usuario] where [Nombre] like @filtro and IdTipo = 3
END
GO


-----------------------------------------------------------------Obtener concepto por filtro
CREATE PROCEDURE [dbo].[usp_ObtenerConceptoByFiltro]
	@filtro nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	select * from  [Concepto] where [Nombre] like @filtro
END
GO


--Select FacturaReport

SELECT        Usuario.ID, Usuario.Nombre, Usuario.Apellidos, EncabezadoFactura.IdFactura, EncabezadoFactura.FechaFacturacion, EncabezadoFactura.Total, DetalleFactura.Secuencia, DetalleFactura.IdConcepto, 
                       Concepto.Nombre,Concepto.Precio
FROM            Usuario INNER JOIN
                         EncabezadoFactura ON Usuario.ID = EncabezadoFactura.IdUsuario INNER JOIN
                         DetalleFactura ON EncabezadoFactura.IdFactura = DetalleFactura.IdFactura INNER JOIN
                         Concepto ON DetalleFactura.IdConcepto = Concepto.Id
WHERE        (EncabezadoFactura.IdFactura = 7)

--sELECCIONAR USUARIO POR IDFACTURA

select Usuario.Id from Usuario inner join EncabezadoFactura on Usuario.Id = EncabezadoFactura.IdUsuario where IdFactura = @IdFactura



--Select Usuario,entrenamiento,ejercicios

SELECT        Usuario.Id, Usuario.Nombre, Usuario.Apellidos,UsuarioxEntrenamiento.IdEntrenamiento, Entrenamiento.Nombre as 'Nombre entrenamiento',Entrenamiento.Descripcion as 'Descripción entrenamiento' ,Ejercicio.Nombre as 'Nombre Ejercicio',Ejercicio.Descripcion 'Descripción Ejercicio',Ejercicio.Imagen,TipoEjercicio.Nombre as 'Tipo Ejercicio'
FROM            Usuario INNER JOIN
                         UsuarioxEntrenamiento ON Usuario.Id = UsuarioxEntrenamiento.IdUsuario INNER JOIN
                         Entrenamiento on Entrenamiento.Id = UsuarioxEntrenamiento.IdEntrenamiento INNER JOIN Ejercicio on Ejercicio.IdEntrenamiento = Entrenamiento.Id inner join 
						 TipoEjercicio on TipoEjercicio.Id = Ejercicio.IdTipoEjercicio
						 where Usuario.Id = 123312312



--select enc y detalle


CREATE PROCEDURE [dbo].[usp_ObtenerEncyDetFacturaById]
	@IdFactura int
AS
BEGIN
	SET NOCOUNT ON;
		SELECT   EncabezadoFactura.IdFactura,EncabezadoFactura.IdUsuario , EncabezadoFactura.FechaFacturacion, EncabezadoFactura.ProximoPago, EncabezadoFactura.Total,
	DetalleFactura.Secuencia,Concepto.Id,Concepto.Nombre, Concepto.Precio
                   FROM           EncabezadoFactura INNER JOIN
                                        DetalleFactura ON EncabezadoFactura.IdFactura = DetalleFactura.IdFactura inner join
										Concepto on Concepto.Id = DetalleFactura.IdConcepto
                    WHERE        (EncabezadoFactura.IdFactura = @IdFactura)
END
GO




--Seleccionar fecha de pago más reciente 
select Max(EncabezadoFactura.ProximoPago) from EncabezadoFactura where IdUsuario = @IdUsuario


CREATE PROCEDURE [dbo].[usp_ObtenerProximoPago]
	@IdUsuario nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	select Max(EncabezadoFactura.ProximoPago) as 'ProximoPago' from EncabezadoFactura where IdUsuario = @IdUsuario
END
GO

----------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[usp_SelectEntrenamientoByIdUser]
	@IdUsuario nvarchar(50)

AS
BEGIN

select UsuarioxEntrenamiento.Id,UsuarioxEntrenamiento.IdUsuario, UsuarioxEntrenamiento.IdEntrenamiento,UsuarioxEntrenamiento.Dia, Entrenamiento.Nombre from UsuarioxEntrenamiento inner join 
Entrenamiento on Entrenamiento.Id = UsuarioxEntrenamiento.IdEntrenamiento where IdUsuario = @IdUsuario

END
GO
--------------------------------------------------------------------------------------------------------------------------
--Select Entrenamientos Ejercicios


CREATE PROCEDURE [dbo].[usp_SelectUserEntreEjerById]
	@IdUsuario nvarchar(50),
	@IdEntrenamiento int
AS
BEGIN
	SET NOCOUNT ON;
select Usuario.Nombre,Usuario.Apellidos, Usuario.Altura, Usuario.Peso,Usuario.IMC,Usuario.MetabolismoBasal,Entrenamiento.Nombre as 'NombreEntrenamiento',
Ejercicio.Nombre as 'NombreEjercicio',Ejercicio.Descripcion as 'DescripcionEjercicio',Ejercicio.Imagen as 'ImagenEjercicio',UsuarioxEntrenamiento.IdEntrenamiento,UsuarioxEntrenamiento.IdUsuario
from Usuario inner join UsuarioxEntrenamiento on Usuario.Id = UsuarioxEntrenamiento.IdUsuario inner join Entrenamiento on Entrenamiento.Id =
UsuarioxEntrenamiento.IdEntrenamiento inner join Ejercicio on Entrenamiento.Id = Ejercicio.IdEntrenamiento where UsuarioxEntrenamiento .IdUsuario
= @IdUsuario and UsuarioxEntrenamiento.IdEntrenamiento = @IdEntrenamiento
END
GO
exec usp_SelectUserEntreEjerById '702910826',1


select Usuario.Nombre,Usuario.Apellidos, Usuario.Altura, Usuario.Peso,Usuario.IMC,Usuario.MetabolismoBasal,Entrenamiento.Nombre as 'NombreEntrenamiento',
Ejercicio.Nombre as 'NombreEjercicio',Ejercicio.Descripcion as 'DescripcionEjercicio',Ejercicio.Imagen as 'ImagenEjercicio',UsuarioxEntrenamiento.IdEntrenamiento,UsuarioxEntrenamiento.IdUsuario
from Usuario inner join UsuarioxEntrenamiento on Usuario.Id = UsuarioxEntrenamiento.IdUsuario inner join Entrenamiento on Entrenamiento.Id =
UsuarioxEntrenamiento.IdEntrenamiento inner join Ejercicio on Entrenamiento.Id = Ejercicio.IdEntrenamiento where UsuarioxEntrenamiento .IdUsuario
= @IdUsuario and UsuarioxEntrenamiento.IdEntrenamiento = @IdEntrenamiento

---------------------------------------------------------------------------------------------

--Actualizar usuario by el usuario


Select * from UsuarioxEntrenamiento where IdUsuario = 702910826


--select ejercicios más utilizados



CREATE PROCEDURE [dbo].[usp_SelectEjerMasUtilizados]
AS
BEGIN
	SET NOCOUNT ON;
select Ejercicio.Nombre,COUNT(*) as'Contador' from Ejercicio inner join Entrenamiento on Entrenamiento.Id = Ejercicio.IdEntrenamiento 
inner join UsuarioxEntrenamiento on UsuarioxEntrenamiento.IdEntrenamiento = Entrenamiento.Id   GROUP BY Ejercicio.Nombre
    HAVING COUNT(*)>0;
	END
GO

exec usp_SelectEjerMasUtilizados


--Select facturas by rango de fecha

GO

/****** Object:  StoredProcedure [dbo].[usp_SelectFacturaByFechas]    Script Date: 11/8/2022 19:37:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_SelectFacturaByFechas]
@FechaDesde datetime,
@FechaHasta datetime
AS
BEGIN
select * from  EncabezadoFactura where EncabezadoFactura.FechaFacturacion between @FechaDesde and @FechaHasta
END
GO


--Select Ejercicios agrupados por tipo

select  Ejercicio.Nombre, Ejercicio.Id, Ejercicio.Descripcion, TipoEjercicio.Nombre from Ejercicio inner
join TipoEjercicio on Ejercicio.IdTipoEjercicio = TipoEjercicio.Id where TipoEjercicio.Id = 4


CREATE PROCEDURE [dbo].[usp_SelectEjerciciosByTipo]
@IdTipo int
AS
BEGIN

select  Ejercicio.Nombre, Ejercicio.Id, Ejercicio.Descripcion, TipoEjercicio.Nombre AS 'NombreTipo' from Ejercicio inner
join TipoEjercicio on Ejercicio.IdTipoEjercicio = TipoEjercicio.Id where TipoEjercicio.Id = @IdTipo
END
GO




--Select Entrenamiento ejercicios filtrado por clientes id


CREATE PROCEDURE [dbo].[usp_SelectEntreEjerByUsuario]
@IdUsuario nvarchar(50)
AS
BEGIN

select Usuario.Nombre,Usuario.Apellidos,Entrenamiento.Nombre as 'NombreEntrenamiento',
Ejercicio.Nombre as 'NombreEjercicio',Ejercicio.Descripcion as 'DescripcionEjercicio',Ejercicio.Imagen as 'ImagenEjercicio',UsuarioxEntrenamiento.IdEntrenamiento,UsuarioxEntrenamiento.IdUsuario
from Usuario inner join UsuarioxEntrenamiento on Usuario.Id = UsuarioxEntrenamiento.IdUsuario inner join Entrenamiento on Entrenamiento.Id =
UsuarioxEntrenamiento.IdEntrenamiento inner join Ejercicio on Entrenamiento.Id = Ejercicio.IdEntrenamiento where UsuarioxEntrenamiento .IdUsuario
= @IdUsuario

END
GO

---------------------------------------------------------------
--Update Concepto by ID
CREATE PROCEDURE [dbo].[usp_UpdateConceptoById]
@IdConcepto nvarchar(50),
@Precio numeric(18,2)
AS
BEGIN
update Concepto set Precio = @Precio where Id = @IdConcepto

END
GO



--Seleccionar usuarios morosos
CREATE PROCEDURE [dbo].[usp_SelectUsuariosMorosos]
AS
BEGIN
select EncabezadoFactura.IdUsuario, EncabezadoFactura.ProximoPago, Usuario.Nombre, DetalleFactura.IdConcepto,Concepto.Nombre as 'NombreConcepto',
DATEDIFF ( DAY, EncabezadoFactura.ProximoPago, GETDATE()) as 'DiasMoroso'
from EncabezadoFactura inner join Usuario on EncabezadoFactura.IdUsuario = Usuario.Id inner join DetalleFactura on EncabezadoFactura.IdFactura
= DetalleFactura.IdFactura inner join Concepto on DetalleFactura.IdConcepto = Concepto.Id  where  GETDATE() > ProximoPago and Concepto.Nombre = 'Mensualidad'
END
GO


select EncabezadoFactura.IdUsuario, EncabezadoFactura.ProximoPago, Usuario.Nombre, DetalleFactura.IdConcepto,Concepto.Nombre,
DATEDIFF ( DAY, GETDATE(), EncabezadoFactura.ProximoPago)
from EncabezadoFactura inner join Usuario on EncabezadoFactura.IdUsuario = Usuario.Id inner join DetalleFactura on EncabezadoFactura.IdFactura
= DetalleFactura.IdFactura inner join Concepto on DetalleFactura.IdConcepto = Concepto.Id  where  GETDATE() > ProximoPago and Concepto.Nombre = 'Mensualidad'






