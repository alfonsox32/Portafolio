CREATE DATABASE ValeFacil
USE ValeFacil

EXEC sp_spaceused

-- Cambiar a modo simple (para que el log se libere automáticamente)
ALTER DATABASE ValeFacil SET RECOVERY SIMPLE;
GO

-- Reducir el archivo de log
DBCC SHRINKFILE (ValeFacil_log, 100); -- 50 es el tamaño final en MB (ajusta a lo que desees)

SELECT name, type_desc, physical_name
FROM sys.database_files;


SELECT 
    name AS [Logical Name],
    type_desc AS [File Type],
    physical_name AS [Physical File],
    size * 8 / 1024 AS [Size_MB]
FROM sys.database_files;


USE master;
ALTER DATABASE ValeFacil SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
ALTER DATABASE ValeFacil SET MULTI_USER;


CREATE TABLE CLIENTES(
	idCliente INT IDENTITY(1,1),
	nombreCliente VARCHAR(150) NOT NULL,
	domicilio VARCHAR(MAX),
	prestamo money NOT NULL,
	montoActual money NOT NULL,                                 ----------Editar Esta Estructura con nmreo TELEFONO
	numeroQuinsenas INT NOT NULL,
	fechaVale DATETIME NOT NULL DEFAULT GETDATE(),
	numeroPago INT NOT NULL,
	imagenIne VARBINARY(MAX) NULL,

	CONSTRAINT PK_idCliente PRIMARY KEY(idCliente)
)
CREATE TABLE DISTRIBUIDORAS(
	idDistribuidora INT IDENTITY(1,1),                           ----------Editar Esta Estructura con nmreo TELEFONO
	nombreDistribuidora VARCHAR(150)not null,
	direccionDistribuidora VARCHAR(MAX)NOT NULL,
	disponible money NULL
)
select *from DISTRIBUIDORAS

ALTER TABLE CLIENTES
ALTER COLUMN prestamo money;

ALTER TABLE DISTRIBUIDORAS
DROP COLUMN valorDeCartera

ALTER TABLE CLIENTES
ADD telefonoClientes VARCHAR(20) NULL;

ALTER TABLE DISTRIBUIDORAS
ADD telefonoDistribuidoras VARCHAR(20) NULL;

ALTER TABLE CLIENTES
ALTER COLUMN cantidadPago MONEY;	

ALTER TABLE CLIENTES
ADD fechaVale DATETIME NOT NULL DEFAULT GETDATE()

ALTER TABLE CLIENTES
ALTER COLUMN montoActual money;
 
 SELECT * FROM DISTRIBUIDORAS

 --Añadir FK
 ALTER TABLE CLIENTES 
   ADD CONSTRAINT FK_CLIENTESDistribuidoras
   FOREIGN KEY (idDistribuidora)
   REFERENCES DISTRIBUIDORAS(idDistribuidora)


go
ALTER PROCEDURE CLIENTESDISTRIBUIDORA
AS 
BEGIN TRY
    SELECT 
        CLI.idCliente AS 'Folio Del Vale',
        CLI.nombreCliente AS 'Nombre Del Cliente',
        CONCAT('$', CAST(CLI.prestamo AS money)) AS 'Prestamo',
        CONCAT('$', CAST(CLI.montoActual AS money)) AS 'Monto Despues de pago',    ----------Editar Esta Estructura con nmreo TELEFONO
        CLI.numeroQuinsenas AS 'No_Quincenas',
		CLI.cantidadPago AS 'Pago Quinsena',
        CLI.numeroPago AS 'Pago Numero',
		CLI.telefonoClientes AS 'Telefono del Cliente',
		DIS.nombreDistribuidora AS 'Distribuidora',
		CLI.domicilio AS 'Domicilio',
        CLI.fechaVale AS 'Fecha del vale'
    FROM 
        CLIENTES AS CLI
    INNER JOIN 
        DISTRIBUIDORAS AS DIS
    ON 
        CLI.idDistribuidora = DIS.idDistribuidora -- Ajuste aquí en el JOIN
		ORDER BY nombreCliente ASC;
END TRY
BEGIN CATCH
    RAISERROR('Error en la Proyección', 16, 1);
END CATCH;

GO
EXEC CLIENTESDISTRIBUIDORA

--------------------------------------------------------------------------------------------------------

GO
ALTER PROCEDURE VERCLIENTES
AS
BEGIN TRY SELECT CLI.idCliente as 'Folio Del Vale',CLI.nombreCliente as 'Nombre del Cliente',CONCAT('$', CAST(CLI.prestamo AS money)) AS 'Prestamo',
        CONCAT('$', CAST(CLI.montoActual AS money)) AS 'Monto Despues de pago',CLI.numeroQuinsenas as 'No_Quinsenas',CLI.numeroPago as 'Pago Numero',CLI.telefonoClientes AS 'Telefono del Cliente',DIS.nombreDistribuidora as 'Distribuidora',CLI.domicilio as 'Domicilio',fechaVale as 'Fecha del vale'
	 FROM 
        CLIENTES AS CLI
    INNER JOIN                                                                       ----------Editar Esta Estructura con nmreo TELEFONO
        DISTRIBUIDORAS AS DIS
    ON 
        CLI.idDistribuidora = DIS.idDistribuidora -- Ajuste aquí en el JOIN
	 ORDER BY nombreCliente ASC;
END TRY
BEGIN CATCH
	RAISERROR('Error en la Visualizacion',16,1);
END CATCH
GO
EXEC VERCLIENTES

--------------------------------------------------------------------------------------------------------

GO
ALTER PROCEDURE VERDISTRIBUIDORAS
AS
BEGIN TRY SELECT d.idDistribuidora as 'Clave Distribuidora',d.nombreDistribuidora as 'Nombre De Distribuidora',d.direccionDistribuidora as 'Direccion', d.telefonoDistribuidoras AS 'Telefono Distribuidora',
	CONCAT('$', CAST(SUM(c.montoActual) AS money)) AS 'Valor De Cartera',CONCAT('$', CAST(d.disponible AS money)) AS 'Efectivo Disponible', COUNT(c.idCliente) AS 'Clientes Asociados'
	FROM 
    DISTRIBUIDORAS d
