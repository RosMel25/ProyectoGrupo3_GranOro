--Vista para mostrar Proveedores ordenados alfabeticamente
CREATE VIEW Vista_Proveedores_Ordenados AS
SELECT Nombre_Proveedor, Ubicacion_Proveedor, Telefono_Proveedor, Email_Proveedor
FROM Proveedores
ORDER BY Nombre_Proveedor;

--Vista para mostrar los productos de Inventario_Finca y su respectivo proveedor
CREATE VIEW Vista_Productos_Proveedores AS
SELECT 
    Inventario_Finca.Nombre_Producto Producto,
    Inventario_Finca.Cantidad_Producto CantidadActualProducto,
    Proveedores.Nombre_Proveedor Proveedor
FROM 
    Inventario_Finca
JOIN 
    Proveedores ON Inventario_Finca.Id_Proveedor = Proveedores.Id_Proveedor;
    
--Vista para mostrar la ubicacion (nombre de la finca) de los equipos de trabajo
CREATE VIEW Vista_Equipos_Finca AS
SELECT 
    Equipos_de_Trabajo.No_Activo NoActivo,
    Equipos_de_Trabajo.Nombre_Equipo Equipo,
    Finca.Nombre_Finca Finca
FROM 
    Equipos_de_Trabajo
JOIN 
    Finca ON Equipos_de_Trabajo.No_Finca = Finca.No_Finca;