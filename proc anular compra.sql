alter procedure anularCompra
@numeroCompra varchar(20)
as
update compras set peso = 0, total = 0, codestado = 0, efectivo = 0,cheque = 0,transferencia = 0,por_cobrar= 0,
 por_pagar = 0, adelantos = 0, saldo_por_pagar = 0 where numcompra = @numeroCompra
 update det_compra set preciok = 0, peso = 0, importe = 0, kilshowdoc = ''
 where numcompra = @numeroCompra
 delete from compras_adelantos where numcompra = @numeroCompra