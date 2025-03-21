--VISTAS CREADAS POR ADRIÁN

CREATE VIEW vista_recoleccion_recolector AS
SELECT
    r.ID_RECOLECCION,
    r.IDENTIFICACION_RECOLECTOR,
    r.NO_FINCA,
    r.ID_CORTE,
    r.FECHA_RECOLECCION,
    r.CANTIDAD_CAJUELAS,
    r.CANTIDAD_CUARTILLOS,
    r.ID_PRECIO,
    r.PAGO_TOTAL,
    rec.NOMBRE_RECOLECTOR
FROM
    RECOLECCION r
JOIN
    RECOLECTOR rec ON r.IDENTIFICACION_RECOLECTOR = rec.IDENTIFICACION_RECOLECTOR;  
    
CREATE VIEW vista_recoleccion_agrupada AS
SELECT
    r.IDENTIFICACION_RECOLECTOR,
    rec.NOMBRE_RECOLECTOR,
    r.NO_FINCA,
    SUM(r.CANTIDAD_CAJUELAS) AS TOTAL_CAJUELAS,
    SUM(r.CANTIDAD_CUARTILLOS) AS TOTAL_CUARTILLOS,
    SUM(r.PAGO_TOTAL) AS TOTAL_PAGO
FROM
    RECOLECCION r
JOIN
    RECOLECTOR rec ON r.IDENTIFICACION_RECOLECTOR = rec.IDENTIFICACION_RECOLECTOR
GROUP BY
    r.IDENTIFICACION_RECOLECTOR,
    rec.NOMBRE_RECOLECTOR,
    r.NO_FINCA;
    
CREATE VIEW vista_recoleccion_por_fecha AS
SELECT
    r.ID_RECOLECCION,
    r.IDENTIFICACION_RECOLECTOR,
    r.NO_FINCA,
    r.ID_CORTE,
    r.FECHA_RECOLECCION,
    r.CANTIDAD_CAJUELAS,
    r.CANTIDAD_CUARTILLOS,
    r.ID_PRECIO,
    r.PAGO_TOTAL,
    rec.NOMBRE_RECOLECTOR
FROM
    RECOLECCION r
JOIN
    RECOLECTOR rec ON r.IDENTIFICACION_RECOLECTOR = rec.IDENTIFICACION_RECOLECTOR
WHERE
    r.FECHA_RECOLECCION BETWEEN TO_DATE('2025-01-01', 'YYYY-MM-DD') 
    AND TO_DATE('2025-12-31', 'YYYY-MM-DD');
     
CREATE VIEW vista_precios_en_moneda_especifica AS
SELECT
    ID_PRECIO,
    NOMBRE_CATEGORIA,
    TIPO_MONEDA,
    VALOR_CAJUELA,
    VALOR_CUARTILLO
FROM
    PRECIO
WHERE
    TIPO_MONEDA = 'COLONES';  
    
CREATE VIEW vista_obtener_id_nombre AS
SELECT
    NO_FINCA

FROM
    FINCA
WHERE
    NOMBRE_FINCA = 'CONCEPCION';
    
-- FIN VISTAS CREADAS POR ADRIÁN    
    
    
    
    
  --VISTAS CREADAS POR MELANY  
    
CREATE VIEW VISTA_PUESTOS_EMPLEADOS AS
SELECT p.ID_PUESTO, p.NOMBRE_PUESTO, COUNT(e.IDENTIFICACION_EMPLEADO) AS CANTIDAD_EMPLEADOS
FROM PUESTO p
LEFT JOIN EMPLEADOS e ON p.ID_PUESTO = e.ID_PUESTO
GROUP BY p.ID_PUESTO, p.NOMBRE_PUESTO;
    