LEFT JOIN 
    CLIENTES c
ON                                                                                         ----------Editar Esta Estructura con nmreo TELEFONO
    d.idDistribuidora = c.idDistribuidora
	GROUP BY 
    d.idDistribuidora, d.nombreDistribuidora,d.direccionDistribuidora,d.telefonoDistribuidoras,d.disponible
	 ORDER BY nombreDistribuidora ASC;
END TRY
BEGIN CATCH
	RAISERROR('Error en la visualizacion',16,1);
END CATCH
GO
EXEC VERDISTRIBUIDORAS

--SELECT 
--    d.idDistribuidora, 
--    d.nombreDistribuidora,
--    SUM(c.montoActual) AS 'Valor de Cartera'
--FROM DISTRIBUIDORAS d
--LEFT JOIN CLIENTES c
--ON d.idDistribuidora = c.idDistribuidora
--GROUP BY d.idDistribuidora, d.nombreDistribuidora;


select *from DISTRIBUIDORAS
EXEC VERDISTRIBUIDORAS
SELECT *FROM DISTRIBUIDORAS

--ALTER TABLE DISTRIBUIDORAS
--DROP COLUMN cantidadPrestamos;



--ALTER PROCEDURE AGREGARCLIENTE 
--    @nombreCliente VARCHAR(250),
--    @domicilio VARCHAR(MAX),
--    @prestamo MONEY,
--    @numeroQuinsenas INT,
--    @numeroPago INT,
--    @idDistribuidora INT,
--    @imagenIne VARBINARY(MAX) NULL,
--    @message VARCHAR(70) OUTPUT
--AS
--BEGIN
--    SET IMPLICIT_TRANSACTIONS OFF;
--    BEGIN TRANSACTION AGREGARCLIENTE;

--    -- Verificar que los datos esenciales estén completos
--    IF (@nombreCliente IS NULL OR @domicilio IS NULL)
--    BEGIN
--        SET @message = 'Debes ingresar información completa del cliente';
--        ROLLBACK TRANSACTION AGREGARCLIENTE;
--        RETURN;
--    END

--    BEGIN TRY
--        -- Declarar las variables para cálculos
--        DECLARE @porcentaje MONEY;
--        DECLARE @montoActual MONEY;
--        DECLARE @cantidadPago MONEY;

--        -- Asignar el porcentaje según las reglas
--        IF (@prestamo = 1000)
--            SET @porcentaje = 0.36;
--        ELSE IF (@prestamo = 2000 AND @numeroQuinsenas = 4)
--            SET @porcentaje = 0.36;
--        ELSE IF (@prestamo = 2000 AND @numeroQuinsenas = 6)
--            SET @porcentaje = 0.40;
--        ELSE IF (@prestamo = 2000 AND @numeroQuinsenas = 8)
--            SET @porcentaje = 0.52;
--        ELSE IF (@prestamo = 3000 AND @numeroQuinsenas = 6)
--            SET @porcentaje = 0.40;
--        ELSE IF (@prestamo = 3000 AND @numeroQuinsenas = 8)
--            SET @porcentaje = 0.52;
--        ELSE IF (@prestamo = 3000 AND @numeroQuinsenas = 10)
--            SET @porcentaje = 0.65;
--        ELSE IF (@prestamo = 4000 AND @numeroQuinsenas = 8)
--            SET @porcentaje = 0.52;
--        ELSE IF (@prestamo = 4000 AND @numeroQuinsenas = 10)
--            SET @porcentaje = 0.65;
--        ELSE IF (@prestamo = 4000 AND @numeroQuinsenas = 12)
--            SET @porcentaje = 0.78;
--        ELSE IF (@prestamo = 5000 AND @numeroQuinsenas = 8)
--            SET @porcentaje = 0.52;
--        ELSE IF (@prestamo = 5000 AND @numeroQuinsenas = 10)
--            SET @porcentaje = 0.65;
--        ELSE IF (@prestamo = 5000 AND @numeroQuinsenas = 12)
--            SET @porcentaje = 0.78;
--        ELSE IF (@prestamo = 6000 AND @numeroQuinsenas = 10)
--            SET @porcentaje = 0.65;
--        ELSE IF (@prestamo = 6000 AND @numeroQuinsenas = 12)
--            SET @porcentaje = 0.78;
--        ELSE IF (@prestamo = 7000 AND @numeroQuinsenas = 10)
--            SET @porcentaje = 0.65;
--        ELSE IF (@prestamo = 7000 AND @numeroQuinsenas = 12)
--            SET @porcentaje = 0.78;
--        ELSE IF (@prestamo = 8000 AND @numeroQuinsenas = 10)
--            SET @porcentaje = 0.65;
--        ELSE IF (@prestamo = 8000 AND @numeroQuinsenas = 12)
--            SET @porcentaje = 0.78;
--        ELSE
--            SET @porcentaje = 0; -- Si no se cumple ninguna condición, asigna un valor predeterminado

--        -- Validar que no haya valores nulos o divisiones por cero
--        IF (@prestamo IS NULL OR @porcentaje IS NULL OR @numeroQuinsenas IS NULL OR @numeroQuinsenas = 0)
--        BEGIN
--            SET @message = 'Error: Valores inválidos en préstamo, porcentaje o número de quincenas.';
--            ROLLBACK TRANSACTION AGREGARCLIENTE;
--            RETURN;
--        END

--        -- Realizar los cálculos
--        SET @montoActual = @prestamo + (@prestamo * @porcentaje);
--        SET @cantidadPago = @montoActual / @numeroQuinsenas;

--        -- Insertar el cliente en la tabla
--        INSERT INTO CLIENTES (nombreCliente, domicilio, prestamo, montoActual, numeroQuinsenas, cantidadPago, numeroPago, idDistribuidora, imagenIne)
--        VALUES (UPPER(@nombreCliente), UPPER(@domicilio), @prestamo, @montoActual, @numeroQuinsenas, @cantidadPago, @numeroPago, @idDistribuidora, @imagenIne);

