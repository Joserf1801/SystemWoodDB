CREATE DATABASE SystemWoodDB;
GO
use SystemWoodDB;
CREATE TABLE Proveedores
(
 Clave_Proveedor int IDENTITY (1,1) PRIMARY KEY not null,
 Codigo AS ('PROV' + RIGHT ('00' + CONVERT (Varchar, Clave_Proveedor), (2))),
 Nombre_Proveedor Varchar(50)   not null,
 Telefono_Proveedor varchar(12) not null, 
 Celular_Proveedor Varchar(12),
 Calle_Proveedor varchar(25)    not null,
 Colonia_Proveedor varchar(25)  not null,
 Municipio_Proveedor varchar(20),
 Estado_Proveedor varchar(20)
);

GO

CREATE TABLE Productos
(
 Clave_Producto int IDENTITY (1,1) PRIMARY KEY not null,
 Codigo AS ('PRO' + RIGHT ('00' + CONVERT (Varchar, Clave_Producto),(2))),
 Nombre_Producto varchar(25) not null,
 Descripcion varchar(75)
);
GO
CREATE TABLE Surtido
(
 Clave_Proveedor int not null,
 Clave_Producto  int not null,
 Fecha_Surtido   varchar(20)not null,

 CONSTRAINT FK_ClaveProveedor_Surtido 
 FOREIGN KEY (Clave_Proveedor) REFERENCES Proveedores(Clave_Proveedor)
 ON UPDATE CASCADE
 ON DELETE CASCADE,

 CONSTRAINT FK_ClaveProducto_Surtido FOREIGN KEY (Clave_Producto)
 REFERENCES Productos(Clave_Producto)
 ON UPDATE CASCADE
 ON DELETE CASCADE

);

GO
CREATE TABLE Medidas
(
  Clave_Producto  int not null,
  Medida_Producto varchar(20) not null,
  Precio_Procucto Decimal (10,2) not null,
  Stock_Producto int not null,

 CONSTRAINT FK_ClaveProducto_Medidas FOREIGN KEY (Clave_Producto)
 REFERENCES Productos(Clave_Producto)
 ON UPDATE CASCADE
 ON DELETE CASCADE

);

GO
CREATE TABLE Clasificaciones
(
  id_Clasificacion int IDENTITY(1,1) PRIMARY KEY not null,
  Codigo AS ('CLA' + RIGHT ('00' + CONVERT (Varchar,id_Clasificacion),(2))),
  Clasificacion varchar(30) not null
);

GO

CREATE TABLE Clasificacion_Productos
(
  Clave_Producto int not null,
  id_Clasificacion int not null

  CONSTRAINT FK_ClaveProducto_ClasiPro FOREIGN KEY (Clave_Producto)
 REFERENCES Productos(Clave_Producto)
 ON UPDATE CASCADE
 ON DELETE CASCADE,

 CONSTRAINT FK_IdClasi_ClasiPro FOREIGN KEY (id_Clasificacion)
 REFERENCES Clasificaciones(id_Clasificacion)
 ON UPDATE CASCADE
 ON DELETE CASCADE
);
GO

CREATE TABLE Cuentas
(
  NumeroCuenta int IDENTITY PRIMARY KEY not null,
  Usuario varchar(30) not null,
  Contrasena varchar(15)not null
);
GO
CREATE TABLE Empleados
(
 Clave_Empleado int IDENTITY(1,1) PRIMARY KEY not null,
 Codigo AS ('EMP' + RIGHT ('00' + CONVERT (Varchar,Clave_Empleado),(2))),
 Nombre_Empleado varchar(20) not null,
 Apellidos_Empleado varchar(30) not null,
 Calle_Empleado varchar(25) not null,
 Colonia_Empledo varchar(25)not null,
 Municipio_Empleado varchar(20) not null,
 CP_Empleado varchar(5),
 TelefonoCasa_Empleado varchar(12) not null,
 Celular_Empleado varchar(12) null,
 RFC_Empleado varchar(15) not null,
 Num_Cuenta int not null,
 
 CONSTRAINT FK_NumCuenta_Empleados FOREIGN KEY (Num_Cuenta)
 REFERENCES Cuentas(NumeroCuenta)
 ON UPDATE CASCADE
 ON DELETE CASCADE

);
GO
CREATE TABLE Ventas
(
 Numero_Venta int IDENTITY PRIMARY KEY not null,
 Clave_Empleado int not null,
 Total decimal (10,2) not null,
 Fecha varchar(15) not null,
 Hora varchar(10) not null,

 CONSTRAINT FK_ClaveEmpleado_Ventas FOREIGN KEY (Clave_Empleado)
 REFERENCES Empleados(Clave_Empleado)
 ON UPDATE CASCADE
 ON DELETE CASCADE
);
GO

CREATE TABLE Detalle_Venta 
(
  Numero_Venta int not null,
  Clave_Producto  int not null,  
  Cantidad int not null,

 CONSTRAINT FK_ClaveProducto_Detalle FOREIGN KEY (Clave_Producto)
 REFERENCES Productos(Clave_Producto)
 ON UPDATE CASCADE
 ON DELETE CASCADE,

  CONSTRAINT FK_NumVenta_Detalle FOREIGN KEY (Numero_Venta)
 REFERENCES Ventas(Numero_Venta)
 ON UPDATE CASCADE
 ON DELETE CASCADE
);

GO
CREATE TABLE Jefes
(
 Num_jefe int IDENTITY (1,1)PRIMARY KEY not null,
 Clave_Empleado int not null, 
 PIN varchar(5) not null,

 CONSTRAINT FK_ClaveEmpleado_Jefes FOREIGN KEY (Clave_Empleado)
 REFERENCES Empleados(Clave_Empleado)
 ON UPDATE CASCADE
 ON DELETE CASCADE
);
GO

CREATE TABLE Trabajador
(
 Clave_Empleado int not null,
 Num_Trabajador int IDENTITY (1,1) PRIMARY KEY not null,
 PIN varchar(5) not null,
 
 CONSTRAINT FK_ClaveEmpleado_Trabajador FOREIGN KEY (Clave_Empleado)
 REFERENCES Empleados(Clave_Empleado)
 ON UPDATE CASCADE
 ON DELETE CASCADE
);
GO






