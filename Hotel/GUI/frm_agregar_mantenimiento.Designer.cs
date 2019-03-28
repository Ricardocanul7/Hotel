namespace Hotel.GUI
{
    partial class frm_agregar_mantenimiento
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
            this.cbo_num_habitacion = new System.Windows.Forms.ComboBox();
            this.cbo_empresa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_fecha_mantenimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_mantenimiento = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 40);
            this.label6.TabIndex = 22;
            this.label6.Text = "MANTENIMIENTO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_num_habitacion);
            this.groupBox1.Controls.Add(this.cbo_empresa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_fecha_mantenimiento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_id_mantenimiento);
            this.groupBox1.Location = new System.Drawing.Point(35, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 199);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Mantenimiento";
            // 
            // cbo_num_habitacion
            // 
            this.cbo_num_habitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_num_habitacion.FormattingEnabled = true;
            this.cbo_num_habitacion.Location = new System.Drawing.Point(112, 149);
            this.cbo_num_habitacion.Name = "cbo_num_habitacion";
            this.cbo_num_habitacion.Size = new System.Drawing.Size(137, 21);
            this.cbo_num_habitacion.TabIndex = 30;
            // 
            // cbo_empresa
            // 
            this.cbo_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empresa.FormattingEnabled = true;
            this.cbo_empresa.Location = new System.Drawing.Point(112, 112);
            this.cbo_empresa.Name = "cbo_empresa";
            this.cbo_empresa.Size = new System.Drawing.Size(137, 21);
            this.cbo_empresa.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Num. Habitacion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Empresa :";
            // 
            // dtp_fecha_mantenimiento
            // 
            this.dtp_fecha_mantenimiento.Location = new System.Drawing.Point(112, 69);
            this.dtp_fecha_mantenimiento.Name = "dtp_fecha_mantenimiento";
            this.dtp_fecha_mantenimiento.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_mantenimiento.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID :";
            // 
            // txt_id_mantenimiento
            // 
            this.txt_id_mantenimiento.Enabled = false;
            this.txt_id_mantenimiento.Location = new System.Drawing.Point(112, 34);
            this.txt_id_mantenimiento.Name = "txt_id_mantenimiento";
            this.txt_id_mantenimiento.Size = new System.Drawing.Size(40, 20);
            this.txt_id_mantenimiento.TabIndex = 0;
            // 
            // btn_guardar
            // 
            this.btn_guardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_guardar.Image = global::Hotel.Properties.Resources._035_save;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(390, 320);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(95, 47);
            this.btn_guardar.TabIndex = 43;
            this.btn_guardar.Text = "       Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(82, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frm_agregar_mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 378);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Name = "frm_agregar_mantenimiento";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_fecha_mantenimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_mantenimiento;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cbo_num_habitacion;
        private System.Windows.Forms.ComboBox cbo_empresa;
    }
}