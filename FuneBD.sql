create database funerariaBD;
use funerariaBD;
CREATE TABLE `Movimientos` (
  `idMovimientos` INT NOT NULL AUTO_INCREMENT,
  `Fecha` DATE NOT NULL,
  `idContrato` INT NOT NULL,
  `Concepto` ENUM('Abono', 'PagoCuota') NOT NULL,
  `Abono` VARCHAR(45) NOT NULL,
  `idEmpleado` INT NOT NULL,
  PRIMARY KEY (`idMovimientos`));
  
CREATE TABLE  `Sucursales_Encargados` (
  `idSucursales/Encargados` INT NOT NULL,
  `idSucrusal` INT NOT NULL,
  `idEncargado` INT NOT NULL,
  PRIMARY KEY (`idSucursales/Encargados`));
  
  
CREATE TABLE IF NOT EXISTS `TipoDeContrato` (
  `idTipoDeContrato` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `Descripcion` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idTipoDeContrato`));
  
  
CREATE TABLE IF NOT EXISTS `beneficiarios` (
  `idbeneficiarios` INT NOT NULL AUTO_INCREMENT,
  `nombres` VARCHAR(45) NOT NULL,
  `apellidos` VARCHAR(45) NOT NULL,
  `dui` VARCHAR(45) NOT NULL,
  `direccion` VARCHAR(45) NOT NULL,
  `fechanacimiento` VARCHAR(45) NOT NULL,
  `telefono` VARCHAR(45) NOT NULL,
  `oficio` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idbeneficiarios`));
  
  CREATE TABLE IF NOT EXISTS `clientes` (
  `idclientes` INT NOT NULL AUTO_INCREMENT,
  `nombres` VARCHAR(45) NOT NULL,
  `apellidos` VARCHAR(45) NOT NULL,
  `dui` VARCHAR(45) NOT NULL,
  `direccion` VARCHAR(45) NOT NULL,
  `fechanacimiento` VARCHAR(45) NOT NULL,
  `telefono` VARCHAR(45) NOT NULL,
  `oficio` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idclientes`));
  
  
CREATE TABLE IF NOT EXISTS `contratos` (
  `idcontratos` INT NOT NULL AUTO_INCREMENT,
  `extendido` VARCHAR(45) NOT NULL,
  `contrato` VARCHAR(45) NULL,
  `idservicios` INT NOT NULL,
  `idformaspago` INT NOT NULL,
  `fecha` DATETIME NOT NULL,
  `vendedor` INT NOT NULL,
  `idclientes` INT NOT NULL,
  `Estado` INT NOT NULL,
  `Precio` INT NOT NULL,
  `Beneficiario1` INT NOT NULL,
  `Beneficiario2` INT NOT NULL,
  PRIMARY KEY (`idcontratos`));
  
  
  CREATE TABLE IF NOT EXISTS `difuntos` (
  `iddifuntos` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(45) NULL,
  `Contrato` INT NOT NULL,
  PRIMARY KEY (`iddifuntos`));
  
  
CREATE TABLE IF NOT EXISTS `empleados` (
  `idempleados` INT NOT NULL AUTO_INCREMENT,
  `nombres` VARCHAR(45) NOT NULL,
  `apellidos` VARCHAR(45) NOT NULL,
  `fechanacimiento` VARCHAR(45) NOT NULL,
  `telefono` VARCHAR(45) NOT NULL,
  `direccion` VARCHAR(45) NOT NULL,
  `idsucursales` INT NOT NULL,
  PRIMARY KEY (`idempleados`));
  
  
CREATE TABLE IF NOT EXISTS `roles` (
  `idroles` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `descripcion` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idroles`));
  
  
CREATE TABLE IF NOT EXISTS `servicios` (
  `idservicios` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `valorcontado` VARCHAR(45) NOT NULL,
  `valorcuota` VARCHAR(45) NOT NULL,
  `descripcion` VARCHAR(45) NOT NULL,
  `prima` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idservicios`));
  
  
CREATE TABLE IF NOT EXISTS `sucursales` (
  `idsucursales` INT NOT NULL AUTO_INCREMENT,
  `direccion` VARCHAR(45) NOT NULL,
  `telefono` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idsucursales`));
  
  
CREATE TABLE IF NOT EXISTS `usuarios` (
  `idusuarios` INT NOT NULL AUTO_INCREMENT,
  `usuario` VARCHAR(45) NOT NULL,
  `clave` VARCHAR(45) NOT NULL,
  `idroles` VARCHAR(45) NOT NULL,
  `idempleados` INT NOT NULL,
  PRIMARY KEY (`idusuarios`));
