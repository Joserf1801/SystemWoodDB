--=================PROCEDIMIENTOS ALMACENADOS VENTAS ===================
Use SystemWoodDB;
GO

--AGREGAR VENTA
CREATE PROC SP_AgregarVenta

@Clave_Empleado int,
@Total decimal (10,2),
@Fecha varchar(15),
@Hora varchar (10)
AS 
INSERT INTO Ventas VALUES (@Clave_Empleado,@Total,@Fecha,@Hora);
GO

--DETALLES DE LA VENTA
CREATE PROC SP_AgregarDetallesVenta
@NumVenta int,
@clavePro int,
@Cantidad int
AS 
INSERT INTO Detalle_Venta VALUES(@NumVenta,@clavePro,@Cantidad);
GO

--BUSCAR VENTA
CREATE PROC SP_BuscarVenta
@Buscar int
AS 
SELECT Ventas.*,Empleados.Codigo AS 'Codigo Empleado', Empleados.Nombre_Empleado +' '+ Empleados.Apellidos_Empleado AS 'Nombre de Empleado'
FROM Ventas INNER JOIN Empleados ON Empleados.Clave_Empleado=Ventas.Clave_Empleado
WHERE Ventas.Numero_Venta LIKE @Buscar OR Ventas.Clave_Empleado LIKE @Buscar;
GO

--BUSCAR DETALLES DE LA VENTA
CREATE PROC SP_BuscarDetalleVenta
@Buscar varchar(20)
AS
SELECT Detalle_Venta.Numero_Venta,Codigo,Nombre_Producto,Cantidad
FROM Detalle_Venta INNER JOIN Productos ON Detalle_Venta.Clave_Producto=Productos.Clave_Producto
WHERE Numero_Venta=@Buscar;
GO

--ULTIMA VENTA REALIZADA
CREATE PROC SP_GetNumeroDeVentaFinal
AS
SELECT MAX(Numero_Venta) FROM Ventas
go

--MODIFICAR STOCK
CREATE PROC SP_RestarStock
@cantidad decimal (10,2),
@ClavePro int,
@Medidas varchar(20)
AS
UPDATE Medidas SET Stock_Producto = (Stock_Producto-@cantidad)
WHERE Clave_Producto=@ClavePro AND Medidas.Medida_Producto=@Medidas
GO