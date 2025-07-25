CREATE DATABASE BOMBEROSSPC
GO
USE BOMBEROSSPC
Go
--------------------------------------------------------------- Tablas ---------------------------------------------------------------
SELECT * FROM Casos
CREATE TABLE Usuario
( 
	idUsuario CHAR(8),
	nombre VARCHAR(100) NOT NULL,
	rol INT NOT NULL,
	contrasena VARCHAR(100) NOT NULL,
--- AGREGAR LAS RESTRICCIONES DE LA TABLA (CONSTRAINT)
	CONSTRAINT PK_Usuario PRIMARY KEY(idUsuario)
)
GO

CREATE TABLE Casos
(
	idCaso BIGINT IDENTITY(1,1),
	descripcionCaso VARCHAR(MAX),
	fechaCaso DATETIME,
	direccionCaso VARCHAR(MAX),
	tipoCaso VARCHAR (100),
	herramientas VARCHAR (MAX)
--- AGREGAR LAS RESTRICCIONES DE LA TABLA (CONSTRAINT)
	CONSTRAINT PK_Casos PRIMARY KEY(idCaso)
)
GO

CREATE TABLE Inventario
(
	idInventario INT IDENTITY(1,1),
	nombreInventario VARCHAR(100)
--- AGREGAR LAS RESTRICCIONES DE LA TABLA (CONSTRAINT)
	CONSTRAINT PK_Inventario PRIMARY KEY (idInventario)
)
GO

CREATE TABLE Estadisticas
(
	idEstadisticas CHAR(5),
	tipoEstadistica VARCHAR(80)NOT NULL,
	valor INT NOT NULL,
--- AGREGAR LAS RESTRICCIONES DE LA TABLA (CONSTRAINT)
	CONSTRAINT PK_Estadisticas PRIMARY KEY(idEstadisticas)
)
GO

CREATE TABLE Localidades(
	idLocalidades INT IDENTITY(1,1),
	CP CHAR (6),
	localidad VARCHAR (200)
	CONSTRAINT PK_Localidades PRIMARY KEY(idLocalidades)
 )
 GO

 CREATE TABLE Categorias(
	idCategoria INT PRIMARY KEY IDENTITY(1,1),
	nombreCategoria VARCHAR(50)
)
GO

--------------------------------------------------------------- Foreing Keys ---------------------------------------------------------------
ALTER TABLE Casos
	ADD idLocalidades INT
GO

ALTER TABLE Casos
	ADD CONSTRAINT FK_Casos_Localidades
	FOREIGN KEY (idLocalidades)
	REFERENCES Localidades(idLocalidades)
GO

ALTER TABLE Casos
	ADD idCategoria INT
GO

ALTER TABLE Casos
	ADD CONSTRAINT FK_Casos_Categorias
	FOREIGN KEY (idCategoria)
	REFERENCES Categorias(idCategoria)
GO

ALTER TABLE Categorias
	ADD idCaso BIGINT
GO

ALTER TABLE Categorias
	ADD CONSTRAINT FK_Categorias_Casos
	FOREIGN KEY (idCaso)
	REFERENCES Casos(idCaso)
GO

--------------------------------------------------------------- Insertar valores ---------------------------------------------------------------

INSERT INTO Usuario VALUES ('admin','Admin',1,'admin')
GO
----------

INSERT INTO Usuario VALUES ('usuario','Usuario',0,'admin')
GO

------
INSERT INTO Inventario VALUES 
	('Escalera'),
	('Manguera'),
	('Extintores'),
	('Cascos'),
	('Mascaras de Oxígeno'),
	('Traje contra incendios')
GO
-----------

