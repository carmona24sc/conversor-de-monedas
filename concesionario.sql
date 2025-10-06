
IF DB_ID('concesionario') IS NULL
BEGIN
    PRINT 'Creando base de datos concesionario...';
    CREATE DATABASE concesionario;
END
ELSE
BEGIN
    PRINT 'La base de datos concesionario ya existe.';
END
GO

USE concesionario;
GO

IF OBJECT_ID('dbo.tipo_vehiculo', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tipo_vehiculo (
        id INT IDENTITY(1,1) PRIMARY KEY,
        nombre VARCHAR(100) NOT NULL
    );

    INSERT INTO dbo.tipo_vehiculo (nombre)
    VALUES ('Automóvil'), ('Camioneta'), ('Motocicleta');
END
GO

IF OBJECT_ID('dbo.marca', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.marca (
        id INT IDENTITY(1,1) PRIMARY KEY,
        nombre VARCHAR(100) NOT NULL
    );

    INSERT INTO dbo.marca (nombre)
    VALUES ('Toyota'), ('Chevrolet'), ('Yamaha'), ('Ford'), ('Kia');
END
GO

IF OBJECT_ID('dbo.vehiculo', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.vehiculo (
        id INT IDENTITY(1,1) PRIMARY KEY,
        placa VARCHAR(10) NOT NULL UNIQUE,
        modelo INT NOT NULL,
        color VARCHAR(50),
        precio DECIMAL(18,2) NOT NULL,
        id_tipo INT NOT NULL,
        id_marca INT NOT NULL,
        CONSTRAINT FK_vehiculo_tipo FOREIGN KEY (id_tipo) REFERENCES dbo.tipo_vehiculo(id),
        CONSTRAINT FK_vehiculo_marca FOREIGN KEY (id_marca) REFERENCES dbo.marca(id)
    );

    INSERT INTO dbo.vehiculo (placa, modelo, color, precio, id_tipo, id_marca)
    VALUES 
    ('ABC123', 2022, 'Rojo', 95000000, 1, 1),
    ('XYZ987', 2023, 'Negro', 120000000, 2, 2),
    ('MOTO45', 2021, 'Azul', 8500000, 3, 3);
END
GO

IF OBJECT_ID('dbo.cliente', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.cliente (
        id INT IDENTITY(1,1) PRIMARY KEY,
        nombre VARCHAR(100) NOT NULL,
        apellido VARCHAR(100) NOT NULL,
        documento VARCHAR(20) NOT NULL UNIQUE,
        telefono VARCHAR(20),
        correo VARCHAR(100)
    );

    INSERT INTO dbo.cliente (nombre, apellido, documento, telefono, correo)
    VALUES 
    ('Juan', 'Pérez', '1001234567', '3001234567', 'juanperez@email.com'),
    ('Laura', 'Gómez', '1007654321', '3017654321', 'lauragomez@email.com');
END
GO

IF OBJECT_ID('dbo.empleado', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.empleado (
        id INT IDENTITY(1,1) PRIMARY KEY,
        nombre VARCHAR(100) NOT NULL,
        apellido VARCHAR(100) NOT NULL,
        cargo VARCHAR(50) NOT NULL,
        salario DECIMAL(18,2)
    );

    INSERT INTO dbo.empleado (nombre, apellido, cargo, salario)
    VALUES 
    ('Carlos', 'Ramírez', 'Vendedor', 2500000),
    ('Ana', 'López', 'Gerente', 4500000);
END
GO

IF OBJECT_ID('dbo.venta', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.venta (
        id INT IDENTITY(1,1) PRIMARY KEY,
        fecha DATE NOT NULL DEFAULT GETDATE(),
        id_cliente INT NOT NULL,
        id_empleado INT NOT NULL,
        id_vehiculo INT NOT NULL,
        total DECIMAL(18,2) NOT NULL,
        CONSTRAINT FK_venta_cliente FOREIGN KEY (id_cliente) REFERENCES dbo.cliente(id),
        CONSTRAINT FK_venta_empleado FOREIGN KEY (id_empleado) REFERENCES dbo.empleado(id),
        CONSTRAINT FK_venta_vehiculo FOREIGN KEY (id_vehiculo) REFERENCES dbo.vehiculo(id)
    );

    INSERT INTO dbo.venta (id_cliente, id_empleado, id_vehiculo, total)
    VALUES (1, 1, 1, 95000000);
END
GO

PRINT 'Mostrando datos iniciales...';

SELECT * FROM dbo.tipo_vehiculo;
SELECT * FROM dbo.marca;
SELECT * FROM dbo.vehiculo;
SELECT * FROM dbo.cliente;
SELECT * FROM dbo.empleado;
SELECT * FROM dbo.venta;
GO

PRINT '✅ Base de datos "concesionario" configurada correctamente.';
GO