--        -- Confirmar la transacción
--        COMMIT TRANSACTION AGREGARCLIENTE;
--        SET @message = 'Cliente guardado exitosamente';
--    END TRY
--    BEGIN CATCH
--        -- Manejo de errores
--        ROLLBACK TRANSACTION AGREGARCLIENTE;
--        SET @message = 'Error al guardar, revisa los valores ingresados.';
--    END CATCH
--END;

DECLARE @message VARCHAR(70);
EXEC AGREGARCLIENTE 'OSCAR PEREZ vargas jorjela cares','La vega calle  #342',5000,7800,10,1,520,1,NULL,@message OUTPUT;

EXEC CLIENTESDISTRIBUIDORA
SELECT *FROM CLIENTES
DBCC CHECKIDENT (CLIENTES, RESEED, 1007);
--------------------
DELETE FROM CLIENTES
	WHERE idCliente = 4
--------------------------------------------------------------------------------------------------------------
GO
ALTER PROCEDURE AGREGARDISTRIBUIDORAS
	@nombreDistribuidora VARCHAR(150),
	@direccionDistribuidora VARCHAR(MAX), 
	@disponible MONEY NULL,
	@numeroTelefono VARCHAR(20)NULL,
    @message VARCHAR(70) OUTPUT
AS
BEGIN
    SET IMPLICIT_TRANSACTIONS OFF;
	                                                                                          ----------Editar Esta Estructura con nmreo TELEFONO
    BEGIN TRANSACTION C;

	 IF (@nombreDistribuidora IS NULL OR @direccionDistribuidora IS NULL)
    BEGIN
        SET @message = 'Debes ingresar información completa del la "DISTRIBUIDORA/o"';
        ROLLBACK TRANSACTION AGREGARDISTRIBUIDORAS;
    END
    ELSE
    BEGIN
	BEGIN TRY 
	INSERT INTO DISTRIBUIDORAS (nombreDistribuidora,direccionDistribuidora,disponible,telefonoDistribuidoras)
	VALUES(UPPER(@nombreDistribuidora),UPPER(@direccionDistribuidora),@disponible,@numeroTelefono)

	COMMIT TRANSACTION AGREGARDISTRIBUIDORAS;
	SET @message = 'Distribuidora/o Guardada Exitosamente'
	END TRY
	BEGIN CATCH
            ROLLBACK TRANSACTION AGREGARCLIENTE;
            SET @message = 'Error al guardar LA DISTRIBUIDORA/o, revisa los valores ingresados.';
        END CATCH
    END
END;
GO

DECLARE @message VARCHAR(70);
EXEC AGREGARDISTRIBUIDORAS 'Sofia Dominguez Solis','Colonia Emiliano zapata #433 calle Juan antonio',35000,8727765454,@message OUTPUT

EXEC VERDISTRIBUIDORAS
---------------------------------------------------------------------------------------------------------------------
GO
ALTER PROCEDURE MODIFICARCLIENTES
	@idCliente INT,
	@nombreClietne VARCHAR(150),
	@domicilio VARCHAR(MAX),
	@telefonoClientes VARCHAR(20)NULL,
	@imagenINE VARBINARY(MAX)NULL
	
AS
BEGIN                                                                             ----------Editar Esta Estructura con nmreo TELEFONO
	UPDATE CLIENTES
	SET nombreCliente = UPPER( @nombreClietne),
		domicilio = UPPER(@domicilio),
		telefonoClientes = @telefonoClientes,
		imagenIne = @imagenINE
		WHERE idCliente = @idCliente;
END;
GO

EXEC CLIENTESDISTRIBUIDORA
SELECT *FROM CLIENTES

EXEC MODIFICARCLIENTES 6,'ALFONSO VARGAS',2,498,'calle felipe angeles fco villa',6000,9200,16,9,NULL;


GO 
ALTER PROCEDURE RECIENTES
AS
SELECT CLI.idCliente as 'Folio Vale', CLI.nombreCliente as 'Nombre del Cliente',CONCAT('$', CAST(CLI.prestamo AS money)) as 'Prestamo',CONCAT('$', CAST(CLI.montoActual AS money)) as 'Monto Despues de Pago',
	CLI.numeroQuinsenas as 'No_Quinsena', CLI.numeroPago AS 'Numero de Pago',CONCAT('$', CAST(CLI.cantidadPago AS money)) AS 'Pago Quinsenal',CLI.telefonoClientes AS 'Telefono Cliente', DIS.nombreDistribuidora as 'Distribuidora',CLI.domicilio as 'Domicilio',CLI.fechaVale as 'Fecha del vale'
 FROM 
        CLIENTES AS CLI
    INNER JOIN 
        DISTRIBUIDORAS AS DIS                                                           ----------Editar Esta Estructura con nmreo TELEFONO
    ON 
        CLI.idDistribuidora = DIS.idDistribuidora -- Ajuste aquí en el JOIN
ORDER BY fechaVale DESC;
GO

EXEC RECIENTES

SELECT numeroQuinsenas FROM CLIENTES


GO
ALTER PROCEDURE vwClientesP
AS
SELECT CLI.idCliente as 'ID cliente', CLI.nombreCliente as 'Nombre del Cliente', CONCAT('$', CAST(CLI.prestamo AS money)) AS 'Presatamo',  
	CONCAT('$', CAST(CLI.montoActual AS money)) AS 'Monto Despues del Pago', CLI.numeroQuinsenas as 'No_Quinsenas', CLI.numeroPago as 'Numero de Pago',CLI.telefonoClientes AS 'Telefono Cliente',DIS.nombreDistribuidora as 'Distribuidora',CLI.domicilio as 'Domicilio',fechaVale as 'Fecha del vale' 
	 FROM 
        CLIENTES AS CLI
    INNER JOIN                                                                          ----------Editar Esta Estructura con nmreo TELEFONO
        DISTRIBUIDORAS AS DIS
    ON 
        CLI.idDistribuidora = DIS.idDistribuidora; -- Ajuste aquí en el JOIN
