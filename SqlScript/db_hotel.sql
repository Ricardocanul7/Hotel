CREATE DATABASE db_hotel;

USE db_hotel;

CREATE TABLE puesto_empleado(
  puesto varchar(45) not null,
  PRIMARY KEY(puesto)
);

CREATE TABLE empleado (
    id_empleado int not null AUTO_INCREMENT,
    nombre varchar(35) not null,
    apellido_patern varchar(35) not null,
    apellido_matern varchar(35) not null,
    direccion varchar(100) not null,
    telefono varchar(20) not null,
    horario varchar(30) not null,
    puesto varchar(30) not null,
    PRIMARY KEY(id_empleado),
    FOREIGN KEY(puesto)
      REFERENCES puesto_empleado(puesto)
);

CREATE TABLE usuario(
  id_usuario int AUTO_INCREMENT not null,
  email varchar(80) not null,
  password varchar(80) not null,
  PRIMARY KEY(id_usuario)
);

CREATE TABLE usuario_empleado(
  id_usuario int not null,
  id_empleado int not null,
  PRIMARY KEY(id_usuario, id_empleado),
  FOREIGN KEY(id_usuario)
    REFERENCES usuario(id_usuario),
  FOREIGN KEY(id_empleado)
    REFERENCES empleado(id_empleado)
);

CREATE TABLE tipo_habitacion(
  nombre_tipo varchar(45),
  PRIMARY KEY(nombre_tipo)
);

CREATE TABLE estado_habitacion(
  desc_estado varchar(45) not null,
  PRIMARY KEY(desc_estado)
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
    tipo varchar(45) not null,
    descripcion text not null,
    estado varchar(35) not null,
    PRIMARY KEY(num_habitacion),
    FOREIGN KEY(tipo)
      REFERENCES tipo_habitacion(nombre_tipo),
    FOREIGN KEY(estado)
      REFERENCES estado_habitacion(desc_estado)
);

CREATE TABLE limpieza_hab(
    num_habitacion int not null,
    id_empleado int not null,
    fecha_limpieza DATE not null,
    PRIMARY KEY(num_habitacion),
    FOREIGN KEY(num_habitacion)
      REFERENCES habitacion(num_habitacion),
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

CREATE TABLE empresa_mmto(
  rfc_empresa varchar(45) not null,
  nombre_empresa varchar(80) not null,
  PRIMARY KEY(rfc_empresa)
);

CREATE TABLE mantenimiento_hab(
  rfc_empresa varchar(45) not null,
  num_habitacion int not null,
  fecha_mant DATE not null,
  PRIMARY KEY(rfc_empresa, num_habitacion),
  FOREIGN KEY (rfc_empresa)
    REFERENCES empresa_mmto(rfc_empresa),
  FOREIGN KEY (num_habitacion)
    REFERENCES habitacion(num_habitacion)
);

CREATE TABLE tipo_transaccion(
  nombre_transaccion varchar(45) not null,
  PRIMARY KEY(nombre_transaccion)
);

CREATE TABLE transaccion(
  codigo_transaccion int AUTO_INCREMENT not null,
  tipo varchar(45) not null,
  fecha_transaccion DATE not null,
  PRIMARY KEY(codigo_transaccion),
  FOREIGN KEY(tipo)
    REFERENCES tipo_transaccion(nombre_transaccion)
);

CREATE TABLE usuario_transaccion(
  codigo_transaccion int not null,
  id_usuario int not null,
  PRIMARY KEY(codigo_transaccion),
  FOREIGN KEY(id_usuario)
    REFERENCES usuario(id_usuario),
  FOREIGN KEY(codigo_transaccion)
    REFERENCES transaccion(codigo_transaccion)
);
