--=================PROCEDIMIENTOS ALMACENADOS PROVEEDORES ===================
GO
Use SystemWoodDB;

GO
--Buscar Proveedor---------
CREATE PROC SP_BuscarProveedor
@Buscar varchar(20)
AS
SELECT * FROM Proveedores
WHERE Nombre_Proveedor LIKE @Buscar +'%' OR  Codigo LIKE @Buscar + '%'
GO
---Insertar Proveedor----
CREATE PROC SP_AgregarProveedor
@Nombre varchar(50),
@Telefono varchar(12),
@Celular varchar(12),
@Calle varchar(25),
@Colonia varchar(25),
@Municipio varchar(20),
@Estado varchar(20)
AS
INSERT INTO Proveedores VALUES (@Nombre,@Telefono,@Celular,@Calle,@Colonia,@Municipio,@Estado);

--Editar Proveedor--
GO
CREATE PROC SP_ModificarProveedor
@Clave_Proveedor int,
@Nombre varchar(50),
@Telefono varchar(12),
@Celular varchar(12),
@Calle varchar(25),
@Colonia varchar(25),
@Municipio varchar(20),
@Estado varchar(20)
AS
UPDATE Proveedores 
SET Nombre_Proveedor=@Nombre, Telefono_Proveedor=@Telefono,Celular_Proveedor=@Celular,Calle_Proveedor=@Calle,Colonia_Proveedor=@Colonia, Municipio_Proveedor=@Municipio, Estado_Proveedor=@Estado
WHERE Clave_Proveedor = @Clave_Proveedor;

GO
CREATE PROC SP_EliminarProveedor
@ClaveProveedor int
AS
DELETE Proveedores WHERE Clave_Proveedor=@ClaveProveedor
GO

--CONSULTA PARA VER TODOS LOS PRODUCTOS QUE PROVEE UN DETERMINADO PROVEEDOR (PARAMETRO CLAVE DEL PROVEEDOR) 
CREATE PROC SP_ProductosDeProveedor
@claveProveedor int
AS
SELECT Proveedores.Codigo AS 'Codigo Proveedor', Productos.Codigo AS 'Codigo Producto',Productos.Nombre_Producto,Productos.Descripcion 
FROM Proveedores INNER JOIN (Surtido INNER JOIN Productos ON Surtido.Clave_Producto=Productos.Clave_Producto)
ON Proveedores.Clave_Proveedor=Surtido.Clave_Proveedor
WHERE Proveedores.Clave_Proveedor=@claveProveedor
ORDER BY Proveedores.Codigo
GO

--DEVUELVE LA ULTIMA CLAVE DEL PROVEEDOR
CREATE PROC SP_GetUltimoCodigoDeProveedor
AS
SELECT MAX(Clave_Proveedor) FROM Proveedores
GO