INSERT INTO Localidades (CP, localidad) VALUES
('-----','Área fuera de San Pedro'),
('27800', 'Colonia San Pedro Centro'),
('27804', 'Barrio Barrio San Luis'),
('27804', 'Colonia Viviendas Populares'),
('27805', 'Colonia Barrio Nuevo'),
('27810', 'Fraccionamiento Cerrada San Fernando'),
('27810', 'Fraccionamiento Cerrada San Javier'),
('27810', 'Colonia El Ancora'),
('27810', 'Colonia Popular el Fénix'),
('27810', 'Colonia Ampliación el Fénix'),
('27810', 'Colonia Burócratas Municipales'),
('27810', 'Colonia Raúl Gámez Espinoza'),
('27810', 'Fraccionamiento Las Palmas'),
('27811', 'Unidad habitacional INFONAVIT'),
('27811', 'Colonia Eliseo Mendoza Berrueto'),
('27811', 'Colonia Los Nogales'),
('27812', 'Ejido Altamira'),
('27812', 'Fraccionamiento Altamira'),
('27813', 'Fraccionamiento Villas del América'),
('27813', 'Colonia Maura Gómez'),
('27813', 'Colonia La América'),
('27820', 'Colonia La Trinidad'),
('27822', 'Colonia Popular San Isidro'),
('27823', 'Colonia Junta Cívica Francisco I Madero'),
('27830', 'Colonia Lázaro Cárdenas'),
('27830', 'Barrio Monterrey'),
('27838', 'Colonia Ramos Arizpe'),
('27838', 'Colonia Luis Donaldo Colosio'),
('27839', 'Colonia Ampliación Lázaro Cárdenas'),
('27840', 'Colonia Proletaria Benito Juárez'),
('27840', 'Colonia Ejido el Ancora'),
('27845', 'Colonia El Chamizal'),
('27845', 'Colonia El Mirador'),
('27845', 'Colonia Agua Nueva'),
('27845', 'Colonia Diana Laura Rioja de Colosio'),
('27845', 'Colonia Ampliación Agua Nueva'),
('27845', 'Zona industrial Parque Industrial San Pedro'),
('27846', 'Colonia Aníbal Flores Neira'),
('27847', 'Fraccionamiento La Quinta'),
('27848', 'Colonia Villa Magisterial los Tulipanes'),
('27848', 'Colonia Del Valle'),
('27850', 'Colonia Las Rosas'),
('27850', 'Barrio Barrio Saltillo'),
('27850', 'Colonia El Fénix'),
('27850', 'Colonia Las Habas'),
('27850', 'Colonia Las Margaritas'),
('27850', 'Fraccionamiento Las Rosas Popular'),
('27850', 'Colonia El Triángulo'),
('27860', 'Colonia Miguel Hidalgo'),
('27860', 'Colonia Obrera Benito Juárez'),
('27863', 'Fraccionamiento Villas del Desierto'),
('27863', 'Fraccionamiento Las Misiones'),
('27870', 'Fraccionamiento Los Sauces'),
('27870', 'Colonia Francisco I Madero'),
('27870', 'Colonia Las Catarinas'),
('27880', 'Colonia Emiliano Zapata'),
('27880', 'Barrio Barrio de Guadalupe'),
('27880', 'Fraccionamiento Valparaíso'),
('27890', 'Colonia Francisco Villa'),
('27890', 'Fraccionamiento Las Américas'),
('27940', 'Pueblo Luchana'),
('27943', 'Ejido El Retiro'),
('27943', 'Ejido Aquiles Serdán'),
('27943', 'Ejido El Estribo'),
('27943', 'Ejido Ricardo Flores Magón'),
('27943', 'Ranchería El Cosaco'),
('27943', 'Ranchería El Ranchito'),
('27943', 'Ranchería La Palma'),
('27943', 'Ranchería Maravillas'),
('27943', 'Ejido Marte'),
('27943', 'Ranchería Mitla'),
('27943', 'Ranchería Pequeña Lote Cuatro Concordia'),
('27944', 'Ejido Alejo González (Bilbao)'),
('27944', 'Ejido La Fe'),
('27944', 'Ejido Veinte de Noviembre (Santa Lucía)'),
('27944', 'Ejido Diez de Mayo (Las Casitas)'),
('27944', 'Ejido Primero de Mayo (Algorta)'),
('27944', 'Ejido San Rafael de Arriba'),
('27944', 'Ejido Emiliano Zapata (Albia)'),
('27944', 'Ejido Diez de Mayo (El Chorizo)'),
('27944', 'Ejido Algorta'),
('27944', 'Ejido Diez de Mayo (El Grupo)'),
('27944', 'Ejido Diez de Mayo (Los Ramírez)'),
('27944', 'Ejido Fraba [Lácteos]'),
('27944', 'Ejido Grupo Número Tres (Ejido Alejo González)'),
('27944', 'Ranchería Las Carretas'),
('27944', 'Ranchería Noria Algorta Número 2'),
('27944', 'Ranchería Noria Algorta Número 3'),
('27944', 'Ejido La Esperanza'),
('27944', 'Ejido San Francisco de la Fe'),
('27944', 'Ranchería Luchana Dos'),
('27945', 'Ejido La Victoria'),
('27945', 'Ejido Sofía de Arriba'),
('27945', 'Ejido Nuevo Mundo'),
('27945', 'Ejido Santa Ana'),
('27945', 'Ejido Vega Larga'),
('27945', 'Ejido Cuauhtémoc Cárdenas (Medio Pulmón)'),
('27945', 'Ranchería La Fe'),
('27945', 'Ejido La Palma'),
('27945', 'Ranchería San Carlos de la Fe'),
('27945', 'Ejido Santa Ana'),
('27945', 'Ejido Santa Ana (Santa Ana de Arriba)'),
('27945', 'Ranchería Tres Estrellas'),
('27946', 'Ranchería Vigo (Bella Vista)'),
('27946', 'Ejido Gabino Vázquez (Begoña)'),
('27946', 'Ranchería Lagos de Moreno (Ampueros)'),
('27946', 'Colonia Félix Ramírez (Gavilanes)'),
('27946', 'Ranchería La Asunción (La Chona)'),
('27946', 'Ejido Purísima de Rubio'),
('27946', 'Ejido San Alberto'),
('27946', 'Ejido San Alberto la Herradura (Archandas)'),
('27946', 'Ejido San Ignacio'),
('27946', 'Ranchería Don José (El Recuerdo)'),
('27947', 'Ejido Purísima de Rubio'),
('27948', 'Ejido Lázaro Cárdenas (Dolores)'),
('27948', 'Ejido Santa Mónica'),
('27948', 'Colonia Estación Santa Teresa'),
('27948', 'Ejido Pequeña de Urquizo'),
('27948', 'Ranchería Beta Santa Mónica [Sociedad de Producción Rural]'),
('27948', 'Colonia Agrícola Aquiles Serdán Número Dos'),
('27948', 'Ejido El Gatuño'),
('27948', 'Ejido Emiliano Zapata (Las Jaulas)'),
('27948', 'Ranchería La Noria Número Uno (Lázaro Cárdenas)'),
('27948', 'Ranchería Guadalupe Ramírez'),
('27948', 'Ejido Noria Sector Tres A (Ejido Luchana)'),
('27948', 'Ranchería Parcela Uno de Aquiles Serdán'),
('27948', 'Ejido El Jacalón'),
('27948', 'Ranchería Presa de Guadalupe (Vida Nueva)'),
('27948', 'Ranchería Sociedad Bellavista (Ejido Luchana)'),
('27948', 'Ranchería El Chubasco'),
('27948', 'Ejido Vida Nueva (Las Palmas)'),
('27948', 'Ranchería Vida Nueva Uno'),
('27950', 'Ejido Urquizo'),
('27950', 'Ejido Concordia (La Rosita)'),
('27950', 'Ejido La Rosita'),
('27950', 'Ejido San Luis de Gurza'),
('27950', 'Ejido Doroteo Arango'),
('27953', 'Ejido San Isidro'),
('27953', 'Ejido Bolívar'),
('27953', 'Ejido La Carolina (La Nueva Carolina)'),
('27953', 'Ejido San Antonio de Gurza'),
('27953', 'Ejido San Francisco de Gurza (Santa Rosa)'),
('27953', 'Ejido Carolina del Norte'),
('27953', 'Ejido Carolinas'),
('27953', 'Ejido Charco Verde'),
('27953', 'Ranchería El Destino de Abajo de San Isidro'),
('27953', 'Ejido El Triángulo (Vicente Vázquez Ontiveros)'),
('27953', 'Ejido Flores Magón'),
('27953', 'Ranchería Héctor Chapa'),
('27953', 'Ejido Miguel del Hoyo'),
('27953', 'Ranchería La Estrella y la Barca'),
('27953', 'Ranchería Noria Doroteo Arango'),
('27953', 'Ejido El Cristo'),
('27953', 'Ranchería Rafael Padilla Medina (El Olmo)'),
('27953', 'Ejido San Antonio de Gurza'),
('27953', 'Ranchería San Carlos (Las Margaritas)'),
('27953', 'Ranchería San Isidro (El Jacalón)'),
('27953', 'Ranchería Santa Rita'),
('27954', 'Ejido Tacubaya'),
('27954', 'Ranchería Buenavista'),
('27954', 'Ejido Candelaria'),
('27954', 'Ejido San Esteban de Abajo'),
('27954', 'Ejido Santa Elena'),
('27954', 'Ejido El Triángulo'),
('27954', 'Ejido Tacuba'),
('27954', 'Ejido San Pedro (José Ruiz Velázquez)'),
('27954', 'Ranchería Doña Blanca'),
('27954', 'Ejido La Fe'),
('27954', 'Ranchería La Pentalfa'),
('27954', 'Ejido Nueva Candelaria'),
('27954', 'Ejido Panamá'),
('27954', 'Ejido San Agustín'),
('27954', 'Ranchería Santa Alicia'),
('27954', 'Ejido Tacuba'),
('27955', 'Ejido Santa Sofía (Sofía de Abajo)'),
('27955', 'Ejido San Felipe (San Felipe de Purcell)'),
('27955', 'Ejido San Marcos'),
('27955', 'Ejido San Rafael de Abajo'),
('27955', 'Ejido Ignacio Zaragoza'),
('27955', 'Ranchería Las Mercedes [Agrícola]'),
('27955', 'Ranchería Nuevo San Juan Bautista'),
('27955', 'Ejido San Patricio'),
('27955', 'Ranchería San Salvador (El Despepite)'),
('27956', 'Ejido Alejandría'),
('27956', 'Ejido Santiago'),
('27956', 'Ranchería Tacubaya Uno (San José de los Álamos)'),
('27957', 'Rancho Manuel Samaniego Aguilar'),
('27957', 'Ejido San Francisco de Arriba'),
('27957', 'Ejido San Lorenzo'),
('27957', 'Ejido Santa Eulalia'),
('27957', 'Ejido Progreso'),
('27957', 'Ejido El Retiro Viejo'),
('27957', 'Ranchería La Noria de Progreso'),
('27957', 'Ranchería Los Arenales (Félix Fernández)'),
('27958', 'Ejido El Venado')
GO
----------

