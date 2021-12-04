/*P. H. Otero 2015233 */

/*!40101 SET NAMES utf8 */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET SQL_NOTES=0 */;
DROP TABLE IF EXISTS prj_to_client;
CREATE TABLE `prj_to_client` (
  `Connection_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Client_Id` int(11) DEFAULT NULL,
  `SolarisPrjProject_Id` int(11) DEFAULT NULL,
  PRIMARY KEY (`Connection_Id`),
  KEY `IX_prj_to_client_Client_Id` (`Client_Id`),
  KEY `IX_prj_to_client_SolarisPrjProject_Id` (`SolarisPrjProject_Id`),
  CONSTRAINT `FK_prj_to_client_client_Client_Id` FOREIGN KEY (`Client_Id`) REFERENCES `client` (`Client_Id`),
  CONSTRAINT `FK_prj_to_client_solaris_project_SolarisPrjProject_Id` FOREIGN KEY (`SolarisPrjProject_Id`) REFERENCES `solaris_project` (`Project_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;
INSERT INTO `prj_to_client`(`Connection_Id`, `Client_Id`, `SolarisPrjProject_Id`) VALUES ('1',(SELECT Client_Id FROM client WHERE first_name = "Trixie"), (SELECT Project_Id FROM solaris_project WHERE project_title = "Racking Systems"))
