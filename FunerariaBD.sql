-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: funerariabd
-- ------------------------------------------------------
-- Server version	5.7.30-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `beneficiarios`
--

DROP TABLE IF EXISTS `beneficiarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `beneficiarios` (
  `idbeneficiarios` int(11) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(45) NOT NULL,
  `apellidos` varchar(45) NOT NULL,
  `dui` varchar(45) NOT NULL,
  `direccion` varchar(45) NOT NULL,
  `fechanacimiento` varchar(45) NOT NULL,
  `telefono` varchar(45) NOT NULL,
  `oficio` varchar(45) NOT NULL,
  PRIMARY KEY (`idbeneficiarios`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `beneficiarios`
--

LOCK TABLES `beneficiarios` WRITE;
/*!40000 ALTER TABLE `beneficiarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `beneficiarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `idclientes` int(11) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(45) NOT NULL,
  `apellidos` varchar(45) NOT NULL,
  `dui` varchar(45) NOT NULL,
  `direccion` varchar(45) NOT NULL,
  `fechanacimiento` varchar(45) NOT NULL,
  `telefono` varchar(45) NOT NULL,
  `oficio` varchar(45) NOT NULL,
  PRIMARY KEY (`idclientes`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contratos`
--

DROP TABLE IF EXISTS `contratos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contratos` (
  `idcontratos` int(11) NOT NULL AUTO_INCREMENT,
  `extendido` varchar(45) NOT NULL,
  `tipoDeContrato` int(11) NOT NULL,
  `idservicios` int(11) NOT NULL,
  `idformaspago` enum('Cuotas','Contado') NOT NULL,
  `fecha` datetime NOT NULL,
  `vendedor` int(11) NOT NULL,
  `idclientes` int(11) NOT NULL,
  `Estado` int(11) NOT NULL,
  `Precio` int(11) NOT NULL,
  `Beneficiario1` int(11) NOT NULL,
  `Beneficiario2` int(11) NOT NULL,
  PRIMARY KEY (`idcontratos`),
  KEY `fk_serv_idx` (`idservicios`),
  KEY `fk_vendedor_idx` (`vendedor`),
  KEY `fk_cliente_idx` (`idclientes`),
  KEY `fk_beneficiario1_idx` (`Beneficiario1`),
  KEY `fk_beneficiario2_idx` (`Beneficiario2`),
  KEY `fk_contrato_idx` (`tipoDeContrato`),
  CONSTRAINT `fk_beneficiario1` FOREIGN KEY (`Beneficiario1`) REFERENCES `beneficiarios` (`idbeneficiarios`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_beneficiario2` FOREIGN KEY (`Beneficiario2`) REFERENCES `beneficiarios` (`idbeneficiarios`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_cliente` FOREIGN KEY (`idclientes`) REFERENCES `clientes` (`idclientes`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_contrato` FOREIGN KEY (`tipoDeContrato`) REFERENCES `tipodecontrato` (`idTipoDeContrato`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_serv` FOREIGN KEY (`idservicios`) REFERENCES `servicios` (`idservicios`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_vendedor` FOREIGN KEY (`vendedor`) REFERENCES `empleados` (`idempleados`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contratos`
--

LOCK TABLES `contratos` WRITE;
/*!40000 ALTER TABLE `contratos` DISABLE KEYS */;
/*!40000 ALTER TABLE `contratos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `difuntos`
--

DROP TABLE IF EXISTS `difuntos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `difuntos` (
  `iddifuntos` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) DEFAULT NULL,
  `Contrato` int(11) NOT NULL,
  PRIMARY KEY (`iddifuntos`),
  KEY `fk_contra_idx` (`Contrato`),
  CONSTRAINT `fk_contra` FOREIGN KEY (`Contrato`) REFERENCES `servicios` (`idservicios`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `difuntos`
--

LOCK TABLES `difuntos` WRITE;
/*!40000 ALTER TABLE `difuntos` DISABLE KEYS */;
/*!40000 ALTER TABLE `difuntos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleados` (
  `idempleados` int(11) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(45) NOT NULL,
  `apellidos` varchar(45) NOT NULL,
  `fechanacimiento` varchar(45) NOT NULL,
  `telefono` varchar(45) NOT NULL,
  `direccion` varchar(45) NOT NULL,
  `idsucursales` int(11) NOT NULL,
  PRIMARY KEY (`idempleados`),
  KEY `fk_sucurs_idx` (`idsucursales`),
  CONSTRAINT `fk_sucurs` FOREIGN KEY (`idsucursales`) REFERENCES `sucursales` (`idsucursales`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'Carlhos Edgardo','Figueroa Tejada','28/10/199','76562543','La Hachadura, Ahuachapan',1),(2,'Jose ','Perez','3/7/1997','76564532','Sonsonate',1),(3,'Pedro','Aguilar','5/4/1998','76568954','Sonsonate',1);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimientos`
--

DROP TABLE IF EXISTS `movimientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimientos` (
  `idMovimientos` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` date NOT NULL,
  `idContrato` int(11) NOT NULL,
  `Concepto` enum('Abono','PagoCuota') NOT NULL,
  `Abono` varchar(45) NOT NULL,
  `idEmpleado` int(11) NOT NULL,
  PRIMARY KEY (`idMovimientos`),
  KEY `fk_movimiento_idx` (`idContrato`),
  KEY `fk_empleado_idx` (`idEmpleado`),
  KEY `fk_mov_idx` (`idContrato`),
  KEY `fk_cobrador_idx` (`idEmpleado`),
  CONSTRAINT `fk_cobrador` FOREIGN KEY (`idEmpleado`) REFERENCES `empleados` (`idempleados`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_mov` FOREIGN KEY (`idContrato`) REFERENCES `contratos` (`idcontratos`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimientos`
--

LOCK TABLES `movimientos` WRITE;
/*!40000 ALTER TABLE `movimientos` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimientos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `idroles` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(150) NOT NULL,
  PRIMARY KEY (`idroles`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrador','Usuario con acceso a todos los servicios y con el privilegio unico de gestionar otros usuarios'),(2,'Vendedor','Usuario destinado a la gestion de contratos en el sistema');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicios`
--

DROP TABLE IF EXISTS `servicios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `servicios` (
  `idservicios` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `valorcontado` varchar(45) NOT NULL,
  `valorcuota` varchar(45) NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  `prima` varchar(45) NOT NULL,
  PRIMARY KEY (`idservicios`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicios`
--

LOCK TABLES `servicios` WRITE;
/*!40000 ALTER TABLE `servicios` DISABLE KEYS */;
/*!40000 ALTER TABLE `servicios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sucursales`
--

DROP TABLE IF EXISTS `sucursales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sucursales` (
  `idsucursales` int(11) NOT NULL AUTO_INCREMENT,
  `direccion` varchar(150) NOT NULL,
  `telefono` varchar(45) NOT NULL,
  PRIMARY KEY (`idsucursales`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursales`
--

LOCK TABLES `sucursales` WRITE;
/*!40000 ALTER TABLE `sucursales` DISABLE KEYS */;
INSERT INTO `sucursales` VALUES (1,'Barrio Santa Cruz, Sexta calle poninte y cuarta avenida norte, Casa #12, Chalchuapa','24440565'),(14,' aaa ',' 11 ');
/*!40000 ALTER TABLE `sucursales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sucursales_encargados`
--

DROP TABLE IF EXISTS `sucursales_encargados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sucursales_encargados` (
  `idSucursales/Encargados` int(11) NOT NULL AUTO_INCREMENT,
  `idSucursal` int(11) NOT NULL,
  `idEncargado` int(11) NOT NULL,
  PRIMARY KEY (`idSucursales/Encargados`),
  KEY `fk_encargado_idx` (`idEncargado`),
  KEY `fk:suc_idx` (`idSucursal`),
  CONSTRAINT `fk_encargado` FOREIGN KEY (`idEncargado`) REFERENCES `empleados` (`idempleados`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_suc` FOREIGN KEY (`idSucursal`) REFERENCES `sucursales` (`idsucursales`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursales_encargados`
--

LOCK TABLES `sucursales_encargados` WRITE;
/*!40000 ALTER TABLE `sucursales_encargados` DISABLE KEYS */;
INSERT INTO `sucursales_encargados` VALUES (1,1,2),(13,14,3);
/*!40000 ALTER TABLE `sucursales_encargados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipodecontrato`
--

DROP TABLE IF EXISTS `tipodecontrato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipodecontrato` (
  `idTipoDeContrato` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `Descripcion` varchar(45) NOT NULL,
  PRIMARY KEY (`idTipoDeContrato`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipodecontrato`
--

LOCK TABLES `tipodecontrato` WRITE;
/*!40000 ALTER TABLE `tipodecontrato` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipodecontrato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `idusuarios` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(45) NOT NULL,
  `clave` varchar(45) NOT NULL,
  `idroles` int(11) NOT NULL,
  `idempleados` int(11) NOT NULL,
  PRIMARY KEY (`idusuarios`),
  UNIQUE KEY `idroles_UNIQUE` (`idroles`),
  KEY `fk_empleado_idx` (`idempleados`),
  CONSTRAINT `fk_empleado` FOREIGN KEY (`idempleados`) REFERENCES `empleados` (`idempleados`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_rol` FOREIGN KEY (`idroles`) REFERENCES `roles` (`idroles`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (2,'CARLHOSF','1234',1,1);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-10  9:22:22
