-- MySQL dump 10.16  Distrib 10.1.36-MariaDB, for Win32 (AMD64)
--
-- Host: localhost    Database: pssc
-- ------------------------------------------------------
-- Server version	10.1.36-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `account` (
  `AccountId` char(255) NOT NULL,
  `DateCreated` date DEFAULT NULL,
  `AccountType` varchar(255) DEFAULT NULL,
  `OwnerId` char(255) DEFAULT NULL,
  PRIMARY KEY (`AccountId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account`
--

LOCK TABLES `account` WRITE;
/*!40000 ALTER TABLE `account` DISABLE KEYS */;
INSERT INTO `account` VALUES ('03e91478-5608-4132-a753-d494dafce00b','2003-12-15','Domestic','f98e4d74-0f68-4aac-89fd-047f1aaca6b6'),('356a5a9b-64bf-4de0-bc84-5395a1fdc9c4','1996-02-15','Domestic','261e1685-cf26-494c-b17c-3546e65f5620'),('371b93f2-f8c5-4a32-894a-fc672741aa5b','1999-05-04','Domestic','24fd81f8-d58a-4bcc-9f35-dc6cd5641906'),('670775db-ecc0-4b90-a9ab-37cd0d8e2801','1999-12-21','Savings','24fd81f8-d58a-4bcc-9f35-dc6cd5641906'),('a3fbad0b-7f48-4feb-8ac0-6d3bbc997bfc','2010-05-28','Domestic','a3c1880c-674c-4d18-8f91-5d3608a2c937'),('aa15f658-04bb-4f73-82af-82db49d0fbef','1999-05-12','Foreign','24fd81f8-d58a-4bcc-9f35-dc6cd5641906'),('c6066eb0-53ca-43e1-97aa-3c2169eec659','1996-02-16','Foreign','261e1685-cf26-494c-b17c-3546e65f5620'),('eccadf79-85fe-402f-893c-32d3f03ed9b1','2010-06-20','Foreign','a3c1880c-674c-4d18-8f91-5d3608a2c937');
/*!40000 ALTER TABLE `account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customer` (
  `Id` char(255) DEFAULT NULL,
  `FirstName` varchar(255) DEFAULT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `Balance` int(11) DEFAULT NULL,
  `CountryId` char(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES ('5918e0a0-e07c-45bc-b7fa-09109ff74232','Bianca','Bianca','bianca@gmail.com',NULL,0,'795d9cfc-7e18-49e7-81a0-c9aa2ea81552'),('826689c4-b82f-4e25-8a00-1c1f3a859205','Busuioc','Bogdan','bb@gmail.com',NULL,0,'e5f0417a-2e3c-491e-8003-195d106a1537'),('bd62160e-18c8-4a0c-b46d-6e53f494372a',NULL,NULL,NULL,NULL,NULL,'049ee962-125d-4048-a9d5-bf344bce2bb2'),('28150170-1a57-4f08-87ad-1512362ed8cf','Bogdaqweqwen','Bogdanbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'e5a1c155-fd17-46e2-99a9-b392556c4076'),('7887db46-210b-4159-95cd-6b7722ea48af','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'0247f54d-63c4-4c0d-8751-24150836ed82'),('93d0bb7c-9c2a-40ee-ac52-c20e7d332a3d','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'b678d1c3-bbab-4e32-a349-887b2059d662'),('506f6bec-b2cf-424e-b377-82b4f6ade4b9','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'f1b0de5e-95e9-47df-b3a4-ed8537479f79'),('9acb357f-1aed-4276-bccf-eb74076eaf6b','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'765b6ecd-0cfb-4413-abbd-ac4d29b5a032'),('a9b10994-5a99-414b-9564-785b80531432','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'4425899b-cf2d-4ad1-95ed-5b0d43675034'),('08281ad4-b3ec-4f52-99fe-fa04b83b87e5','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'357fc8cd-5944-40ec-b104-29efa60d84a9'),('c55f6db3-a560-4774-9e9d-70d5a2817a45','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'fa82001c-efa2-43b7-a81e-076500d6b560'),('552eb196-588d-4710-8a45-18fdfa62fe53','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'c8c5c1c0-d53b-4136-85ab-6b70228872c6'),('28c6e8ea-a89d-4fc5-b8b3-3df58574ed21','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'02434b93-820a-46d3-9b3e-b692dc9e9065'),('e7727310-c33b-47f0-aceb-52f17ee65894','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'1c027f70-a712-4182-a4ac-90edacfaaee3'),('ea857e62-86f3-4009-b795-93fbf55ec781','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'01ed0c26-5ff0-4834-8875-f84cbd074a50'),('43bbd7e9-807d-4bab-b8e7-36da1e6240c6','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'39dcf404-74f1-41ea-a684-758e20a5e536'),('101b4a7b-7ca3-49d0-a571-2075d662740a','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'bff8db13-7cfe-4728-9797-a80cdc1fddde'),('9e5d2cba-5b63-4001-9845-485058e53bb7','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'130615f1-e310-4a32-814b-f996bd1bb406'),('a419d9cb-6c21-42a5-afb3-eca4725b5189','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'df5ad20d-9212-46de-b8f0-aa655e6598e3'),('49146e35-781b-4202-bf84-2b51f86bdd20','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'9b839e2b-01b9-4b6e-9856-c91c9ed054d7'),('645c17c7-8659-401a-980a-3346af7a5aed','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'49b836ba-a259-458d-9a23-8ab5d4a4a00c'),('8299ac8a-6f86-45c6-8fac-de9e52cf4eea','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'778d53b3-b285-4897-ab15-58c3daf8b485'),('ef1c0888-5241-4b62-b9e1-56bab891ebc2','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'fbe8d3bf-e57e-410f-ad00-9d9b09e61621'),('7f818d89-b268-4ec7-9bad-7728b1a8f13b','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'516871ee-9d90-4f1d-91f3-3509ef8c7190'),('da3caee1-1932-470b-83fd-a35ac1ca68ff','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'8fcabc18-41e5-4bb8-93b9-4bf30e4b1ca2'),('a124cf14-d68e-49fa-9a64-18d889062567','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'6a9c0818-92cd-4288-a2c0-26204513e5f5'),('462852d9-7148-4caf-93ba-fc177114c949','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'0c53f608-77ad-4f9f-a069-2c40d3bb8d0e'),('f8c2029c-a7c7-4c7b-bfc1-fe545bcdfc3f','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'ff962b74-299e-4b41-923d-fa571e9fcd00'),('b68ec25f-8107-4e08-83cf-715b82a86b4f','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'95454439-ebd0-4f95-87f0-285fb462305c'),('438d4c4a-46ab-4c19-bf65-6527bded5d69','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'81018c13-978c-4297-858a-013d6ad86526'),('dca0bf10-f1e9-46aa-8fe6-43e2cf18cd9f','Bogdaqwqeqweweqwen','Bogdaqweqwenbbbqeqwe','Bogdan@adad.casd',NULL,NULL,'69607d6b-0fc5-4ae2-8a95-091cefc08c39');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `owner`
--

DROP TABLE IF EXISTS `owner`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `owner` (
  `OwnerId` char(255) NOT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `DateOfBirth` date DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`OwnerId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `owner`
--

LOCK TABLES `owner` WRITE;
/*!40000 ALTER TABLE `owner` DISABLE KEYS */;
INSERT INTO `owner` VALUES ('24fd81f8-d58a-4bcc-9f35-dc6cd5641906','John Keen','1980-12-05','61 Wellfield Road'),('261e1685-cf26-494c-b17c-3546e65f5620','Anna Bosh','1974-11-14','27 Colored Row'),('a3c1880c-674c-4d18-8f91-5d3608a2c937','Sam Query','1990-04-22','91 Western Roads'),('f98e4d74-0f68-4aac-89fd-047f1aaca6b6','Martin Miller','1983-05-21','3 Edgar Buildings');
/*!40000 ALTER TABLE `owner` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product` (
  `Id` char(255) DEFAULT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `created` date DEFAULT NULL,
  `modified` date DEFAULT NULL,
  `Active` tinyint(1) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `Cost` int(11) DEFAULT NULL,
  `ProductCodeId` char(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES ('08d6726a-8fbe-a1f5-523e-8cd55089b5b4','test','2019-01-04','2019-01-04',1,20,150,'00000000-0000-0000-0000-000000000000');
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `Id` char(255) DEFAULT NULL,
  `UserName` varchar(255) DEFAULT NULL,
  `PasswordHash` binary(64) DEFAULT NULL,
  `PasswordSalt` binary(128) DEFAULT NULL,
  `Role` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('08d67281-01c5-e742-40d4-c7905ebad41c','bogdan','ù \0£¶&’¡%{ìå-+DŒ8Æ‘∂víﬁä¯…√cc€s∫èÛÄ<»ÔÆC9¥\"ãvÿq%ü≈cŸ≥=,ˇ8Å','≥«-–∞¿{TÎf	gı ﬂùÕ◊ƒ\0ÕMı·Hƒf´ .G“„ƒ_Do{ôº≠ ∞ÿq\\4¸‘A˙ﬂ$Søã◊pú[≤MTëËÀπÓ&Íùmﬂ8aπÓ9CS,Æ–óT©∏4‹‡ÎA_π™˚Í∞8%r6J∑†; ˛>@*¿°ÛÓ',NULL),('08d674d1-de24-8954-eebb-20e1435b09a6','Bia672','yúÓSà>Øe‰+ç€…ìÒÂ≈™Ï8:Êc°åDÈπﬁVúB«≠.%7Fòl˚Ìjût⁄\ZÏÙ1ah≥Y˜','?ªék¿≈È©\Z9æsó≠ûªBTæY˚dXñ’?Ó¯5LΩZzàQ∂Ãﬂ’7ÑG«ºe–e›\0éa≥\näﬂÎ∏/ﬁöL¸\"Q>∆∏∂\\á]˘ Ω1å‰GAŸ∞eVf@jƒ¬‚^Êõ§G?Ò<Gw‹…—JÊªí˘ø{∆«æ\n!˘¯Z',NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-08  0:44:24
