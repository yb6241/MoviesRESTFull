-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.7.36 - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for db_xsis
CREATE DATABASE IF NOT EXISTS `db_xsis` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `db_xsis`;

-- Dumping structure for table db_xsis.movies
CREATE TABLE IF NOT EXISTS `movies` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(50) DEFAULT NULL,
  `description` varchar(1000) DEFAULT NULL,
  `rating` float DEFAULT NULL,
  `image` varchar(50) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- Dumping data for table db_xsis.movies: 5 rows
DELETE FROM `movies`;
/*!40000 ALTER TABLE `movies` DISABLE KEYS */;
INSERT INTO `movies` (`id`, `title`, `description`, `rating`, `image`, `created_at`, `updated_at`) VALUES
	(1, 'Pengabdi Setan 2 Comunion', 'adalah sebuah film horor Indonesia tahun 2022 yang disutradarai dan', 7, '', '2023-06-03 00:56:20', '2023-06-03 00:56:22'),
	(2, 'Pengabdi Setan', 'Adalah sebuah film karya Mytan', 7, '', '2023-06-03 00:58:44', '2023-06-03 02:02:43'),
	(3, 'Avenger age of ultron', 'adalah sebuah film karya Marvel Studios', 8, '', '2023-06-03 02:17:39', '2023-06-03 02:17:39'),
	(4, 'Fast Furious 9', 'Adalah sebuah film balapan mobil yang diperankan oleh Vin Diesel', 5, '', '2023-06-03 02:23:30', '2023-06-03 02:23:30'),
	(5, 'Hatchi', 'Adalah sebuah film serangga semut dalam mencari mama', 8, '', '2023-06-03 02:24:08', '2023-06-03 02:24:08');
/*!40000 ALTER TABLE `movies` ENABLE KEYS */;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