CREATE VIEW VISTA_PUESTOS_MONEDA AS
SELECT ID_PUESTO AS CODIGO, 
       NOMBRE_PUESTO AS PUESTO, 
       TO_CHAR(MIN_SALARIO, 'L9,999,999') AS SALARIO_MINIMO, 
       TO_CHAR(MAX_SALARIO, 'L9,999,999') AS SALARIO_MAXIMO
FROM PUESTO;

CREATE VIEW VISTA_EMPLEADOS_PUESTO AS
SELECT e.IDENTIFICACION_EMPLEADO, e.NOMBRE_EMPLEADO, e.APELLIDO_EMPLEADO, 
       p.NOMBRE_PUESTO, e.SALARIO
FROM EMPLEADOS e
JOIN PUESTO p ON e.ID_PUESTO = p.ID_PUESTO;

CREATE VIEW VISTA_EMPLEADOS_CONTACTO AS
SELECT IDENTIFICACION_EMPLEADO, 
       NOMBRE_EMPLEADO || ' ' || APELLIDO_EMPLEADO AS NOMBRE_COMPLETO, 
       EMAIL, 
       'Teléfono: ' || TELEFONO AS CONTACTO
FROM EMPLEADOS;

--FIN VISTAS CREADAS POR MELANY




-- VISTAS CREADAS POR ANDRES

--VER INFORMACION COMPLETA DE LOS VEHICULOS
CREATE VIEW Vista_Vehiculos_Completa AS
SELECT 
    v.Placa_Vehiculo,
    v.Marca_Vehiculo,
    v.Modelo_Vehiculo,
    v.Valor_Fiscal,
    e.Nombre_Empleado,
    p.Nombre_Proveedor, 
    f.Nombre_Finca 
FROM 
    Vehiculos v
JOIN 
    Empleados e ON v.Identificacion_Empleado = e.Identificacion_Empleado
JOIN 
    Proveedores p ON v.Id_Proveedor = p.Id_Proveedor
JOIN 
    Finca f ON v.No_Finca = f.No_Finca;
    
  --  VEHICULOS POR EMPLEADO
CREATE VIEW Vista_Vehiculos_Empleado AS
SELECT 
    v.Placa_Vehiculo,
    v.Marca_Vehiculo,
    v.Modelo_Vehiculo,
    v.Valor_Fiscal,
    v.No_Finca,
    v.Identificacion_Empleado,
    e.Nombre_Empleado  
FROM 
    Vehiculos v
JOIN 
    Empleados e ON v.Identificacion_Empleado = e.Identificacion_Empleado;
    
--    VER COSTO DE MANTENIMIENTO
CREATE VIEW Vista_Mantenimiento_Costo AS
SELECT 
    mv.Id_Mantenimiento,
    mv.Placa_Vehiculo,
    mv.Motivo_Mantenimiento,
    mv.Costo_Mantenimiento,
    v.Marca_Vehiculo,
    v.Modelo_Vehiculo
FROM 
    Mant_Vehiculos mv
JOIN 
    Vehiculos v ON mv.Placa_Vehiculo = v.Placa_Vehiculo
ORDER BY 
    mv.Costo_Mantenimiento DESC;

--COSTO PROMEDIO
CREATE VIEW Vista_Mantenimiento_Promedio_Vehiculo AS
SELECT 
    mv.Placa_Vehiculo,
    v.Marca_Vehiculo,
    v.Modelo_Vehiculo,
    AVG(mv.Costo_Mantenimiento) AS Costo_Promedio_Mantenimiento
FROM 
    Mant_Vehiculos mv
JOIN 
    Vehiculos v ON mv.Placa_Vehiculo = v.Placa_Vehiculo
GROUP BY 
    mv.Placa_Vehiculo, v.Marca_Vehiculo, v.Modelo_Vehiculo
ORDER BY 
    Costo_Promedio_Mantenimiento DESC;
    
--FIN VISTAS CREADAS POR ANDRES
    
    
    
    
--VISTAS CREADAS POR CARLOS    

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

--FIN VISTAS CREADAS POR CARLOS
    

    