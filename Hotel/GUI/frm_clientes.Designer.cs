namespace Hotel.GUI
{
    partial class frm_clientes
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
            this.btn_borrar_cliente = new System.Windows.Forms.Button();
            this.txt_tele_cliente = new System.Windows.Forms.TextBox();
            this.txt_direcc_cliente = new System.Windows.Forms.TextBox();
            this.txt_apell_clinte = new System.Windows.Forms.TextBox();
            this.txt_nom_cliente = new System.Windows.Forms.TextBox();
            this.txt_idcliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_mod_cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_guardar_cliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_borrar_cliente
            // 
            this.btn_borrar_cliente.Image = global::Hotel.Properties.Resources.close;
            this.btn_borrar_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borrar_cliente.Location = new System.Drawing.Point(470, 290);
            this.btn_borrar_cliente.Name = "btn_borrar_cliente";
            this.btn_borrar_cliente.Size = new System.Drawing.Size(93, 47);
            this.btn_borrar_cliente.TabIndex = 20;
            this.btn_borrar_cliente.Text = "Eliminar";
            this.btn_borrar_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_borrar_cliente.UseVisualStyleBackColor = true;
            // 
            // txt_tele_cliente
            // 
            this.txt_tele_cliente.Location = new System.Drawing.Point(97, 150);
            this.txt_tele_cliente.Name = "txt_tele_cliente";
            this.txt_tele_cliente.Size = new System.Drawing.Size(162, 20);
            this.txt_tele_cliente.TabIndex = 10;
            // 
            // txt_direcc_cliente
            // 
            this.txt_direcc_cliente.Location = new System.Drawing.Point(97, 120);
            this.txt_direcc_cliente.Name = "txt_direcc_cliente";
            this.txt_direcc_cliente.Size = new System.Drawing.Size(428, 20);
            this.txt_direcc_cliente.TabIndex = 9;
            // 
            // txt_apell_clinte
            // 
            this.txt_apell_clinte.Location = new System.Drawing.Point(97, 87);
            this.txt_apell_clinte.Name = "txt_apell_clinte";
            this.txt_apell_clinte.Size = new System.Drawing.Size(162, 20);
            this.txt_apell_clinte.TabIndex = 8;
            // 
            // txt_nom_cliente
            // 
            this.txt_nom_cliente.Location = new System.Drawing.Point(97, 57);
            this.txt_nom_cliente.Name = "txt_nom_cliente";
            this.txt_nom_cliente.Size = new System.Drawing.Size(428, 20);
            this.txt_nom_cliente.TabIndex = 7;
            // 
            // txt_idcliente
            // 
            this.txt_idcliente.Location = new System.Drawing.Point(97, 28);
            this.txt_idcliente.Name = "txt_idcliente";
            this.txt_idcliente.Size = new System.Drawing.Size(162, 20);
            this.txt_idcliente.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido paterno:";
            // 
            // btn_mod_cliente
            // 
            this.btn_mod_cliente.Image = global::Hotel.Properties.Resources._036_edit;
            this.btn_mod_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mod_cliente.Location = new System.Drawing.Point(362, 290);
            this.btn_mod_cliente.Name = "btn_mod_cliente";
            this.btn_mod_cliente.Size = new System.Drawing.Size(102, 47);
            this.btn_mod_cliente.TabIndex = 21;
            this.btn_mod_cliente.Text = "Modificar";
            this.btn_mod_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_mod_cliente.UseVisualStyleBackColor = true;
            this.btn_mod_cliente.Click += new System.EventHandler(this.Modificar_clientes);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tele_cliente);
            this.groupBox1.Controls.Add(this.txt_direcc_cliente);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txt_apell_clinte);
            this.groupBox1.Controls.Add(this.txt_nom_cliente);
            this.groupBox1.Controls.Add(this.txt_idcliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 189);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 40);
            this.label6.TabIndex = 17;
            this.label6.Text = "CLIENTES";
            // 
            // btn_guardar_cliente
            // 
            this.btn_guardar_cliente.Image = global::Hotel.Properties.Resources._035_save;
            this.btn_guardar_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar_cliente.Location = new System.Drawing.Point(261, 290);
            this.btn_guardar_cliente.Name = "btn_guardar_cliente";
            this.btn_guardar_cliente.Size = new System.Drawing.Size(95, 47);
            this.btn_guardar_cliente.TabIndex = 19;
            this.btn_guardar_cliente.Text = "       Guardar";
            this.btn_guardar_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar_cliente.UseVisualStyleBackColor = true;
            this.btn_guardar_cliente.Click += new System.EventHandler(this.Guardar_clientes);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources._022_reception;
            this.pictureBox1.Location = new System.Drawing.Point(80, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellido materno:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 8;
            // 
            // frm_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 374);
            this.Controls.Add(this.btn_borrar_cliente);
            this.Controls.Add(this.btn_mod_cliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_guardar_cliente);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_clientes";
            this.Text = "frm_clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_borrar_cliente;
        private System.Windows.Forms.TextBox txt_tele_cliente;
        private System.Windows.Forms.TextBox txt_direcc_cliente;
        private System.Windows.Forms.TextBox txt_apell_clinte;
        private System.Windows.Forms.TextBox txt_nom_cliente;
        private System.Windows.Forms.TextBox txt_idcliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_mod_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_guardar_cliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}