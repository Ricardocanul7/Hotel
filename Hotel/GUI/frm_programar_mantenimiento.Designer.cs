namespace Hotel.GUI
{
    partial class frm_programar_mantenimiento
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
            this.Panel_Principal = new System.Windows.Forms.Panel();
            this.Panel_Izquierdo = new System.Windows.Forms.Panel();
            this.Panel_Derecho = new System.Windows.Forms.Panel();
            this.Panel_Mantenimiento = new System.Windows.Forms.Panel();
            this.Panel_Limpieza = new System.Windows.Forms.Panel();
            this.btn_habitaciones = new System.Windows.Forms.ToolStrip();
            this.btn_nvoempleado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_buscarempleados = new System.Windows.Forms.ToolStripTextBox();
            this.btn_buscarempleados = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.dgv_mantenimiento = new System.Windows.Forms.DataGridView();
            this.dgv_Limpieza = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Principal.SuspendLayout();
            this.Panel_Izquierdo.SuspendLayout();
            this.Panel_Derecho.SuspendLayout();
            this.Panel_Mantenimiento.SuspendLayout();
            this.Panel_Limpieza.SuspendLayout();
            this.btn_habitaciones.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Limpieza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Principal
            // 
            this.Panel_Principal.Controls.Add(this.Panel_Derecho);
            this.Panel_Principal.Controls.Add(this.Panel_Izquierdo);
            this.Panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Principal.Location = new System.Drawing.Point(0, 0);
            this.Panel_Principal.Name = "Panel_Principal";
            this.Panel_Principal.Size = new System.Drawing.Size(809, 450);
            this.Panel_Principal.TabIndex = 0;
            // 
            // Panel_Izquierdo
            // 
            this.Panel_Izquierdo.Controls.Add(this.dgv_mantenimiento);
            this.Panel_Izquierdo.Controls.Add(this.Panel_Mantenimiento);
            this.Panel_Izquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Izquierdo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Izquierdo.Name = "Panel_Izquierdo";
            this.Panel_Izquierdo.Size = new System.Drawing.Size(500, 450);
            this.Panel_Izquierdo.TabIndex = 0;
            // 
            // Panel_Derecho
            // 
            this.Panel_Derecho.BackColor = System.Drawing.SystemColors.Menu;
            this.Panel_Derecho.Controls.Add(this.dgv_Limpieza);
            this.Panel_Derecho.Controls.Add(this.Panel_Limpieza);
            this.Panel_Derecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Derecho.Location = new System.Drawing.Point(309, 0);
            this.Panel_Derecho.Name = "Panel_Derecho";
            this.Panel_Derecho.Size = new System.Drawing.Size(500, 450);
            this.Panel_Derecho.TabIndex = 1;
            // 
            // Panel_Mantenimiento
            // 
            this.Panel_Mantenimiento.Controls.Add(this.pictureBox1);
            this.Panel_Mantenimiento.Controls.Add(this.btn_habitaciones);
            this.Panel_Mantenimiento.Controls.Add(this.label6);
            this.Panel_Mantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Mantenimiento.Location = new System.Drawing.Point(0, 0);
            this.Panel_Mantenimiento.Name = "Panel_Mantenimiento";
            this.Panel_Mantenimiento.Size = new System.Drawing.Size(500, 116);
            this.Panel_Mantenimiento.TabIndex = 1;
            // 
            // Panel_Limpieza
            // 
            this.Panel_Limpieza.Controls.Add(this.pictureBox2);
            this.Panel_Limpieza.Controls.Add(this.label1);
            this.Panel_Limpieza.Controls.Add(this.toolStrip1);
            this.Panel_Limpieza.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Limpieza.Location = new System.Drawing.Point(0, 0);
            this.Panel_Limpieza.Name = "Panel_Limpieza";
            this.Panel_Limpieza.Size = new System.Drawing.Size(500, 116);
            this.Panel_Limpieza.TabIndex = 1;
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nvoempleado,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.txt_buscarempleados,
            this.btn_buscarempleados});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(500, 39);
            this.btn_habitaciones.TabIndex = 3;
            this.btn_habitaciones.Text = "Menu";
            // 
            // btn_nvoempleado
            // 
            this.btn_nvoempleado.Image = global::Hotel.Properties.Resources._031_broom1;
            this.btn_nvoempleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nvoempleado.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_nvoempleado.Name = "btn_nvoempleado";
            this.btn_nvoempleado.Size = new System.Drawing.Size(168, 36);
            this.btn_nvoempleado.Text = "Programar Mantenimiento";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Hotel.Properties.Resources.close;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 36);
            this.toolStripButton1.Text = "Eliminar ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // txt_buscarempleados
            // 
            this.txt_buscarempleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscarempleados.Name = "txt_buscarempleados";
            this.txt_buscarempleados.Size = new System.Drawing.Size(150, 39);
            // 
            // btn_buscarempleados
            // 
            this.btn_buscarempleados.Image = global::Hotel.Properties.Resources.icon_search;
            this.btn_buscarempleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_buscarempleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscarempleados.Name = "btn_buscarempleados";
            this.btn_buscarempleados.Size = new System.Drawing.Size(36, 36);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator4,
            this.toolStripTextBox1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(500, 39);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "Menu";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Hotel.Properties.Resources._031_broom1;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(133, 36);
            this.toolStripButton2.Text = "Programar Limpieza";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::Hotel.Properties.Resources.close;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(73, 36);
            this.toolStripButton3.Text = "Eliminar ";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 23);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::Hotel.Properties.Resources.icon_search;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
            // 
            // dgv_mantenimiento
            // 
            this.dgv_mantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_mantenimiento.Location = new System.Drawing.Point(0, 116);
            this.dgv_mantenimiento.Name = "dgv_mantenimiento";
            this.dgv_mantenimiento.Size = new System.Drawing.Size(500, 334);
            this.dgv_mantenimiento.TabIndex = 2;
            // 
            // dgv_Limpieza
            // 
            this.dgv_Limpieza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Limpieza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Limpieza.Location = new System.Drawing.Point(0, 116);
            this.dgv_Limpieza.Name = "dgv_Limpieza";
            this.dgv_Limpieza.Size = new System.Drawing.Size(500, 334);
            this.dgv_Limpieza.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(41, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 40);
            this.label6.TabIndex = 24;
            this.label6.Text = "MANTENIMIENTO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel.Properties.Resources.add;
            this.pictureBox2.Location = new System.Drawing.Point(116, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 66);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 40);
            this.label1.TabIndex = 46;
            this.label1.Text = "LIMPIEZA";
            // 
            // frm_programar_mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.Panel_Principal);
            this.Name = "frm_programar_mantenimiento";
            this.Text = "frm_programar_mantenimiento";
            this.Panel_Principal.ResumeLayout(false);
            this.Panel_Izquierdo.ResumeLayout(false);
            this.Panel_Derecho.ResumeLayout(false);
            this.Panel_Mantenimiento.ResumeLayout(false);
            this.Panel_Mantenimiento.PerformLayout();
            this.Panel_Limpieza.ResumeLayout(false);
            this.Panel_Limpieza.PerformLayout();
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Limpieza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Principal;
        private System.Windows.Forms.Panel Panel_Derecho;
        private System.Windows.Forms.Panel Panel_Izquierdo;
        private System.Windows.Forms.Panel Panel_Mantenimiento;
        private System.Windows.Forms.Panel Panel_Limpieza;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripButton btn_nvoempleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox txt_buscarempleados;
        private System.Windows.Forms.ToolStripButton btn_buscarempleados;
        private System.Windows.Forms.DataGridView dgv_Limpieza;
        private System.Windows.Forms.DataGridView dgv_mantenimiento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}