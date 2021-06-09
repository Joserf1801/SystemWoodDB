--=================PROCEDIMIENTOS ALMACENADOS EMPLEADO ===================
use SystemWoodDB;
GO
--AGREGAR EMPLEADO
CREATE PROC SP_AgregarEmpleado
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
--MODIFICAR EMPLEADO
CREATE PROC SP_ModificarEmpleado
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

--Asignar puesto de jefe
CREATE PROC SP_AsignarPuestoJefe
@ClaveEmp varchar(10),
@PIN varchar(5)
AS
INSERT INTO Jefes VALUES (@ClaveEmp,@PIN)
GO

GO
--Asignar puesto de trabajador
CREATE PROC SP_AsignarPuestoTrabajador
@PIN varchar(5),
@ClaveEmp varchar(10)
AS
INSERT INTO Trabajador VALUES (@PIN,@ClaveEmp)
GO


--MUESTRA TODOS LOS EMPLEADOS QUE SON TRABAJADORES
CREATE PROC SP_TodoLosTrabajadores
@PIN varchar (5)
AS
SELECT Empleados.* FROM Empleados INNER JOIN Trabajador 
ON Empleados.Clave_Empleado=Trabajador.Clave_Empleado
WHERE Trabajador.PIN=@PIN;

GO
--MUESTRA TODOS LOS EMPLEADOS Q SON JEFES
CREATE PROC SP_TodoLosJefes
@PIN varchar (5)
AS
SELECT Empleados.* FROM Empleados INNER JOIN Jefes 
ON Empleados.Clave_Empleado=Jefes.Clave_Empleado
WHERE Jefes.PIN=@PIN;

GO
