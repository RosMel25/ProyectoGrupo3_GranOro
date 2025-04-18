CREATE OR REPLACE FUNCTION obtener_salario_total_empleados
RETURN NUMBER
AS
    total_salario NUMBER := 0;
BEGIN
    SELECT SUM(SALARIO)
    INTO total_salario
    FROM EMPLEADOS;

    RETURN total_salario;
END;

CREATE OR REPLACE FUNCTION nombre_completo_empleado(p_id_empleado NUMBER)
RETURN VARCHAR2
IS
    nombre_completo VARCHAR2(255);
BEGIN
    SELECT NOMBRE_EMPLEADO || ' ' || APELLIDO_EMPLEADO
    INTO nombre_completo
    FROM EMPLEADOS
    WHERE IDENTIFICACION_EMPLEADO = p_id_empleado;

    RETURN nombre_completo;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN 'NO ENCONTRADO';
END;

CREATE OR REPLACE FUNCTION total_empleados_por_finca(p_no_finca NUMBER)
RETURN NUMBER
IS
    total NUMBER;
BEGIN
    SELECT COUNT(*)
    INTO total
    FROM EMPLEADOS
    WHERE NO_FINCA = p_no_finca;

    RETURN total;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN 0;
END;

CREATE OR REPLACE FUNCTION tiene_correo_institucional(p_id_empleado NUMBER)
RETURN VARCHAR2
IS
    correo VARCHAR2(255);
BEGIN
    SELECT EMAIL INTO correo
    FROM EMPLEADOS
    WHERE IDENTIFICACION_EMPLEADO = p_id_empleado;

    IF correo LIKE '%@empresa.com' THEN
        RETURN 'SÍ';
    ELSE
        RETURN 'NO';
    END IF;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN 'NO EXISTE';
END;

CREATE OR REPLACE FUNCTION contar_empleados_rango(p_min NUMBER, p_max NUMBER)
RETURN NUMBER
IS
    total NUMBER;
BEGIN
    SELECT COUNT(*) INTO total
    FROM EMPLEADOS
    WHERE SALARIO BETWEEN p_min AND p_max;

    RETURN total;
END;

CREATE OR REPLACE FUNCTION obtener_salario_promedio_puesto(p_id_puesto NUMBER)
RETURN NUMBER
IS
    salario_promedio NUMBER := 0;
BEGIN
    SELECT AVG(SALARIO)
    INTO salario_promedio
    FROM EMPLEADOS
    WHERE ID_PUESTO = p_id_puesto;

    RETURN salario_promedio;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN 0;
END;


