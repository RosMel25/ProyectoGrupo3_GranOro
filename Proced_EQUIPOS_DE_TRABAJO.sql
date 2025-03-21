CREATE OR REPLACE PACKAGE BODY PROCE_Equipos_de_Trabajo AS

    PROCEDURE Agregar_Equipo(
        pNo_Activo IN INT,
        pNombre_Equipo IN VARCHAR2,
        pTipo_Equipo IN VARCHAR2,
        pGarantia_Equipo IN DATE,
        pId_Proveedor IN INT,
        pNo_Finca IN INT
    ) AS
    BEGIN
        INSERT INTO Equipos_de_Trabajo (No_Activo, Nombre_Equipo, Tipo_Equipo, Garantia_Equipo, Id_Proveedor, No_Finca)
        VALUES (pNo_Activo, pNombre_Equipo, pTipo_Equipo, pGarantia_Equipo, pId_Proveedor, pNo_Finca);
    END Agregar_Equipo;

    PROCEDURE Buscar_Equipo(
        pNo_Activo IN INT,
        pNombre_Equipo OUT VARCHAR2,
        pTipo_Equipo OUT VARCHAR2,
        pGarantia_Equipo OUT DATE,
        pId_Proveedor OUT INT,
        pNo_Finca OUT INT
    ) AS
    BEGIN
        SELECT Nombre_Equipo, Tipo_Equipo, Garantia_Equipo, Id_Proveedor, No_Finca
        INTO pNombre_Equipo, pTipo_Equipo, pGarantia_Equipo, pId_Proveedor, pNo_Finca
        FROM Equipos_de_Trabajo
        WHERE No_Activo = pNo_Activo;
    END Buscar_Equipo;

    PROCEDURE Editar_Equipo(
        pNo_Activo IN INT,
        pNombre_Equipo IN VARCHAR2,
        pTipo_Equipo IN VARCHAR2,
        pGarantia_Equipo IN DATE,
        pId_Proveedor IN INT,
        pNo_Finca IN INT
    ) AS
    BEGIN
        UPDATE Equipos_de_Trabajo
        SET Nombre_Equipo = pNombre_Equipo,
            Tipo_Equipo = pTipo_Equipo,
            Garantia_Equipo = pGarantia_Equipo,
            Id_Proveedor = pId_Proveedor,
            No_Finca = pNo_Finca
        WHERE No_Activo = pNo_Activo;
    END Editar_Equipo;

    PROCEDURE Eliminar_Equipo(
        pNo_Activo IN INT
    ) AS
    BEGIN
        DELETE FROM Equipos_de_Trabajo
        WHERE No_Activo = pNo_Activo;
    END Eliminar_Equipo;
    
END PROCE_Equipos_de_Trabajo;