INSERT INTO Categorias (nombreCategoria) VALUES 
			('Accidentes'),
            ('Capacitaciones'),
            ('Cables colgados, reventados o enredados'),
            ('Enjambres'),
            ('Fuga de gas'),
            ('Incendios'),
            ('Poda de árboles'),
            ('Rondines de rin de semana'),
            ('Simulacros'),
            ('Traslados de agua'),
            ('Traslados (Ambulancia)'),
            ('Vehículos incendiados'),
            ('Verificación de negocios')
GO

--------------------------------------------------------------- Vistas ---------------------------------------------------------------

CREATE VIEW vwMostrarUsuarios
AS
	SELECT idUsuario AS 'Clave', nombre AS 'Nombre del usuario', 
	CASE
        WHEN rol = 1 THEN 'Administrador'
        WHEN rol = 0 THEN 'Secretario'
		ELSE 'Desconocido'
	END AS 'Rol administrativo'
	FROM Usuario WITH (NOLOCK)
GO

CREATE VIEW vwMostrarCasos
AS
    SELECT TOP 100 
        c.tipoCaso AS 'Caso', c.descripcionCaso AS 'Descripción', c.herramientas AS 'Herramientas', l.CP AS 'CP',  l.localidad AS 'Colonia/Ejido', 
        c.direccionCaso AS 'Dirección', c.fechaCaso AS 'Fecha'
    FROM Casos c WITH(NOLOCK)
    INNER JOIN  Localidades l ON c.idLocalidades = l.idLocalidades
