/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

CREATE DATABASE IF NOT EXISTS `demo` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `demo`;

CREATE TABLE IF NOT EXISTS `contacts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `phone` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL,
  `created` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

/*!40000 ALTER TABLE `contacts` DISABLE KEYS */;
INSERT INTO `contacts` (`id`, `name`, `email`, `phone`, `title`, `created`) VALUES
	(1, 'João Rodrigues', 'jr@example.com', '2326550143', 'Supervisor', '2019-05-08 17:32:00'),
	(2, 'David Simões', 'davidsimoes@example.com', '2025550121', 'Funcionário', '2022-01-19 17:28:00'),
	(3, 'José Abrantes', 'ja@example.com', '232455012', 'Funcionário', '2021-05-08 17:29:00'),
	(4, 'Carlos Batista', 'carlos@example.com', '222550178', 'Supervisor', '2021-05-08 17:29:00'),
	(5, 'Rui Carvalho', 'ruicarv@example.com', '212234239', '', '2019-05-09 19:16:00'),
	(6, 'Arnaldo Jorge', 'arnaldo@example.com', '5089573579', 'Admin', '2019-05-09 19:17:00'),
	(7, 'António Gonçalves', 'ag@example.com', '2603668738', '', '2019-05-09 19:19:00'),
	(8, 'Donald Perry', 'donald1983@example.com', '7019007916', 'Funcionário', '2019-05-09 19:20:00'),
	(9, 'Isabel Alves', 'isabel@example.com', '6153353674', 'Funcionário', '2019-05-09 19:20:00'),
	(10, 'Angela Hortis', 'angela1977@example.com', '3094234980', 'Supervisor', '2019-05-09 19:21:00'),
	(11, 'João Peres', 'peres1965@example.com', '4002349823', 'Admin', '2019-05-09 19:32:00'),
	(13, 'José Carvalho', 'pa@sapo.pt', '962392344', 'Admin', '2022-01-14 22:09:00'),
	(14, 'Amadeu Gomes', 'ag@sapo.pt', '222555666', 'Admin', '2022-01-19 19:23:00');
/*!40000 ALTER TABLE `contacts` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
