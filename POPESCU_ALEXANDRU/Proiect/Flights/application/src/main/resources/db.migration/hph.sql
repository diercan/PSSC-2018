-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.1.36-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win32
-- HeidiSQL Version:             9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for hph
CREATE DATABASE IF NOT EXISTS `hph` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `hph`;

-- Dumping structure for table hph.airplane
CREATE TABLE IF NOT EXISTS `airplane` (
  `id_airplane` int(10) unsigned NOT NULL,
  `places` double NOT NULL,
  `id_booking` int(11) unsigned NOT NULL,
  KEY `FK_airplane_booking` (`id_booking`),
  CONSTRAINT `FK_airplane_booking` FOREIGN KEY (`id_booking`) REFERENCES `booking` (`Id_booking`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table hph.airplane: ~0 rows (approximately)
/*!40000 ALTER TABLE `airplane` DISABLE KEYS */;
INSERT INTO `airplane` (`id_airplane`, `places`, `id_booking`) VALUES
	(1, 500, 1);
/*!40000 ALTER TABLE `airplane` ENABLE KEYS */;

-- Dumping structure for table hph.booking
CREATE TABLE IF NOT EXISTS `booking` (
  `id_booking` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `from` varchar(50) DEFAULT NULL,
  `to` varchar(50) DEFAULT NULL,
  `date_year` varchar(10) DEFAULT NULL,
  `date_hour` varchar(10) DEFAULT NULL,
  `traveltime` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`id_booking`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Dumping data for table hph.booking: ~0 rows (approximately)
/*!40000 ALTER TABLE `booking` DISABLE KEYS */;
INSERT INTO `booking` (`id_booking`, `from`, `to`, `date_year`, `date_hour`, `traveltime`) VALUES
	(1, 'RO', 'DE', '2019-12-29', '15:25', '01:05');
/*!40000 ALTER TABLE `booking` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
