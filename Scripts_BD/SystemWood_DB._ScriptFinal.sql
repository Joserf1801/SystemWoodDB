CREATE DATABASE SystemWoodDB
GO
USE [SystemWoodDB]
GO
/****** Object:  Table [dbo].[Clasificacion_Productos]    Script Date: 18/01/2021 11:37:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clasificacion_Productos](
	[Clave_Producto] [int] NOT NULL,
	[id_Clasificacion] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clasificaciones]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clasificaciones](
	[id_Clasificacion] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('CLA'+right('00'+CONVERT([varchar],[id_Clasificacion]),(2))),
	[Clasificacion] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Clasificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuentas]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuentas](
	[NumeroCuenta] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](30) NOT NULL,
	[Contrasena] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NumeroCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Venta]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Venta](
	[Numero_Venta] [int] NOT NULL,
	[Clave_Producto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Medidas] [varchar](20) NULL,
	[Subtotal] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Clave_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('EMP'+right('00'+CONVERT([varchar],[Clave_Empleado]),(2))),
	[Nombre_Empleado] [varchar](20) NOT NULL,
	[Apellidos_Empleado] [varchar](30) NOT NULL,
	[Calle_Empleado] [varchar](25) NOT NULL,
	[Colonia_Empledo] [varchar](25) NOT NULL,
	[Municipio_Empleado] [varchar](20) NOT NULL,
	[CP_Empleado] [varchar](5) NULL,
	[TelefonoCasa_Empleado] [varchar](12) NOT NULL,
	[Celular_Empleado] [varchar](12) NULL,
	[RFC_Empleado] [varchar](15) NOT NULL,
	[Num_Cuenta] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Clave_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jefes]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jefes](
	[Num_jefe] [int] IDENTITY(1,1) NOT NULL,
	[Clave_Empleado] [int] NOT NULL,
	[PIN] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Num_jefe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medidas]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medidas](
	[Clave_Producto] [int] NOT NULL,
	[Medida_Producto] [varchar](20) NOT NULL,
	[Precio_Procucto] [decimal](10, 2) NOT NULL,
	[Stock_Producto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Clave_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('PRO'+right('00'+CONVERT([varchar],[Clave_Producto]),(2))),
	[Nombre_Producto] [varchar](25) NOT NULL,
	[Descripcion] [varchar](75) NULL,
PRIMARY KEY CLUSTERED 
(
	[Clave_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[Clave_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('PROV'+right('00'+CONVERT([varchar],[Clave_Proveedor]),(2))),
	[Nombre_Proveedor] [varchar](50) NOT NULL,
	[Telefono_Proveedor] [varchar](12) NOT NULL,
	[Celular_Proveedor] [varchar](12) NULL,
	[Calle_Proveedor] [varchar](25) NOT NULL,
	[Colonia_Proveedor] [varchar](25) NOT NULL,
	[Municipio_Proveedor] [varchar](20) NULL,
	[Estado_Proveedor] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Clave_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Surtido]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Surtido](
	[Clave_Proveedor] [int] NOT NULL,
	[Clave_Producto] [int] NOT NULL,
	[Fecha_Surtido] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trabajador]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajador](
	[Clave_Empleado] [int] NOT NULL,
	[Num_Trabajador] [int] IDENTITY(1,1) NOT NULL,
	[PIN] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Num_Trabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[Numero_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Clave_Empleado] [int] NOT NULL,
	[Total] [decimal](10, 2) NOT NULL,
	[Fecha] [varchar](15) NOT NULL,
	[Hora] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Numero_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clasificacion_Productos]  WITH CHECK ADD  CONSTRAINT [FK_ClaveProducto_ClasiPro] FOREIGN KEY([Clave_Producto])
REFERENCES [dbo].[Productos] ([Clave_Producto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Clasificacion_Productos] CHECK CONSTRAINT [FK_ClaveProducto_ClasiPro]
GO
ALTER TABLE [dbo].[Clasificacion_Productos]  WITH CHECK ADD  CONSTRAINT [FK_IdClasi_ClasiPro] FOREIGN KEY([id_Clasificacion])
REFERENCES [dbo].[Clasificaciones] ([id_Clasificacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Clasificacion_Productos] CHECK CONSTRAINT [FK_IdClasi_ClasiPro]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_ClaveProducto_Detalle] FOREIGN KEY([Clave_Producto])
REFERENCES [dbo].[Productos] ([Clave_Producto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [FK_ClaveProducto_Detalle]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_NumVenta_Detalle] FOREIGN KEY([Numero_Venta])
REFERENCES [dbo].[Ventas] ([Numero_Venta])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [FK_NumVenta_Detalle]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_NumCuenta_Empleados] FOREIGN KEY([Num_Cuenta])
REFERENCES [dbo].[Cuentas] ([NumeroCuenta])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_NumCuenta_Empleados]
GO
ALTER TABLE [dbo].[Jefes]  WITH CHECK ADD  CONSTRAINT [FK_ClaveEmpleado_Jefes] FOREIGN KEY([Clave_Empleado])
REFERENCES [dbo].[Empleados] ([Clave_Empleado])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Jefes] CHECK CONSTRAINT [FK_ClaveEmpleado_Jefes]
GO
ALTER TABLE [dbo].[Medidas]  WITH CHECK ADD  CONSTRAINT [FK_ClaveProducto_Medidas] FOREIGN KEY([Clave_Producto])
REFERENCES [dbo].[Productos] ([Clave_Producto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Medidas] CHECK CONSTRAINT [FK_ClaveProducto_Medidas]
GO
ALTER TABLE [dbo].[Surtido]  WITH CHECK ADD  CONSTRAINT [FK_ClaveProducto_Surtido] FOREIGN KEY([Clave_Producto])
REFERENCES [dbo].[Productos] ([Clave_Producto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Surtido] CHECK CONSTRAINT [FK_ClaveProducto_Surtido]
GO
ALTER TABLE [dbo].[Surtido]  WITH CHECK ADD  CONSTRAINT [FK_ClaveProveedor_Surtido] FOREIGN KEY([Clave_Proveedor])
REFERENCES [dbo].[Proveedores] ([Clave_Proveedor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Surtido] CHECK CONSTRAINT [FK_ClaveProveedor_Surtido]
GO
ALTER TABLE [dbo].[Trabajador]  WITH CHECK ADD  CONSTRAINT [FK_ClaveEmpleado_Trabajador] FOREIGN KEY([Clave_Empleado])
REFERENCES [dbo].[Empleados] ([Clave_Empleado])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Trabajador] CHECK CONSTRAINT [FK_ClaveEmpleado_Trabajador]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_ClaveEmpleado_Ventas] FOREIGN KEY([Clave_Empleado])
REFERENCES [dbo].[Empleados] ([Clave_Empleado])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_ClaveEmpleado_Ventas]
GO
/****** Object:  StoredProcedure [dbo].[Info_De_Ventas]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Info_De_Ventas]
@clave int,
@fecha varchar
AS
SELECT COUNT(Numero_Venta) AS 'Todas las ventas' FROM Ventas where Clave_Empleado=@clave
SELECT COUNT(Numero_Venta) AS 'Todas las ventas' FROM Ventas where Clave_Empleado=@clave and Fecha=@fecha
GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarAlSurtido]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Agregar_Al_Surtido
CREATE PROC [dbo].[SP_AgregarAlSurtido]
@claveProve int,
@claveProdu int
AS
INSERT INTO Surtido VALUES (@claveProve,@claveProdu,Convert (varchar,GETDATE()));
GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarClasificacion]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--AgregarClasificacion
CREATE PROC [dbo].[SP_AgregarClasificacion]

@Nombre_Clasificacion varchar(30)
AS
INSERT INTO Clasificaciones VALUES (@Nombre_Clasificacion);

GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarDetallesVenta]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_AgregarDetallesVenta]
@NumVenta int,
@clavePro int,
@Cantidad int,
@Medidas varchar(20),
@Subtotal varchar(10)

AS 
BEGIN TRAN TR_DetalleVenta
if @NumVenta=(select MAX(Ventas.Numero_Venta) FROM Ventas)
  begin
   INSERT INTO Detalle_Venta VALUES(@NumVenta,@clavePro,@Cantidad,@Medidas,@Subtotal);
   commit tran   
  end
else
  begin
  rollback tran
  print 'Error al realizar la venta'
  end
GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarEmpleado]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--AGREGAR EMPLEADO
CREATE PROC [dbo].[SP_AgregarEmpleado]
@Nombre varchar(20),
@Apellidos varchar(30),
@Calle varchar(25),
@Colonia varchar(25),
@Municipio varchar(20),
@CP varchar(5),
@Telefono varchar(12),
@Celular varchar(12),
@RFC varchar(15),
@NumCuenta int
AS
INSERT INTO Empleados VALUES (@Nombre,@Apellidos,@Calle,@Colonia,@Municipio,@CP,@Telefono,@Celular,@RFC,@NumCuenta);
GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarMedidas]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Agregar Medidas
CREATE PROC [dbo].[SP_AgregarMedidas]
@ClavePro int,
@Medida varchar(20),
@Precio Decimal(10,2),
@stock int
AS
INSERT INTO Medidas VALUES (@ClavePro,@Medida,@Precio,@stock);
GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarProducto]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Agregar Producto
CREATE PROC [dbo].[SP_AgregarProducto]
@Nombre varchar(25),
@Descripcion varchar(50)

AS
INSERT INTO Productos VALUES (@Nombre,@Descripcion);
GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarProveedor]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---Insertar Proveedor----
CREATE PROC [dbo].[SP_AgregarProveedor]
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
/****** Object:  StoredProcedure [dbo].[SP_AgregarVenta]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--AGREGAR VENTA
CREATE PROC [dbo].[SP_AgregarVenta]
@Clave_Empleado int,
@Total decimal (10,2),
@Fecha varchar(15),
@Hora varchar (10)
AS 
INSERT INTO Ventas VALUES (@Clave_Empleado,@Total,@Fecha,@Hora);
GO
/****** Object:  StoredProcedure [dbo].[SP_AsignarClasificacion]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--AsignarClasificacion
CREATE PROC [dbo].[SP_AsignarClasificacion]
@ClavePro int,
@id_Clasi int
AS 
INSERT INTO Clasificacion_Productos VALUES (@ClavePro,@id_Clasi);
GO
/****** Object:  StoredProcedure [dbo].[SP_AsignarPuestoJefe]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_AsignarPuestoJefe]
@ClaveEmp varchar(10),
@PIN varchar(5)
AS
INSERT INTO Jefes VALUES (@PIN,@ClaveEmp)
GO
/****** Object:  StoredProcedure [dbo].[SP_AsignarPuestoTrabajador]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_AsignarPuestoTrabajador]
@PIN varchar(5),
@ClaveEmp varchar(10)
AS
INSERT INTO Trabajador VALUES (@PIN,@ClaveEmp)
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarClasificacionDeProducto]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BuscarClasificacionDeProducto]
@ClaveProducto int
AS
SELECT Clasificaciones.* FROM Clasificaciones 
INNER JOIN Clasificacion_Productos
ON Clasificacion_Productos.id_Clasificacion=Clasificaciones.id_Clasificacion
where Clasificacion_Productos.Clave_Producto=@ClaveProducto;
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarCuenta]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BuscarCuenta]
@NumCuenta int
AS
SELECT * FROM Cuentas WHERE NumeroCuenta=@NumCuenta;
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarDetalleVenta]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BuscarDetalleVenta]
@Buscar varchar(20)
AS
SELECT Detalle_Venta.Numero_Venta,Codigo,Nombre_Producto, Detalle_Venta.Cantidad,Detalle_Venta.Medidas, Detalle_Venta.Subtotal
FROM Detalle_Venta INNER JOIN Productos ON Detalle_Venta.Clave_Producto=Productos.Clave_Producto
WHERE Numero_Venta=@Buscar;
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarFechaPorRango]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROC [dbo].[SP_BuscarFechaPorRango]
@FechaInicio varchar(10),
@FechaFinal varchar(10)
AS
SELECT Ventas.Numero_Venta,Ventas.Clave_Empleado,Ventas.Total,Convert(datetime,Ventas.Fecha,103) AS fecha,Ventas.Hora,Empleados.Codigo AS 'Codigo Empleado', Empleados.Nombre_Empleado +' '+ Empleados.Apellidos_Empleado AS 'Nombre de Empleado'
FROM Ventas INNER JOIN Empleados ON Empleados.Clave_Empleado=Ventas.Clave_Empleado
WHERE convert(datetime,Ventas.Fecha,103) BETWEEN CONVERT(DATETIME,@FechaInicio) AND CONVERT (DATETIME,@FechaFinal)
ORDER BY Numero_Venta DESC
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarIdClasiXNombre]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BuscarIdClasiXNombre]
@clasi varchar(30)
AS
SELECT Clasificaciones.id_Clasificacion FROM Clasificaciones WHERE Clasificaciones.Clasificacion=@clasi
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarMedidas]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--BUSCAR MEDIDAS
CREATE PROC [dbo].[SP_BuscarMedidas]
@claveProducto int
AS
SELECT * FROM Medidas WHERE Clave_Producto=@claveProducto;
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarProducto]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BuscarProducto]
@Buscar varchar(10)
AS 
SELECT * FROM Productos 
WHERE Codigo LIKE @Buscar + '%' OR Nombre_Producto LIKE @Buscar+'%';
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarProductosPorClasificacion]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BuscarProductosPorClasificacion]
@id_categoria int
AS
SELECT DISTINCT Productos.* FROM Productos 
INNER JOIN (Clasificacion_Productos INNER JOIN Clasificaciones ON Clasificacion_Productos.id_Clasificacion=Clasificaciones.id_Clasificacion)
ON Productos.Clave_Producto=Clasificacion_Productos.Clave_Producto
WHERE Clasificacion_Productos.id_Clasificacion=@id_categoria;
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarProveedor]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Buscar Proveedor---------
CREATE PROC [dbo].[SP_BuscarProveedor]
@Buscar varchar(20)
AS
SELECT * FROM Proveedores
WHERE Nombre_Proveedor LIKE @Buscar +'%' OR  Codigo LIKE @Buscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarVenta]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BuscarVenta]
@Buscar int
AS 
SELECT Ventas.*,Empleados.Codigo AS 'Codigo Empleado', Empleados.Nombre_Empleado +' '+ Empleados.Apellidos_Empleado AS 'Nombre de Empleado'
FROM Ventas INNER JOIN Empleados ON Empleados.Clave_Empleado=Ventas.Clave_Empleado
WHERE Ventas.Numero_Venta = @Buscar
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarVentaPorFecha]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BuscarVentaPorFecha]
@Fecha varchar(10)
AS
SELECT Ventas.*,Empleados.Codigo AS 'Codigo Empleado', Empleados.Nombre_Empleado +' '+ Empleados.Apellidos_Empleado AS 'Nombre de Empleado'
FROM Ventas INNER JOIN Empleados ON Empleados.Clave_Empleado=Ventas.Clave_Empleado
WHERE Ventas.Fecha=@Fecha
ORDER BY Numero_Venta DESC
GO
/****** Object:  StoredProcedure [dbo].[SP_ClaveUltimoProducto]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_ClaveUltimoProducto]
AS
SELECT MAX(Clave_Producto) FROM Productos;
GO
/****** Object:  StoredProcedure [dbo].[SP_CrearCuenta]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--CREAR CUENTA
CREATE PROC [dbo].[SP_CrearCuenta]
@usuario varchar(30),
@contra  varchar(15)
AS
INSERT INTO Cuentas VALUES (@usuario,@contra);
GO
/****** Object:  StoredProcedure [dbo].[SP_DesagsinarProductoDeCategoria]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DesagsinarProductoDeCategoria]
@claveProd int
AS
DELETE Clasificacion_Productos WHERE Clave_Producto=@claveProd;
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarCuentaYEmpleado]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_EliminarCuentaYEmpleado]
@numCuenta int
AS
DELETE Cuentas WHERE Cuentas.NumeroCuenta=@numCuenta
DELETE Empleados WHERE Num_Cuenta=@numCuenta;
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarMedida]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--ELIMINAR MEDIDA
CREATE PROC [dbo].[SP_EliminarMedida]
@ClavePro int
AS
DELETE Medidas WHERE Medidas.Clave_Producto=@ClavePro;
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarProducto]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ELIMINAR PRODUCTO
CREATE PROC [dbo].[SP_EliminarProducto]
@ClavePro int
AS
DELETE Productos WHERE Productos.Clave_Producto=@ClavePro;
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarProveedor]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_EliminarProveedor]
@ClaveProveedor int
AS
DELETE Proveedores WHERE Clave_Proveedor=@ClaveProveedor
GO
/****** Object:  StoredProcedure [dbo].[SP_ExisteCuenta]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMINETO PARA COMPROBAR SI LA CUENTA YA EXISTE
CREATE PROC [dbo].[SP_ExisteCuenta]
@usuario varchar(30),
@contra  varchar(15)
AS
SELECT * FROM Cuentas WHERE Usuario=@usuario AND Contrasena=@contra
GO
/****** Object:  StoredProcedure [dbo].[SP_GetNumeroDeVentaFinal]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ULTIMA VENTA REALIZADA
CREATE PROC [dbo].[SP_GetNumeroDeVentaFinal]
AS
SELECT MAX(Numero_Venta) FROM Ventas

GO
/****** Object:  StoredProcedure [dbo].[SP_GetUltimaCuenta]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GetUltimaCuenta]
AS
SELECT MAX(NumeroCuenta) FROM Cuentas;

GO
/****** Object:  StoredProcedure [dbo].[SP_GetUltimoCodigoDeProveedor]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--DEVUELVE LA ULTIMA CLAVE DEL PROVEEDOR
CREATE PROC [dbo].[SP_GetUltimoCodigoDeProveedor]
AS
SELECT MAX(Clave_Proveedor) FROM Proveedores
GO
/****** Object:  StoredProcedure [dbo].[SP_InfomacionDeUsuarioPorCuenta]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_InfomacionDeUsuarioPorCuenta]
@numCuenta int
AS
SELECT Empleados.*, Usuario, Contrasena FROM Empleados INNER JOIN Cuentas ON Empleados.Num_Cuenta=Cuentas.NumeroCuenta
WHERE Empleados.Num_Cuenta=@numCuenta;

GO
/****** Object:  StoredProcedure [dbo].[SP_MedidasXClaveProducto]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MedidasXClaveProducto]
@Clave int
AS
SELECT Medidas.Medida_Producto
FROM Medidas 
WHERE Clave_Producto=@Clave;

GO
/****** Object:  StoredProcedure [dbo].[SP_ModificarCuenta]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ModificarCuenta]
@NumCuenta int,
@usuario varchar(30),
@contra varchar(15)
AS
UPDATE Cuentas SET Usuario=@usuario, Contrasena=@contra 
WHERE NumeroCuenta = @NumCuenta;
GO
/****** Object:  StoredProcedure [dbo].[SP_ModificarEmpleado]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--MODIFICAR EMPLEADO
CREATE PROC [dbo].[SP_ModificarEmpleado]
@ClaveEmpleado varchar (5),
@Nombre varchar(20),
@Apellidos varchar(30),
@Calle varchar(25),
@Colonia varchar(25),
@Municipio varchar(20),
@CP varchar(5),
@Telefono varchar(12),
@Celular varchar(12),
@RFC varchar(15),
@NumCuenta int

AS 
UPDATE Empleados SET Nombre_Empleado=@Nombre,Apellidos_Empleado=@Apellidos,Calle_Empleado=@Calle,Colonia_Empledo=@Colonia,Municipio_Empleado=@Municipio,CP_Empleado=@CP, TelefonoCasa_Empleado=@Telefono, Celular_Empleado=@Celular,RFC_Empleado=@RFC
WHERE Clave_Empleado=@ClaveEmpleado;
GO
/****** Object:  StoredProcedure [dbo].[SP_ModificarMedidas]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--MODIFICAR MEDIDAS
CREATE PROC [dbo].[SP_ModificarMedidas]
@ClavePro int,
@Medida varchar(20),
@Precio Decimal(10,2),
@stock int
AS
UPDATE Medidas SET Medida_Producto=@Medida, Precio_Procucto=@Precio, Stock_Producto=@stock
WHERE Clave_Producto=@ClavePro;
GO
/****** Object:  StoredProcedure [dbo].[SP_ModificarProducto]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--MODIFICAR PRODUCTO
CREATE PROC [dbo].[SP_ModificarProducto]
@ClaveProducto int,
@Nombre varchar(25),
@Descripcion varchar(50)
AS
UPDATE Productos SET Nombre_Producto=@Nombre, Descripcion=@Descripcion
WHERE Productos.Clave_Producto =@ClaveProducto;
GO
/****** Object:  StoredProcedure [dbo].[SP_ModificarProveedor]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ModificarProveedor]
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
/****** Object:  StoredProcedure [dbo].[SP_MostrarEmpleados]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MostrarEmpleados]
as
SELECT Empleados.* FROM Empleados INNER JOIN Trabajador 
ON Empleados.Clave_Empleado=Trabajador.Clave_Empleado
GO
/****** Object:  StoredProcedure [dbo].[SP_NUMDEVENTASDELDIA]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROC [dbo].[SP_NUMDEVENTASDELDIA]
 @Fecha varchar(10)
 AS
 SELECT COUNT(Numero_Venta) FROM Ventas WHERE Fecha=@Fecha;
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerClaveXCodigo]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ObtenerClaveXCodigo]
@codigo varchar(10)
AS
SELECT Clave_Producto FROM Productos
WHERE Codigo = @codigo;
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerNombreUsuarioClaveEmpleado]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ObtenerNombreUsuarioClaveEmpleado]
AS
SELECT Usuario FROM Cuentas
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerUltimaClaveEmpleado]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ObtenerUltimaClaveEmpleado]
as
select max(Clave_Empleado) from Empleados
GO
/****** Object:  StoredProcedure [dbo].[SP_PrecioXMedidas]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PrecioXMedidas]
@clave int,
@medidas varchar(15)
AS
SELECT Medidas.Precio_Procucto
FROM Medidas 
WHERE Clave_Producto=@clave and Medida_Producto=@medidas;
GO
/****** Object:  StoredProcedure [dbo].[SP_ProductosDeProveedor]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--CONSULTA PARA VER TODOS LOS PRODUCTOS QUE PROVEE UN DETERMINADO PROVEEDOR (PARAMETRO CLAVE DEL PROVEEDOR) 
CREATE PROC [dbo].[SP_ProductosDeProveedor]
@claveProveedor int
AS
SELECT Proveedores.Codigo AS 'Codigo Proveedor', Productos.Codigo AS 'Codigo Producto',Productos.Nombre_Producto,Productos.Descripcion 
FROM Proveedores INNER JOIN (Surtido INNER JOIN Productos ON Surtido.Clave_Producto=Productos.Clave_Producto)
ON Proveedores.Clave_Proveedor=Surtido.Clave_Proveedor
WHERE Proveedores.Clave_Proveedor=@claveProveedor
ORDER BY Proveedores.Codigo
GO
/****** Object:  StoredProcedure [dbo].[SP_QuitarCategoria]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--QUITAR CATEGORIA
CREATE PROC [dbo].[SP_QuitarCategoria]
@ClavePro int
AS
DELETE Clasificacion_Productos WHERE Clasificacion_Productos.Clave_Producto=@ClavePro

GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteVenta]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ReporteVenta]
@FechaI varchar(20),
@FechaF varchar(20)
AS
SELECT Detalle_Venta.Numero_Venta,Codigo,CONVERT (datetime,Ventas.Fecha,103) as Fecha,Ventas.Hora,Productos.Nombre_Producto,Detalle_Venta.Medidas, Cantidad, Detalle_Venta.Subtotal, Ventas.Total AS 'total de la venta'
FROM (Detalle_Venta INNER JOIN Productos ON Detalle_Venta.Clave_Producto=Productos.Clave_Producto) INNER JOIN Ventas on Detalle_Venta.Numero_Venta=Ventas.Numero_Venta
WHERE convert(datetime,Ventas.Fecha,103) BETWEEN Convert (datetime,@FechaI) AND convert(datetime,@FechaF)
ORDER BY Detalle_Venta.Numero_Venta ASC

GO
/****** Object:  StoredProcedure [dbo].[SP_RestarStock]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_RestarStock]
@cantidad decimal (10,2),
@ClavePro int,
@Medidas varchar(20)
AS
UPDATE Medidas SET Stock_Producto = (Stock_Producto-@cantidad)
WHERE Clave_Producto=@ClavePro AND Medidas.Medida_Producto=@Medidas

GO
/****** Object:  StoredProcedure [dbo].[SP_TodasClasificaciones]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TodasClasificaciones]
AS
SELECT Clasificacion FROM Clasificaciones
GO
/****** Object:  StoredProcedure [dbo].[SP_TodoLosJefes]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--MUESTRA TODOS LOS EMPLEADOS Q SON JEFES
CREATE PROC [dbo].[SP_TodoLosJefes]
@PIN varchar (5)
AS
SELECT Empleados.* FROM Empleados INNER JOIN Jefes 
ON Empleados.Clave_Empleado=Jefes.Clave_Empleado
WHERE Jefes.PIN=@PIN;

GO
/****** Object:  StoredProcedure [dbo].[SP_TodoLosTrabajadores]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TodoLosTrabajadores]
@PIN varchar (5)
AS
SELECT Empleados.* FROM Empleados INNER JOIN Trabajador 
ON Empleados.Clave_Empleado=Trabajador.Clave_Empleado
WHERE Trabajador.PIN=@PIN;
GO
/****** Object:  StoredProcedure [dbo].[SP_TodosCodigosProductos]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TodosCodigosProductos]
AS
SELECT Codigo FROM Productos

GO
/****** Object:  StoredProcedure [dbo].[SP_TodosLosEmpleados]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TodosLosEmpleados]
@Codigo varchar(10)
AS
SELECT * FROM Empleados WHERE Codigo = @Codigo OR Nombre_Empleado like @Codigo+'%'
GO
/****** Object:  StoredProcedure [dbo].[SP_TodosNombresProductos]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TodosNombresProductos]
AS
SELECT Nombre_Producto FROM Productos
GO
/****** Object:  StoredProcedure [dbo].[SP_TotalCategorias]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_TotalCategorias]
AS
SELECT COUNT(Clasificaciones.id_Clasificacion) From Clasificaciones;
GO
/****** Object:  StoredProcedure [dbo].[SP_TOTALDEVENTASDELDIA]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROC [dbo].[SP_TOTALDEVENTASDELDIA]
 @Fecha varchar(10)
 AS
 SELECT Sum(Total) FROM Ventas WHERE Fecha=@Fecha;
GO
/****** Object:  StoredProcedure [dbo].[SP_TotalProductos]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TotalProductos]
AS
SELECT COUNT(Productos.Clave_Producto) From Productos;

GO
/****** Object:  StoredProcedure [dbo].[SP_VerificarPrivilegios]    Script Date: 18/01/2021 11:37:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_VerificarPrivilegios]
@claveEmpleado int 
AS
if Exists (SELECT Clave_Empleado FROM Jefes WHERE Clave_Empleado=@claveEmpleado)
  BEGIN
    SELECT PIN FROM Jefes  WHERE Clave_Empleado=@claveEmpleado
  END
 else
   if Exists (SELECT Clave_Empleado FROM Trabajador WHERE Clave_Empleado=@claveEmpleado)
   BEGIN
   SELECT PIN FROM Trabajador  WHERE Clave_Empleado=@claveEmpleado
   end
GO
