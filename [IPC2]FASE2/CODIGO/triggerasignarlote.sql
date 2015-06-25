
CREATE TRIGGER asigar_lote
   ON pedido
   AFTER insert
AS 
BEGIN
	declare @cod_pedido as int
	declare @cod_sucursal as int
	declare @fecha as date
	declare @cod_lote as int
	select @cod_sucursal=cod_sucursal,
		   @fecha=fecha
	from inserted
	select top 1 @cod_pedido=cod_pedido from pedido order by cod_pedido desc
	select top 1 @cod_lote=cod_lote from lote where fecha>@fecha and @cod_sucursal=cod_sucursal
	update pedido set cod_lote=@cod_lote where cod_pedido=@cod_pedido
END
GO
