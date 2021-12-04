/*P. H. Otero 2015233 */

/*!40101 SET NAMES utf8 */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET SQL_NOTES=0 */;
DROP TABLE IF EXISTS client;
CREATE TABLE `client` (
  `Client_Id` int(11) NOT NULL AUTO_INCREMENT,
  `First_name` longtext DEFAULT NULL,
  `Last_name` longtext DEFAULT NULL,
  `City` longtext DEFAULT NULL,
  `Phone_number` longtext DEFAULT NULL,
  PRIMARY KEY (`Client_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=13396 DEFAULT CHARSET=utf8mb4;