GO

exec vwClientesP

SELECT idDistribuidora,nombreDistribuidora FROM DISTRIBUIDORAS

GO
ALTER PROCEDURE MODIFICARDISTRIBUIDORA
	@idDistribuidora INT,
	@nombreDistribuidora VARCHAR(150),
	@domicilio VARCHAR(MAX),
	@disponible MONEY,
	@telefonoDistribuidoras VARCHAR(20)
AS                                                                           ----------Editar Esta Estructura con nmreo TELEFONO
BEGIN
	UPDATE DISTRIBUIDORAS
		SET nombreDistribuidora = UPPER( @nombreDistribuidora),
		direccionDistribuidora = UPPER(@domicilio),
		disponible = (@disponible),
		telefonoDistribuidoras = @telefonoDistribuidoras
		WHERE idDistribuidora = @idDistribuidora;
END;
GO

exec MODIFICARDISTRIBUIDORA 1,'alma karina hernandez','calle cepeda #417',23131,1231


SELECT *FROM DISTRIBUIDORAS
EXEC VERDISTRIBUIDORAS

------------------------------------------------------------------------------------------------------------------

--GO
--ALTER PROCEDURE ELIMINARCLIENTE
--	@idCliente INT,
--	@message VARCHAR(250) OUTPUT
--AS
--	SET IMPLICIT_TRANSACTIONS OFF
--		BEGIN TRAN ELIMINARCLIENTE

--		UPDATE DISTRIBUIDORAS
--        SET disponible = disponible + c.prestamo
--            FROM CLIENTES c
--            WHERE c.idDistribuidora = DISTRIBUIDORAS.idDistribuidora

--		---Evaluar los parametros de entrada
--		IF (@idCliente IS NULL)
--		BEGIN---{
--			PRINT 'Debes ingesar el ID del cliente para eliminar'
--		END---}
--		ELSE
--			BEGIN TRY
--				 DELETE FROM CLIENTES WHERE idCliente = @idCliente;
--				COMMIT
--				SET @message = 'El cliente fue Eliminado de manera exitosa.'
--			END TRY
--			BEGIN CATCH
--				ROLLBACK
--				SET @message = 'Error al Eliminar, revisa el ID ingresado.'
--			END CATCH
--GO
GO
CREATE PROCEDURE ELIMINARDISTRIBUIDORA
    @idDistribuidora INT, -- Parámetro de entrada
    @message VARCHAR(250) OUTPUT -- Mensaje de salida
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION ELIMINARDISTRIBUIDORA;

    BEGIN TRY
        -- Verificar si hay clientes asociados a la distribuidora
        IF EXISTS (
            SELECT 1 
            FROM CLIENTES 
            WHERE idDistribuidora = @idDistribuidora
        )
        BEGIN
            -- Si hay clientes asociados, no se elimina la distribuidora
            SET @message = 'No se puede eliminar la distribuidora porque tiene clientes asociados.';
            ROLLBACK TRANSACTION ELIMINARDISTRIBUIDORA;
            RETURN;
        END

        -- Eliminar la distribuidora
        DELETE FROM DISTRIBUIDORAS
        WHERE idDistribuidora = @idDistribuidora;

        -- Confirmar la transacción
        COMMIT TRANSACTION ELIMINARDISTRIBUIDORA;

        -- Mensaje de éxito
        SET @message = 'Distribuidora eliminada exitosamente.';
    END TRY
    BEGIN CATCH
        -- Manejo de errores
        ROLLBACK TRANSACTION ELIMINARDISTRIBUIDORA;
        SET @message = 'Error al intentar eliminar la distribuidora.';
    END CATCH
END;
GO

GO
ALTER PROCEDURE ELIMINARCLIENTE
    @idCliente INT,
    @message VARCHAR(250) OUTPUT
AS
BEGIN
    SET IMPLICIT_TRANSACTIONS OFF

    BEGIN TRAN ELIMINARCLIENTE

    -- Verificar los parámetros de entrada
    IF (@idCliente IS NULL)
    BEGIN
        PRINT 'Debes ingresar el ID del cliente para eliminar'
        ROLLBACK TRANSACTION ELIMINARCLIENTE
        RETURN
    END

    BEGIN TRY
        -- Actualizar el disponible de la distribuidora basado en el monto pendiente
        UPDATE DISTRIBUIDORAS
        SET disponible = disponible + (
            SELECT
                c.prestamo - (c.numeroPago * c.cantidadPago) -- Monto pendiente del préstamo
            FROM CLIENTES c
            WHERE c.idCliente = @idCliente
        )
        WHERE DISTRIBUIDORAS.idDistribuidora = (
            SELECT c.idDistribuidora
            FROM CLIENTES c
            WHERE c.idCliente = @idCliente
        );

        -- Eliminar al cliente
        DELETE FROM CLIENTES WHERE idCliente = @idCliente;

        -- Confirmar los cambios
        COMMIT TRANSACTION ELIMINARCLIENTE
        SET @message = 'El cliente fue eliminado de manera exitosa.'
    END TRY
    BEGIN CATCH
        -- Revertir los cambios en caso de error
        ROLLBACK TRANSACTION ELIMINARCLIENTE
        SET @message = 'Error al eliminar, revisa el ID ingresado.'
    END CATCH
END;
GO

EXEC VERDISTRIBUIDORAS
EXEC VERCLIENTES
----------------------------------------------------------------
DECLARE @message VARCHAR(250);
EXEC ELIMINARCLIENTE @idCliente = 3137, @message = @message OUTPUT;
PRINT @message;
------------------------------------------------------------------------------------------------------------------


DECLARE @message VARCHAR(250);
EXEC ELIMINARCLIENTE 3,@message OUTPUT
EXEC CLIENTESDISTRIBUIDORA

SELECT *FROM CLIENTES


