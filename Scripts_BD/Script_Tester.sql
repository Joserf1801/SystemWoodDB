use SystemWoodDB;
go
--Empleado1
Execute SP_CrearCuenta 'JuVaLo31','ju@nV@zquez'
Execute SP_AgregarEmpleado 'Juan','Vazquez López', 'Zaragoza','Centro','Atlixco','74323','2441236789','2445671234','VALOJU12343', 1;
Execute SP_AsignarPuestoTrabajador 1,'34789'
go
--Empleado2
Execute SP_CrearCuenta 'EnPuPe12','enrique4379Perez'
Execute SP_AgregarEmpleado 'Enrique','Puentes Pérez', '9 de mayo','Panteon','Metepec','74893','244673456','2449081235','PUPE881201JI', 2;
Execute SP_AsignarPuestoTrabajador 2,'43789'
go
--Empleado 3
Execute SP_CrearCuenta 'ReQuFl89','Rey123florez'
Execute SP_AgregarEmpleado 'Reyna','Quintero Flores', '7 poniente','Centro','Atlixco','74360','2449082367','2447652345','QUFR790612FE', 3;
Execute SP_AsignarPuestoJefe 3,'21323'
go
--Empleado 4
Execute SP_CrearCuenta 'JoLoMo74','j@seL0p3z'
Execute SP_AgregarEmpleado 'José','López Montes', '5 poniente','Lazaro Cardena','Atlixco','74360','2443243565','2224567213','LOMA890423GH', 4;
Execute SP_AsignarPuestoJefe 4,'21323'

Execute SP_CrearCuenta 'joserf','1801'
Execute SP_AgregarEmpleado 'José Antonio','Ramírez Franco', '7 poniente','Centro','Atlixco','74360','2449082367','2447652345','QUFR790612FE', 5;
Execute SP_AsignarPuestoJefe 5,'21323'

UPDATE Empleados SET Num_Cuenta=5 where Clave_Empleado=5;
go
--Proveedores
Execute SP_AgregarProveedor 'Fernando López García','2446789432','2446478943','Calle Dominguez #32','Maravillas','Atlixco','Puebla'
Execute SP_AgregarProveedor 'Marcelino Alberto Ramírez Montiel', '2443453128','2443217890','Acueducto #2','Prados El león','Atlixco','Puebla'
Execute SP_AgregarProveedor 'Luis Carlos Sandoval Martinez','2223456721','2224327856','5 de Mayo', 'Revolución','San Andres Cholula','Puebla'
Execute SP_AgregarProveedor 'Eduardo Alberto Reyes Pérez','5532456784','5532567213','Aquiles Serdán','Cuauhtemoc','Benito Juarez','Estado de México'
Execute SP_AgregarProveedor 'Daniela Gomez Pérez','5536756784','5532097213','Aquiles Serdán','Romero','Benito Juarez','Estado de México'
go
--Productos
Execute SP_AgregarProducto 'Melamina Texturizada', 'Laminado Decorativo de Alta Presión'
Execute SP_AgregarProducto 'Melamina Alto brillo', 'Laminado recubiertos con melamínico'
Execute SP_AgregarProducto 'Melamina Extra Matte', 'Laminado Decorativo color Matte'
Execute SP_AgregarProducto 'Melamina Alta Resistencia', 'Laminado reforzado con capaz'
Execute SP_AgregarProducto 'Melamina Nacional', 'Laminado hecho en México'
Execute SP_AgregarProducto 'Melamina Importada', 'Laminado importado de EU'
Execute SP_AgregarProducto 'Madera de Pino', 'Madera de Pino blanda e impregnable'
Execute SP_AgregarProducto 'Madera de Ayacahuite', 'Madera suave y semi dura'
Execute SP_AgregarProducto 'Madera de Oyamel', 'Madera suave y resistente a torceduras'
Execute SP_AgregarProducto 'Tabla', 'Tablas de diferente medidas'
Execute SP_AgregarProducto 'Viga', 'Viga común de diferentes medidas y grosor'
Execute SP_AgregarProducto 'Durmientes', 'Vigas para vías férreas'
Execute SP_AgregarProducto 'Duelas de ingenieria','Piso de madera por varias capaz'
Execute SP_AgregarProducto 'Duelas Solida','Piso de madera común'
Execute SP_AgregarProducto 'Triplay','Panales formados por diferentes capas de madera'
Execute SP_AgregarProducto 'Perrera Chica','Casa para Perros de raza chica'
Execute SP_AgregarProducto 'Perrera Mediana','Casa para Perros Mediana'
Execute SP_AgregarProducto 'Perrera Grande','Casa para Perros de raza Grande'