GO

CREATE VIEW vwMostrarCasos2
AS
    SELECT
        c.tipoCaso AS 'Caso', c.descripcionCaso AS 'Descripción', c.herramientas AS 'Herramientas', l.CP AS 'CP',  l.localidad AS 'Colonia/Ejido', 
        c.direccionCaso AS 'Dirección', c.fechaCaso AS 'Fecha'
    FROM Casos c WITH(NOLOCK)
    INNER JOIN  Localidades l ON c.idLocalidades = l.idLocalidades
GO

CREATE VIEW vwModificarCaso
AS
	SELECT TOP 100
		c.idCaso AS 'Clave caso',c.tipoCaso AS 'Caso', c.descripcionCaso 'Descripción', c.herramientas AS 'Herramientas', l.CP 'CP', 
		l.localidad AS 'Colonia/Ejido', c.direccionCaso 'Dirección', c.fechaCaso 'Fecha'
	FROM Casos AS c WITH (NOLOCK)
	INNER JOIN Localidades AS l ON c.idLocalidades = l.idLocalidades
GO

CREATE VIEW vwLocalidades AS
	SELECT CP AS 'CP', localidad AS 'Localidad'
	FROM Localidades WITH (NOLOCK)
GO

CREATE VIEW vwHerramientas AS
	SELECT idInventario AS 'Clave', nombreInventario AS 'Herramientas registradas'
	FROM Inventario WITH (NOLOCK)
