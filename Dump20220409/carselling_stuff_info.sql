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
-- Table structure for table `stuff_info`
--

DROP TABLE IF EXISTS `stuff_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stuff_info` (
  `stuff_id` int NOT NULL AUTO_INCREMENT,
  `national_id` varchar(14) NOT NULL,
  `stuff_first_name` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `stuff_last_name` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `stuff_gender` varchar(1) NOT NULL,
  `dob` date NOT NULL,
  `stuff_phone_num` varchar(10) NOT NULL,
  `stuff_addr` varchar(255) DEFAULT NULL,
  `stuff_image_path` varchar(255) NOT NULL,
  `stuff_state_id` tinyint NOT NULL,
  `is_deleted` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`stuff_id`),
  UNIQUE KEY `national_id` (`national_id`),
  KEY `fk_stuff_state_id` (`stuff_state_id`),
  CONSTRAINT `fk_stuff_state_id` FOREIGN KEY (`stuff_state_id`) REFERENCES `stuff_state` (`stuff_state_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stuff_info`
--

LOCK TABLES `stuff_info` WRITE;
/*!40000 ALTER TABLE `stuff_info` DISABLE KEYS */;
INSERT INTO `stuff_info` VALUES (1,'02251221','Lisophara','Leam','M','2001-01-17','0966258640','1J Kraches','image/IMG_2111.JPG',1,0),(2,'022512212','Lisop','Le22','M','2001-01-17','0966258640','1J Kraches','image/24123123',3,1),(3,'022512216','Lisop','Le22','M','2001-01-17','0966258640','1J Kraches','image/24123123',3,0),(5,'11244556','Haiya','Mary','F','2001-01-17','0966258640','1J kraches','image/asdasd',3,0),(8,'21212314','Leam','Lisophara','M','2022-03-26','0966258640','sdas asdaf fsfasd  asdasdasd sdasd','',2,0),(9,'099358212','Lisophara','Leam','M','2000-01-01','0966258640','ada asda aijmoiaa kas.a oa','imagef49312de-19f5-44de-8be5-09ce176342dc.JPG',2,0),(10,'2312312','adadad','asdadasd','M','2000-01-01','123123123','asdasdasdasd','image7971fb51-b443-4dad-9951-fa6db2a2067d.JPG',3,0),(11,'12313212','123asdasd','123asdasd','M','2000-01-01','2311234','asdasdasdads','image/9f2e4b1b-333e-475f-ad24-040d022b4cde.JPG',3,0),(12,'09982412','Leam','lisophara','M','2001-01-17','2241224','asdad asd asd  asd as da sd','image/1c0f8f0c-8562-4760-9ed6-7f64b80caf99.JPG',2,0);
/*!40000 ALTER TABLE `stuff_info` ENABLE KEYS */;
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
