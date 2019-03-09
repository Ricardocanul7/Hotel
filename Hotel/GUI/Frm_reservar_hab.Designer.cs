﻿namespace Hotel.GUI
{
    partial class Frm_reservar_hab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cmb_numpax = new System.Windows.Forms.ComboBox();
            this.Cmb_habitaciones = new System.Windows.Forms.ComboBox();
            this.Cmb_tipohab = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_id_cliente = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Txt_telefono_cliente = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Txt_apellido_cliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.Txt_email_cliente = new System.Windows.Forms.Label();
            this.Txt_direccion_cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_detalles_reserva = new System.Windows.Forms.TextBox();
            this.Dtm_checkout = new System.Windows.Forms.DateTimePicker();
            this.Dtm_checkin = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lbl_precio_desc = new System.Windows.Forms.Label();
            this.Lbl_anticipo = new System.Windows.Forms.Label();
            this.Lbl_total_pago = new System.Windows.Forms.Label();
            this.Lbl_precio_adpax = new System.Windows.Forms.Label();
            this.Lbl_precio_res = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_imprimir_res = new System.Windows.Forms.Button();
            this.btn_mod_res = new System.Windows.Forms.Button();
            this.btn_borrar_res = new System.Windows.Forms.Button();
            this.btn_guardar_res = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cmb_numpax);
            this.groupBox3.Controls.Add(this.Cmb_habitaciones);
            this.groupBox3.Controls.Add(this.Cmb_tipohab);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 136);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la habitación";
            // 
            // Cmb_numpax
            // 
            this.Cmb_numpax.FormattingEnabled = true;
            this.Cmb_numpax.Location = new System.Drawing.Point(119, 62);
            this.Cmb_numpax.Name = "Cmb_numpax";
            this.Cmb_numpax.Size = new System.Drawing.Size(83, 21);
            this.Cmb_numpax.TabIndex = 17;
            // 
            // Cmb_habitaciones
            // 
            this.Cmb_habitaciones.FormattingEnabled = true;
            this.Cmb_habitaciones.Location = new System.Drawing.Point(119, 28);
            this.Cmb_habitaciones.Name = "Cmb_habitaciones";
            this.Cmb_habitaciones.Size = new System.Drawing.Size(241, 21);
            this.Cmb_habitaciones.TabIndex = 16;
            // 
            // Cmb_tipohab
            // 
            this.Cmb_tipohab.FormattingEnabled = true;
            this.Cmb_tipohab.Location = new System.Drawing.Point(119, 100);
            this.Cmb_tipohab.Name = "Cmb_tipohab";
            this.Cmb_tipohab.Size = new System.Drawing.Size(241, 21);
            this.Cmb_tipohab.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo de habitación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Num. Personas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Habitación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 40);
            this.label6.TabIndex = 26;
            this.label6.Text = "Reservar Habitación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_id_cliente);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.Txt_telefono_cliente);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.Txt_apellido_cliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_nombre_cliente);
            this.groupBox1.Controls.Add(this.Txt_email_cliente);
            this.groupBox1.Controls.Add(this.Txt_direccion_cliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 192);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // Txt_id_cliente
            // 
            this.Txt_id_cliente.Location = new System.Drawing.Point(88, 23);
            this.Txt_id_cliente.Name = "Txt_id_cliente";
            this.Txt_id_cliente.Size = new System.Drawing.Size(80, 20);
            this.Txt_id_cliente.TabIndex = 22;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 21;
            this.label23.Text = "ID Cliente:";
            // 
            // Txt_telefono_cliente
            // 
            this.Txt_telefono_cliente.Location = new System.Drawing.Point(88, 157);
            this.Txt_telefono_cliente.Name = "Txt_telefono_cliente";
            this.Txt_telefono_cliente.Size = new System.Drawing.Size(272, 20);
            this.Txt_telefono_cliente.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(88, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(272, 20);
            this.textBox4.TabIndex = 19;
            // 
            // Txt_apellido_cliente
            // 
            this.Txt_apellido_cliente.Location = new System.Drawing.Point(88, 75);
            this.Txt_apellido_cliente.Name = "Txt_apellido_cliente";
            this.Txt_apellido_cliente.Size = new System.Drawing.Size(272, 20);
            this.Txt_apellido_cliente.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Apellidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Teléfono:";
            // 
            // Txt_nombre_cliente
            // 
            this.Txt_nombre_cliente.Location = new System.Drawing.Point(88, 49);
            this.Txt_nombre_cliente.Name = "Txt_nombre_cliente";
            this.Txt_nombre_cliente.Size = new System.Drawing.Size(272, 20);
            this.Txt_nombre_cliente.TabIndex = 15;
            // 
            // Txt_email_cliente
            // 
            this.Txt_email_cliente.AutoSize = true;
            this.Txt_email_cliente.Location = new System.Drawing.Point(17, 131);
            this.Txt_email_cliente.Name = "Txt_email_cliente";
            this.Txt_email_cliente.Size = new System.Drawing.Size(35, 13);
            this.Txt_email_cliente.TabIndex = 14;
            this.Txt_email_cliente.Text = "Email:";
            // 
            // Txt_direccion_cliente
            // 
            this.Txt_direccion_cliente.Location = new System.Drawing.Point(88, 101);
            this.Txt_direccion_cliente.Name = "Txt_direccion_cliente";
            this.Txt_direccion_cliente.Size = new System.Drawing.Size(272, 20);
            this.Txt_direccion_cliente.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_detalles_reserva);
            this.groupBox2.Controls.Add(this.Dtm_checkout);
            this.groupBox2.Controls.Add(this.Dtm_checkin);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(410, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 202);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la reservación";
            // 
            // Txt_detalles_reserva
            // 
            this.Txt_detalles_reserva.Location = new System.Drawing.Point(18, 116);
            this.Txt_detalles_reserva.Multiline = true;
            this.Txt_detalles_reserva.Name = "Txt_detalles_reserva";
            this.Txt_detalles_reserva.Size = new System.Drawing.Size(323, 66);
            this.Txt_detalles_reserva.TabIndex = 17;
            // 
            // Dtm_checkout
            // 
            this.Dtm_checkout.Location = new System.Drawing.Point(141, 63);
            this.Dtm_checkout.Name = "Dtm_checkout";
            this.Dtm_checkout.Size = new System.Drawing.Size(200, 20);
            this.Dtm_checkout.TabIndex = 16;
            // 
            // Dtm_checkin
            // 
            this.Dtm_checkin.Location = new System.Drawing.Point(141, 28);
            this.Dtm_checkin.Name = "Dtm_checkin";
            this.Dtm_checkin.Size = new System.Drawing.Size(200, 20);
            this.Dtm_checkin.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Detalles de la reserva:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Fecha de salida:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Fecha de entrada:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.Lbl_precio_desc);
            this.groupBox4.Controls.Add(this.Lbl_anticipo);
            this.groupBox4.Controls.Add(this.Lbl_total_pago);
            this.groupBox4.Controls.Add(this.Lbl_precio_adpax);
            this.groupBox4.Controls.Add(this.Lbl_precio_res);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(410, 304);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 128);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel.Properties.Resources.cash;
            this.pictureBox2.Location = new System.Drawing.Point(18, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // Lbl_precio_desc
            // 
            this.Lbl_precio_desc.AutoSize = true;
            this.Lbl_precio_desc.ForeColor = System.Drawing.Color.Brown;
            this.Lbl_precio_desc.Location = new System.Drawing.Point(300, 60);
            this.Lbl_precio_desc.Name = "Lbl_precio_desc";
            this.Lbl_precio_desc.Size = new System.Drawing.Size(28, 13);
            this.Lbl_precio_desc.TabIndex = 51;
            this.Lbl_precio_desc.Text = "0.00";
            this.Lbl_precio_desc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_anticipo
            // 
            this.Lbl_anticipo.AutoSize = true;
            this.Lbl_anticipo.ForeColor = System.Drawing.Color.OrangeRed;
            this.Lbl_anticipo.Location = new System.Drawing.Point(279, 82);
            this.Lbl_anticipo.Name = "Lbl_anticipo";
            this.Lbl_anticipo.Size = new System.Drawing.Size(49, 13);
            this.Lbl_anticipo.TabIndex = 50;
            this.Lbl_anticipo.Text = "2,700.00";
            this.Lbl_anticipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_total_pago
            // 
            this.Lbl_total_pago.AutoSize = true;
            this.Lbl_total_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_total_pago.ForeColor = System.Drawing.Color.ForestGreen;
            this.Lbl_total_pago.Location = new System.Drawing.Point(248, 99);
            this.Lbl_total_pago.Name = "Lbl_total_pago";
            this.Lbl_total_pago.Size = new System.Drawing.Size(80, 24);
            this.Lbl_total_pago.TabIndex = 49;
            this.Lbl_total_pago.Text = "2,700.00";
            this.Lbl_total_pago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_precio_adpax
            // 
            this.Lbl_precio_adpax.AutoSize = true;
            this.Lbl_precio_adpax.Location = new System.Drawing.Point(288, 36);
            this.Lbl_precio_adpax.Name = "Lbl_precio_adpax";
            this.Lbl_precio_adpax.Size = new System.Drawing.Size(40, 13);
            this.Lbl_precio_adpax.TabIndex = 48;
            this.Lbl_precio_adpax.Text = "400.00";
            this.Lbl_precio_adpax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_precio_res
            // 
            this.Lbl_precio_res.AutoSize = true;
            this.Lbl_precio_res.Location = new System.Drawing.Point(279, 14);
            this.Lbl_precio_res.Name = "Lbl_precio_res";
            this.Lbl_precio_res.Size = new System.Drawing.Size(49, 13);
            this.Lbl_precio_res.TabIndex = 47;
            this.Lbl_precio_res.Text = "5,000.00";
            this.Lbl_precio_res.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Brown;
            this.label17.Location = new System.Drawing.Point(171, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Descuento: $";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.OrangeRed;
            this.label16.Location = new System.Drawing.Point(185, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Anticipo: $";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.ForestGreen;
            this.label15.Location = new System.Drawing.Point(103, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 24);
            this.label15.TabIndex = 44;
            this.label15.Text = "Total a pagar: $";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(95, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Adicional por persona extra: $";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(193, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Precio: $";
            // 
            // btn_imprimir_res
            // 
            this.btn_imprimir_res.Image = global::Hotel.Properties.Resources._049_notes1;
            this.btn_imprimir_res.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imprimir_res.Location = new System.Drawing.Point(656, 450);
            this.btn_imprimir_res.Name = "btn_imprimir_res";
            this.btn_imprimir_res.Size = new System.Drawing.Size(95, 47);
            this.btn_imprimir_res.TabIndex = 45;
            this.btn_imprimir_res.Text = "Imprimir";
            this.btn_imprimir_res.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimir_res.UseVisualStyleBackColor = true;
            // 
            // btn_mod_res
            // 
            this.btn_mod_res.Image = global::Hotel.Properties.Resources._036_edit;
            this.btn_mod_res.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mod_res.Location = new System.Drawing.Point(435, 450);
            this.btn_mod_res.Name = "btn_mod_res";
            this.btn_mod_res.Size = new System.Drawing.Size(102, 47);
            this.btn_mod_res.TabIndex = 44;
            this.btn_mod_res.Text = "Modificar";
            this.btn_mod_res.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_mod_res.UseVisualStyleBackColor = true;
            // 
            // btn_borrar_res
            // 
            this.btn_borrar_res.Image = global::Hotel.Properties.Resources.close;
            this.btn_borrar_res.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borrar_res.Location = new System.Drawing.Point(327, 450);
            this.btn_borrar_res.Name = "btn_borrar_res";
            this.btn_borrar_res.Size = new System.Drawing.Size(93, 47);
            this.btn_borrar_res.TabIndex = 43;
            this.btn_borrar_res.Text = "Eliminar";
            this.btn_borrar_res.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_borrar_res.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_res
            // 
            this.btn_guardar_res.Image = global::Hotel.Properties.Resources._035_save;
            this.btn_guardar_res.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar_res.Location = new System.Drawing.Point(551, 450);
            this.btn_guardar_res.Name = "btn_guardar_res";
            this.btn_guardar_res.Size = new System.Drawing.Size(95, 47);
            this.btn_guardar_res.TabIndex = 42;
            this.btn_guardar_res.Text = "       Guardar";
            this.btn_guardar_res.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar_res.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources._039_bed;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_reservar_hab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_imprimir_res);
            this.Controls.Add(this.btn_mod_res);
            this.Controls.Add(this.btn_borrar_res);
            this.Controls.Add(this.btn_guardar_res);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Name = "Frm_reservar_hab";
            this.Text = "Reserva Habitaciones";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox Cmb_tipohab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cmb_habitaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_nombre_cliente;
        private System.Windows.Forms.Label Txt_email_cliente;
        private System.Windows.Forms.TextBox Txt_direccion_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cmb_numpax;
        private System.Windows.Forms.TextBox Txt_telefono_cliente;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox Txt_apellido_cliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_detalles_reserva;
        private System.Windows.Forms.DateTimePicker Dtm_checkout;
        private System.Windows.Forms.DateTimePicker Dtm_checkin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_mod_res;
        private System.Windows.Forms.Button btn_borrar_res;
        private System.Windows.Forms.Button btn_guardar_res;
        private System.Windows.Forms.Button btn_imprimir_res;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Lbl_precio_desc;
        private System.Windows.Forms.Label Lbl_anticipo;
        private System.Windows.Forms.Label Lbl_total_pago;
        private System.Windows.Forms.Label Lbl_precio_adpax;
        private System.Windows.Forms.Label Lbl_precio_res;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Txt_id_cliente;
        private System.Windows.Forms.Label label23;
    }
}