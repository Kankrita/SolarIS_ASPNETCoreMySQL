/*P. H. Otero 2015233 */

/*!40101 SET NAMES utf8 */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET SQL_NOTES=0 */;
DROP TABLE IF EXISTS solaris_project;
CREATE TABLE `solaris_project` (
  `Project_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Project_Title` longtext DEFAULT NULL,
  `Cost` decimal(10,0) NOT NULL,
  `Due_date` datetime(6) NOT NULL,
  PRIMARY KEY (`Project_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;