go
--Medidas
Execute SP_AgregarMedidas  1, '36x1.5x16cm', 300, 250.00
Execute SP_AgregarMedidas  1, '124x244 cm' , 529.00, 300
Execute SP_AgregarMedidas  1, '245x124 cm',  530.00, 200
Execute SP_AgregarMedidas  1, '16 mm',  450.00,  250
Execute SP_AgregarMedidas  1, '15 x1.24 mm',289.00,500
Execute SP_AgregarMedidas  2, '36x16 cm', 260.00, 200
Execute SP_AgregarMedidas  2, '124x244 cm',550.00,100
Execute SP_AgregarMedidas  2, '245x124', 600.00,380
Execute SP_AgregarMedidas  2, '16 mm', 500.00, 150
Execute SP_AgregarMedidas  3, '124x244 cm', 600.00, 500
Execute SP_AgregarMedidas  3, '15x1.24mm',300.00, 430
Execute SP_AgregarMedidas  4, '124x244 cm',700.00,250
Execute SP_AgregarMedidas  4, '36x16 cm',350.00,300
Execute SP_AgregarMedidas  4, '15x1.24 mm',330.00,50
Execute SP_AgregarMedidas  5, '36x16 cm', 270.00,230
Execute SP_AgregarMedidas  5, '50x50 cm', 200.00, 200
Execute SP_AgregarMedidas  5, '80x15 cm', 600.00,450
Execute SP_AgregarMedidas  5, '30x15 cm', 450.00,345
Execute SP_AgregarMedidas  6, '23x16 cm', 425.00,345
Execute SP_AgregarMedidas  6, '80x15 cm', 725.00,125
Execute SP_AgregarMedidas  6, '40x15 cm', 456.00, 60
Execute SP_AgregarMedidas  6, '50x15 cm',490.00, 300
Execute SP_AgregarMedidas  7, '200x100 cm',400.00, 340
Execute SP_AgregarMedidas  7, '100x100 cm', 375.00, 200
Execute SP_AgregarMedidas  7, '50x25 cm', 275.00, 500
Execute SP_AgregarMedidas  7, '50x15 cm', 200.00,100
Execute SP_AgregarMedidas  7, '40x15 cm', 180.00, 70
Execute SP_AgregarMedidas  8, '50x15 cm', 460.00, 250
Execute SP_AgregarMedidas  8, '40x15 cm', 405.00,120
Execute SP_AgregarMedidas  8, '30x15 cm', 380.00,350
Execute SP_AgregarMedidas  9, '50x25 cm', 445.00, 300
Execute SP_AgregarMedidas  9, '80x25 cm', 510.00, 76
Execute SP_AgregarMedidas  9, '40x15 cm', 450.00,230
Execute SP_AgregarMedidas  10,'30x15 cm', 200.00,300
Execute SP_AgregarMedidas  10,'40x15 cm', 250.00,340
Execute SP_AgregarMedidas  10,'50x15 cm', 300.00, 350
Execute SP_AgregarMedidas  10,'80x15 cm', 500.00, 200
Execute SP_AgregarMedidas  10,'80x30 cm', 600.00, 300
Execute SP_AgregarMedidas  11,'200x100 cm',600.00, 100
Execute SP_AgregarMedidas  11,'250x150 cm',700.00, 100
Execute SP_AgregarMedidas  12,'200x30cm', 200.00,230
Execute SP_AgregarMedidas  12,'200x28cm', 180.00, 34
Execute SP_AgregarMedidas  12,'5x5cm', 12.00 , 300
Execute SP_AgregarMedidas  12,'249x7.5 cm', 92.00, 67
Execute SP_AgregarMedidas  13,'250 x24cm', 15.00, 150
Execute SP_AgregarMedidas  13,'300x24cm', 20.00, 150
Execute SP_AgregarMedidas  13,'350x24cm', 30.00,300
Execute SP_AgregarMedidas  13,'400x24',  40.00, 150
Execute SP_AgregarMedidas  14,'80x12.5cm',30.00, 300
Execute SP_AgregarMedidas  15,'80x12.5cm', 20.00, 200
Execute SP_AgregarMedidas  16,'25x19x19 cm',250.00,10
Execute SP_AgregarMedidas  17,'30x20x20', 500.00, 10
Execute SP_AgregarMedidas  18,'54x38x38 cm',700.00,10
go

