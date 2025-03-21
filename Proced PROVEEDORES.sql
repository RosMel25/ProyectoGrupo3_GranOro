CREATE OR REPLACE PACKAGE BODY PROCE_Proveedores AS

    PROCEDURE Agregar_Proveedor(
        pId_Proveedor IN INT,
        pNombre_Proveedor IN VARCHAR2,
        pUbicacion_Proveedor IN VARCHAR2,
        pTelefono_Proveedor IN VARCHAR2,
        pEmail_Proveedor IN VARCHAR2
    ) AS
    BEGIN
        INSERT INTO Proveedores (Id_Proveedor, Nombre_Proveedor, Ubicacion_Proveedor, Telefono_Proveedor, Email_Proveedor)
        VALUES (pId_Proveedor, pNombre_Proveedor, pUbicacion_Proveedor, pTelefonoProveedor, pEmail_Proveedor);
    END Agregar_Proveedor;

    PROCEDURE Buscar_Proveedor(
        pId_Proveedor IN INT,
        pNombre_Proveedor OUT VARCHAR2,
        pUbicacion_Proveedor OUT VARCHAR2,
        pTelefono_Proveedor OUT VARCHAR2,
        pEmail_Proveedor OUT VARCHAR2
    ) AS
    BEGIN
        SELECT Nombre_Proveedor, Ubicacion_Proveedor, Telefono_Proveedor, Email_Proveedor
        INTO pNombre_Proveedor, pUbicacion_Proveedor, pTelefono_Proveedor, pEmail_Proveedor
        FROM Proveedores
        WHERE Id_Proveedor = pId_Proveedor;
    END Buscar_Proveedor;

    PROCEDURE Editar_Proveedor(
        pId_Proveedor IN INT,
        pNombre_Proveedor IN VARCHAR2,
        pUbicacion_Proveedor IN VARCHAR2,
        pTelefono_Proveedor IN VARCHAR2,
        pEmail_Proveedor IN VARCHAR2
    ) AS
    BEGIN
        UPDATE Proveedores
        SET Nombre_Proveedor = pNombre_Proveedor,
            Ubicacion_Proveedor = pUbicacion_Proveedor,
            Telefono_Proveedor = pTelefono_Proveedor,
            Email_Proveedor = pEmail_Proveedor
        WHERE Id_Proveedor = pId_Proveedor;
    END Editar_Proveedor;

    PROCEDURE Eliminar_Proveedor(
        pId_Proveedor IN INT
    ) AS
    BEGIN
        DELETE FROM Proveedores
        WHERE Id_Proveedor = pId_Proveedor;
    END Eliminar_Proveedor;
    
END PROCE_Proveedores;