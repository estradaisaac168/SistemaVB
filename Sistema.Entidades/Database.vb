Public Class Database

    Public Sub New()



        'Listar categorias
        'create proc categoria_listar
        'as
        'select idcategoria as ID, nombre as Nombre, description as Description, estado as Estado
        'from categoria
        'order by idcategoria desc
        'go



        'Buscar categorias
        'create proc categoria_buscar
        '@valor varchar(50)
        'as
        'select idcategoria as ID, nombre as Nombre, description as Description, estado as Estado
        'from categoria
        'where nombre like '%' + @valor + '%' Or descripcion like '%' + @valor + '%'
        'order by nombre desc
        'go


        'Crear categoria
        'create proc categoria_insertar
        '@nombre varchar(50),
        '@descripcion varchar(255)
        'as
        'insert into categoria (nombre, descripcion) values (@nombre, @descripcion)
        'go


        'Actualizar categoria
        'create proc categoria_actualizar
        '@idcategoria int,
        '@nombre varchar(50),
        '@descripcion varchar(255)
        'as 
        'update categoria set nombre = @nombre, descripcion = @descripcion
        'where idcategoria = @idcategoria
        'go


        'Eliminar categoria
        'create proc categoria_eliminar
        '@idcategoria int
        'as 
        'delete from categoria
        'where idcategoria = @idcategoria
        'go


        'Desactivar categoria
        'create proc categoria_desactivar
        '@idcategoria int,
        'as 
        'update categoria set estado = 0
        'where idcategoria = @idcategoria
        'go



        'Activar categoria
        'create proc categoria_activar
        '@idcategoria int,
        'as 
        'update categoria set estado = 1
        'where idcategoria = @idcategoria
        'go


    End Sub

End Class