--Clasificaciones
Execute SP_AgregarClasificacion 'Melaminas o Enchapados'
Execute SP_AgregarClasificacion 'Maderas Comunes'
Execute SP_AgregarClasificacion 'Maderas Finas'
Execute SP_AgregarClasificacion 'Construcción'
Execute SP_AgregarClasificacion 'Pisos de Madera'
Execute SP_AgregarClasificacion 'Perrera'

go
--Clasificacion de cada producto
Execute SP_AsignarClasificacion 1,1
Execute SP_AsignarClasificacion 2,1
Execute SP_AsignarClasificacion 3,1
Execute SP_AsignarClasificacion 4,1
Execute SP_AsignarClasificacion 5,1
Execute SP_AsignarClasificacion 6,1
Execute SP_AsignarClasificacion 7,2
Execute SP_AsignarClasificacion 8,2
Execute SP_AsignarClasificacion 9,2
Execute SP_AsignarClasificacion 10,2
Execute SP_AsignarClasificacion 11,2
Execute SP_AsignarClasificacion 11,3
Execute SP_AsignarClasificacion 12,2
Execute SP_AsignarClasificacion 12,3
Execute SP_AsignarClasificacion 13,2
Execute SP_AsignarClasificacion 14,4
Execute SP_AsignarClasificacion 15,4
Execute SP_AsignarClasificacion 14,5
Execute SP_AsignarClasificacion 15,5
Execute SP_AsignarClasificacion 16,4
Execute SP_AsignarClasificacion 16,6
Execute SP_AsignarClasificacion 17,4
Execute SP_AsignarClasificacion 17,6
Execute SP_AsignarClasificacion 18,4
Execute SP_AsignarClasificacion 18,6

go
--Surtido de cada proveedor
Execute SP_AgregarAlSurtido 5,1
Execute SP_AgregarAlSurtido 5,2
Execute SP_AgregarAlSurtido 5,3
Execute SP_AgregarAlSurtido 5,4
Execute SP_AgregarAlSurtido 5,5
Execute SP_AgregarAlSurtido 1,6
Execute SP_AgregarAlSurtido 2,7
Execute SP_AgregarAlSurtido 2,8
Execute SP_AgregarAlSurtido 2,9
Execute SP_AgregarAlSurtido 1,10
Execute SP_AgregarAlSurtido 1,11
Execute SP_AgregarAlSurtido 3,12
Execute SP_AgregarAlSurtido 3,13
Execute SP_AgregarAlSurtido 3,14
Execute SP_AgregarAlSurtido 2,15
Execute SP_AgregarAlSurtido 4,16
Execute SP_AgregarAlSurtido 4,17
Execute SP_AgregarAlSurtido 4,18

go
--Ventas
execute SP_AgregarVenta 2,345.00,'Dec 18 2020', '02:18 PM';
go
Execute SP_AgregarDetallesVenta 1,2,25
Execute SP_AgregarDetallesVenta 1,6,2
Execute SP_AgregarDetallesVenta 1,8,2
