/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.6.12-log : Database - agrosys
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`agrosys` /*!40100 DEFAULT CHARACTER SET ucs2 COLLATE ucs2_spanish_ci */;

USE `agrosys`;

/*Table structure for table `cliente` */

DROP TABLE IF EXISTS `cliente`;

CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `primer_nombre` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `segundo_nombre` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `primer_apellido` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `segundo_apellido` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `direccion` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `telefono` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `nit` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `dpi` varchar(75) COLLATE ucs2_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `cliente` */

insert  into `cliente`(`id_cliente`,`primer_nombre`,`segundo_nombre`,`primer_apellido`,`segundo_apellido`,`direccion`,`telefono`,`nit`,`dpi`) values (1,'Steveen','Alexis','Blanco','Gómez','67134542','45646','67134542','465456'),(3,'Juan','Diego','Perez','Lopez','4567891','548754232','4567891','565446546'),(4,'Elisa ','Del Rosario','Fonsea','Lopez','zona 15 Guatemala ','245784514','456489798','4560465046'),(5,'Steveen','blanco','gomez','afdsjkl','234e234jlk32jl|','3232','990','8888');

/*Table structure for table `control_acceso` */

DROP TABLE IF EXISTS `control_acceso`;

CREATE TABLE `control_acceso` (
  `id_control_acceso` int(11) NOT NULL,
  `hora` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `fecha` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `usuario_id_usuario` int(11) NOT NULL,
  PRIMARY KEY (`id_control_acceso`,`usuario_id_usuario`),
  KEY `fk_control_acceso_usuario1_idx` (`usuario_id_usuario`),
  CONSTRAINT `fk_control_acceso_usuario1` FOREIGN KEY (`usuario_id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `control_acceso` */

/*Table structure for table `detalle_factura` */

DROP TABLE IF EXISTS `detalle_factura`;

CREATE TABLE `detalle_factura` (
  `id_detalle_factura` int(11) NOT NULL AUTO_INCREMENT,
  `sub_total` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `factura_id_factura` int(11) NOT NULL,
  `producto_id_producto` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_factura`,`factura_id_factura`,`producto_id_producto`),
  KEY `fk_detalle_factura_factura1_idx` (`factura_id_factura`),
  KEY `fk_detalle_factura_producto1_idx` (`producto_id_producto`),
  CONSTRAINT `fk_detalle_factura_factura1` FOREIGN KEY (`factura_id_factura`) REFERENCES `factura` (`id_factura`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_factura_producto1` FOREIGN KEY (`producto_id_producto`) REFERENCES `producto` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `detalle_factura` */

insert  into `detalle_factura`(`id_detalle_factura`,`sub_total`,`cantidad`,`factura_id_factura`,`producto_id_producto`) values (1,'8250',150,1,2),(2,'1904',56,1,3),(3,'1530',45,1,3),(4,'3685',67,2,2),(5,'3685',67,3,2),(6,'4950',90,4,2),(8,'22882',673,6,3),(9,'22882',673,6,3),(10,'22882',673,6,3),(11,'22882',673,6,3),(12,'22882',673,6,3);

/*Table structure for table `detalle_order_de_compra` */

DROP TABLE IF EXISTS `detalle_order_de_compra`;

CREATE TABLE `detalle_order_de_compra` (
  `id_detalle_order_de_compra` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `proveedor_id_proveedor` int(11) NOT NULL,
  `order_de_compra_id_order_de_compra` int(11) NOT NULL,
  `producto_id_producto` int(11) NOT NULL,
  `precio` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `subtotal` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_detalle_order_de_compra`,`proveedor_id_proveedor`,`order_de_compra_id_order_de_compra`,`producto_id_producto`),
  KEY `fk_detalle_order_de_compra_proveedor1_idx` (`proveedor_id_proveedor`),
  KEY `fk_detalle_order_de_compra_order_de_compra1_idx` (`order_de_compra_id_order_de_compra`),
  KEY `fk_detalle_order_de_compra_producto1_idx` (`producto_id_producto`),
  CONSTRAINT `fk_detalle_order_de_compra_order_de_compra1` FOREIGN KEY (`order_de_compra_id_order_de_compra`) REFERENCES `order_de_compra` (`id_order_de_compra`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_order_de_compra_producto1` FOREIGN KEY (`producto_id_producto`) REFERENCES `producto` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_order_de_compra_proveedor1` FOREIGN KEY (`proveedor_id_proveedor`) REFERENCES `proveedor` (`id_proveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `detalle_order_de_compra` */

/*Table structure for table `detalle_pedido_tienda` */

DROP TABLE IF EXISTS `detalle_pedido_tienda`;

CREATE TABLE `detalle_pedido_tienda` (
  `id_detalle_pedido_tienda` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(11) DEFAULT NULL,
  `pedido_tienda_id_pedido_tienda` int(11) NOT NULL,
  PRIMARY KEY (`id_detalle_pedido_tienda`,`pedido_tienda_id_pedido_tienda`),
  KEY `fk_detalle_pedido_tienda_pedido_tienda1_idx` (`pedido_tienda_id_pedido_tienda`),
  CONSTRAINT `fk_detalle_pedido_tienda_pedido_tienda1` FOREIGN KEY (`pedido_tienda_id_pedido_tienda`) REFERENCES `pedido_tienda` (`id_pedido_tienda`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `detalle_pedido_tienda` */

/*Table structure for table `empleado` */

DROP TABLE IF EXISTS `empleado`;

CREATE TABLE `empleado` (
  `id_empleado` int(11) NOT NULL AUTO_INCREMENT,
  `primer_nombre` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `segundo_nombre` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `primer_apellido` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `segundo_apellido` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `direccion` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `telefono` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `tienda_id_tienda` int(11) NOT NULL,
  `dpi` varchar(75) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `nit` varchar(75) COLLATE ucs2_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_empleado`,`tienda_id_tienda`),
  KEY `fk_empleado_tienda1_idx` (`tienda_id_tienda`),
  CONSTRAINT `fk_empleado_tienda1` FOREIGN KEY (`tienda_id_tienda`) REFERENCES `tienda` (`id_tienda`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `empleado` */

insert  into `empleado`(`id_empleado`,`primer_nombre`,`segundo_nombre`,`primer_apellido`,`segundo_apellido`,`direccion`,`telefono`,`tienda_id_tienda`,`dpi`,`nit`) values (2,'Sasha piri','Daniela','Blanco','Fonsea','456498','45218754',3,'1564696','456498'),(3,'Alexisxx','Stuardxx','Gomezxx','Perezxx','5465645','21547845',3,'4564567489','5465645'),(4,'Emiliana','Chabela','Pulix','Talax','zona 12','21547845',4,'45668999','758954'),(5,'Chayannaxxx','Riannna','Tzum','Chichiwix','75895455','25896532',4,'45668472','75895455');

/*Table structure for table `envio_tienda` */

DROP TABLE IF EXISTS `envio_tienda`;

CREATE TABLE `envio_tienda` (
  `id_envio_tienda` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `pedido_tienda_id_pedido_tienda` int(11) NOT NULL,
  PRIMARY KEY (`id_envio_tienda`,`pedido_tienda_id_pedido_tienda`),
  KEY `fk_envio_tienda_pedido_tienda1_idx` (`pedido_tienda_id_pedido_tienda`),
  CONSTRAINT `fk_envio_tienda_pedido_tienda1` FOREIGN KEY (`pedido_tienda_id_pedido_tienda`) REFERENCES `pedido_tienda` (`id_pedido_tienda`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `envio_tienda` */

/*Table structure for table `factura` */

DROP TABLE IF EXISTS `factura`;

CREATE TABLE `factura` (
  `id_factura` int(11) NOT NULL AUTO_INCREMENT,
  `sub_total` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `total` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `iva` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `cliente_id_cliente` int(11) NOT NULL,
  PRIMARY KEY (`id_factura`,`cliente_id_cliente`),
  KEY `fk_factura_cliente_idx` (`cliente_id_cliente`),
  CONSTRAINT `fk_factura_cliente` FOREIGN KEY (`cliente_id_cliente`) REFERENCES `cliente` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `factura` */

insert  into `factura`(`id_factura`,`sub_total`,`total`,`iva`,`cliente_id_cliente`) values (1,'25000','26500','1500',3),(2,'32432433','23423433','232',4),(3,'32432433','23423433','232',4),(4,'50000','90000','900',1),(6,'120000','123000','1100',5);

/*Table structure for table `inventario` */

DROP TABLE IF EXISTS `inventario`;

CREATE TABLE `inventario` (
  `id_inventario` int(11) NOT NULL AUTO_INCREMENT,
  `total_productos` int(11) DEFAULT NULL,
  `proveedor_id_proveedor` int(11) NOT NULL,
  `producto_id_producto` int(11) NOT NULL,
  PRIMARY KEY (`id_inventario`,`proveedor_id_proveedor`,`producto_id_producto`),
  KEY `fk_inventario_proveedor1_idx` (`proveedor_id_proveedor`),
  KEY `fk_inventario_producto1_idx` (`producto_id_producto`),
  CONSTRAINT `fk_inventario_producto1` FOREIGN KEY (`producto_id_producto`) REFERENCES `producto` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_inventario_proveedor1` FOREIGN KEY (`proveedor_id_proveedor`) REFERENCES `proveedor` (`id_proveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `inventario` */

/*Table structure for table `order_de_compra` */

DROP TABLE IF EXISTS `order_de_compra`;

CREATE TABLE `order_de_compra` (
  `id_order_de_compra` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `iva` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `total` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_order_de_compra`)
) ENGINE=InnoDB DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `order_de_compra` */

/*Table structure for table `pedido_cliente` */

DROP TABLE IF EXISTS `pedido_cliente`;

CREATE TABLE `pedido_cliente` (
  `id_pedido_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `cliente_id_cliente` int(11) NOT NULL,
  PRIMARY KEY (`id_pedido_cliente`,`cliente_id_cliente`),
  KEY `fk_pedido_cliente_cliente1_idx` (`cliente_id_cliente`),
  CONSTRAINT `fk_pedido_cliente_cliente1` FOREIGN KEY (`cliente_id_cliente`) REFERENCES `cliente` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `pedido_cliente` */

/*Table structure for table `pedido_tienda` */

DROP TABLE IF EXISTS `pedido_tienda`;

CREATE TABLE `pedido_tienda` (
  `id_pedido_tienda` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `tienda_id_tienda` int(11) NOT NULL,
  PRIMARY KEY (`id_pedido_tienda`,`tienda_id_tienda`),
  KEY `fk_pedido_tienda_tienda1_idx` (`tienda_id_tienda`),
  CONSTRAINT `fk_pedido_tienda_tienda1` FOREIGN KEY (`tienda_id_tienda`) REFERENCES `tienda` (`id_tienda`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `pedido_tienda` */

/*Table structure for table `producto` */

DROP TABLE IF EXISTS `producto`;

CREATE TABLE `producto` (
  `id_producto` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_producto` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `detalle_producto` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `proveedor_id_proveedor` int(11) NOT NULL,
  `precio` varchar(45) COLLATE ucs2_spanish_ci NOT NULL,
  PRIMARY KEY (`id_producto`,`proveedor_id_proveedor`),
  KEY `fk_producto_proveedor1_idx` (`proveedor_id_proveedor`),
  CONSTRAINT `fk_producto_proveedor1` FOREIGN KEY (`proveedor_id_proveedor`) REFERENCES `proveedor` (`id_proveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `producto` */

insert  into `producto`(`id_producto`,`nombre_producto`,`detalle_producto`,`proveedor_id_proveedor`,`precio`) values (1,'comida','asjdfklajdlfjaskdfl',2,'34'),(2,'comida2','asjdfklajdlfjaskdfl',2,'55'),(3,'comida3','asjdfklajdlfjaskdfl',2,'34');

/*Table structure for table `proveedor` */

DROP TABLE IF EXISTS `proveedor`;

CREATE TABLE `proveedor` (
  `id_proveedor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_proveedor` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `direccion` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `telefono` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `nit` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `proveedor` */

insert  into `proveedor`(`id_proveedor`,`nombre_proveedor`,`direccion`,`telefono`,`nit`) values (1,'Juan ','zona 12','23323223','3838383838'),(2,'diego','zona 5 ','09093290','0393211'),(3,'adan','sadjfaksldfjio','345345','122121');

/*Table structure for table `rol` */

DROP TABLE IF EXISTS `rol`;

CREATE TABLE `rol` (
  `id_rol` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_rol` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `descripcion` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `estado` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_rol`)
) ENGINE=InnoDB DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `rol` */

/*Table structure for table `tienda` */

DROP TABLE IF EXISTS `tienda`;

CREATE TABLE `tienda` (
  `id_tienda` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `direccion` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `telefono` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_tienda`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `tienda` */

insert  into `tienda`(`id_tienda`,`nombre`,`direccion`,`telefono`) values (1,'Tienda el Mago','zona 13','23452145'),(3,'Tienda el Mago de oz','zona 12','54784521'),(4,'Tiendita el pescado','zona 15','54215487');

/*Table structure for table `usuario` */

DROP TABLE IF EXISTS `usuario`;

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `password` varchar(45) COLLATE ucs2_spanish_ci DEFAULT NULL,
  `rol_id_rol` int(11) NOT NULL,
  `empleado_id_empleado` int(11) NOT NULL,
  PRIMARY KEY (`id_usuario`,`rol_id_rol`,`empleado_id_empleado`),
  KEY `fk_usuario_rol1_idx` (`rol_id_rol`),
  KEY `fk_usuario_empleado1_idx` (`empleado_id_empleado`),
  CONSTRAINT `fk_usuario_empleado1` FOREIGN KEY (`empleado_id_empleado`) REFERENCES `empleado` (`id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuario_rol1` FOREIGN KEY (`rol_id_rol`) REFERENCES `rol` (`id_rol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=ucs2 COLLATE=ucs2_spanish_ci;

/*Data for the table `usuario` */

/* Procedure structure for procedure `FacturaCount` */

/*!50003 DROP PROCEDURE IF EXISTS  `FacturaCount` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `FacturaCount`()
BEGIN
SELECT COUNT(*)  as totalDeTuplas FROM factura ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `FacturaNextIdValue` */

/*!50003 DROP PROCEDURE IF EXISTS  `FacturaNextIdValue` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `FacturaNextIdValue`(in tableName text)
BEGIN
SELECT max(id_factura) +1 as NextID From factura ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `getClientes` */

/*!50003 DROP PROCEDURE IF EXISTS  `getClientes` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `getClientes`()
BEGIN 
SELECT * FROM CLIENTE;
END */$$
DELIMITER ;

/* Procedure structure for procedure `getClientesById` */

/*!50003 DROP PROCEDURE IF EXISTS  `getClientesById` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `getClientesById`(in clienteId int)
BEGIN 
SELECT * FROM CLIENTE where id_cliente = clienteId;
END */$$
DELIMITER ;

/* Procedure structure for procedure `getPrecioProducto` */

/*!50003 DROP PROCEDURE IF EXISTS  `getPrecioProducto` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `getPrecioProducto`(
         IN productoID VARCHAR(25))
BEGIN
    select precio from producto where id_producto = productoID;
END */$$
DELIMITER ;

/* Procedure structure for procedure `getPrecioProductoPorID` */

/*!50003 DROP PROCEDURE IF EXISTS  `getPrecioProductoPorID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `getPrecioProductoPorID`(
         IN productoID VARCHAR(25) )
BEGIN
    select precio from producto where id_producto = productoID;
END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
