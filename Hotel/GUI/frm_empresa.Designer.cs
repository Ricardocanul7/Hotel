namespace Hotel.GUI
{
    partial class frm_empresa
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
            this.txt_precio_hora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre_empresa = new System.Windows.Forms.TextBox();
            this.txt_rfc_empresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 40);
            this.label6.TabIndex = 40;
            this.label6.Text = "EMPRESA";
            // 
            // txt_precio_hora
            // 
            this.txt_precio_hora.Location = new System.Drawing.Point(120, 93);
            this.txt_precio_hora.Name = "txt_precio_hora";
            this.txt_precio_hora.Size = new System.Drawing.Size(232, 20);
            this.txt_precio_hora.TabIndex = 18;
            this.txt_precio_hora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validar_precio);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Precio por Hora :";
            // 
            // txt_nombre_empresa
            // 
            this.txt_nombre_empresa.Location = new System.Drawing.Point(119, 59);
            this.txt_nombre_empresa.Name = "txt_nombre_empresa";
            this.txt_nombre_empresa.Size = new System.Drawing.Size(232, 20);
            this.txt_nombre_empresa.TabIndex = 16;
            // 
            // txt_rfc_empresa
            // 
            this.txt_rfc_empresa.Location = new System.Drawing.Point(120, 31);
            this.txt_rfc_empresa.Name = "txt_rfc_empresa";
            this.txt_rfc_empresa.Size = new System.Drawing.Size(232, 20);
            this.txt_rfc_empresa.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "RFC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_precio_hora);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_nombre_empresa);
            this.groupBox3.Controls.Add(this.txt_rfc_empresa);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(34, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 148);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la Empresa:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(88, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_guardar.Image = global::Hotel.Properties.Resources._035_save;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(365, 267);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(95, 38);
            this.btn_guardar.TabIndex = 43;
            this.btn_guardar.Text = "       Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.Guardar_empresa);
            // 
            // frm_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 328);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Name = "frm_empresa";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_precio_hora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre_empresa;
        private System.Windows.Forms.TextBox txt_rfc_empresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_guardar;
    }
}