-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: funerariabd
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1,' Antonio ',' Lara ',' 123456-8-9 ',' San Antonio,Sonsonate ',' 14/5/1997 ',' 77634311 ',' Asaltante de la 53-E '),(2,' Fernando ',' Escobar ',' 34567812-9 ',' La Hachadura ',' 2/6/1989 ',' 77559023 ',' Politico Corrupto ');
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
  `DUI` varchar(15) DEFAULT NULL,
  `idsucursales` int(11) NOT NULL,
  `FechaContratacion` varchar(45) NOT NULL,
  `puesto` int(11) NOT NULL,
  PRIMARY KEY (`idempleados`),
  UNIQUE KEY `idempleados_UNIQUE` (`idempleados`),
  KEY `fk_sucurs_idx` (`idsucursales`),
  CONSTRAINT `fk_sucurs` FOREIGN KEY (`idsucursales`) REFERENCES `sucursales` (`idsucursales`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (9,'  Carlhos  ','  Figueroa  ',' 28/10/1999 ','  75254523  ','  La Hachadura, Ahuachapan  ','  123456789-1  ',3,' 22/2/2021 ',4),(10,'  Jose   ',' Lopez ',' 12/3/1995 ','  75467834  ','  Chalchuapa  ','  231456798-3  ',1,' 12/4/2011 ',1),(15,'  Pedro  ','  Infante  ',' 6/5/1996 ','  457696677  ','  La Hachadura  ','  24567990-0  ',3,' 6/5/2021 ',1),(16,' Jose ',' Cañas ',' 6/5/1999 ',' 75678934 ',' La Hachadura ',' 235678-7 ',3,' 6/5/2021 ',2);
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
-- Table structure for table `puestos`
--

DROP TABLE IF EXISTS `puestos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `puestos` (
  `idpuestos` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(150) NOT NULL,
  PRIMARY KEY (`idpuestos`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `puestos`
--

LOCK TABLES `puestos` WRITE;
/*!40000 ALTER TABLE `puestos` DISABLE KEYS */;
INSERT INTO `puestos` VALUES (1,' Gerente ','  Es el encargado de gestionar todas las transacciones y opereaciones de una sucursal'),(2,' Encargado de Grupo ','  Encargado de liderar grupos de operaciones que dan cumplimiento a los contratos'),(3,'Trabajador corriente','Perteneciente a los grupos de trabajo de los supervisores y a la orden de estos para cumplir contratos y servicios.'),(4,'Tecnico de Sistema','Encargado de dar soporte y mantenimiento al sistema de la empresa');
/*!40000 ALTER TABLE `puestos` ENABLE KEYS */;
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
  `valorcontado` decimal(9,2) NOT NULL,
  `valorcuota` decimal(9,2) NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  `prima` decimal(9,2) NOT NULL,
  PRIMARY KEY (`idservicios`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicios`
--

LOCK TABLES `servicios` WRITE;
/*!40000 ALTER TABLE `servicios` DISABLE KEYS */;
INSERT INTO `servicios` VALUES (1,' Servicio de Prueba ',350.00,400.00,' Descripcion de prueba para testeo ',5.00);
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursales`
--

LOCK TABLES `sucursales` WRITE;
/*!40000 ALTER TABLE `sucursales` DISABLE KEYS */;
INSERT INTO `sucursales` VALUES (1,'Barrio Santa Cruz, Sexta calle poninte y cuarta avenida norte, Casa #12, Chalchuapa','24440565'),(3,' La Hachadura ',' 24356745 ');
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
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursales_encargados`
--

LOCK TABLES `sucursales_encargados` WRITE;
/*!40000 ALTER TABLE `sucursales_encargados` DISABLE KEYS */;
INSERT INTO `sucursales_encargados` VALUES (18,1,10),(19,3,15);
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
  `factor` decimal(9,5) NOT NULL,
  PRIMARY KEY (`idTipoDeContrato`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipodecontrato`
--

LOCK TABLES `tipodecontrato` WRITE;
/*!40000 ALTER TABLE `tipodecontrato` DISABLE KEYS */;
INSERT INTO `tipodecontrato` VALUES (2,'Contrato individual Comun','d',1.00000);
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
  `rol` enum(' Administrador',' Gerente',' Vendedor') NOT NULL,
  `idempleados` int(11) NOT NULL,
  PRIMARY KEY (`idusuarios`),
  KEY `fk_empleado_idx` (`idempleados`),
  CONSTRAINT `fk_empleado` FOREIGN KEY (`idempleados`) REFERENCES `empleados` (`idempleados`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (8,'CARLHOSF','1234',' Administrador',9);
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

-- Dump completed on 2021-05-14  9:31:14
