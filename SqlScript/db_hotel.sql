CREATE DATABASE db_hotel;

USE db_hotel;

CREATE TABLE empleado (
    id_empleado int not null AUTO_INCREMENT,
    nombre varchar(35) not null,
    apellido_patern varchar(35) not null,
    apellido_matern varchar(35) not null,
    direccion varchar(100) not null,
    telefono varchar(20) not null,
    horario varchar(30) not null,
    tipo varchar(30) not null,
    PRIMARY KEY(id_empleado)
);

CREATE TABLE habitacion (
    num_habitacion int not null AUTO_INCREMENT,
    nombre varchar(50) not null,
    max_ninios int not null,
    max_adultos int not null,
    precio_alta decimal not null,
    precio_baja decimal not null,
    precio_adic_alta decimal not null,
    precio_adic_baja decimal not null,
    tipo varchar(35) not null,
    descripcion text not null,
    estado varchar(35) not null,
    PRIMARY KEY(num_habitacion)
);

CREATE TABLE limpieza_hab(
    num_habitacion int not null,
    id_empleado int not null,
    PRIMARY KEY(num_habitacion),
    FOREIGN KEY(id_empleado)
      REFERENCES empleado(id_empleado)
);

CREATE TABLE cliente(
  cliente_id int not null AUTO_INCREMENT,
  cliente_nombre varchar(45) not null,
  cliente_apaterno varchar(45) not null,
  cliente_amaterno varchar(45) not null,
  cliente_direccion varchar(100) not null,
  cliente_email varchar(60) not null,
  cliente_telefono varchar(45) not null,
  PRIMARY KEY(cliente_id)
);

CREATE TABLE reservacion(
  folio_reserva int not null AUTO_INCREMENT,
  num_habitacion int not null,
  fecha_entrada DATETIME not null,
  fecha_salida DATETIME not null,
  detalles TEXT,
  cliente int not null,
  PRIMARY KEY(folio_reserva),
  FOREIGN KEY(num_habitacion)
    REFERENCES habitacion(num_habitacion),
  FOREIGN KEY(cliente)
    REFERENCES cliente(cliente_id)
);