GO

CREATE VIEW  vwCategorias 
AS
	SELECT	idCategoria AS 'Clave Categoria', nombreCategoria AS 'Categoria'  FROM Categorias WITH(NOLOCK)
GO

Create VIEW vwContarAccidentesPorTipo2 AS
	SELECT tipoCaso AS 'Tipo de Casos',  COUNT(*) AS 'Total de Casos'
	FROM Casos WITH(NOLOCK)
    GROUP BY tipoCaso
GO

--------------------------------------------------------- Procedimientos almacenados ---------------------------------------------------------

CREATE PROCEDURE spEliminarUsuario
    @idUsuarioEliminar CHAR(8)
AS
BEGIN
    IF @idUsuarioEliminar = 'admin'
    BEGIN
        PRINT 'No se puede eliminar el usuario "admin".';
        RETURN;
    END

    BEGIN TRY
        -- Eliminar el usuario especificado
        DELETE FROM Usuario WHERE idUsuario = @idUsuarioEliminar;

        PRINT 'Usuario eliminado correctamente.';
    END TRY
    BEGIN CATCH
        -- Manejar cualquier error que ocurra durante la eliminación
        PRINT 'Error al intentar eliminar el usuario.';
        THROW;
    END CATCH
END
GO
-------------------------------------------------

CREATE PROCEDURE spInsertarUsuario
    @Nombre VARCHAR(100),
    @Rol BIT,
    @Contrasena VARCHAR(100)
AS
BEGIN
    DECLARE @Fecha CHAR(2)
    DECLARE @InicialNombre CHAR(2)
    DECLARE @Secuencia INT
    DECLARE @idUsuario CHAR(8)

    -- Obtener los dos últimos dígitos del año actual
    SET @Fecha = RIGHT(YEAR(GETDATE()), 2)

    -- Obtener las dos primeras letras del nombre y convertirlas a mayúsculas
    SET @InicialNombre = UPPER(LEFT(@Nombre, 2))

    -- Obtener la próxima secuencia numérica
    SELECT @Secuencia = ISNULL(MAX(CONVERT(INT, RIGHT(idUsuario, 3))), 0) + 1
    FROM Usuario
    WHERE LEFT(idUsuario, 4) = CONCAT(@Fecha, @InicialNombre)

    -- Formar el idUsuario
    SET @idUsuario = CONCAT(@Fecha, @InicialNombre, RIGHT('00' + CAST(@Secuencia AS VARCHAR(3)), 3))

    -- Insertar el nuevo usuario
    INSERT INTO Usuario (idUsuario, nombre, rol, contrasena)
    VALUES (@idUsuario, @Nombre, @Rol, @Contrasena)
END
GO
-------------------------------------------------

CREATE PROCEDURE spModificarUsuario
    @idUsuario CHAR(8),
    @NuevoNombre VARCHAR(100),
    @NuevoRol VARCHAR(50),
    @NuevaContrasena VARCHAR(100)