------------------------------
-- Respaldar la tabla CLIENTES
SELECT *
INTO CLIENTES_BACKUP
FROM CLIENTES;

-- Respaldar la tabla DISTRIBUIDORAS
SELECT *
INTO DISTRIBUIDORAS_BACKUP
FROM DISTRIBUIDORAS;


----------------------------------------------------------------------

------------------------------------------------

GO
------------------------------------------------------elBEUNO


exec HACERCORTE

EXEC VERCLIENTES
EXEC VERDISTRIBUIDORAS

------------------------------------------------------
BACKUP DATABASE ValeFacil
TO DISK = 'C:\Temp\BDrespaldo\ValeFacil.bak'
WITH FORMAT;

------------------------------------------------------

BEGIN TRANSACTION;
-- Actualiza los datos
UPDATE CLIENTES SET numeroPago = numeroPago - 1 WHERE numeroPago > 0;
-- Confirma el cambio
COMMIT;


GO
ALTER PROCEDURE MOSTRARDISTRIBUIDORASPARaAgregarVale
as
SELECT idDistribuidora,nombreDistribuidora,disponible  FROM DISTRIBUIDORAS
GO

EXEC MOSTRARDISTRIBUIDORASPARaAgregarVale

SELECT *FROM CLIENTES

exec HACERCORTE
--------------------------------------------------Sumar cantidades de pago 

---------------------------------------------------
--SELECT 
--    d.idDistribuidora, 
--    d.nombreDistribuidora,
--    SUM(c.montoActual) AS 'Valor de Cartera'
--FROM DISTRIBUIDORAS d
--LEFT JOIN CLIENTES c
--ON d.idDistribuidora = c.idDistribuidora
--GROUP BY d.idDistribuidora, d.nombreDistribuidora;

SELECT *FROM vwRelaciones
exec CLIENTESDISTRIBUIDORA
SELECT *FROM DISTRIBUIDORAS
-----------------------------------------------------------------------
ALTER VIEW vwRelaciones
AS
SELECT 
    d.nombreDistribuidora AS 'Nombre Distribuidora',
    c.idDistribuidora AS 'idDistribuidora',
    c.idCliente AS 'Folio Vale',
    c.nombreCliente AS 'Nombre del Cliente',
    c.prestamo AS 'Prestamo',
    SUM(c.montoActual) AS 'Monto despues del Pago',
    c.numeroQuinsenas AS 'NoQuinsenas',
    c.numeroPago AS 'Numero Pago',
    SUM(c.cantidadPago) AS 'Pagos Quincenales'
FROM 
    CLIENTES c
LEFT JOIN 
    DISTRIBUIDORAS d ON c.idDistribuidora = d.idDistribuidora
GROUP BY 
    d.nombreDistribuidora, c.idDistribuidora, c.idCliente, c.nombreCliente, c.prestamo, c.montoActual, c.numeroQuinsenas, c.numeroPago

UNION ALL

SELECT 
    NULL AS 'Nombre Distribuidora',
    NULL AS 'idDistribuidora',
    NULL AS 'Folio Vale', 
    'TOTAL GENERAL' AS 'Numero Pago',
    NULL AS 'Prestamo',
    SUM(c.montoActual) AS 'Monto despues del Pago',
    NULL AS 'NoQuinsenas',
    NULL AS 'Numero Pago',
    SUM(c.cantidadPago) AS 'Total Pagos Quincenales'
FROM 
    CLIENTES c;
GO
select *from vwRelaciones
SELECT TOP 1 * FROM vwRelaciones;

ALTER VIEW vwRecibos
AS
SELECT 
    d.nombreDistribuidora AS 'Nombre Distribuidora',
    c.idDistribuidora AS 'idDistribuidora',
    c.idCliente AS 'Folio Vale',
    c.nombreCliente AS 'Nombre del Cliente',
    CAST(c.prestamo AS decimal(18, 2)) AS 'Prestamo',
    c.numeroPago AS 'Pago numero',
    c.numeroQuinsenas AS 'Quinsenas Totales',
    CAST(c.cantidadPago AS decimal(18, 2)) AS 'Pago Quinsenal',
    CAST(c.montoActual AS decimal(18, 2)) AS 'Monto Despues del Pago',
    FORMAT(c.fechaVale, 'dd/MM/yyyy') AS 'Fecha del Vale'
FROM 
    CLIENTES c
LEFT JOIN 
    DISTRIBUIDORAS d ON c.idDistribuidora = d.idDistribuidora;
GO
----------------------------------------------------------------------------------
go
Alter view vwRelaciones
as
SELECT 
	idDistribuidora as 'idDistribuidora',
    idCliente AS 'Folio Vale',
    nombreCliente AS 'Nombre del Cliente',
	prestamo as 'Prestamo',
	SUM(montoActual) as 'Monto despues del Pago',
	numeroQuinsenas as 'NoQuinsenas',
	numeroPago as 'Numero Pago',
    SUM(cantidadPago) AS 'Pagos Quincenales'
FROM 
    CLIENTES
GROUP BY 
    idDistribuidora, idCliente, nombreCliente,prestamo,montoActual,numeroQuinsenas,numeroPago

UNION ALL

SELECT 
	NULL AS 'idDistribuidora',
    NULL AS 'Folio Vale', 
    'TOTAL GENERAL' AS 'Numero Pago',
    NULL AS 'Prestamo',
    SUM(montoActual) as 'Monto despues del Pago',
    NULL AS 'NoQuinsenas',
    NULL AS 'Numero Pago',
    SUM(cantidadPago) AS 'Total Pagos Quincenales'
FROM 
    CLIENTES;
go

SELECT *FROM vwRelaciones
-------------------------------------------------------------


