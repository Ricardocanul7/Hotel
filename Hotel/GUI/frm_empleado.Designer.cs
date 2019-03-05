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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_empleado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_idempleado = new System.Windows.Forms.TextBox();
            this.txt_nom_empleado = new System.Windows.Forms.TextBox();
            this.txt_apell_empleado = new System.Windows.Forms.TextBox();
            this.txt_direcc_empleado = new System.Windows.Forms.TextBox();
            this.txt_tele_empleado = new System.Windows.Forms.TextBox();
            this.txt_horario_empleado = new System.Windows.Forms.TextBox();
            this.btn_guar_empleado = new System.Windows.Forms.Button();
            this.btn_cance_empleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.txt_horario_empleado);
            this.groupBox1.Controls.Add(this.txt_tele_empleado);
            this.groupBox1.Controls.Add(this.txt_direcc_empleado);
            this.groupBox1.Controls.Add(this.txt_apell_empleado);
            this.groupBox1.Controls.Add(this.txt_nom_empleado);
            this.groupBox1.Controls.Add(this.txt_idempleado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 189);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Horario:";
            // 
            // txt_idempleado
            // 
            this.txt_idempleado.Location = new System.Drawing.Point(103, 28);
            this.txt_idempleado.Name = "txt_idempleado";
            this.txt_idempleado.Size = new System.Drawing.Size(98, 20);
            this.txt_idempleado.TabIndex = 6;
            // 
            // txt_nom_empleado
            // 
            this.txt_nom_empleado.Location = new System.Drawing.Point(83, 57);
            this.txt_nom_empleado.Name = "txt_nom_empleado";
            this.txt_nom_empleado.Size = new System.Drawing.Size(162, 20);
            this.txt_nom_empleado.TabIndex = 7;
            // 
            // txt_apell_empleado
            // 
            this.txt_apell_empleado.Location = new System.Drawing.Point(316, 57);
            this.txt_apell_empleado.Name = "txt_apell_empleado";
            this.txt_apell_empleado.Size = new System.Drawing.Size(162, 20);
            this.txt_apell_empleado.TabIndex = 8;
            // 
            // txt_direcc_empleado
            // 
            this.txt_direcc_empleado.Location = new System.Drawing.Point(83, 92);
            this.txt_direcc_empleado.Name = "txt_direcc_empleado";
            this.txt_direcc_empleado.Size = new System.Drawing.Size(279, 20);
            this.txt_direcc_empleado.TabIndex = 9;
            // 
            // txt_tele_empleado
            // 
            this.txt_tele_empleado.Location = new System.Drawing.Point(83, 123);
            this.txt_tele_empleado.Name = "txt_tele_empleado";
            this.txt_tele_empleado.Size = new System.Drawing.Size(202, 20);
            this.txt_tele_empleado.TabIndex = 10;
            // 
            // txt_horario_empleado
            // 
            this.txt_horario_empleado.Location = new System.Drawing.Point(83, 159);
            this.txt_horario_empleado.Name = "txt_horario_empleado";
            this.txt_horario_empleado.Size = new System.Drawing.Size(202, 20);
            this.txt_horario_empleado.TabIndex = 11;
            // 
            // btn_guar_empleado
            // 
            this.btn_guar_empleado.Image = ((System.Drawing.Image)(resources.GetObject("btn_guar_empleado.Image")));
            this.btn_guar_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guar_empleado.Location = new System.Drawing.Point(298, 296);
            this.btn_guar_empleado.Name = "btn_guar_empleado";
            this.btn_guar_empleado.Size = new System.Drawing.Size(75, 32);
            this.btn_guar_empleado.TabIndex = 13;
            this.btn_guar_empleado.Text = "       Guardar";
            this.btn_guar_empleado.UseVisualStyleBackColor = true;
            // 
            // btn_cance_empleado
            // 
            this.btn_cance_empleado.Image = ((System.Drawing.Image)(resources.GetObject("btn_cance_empleado.Image")));
            this.btn_cance_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cance_empleado.Location = new System.Drawing.Point(398, 296);
            this.btn_cance_empleado.Name = "btn_cance_empleado";
            this.btn_cance_empleado.Size = new System.Drawing.Size(79, 32);
            this.btn_cance_empleado.TabIndex = 14;
            this.btn_cance_empleado.Text = "     Cancelar";
            this.btn_cance_empleado.UseVisualStyleBackColor = true;
            // 
            // frm_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 340);
            this.Controls.Add(this.btn_cance_empleado);
            this.Controls.Add(this.btn_guar_empleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_empleado";
            this.Text = "frm_empleado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_horario_empleado;
        private System.Windows.Forms.TextBox txt_tele_empleado;
        private System.Windows.Forms.TextBox txt_direcc_empleado;
        private System.Windows.Forms.TextBox txt_apell_empleado;
        private System.Windows.Forms.TextBox txt_nom_empleado;
        private System.Windows.Forms.TextBox txt_idempleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_guar_empleado;
        private System.Windows.Forms.Button btn_cance_empleado;
    }
}