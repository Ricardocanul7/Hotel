namespace Hotel.GUI
{
    partial class Frm_corte_caja
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
            this.btn_guardar_empresa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbo_usuario = new System.Windows.Forms.ComboBox();
            this.dtp_hora = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_idcorte = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar_empresa
            // 
            this.btn_guardar_empresa.Image = global::Hotel.Properties.Resources._035_save;
            this.btn_guardar_empresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar_empresa.Location = new System.Drawing.Point(274, 282);
            this.btn_guardar_empresa.Name = "btn_guardar_empresa";
            this.btn_guardar_empresa.Size = new System.Drawing.Size(93, 50);
            this.btn_guardar_empresa.TabIndex = 38;
            this.btn_guardar_empresa.Text = "       Guardar";
            this.btn_guardar_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar_empresa.UseVisualStyleBackColor = true;
            this.btn_guardar_empresa.Click += new System.EventHandler(this.btn_guardar_empresa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbo_usuario);
            this.groupBox3.Controls.Add(this.dtp_hora);
            this.groupBox3.Controls.Add(this.dtp_fecha);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_monto);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(28, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 157);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles del Corte";
            // 
            // cbo_usuario
            // 
            this.cbo_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_usuario.FormattingEnabled = true;
            this.cbo_usuario.Location = new System.Drawing.Point(75, 26);
            this.cbo_usuario.Name = "cbo_usuario";
            this.cbo_usuario.Size = new System.Drawing.Size(232, 21);
            this.cbo_usuario.TabIndex = 21;
            this.cbo_usuario.SelectedValueChanged += new System.EventHandler(this.cbo_usuario_SelectedValueChanged);
            // 
            // dtp_hora
            // 
            this.dtp_hora.CustomFormat = "HH:mm:ss";
            this.dtp_hora.Enabled = false;
            this.dtp_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_hora.Location = new System.Drawing.Point(75, 116);
            this.dtp_hora.Name = "dtp_hora";
            this.dtp_hora.Size = new System.Drawing.Size(232, 20);
            this.dtp_hora.TabIndex = 20;
            this.dtp_hora.Value = new System.DateTime(2019, 3, 21, 5, 36, 31, 0);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CustomFormat = "yyyy-MM-dd";
            this.dtp_fecha.Enabled = false;
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(75, 88);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(232, 20);
            this.dtp_fecha.TabIndex = 19;
            this.dtp_fecha.Value = new System.DateTime(2019, 3, 21, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha:";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(75, 59);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(232, 20);
            this.txt_monto.TabIndex = 16;
            this.txt_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validar_monto);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Monto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources._024_safety_box;
            this.pictureBox1.Location = new System.Drawing.Point(28, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 40);
            this.label6.TabIndex = 35;
            this.label6.Text = "CORTE DE CAJA";
            // 
            // txt_idcorte
            // 
            this.txt_idcorte.Location = new System.Drawing.Point(303, 93);
            this.txt_idcorte.Name = "txt_idcorte";
            this.txt_idcorte.Size = new System.Drawing.Size(64, 20);
            this.txt_idcorte.TabIndex = 23;
            this.txt_idcorte.Visible = false;
            // 
            // Frm_corte_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 354);
            this.Controls.Add(this.txt_idcorte);
            this.Controls.Add(this.btn_guardar_empresa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Name = "Frm_corte_caja";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar_empresa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.DateTimePicker dtp_hora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_usuario;
        private System.Windows.Forms.TextBox txt_idcorte;
    }
}