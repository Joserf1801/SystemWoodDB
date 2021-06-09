--=================PROCEDIMIENTOS ALMACENADOS PRODUCTOS ===================
Use SystemWoodDB;
GO
--Agregar_Al_Surtido
CREATE PROC SP_AgregarAlSurtido
@claveProve int,
@claveProdu int
AS
INSERT INTO Surtido VALUES (@claveProve,@claveProdu,Convert (varchar,GETDATE()));
GO

--Agregar Producto
CREATE PROC SP_AgregarProducto
@Nombre varchar(25),
@Descripcion varchar(50)

AS
INSERT INTO Productos VALUES (@Nombre,@Descripcion);
GO

--Agregar Medidas
CREATE PROC SP_AgregarMedidas
@ClavePro int,
@Medida varchar(20),
@Precio Decimal(10,2),
@stock int
AS
INSERT INTO Medidas VALUES (@ClavePro,@Medida,@Precio,@stock);
GO

--AsignarClasificacion
CREATE PROC SP_AsignarClasificacion
@ClavePro int,
@id_Clasi int
AS 
INSERT INTO Clasificacion_Productos VALUES (@ClavePro,@id_Clasi);
GO

--AgregarClasificacion
CREATE PROC SP_AgregarClasificacion

@Nombre_Clasificacion varchar(30)
AS
INSERT INTO Clasificaciones VALUES (@Nombre_Clasificacion);

GO

--BUSCAR PRODUCTO
CREATE PROC SP_BuscarProducto
@Buscar varchar(10)
AS 
SELECT * FROM Productos 
WHERE Codigo LIKE @Buscar + '%' OR Nombre_Producto LIKE @Buscar+'%';
GO

--BUSCAR MEDIDAS
CREATE PROC SP_BuscarMedidas
@claveProducto int
AS
SELECT * FROM Medidas WHERE Clave_Producto=@claveProducto;
Go

--BUSCAR CATEGORIAS DE UN PRODUCTO
CREATE PROC SP_BuscarClasificacionDeProducto
@ClaveProducto int
AS
SELECT Clasificaciones.* FROM Clasificaciones 
INNER JOIN Clasificacion_Productos
ON Clasificacion_Productos.id_Clasificacion=Clasificaciones.id_Clasificacion;
GO

--BUSCAR TODOS LOS PRODCUTOS QUE TENGA X CLASIFICACIÓN
CREATE PROC SP_BuscarProductosPorClasificacion
@id_Categoria int
AS
SELECT Productos.* FROM Productos 
INNER JOIN (Clasificacion_Productos INNER JOIN Clasificaciones ON Clasificacion_Productos.id_Clasificacion=Clasificaciones.id_Clasificacion)
ON Productos.Clave_Producto=Clasificacion_Productos.Clave_Producto
WHERE Clasificacion_Productos.id_Clasificacion=@id_Categoria;

GO
--MODIFICAR PRODUCTO
CREATE PROC SP_ModificarProducto
@ClaveProducto int,
@Nombre varchar(25),
@Descripcion varchar(50)
AS
UPDATE Productos SET Nombre_Producto=@Nombre, Descripcion=@Descripcion
WHERE Productos.Clave_Producto =@ClaveProducto;
GO

--MODIFICAR MEDIDAS
CREATE PROC SP_ModificarMedidas
@ClavePro int,
@Medida varchar(20),
@Precio Decimal(10,2),
@stock int
AS
UPDATE Medidas SET Medida_Producto=@Medida, Precio_Procucto=@Precio, Stock_Producto=@stock
WHERE Clave_Producto=@ClavePro;
GO

--ELIMINAR PRODUCTO
CREATE PROC SP_EliminarProducto
@ClavePro int
AS
DELETE Productos WHERE Productos.Clave_Producto=@ClavePro;
GO
--ELIMINAR MEDIDA
CREATE PROC SP_EliminarMedida
@ClavePro int
AS
DELETE Medidas WHERE Medidas.Clave_Producto=@ClavePro;
GO
--QUITAR CATEGORIA
CREATE PROC SP_QuitarCategoria
@ClavePro int
AS
DELETE Clasificacion_Productos WHERE Clasificacion_Productos.Clave_Producto=@ClavePro
GO
--BUSCAR CODIGO DE PRODUCTO O NOMBRE
CREATE PROC SP_TodosCodigosProductos
AS
SELECT Codigo FROM Productos

Go
--Obtener las medidas de un producto por codigo
CREATE PROC SP_MedidasXClaveProducto
@Clave int
AS
SELECT Medidas.Medida_Producto
FROM Medidas 
WHERE Clave_Producto=@Clave;

GO
CREATE PROC SP_PrecioXMedidas
@clave int,
@medidas varchar(15)
AS
SELECT Medidas.Precio_Procucto
FROM Medidas 
WHERE Clave_Producto=@clave and Medida_Producto=@medidas;
GO


--CREAR 
CREATE PROC SP_ObtenerClaveXCodigo
@codigo varchar(10)
AS
SELECT Clave_Producto FROM Productos
WHERE Codigo = @codigo;
go