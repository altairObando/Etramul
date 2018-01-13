IF EXISTS (SELECT * FROM sysobjects WHERE name = 'TicketCarrera' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].TicketCarrera
GO

CREATE PROCEDURE [dbo].TicketCarrera
(
	@Codigo int
)
AS
	SET NOCOUNT ON;
SELECT        CASE c.TipoTransaccion WHEN 1 THEN 'Ingreso' ELSE 'Egreso' END AS Tipo, d.Descripcion, c.Cantidad
FROM            CarreraSet AS a INNER JOIN
                         TransaccionSet AS b ON a.No_transaccion = b.IdTransaccion INNER JOIN
                         DetalleSet AS c ON b.IdTransaccion = c.IdTransaccion INNER JOIN
                         TipoDetalleSet AS d ON c.TipoDetalle = d.IdTipoDetalle
WHERE        (c.TipoTransaccion = 0) AND (a.Id_carrera = @Codigo)
GO

