Create procedure USP_Listado_ca
@cTexto varchar(30) = ''
as
SELECT codigo_ca, descripcion_ca 
FROM TB_CATEGORIAS
WHERE estado = 1 AND upper(trim(descripcion_ca)) LIKE + '%' + upper(trim(@cTexto)) + '%' 
ORDER BY codigo_ca; 
go