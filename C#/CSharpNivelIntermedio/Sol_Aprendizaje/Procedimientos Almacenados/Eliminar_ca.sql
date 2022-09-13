Create procedure USP_Eliminar_ca
@Codigo int = 0
as
UPDATE TB_CATEGORIAS SET estado = 0 
	WHERE codigo_ca = @Codigo; 
go