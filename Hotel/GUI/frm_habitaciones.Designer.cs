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
            this.txt_hab_descripcion = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_hab_preciopad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_hab_preciotb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_hab_preciopata = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_hab_preciota = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_tipohab = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numx_per = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cant_hab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombrehab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hab_guardar = new System.Windows.Forms.Button();
            this.btn_hab_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripción:";
            // 
            // txt_hab_descripcion
            // 
            this.txt_hab_descripcion.Location = new System.Drawing.Point(37, 349);
            this.txt_hab_descripcion.Name = "txt_hab_descripcion";
            this.txt_hab_descripcion.Size = new System.Drawing.Size(406, 101);
            this.txt_hab_descripcion.TabIndex = 9;
            this.txt_hab_descripcion.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "HABITACIONES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources._039_bed;
            this.pictureBox1.Location = new System.Drawing.Point(40, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_hab_preciopad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_hab_preciotb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(37, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 87);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio Normal";
            // 
            // txt_hab_preciopad
            // 
            this.txt_hab_preciopad.Location = new System.Drawing.Point(101, 53);
            this.txt_hab_preciopad.Name = "txt_hab_preciopad";
            this.txt_hab_preciopad.Size = new System.Drawing.Size(87, 20);
            this.txt_hab_preciopad.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Per. adicional: $";
            // 
            // txt_hab_preciotb
            // 
            this.txt_hab_preciotb.Location = new System.Drawing.Point(101, 27);
            this.txt_hab_preciotb.Name = "txt_hab_preciotb";
            this.txt_hab_preciotb.Size = new System.Drawing.Size(87, 20);
            this.txt_hab_preciotb.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Precio: $";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_hab_preciopata);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_hab_preciota);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(243, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 87);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precio Temp. Alta";
            // 
            // txt_hab_preciopata
            // 
            this.txt_hab_preciopata.Location = new System.Drawing.Point(101, 53);
            this.txt_hab_preciopata.Name = "txt_hab_preciopata";
            this.txt_hab_preciopata.Size = new System.Drawing.Size(87, 20);
            this.txt_hab_preciopata.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Per. adicional: $";
            // 
            // txt_hab_preciota
            // 
            this.txt_hab_preciota.Location = new System.Drawing.Point(101, 27);
            this.txt_hab_preciota.Name = "txt_hab_preciota";
            this.txt_hab_preciota.Size = new System.Drawing.Size(87, 20);
            this.txt_hab_preciota.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Precio: $";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_tipohab);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_numx_per);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_cant_hab);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_nombrehab);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(37, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 136);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la habitación";
            // 
            // cmb_tipohab
            // 
            this.cmb_tipohab.FormattingEnabled = true;
            this.cmb_tipohab.Location = new System.Drawing.Point(151, 100);
            this.cmb_tipohab.Name = "cmb_tipohab";
            this.cmb_tipohab.Size = new System.Drawing.Size(241, 21);
            this.cmb_tipohab.TabIndex = 15;
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
            // txt_numx_per
            // 
            this.txt_numx_per.Location = new System.Drawing.Point(329, 63);
            this.txt_numx_per.Name = "txt_numx_per";
            this.txt_numx_per.Size = new System.Drawing.Size(63, 20);
            this.txt_numx_per.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Num. Max. personas";
            // 
            // txt_cant_hab
            // 
            this.txt_cant_hab.Location = new System.Drawing.Point(151, 63);
            this.txt_cant_hab.Name = "txt_cant_hab";
            this.txt_cant_hab.Size = new System.Drawing.Size(64, 20);
            this.txt_cant_hab.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad de habitaciones:";
            // 
            // txt_nombrehab
            // 
            this.txt_nombrehab.Location = new System.Drawing.Point(68, 29);
            this.txt_nombrehab.Name = "txt_nombrehab";
            this.txt_nombrehab.Size = new System.Drawing.Size(326, 20);
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
            // btn_hab_guardar
            // 
            this.btn_hab_guardar.Location = new System.Drawing.Point(368, 466);
            this.btn_hab_guardar.Name = "btn_hab_guardar";
            this.btn_hab_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_hab_guardar.TabIndex = 24;
            this.btn_hab_guardar.Text = "Guardar";
            this.btn_hab_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_hab_limpiar
            // 
            this.btn_hab_limpiar.Location = new System.Drawing.Point(287, 466);
            this.btn_hab_limpiar.Name = "btn_hab_limpiar";
            this.btn_hab_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_hab_limpiar.TabIndex = 25;
            this.btn_hab_limpiar.Text = "Limpiar";
            this.btn_hab_limpiar.UseVisualStyleBackColor = true;
            // 
            // frm_habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 501);
            this.Controls.Add(this.btn_hab_limpiar);
            this.Controls.Add(this.btn_hab_guardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_hab_descripcion);
            this.Controls.Add(this.label5);
            this.Name = "frm_habitaciones";
            this.Text = "frm_habitaciones";
            this.Load += new System.EventHandler(this.frm_habitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txt_hab_descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_hab_preciopad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_hab_preciotb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_hab_preciopata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_hab_preciota;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_tipohab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_numx_per;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cant_hab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombrehab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hab_guardar;
        private System.Windows.Forms.Button btn_hab_limpiar;
    }
}