CREATE DATABASE db_hotel;

USE db_hotel;

CREATE TABLE tipo_usuario(
  tipo_id INT NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY(tipo_id)
);

CREATE TABLE usuario(
  usuario_id INT NOT NULL AUTO_INCREMENT,
  usuario_tipo INT NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  apellido_patern VARCHAR(45) NOT NULL,
  apellido_matern VARCHAR(45) NOT NULL,
  email VARCHAR(85) NOT NULL,
  password VARCHAR(45) NOT NULL,
  PRIMARY KEY(usuario_id),
  FOREIGN KEY(usuario_tipo)
    REFERENCES tipo_usuario(tipo_id)
);

CREATE TABLE puesto_empleado(
  puesto_id INT NOT NULL AUTO_INCREMENT,
  puesto VARCHAR(45) NOT NULL,
  PRIMARY KEY(puesto_id)
);

CREATE TABLE empleado(
  empleado_id INT NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(60) NOT NULL,
  apellido_patern VARCHAR(45) NOT NULL,
  apellido_matern VARCHAR(45) NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  telefono VARCHAR(20) NOT NULL,
  horario VARCHAR(45) NOT NULL,
  sueldo DECIMAL NOT NULL,
  puesto_id INT NOT NULL,
  PRIMARY KEY(empleado_id),
  FOREIGN KEY(puesto_id)
    REFERENCES puesto_empleado(puesto_id)
);

CREATE TABLE tipo_habitacion(
  tipo_id INT NOT NULL AUTO_INCREMENT,
  nombre_tipo VARCHAR(45) NOT NULL,
  PRIMARY KEY(tipo_id)
);

CREATE TABLE estado_habitacion(
  estado_id INT NOT NULL AUTO_INCREMENT,
  estado VARCHAR(45) NOT NULL,
  PRIMARY KEY(estado_id)
);

CREATE TABLE habitacion (
    num_habitacion INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(50) NOT NULL,
    max_ninios INT NOT NULL,
    max_adultos INT NOT NULL,
    precio_alta decimal NOT NULL,
    precio_baja decimal NOT NULL,
    precio_adic_alta REAL NOT NULL,
    precio_adic_baja REAL NOT NULL,
    tipo_hab INT NOT NULL,
    descripcion text NOT NULL,
    estado_hab INT NOT NULL,
    PRIMARY KEY(num_habitacion),
    FOREIGN KEY(tipo_hab)
      REFERENCES tipo_habitacion(tipo_id),
    FOREIGN KEY(estado_hab)
      REFERENCES estado_habitacion(estado_id)
);

CREATE TABLE cliente(
  cliente_id INT NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(45) NOT NULL,
  apaterno VARCHAR(45) NOT NULL,
  amaterno VARCHAR(45) NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  email VARCHAR(60) NOT NULL,
  telefono VARCHAR(45) NOT NULL,
  PRIMARY KEY(cliente_id)
);

CREATE TABLE estado_reserva(
  estado_id INT NOT NULL AUTO_INCREMENT,
  estado_nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY(estado_id)
);

CREATE TABLE reservacion(
  folio_reserva INT NOT NULL AUTO_INCREMENT,
  num_habitacion INT NOT NULL,
  fecha_entrada DATE NOT NULL,
  fecha_salida DATE NOT NULL,
  detalles TEXT,
  estado_reserva INT NOT NULL,
  cliente_id INT NOT NULL,
  PRIMARY KEY(folio_reserva),
  FOREIGN KEY(num_habitacion)
    REFERENCES habitacion(num_habitacion),
  FOREIGN KEY(cliente_id)
    REFERENCES cliente(cliente_id),
  FOREIGN KEY(estado_reserva)
    REFERENCES estado_reserva(estado_id)
);

CREATE TABLE corte_caja(
  corte_id INT NOT NULL AUTO_INCREMENT,
  monto REAL NOT NULL,
  fecha DATE NOT NULL,
  hora TIME NOT NULL,
  usuario_id INT NOT NULL,
  PRIMARY KEY(corte_id),
  FOREIGN KEY(usuario_id)
    REFERENCES usuario(usuario_id)
);

CREATE TABLE tipo_transaccion(
  tipo_id INT NOT NULL AUTO_INCREMENT,
  nombre_transaccion VARCHAR(45) NOT NULL,
  PRIMARY KEY(tipo_id)
);

CREATE TABLE transaccion(
  codigo_transaccion INT AUTO_INCREMENT NOT NULL,
  monto REAL NOT NULL,
  descripcion TEXT NOT NULL,
  fecha DATE NOT NULL,
  tipo INT NOT NULL,
  folio_reserva INT NOT NULL,
  usuario_id INT NOT NULL,
  PRIMARY KEY(codigo_transaccion),
  FOREIGN KEY(tipo)
    REFERENCES tipo_transaccion(tipo_id),
  FOREIGN KEY(folio_reserva)
    REFERENCES reservacion(folio_reserva),
  FOREIGN KEY(usuario_id)
    REFERENCES usuario(usuario_id)
);

CREATE TABLE proveedor(
  rfc_proveedor VARCHAR(45) NOT NULL,
  nombre VARCHAR(80) NOT NULL,
  precio_porhora REAL NOT NULL,
  PRIMARY KEY(rfc_proveedor)
);

CREATE TABLE mantenimiento(
  mantenimiento_id INT NOT NULL AUTO_INCREMENT,
  fecha DATE NOT NULL,
  proveedor_rfc VARCHAR(45) NOT NULL,
  num_habitacion INT NOT NULL,
  PRIMARY KEY(mantenimiento_id),
  FOREIGN KEY(proveedor_rfc)
    REFERENCES proveedor(rfc_proveedor),
  FOREIGN KEY(num_habitacion)
    REFERENCES habitacion(num_habitacion)
);

CREATE TABLE limpieza(
  limpieza_id INT NOT NULL AUTO_INCREMENT,
  fecha DATE NOT NULL,
  empleado_id INT NOT NULL,
  num_habitacion INT NOT NULL,
  PRIMARY KEY(limpieza_id),
  FOREIGN KEY(empleado_id)
    REFERENCES empleado(empleado_id),
  FOREIGN KEY(num_habitacion)
    REFERENCES habitacion(num_habitacion)
);

CREATE TABLE pago_mantenimiento(
  folio_recibo INT NOT NULL AUTO_INCREMENT,
  fecha DATE NOT NULL,
  num_horas TIME NOT NULL,
  mantenimiento_id INT NOT NULL,
  PRIMARY KEY(folio_recibo),
  FOREIGN KEY(mantenimiento_id)
    REFERENCES mantenimiento(mantenimiento_id)
);

CREATE TABLE pago_empleado(
  folio_recibo INT NOT NULL AUTO_INCREMENT,
  fecha DATE NOT NULL,
  empleado_id INT NOT NULL,
  PRIMARY KEY(folio_recibo),
  FOREIGN KEY(empleado_id)
    REFERENCES empleado(empleado_id)
);