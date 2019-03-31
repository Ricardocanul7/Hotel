namespace Hotel.GUI
{
    partial class Frm_Transacciones
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
            this.btn_guardar_transaccion = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbo_tipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_buscar_id = new System.Windows.Forms.Button();
            this.Txt_folio_reserva = new System.Windows.Forms.TextBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_num_transaccion = new System.Windows.Forms.TextBox();
            this.dtp_hora = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar_transaccion
            // 
            this.btn_guardar_transaccion.Image = global::Hotel.Properties.Resources._035_save;
            this.btn_guardar_transaccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar_transaccion.Location = new System.Drawing.Point(211, 363);
            this.btn_guardar_transaccion.Name = "btn_guardar_transaccion";
            this.btn_guardar_transaccion.Size = new System.Drawing.Size(93, 50);
            this.btn_guardar_transaccion.TabIndex = 43;
            this.btn_guardar_transaccion.Text = "       Guardar";
            this.btn_guardar_transaccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar_transaccion.UseVisualStyleBackColor = true;
            this.btn_guardar_transaccion.Click += new System.EventHandler(this.btn_guardar_transaccion_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_hora);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbo_tipo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_buscar_id);
            this.groupBox3.Controls.Add(this.Txt_folio_reserva);
            this.groupBox3.Controls.Add(this.Txt_Descripcion);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtp_fecha);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_monto);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(29, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 225);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agrega una transacción";
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo.FormattingEnabled = true;
            this.cbo_tipo.Location = new System.Drawing.Point(115, 87);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Size = new System.Drawing.Size(232, 21);
            this.cbo_tipo.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tipo de pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Folio de Reserva:";
            // 
            // btn_buscar_id
            // 
            this.btn_buscar_id.FlatAppearance.BorderSize = 0;
            this.btn_buscar_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_id.Image = global::Hotel.Properties.Resources.icon_search;
            this.btn_buscar_id.Location = new System.Drawing.Point(321, 22);
            this.btn_buscar_id.Name = "btn_buscar_id";
            this.btn_buscar_id.Size = new System.Drawing.Size(26, 23);
            this.btn_buscar_id.TabIndex = 28;
            this.btn_buscar_id.UseVisualStyleBackColor = true;
            this.btn_buscar_id.Click += new System.EventHandler(this.btn_buscar_id_Click);
            // 
            // Txt_folio_reserva
            // 
            this.Txt_folio_reserva.Location = new System.Drawing.Point(115, 24);
            this.Txt_folio_reserva.Name = "Txt_folio_reserva";
            this.Txt_folio_reserva.Size = new System.Drawing.Size(200, 20);
            this.Txt_folio_reserva.TabIndex = 27;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(115, 179);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(232, 20);
            this.Txt_Descripcion.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descripción:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CustomFormat = "yyyy-MM-dd";
            this.dtp_fecha.Enabled = false;
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(115, 118);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(232, 20);
            this.dtp_fecha.TabIndex = 19;
            this.dtp_fecha.Value = new System.DateTime(2019, 3, 21, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha:";
            // 
            // txt_monto
            // 
            this.txt_monto.Enabled = false;
            this.txt_monto.Location = new System.Drawing.Point(115, 58);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(232, 20);
            this.txt_monto.TabIndex = 16;
            this.txt_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validar_monto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Monto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(29, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 40);
            this.label6.TabIndex = 40;
            this.label6.Text = "TRANSACCIONES";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::Hotel.Properties.Resources.close;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(310, 366);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(95, 47);
            this.btn_cancelar.TabIndex = 46;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_num_transaccion
            // 
            this.txt_num_transaccion.Location = new System.Drawing.Point(340, 86);
            this.txt_num_transaccion.Name = "txt_num_transaccion";
            this.txt_num_transaccion.Size = new System.Drawing.Size(64, 20);
            this.txt_num_transaccion.TabIndex = 39;
            this.txt_num_transaccion.Visible = false;
            // 
            // dtp_hora
            // 
            this.dtp_hora.CustomFormat = "HH:mm:ss";
            this.dtp_hora.Enabled = false;
            this.dtp_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_hora.Location = new System.Drawing.Point(115, 150);
            this.dtp_hora.Name = "dtp_hora";
            this.dtp_hora.Size = new System.Drawing.Size(232, 20);
            this.dtp_hora.TabIndex = 33;
            this.dtp_hora.Value = new System.DateTime(2019, 3, 21, 5, 36, 31, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Hora:";
            // 
            // Frm_Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_num_transaccion);
            this.Controls.Add(this.btn_guardar_transaccion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Name = "Frm_Transacciones";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_guardar_transaccion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_tipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscar_id;
        private System.Windows.Forms.TextBox Txt_folio_reserva;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_num_transaccion;
        private System.Windows.Forms.DateTimePicker dtp_hora;
        private System.Windows.Forms.Label label4;
    }
}