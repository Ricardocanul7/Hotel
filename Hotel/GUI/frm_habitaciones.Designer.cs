namespace Hotel.GUI
{
    partial class frm_habitaciones
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descripHab = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_precioN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbo_estadohab = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_num_habitacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_max_ninios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_tipohab = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_max_adultos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombrehab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hab_limpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripción:";
            // 
            // txt_descripHab
            // 
            this.txt_descripHab.Location = new System.Drawing.Point(37, 318);
            this.txt_descripHab.Name = "txt_descripHab";
            this.txt_descripHab.Size = new System.Drawing.Size(406, 132);
            this.txt_descripHab.TabIndex = 9;
            this.txt_descripHab.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "HABITACIONES";
            // 
            // txt_precioN
            // 
            this.txt_precioN.Location = new System.Drawing.Point(68, 140);
            this.txt_precioN.Name = "txt_precioN";
            this.txt_precioN.Size = new System.Drawing.Size(174, 20);
            this.txt_precioN.TabIndex = 19;
            this.txt_precioN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validar_Precio);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Precio: $";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_precioN);
            this.groupBox3.Controls.Add(this.cbo_estadohab);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_num_habitacion);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_max_ninios);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbo_tipohab);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_max_adultos);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_nombrehab);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(37, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 199);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la habitación";
            // 
            // cbo_estadohab
            // 
            this.cbo_estadohab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_estadohab.FormattingEnabled = true;
            this.cbo_estadohab.Location = new System.Drawing.Point(125, 100);
            this.cbo_estadohab.Name = "cbo_estadohab";
            this.cbo_estadohab.Size = new System.Drawing.Size(117, 21);
            this.cbo_estadohab.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Estado de habitación:";
            // 
            // txt_num_habitacion
            // 
            this.txt_num_habitacion.Enabled = false;
            this.txt_num_habitacion.Location = new System.Drawing.Point(349, 29);
            this.txt_num_habitacion.Name = "txt_num_habitacion";
            this.txt_num_habitacion.Size = new System.Drawing.Size(45, 20);
            this.txt_num_habitacion.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Número:";
            // 
            // txt_max_ninios
            // 
            this.txt_max_ninios.Location = new System.Drawing.Point(349, 63);
            this.txt_max_ninios.Name = "txt_max_ninios";
            this.txt_max_ninios.Size = new System.Drawing.Size(45, 20);
            this.txt_max_ninios.TabIndex = 17;
            this.txt_max_ninios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validar_maxniños);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Max. niños";
            // 
            // cbo_tipohab
            // 
            this.cbo_tipohab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipohab.FormattingEnabled = true;
            this.cbo_tipohab.Location = new System.Drawing.Point(125, 63);
            this.cbo_tipohab.Name = "cbo_tipohab";
            this.cbo_tipohab.Size = new System.Drawing.Size(117, 21);
            this.cbo_tipohab.TabIndex = 15;
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
            // txt_max_adultos
            // 
            this.txt_max_adultos.Location = new System.Drawing.Point(349, 100);
            this.txt_max_adultos.Name = "txt_max_adultos";
            this.txt_max_adultos.Size = new System.Drawing.Size(45, 20);
            this.txt_max_adultos.TabIndex = 13;
            this.txt_max_adultos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validar_maxadultos);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Max. adultos";
            // 
            // txt_nombrehab
            // 
            this.txt_nombrehab.Location = new System.Drawing.Point(68, 29);
            this.txt_nombrehab.Name = "txt_nombrehab";
            this.txt_nombrehab.Size = new System.Drawing.Size(174, 20);
            this.txt_nombrehab.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // btn_hab_limpiar
            // 
            this.btn_hab_limpiar.Location = new System.Drawing.Point(368, 466);
            this.btn_hab_limpiar.Name = "btn_hab_limpiar";
            this.btn_hab_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_hab_limpiar.TabIndex = 25;
            this.btn_hab_limpiar.Text = "Limpiar";
            this.btn_hab_limpiar.UseVisualStyleBackColor = true;
            this.btn_hab_limpiar.Click += new System.EventHandler(this.btn_hab_limpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources._039_bed;
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_guardar.Location = new System.Drawing.Point(287, 466);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 27;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // frm_habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 501);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_hab_limpiar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_descripHab);
            this.Controls.Add(this.label5);
            this.Name = "frm_habitaciones";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txt_descripHab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_precioN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbo_tipohab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_max_adultos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombrehab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hab_limpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_max_ninios;
        private System.Windows.Forms.TextBox txt_num_habitacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_estadohab;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_guardar;
    }
}