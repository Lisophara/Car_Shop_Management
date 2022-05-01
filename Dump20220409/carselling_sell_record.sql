-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: carselling
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `sell_record`
--

DROP TABLE IF EXISTS `sell_record`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sell_record` (
  `sell_id` int NOT NULL AUTO_INCREMENT,
  `sell_date` date NOT NULL,
  `sell_time` time NOT NULL,
  `stuff_id` int NOT NULL,
  `customer_national_id` varchar(12) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `car_identifier` varchar(17) NOT NULL,
  `discount` decimal(2,2) DEFAULT NULL,
  `is_deleted` tinyint(1) NOT NULL DEFAULT '0',
  `decription` varchar(512) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT '',
  PRIMARY KEY (`sell_id`),
  KEY `fk_stuff_id` (`stuff_id`),
  KEY `fk_customer_national_id` (`customer_national_id`),
  KEY `fk_car_identifier` (`car_identifier`),
  CONSTRAINT `fk_car_identifier` FOREIGN KEY (`car_identifier`) REFERENCES `car` (`identifier`),
  CONSTRAINT `fk_customer_national_id` FOREIGN KEY (`customer_national_id`) REFERENCES `customer` (`national_id`),
  CONSTRAINT `fk_stuff_id` FOREIGN KEY (`stuff_id`) REFERENCES `stuff_info` (`stuff_id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sell_record`
--

LOCK TABLES `sell_record` WRITE;
/*!40000 ALTER TABLE `sell_record` DISABLE KEYS */;
INSERT INTO `sell_record` VALUES (2,'2022-03-09','16:31:49',1,'022512551','1HGBH41JXMN109182',0.00,0,''),(3,'2022-03-10','14:25:26',1,'022512551','1HGBH41JXMN109182',0.00,0,''),(4,'2012-12-22','19:30:22',2,'022512555','1HGBH41JXMN109183',0.00,0,''),(19,'2022-03-23','15:14:41',2,'022512555','1HGBH41JXMN109183',0.00,0,'');
/*!40000 ALTER TABLE `sell_record` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-09 23:42:51
