namespace Hotel.GUI
{
    partial class frm_Empresa
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_rfc_empresa = new System.Windows.Forms.TextBox();
            this.txt_nombre_empresa = new System.Windows.Forms.TextBox();
            this.btn_borrar_empresa = new System.Windows.Forms.Button();
            this.btn_mod_empresa = new System.Windows.Forms.Button();
            this.btn_guardar_empresa = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_nombre_empresa);
            this.groupBox3.Controls.Add(this.txt_rfc_empresa);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(51, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 113);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la Empresa:";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(105, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 40);
            this.label6.TabIndex = 31;
            this.label6.Text = "EMPRESA";
            // 
            // txt_rfc_empresa
            // 
            this.txt_rfc_empresa.Location = new System.Drawing.Point(120, 31);
            this.txt_rfc_empresa.Name = "txt_rfc_empresa";
            this.txt_rfc_empresa.Size = new System.Drawing.Size(232, 20);
            this.txt_rfc_empresa.TabIndex = 15;
            // 
            // txt_nombre_empresa
            // 
            this.txt_nombre_empresa.Location = new System.Drawing.Point(119, 59);
            this.txt_nombre_empresa.Name = "txt_nombre_empresa";
            this.txt_nombre_empresa.Size = new System.Drawing.Size(232, 20);
            this.txt_nombre_empresa.TabIndex = 16;
            // 
            // btn_borrar_empresa
            // 
            this.btn_borrar_empresa.Image = global::Hotel.Properties.Resources.close;
            this.btn_borrar_empresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borrar_empresa.Location = new System.Drawing.Point(312, 249);
            this.btn_borrar_empresa.Name = "btn_borrar_empresa";
            this.btn_borrar_empresa.Size = new System.Drawing.Size(91, 50);
            this.btn_borrar_empresa.TabIndex = 35;
            this.btn_borrar_empresa.Text = "Eliminar";
            this.btn_borrar_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_borrar_empresa.UseVisualStyleBackColor = true;
            // 
            // btn_mod_empresa
            // 
            this.btn_mod_empresa.Image = global::Hotel.Properties.Resources._036_edit;
            this.btn_mod_empresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mod_empresa.Location = new System.Drawing.Point(98, 249);
            this.btn_mod_empresa.Name = "btn_mod_empresa";
            this.btn_mod_empresa.Size = new System.Drawing.Size(100, 50);
            this.btn_mod_empresa.TabIndex = 36;
            this.btn_mod_empresa.Text = "Modificar";
            this.btn_mod_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_mod_empresa.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_empresa
            // 
            this.btn_guardar_empresa.Image = global::Hotel.Properties.Resources._035_save;
            this.btn_guardar_empresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar_empresa.Location = new System.Drawing.Point(206, 249);
            this.btn_guardar_empresa.Name = "btn_guardar_empresa";
            this.btn_guardar_empresa.Size = new System.Drawing.Size(93, 50);
            this.btn_guardar_empresa.TabIndex = 34;
            this.btn_guardar_empresa.Text = "       Guardar";
            this.btn_guardar_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar_empresa.UseVisualStyleBackColor = true;
            // 
            // frm_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 352);
            this.Controls.Add(this.btn_borrar_empresa);
            this.Controls.Add(this.btn_mod_empresa);
            this.Controls.Add(this.btn_guardar_empresa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Name = "frm_Empresa";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_nombre_empresa;
        private System.Windows.Forms.TextBox txt_rfc_empresa;
        private System.Windows.Forms.Button btn_borrar_empresa;
        private System.Windows.Forms.Button btn_mod_empresa;
        private System.Windows.Forms.Button btn_guardar_empresa;
    }
}