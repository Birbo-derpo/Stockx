/*
SQLyog Community v13.2.1 (64 bit)
MySQL - 10.4.32-MariaDB : Database - stockx
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`stockx` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `stockx`;

/*Table structure for table `tblmaininventory` */

DROP TABLE IF EXISTS `tblmaininventory`;

CREATE TABLE `tblmaininventory` (
  `Invoice` varchar(55) NOT NULL,
  `Datearrive` datetime NOT NULL,
  `Model` varchar(55) NOT NULL,
  `Color` varchar(55) NOT NULL,
  `Price` double NOT NULL,
  `EngineNum` varchar(55) NOT NULL,
  `FrameNum` varchar(55) NOT NULL,
  `TotalAmount` double NOT NULL,
  PRIMARY KEY (`Invoice`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tblmaininventory` */

insert  into `tblmaininventory`(`Invoice`,`Datearrive`,`Model`,`Color`,`Price`,`EngineNum`,`FrameNum`,`TotalAmount`) values 
('1232321','2024-02-01 00:00:00','332133','13232',3132132,'312321','213213',2312312);

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `Email` varchar(20) NOT NULL,
  `Pass` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `users` */

insert  into `users`(`Email`,`Pass`) values 
('email','ebdf8cc00bc4d9ceee633c56c63b49955769a92ca060825c9b08e4af61326e2b');

/* Procedure structure for procedure `DeleteUnitbyInvoice` */

/*!50003 DROP PROCEDURE IF EXISTS  `DeleteUnitbyInvoice` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteUnitbyInvoice`(p_invoice INTEGER)
BEGIN
	DELETE FROM tblmaininventory WHERE Invoice = p_invoice;
	
	END */$$
DELIMITER ;

/* Procedure structure for procedure `prcAddMotorcycel` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcAddMotorcycel` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcAddMotorcycel`(p_invoice VARCHAR(50),
					 p_dd DATETIME,
					 p_model VARCHAR(50),
					 p_color VARCHAR(50),
					
					 p_price INTEGER,
					 p_engine VARCHAR(45),
					 p_frame VARCHAR(11),
					 p_Total  INTEGER)
BEGIN
		INSERT INTO tblmaininventory(Invoice,
				       Datearrive,
				       Model,
				       Color,
				       Price,
				       EngineNum,
				       Framenum,
				       TotalAmount)
				      
				       
				VALUES(  p_invoice,
					 p_dd ,
					 p_model ,
					 p_color ,	
					 p_price ,
					 p_engine,
					 p_frame ,
					 p_Total );
					


	END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayMotorcycle` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayMotorcycle` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayMotorcycle`()
BEGIN
			SELECT Invoice,
				       Datearrive,
				       Model,
				       Color,
				       Price,
				       EngineNum,
				       Framenum,
				       TotalAmount
			FROM tblmaininventory ORDER BY Invoice ASC;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `prc_Login` */

/*!50003 DROP PROCEDURE IF EXISTS  `prc_Login` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prc_Login`(p_email varchar(20), p_password varchar(256))
BEGIN
		SELECT Email from users WHERE Email = p_email AND pass = SHA2(p_password, 256);
	END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
