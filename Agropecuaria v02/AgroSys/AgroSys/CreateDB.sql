SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

DROP SCHEMA IF EXISTS `agrosys` ;
CREATE SCHEMA IF NOT EXISTS `agrosys` DEFAULT CHARACTER SET ucs2 COLLATE ucs2_spanish_ci ;
USE `agrosys` ;

-- -----------------------------------------------------
-- Table `agrosys`.`cliente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`cliente` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`cliente` (
  `id_cliente` INT NOT NULL AUTO_INCREMENT ,
  `primer_nombre` VARCHAR(45) NULL ,
  `segundo_nombre` VARCHAR(45) NULL ,
  `primer_apellido` VARCHAR(45) NULL ,
  `segundo_apellido` VARCHAR(45) NULL ,
  `direccion` VARCHAR(45) NULL ,
  `telefono` VARCHAR(45) NULL ,
  `nit` VARCHAR(45) NULL ,
  PRIMARY KEY (`id_cliente`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`tienda`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`tienda` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`tienda` (
  `id_tienda` INT NOT NULL AUTO_INCREMENT ,
  `nombre` VARCHAR(45) NULL ,
  `direccion` VARCHAR(45) NULL ,
  `telefono` VARCHAR(45) NULL ,
  PRIMARY KEY (`id_tienda`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`empleado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`empleado` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`empleado` (
  `id_empleado` INT NOT NULL AUTO_INCREMENT ,
  `primer_nombre` VARCHAR(45) NULL ,
  `segundo_nombre` VARCHAR(45) NULL ,
  `primer_apellido` VARCHAR(45) NULL ,
  `segundo_apellido` VARCHAR(45) NULL ,
  `direccion` VARCHAR(45) NULL ,
  `telefono` VARCHAR(45) NULL ,
  `tienda_id_tienda` INT NOT NULL ,
  PRIMARY KEY (`id_empleado`, `tienda_id_tienda`) ,
  INDEX `fk_empleado_tienda1_idx` (`tienda_id_tienda` ASC) ,
  CONSTRAINT `fk_empleado_tienda1`
    FOREIGN KEY (`tienda_id_tienda` )
    REFERENCES `agrosys`.`tienda` (`id_tienda` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`proveedor`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`proveedor` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`proveedor` (
  `id_proveedor` INT NOT NULL AUTO_INCREMENT ,
  `nombre_proveedor` VARCHAR(45) NULL ,
  `direccion` VARCHAR(45) NULL ,
  `telefono` VARCHAR(45) NULL ,
  `nit` VARCHAR(45) NULL ,
  PRIMARY KEY (`id_proveedor`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`producto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`producto` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`producto` (
  `id_producto` INT NOT NULL AUTO_INCREMENT ,
  `nombre_producto` VARCHAR(45) NULL ,
  `detalle_producto` VARCHAR(45) NULL ,
  `proveedor_id_proveedor` INT NOT NULL ,
  `precio` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`id_producto`, `proveedor_id_proveedor`) ,
  INDEX `fk_producto_proveedor1_idx` (`proveedor_id_proveedor` ASC) ,
  CONSTRAINT `fk_producto_proveedor1`
    FOREIGN KEY (`proveedor_id_proveedor` )
    REFERENCES `agrosys`.`proveedor` (`id_proveedor` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`rol`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`rol` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`rol` (
  `id_rol` INT NOT NULL AUTO_INCREMENT ,
  `nombre_rol` VARCHAR(45) NULL ,
  `descripcion` VARCHAR(45) NULL ,
  `estado` VARCHAR(45) NULL ,
  PRIMARY KEY (`id_rol`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`usuario` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`usuario` (
  `id_usuario` INT NOT NULL AUTO_INCREMENT ,
  `nombre_usuario` VARCHAR(45) NULL ,
  `password` VARCHAR(45) NULL ,
  `rol_id_rol` INT NOT NULL ,
  `empleado_id_empleado` INT NOT NULL ,
  PRIMARY KEY (`id_usuario`, `rol_id_rol`, `empleado_id_empleado`) ,
  INDEX `fk_usuario_rol1_idx` (`rol_id_rol` ASC) ,
  INDEX `fk_usuario_empleado1_idx` (`empleado_id_empleado` ASC) ,
  CONSTRAINT `fk_usuario_rol1`
    FOREIGN KEY (`rol_id_rol` )
    REFERENCES `agrosys`.`rol` (`id_rol` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuario_empleado1`
    FOREIGN KEY (`empleado_id_empleado` )
    REFERENCES `agrosys`.`empleado` (`id_empleado` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`control_acceso`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`control_acceso` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`control_acceso` (
  `id_control_acceso` INT NOT NULL ,
  `hora` VARCHAR(45) NULL ,
  `fecha` VARCHAR(45) NULL ,
  `usuario_id_usuario` INT NOT NULL ,
  PRIMARY KEY (`id_control_acceso`, `usuario_id_usuario`) ,
  INDEX `fk_control_acceso_usuario1_idx` (`usuario_id_usuario` ASC) ,
  CONSTRAINT `fk_control_acceso_usuario1`
    FOREIGN KEY (`usuario_id_usuario` )
    REFERENCES `agrosys`.`usuario` (`id_usuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`pedido_cliente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`pedido_cliente` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`pedido_cliente` (
  `id_pedido_cliente` INT NOT NULL AUTO_INCREMENT ,
  `fecha` DATE NULL ,
  `hora` TIME NULL ,
  `cliente_id_cliente` INT NOT NULL ,
  PRIMARY KEY (`id_pedido_cliente`, `cliente_id_cliente`) ,
  INDEX `fk_pedido_cliente_cliente1_idx` (`cliente_id_cliente` ASC) ,
  CONSTRAINT `fk_pedido_cliente_cliente1`
    FOREIGN KEY (`cliente_id_cliente` )
    REFERENCES `agrosys`.`cliente` (`id_cliente` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`factura`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`factura` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`factura` (
  `id_factura` INT NOT NULL AUTO_INCREMENT ,
  `sub_total` VARCHAR(45) NULL ,
  `total` VARCHAR(45) NULL ,
  `iva` VARCHAR(45) NULL ,
  `cliente_id_cliente` INT NOT NULL ,
  `pedido_cliente_id_pedido_cliente` INT NOT NULL ,
  `pedido_cliente_cliente_id_cliente` INT NOT NULL ,
  PRIMARY KEY (`id_factura`, `cliente_id_cliente`, `pedido_cliente_id_pedido_cliente`, `pedido_cliente_cliente_id_cliente`) ,
  INDEX `fk_factura_cliente_idx` (`cliente_id_cliente` ASC) ,
  INDEX `fk_factura_pedido_cliente1_idx` (`pedido_cliente_id_pedido_cliente` ASC, `pedido_cliente_cliente_id_cliente` ASC) ,
  CONSTRAINT `fk_factura_cliente`
    FOREIGN KEY (`cliente_id_cliente` )
    REFERENCES `agrosys`.`cliente` (`id_cliente` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_factura_pedido_cliente1`
    FOREIGN KEY (`pedido_cliente_id_pedido_cliente` , `pedido_cliente_cliente_id_cliente` )
    REFERENCES `agrosys`.`pedido_cliente` (`id_pedido_cliente` , `cliente_id_cliente` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`detalle_factura`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`detalle_factura` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`detalle_factura` (
  `id_detalle_factura` INT NOT NULL ,
  `sub_total` VARCHAR(45) NULL ,
  `cantidad` INT NULL ,
  `factura_id_factura` INT NOT NULL ,
  `producto_id_producto` INT NOT NULL ,
  PRIMARY KEY (`id_detalle_factura`, `factura_id_factura`, `producto_id_producto`) ,
  INDEX `fk_detalle_factura_factura1_idx` (`factura_id_factura` ASC) ,
  INDEX `fk_detalle_factura_producto1_idx` (`producto_id_producto` ASC) ,
  CONSTRAINT `fk_detalle_factura_factura1`
    FOREIGN KEY (`factura_id_factura` )
    REFERENCES `agrosys`.`factura` (`id_factura` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_factura_producto1`
    FOREIGN KEY (`producto_id_producto` )
    REFERENCES `agrosys`.`producto` (`id_producto` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`detalle_pedido_cliente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`detalle_pedido_cliente` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`detalle_pedido_cliente` (
  `id_detalle_pedido_cliente` INT NOT NULL AUTO_INCREMENT ,
  `cantidad` INT NULL ,
  `pedido_cliente_id_pedido_cliente` INT NOT NULL ,
  `producto_id_producto` INT NOT NULL ,
  PRIMARY KEY (`id_detalle_pedido_cliente`, `pedido_cliente_id_pedido_cliente`, `producto_id_producto`) ,
  INDEX `fk_detalle_pedido_cliente_pedido_cliente1_idx` (`pedido_cliente_id_pedido_cliente` ASC) ,
  INDEX `fk_detalle_pedido_cliente_producto1_idx` (`producto_id_producto` ASC) ,
  CONSTRAINT `fk_detalle_pedido_cliente_pedido_cliente1`
    FOREIGN KEY (`pedido_cliente_id_pedido_cliente` )
    REFERENCES `agrosys`.`pedido_cliente` (`id_pedido_cliente` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_pedido_cliente_producto1`
    FOREIGN KEY (`producto_id_producto` )
    REFERENCES `agrosys`.`producto` (`id_producto` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`envio_cliente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`envio_cliente` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`envio_cliente` (
  `id_envio_cliente` INT NOT NULL AUTO_INCREMENT ,
  `fecha` DATE NULL ,
  `hora` TIME NULL ,
  `cliente_id_cliente` INT NOT NULL ,
  PRIMARY KEY (`id_envio_cliente`, `cliente_id_cliente`) ,
  INDEX `fk_envio_cliente_cliente1_idx` (`cliente_id_cliente` ASC) ,
  CONSTRAINT `fk_envio_cliente_cliente1`
    FOREIGN KEY (`cliente_id_cliente` )
    REFERENCES `agrosys`.`cliente` (`id_cliente` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`pedido_tienda`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`pedido_tienda` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`pedido_tienda` (
  `id_pedido_tienda` INT NOT NULL AUTO_INCREMENT ,
  `fecha` DATE NULL ,
  `hora` TIME NULL ,
  `tienda_id_tienda` INT NOT NULL ,
  PRIMARY KEY (`id_pedido_tienda`, `tienda_id_tienda`) ,
  INDEX `fk_pedido_tienda_tienda1_idx` (`tienda_id_tienda` ASC) ,
  CONSTRAINT `fk_pedido_tienda_tienda1`
    FOREIGN KEY (`tienda_id_tienda` )
    REFERENCES `agrosys`.`tienda` (`id_tienda` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`envio_tienda`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`envio_tienda` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`envio_tienda` (
  `id_envio_tienda` INT NOT NULL AUTO_INCREMENT ,
  `fecha` DATE NULL ,
  `hora` TIME NULL ,
  `pedido_tienda_id_pedido_tienda` INT NOT NULL ,
  PRIMARY KEY (`id_envio_tienda`, `pedido_tienda_id_pedido_tienda`) ,
  INDEX `fk_envio_tienda_pedido_tienda1_idx` (`pedido_tienda_id_pedido_tienda` ASC) ,
  CONSTRAINT `fk_envio_tienda_pedido_tienda1`
    FOREIGN KEY (`pedido_tienda_id_pedido_tienda` )
    REFERENCES `agrosys`.`pedido_tienda` (`id_pedido_tienda` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`detalle_pedido_tienda`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`detalle_pedido_tienda` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`detalle_pedido_tienda` (
  `id_detalle_pedido_tienda` INT NOT NULL AUTO_INCREMENT ,
  `cantidad` INT NULL ,
  `pedido_tienda_id_pedido_tienda` INT NOT NULL ,
  PRIMARY KEY (`id_detalle_pedido_tienda`, `pedido_tienda_id_pedido_tienda`) ,
  INDEX `fk_detalle_pedido_tienda_pedido_tienda1_idx` (`pedido_tienda_id_pedido_tienda` ASC) ,
  CONSTRAINT `fk_detalle_pedido_tienda_pedido_tienda1`
    FOREIGN KEY (`pedido_tienda_id_pedido_tienda` )
    REFERENCES `agrosys`.`pedido_tienda` (`id_pedido_tienda` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`inventario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`inventario` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`inventario` (
  `id_inventario` INT NOT NULL AUTO_INCREMENT ,
  `total_productos` INT NULL ,
  `proveedor_id_proveedor` INT NOT NULL ,
  `producto_id_producto` INT NOT NULL ,
  PRIMARY KEY (`id_inventario`, `proveedor_id_proveedor`, `producto_id_producto`) ,
  INDEX `fk_inventario_proveedor1_idx` (`proveedor_id_proveedor` ASC) ,
  INDEX `fk_inventario_producto1_idx` (`producto_id_producto` ASC) ,
  CONSTRAINT `fk_inventario_proveedor1`
    FOREIGN KEY (`proveedor_id_proveedor` )
    REFERENCES `agrosys`.`proveedor` (`id_proveedor` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_inventario_producto1`
    FOREIGN KEY (`producto_id_producto` )
    REFERENCES `agrosys`.`producto` (`id_producto` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`order_de_compra`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`order_de_compra` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`order_de_compra` (
  `id_order_de_compra` INT NOT NULL AUTO_INCREMENT ,
  `fecha` DATE NULL ,
  `hora` TIME NULL ,
  `iva` VARCHAR(45) NULL ,
  `total` VARCHAR(45) NULL ,
  PRIMARY KEY (`id_order_de_compra`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `agrosys`.`detalle_order_de_compra`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `agrosys`.`detalle_order_de_compra` ;

CREATE  TABLE IF NOT EXISTS `agrosys`.`detalle_order_de_compra` (
  `id_detalle_order_de_compra` INT NOT NULL AUTO_INCREMENT ,
  `cantidad` INT NULL ,
  `proveedor_id_proveedor` INT NOT NULL ,
  `order_de_compra_id_order_de_compra` INT NOT NULL ,
  `producto_id_producto` INT NOT NULL ,
  `precio` VARCHAR(45) NULL ,
  `subtotal` VARCHAR(45) NULL ,
  PRIMARY KEY (`id_detalle_order_de_compra`, `proveedor_id_proveedor`, `order_de_compra_id_order_de_compra`, `producto_id_producto`) ,
  INDEX `fk_detalle_order_de_compra_proveedor1_idx` (`proveedor_id_proveedor` ASC) ,
  INDEX `fk_detalle_order_de_compra_order_de_compra1_idx` (`order_de_compra_id_order_de_compra` ASC) ,
  INDEX `fk_detalle_order_de_compra_producto1_idx` (`producto_id_producto` ASC) ,
  CONSTRAINT `fk_detalle_order_de_compra_proveedor1`
    FOREIGN KEY (`proveedor_id_proveedor` )
    REFERENCES `agrosys`.`proveedor` (`id_proveedor` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_order_de_compra_order_de_compra1`
    FOREIGN KEY (`order_de_compra_id_order_de_compra` )
    REFERENCES `agrosys`.`order_de_compra` (`id_order_de_compra` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_order_de_compra_producto1`
    FOREIGN KEY (`producto_id_producto` )
    REFERENCES `agrosys`.`producto` (`id_producto` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
