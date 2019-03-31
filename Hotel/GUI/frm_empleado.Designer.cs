namespace Hotel.GUI
{
    partial class frm_empleado
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_sueldoempleado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_tipoempleado = new System.Windows.Forms.ComboBox();
            this.txt_apellidoparteno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_Horario = new System.Windows.Forms.ComboBox();
            this.txt_tele_empleado = new System.Windows.Forms.TextBox();
            this.txt_direcc_empleado = new System.Windows.Forms.TextBox();
            this.txt_apellidomaterno = new System.Windows.Forms.TextBox();
            this.txt_nom_empleado = new System.Windows.Forms.TextBox();
            this.txt_idempleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar_empleado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 40);
            this.label6.TabIndex = 11;
            this.label6.Text = "EMPLEADOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_sueldoempleado);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbo_tipoempleado);
            this.groupBox1.Controls.Add(this.txt_apellidoparteno);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbo_Horario);
            this.groupBox1.Controls.Add(this.txt_tele_empleado);
            this.groupBox1.Controls.Add(this.txt_direcc_empleado);
            this.groupBox1.Controls.Add(this.txt_apellidomaterno);
            this.groupBox1.Controls.Add(this.txt_nom_empleado);
            this.groupBox1.Controls.Add(this.txt_idempleado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 189);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Empleado";
            // 
            // txt_sueldoempleado
            // 
            this.txt_sueldoempleado.Location = new System.Drawing.Point(366, 148);
            this.txt_sueldoempleado.Name = "txt_sueldoempleado";
            this.txt_sueldoempleado.Size = new System.Drawing.Size(162, 20);
            this.txt_sueldoempleado.TabIndex = 18;
            this.txt_sueldoempleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validar_sueldo);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Sueldo:";
            // 
            // cbo_tipoempleado
            // 
            this.cbo_tipoempleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipoempleado.FormattingEnabled = true;
            this.cbo_tipoempleado.Location = new System.Drawing.Point(99, 147);
            this.cbo_tipoempleado.Name = "cbo_tipoempleado";
            this.cbo_tipoempleado.Size = new System.Drawing.Size(190, 21);
            this.cbo_tipoempleado.TabIndex = 16;
            // 
            // txt_apellidoparteno
            // 
            this.txt_apellidoparteno.Location = new System.Drawing.Point(99, 55);
            this.txt_apellidoparteno.Name = "txt_apellidoparteno";
            this.txt_apellidoparteno.Size = new System.Drawing.Size(162, 20);
            this.txt_apellidoparteno.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Apellido Paterno:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Puesto:";
            // 
            // cbo_Horario
            // 
            this.cbo_Horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Horario.FormattingEnabled = true;
            this.cbo_Horario.Items.AddRange(new object[] {
            "8 am - 4 pm",
            "4pm - 12 am",
            "12 am - 8 am"});
            this.cbo_Horario.Location = new System.Drawing.Point(366, 120);
            this.cbo_Horario.Name = "cbo_Horario";
            this.cbo_Horario.Size = new System.Drawing.Size(121, 21);
            this.cbo_Horario.TabIndex = 11;
            // 
            // txt_tele_empleado
            // 
            this.txt_tele_empleado.Location = new System.Drawing.Point(99, 121);
            this.txt_tele_empleado.Name = "txt_tele_empleado";
            this.txt_tele_empleado.Size = new System.Drawing.Size(190, 20);
            this.txt_tele_empleado.TabIndex = 10;
            this.txt_tele_empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validar_telefono);
            // 
            // txt_direcc_empleado
            // 
            this.txt_direcc_empleado.Location = new System.Drawing.Point(99, 90);
            this.txt_direcc_empleado.Name = "txt_direcc_empleado";
            this.txt_direcc_empleado.Size = new System.Drawing.Size(395, 20);
            this.txt_direcc_empleado.TabIndex = 9;
            // 
            // txt_apellidomaterno
            // 
            this.txt_apellidomaterno.Location = new System.Drawing.Point(366, 55);
            this.txt_apellidomaterno.Name = "txt_apellidomaterno";
            this.txt_apellidomaterno.Size = new System.Drawing.Size(162, 20);
            this.txt_apellidomaterno.TabIndex = 8;
            // 
            // txt_nom_empleado
            // 
            this.txt_nom_empleado.Location = new System.Drawing.Point(366, 26);
            this.txt_nom_empleado.Name = "txt_nom_empleado";
            this.txt_nom_empleado.Size = new System.Drawing.Size(162, 20);
            this.txt_nom_empleado.TabIndex = 7;
            // 
            // txt_idempleado
            // 
            this.txt_idempleado.Location = new System.Drawing.Point(99, 26);
            this.txt_idempleado.Name = "txt_idempleado";
            this.txt_idempleado.Size = new System.Drawing.Size(162, 20);
            this.txt_idempleado.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Horario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Empleado:";
            // 
            // btn_guardar_empleado
            // 
            this.btn_guardar_empleado.Image = global::Hotel.Properties.Resources._035_save;
            this.btn_guardar_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar_empleado.Location = new System.Drawing.Point(440, 296);
            this.btn_guardar_empleado.Name = "btn_guardar_empleado";
            this.btn_guardar_empleado.Size = new System.Drawing.Size(95, 47);
            this.btn_guardar_empleado.TabIndex = 13;
            this.btn_guardar_empleado.Text = "       Guardar";
            this.btn_guardar_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar_empleado.UseVisualStyleBackColor = true;
            this.btn_guardar_empleado.Click += new System.EventHandler(this.Guardar_Empleados);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources._022_reception;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frm_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 360);
            this.Controls.Add(this.btn_guardar_empleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_empleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tele_empleado;
        private System.Windows.Forms.TextBox txt_direcc_empleado;
        private System.Windows.Forms.TextBox txt_apellidomaterno;
        private System.Windows.Forms.TextBox txt_nom_empleado;
        private System.Windows.Forms.TextBox txt_idempleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_guardar_empleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_Horario;
        private System.Windows.Forms.TextBox txt_apellidoparteno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_tipoempleado;
        private System.Windows.Forms.TextBox txt_sueldoempleado;
        private System.Windows.Forms.Label label10;
    }
}