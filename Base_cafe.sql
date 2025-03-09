CREATE TABLE Finca (
    No_Finca INT PRIMARY KEY,
    Nombre_Finca VARCHAR(100),
    Tamaño_Finca DECIMAL(10, 2),
    Ubicacion_Finca VARCHAR(255)
);

-- 2. Tabla Cortes o Lotes
CREATE TABLE Cortes (
    Id_Corte INT PRIMARY KEY,
    Nombre_Corte VARCHAR(100),
    No_Finca INT,
    FOREIGN KEY (No_Finca) REFERENCES Finca(No_Finca)
);

-- 3. Tabla Precio
CREATE TABLE Precio (
    Id_Precio INT PRIMARY KEY,
    Nombre_Categoria VARCHAR(100),
    Tipo_Moneda VARCHAR(50),
    Valor_Cafe_Rojo_Cajuelas DECIMAL(10, 2),
    Valor_Cafe_Verde_Cajuelas DECIMAL(10, 2)
);

-- 4. Tabla Categoría
CREATE TABLE Categoria (
    Id_Categoria INT PRIMARY KEY,
    Tipo_Categoria VARCHAR(100),
    Id_Corte INT,
    Id_Precio INT,
    FOREIGN KEY (Id_Corte) REFERENCES Cortes(Id_Corte),
    FOREIGN KEY (Id_Precio) REFERENCES Precio(Id_Precio)
);

CREATE TABLE Puesto (
    Id_Puesto INT PRIMARY KEY,
    Nombre_Puesto VARCHAR(100),
    Min_Salario NUMBER(10, 2),
    Max_Salario NUMBER(10, 2)
);

-- 5. Tabla Empleados
CREATE TABLE Empleados (
    Identificacion_Empleado INT PRIMARY KEY,
    Nombre_Empleado VARCHAR(100),
    Apellido_Empleado VARCHAR(100),
    Email VARCHAR(255),
    Telefono VARCHAR(20),
    Salario DECIMAL(10, 2),
    Id_Puesto INT,
    No_Finca INT,
    FOREIGN KEY (Id_Puesto) REFERENCES Puesto(Id_Puesto), -- Suponiendo que hay una tabla Puesto que no mencionas
    FOREIGN KEY (No_Finca) REFERENCES Finca(No_Finca)
);

-- 6. Tabla Recolector
CREATE TABLE Recolector (
    Identificacion_Recolector INT PRIMARY KEY,
    Nombre_Recolector VARCHAR(100)
);

-- 7. Tabla Recolección
CREATE TABLE Recoleccion (
    Id_Recoleccion INT PRIMARY KEY,
    Identificacion_Recolector INT,
    Id_Corte INT,
    Fecha_Recoleccion DATE,
    Cantidad_Cajuelas INT,
    Cantidad_Cuartillos INT,
    Id_Categoria INT,
    Pago_Total DECIMAL(10, 2),
    FOREIGN KEY (Identificacion_Recolector) REFERENCES Recolector(Identificacion_Recolector),
    FOREIGN KEY (Id_Corte) REFERENCES Cortes(Id_Corte),
    FOREIGN KEY (Id_Categoria) REFERENCES Categoria(Id_Categoria)
);

-- 8. Tabla Proveedores
CREATE TABLE Proveedores (
    Id_Proveedor INT PRIMARY KEY,
    Nombre_Proveedor VARCHAR(100),
    Ubicacion_Proveedor VARCHAR(255),
    Telefono_Proveedor VARCHAR(20),
    Email_Proveedor VARCHAR(255)
);

-- 9. Tabla Inventario para Fincas
CREATE TABLE Inventario_Finca (
    Cod_Producto INT PRIMARY KEY,
    Nombre_Producto VARCHAR(100),
    Cantidad_Producto INT,
    No_Finca INT,
    Id_Proveedor INT,
    FOREIGN KEY (No_Finca) REFERENCES Finca(No_Finca),
    FOREIGN KEY (Id_Proveedor) REFERENCES Proveedores(Id_Proveedor)
);

-- 10. Tabla Vehículos
CREATE TABLE Vehiculos (
    Placa_Vehiculo VARCHAR(20) PRIMARY KEY,
    Marca_Vehiculo VARCHAR(100),
    Modelo_Vehiculo VARCHAR(100),
    Valor_Fiscal DECIMAL(10, 2),
    No_Finca INT,
    Identificacion_Empleado INT,
    Id_Proveedor INT,
    FOREIGN KEY (Identificacion_Empleado) REFERENCES Empleados(Identificacion_Empleado),
    FOREIGN KEY (No_Finca) REFERENCES Finca(No_Finca),
    FOREIGN KEY (Id_Proveedor) REFERENCES Proveedores(Id_Proveedor)
);

-- 11. Tabla Equipos de trabajo
CREATE TABLE Equipos_de_Trabajo (
    No_Activo INT PRIMARY KEY,
    Nombre_Equipo VARCHAR(100),
    Tipo_Equipo VARCHAR(100),
    Garantia_Equipo DATE,
    Id_Proveedor INT,
    No_Finca INT,
    FOREIGN KEY (Id_Proveedor) REFERENCES Proveedores(Id_Proveedor),
    FOREIGN KEY (No_Finca) REFERENCES Finca(No_Finca)
);

-- 12. Tabla Mantenimiento de Vehículos
CREATE TABLE Mant_Vehiculos (
    Id_Mantenimiento INT PRIMARY KEY,
    Placa_Vehiculo VARCHAR(20),
    Motivo_Mantenimiento VARCHAR(255),
    Costo_Mantenimiento DECIMAL(10, 2),
    FOREIGN KEY (Placa_Vehiculo) REFERENCES Vehiculos(Placa_Vehiculo)
);