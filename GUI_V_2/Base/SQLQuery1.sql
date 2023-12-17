/*Crear Base de datos*/
Create Database PA_CAF
--ON
--(name = PA_CAF,
--Filename= 'E:\PA_BASE_CAF\CAFPA_Dat.mdf',
--SIZE = 10,
--MAXSIZE= 50,
--FILEGROWTH = 5)
--Log ON
--(name = CAFPA_Log,
--Filename= 'E:\PA_BASE_CAF\CAFPA_Log.ldf',
--SIZE = 10,
--MAXSIZE= 50,
--FILEGROWTH = 5)
GO

USE PA_CAF
go

CREATE TABLE Empleados (
    EmpleadoID INT PRIMARY KEY IDENTITY(1,1),
    NombreEmpleado NVARCHAR(100) NOT NULL,
    ApellidoPaterno NVARCHAR(50) NOT NULL,
    ApellidoMaterno NVARCHAR(50) NOT NULL,
    Telefono NVARCHAR(15),
    Calle NVARCHAR(255),
    Colonia NVARCHAR(100),
    Ciudad NVARCHAR(100),
    Estado NVARCHAR(100),
    CodigoPostal NVARCHAR(10),
    Puesto NVARCHAR(50),
    Horario NVARCHAR(50),
    Sueldo DECIMAL(10, 2),
	Usuario NVARCHAR(30),
	Contraseña NVARCHAR(30),
    rol int
)
go

-- Insertar 10 ejemplos de registros en la tabla Empleados
INSERT INTO Empleados VALUES
    ('Juan', 'Gómez', 'López', '555-1234', 'Calle 123', 'Colonia Centro', 'Ciudad A', 'Estado 1', '12345', 'Barista', '8:00 AM - 5:00 PM', 2500.00, 'JuanGL' ,'JGomez939',0),
    ('María', 'Hernández', 'Sánchez', '555-5678', 'Avenida 456', 'Colonia Norte', 'Ciudad B', 'Estado 2', '56789', 'Cajero', '9:00 AM - 6:00 PM', 2800.00, 'MariaHS', 'MaSnch3z_463',1),
    ('Carlos', 'Martínez', 'García', '555-9012', 'Calle 789', 'Colonia Sur', 'Ciudad C', 'Estado 3', '78901', 'Mesero', '10:00 AM - 7:00 PM', 2600.00, 'CarlosMG', 'Car_Mtz_Ga746',1),
    ('Ana', 'Rodríguez', 'Fernández', '555-3456', 'Avenida 012', 'Colonia Este', 'Ciudad D', 'Estado 4', '01234', 'Chef', '12:00 PM - 9:00 PM', 3000.00, 'AnaRF', 'FernandezAR_85,',1),
    ('Pedro', 'López', 'Vargas', '555-7890', 'Calle 345', 'Colonia Oeste', 'Ciudad E', 'Estado 5', '34567', 'Barista', '8:00 AM - 5:00 PM', 2500.00, 'apaedroLV', 'VargasLopezP_63',1),
    ('Laura', 'González', 'Ramírez', '555-2345', 'Avenida 678', 'Colonia Poniente', 'Ciudad F', 'Estado 6', '67890', 'Cajero', '9:00 AM - 6:00 PM', 2800.00, 'LauraGR', 'G.RamirezLaura01',1),
    ('Miguel', 'Sánchez', 'Díaz', '555-6789', 'Calle 901', 'Colonia Central', 'Ciudad G', 'Estado 7', '90123', 'Mesero', '10:00 AM - 7:00 PM', 2600.00, 'MiguelSD', 'MguelSD5820',1),
    ('Isabel', 'Ramírez', 'Torres', '555-1234', 'Avenida 234', 'Colonia Occidental', 'Ciudad H', 'Estado 8', '23456', 'Chef', '12:00 PM - 9:00 PM', 3000.00, 'IsabelRT', 'IzzyRmzT42',1),
    ('José', 'Torres', 'Cruz', '555-5678', 'Calle 567', 'Colonia Oriental', 'Ciudad I', 'Estado 9', '56789', 'Barista', '8:00 AM - 5:00 PM', 2500.00, 'J0oseTC', 'TorresCruzJTC',1),
    ('Carmen', 'Díaz', 'Hernández', '555-9012', 'Avenida 890', 'Colonia Meridional', 'Ciudad J', 'Estado 10', '89012', 'Cajero', '9:00 AM - 6:00 PM', 2800.00, 'CarmenDH', 'D.HernandezC5383',1);
go

CREATE TABLE Cliente (
    ClienteID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL
);

-- Insertar 20 ejemplos de registros en la tabla Cliente
INSERT INTO Cliente VALUES
    ('Juan Pérez'),
    ('María Rodríguez'),
    ('Carlos García'),
    ('Ana López'),
    ('Pedro Martínez'),
    ('Laura González'),
    ('Miguel Sánchez'),
    ('Isabel Ramírez'),
    ('José Torres'),
    ('Carmen Díaz'),
    ('Raúl Fernández'),
    ('Elena Ruiz'),
    ('Francisco Herrera'),
    ('Lucía Castro'),
    ('Andrés Vargas'),
    ('Beatriz Jiménez'),
    ('Luisa Navarro'),
    ('Javier Medina'),
    ('Patricia Ortega'),
    ('Roberto Mendoza');
    go

CREATE TABLE Categoria (
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),
    NombreCategoria NVARCHAR(50) NOT NULL
);

-- Insertar 20 ejemplos de registros en la tabla Categoria
INSERT INTO Categoria VALUES
    ('Bebidas calientes'),
    ('Bebidas frías'),
    ('Pasteles'),
    ('Galletas'),
    ('Bocadillos'),
    ('Desayuno'),
    ('Ensaladas')
    go

	-- Crear la tabla Productos
-- Crear la tabla Productos
CREATE TABLE Productos (
    ProductoID INT PRIMARY KEY IDENTITY(1,1),
    NombreProducto NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    idcategoria int,
    foreign key (idcategoria) references Categoria (CategoriaID)
);

-- Insertar ejemplos de registros en la tabla Productos
INSERT INTO Productos VALUES
    ('Café Americano', 2.50,1),
    ('Latte', 3.50,2),
    ('Té Earl Grey', 2.00,1),
    ('Té Matcha', 3.00,2),
    ('Brownie', 4.50,3),
    ('Galletas de chocolate', 2.00,4),
    ('Bocadillo de pollo', 5.00,5),
    ('Desayuno completo', 8.50,6),
    ('Ensalada de quinoa', 7.00,7)
    go

-- Crear la tabla Ventas
CREATE TABLE Ventas (
    VentaID INT PRIMARY KEY IDENTITY(1,1),
    FechaVenta DATE NOT NULL,
    Precio money, 
    TipoPago NVARCHAR(20) NOT NULL,
    EmpleadoID INT FOREIGN KEY REFERENCES Empleados(EmpleadoID),
    ClienteID INT FOREIGN KEY REFERENCES Cliente(ClienteID)
)
go

select * from Ventas
go