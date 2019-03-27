namespace Hotel.GUI
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
            this.txt_tipo_hab = new System.Windows.Forms.TextBox();
            this.cbo_habitaciones = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_apelli_matern_cli = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Txt_id_cliente = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Txt_telefono_cliente = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.Txt_apell_patern_cliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_nom_cliente = new System.Windows.Forms.TextBox();
            this.Txt_email_cliente = new System.Windows.Forms.Label();
            this.Txt_dir_cliente = new System.Windows.Forms.TextBox();
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
            this.rdb_pago_pendiente = new System.Windows.Forms.RadioButton();
            this.rdb_pagado = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lbl_total_pago = new System.Windows.Forms.Label();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lbl_precio_res = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_num_noches = new System.Windows.Forms.Label();
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
            this.groupBox3.Controls.Add(this.txt_tipo_hab);
            this.groupBox3.Controls.Add(this.cbo_habitaciones);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 167);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la habitación";
            // 
            // txt_tipo_hab
            // 
            this.txt_tipo_hab.Enabled = false;
            this.txt_tipo_hab.Location = new System.Drawing.Point(119, 63);
            this.txt_tipo_hab.Name = "txt_tipo_hab";
            this.txt_tipo_hab.Size = new System.Drawing.Size(241, 20);
            this.txt_tipo_hab.TabIndex = 20;
            // 
            // cbo_habitaciones
            // 
            this.cbo_habitaciones.FormattingEnabled = true;
            this.cbo_habitaciones.Location = new System.Drawing.Point(119, 28);
            this.cbo_habitaciones.Name = "cbo_habitaciones";
            this.cbo_habitaciones.Size = new System.Drawing.Size(241, 21);
            this.cbo_habitaciones.TabIndex = 16;
            this.cbo_habitaciones.SelectedValueChanged += new System.EventHandler(this.cbo_habitaciones_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo de habitación:";
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
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 39);
            this.label6.TabIndex = 26;
            this.label6.Text = "Registro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_apelli_matern_cli);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.Txt_id_cliente);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.Txt_telefono_cliente);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.Txt_apell_patern_cliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_nom_cliente);
            this.groupBox1.Controls.Add(this.Txt_email_cliente);
            this.groupBox1.Controls.Add(this.Txt_dir_cliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 236);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // txt_apelli_matern_cli
            // 
            this.txt_apelli_matern_cli.Location = new System.Drawing.Point(119, 105);
            this.txt_apelli_matern_cli.Name = "txt_apelli_matern_cli";
            this.txt_apelli_matern_cli.Size = new System.Drawing.Size(241, 20);
            this.txt_apelli_matern_cli.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Apellido materno:";
            // 
            // Txt_id_cliente
            // 
            this.Txt_id_cliente.Location = new System.Drawing.Point(119, 23);
            this.Txt_id_cliente.Name = "Txt_id_cliente";
            this.Txt_id_cliente.Size = new System.Drawing.Size(80, 20);
            this.Txt_id_cliente.TabIndex = 22;
            this.Txt_id_cliente.TextChanged += new System.EventHandler(this.Txt_id_cliente_TextChanged);
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
            this.Txt_telefono_cliente.Location = new System.Drawing.Point(119, 194);
            this.Txt_telefono_cliente.Name = "Txt_telefono_cliente";
            this.Txt_telefono_cliente.Size = new System.Drawing.Size(241, 20);
            this.Txt_telefono_cliente.TabIndex = 20;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(119, 165);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(241, 20);
            this.txt_email.TabIndex = 19;
            // 
            // Txt_apell_patern_cliente
            // 
            this.Txt_apell_patern_cliente.Location = new System.Drawing.Point(119, 75);
            this.Txt_apell_patern_cliente.Name = "Txt_apell_patern_cliente";
            this.Txt_apell_patern_cliente.Size = new System.Drawing.Size(241, 20);
            this.Txt_apell_patern_cliente.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Apellido paterno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Teléfono:";
            // 
            // Txt_nom_cliente
            // 
            this.Txt_nom_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Txt_nom_cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_nom_cliente.Location = new System.Drawing.Point(119, 49);
            this.Txt_nom_cliente.Name = "Txt_nom_cliente";
            this.Txt_nom_cliente.Size = new System.Drawing.Size(241, 20);
            this.Txt_nom_cliente.TabIndex = 15;
            this.Txt_nom_cliente.TextChanged += new System.EventHandler(this.Txt_nom_cliente_TextChanged);
            // 
            // Txt_email_cliente
            // 
            this.Txt_email_cliente.AutoSize = true;
            this.Txt_email_cliente.Location = new System.Drawing.Point(17, 168);
            this.Txt_email_cliente.Name = "Txt_email_cliente";
            this.Txt_email_cliente.Size = new System.Drawing.Size(35, 13);
            this.Txt_email_cliente.TabIndex = 14;
            this.Txt_email_cliente.Text = "Email:";
            // 
            // Txt_dir_cliente
            // 
            this.Txt_dir_cliente.Location = new System.Drawing.Point(119, 138);
            this.Txt_dir_cliente.Name = "Txt_dir_cliente";
            this.Txt_dir_cliente.Size = new System.Drawing.Size(241, 20);
            this.Txt_dir_cliente.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 141);
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
            this.groupBox2.Size = new System.Drawing.Size(392, 224);
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
            this.Dtm_checkout.ValueChanged += new System.EventHandler(this.Dtm_checkout_ValueChanged);
            // 
            // Dtm_checkin
            // 
            this.Dtm_checkin.Enabled = false;
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
            this.groupBox4.Controls.Add(this.lbl_num_noches);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.rdb_pago_pendiente);
            this.groupBox4.Controls.Add(this.rdb_pagado);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.Lbl_total_pago);
            this.groupBox4.Controls.Add(this.lbl_iva);
            this.groupBox4.Controls.Add(this.lbl_precio_res);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(410, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 179);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio";
            // 
            // rdb_pago_pendiente
            // 
            this.rdb_pago_pendiente.AutoSize = true;
            this.rdb_pago_pendiente.Location = new System.Drawing.Point(252, 28);
            this.rdb_pago_pendiente.Name = "rdb_pago_pendiente";
            this.rdb_pago_pendiente.Size = new System.Drawing.Size(73, 17);
            this.rdb_pago_pendiente.TabIndex = 54;
            this.rdb_pago_pendiente.TabStop = true;
            this.rdb_pago_pendiente.Text = "Pendiente";
            this.rdb_pago_pendiente.UseVisualStyleBackColor = true;
            // 
            // rdb_pagado
            // 
            this.rdb_pagado.AutoSize = true;
            this.rdb_pagado.Location = new System.Drawing.Point(55, 28);
            this.rdb_pagado.Name = "rdb_pagado";
            this.rdb_pagado.Size = new System.Drawing.Size(62, 17);
            this.rdb_pagado.TabIndex = 53;
            this.rdb_pagado.TabStop = true;
            this.rdb_pagado.Text = "Pagado";
            this.rdb_pagado.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel.Properties.Resources.cash;
            this.pictureBox2.Location = new System.Drawing.Point(20, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // Lbl_total_pago
            // 
            this.Lbl_total_pago.AutoSize = true;
            this.Lbl_total_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_total_pago.ForeColor = System.Drawing.Color.ForestGreen;
            this.Lbl_total_pago.Location = new System.Drawing.Point(248, 130);
            this.Lbl_total_pago.Name = "Lbl_total_pago";
            this.Lbl_total_pago.Size = new System.Drawing.Size(45, 24);
            this.Lbl_total_pago.TabIndex = 49;
            this.Lbl_total_pago.Text = "0.00";
            this.Lbl_total_pago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_iva
            // 
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Location = new System.Drawing.Point(249, 84);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(28, 13);
            this.lbl_iva.TabIndex = 48;
            this.lbl_iva.Text = "0.00";
            this.lbl_iva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_precio_res
            // 
            this.lbl_precio_res.AutoSize = true;
            this.lbl_precio_res.Location = new System.Drawing.Point(249, 60);
            this.lbl_precio_res.Name = "lbl_precio_res";
            this.lbl_precio_res.Size = new System.Drawing.Size(28, 13);
            this.lbl_precio_res.TabIndex = 47;
            this.lbl_precio_res.Text = "0.00";
            this.lbl_precio_res.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.ForestGreen;
            this.label15.Location = new System.Drawing.Point(103, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 24);
            this.label15.TabIndex = 44;
            this.label15.Text = "Total a pagar: $";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(206, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "IVA: $";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(142, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Precio por noche: $";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::Hotel.Properties.Resources.close;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(711, 519);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(95, 47);
            this.btn_cancelar.TabIndex = 45;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_guardar.Image = global::Hotel.Properties.Resources._035_save;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(606, 519);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(95, 47);
            this.btn_guardar.TabIndex = 42;
            this.btn_guardar.Text = "       Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_res_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Cantidad de noches:";
            // 
            // lbl_num_noches
            // 
            this.lbl_num_noches.AutoSize = true;
            this.lbl_num_noches.Location = new System.Drawing.Point(249, 108);
            this.lbl_num_noches.Name = "lbl_num_noches";
            this.lbl_num_noches.Size = new System.Drawing.Size(13, 13);
            this.lbl_num_noches.TabIndex = 56;
            this.lbl_num_noches.Text = "1";
            this.lbl_num_noches.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Frm_reservar_hab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 588);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Name = "Frm_reservar_hab";
            this.Text = " ";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_habitaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_nom_cliente;
        private System.Windows.Forms.Label Txt_email_cliente;
        private System.Windows.Forms.TextBox Txt_dir_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_telefono_cliente;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox Txt_apell_patern_cliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_detalles_reserva;
        private System.Windows.Forms.DateTimePicker Dtm_checkout;
        private System.Windows.Forms.DateTimePicker Dtm_checkin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Lbl_total_pago;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Label lbl_precio_res;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Txt_id_cliente;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_apelli_matern_cli;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_tipo_hab;
        private System.Windows.Forms.RadioButton rdb_pago_pendiente;
        private System.Windows.Forms.RadioButton rdb_pagado;
        private System.Windows.Forms.Label lbl_num_noches;
        private System.Windows.Forms.Label label2;
    }
}