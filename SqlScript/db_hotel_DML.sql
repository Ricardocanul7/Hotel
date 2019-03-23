use db_hotel;

/* Estado de habitacion */
INSERT INTO estado_habitacion (estado) VALUES ('No disponible');
INSERT INTO estado_habitacion (estado) VALUES ('Mantenimiento');
INSERT INTO estado_habitacion (estado) VALUES ('Limpieza');
INSERT INTO estado_habitacion (estado) VALUES ('Disponible');

/* Puesto de empleado */
INSERT INTO puesto_empleado (puesto) VALUES ('Recepcion');
INSERT INTO puesto_empleado (puesto) VALUES ('Limpieza');

/* Tipo de transaccion */
INSERT INTO tipo_transaccion (nombre_transaccion) VALUES ('Efectivo');
INSERT INTO tipo_transaccion (nombre_transaccion) VALUES ('Tarjeta');

/* Tipo de usuario */
INSERT INTO tipo_usuario (nombre) VALUES ('Admin');
INSERT INTO tipo_usuario (nombre) VALUES ('Recepcionista');
INSERT INTO tipo_usuario (nombre) VALUES ('Propietario');

/* Tipo de habitaciones */
INSERT INTO tipo_habitacion (nombre_tipo) VALUES ('Sencilla');
INSERT INTO tipo_habitacion (nombre_tipo) VALUES ('Doble');

/* Estado de reservas
INSERT INTO estado_reserva (estado_nombre) VALUE ('No pagado');
INSERT INTO estado_reserva (estado_nombre) VALUE ('Pagado');
*/