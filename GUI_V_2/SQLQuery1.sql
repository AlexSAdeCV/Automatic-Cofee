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

-- Crear la tabla Cliente
CREATE TABLE Cliente (
    ClienteID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL
);

-- Insertar 20 ejemplos de registros en la tabla Cliente
INSERT INTO Cliente (Nombre) VALUES
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

-- Crear la tabla Categoria
CREATE TABLE Categoria (
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),
    NombreCategoria NVARCHAR(50) NOT NULL
);

-- Insertar 20 ejemplos de registros en la tabla Categoria
INSERT INTO Categoria (NombreCategoria) VALUES
    ('Bebidas calientes'),
    ('Bebidas frías'),
    ('Café'),
    ('Té'),
    ('Pasteles'),
    ('Galletas'),
    ('Bocadillos'),
    ('Desayuno'),
    ('Ensaladas'),
    ('Sandwiches'),
    ('Postres'),
    ('Smoothies'),
    ('Zumos naturales'),
    ('Hamburguesas'),
    ('Pizzas'),
    ('Sopas'),
    ('Helados'),
    ('Almuerzos'),
    ('Cervezas'),
    ('Vinos');

	-- Crear la tabla Subcategoria
CREATE TABLE Subcategoria (
    SubcategoriaID INT PRIMARY KEY IDENTITY(1,1),
    NombreSubcategoria NVARCHAR(50) NOT NULL,
    CategoriaID INT FOREIGN KEY REFERENCES Categoria(CategoriaID)
);

-- Insertar 20 ejemplos de registros en la tabla Subcategoria
INSERT INTO Subcategoria (NombreSubcategoria, CategoriaID) VALUES
    ('Café con leche', 1),
    ('Capuchino', 1),
    ('Té negro', 2),
    ('Té verde', 2),
    ('Pastel de chocolate', 5),
    ('Galletas de avena', 6),
    ('Bocadillo de jamón y queso', 7),
    ('Desayuno continental', 8),
    ('Ensalada César', 9),
    ('Sandwich de pollo', 10),
    ('Tarta de manzana', 11),
    ('Smoothie de frutas', 12),
    ('Zumo de naranja', 13),
    ('Hamburguesa clásica', 14),
    ('Pizza margarita', 15),
    ('Sopa de tomate', 16),
    ('Helado de vainilla', 17),
    ('Almuerzo ejecutivo', 18),
    ('Cerveza artesanal', 19),
    ('Vino tinto', 20);

	-- Crear la tabla Productos
CREATE TABLE Productos (
    ProductoID INT PRIMARY KEY IDENTITY(1,1),
    NombreProducto NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    SubcategoriaID INT FOREIGN KEY REFERENCES Subcategoria(SubcategoriaID)
);

-- Insertar ejemplos de registros en la tabla Productos
INSERT INTO Productos (NombreProducto, Precio, SubcategoriaID) VALUES
    ('Café Americano', 2.50, 1),
    ('Latte', 3.50, 1),
    ('Té Earl Grey', 2.00, 3),
    ('Té Matcha', 3.00, 4),
    ('Brownie', 4.50, 5),
    ('Galletas de chocolate', 2.00, 6),
    ('Bocadillo de pollo', 5.00, 7),
    ('Desayuno completo', 8.50, 8),
    ('Ensalada de quinoa', 7.00, 9),
    ('Sandwich vegetariano', 6.00, 10),
    ('Cheesecake', 5.50, 11),
    ('Smoothie de fresa-banana', 4.00, 12),
    ('Zumo de manzana', 2.50, 13),
    ('Hamburguesa con queso', 6.50, 14),
    ('Pizza pepperoni', 9.00, 15),
    ('Sopa de lentejas', 3.50, 16),
    ('Helado de fresa', 4.00, 17),
    ('Almuerzo especial', 10.00, 18),
    ('Cerveza IPA', 5.00, 19),
    ('Vino blanco seco', 8.00, 20);
-- Crear la tabla Empleados con atributos adicionales
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
	Contraseña NVARCHAR(30)
);

select * from Empleados
go

