Create procedure USP_Guardar_ca
@Opcion int = 0,
@Codigo_ca int = 0, 
@Descripcion_ca varchar(30) = '' 
as
if @Opcion=1 --Nuevo Registro
begin
	INSERT INTO TB_CATEGORIAS(descripcion_ca, estado) VALUES(@Descripcion_ca, 1); 
end;
else --Actualizar Registro
begin
	UPDATE TB_CATEGORIAS SET descripcion_ca = @Descripcion_ca
	WHERE codigo_ca = @Codigo_ca; 
end
go