AS
BEGIN
    -- Verificar si el usuario existe
    IF NOT EXISTS (SELECT 1 FROM Usuario WHERE idUsuario = @idUsuario)
    BEGIN
        PRINT 'El usuario especificado no existe.';
        RETURN;
    END

    -- Modificar los datos del usuario
    BEGIN TRY
        UPDATE Usuario
        SET nombre = @NuevoNombre,
            rol = @NuevoRol,
            contrasena = @NuevaContrasena
        WHERE idUsuario = @idUsuario;

        PRINT 'Usuario modificado correctamente.';
    END TRY
    BEGIN CATCH
        -- Manejar cualquier error que ocurra durante la modificación
        PRINT 'Error al intentar modificar el usuario.';
        THROW;
    END CATCH
END
GO
-------------------------------------------------

CREATE PROCEDURE spInsertarCaso
(
    @descripcionCaso VARCHAR(MAX),
    @direccionCaso VARCHAR(MAX),
    @tipoCaso VARCHAR(100),
    @herramientas VARCHAR(MAX),
    @idLocalidades INT
)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @fechaCaso DATETIME = GETDATE();
    
    INSERT INTO Casos (descripcionCaso, fechaCaso, direccionCaso, tipoCaso, herramientas, idLocalidades)
    VALUES (@descripcionCaso, @fechaCaso, @direccionCaso, @tipoCaso, @herramientas, @idLocalidades);
END
GO
SELECT * FROM Casos
-------------------------------------------------