select *from DISTRIBUIDORAS
--------------------------------------------------------------------------
GO
ALTER VIEW vwRecibos
AS
SELECT 
	idDistribuidora as 'idDistribuidora',
    idCliente AS 'Folio Vale',
    nombreCliente AS 'Nombre del Cliente',
    CAST(prestamo AS decimal(18, 2)) AS 'Prestamo',
    numeroPago AS 'Pago numero',
    numeroQuinsenas AS 'Quinsenas Totales',
    CAST(cantidadPago AS decimal(18, 2)) AS 'Pago Quinsenal',
    CAST(montoActual AS decimal(18, 2)) AS 'Monto Despues del Pago',
    FORMAT(fechaVale, 'dd/MM/yyyy') AS 'Fecha del Vale'
FROM CLIENTES
GO
------------------------------------------------------------

SELECT 
	
    SUM(cantidadPago) AS 'Total Pagos Quincenales'
FROM 
    CLIENTES
GROUP BY 
    idCliente,nombreCliente WITH ROLLUP;


SELECT *FROM vwRelaciones


GO
CREATE VIEW vwRelaciones
AS
SELECT idCliente as 'ID cliente', nombreCliente as 'Nombre del Cliente', domicilio as 'Domicilio', CONCAT('$', CAST(prestamo AS money)) AS 'Presatamo',
	CONCAT('$', CAST(SUM(cantidadPago) AS money)) AS 'Dinero esperado esta Quinsena',CONCAT('$', CAST(SUM(montoActual) AS money)) AS 'Monto Despues de esta Quinsena'
FROM CLIENTES
GROUP BY idCliente, nombreCliente,domicilio,prestamo WITH ROLLUP;
GO
select *from vwRelaciones

GO
Alter VIEW vwRelacionesDis
AS
SELECT idDistribuidora as 'idDistribuidora', idCliente as 'ID cliente', nombreCliente as 'Nombre del Cliente', domicilio as 'Domicilio', CONCAT('$', CAST(prestamo AS money)) AS 'Presatamo',
	CONCAT('$', CAST(SUM(cantidadPago) AS money)) AS 'Dinero esperado esta Quinsena',CONCAT('$', CAST(SUM(montoActual) AS money)) AS 'Monto Despues de esta Quinsena'
FROM CLIENTES
GROUP BY idDistribuidora, idCliente, nombreCliente,domicilio,prestamo WITH ROLLUP;
GO
GO
CREATE VIEW vwRecibosDis
AS
SELECT idDistribuidora as 'idDistribuidora',idCliente as 'Folio Vale', nombreCliente as 'Nombre del Cliente',prestamo AS 'Presatamo',numeroPago AS 'Pago numero',numeroQuinsenas AS 'Quinsenas Totales',
	cantidadPago AS 'Pago Quinsenal',montoActual AS 'Monto Despues del Pago',FORMAT(fechaVale, 'dd/MM/yyyy') AS 'Fecha del Vale'
FROM CLIENTES
GO

SELECT [Folio Vale] FROM vwRecibosDis
SELECT TOP 1 * FROM vwRecibosDis




SELECT *FROM vwRecibos


ALTER VIEW vwClientes
AS
SELECT idCliente as 'ID cliente', nombreCliente as 'Nombre del Cliente', domicilio as 'Domicilio', CONCAT('$', CAST(prestamo AS money)) AS 'Presatamo',  
	CONCAT('$', CAST(montoActual AS money)) AS 'Monto Actual', numeroQuinsenas as 'No.Quinsenas', numeroPago as 'Numero de Pago',idDistribuidora as 'Distribuidora'  ,fechaVale as 'Fecha del vale',imagenIne as 'INE' FROM CLIENTES
GO
--------------------------------------------------------------
SELECT *FROM CLIENTES
SELECT *FROM vwDistribuidora


--------------------------------------------------------------------------
GO
ALTER PROCEDURE AGREGARCLIENTE 
    @nombreCliente VARCHAR(250),
    @domicilio VARCHAR(MAX),
    @prestamo MONEY,
    @numeroQuinsenas INT,
    @numeroPago INT,
    @idDistribuidora INT,
    @imagenIne VARBINARY(MAX) NULL,
	@telefonoClientes VARCHAR(20),
    @message VARCHAR(70) OUTPUT
