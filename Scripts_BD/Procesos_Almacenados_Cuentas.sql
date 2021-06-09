--=================PROCEDIMIENTOS ALMACENADOS CUENTAS ===================
use SystemWoodDB;
go

--CREAR CUENTA
CREATE PROC SP_CrearCuenta
@usuario varchar(30),
@contra  varchar(15)
AS
INSERT INTO Cuentas VALUES (@usuario,@contra);
GO

--MODIFICAR CUENTA

CREATE PROC SP_ModificarCuenta 
@usuario varchar(30),
@contra  varchar(15)
AS
UPDATE Cuentas SET Usuario=@usuario, Contrasena=@contra;
GO

--PROCEDIMINETO PARA COMPROBAR SI LA CUENTA YA EXISTE
CREATE PROC SP_ExisteCuenta
@usuario varchar(30),
@contra  varchar(15)
AS
SELECT * FROM Cuentas WHERE Usuario=@usuario AND Contrasena=@contra
GO

CREATE PROC SP_EliminarCuentaYEmpleado
@numCuenta int
AS
DELETE Cuentas WHERE Cuentas.NumeroCuenta=@numCuenta
DELETE Empleados WHERE Num_Cuenta=@numCuenta;

GO
CREATE alter PROC SP_InfomacionDeUsuarioPorCuenta
@numCuenta int
AS
SELECT Empleados.Clave_Empleado, Empleados.Codigo, Empleados.Nombre_Empleado, Empleados.Apellidos_Empleado FROM Empleados
WHERE Empleados.Num_Cuenta=5;
GO

CREATE PROC SP_GetUltimaCuenta
AS
SELECT MAX(NumeroCuenta) FROM Cuentas;
GO