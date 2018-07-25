update compras_adelantos set codagencia = c.codagencia 
from (select * from compras) c 
where compras_adelantos.numcompra = c.numcompra and c.adelantos>0