AS
BEGIN                                                                            ----------Editar Esta Estructura con nmreo TELEFONO
    SET IMPLICIT_TRANSACTIONS OFF;
    BEGIN TRANSACTION AGREGARCLIENTE;

    -- Verificar que los datos esenciales estén completos
    IF (@nombreCliente IS NULL OR @domicilio IS NULL OR @prestamo IS NULL OR @numeroQuinsenas IS NULL OR @idDistribuidora IS NULL)
    BEGIN
        SET @message = 'Debes ingresar información completa del cliente y distribuidora';
        ROLLBACK TRANSACTION AGREGARCLIENTE;
        RETURN;
    END

    BEGIN TRY
        -- Declarar las variables para cálculos
        DECLARE @porcentaje MONEY;
        DECLARE @montoActual MONEY;
        DECLARE @cantidadPago MONEY;
        DECLARE @disponibleDistribuidora MONEY;

        -- Obtener el monto disponible de la distribuidora
        SELECT @disponibleDistribuidora = disponible 
        FROM DISTRIBUIDORAS 
        WHERE idDistribuidora = @idDistribuidora;

        -- Validar que la distribuidora exista y tenga suficiente monto disponible
        IF (@disponibleDistribuidora IS NULL)
        BEGIN
            SET @message = 'La distribuidora no existe.';
            ROLLBACK TRANSACTION AGREGARCLIENTE;
            RETURN;
        END

        IF (@prestamo > @disponibleDistribuidora)
        BEGIN
            SET @message = 'El préstamo excede el monto disponible de la distribuidora.';
            ROLLBACK TRANSACTION AGREGARCLIENTE;
            RETURN;
        END

        -- Asignar el porcentaje según las reglas
        IF (@prestamo = 1000)
            SET @porcentaje = 0.36;
        ELSE IF (@prestamo = 2000 AND @numeroQuinsenas = 4)
            SET @porcentaje = 0.36;
        ELSE IF (@prestamo = 2000 AND @numeroQuinsenas = 6)
            SET @porcentaje = 0.40;
        ELSE IF (@prestamo = 2000 AND @numeroQuinsenas = 8)
            SET @porcentaje = 0.52;
        ELSE IF (@prestamo = 3000 AND @numeroQuinsenas = 6)
            SET @porcentaje = 0.40;
        ELSE IF (@prestamo = 3000 AND @numeroQuinsenas = 8)
            SET @porcentaje = 0.52;
        ELSE IF (@prestamo = 3000 AND @numeroQuinsenas = 10)
            SET @porcentaje = 0.65;
        ELSE IF (@prestamo = 4000 AND @numeroQuinsenas = 8)
            SET @porcentaje = 0.52;
        ELSE IF (@prestamo = 4000 AND @numeroQuinsenas = 10)
            SET @porcentaje = 0.65;
        ELSE IF (@prestamo = 4000 AND @numeroQuinsenas = 12)
            SET @porcentaje = 0.78;
        ELSE IF (@prestamo = 5000 AND @numeroQuinsenas = 8)
            SET @porcentaje = 0.52;
        ELSE IF (@prestamo = 5000 AND @numeroQuinsenas = 10)
            SET @porcentaje = 0.65;
        ELSE IF (@prestamo = 5000 AND @numeroQuinsenas = 12)
            SET @porcentaje = 0.78;
        ELSE IF (@prestamo = 6000 AND @numeroQuinsenas = 10)
            SET @porcentaje = 0.65;
        ELSE IF (@prestamo = 6000 AND @numeroQuinsenas = 12)
            SET @porcentaje = 0.78;
        ELSE IF (@prestamo = 7000 AND @numeroQuinsenas = 10)
            SET @porcentaje = 0.65;
        ELSE IF (@prestamo = 7000 AND @numeroQuinsenas = 12)
            SET @porcentaje = 0.78;
        ELSE IF (@prestamo = 8000 AND @numeroQuinsenas = 10)
            SET @porcentaje = 0.65;
        ELSE IF (@prestamo = 8000 AND @numeroQuinsenas = 12)
            SET @porcentaje = 0.78;
        ELSE
            SET @porcentaje = 0; -- Si no se cumple ninguna condición, asigna un valor predeterminado

        -- Validar que no haya valores nulos o divisiones por cero
        IF (@prestamo IS NULL OR @porcentaje IS NULL OR @numeroQuinsenas IS NULL OR @numeroQuinsenas = 0)
        BEGIN
            SET @message = 'Error: Valores inválidos en préstamo, porcentaje o número de quincenas.';
            ROLLBACK TRANSACTION AGREGARCLIENTE;
            RETURN;
        END

        -- Realizar los cálculos
        SET @montoActual = @prestamo + (@prestamo * @porcentaje);
        SET @cantidadPago = @montoActual / @numeroQuinsenas;

        -- Insertar el cliente en la tabla
        INSERT INTO CLIENTES (nombreCliente, domicilio, prestamo, montoActual, numeroQuinsenas, cantidadPago, numeroPago, idDistribuidora, imagenIne,telefonoClientes)
        VALUES (UPPER(@nombreCliente), UPPER(@domicilio), @prestamo, @montoActual, @numeroQuinsenas, @cantidadPago, @numeroPago, @idDistribuidora, @imagenIne,@telefonoClientes);

        -- Actualizar el monto disponible de la distribuidora
        UPDATE DISTRIBUIDORAS
        SET disponible = disponible - @prestamo
        WHERE idDistribuidora = @idDistribuidora;

        -- Confirmar la transacción
        COMMIT TRANSACTION AGREGARCLIENTE;
        SET @message = 'Cliente guardado exitosamente';
    END TRY
    BEGIN CATCH
        -- Manejo de errores
        ROLLBACK TRANSACTION AGREGARCLIENTE;
        SET @message = 'Error al guardar, revisa los valores ingresados.';
    END CATCH
END;
GO

DELETE FROM CLIENTES
DELETE FROM DISTRIBUIDORAS


--------------------------------------------------------------------------------------------------------

CREATE TABLE PagosQuincenales (
    IdPago INT IDENTITY PRIMARY KEY,
    IdDistribuidora INT NOT NULL,
    Quincena DATETIME NOT NULL,
    TotalPagar DECIMAL(10, 2) NOT NULL,
    EstadoPago VARCHAR(50) DEFAULT 'Pendiente', -- Puede ser 'Pendiente', 'Pagado'
    FechaPago DATETIME NULL,
    FOREIGN KEY (IdDistribuidora) REFERENCES DISTRIBUIDORAS(idDistribuidora)
);
------------LA BUENOTA 
CREATE TABLE PagosQuincenales (
    IdPago INT IDENTITY PRIMARY KEY,
    IdDistribuidora INT NOT NULL,
    TotalPagar DECIMAL(10, 2) NOT NULL,
    MontoPagado DECIMAL(10, 2) DEFAULT 0,
    EstadoPago VARCHAR(50) DEFAULT 'Pendiente',
    FechaPago DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdDistribuidora) REFERENCES DISTRIBUIDORAS(idDistribuidora)
);
SELECT *FROM PagosQuincenales

