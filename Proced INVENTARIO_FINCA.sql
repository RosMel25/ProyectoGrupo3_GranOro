CREATE OR REPLACE PACKAGE BODY PROCE_Inventario_Finca AS

    PROCEDURE Agregar_Producto(
        pCod_Producto IN INT,
        pNombre_Producto IN VARCHAR2,
        pCantidad_Producto IN INT,
        pNo_Finca IN INT,
        pId_Proveedor IN INT
    ) AS
    BEGIN
        INSERT INTO Inventario_Finca (Cod_Producto, Nombre_Producto, Cantidad_Producto, No_Finca, Id_Proveedor)
        VALUES (pCod_Producto, pNombre_Producto, pCantidad_Producto, pNo_Finca, pId_Proveedor);
    END Agregar_Producto;

    PROCEDURE Buscar_Producto(
        pCod_Producto IN INT,
        pNombre_Producto OUT VARCHAR2,
        pCantidad_Producto OUT INT,
        pNo_Finca OUT INT,
        pId_Proveedor OUT INT
    ) AS
    BEGIN
        SELECT Nombre_Producto, Cantidad_Producto, No_Finca, Id_Proveedor
        INTO pNombre_Producto, pCantidad_Producto, pNo_Finca, pId_Proveedor
        FROM Inventario_Finca
        WHERE Cod_Producto = pCod_Producto;
    END Buscar_Producto;

    PROCEDURE Editar_Producto(
        pCod_Producto IN INT,
        pNombre_Producto IN VARCHAR2,
        pCantidad_Producto IN INT,
        pNo_Finca IN INT,
        pId_Proveedor IN INT
    ) AS
    BEGIN
        UPDATE Inventario_Finca
        SET Nombre_Producto = pNombre_Producto,
            Cantidad_Producto = pCantidad_Producto,
            No_Finca = pNo_Finca,
            Id_Proveedor = pId_Proveedor
        WHERE Cod_Producto = pCod_Producto;
    END Editar_Producto;

    PROCEDURE Eliminar_Producto(
        pCod_Producto IN INT
    ) AS
    BEGIN
        DELETE FROM Inventario_Finca
        WHERE Cod_Producto = pCod_Producto;
    END Eliminar_Producto;
    
END PROCE_Inventario_Finca;