-- Insertar 10 ejemplos de registros en la tabla Empleados
INSERT INTO Empleados (NombreEmpleado, ApellidoPaterno, ApellidoMaterno, Telefono, Calle, Colonia, Ciudad, Estado, CodigoPostal, Puesto, Horario, Sueldo, Usuario, Contraseña) VALUES
    ('Juan', 'Gómez', 'López', '555-1234', 'Calle 123', 'Colonia Centro', 'Ciudad A', 'Estado 1', '12345', 'Barista', '8:00 AM - 5:00 PM', 2500.00, 'JuanGL' ,'JGomez939'),
    ('María', 'Hernández', 'Sánchez', '555-5678', 'Avenida 456', 'Colonia Norte', 'Ciudad B', 'Estado 2', '56789', 'Cajero', '9:00 AM - 6:00 PM', 2800.00, 'MariaHS', 'MaSnch3z_463'),
    ('Carlos', 'Martínez', 'García', '555-9012', 'Calle 789', 'Colonia Sur', 'Ciudad C', 'Estado 3', '78901', 'Mesero', '10:00 AM - 7:00 PM', 2600.00, 'CarlosMG', 'Car_Mtz_Ga746'),
    ('Ana', 'Rodríguez', 'Fernández', '555-3456', 'Avenida 012', 'Colonia Este', 'Ciudad D', 'Estado 4', '01234', 'Chef', '12:00 PM - 9:00 PM', 3000.00, 'AnaRF', 'FernandezAR_85'),
    ('Pedro', 'López', 'Vargas', '555-7890', 'Calle 345', 'Colonia Oeste', 'Ciudad E', 'Estado 5', '34567', 'Barista', '8:00 AM - 5:00 PM', 2500.00, 'apaedroLV', 'VargasLopezP_63'),
    ('Laura', 'González', 'Ramírez', '555-2345', 'Avenida 678', 'Colonia Poniente', 'Ciudad F', 'Estado 6', '67890', 'Cajero', '9:00 AM - 6:00 PM', 2800.00, 'LauraGR', 'G.RamirezLaura01'),
    ('Miguel', 'Sánchez', 'Díaz', '555-6789', 'Calle 901', 'Colonia Central', 'Ciudad G', 'Estado 7', '90123', 'Mesero', '10:00 AM - 7:00 PM', 2600.00, 'MiguelSD', 'MguelSD5820'),
    ('Isabel', 'Ramírez', 'Torres', '555-1234', 'Avenida 234', 'Colonia Occidental', 'Ciudad H', 'Estado 8', '23456', 'Chef', '12:00 PM - 9:00 PM', 3000.00, 'IsabelRT', 'IzzyRmzT42'),
    ('José', 'Torres', 'Cruz', '555-5678', 'Calle 567', 'Colonia Oriental', 'Ciudad I', 'Estado 9', '56789', 'Barista', '8:00 AM - 5:00 PM', 2500.00, 'J0oseTC', 'TorresCruzJTC'),
    ('Carmen', 'Díaz', 'Hernández', '555-9012', 'Avenida 890', 'Colonia Meridional', 'Ciudad J', 'Estado 10', '89012', 'Cajero', '9:00 AM - 6:00 PM', 2800.00, 'CarmenDH', 'D.HernandezC5383');


-- Crear la tabla Ventas
CREATE TABLE Ventas (
    VentaID INT PRIMARY KEY IDENTITY(1,1),
    FechaVenta DATE NOT NULL,
    TipoPago NVARCHAR(20) NOT NULL,
    ProductoID INT FOREIGN KEY REFERENCES Productos(ProductoID),
    EmpleadoID INT FOREIGN KEY REFERENCES Empleados(EmpleadoID),
    ClienteID INT FOREIGN KEY REFERENCES Cliente(ClienteID)
);

-- Insertar 20 ejemplos de registros en la tabla Ventas
INSERT INTO Ventas (FechaVenta, TipoPago, ProductoID, EmpleadoID, ClienteID) VALUES
    ('2023-01-01', 'Efectivo', 1, 1, 1),
    ('2023-01-02', 'Tarjeta', 5, 2, 2),
    ('2023-01-03', 'Efectivo', 10, 3, 3),
    ('2023-01-04', 'Tarjeta', 15, 4, 4),
    ('2023-01-05', 'Efectivo', 20, 5, 5),
    ('2023-01-06', 'Tarjeta', 3, 6, 6),
    ('2023-01-07', 'Efectivo', 8, 7, 7),
    ('2023-01-08', 'Tarjeta', 12, 8, 8),
    ('2023-01-09', 'Efectivo', 17, 9, 9),
    ('2023-01-10', 'Tarjeta', 19, 10, 10),
    ('2023-01-11', 'Efectivo', 2, 1, 1),
    ('2023-01-12', 'Tarjeta', 6, 2, 2),
    ('2023-01-13', 'Efectivo', 11, 3, 3),
    ('2023-01-14', 'Tarjeta', 16, 4, 4),
    ('2023-01-15', 'Efectivo', 18, 5, 5),
    ('2023-01-16', 'Tarjeta', 4, 6, 6),
    ('2023-01-17', 'Efectivo', 9, 7, 7),
    ('2023-01-18', 'Tarjeta', 13, 8, 8),
    ('2023-01-19', 'Efectivo', 14, 9, 9),
    ('2023-01-20', 'Tarjeta', 7, 10, 10);

-- Crear la tabla DetalleVenta
CREATE TABLE DetalleVenta (
    DetalleVentaID INT PRIMARY KEY IDENTITY(1,1),
    NombreProducto NVARCHAR(100) NOT NULL,
    CostoUnitario DECIMAL(10, 2) NOT NULL,
    TotalPedido DECIMAL(10, 2) NOT NULL,
    CantidadProductos INT NOT NULL,
    ProductoID INT FOREIGN KEY REFERENCES Productos(ProductoID),
    VentaID INT FOREIGN KEY REFERENCES Ventas(VentaID),
    Cantidad INT NOT NULL
);

-- Insertar ejemplos de registros en la tabla DetalleVenta
INSERT INTO DetalleVenta (NombreProducto, CostoUnitario, TotalPedido, CantidadProductos, ProductoID, VentaID, Cantidad) VALUES
    ('Café Americano', 2.50, 5.00, 2, 1, 1, 2),
    ('Brownie', 4.50, 4.50, 1, 5, 2, 1),
    ('Sandwich vegetariano', 6.00, 12.00, 2, 10, 3, 2),
    ('Cheesecake', 5.50, 5.50, 1, 11, 4, 1),
    ('Hamburguesa con queso', 6.50, 13.00, 2, 14, 5, 2),
    ('Pizza pepperoni', 9.00, 9.00, 1, 15, 6, 1),
    ('Helado de fresa', 4.00, 8.00, 2, 17, 7, 2),
    ('Cerveza IPA', 5.00, 10.00, 2, 19, 8, 2),
    ('Té Matcha', 3.00, 6.00, 2, 4, 9, 2),
    ('Galletas de chocolate', 2.00, 8.00, 4, 6, 10, 4);

