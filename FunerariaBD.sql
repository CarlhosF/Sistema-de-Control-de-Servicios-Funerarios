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
  `fechanacimiento` date NOT NULL,
  `telefono` varchar(45) NOT NULL,
  `oficio` varchar(45) NOT NULL,
  PRIMARY KEY (`idclientes`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (5,' AAAAAA ',' BBBBBB ',' 44444 ',' CCCCCC ','1989-06-06',' 6666666 ',' DDDDDD '),(6,' Prueba ',' Prueba ',' 555555 ',' aaaaaa ','1997-05-19',' 66666 ',' bbbbb '),(9,' Pedro Antonio ',' Lara ',' 1245677-6 ',' Sonsacate ','1998-04-03',' 76459878 ',' Mesero, en el Pizza Hut '),(10,' Carlos Alfredo  ',' Perez ',' 1244567-6 ',' San Antonio, Sonsonate ','1997-03-07',' 76894523 ',' Chofer de Autobus '),(11,' Alberto ',' Guerra ',' 1222367-6 ',' Sensunapan,Sonsonate ','1991-11-17',' 67561242 ',' Cobrador de la 259 '),(12,' Jose Carlos ',' Aguilar ',' 333333333 ',' ffffffffffff ','1980-05-20',' 33333333 ',' Ass breaker ');
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
  `extendido` varchar(100) NOT NULL,
  `tipoDeContrato` int(11) NOT NULL,
  `idservicios` int(11) NOT NULL,
  `formaspago` enum('Cuotas','Contado') NOT NULL,
  `fecha` datetime NOT NULL,
  `vendedor` int(11) DEFAULT NULL,
  `contratista` int(11) DEFAULT NULL,
  `Estado` enum('Activo','Cancelado','Entregado','Nulo','Moroso') NOT NULL,
  `Monto` decimal(8,2) NOT NULL,
  `Beneficiario1` int(11) DEFAULT NULL,
  `Beneficiario2` int(11) DEFAULT NULL,
  `observaciones` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idcontratos`),
  KEY `fk_serv_idx` (`idservicios`),
  KEY `fk_contrato_idx` (`tipoDeContrato`),
  KEY `fk_vendedor_idx` (`vendedor`),
  KEY `fk_contratista_idx` (`contratista`),
  KEY `fk_beneficiario_idx` (`Beneficiario1`),
  KEY `fk_beneficiario2_idx` (`Beneficiario2`),
  CONSTRAINT `fk_beneficiario1` FOREIGN KEY (`Beneficiario1`) REFERENCES `clientes` (`idclientes`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_beneficiario2` FOREIGN KEY (`Beneficiario2`) REFERENCES `clientes` (`idclientes`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_contratista` FOREIGN KEY (`contratista`) REFERENCES `clientes` (`idclientes`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_contrato` FOREIGN KEY (`tipoDeContrato`) REFERENCES `tipodecontrato` (`idTipoDeContrato`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_serv` FOREIGN KEY (`idservicios`) REFERENCES `servicios` (`idservicios`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_vendedor` FOREIGN KEY (`vendedor`) REFERENCES `usuarios` (`idusuarios`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contratos`
--

LOCK TABLES `contratos` WRITE;
/*!40000 ALTER TABLE `contratos` DISABLE KEYS */;
INSERT INTO `contratos` VALUES (10,'aaaa',3,1,'Contado','2021-05-19 00:00:00',13,6,'Activo',262.50,6,5,'ssssss'),(11,'La Hachadura',2,1,'Cuotas','2021-05-20 00:00:00',13,11,'Activo',400.00,10,9,'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa'),(12,'bbbbbbbbbbbbbb',4,1,'Cuotas','2021-05-20 00:00:00',13,10,'Activo',1200.00,11,5,'sssssssssssssssssss'),(13,'sssssss',4,1,'Cuotas','2021-05-20 00:00:00',13,9,'Cancelado',1200.00,11,5,NULL),(14,'fffffffff',4,1,'Cuotas','2021-05-19 00:00:00',13,11,'Moroso',1200.00,9,5,NULL),(15,'gggggggg',4,1,'Cuotas','2021-05-20 00:00:00',14,12,'Activo',1200.00,6,5,'ddddddddd'),(16,'sssss',3,1,'Cuotas','2021-05-20 00:00:00',14,6,'Activo',300.00,10,9,'zzzz'),(17,'aaaa',5,1,'Contado','2021-05-21 00:00:00',14,11,'Cancelado',896.00,12,11,'sssss');
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
  `Nombre` varchar(45) NOT NULL,
  `Apellidos` varchar(45) NOT NULL,
  `Direcciondetoma` varchar(45) NOT NULL,
  `Direcciondeentrega` varchar(45) NOT NULL,
  `CausadeMuerte` varchar(45) NOT NULL,
  `FechadeMuerte` varchar(45) NOT NULL,
  `FechadeNacimiento` varchar(45) NOT NULL,
  `Contrato` int(11) NOT NULL,
  PRIMARY KEY (`iddifuntos`),
  KEY `fk_contr_idx` (`Contrato`),
  CONSTRAINT `fk_contr` FOREIGN KEY (`Contrato`) REFERENCES `contratos` (`idcontratos`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `difuntos`
--

LOCK TABLES `difuntos` WRITE;
/*!40000 ALTER TABLE `difuntos` DISABLE KEYS */;
INSERT INTO `difuntos` VALUES (4,' AAAA  ',' CCC ',' ACCCCCAAA ','CC','CCCC','2021/05/21','1989/03/02',13);
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
  `fechanacimiento` date NOT NULL,
  `telefono` varchar(45) NOT NULL,
  `direccion` varchar(45) NOT NULL,
  `DUI` varchar(15) DEFAULT NULL,
  `idsucursales` int(11) NOT NULL,
  `FechaContratacion` date NOT NULL,
  `puesto` int(11) NOT NULL,
  PRIMARY KEY (`idempleados`),
  UNIQUE KEY `idempleados_UNIQUE` (`idempleados`),
  KEY `fk_sucurs_idx` (`idsucursales`),
  CONSTRAINT `fk_sucurs` FOREIGN KEY (`idsucursales`) REFERENCES `sucursales` (`idsucursales`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (17,'Carlhos Edgardo','Figueroa Tejada','1999-10-28','75652543','La Hachadura','12345678-9',3,'2021-05-19',4),(18,'Antonio ','Lara','1998-03-04','33','1ahi1','223333',3,'2021-03-05',2),(19,'Arturo','Perez','1997-06-06','44','2aya2','444466-9',1,'2021-03-05',2),(20,' AAA ',' BBBB ','1998-05-19',' 444444 ',' CCCC ',' 555555 ',3,'2021-05-19',3),(21,' PEPE ',' PEPE ','2001-10-05',' 67913347 ',' Por donde la pepe ',' 88888888888888',3,'2021-05-21',4);
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
  `Concepto` varchar(50) NOT NULL,
  `Abono` decimal(9,2) NOT NULL,
  `idEmpleado` int(11) NOT NULL,
  PRIMARY KEY (`idMovimientos`),
  KEY `fk_movimiento_idx` (`idContrato`),
  KEY `fk_mov_idx` (`idContrato`),
  KEY `fk_cobrador_idx` (`idEmpleado`),
  CONSTRAINT `fk_cobrador` FOREIGN KEY (`idEmpleado`) REFERENCES `usuarios` (`idusuarios`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_mov` FOREIGN KEY (`idContrato`) REFERENCES `contratos` (`idcontratos`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimientos`
--

LOCK TABLES `movimientos` WRITE;
/*!40000 ALTER TABLE `movimientos` DISABLE KEYS */;
INSERT INTO `movimientos` VALUES (2,'2021-05-20',11,'Abono corriente',20.50,13),(3,'2021-05-20',11,'Abono corriente',20.50,13),(4,'2021-05-20',12,'Abono corriente',10.00,13),(7,'2021-05-20',14,'Abono Comun',15.00,14),(8,'2021-05-20',12,'Abono Corriente',10.00,14),(12,'2021-05-21',15,'Abono corriente',25.00,14),(13,'2021-05-21',15,'Pago de todo',1175.00,14),(18,'2021-05-21',12,'Abono Ordinario+ extra',40.00,14);
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
  `nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idsucursales`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursales`
--

LOCK TABLES `sucursales` WRITE;
/*!40000 ALTER TABLE `sucursales` DISABLE KEYS */;
INSERT INTO `sucursales` VALUES (1,'Barrio Santa Cruz, Sexta calle poninte y cuarta avenida norte, Casa #12, Chalchuapa','24440565','Chalchuapa'),(3,' La Hachadura ',' 24356745 ','La Hachadura');
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
  `idSucursal` int(11) DEFAULT NULL,
  `idEncargado` int(11) DEFAULT NULL,
  PRIMARY KEY (`idSucursales/Encargados`),
  KEY `fk_encargado_idx` (`idEncargado`),
  KEY `fk:suc_idx` (`idSucursal`),
  CONSTRAINT `fk_encargado` FOREIGN KEY (`idEncargado`) REFERENCES `empleados` (`idempleados`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_suc` FOREIGN KEY (`idSucursal`) REFERENCES `sucursales` (`idsucursales`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursales_encargados`
--

LOCK TABLES `sucursales_encargados` WRITE;
/*!40000 ALTER TABLE `sucursales_encargados` DISABLE KEYS */;
INSERT INTO `sucursales_encargados` VALUES (24,1,18),(25,3,19);
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
  `tratamiento` int(11) DEFAULT NULL,
  PRIMARY KEY (`idTipoDeContrato`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipodecontrato`
--

LOCK TABLES `tipodecontrato` WRITE;
/*!40000 ALTER TABLE `tipodecontrato` DISABLE KEYS */;
INSERT INTO `tipodecontrato` VALUES (2,'Contrato individual Comun','d',1.00000,1),(3,'Individual Para Socio','sfsf',0.75000,1),(4,'Colectivo Comun','dad',3.00000,3),(5,'Colectivo Para Socio','CCCC',2.56000,3);
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
  `rol` enum('Administrador','Gerente','Vendedor') NOT NULL,
  `idempleados` int(11) NOT NULL,
  PRIMARY KEY (`idusuarios`),
  KEY `fk_empleado_idx` (`idempleados`),
  CONSTRAINT `fk_empleado` FOREIGN KEY (`idempleados`) REFERENCES `empleados` (`idempleados`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (13,'CARLHOSF','1234','Administrador',17),(14,'SS','SS','Administrador',18),(15,'PEPE','PEPE','Administrador',21);
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

-- Dump completed on 2021-05-21 16:55:18
