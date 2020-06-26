
-- ------------------------------------------------------
-- Server version	8.0.19

CREATE SCHEMA IF NOT EXISTS `ventas_comedor` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `ventas_comedor` ;


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
-- Table structure for table `bebida`

--

DROP TABLE IF EXISTS `bebida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bebida` (
  `idBebida` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `precio` float NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idBebida`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bebida`
--

LOCK TABLES `bebida` WRITE;
/*!40000 ALTER TABLE `bebida` DISABLE KEYS */;
/*!40000 ALTER TABLE `bebida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `caja`
--

DROP TABLE IF EXISTS `caja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `caja` (
  `idCaja` int NOT NULL,
  `idEmpleado` int NOT NULL,
  `idCliente` int NOT NULL,
  `idMesa` int NOT NULL,
  `idPedido` int NOT NULL,
  `Total` float NOT NULL,
  PRIMARY KEY (`idCaja`),
  KEY `idEmpleado_idx` (`idEmpleado`,`idCaja`),
  KEY `idCliente_idx` (`idCliente`),
  KEY `idMesa_idx` (`idMesa`),
  KEY `idPedido_idx` (`idPedido`),
  CONSTRAINT `idCliente` FOREIGN KEY (`idCliente`) REFERENCES `caja` (`idCaja`),
  CONSTRAINT `idEmpleado` FOREIGN KEY (`idEmpleado`) REFERENCES `caja` (`idCaja`),
  CONSTRAINT `idMesa` FOREIGN KEY (`idMesa`) REFERENCES `caja` (`idCaja`),
  CONSTRAINT `idPedido` FOREIGN KEY (`idPedido`) REFERENCES `caja` (`idCaja`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caja`
--

LOCK TABLES `caja` WRITE;
/*!40000 ALTER TABLE `caja` DISABLE KEYS */;
/*!40000 ALTER TABLE `caja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `idCliente` varchar(15) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `comida`
--

DROP TABLE IF EXISTS `comida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `comida` (
  `idComida`int NOT NULL AUTO_INCREMENT,
  `comida` varchar(45) NOT NULL,
  `precio` float NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  PRIMARY KEY (`idComida`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comida`
--

LOCK TABLES `comida` WRITE;
/*!40000 ALTER TABLE `comida` DISABLE KEYS */;
/*!40000 ALTER TABLE `comida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `idEmpleado`varchar(15) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `apeliido` varchar(45) NOT NULL,
  `edad` int NOT NULL,
  `cargo` varchar(45) NOT NULL,
  PRIMARY KEY (`idEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;


-- -----------------------------------------------------
-- Table `makeupbar`.`factura`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Factura` (
  `IdFactura` INT NOT NULL AUTO_INCREMENT,
  `FechaActual` DATETIME NULL DEFAULT CURRENT_TIMESTAMP(),
  `IdEmpleado` VARCHAR(15) NOT NULL,
  `idCliente` VARCHAR(15) NOT NULL,
  PRIMARY KEY (`IdFactura`),
  INDEX `idEmpleadoFK_idx` (`IdEmpleado` ASC) VISIBLE,
  INDEX `idClienteFK_idx` (`idCliente` ASC) VISIBLE,
  CONSTRAINT `FK_Factura_idEmpeado_Empelado`
    FOREIGN KEY (`IdEmpleado`)
    REFERENCES `empleado` (`idEmpleado`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `FK_Factura_idCliente_Cliente`
    FOREIGN KEY (`idCliente`)
    REFERENCES `cliente` (`IdCliente`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `makeupbar`.`Venta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Venta` (
  `idVenta` INT NOT NULL AUTO_INCREMENT,
  `idCliente` VARCHAR(15) NULL,
  `idEmpleado` VARCHAR(15) NULL,
  `Fecha` DATETIME NULL DEFAULT CURRENT_TIMESTAMP(),
  INDEX `idVenta` USING BTREE (`idVenta`) VISIBLE,
  PRIMARY KEY (`idVenta`),
  UNIQUE INDEX `idVenta_UNIQUE` (`idVenta` ASC) VISIBLE,
  INDEX `FK_Venta_idCliene_Cliente_idx` (`idCliente` ASC) VISIBLE,
  INDEX `FK_Venta_idEmpleado_Empleado_idx` (`idEmpleado` ASC) VISIBLE,
  CONSTRAINT `FK_Venta_idCliene_Cliente`
    FOREIGN KEY (`idCliente`)
    REFERENCES `cliente` (`IdCliente`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `FK_Venta_idEmpleado_Empleado`
    FOREIGN KEY (`idEmpleado`)
    REFERENCES `empleado` (`idEmpleado`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `makeupbar`.`DetalleDeVenta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DetalleDeFactura` (
  `idDetalleDeFactura` INT NOT NULL AUTO_INCREMENT,
  `idVenta` INT NULL,
  `idFactura` INT NULL,
  `idPedido` INT NULL,
  `precio` FLOAT NULL,
  `Cantidad` INT NULL,
  `Total` float NULL,
  
  PRIMARY KEY (`idDetalleDeFactura`),
  INDEX `FK_DetalleDeFactura_idVenta_Venta_idx` (`idVenta` ASC) VISIBLE,
  INDEX `FK_DetallaDeFactura_idFactura_Factura_idx` (`idFactura` ASC) VISIBLE,
  INDEX `fk_DetalleDeFactura_idPedido_pedido_idx` (`idPedido` ASC) VISIBLE,
  CONSTRAINT `FK_DetalleDeFactura_idVenta_Venta`
    FOREIGN KEY (`idVenta`)
    REFERENCES `Venta` (`idVenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_DetallaDeFactura_idFactura_Factura`
    FOREIGN KEY (`idFactura`)
    REFERENCES `factura` (`IdFactura`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_DetalleDeFactura_idPedido_Pedido`
    FOREIGN KEY (`idPedido`)
    REFERENCES `pedido` (`idPedido`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;
--
-- Table structure for table `mesa`
--

DROP TABLE IF EXISTS `mesa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mesa` (
  `idMesa` int NOT NULL AUTO_INCREMENT,
  `numeroMesa` int NOT NULL,
  `asientos` int NOT NULL,
  PRIMARY KEY (`idMesa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mesa`
--



LOCK TABLES `mesa` WRITE;
/*!40000 ALTER TABLE `mesa` DISABLE KEYS */;
/*!40000 ALTER TABLE `mesa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedido` (
  `idPedido` int NOT NULL AUTO_INCREMENT,
  `idComida` int NOT NULL,
  `idBebida` int NOT NULL,
  PRIMARY KEY (`idPedido`),
  KEY `idComida_idx` (`idComida`),
  KEY `idBebida_idx` (`idBebida`),
  CONSTRAINT `idBebida` FOREIGN KEY (`idBebida`) REFERENCES `pedido` (`idPedido`),
  CONSTRAINT `idComida` FOREIGN KEY (`idComida`) REFERENCES `pedido` (`idPedido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservacion`
--

DROP TABLE IF EXISTS `reservacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservacion` (
  `idReservacion` int NOT NULL AUTO_INCREMENT,
  `idCliente` int NOT NULL,
  `idMesa` int NOT NULL,
  `fecha` datetime NOT NULL,
  `hora`  VARCHAR(8) NULL,
  PRIMARY KEY (`idReservacion`),
  KEY `idCliente_idx` (`idCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservacion`
--

LOCK TABLES `reservacion` WRITE;
/*!40000 ALTER TABLE `reservacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `reservacion` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-21 18:07:52