ALTER TABLE PagosQuincenales
ADD PagoRealizado BIT DEFAULT 0 NOT NULL;
GO
------
ALTER PROCEDURE HACERCORTE
@message VARCHAR(100) OUTPUT
AS
BEGIN
    BEGIN TRANSACTION HACERCORTE;

    BEGIN TRY
        -- Eliminar los registros existentes en la tabla PagosQuincenales
        DELETE FROM PagosQuincenales;

        -- Lógica de corte existente
        UPDATE CLIENTES
        SET numeroPago = numeroPago + 1,
            montoActual = montoActual - cantidadPago;

        DELETE FROM CLIENTES
        WHERE numeroPago > numeroQuinsenas;

		 SET IMPLICIT_TRANSACTIONS OFF;
		BEGIN TRANSACTION HACERCORTE;

		BEGIN TRY
        -- Actualizar el monto disponible de cada distribuidora
        UPDATE DISTRIBUIDORAS
        SET disponible = disponible + (
            SELECT COALESCE(SUM((c.cantidadPago) * 0.8), 0)
            FROM CLIENTES c
            WHERE c.idDistribuidora = DISTRIBUIDORAS.idDistribuidora
        );

        -- Confirmar la transacción
        COMMIT TRANSACTION HACERCORTE;
        SET @message = 'Corte realizado exitosamente. Disponible actualizado.';
    END TRY
    BEGIN CATCH
        -- Manejo de errores
        ROLLBACK TRANSACTION HACERCORTE;
        SET @message = 'Error al realizar el corte.';
    END CATCH

        -- Insertar nuevos datos en la tabla PagosQuincenales
        INSERT INTO PagosQuincenales (IdDistribuidora, Quincena, TotalPagar)
        SELECT d.idDistribuidora, GETDATE(), SUM(c.cantidadPago)
        FROM DISTRIBUIDORAS d
        JOIN CLIENTES c ON d.idDistribuidora = c.idDistribuidora
        GROUP BY d.idDistribuidora;

        -- Confirmar la transacción
        COMMIT TRANSACTION HACERCORTE;
        SET @message = 'Corte realizado y pagos generados exitosamente.';
    END TRY
    BEGIN CATCH
        -- Revertir la transacción en caso de error
        ROLLBACK TRANSACTION HACERCORTE;
        SET @message = 'Error al realizar el corte.';
    END CATCH
END;
GO

select *from DISTRIBUIDORAS 

 UPDATE DISTRIBUIDORAS
        SET disponible = disponible + (
            SELECT COALESCE(SUM((c.cantidadPago) * 0.8), 0)
            FROM CLIENTES c
            WHERE c.idDistribuidora = DISTRIBUIDORAS.idDistribuidora
        );
-----------------------------------------------------------------------------------------------------------------------------------------
	CREATE TABLE listaNegra(
	 idLista INT IDENTITY(1,1),
	 nombreCliente VARCHAR(200),
	 domicilio VARCHAR(MAX),
	 FechaIngreso DATETIME DEFAULT GETDATE()

	CONSTRAINT PK_idLista PRIMARY KEY(idLista)
	);
----Agregar a lista negra 
GO
CREATE PROCEDURE AgregarListaNegra
	@nombreCliente VARCHAR(200),
	@domicilio VARCHAR(MAX), 
    @message VARCHAR(100) OUTPUT
AS
BEGIN
    SET IMPLICIT_TRANSACTIONS OFF;

    BEGIN TRANSACTION ;

	 IF (@nombreCliente IS NULL OR @domicilio IS NULL)
    BEGIN
        SET @message = 'Debes ingresar información completa del la para agregar a lista NEGRA';
        ROLLBACK TRANSACTION AgregarListaNegra;
    END
    ELSE
    BEGIN
	BEGIN TRY 
	INSERT INTO listaNegra (nombreCliente,domicilio)
	VALUES(UPPER(@nombreCliente),UPPER(@domicilio));

	COMMIT TRANSACTION AgregarListaNegra;
	SET @message = 'Cliente Agregado a Lista Negra'
	END TRY
	BEGIN CATCH
            ROLLBACK TRANSACTION AgregarListaNegra;
            SET @message = 'Error al Agregar a lista Negra';
        END CATCH
    END
END;
GO
--------------------------------------------------------
SELECT *FROM listaNegra
DECLARE @message VARCHAR(100);
exec AgregarListaNegra 'alfonso','la villa',@message OUTPUT
PRINT @message;
---------------------------------------------------------
GO
CREATE PROCEDURE ELIMINARlistaNegra
    @idClienteLista INT,
    @message VARCHAR(250) OUTPUT
AS
BEGIN
    SET IMPLICIT_TRANSACTIONS OFF

    BEGIN TRAN ELIMINARlistaNegra

    -- Verificar los parámetros de entrada
    IF (@idClienteLista IS NULL)
    BEGIN
        PRINT 'Debes ingresar el ID del cliente para eliminar de la lista'
        ROLLBACK TRANSACTION ELIMINARlistaNegra
        RETURN
    END

    BEGIN TRY
        -- Eliminar al cliente
        DELETE FROM listaNegra WHERE idLista = @idClienteLista;

        -- Confirmar los cambios
        COMMIT TRANSACTION ELIMINARlistaNegra
        SET @message = 'El cliente fue eliminado de la lista negra.'
    END TRY
    BEGIN CATCH
        -- Revertir los cambios en caso de error
        ROLLBACK TRANSACTION ELIMINARlistaNegra
        SET @message = 'Error al eliminar, revisa el ID ingresado.'
    END CATCH
END;
GO
----------------------------------------------------------------
DECLARE @message VARCHAR(250);
exec ELIMINARlistaNegra 1,@message OUTPUT
PRINT @message;

sELECT *FROM CLIENTES 

ALTER PROCEDURE filtrarPorDistribuidora
 @idDistribuidora INT
 AS
	BEGIN
	SELECT CLI.idCliente AS 'ID cliente',nombreCliente as 'Nombre Del Cliente', prestamo as 'Prestamo',numeroQuinsenas as 'Numero de quincenas',numeroPago as 'Numero de Pago', CLI.cantidadPago AS 'Pago Quincenal' , DIS.nombreDistribuidora as 'Distribiodora/o',
	 CLI.telefonoClientes as 'NUM Telefono', CLI.fechaVale as 'Fecha del vale' FROM  CLIENTES AS CLI
    INNER JOIN 
        DISTRIBUIDORAS AS DIS                                                           ----------Editar Esta Estructura con nmreo TELEFONO
    ON 
        CLI.idDistribuidora = DIS.idDistribuidora -- Ajuste aquí en el JOIN
	WHERE CLI.idDistribuidora = @idDistribuidora
	ORDER BY fechaVale DESC;
	END;

EXEC filtrarPorDistribuidora 13
-------------------------------------------------------------------------------------------------------------------------------------------
------------DE AQUI PA BAJO YA NO 
---------------------------------------------------------------------------------------------------------

