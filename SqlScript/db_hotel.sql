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
    precio_adicional decimal not null,
    tipo varchar(35) not null,
    descripcion text not null,
    estado varchar(35) not null,
    id_empleado int,
    PRIMARY KEY(num_habitacion),
    FOREIGN KEY(id_empleado)
        REFERENCES empleado(id_empleado)
);