CREATE PROCEDURE spObtenerIdLocalidad
(
    @nombreLocalidad VARCHAR(200),
    @CP CHAR(6),
    @idLocalidad INT OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT @idLocalidad = idLocalidades
    FROM Localidades WITH (NOLOCK)
    WHERE localidad = @nombreLocalidad AND CP = @CP
END
GO
-------------------------------------------------

CREATE PROCEDURE spModificarCaso
(
    @idCaso BIGINT,
    @descripcionCaso VARCHAR(MAX),
    @direccionCaso VARCHAR(MAX),
    @tipoCaso VARCHAR(100),
    @herramientas VARCHAR(MAX),
    @idLocalidades INT
)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Casos
    SET descripcionCaso = @descripcionCaso,
        direccionCaso = @direccionCaso,
        tipoCaso = @tipoCaso,
        herramientas = @herramientas,
        idLocalidades = @idLocalidades
    WHERE idCaso = @idCaso;
END
GO
-------------------------------------------------

CREATE PROCEDURE spAgregarHerramienta
    @nombreInventario VARCHAR(100)
AS
BEGIN
    -- Inserta una nueva herramienta en la tabla Inventario
    INSERT INTO Inventario (nombreInventario)
    VALUES (@nombreInventario);
END
GO
-------------------------------------------------

CREATE PROCEDURE spModificarHerramienta
    @idInventario INT,
    @nombreInventario VARCHAR(100)
AS
BEGIN
    UPDATE Inventario
    SET nombreInventario = @nombreInventario
    WHERE idInventario = @idInventario;
END
GO
-------------------------------------------------

CREATE PROCEDURE spEliminarHerramienta
    @idInventario INT
AS
BEGIN
    DELETE FROM Inventario
    WHERE idInventario = @idInventario;
END
GO
-------------------------------------------------

CREATE PROCEDURE spObtenerNombreUsuario
    @idUsuario CHAR(8)
AS
BEGIN
    SELECT nombre
    FROM Usuario
    WHERE idUsuario = @idUsuario
END
GO
-------------------------------------------------

CREATE PROCEDURE ContarAccidentesPorTipo2
AS
BEGIN
    SELECT tipoCaso, COUNT(*) AS TotalAccidentes
    FROM Casos
    GROUP BY tipoCaso;
END
GO

EXEC ContarAccidentesPorTipo2
-------------------------------------------------

CREATE PROCEDURE ContarAccidentesPorTipoFECHAsemana
AS
BEGIN
    SELECT tipoCaso, COUNT(*) AS TotalAccidentes
    FROM Casos
    WHERE CONVERT(DATE, fechaCaso) >= CONVERT(DATE,DATEADD(WEEK, -1, GETDATE()))
    GROUP BY tipoCaso
END
GO
-------------------------------------------------

EXEC ContarAccidentesPorTipoFECHAsemana
Select *from Casos
GO
-------------------------------------------------

CREATE PROCEDURE ContarAccidentesPorTipoFECHAmes
AS
BEGIN
    SELECT tipoCaso, COUNT(*) AS TotalAccidentes
    FROM Casos
    WHERE CONVERT(DATE, fechaCaso) >= CONVERT(DATE,DATEADD(MONTH, -1, GETDATE()))
    GROUP BY tipoCaso;
END
GO

EXEC ContarAccidentesPorTipoFECHAsemana
-------------------------------------------------

GO
CREATE PROCEDURE ContarAccidentesPorTipoFECHAano
AS
BEGIN
    SELECT tipoCaso, COUNT(*) AS TotalAccidentes
    FROM Casos
    WHERE CONVERT(DATE, fechaCaso) >= CONVERT(DATE,DATEADD(YEAR, -1, GETDATE()))
    GROUP BY tipoCaso;
END
GO

-------------------------------------------------

CREATE PROCEDURE ObtenerDatosPorFecha123
    @FechaSeleccionada DATETIME
AS
BEGIN
    SELECT tipoCaso, COUNT(*) AS TotalAccidentes
    FROM Casos
    WHERE CONVERT(DATE, fechaCaso) = CONVERT(DATE, @FechaSeleccionada)
    GROUP BY tipoCaso;
END
GO

-----------------------------------------------------------------------------------
-- Procedimiento para obtener todos los casos
CREATE PROCEDURE spObtenerCasos
AS
BEGIN
    SELECT * FROM vwMostrarCasos2
END
GO

-- Procedimiento para obtener casos por fecha
CREATE PROCEDURE spObtenerCasosPorFecha
    @FechaSeleccionada DATE
AS
BEGIN
    SELECT * FROM vwMostrarCasos2 WHERE CONVERT(date, Fecha) = @FechaSeleccionada
END
GO

-- Procedimiento para obtener casos por fecha y tipo
CREATE PROCEDURE spObtenerCasosPorFechaYTipo
    @FechaSeleccionada DATE,
    @TipoCaso NVARCHAR(50)
AS
BEGIN
    SELECT * FROM vwMostrarCasos2 WHERE CONVERT(date, Fecha) = @FechaSeleccionada AND Caso = @TipoCaso
END
GO

-- Procedimiento para obtener casos por tipo
CREATE PROCEDURE spObtenerCasosPorTipo
    @TipoCaso NVARCHAR(50)
AS
BEGIN
    SELECT * FROM vwMostrarCasos2 WHERE Caso = @TipoCaso
END
GO

-- Procedimiento para obtener casos por localidad
CREATE PROCEDURE spObtenerCasosPorLocalidad
    @Localidad NVARCHAR(50)
AS
BEGIN
    SELECT * FROM vwMostrarCasos2 WHERE [Colonia/Ejido] = @Localidad
END
GO

-- Procedimiento para obtener casos por fecha y localidad
CREATE PROCEDURE spObtenerCasosPorFechaLocalidad
    @FechaSeleccionada DATE,
    @Localidad NVARCHAR(50)
AS
BEGIN
    SELECT * FROM vwMostrarCasos2 WHERE CONVERT(date, Fecha) = @FechaSeleccionada AND[Colonia/Ejido] = @Localidad
END
GO

-- Procedimiento para obtener casos por tipo y localidad
CREATE PROCEDURE spObtenerCasosPorTipoLocalidad
    @TipoCaso NVARCHAR(50),
    @Localidad NVARCHAR(50)
AS
BEGIN
    SELECT * FROM vwMostrarCasos2 WHERE Caso = @TipoCaso AND [Colonia/Ejido] = @Localidad
END
GO

-- Procedimiento para obtener casos por tipo, fecha y localidad
CREATE PROCEDURE spObtenerCasosPorTipoFechaLocalidad
    @TipoCaso NVARCHAR(50),
    @FechaSeleccionada DATE,
    @Localidad NVARCHAR(50)
AS
BEGIN
    SELECT * FROM vwMostrarCasos2 WHERE CONVERT(date, Fecha) = @FechaSeleccionada AND [Colonia/Ejido] = @Localidad AND Caso = @TipoCaso
END
GO