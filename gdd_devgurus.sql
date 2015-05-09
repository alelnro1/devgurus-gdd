USE GD1C2015
GO
 
/***********************************************************************/
/*********************** CREACION DE TABLAS ****************************/
/***********************************************************************/
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Bancos')
    CREATE TABLE Bancos (
                Banco_Id NUMERIC(18,0) PRIMARY KEY NOT NULL,
                Banco_Nombre VARCHAR(255),
                Banco_Direccion VARCHAR(255)
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Login_Incorrecto')
    CREATE TABLE Login_Incorrecto (
                Login_Incorrecto_Id NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
                Login_Incorrecto_User VARCHAR(255),
                Login_Incorrecto_Pass VARCHAR (255),
                Login_Incorrecto_Intento NUMERIC(1,0),
                Login_Incorrecto_Fecha datetime
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Login_Auditoria')
    CREATE TABLE Login_Auditoria (
                Login_Auditoria_Id NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
                Login_Auditoria_Ingresado VARCHAR(255),
                Login_Auditoria_Fecha datetime,
                Login_Auditoria_Tipo VARCHAR(20)
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Tipo_De_Cuentas')
    CREATE TABLE Tipo_De_Cuentas (
                Tipo_De_Cuenta_Id NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
                Tipo_De_Cuenta_Nombre VARCHAR (255),
                Tipo_De_Cuenta_Duracion NUMERIC(18,0),
                Tipo_De_Cuenta_Costo NUMERIC (18,2)
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Tarjetas')
    CREATE TABLE Tarjetas (
                Tarjeta_Nro NUMERIC(18,0) PRIMARY KEY NOT NULL,
                Tarjeta_Fecha_Emision datetime,
                Tarjeta_Fecha_Vencimiento datetime,
                Tarjeta_Cod_Seg VARCHAR(3),
                Tarjeta_Emisor_Desc VARCHAR (255)
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Funciones')
    CREATE TABLE Funciones (
                Funcion_Id NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
                Funcion_Desc VARCHAR(255) NOT NULL
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Paises')
    CREATE TABLE Paises (
                Pais_Id NUMERIC(18,0) PRIMARY KEY NOT NULL,
                Pais_Nombre VARCHAR(255) NOT NULL
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Tipo_De_Doc')
    CREATE TABLE Tipo_De_Doc (
                Tipo_Doc_Id NUMERIC(18,0) PRIMARY KEY NOT NULL,
                Tipo_Doc_Desc VARCHAR(255) NOT NULL
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Roles')
    CREATE TABLE Roles (
                Rol_Id NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
                Rol_Desc VARCHAR(255),
                Rol_Estado VARCHAR (20) NOT NULL,
                Rol_Funcion NUMERIC(18,0) FOREIGN KEY REFERENCES Funciones(Funcion_Id) NOT NULL
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Usuarios')
    CREATE TABLE Usuarios (
                Usuario_Id NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
                Usuario_Name VARCHAR(255) UNIQUE NOT NULL,
                Usuario_Pass VARCHAR(255) NOT NULL,
                Usuario_Rol NUMERIC(18,0) FOREIGN KEY REFERENCES Roles(Rol_Id) NOT NULL,
                Usuario_FechaCreacion datetime NOT NULL,
                Usuario_FechaUltimaModificacion datetime NOT NULL,
                Usuario_PreguntaSecreta VARCHAR(255) NOT NULL,
                Usuario_RespuestaSecreta VARCHAR (255) NOT NULL
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Rol_X_Usuario')
    CREATE TABLE Rol_X_Usuario (
                Rol_X_Usuario_Usuario NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES Usuarios(Usuario_Id),
                Rol_X_Usuario_Rol NUMERIC(18,0)  NOT NULL FOREIGN KEY REFERENCES Roles(Rol_Id),
                CONSTRAINT Pk_Rol_X_Usuario PRIMARY KEY (Rol_X_Usuario_Usuario,Rol_X_Usuario_Rol)
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Clientes')
    CREATE TABLE Clientes (
                Cliente_Id NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
                Cliente_Nombre VARCHAR(255),
                Cliente_Apellido VARCHAR(255),
                Cliente_Estado VARCHAR(255),
                Cliente_Tipo_Doc NUMERIC(18,0) FOREIGN KEY REFERENCES Tipo_De_Doc(Tipo_Doc_Id),
                Cliente_Nro_Doc NUMERIC(18,0),
                Cliente_Pais NUMERIC(18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
                Cliente_Dom_Calle VARCHAR(255),
                Cliente_Dom_Nro NUMERIC (8,0),
                Cliente_Dom_Piso NUMERIC (3,0),
                Cliente_Dom_Depto VARCHAR(1),
                Cliente_Fecha_Nac datetime,
                Cliente_Mail VARCHAR(255),
                Cliente_User NUMERIC(18,0) FOREIGN KEY REFERENCES Usuarios(Usuario_Id) --UNIQUE
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Cuentas')
    CREATE TABLE Cuentas (
                Cuenta_Nro NUMERIC(18,0) PRIMARY KEY NOT NULL,
                Cuenta_Estado VARCHAR(255),
                Cuenta_Moneda VARCHAR(255) DEFAULT 'Dolar',
                Cuenta_Tipo NUMERIC(18,0) FOREIGN KEY REFERENCES Tipo_De_Cuentas(Tipo_De_Cuenta_Id),
                Cuenta_PaisOrigen NUMERIC(18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
                Cuenta_PaisAsignado NUMERIC(18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
                Cuenta_Fec_Cre datetime,
                Cuenta_Fec_Cierre datetime,
                Cuenta_Tarjeta NUMERIC(18,0) FOREIGN KEY REFERENCES Tarjetas(Tarjeta_Nro),
                Cuenta_Cliente NUMERIC(18,0) FOREIGN KEY REFERENCES Clientes(Cliente_Id)
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Depositos')
    CREATE TABLE Depositos (
                Deposito_Id NUMERIC(18,0) PRIMARY KEY NOT NULL,
                Deposito_Fecha datetime,
                Deposito_Importe NUMERIC (18,2) CHECK (Deposito_Importe >= 1),
                Deposito_TipoMoneda VARCHAR(255),
                Deposito_Cuenta NUMERIC(18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
                Deposito_Tarjeta NUMERIC(18,0) FOREIGN KEY REFERENCES Tarjetas(Tarjeta_Nro)
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Facturas')
    CREATE TABLE Facturas (
                Factura_Numero NUMERIC(18,0) PRIMARY KEY NOT NULL,
                Factura_Fecha datetime,
                Factura_Descripcion VARCHAR(255),
                Factura_Importe NUMERIC(18,0),
                Factura_Cliente NUMERIC(18,0) FOREIGN KEY REFERENCES Clientes(Cliente_Id)
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Transferencia')
    CREATE TABLE Transferencia (
                Transferencia_Id NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
                Transferencia_Fecha datetime,
                Transferencia_Importe NUMERIC (18,2),
                Transferencia_Costo_Transf NUMERIC (18,2),
                Transferencia_Cuenta_Emisora NUMERIC(18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
                Transferencia_Cuenta_Destino NUMERIC(18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
                Transferencia_Factura NUMERIC(18,0) FOREIGN KEY REFERENCES Facturas(Factura_Numero)
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Cheques')
    CREATE TABLE Cheques (
                Cheque_Id NUMERIC(18,0) PRIMARY KEY NOT NULL,
                Cheque_Fecha datetime,
                Cheque_Importe NUMERIC (18,2),
                Cheque_Banco NUMERIC(18,0) FOREIGN KEY REFERENCES Bancos(Banco_Id)
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Retiros')
    CREATE TABLE Retiros (
                Retiro_Id NUMERIC(18,0) PRIMARY KEY NOT NULL,
                Retiro_Fecha datetime,
                Retiro_Importe NUMERIC (18,2),
                Retiro_Cuenta NUMERIC(18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
                Retiro_Cheque NUMERIC(18,0) FOREIGN KEY REFERENCES Cheques(Cheque_Id)
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Transaccion_Pendiente')
    CREATE TABLE Transaccion_Pendiente (
                Transaccion_Pendiente_Id NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
                Transaccion_Pendiente_Importe NUMERIC (18,2),
                Transaccion_Pendiente_Descr VARCHAR(255),
                Transaccion_Pendiente_Cliente NUMERIC(18,0) FOREIGN KEY REFERENCES Clientes(Cliente_Id),
                Transaccion_Pendiente_Fecha datetime
    )
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Items')
    CREATE TABLE Items (
                Item_Id NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
                Item_Importe NUMERIC (18,2),
                Item_Descr VARCHAR(255),
                Item_Factura NUMERIC(18,0) FOREIGN KEY REFERENCES Facturas(Factura_Numero)
    )
GO
 
/* BORRAR TODAS LAS TABLAS
Drop Table Items
Drop Table Transaccion_Pendiente
Drop Table Retiros
Drop Table Cheques
Drop Table Transferencia
Drop Table Facturas
Drop Table Depositos
Drop Table Cuentas
Drop Table Clientes
Drop Table Rol_X_Usuario
Drop Table Usuarios
Drop Table Roles
Drop Table Tipo_De_Doc
Drop Table Paises
Drop Table Funciones
Drop Table Tarjetas
Drop Table Tipo_De_Cuentas
Drop Table Login_Auditoria
Drop Table Login_Incorrecto
Drop Table Bancos
*/
 
/************************************************
    *************************************************
    INSERT DE DATOS EN LAS TABLAS DESDE TABLA MAESTRA
    *************************************************
    *************************************************/
 
-- BANCOS
INSERT INTO Bancos (Banco_Id, Banco_Nombre, Banco_Direccion)
        SELECT DISTINCT Banco_Cogido, Banco_Nombre, Banco_Direccion FROM gd_esquema.Maestra WHERE Banco_Cogido IS NOT NULL
       
 
-- TIPO DE CUENTAS
INSERT INTO Tipo_De_Cuentas (Tipo_De_Cuenta_Nombre, Tipo_De_Cuenta_Duracion, Tipo_De_Cuenta_Costo)
        VALUES
                ('Oro', 45, 22.88),
                ('Plata', 30, 18.99),
                ('Bronce', 15, 12.49),
                ('Gratuita', 5, 0)
               
-- TARJETAS
INSERT INTO Tarjetas
        (
                Tarjeta_Nro, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, Tarjeta_Cod_Seg, Tarjeta_Emisor_Desc
        )
        SELECT DISTINCT
                Tarjeta_Numero, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento,
                Tarjeta_Codigo_Seg, Tarjeta_Emisor_Descripcion
                FROM gd_esquema.Maestra
                WHERE Tarjeta_Numero IS NOT NULL
 
-- FUNCIONES
INSERT INTO Funciones (Funcion_Desc) VALUES
   ('Logear'),
   ('Extraer'),
   ('Transferir'),
   ('Depositar'),
   ('Poseer tarjeta'),
   ('Eliminar cliente')
 
-- PAISES
INSERT INTO Paises (Pais_Id, Pais_Nombre) SELECT DISTINCT Cli_Pais_Codigo, Cli_Pais_Desc FROM gd_esquema.Maestra
 
-- TIPOS DE DOCUMENTO
INSERT INTO Tipo_De_Doc (Tipo_Doc_Id, Tipo_Doc_Desc) SELECT DISTINCT Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc FROM gd_esquema.Maestra
 
-- ROLES
INSERT INTO Roles (Rol_Desc, Rol_Estado) VALUES
   ('Administrador', 'Habilitado'),
   ('Cliente', 'Habilitado')
   
-- USUARIOS
   
-- FUNCIONES X ROL
/*INSERT INTO FuncionesXRol (Rol_Id,Funcion_Id) VALUES
   (1,1), (1,2), (1,3), (1,4), (1,5), (1,6),
   (2,1), (2,2), (2,3), (2,4)*/
 
 
-- CLIENTES
INSERT INTO Clientes
        (
                Cliente_Nombre, Cliente_Apellido, Cliente_Tipo_Doc, Cliente_Pais,
                Cliente_Dom_Calle, Cliente_Dom_Nro, Cliente_Dom_Piso, Cliente_Dom_Depto, Cliente_Fecha_Nac,
                Cliente_Mail
        )
        SELECT DISTINCT
                Cli_Nombre, Cli_Apellido, Cli_Tipo_Doc_Cod, Cli_Pais_Codigo, Cli_Dom_Calle,
                Cli_Dom_Nro, Cli_Dom_Piso, Cli_Dom_Depto, Cli_Fecha_Nac, Cli_Mail
                FROM gd_esquema.Maestra
               
/*INSERT INTO Clientes (Cliente_Tipo_Doc)
        SELECT Tipo_Doc_Id FROM Tipo_De_Doc WHERE Tipo_De_Doc.Tipo_Doc_Desc = gd_esquema.Maestra.Cli_Tipo_Doc_Desc
                                               
INSERT INTO Clientes (Cliente_Pais)
        SELECT Pais_Id FROM Paises WHERE Paises.Pais_Nombre = gd_esquema.Maestra.Cli_Pais_Desc*/
       
-- CUENTAS
INSERT INTO Cuentas
        (
                Cuenta_Nro, Cuenta_Estado, Cuenta_PaisOrigen, Cuenta_Fec_Cre,
                Cuenta_Fec_Cierre, Cuenta_Cliente, Cuenta_Tarjeta
        )
        SELECT DISTINCT
                Maestro.Cuenta_Numero, Maestro.Cuenta_Estado, Maestro.Cuenta_Pais_Codigo,
                Maestro.Cuenta_Fecha_Creacion, Maestro.Cuenta_Fecha_Cierre, Clientes.Cliente_Id, Maestro.Tarjeta_Numero
                FROM gd_esquema.Maestra Maestro, dbo.Clientes
                WHERE
                        Clientes.Cliente_Apellido = Maestro.Cli_Apellido AND
                        Clientes.Cliente_Nombre = Maestro.Cli_Nombre
                       
-- DEPOSITOS
 
INSERT INTO Depositos (Deposito_Id, Deposito_Fecha, Deposito_Importe, Deposito_Cuenta, Deposito_Tarjeta)
        SELECT *
                FROM gd_esquema.Maestra Maestro, dbo.Tarjetas, dbo.Cuentas
                WHERE
                        Maestro.Deposito_Codigo IS NOT NULL AND
                        Tarjetas.Tarjeta_Nro = Maestro.Tarjeta_Numero AND
                        Cuentas.Cuenta_Nro = Maestro.Cuenta_Numero
                        
                    