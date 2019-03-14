namespace Hotel.GUI
{
    partial class Frm_menu_empleados
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
            this.btn_habitaciones = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_nvoempleado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_buscarempleados = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_buscarempleados = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.btn_mod_empleado = new System.Windows.Forms.Button();
            this.btn_borrar_empleado = new System.Windows.Forms.Button();
            this.btn_habitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.btn_nvoempleado,
            this.toolStripSeparator1,
            this.btn_buscarempleados,
            this.toolStripSeparator2,
            this.txt_buscarempleados});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(800, 25);
            this.btn_habitaciones.TabIndex = 2;
            this.btn_habitaciones.Text = "Menu";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_nvoempleado
            // 
            this.btn_nvoempleado.Image = global::Hotel.Properties.Resources.add1;
            this.btn_nvoempleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nvoempleado.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_nvoempleado.Name = "btn_nvoempleado";
            this.btn_nvoempleado.Size = new System.Drawing.Size(118, 22);
            this.btn_nvoempleado.Text = "Nuevo Empleado";
            this.btn_nvoempleado.Click += new System.EventHandler(this.btn_nvoempleado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_buscarempleados
            // 
            this.btn_buscarempleados.Image = global::Hotel.Properties.Resources._036_edit;
            this.btn_buscarempleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscarempleados.Name = "btn_buscarempleados";
            this.btn_buscarempleados.Size = new System.Drawing.Size(121, 22);
            this.btn_buscarempleados.Text = "Buscar  Empleado";
            this.btn_buscarempleados.Click += new System.EventHandler(this.Buscar_empleados_click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txt_buscarempleados
            // 
            this.txt_buscarempleados.Name = "txt_buscarempleados";
            this.txt_buscarempleados.Size = new System.Drawing.Size(250, 25);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "<< Aquí van las tablas de los empleados";
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Location = new System.Drawing.Point(13, 29);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.Size = new System.Drawing.Size(775, 361);
            this.dgv_empleados.TabIndex = 5;
            this.dgv_empleados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar_empleado);
            // 
            // btn_mod_empleado
            // 
            this.btn_mod_empleado.Image = global::Hotel.Properties.Resources._036_edit;
            this.btn_mod_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mod_empleado.Location = new System.Drawing.Point(549, 396);
            this.btn_mod_empleado.Name = "btn_mod_empleado";
            this.btn_mod_empleado.Size = new System.Drawing.Size(102, 47);
            this.btn_mod_empleado.TabIndex = 17;
            this.btn_mod_empleado.Text = "Modificar";
            this.btn_mod_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_mod_empleado.UseVisualStyleBackColor = true;
            // 
            // btn_borrar_empleado
            // 
            this.btn_borrar_empleado.Image = global::Hotel.Properties.Resources.close;
            this.btn_borrar_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borrar_empleado.Location = new System.Drawing.Point(672, 396);
            this.btn_borrar_empleado.Name = "btn_borrar_empleado";
            this.btn_borrar_empleado.Size = new System.Drawing.Size(93, 47);
            this.btn_borrar_empleado.TabIndex = 16;
            this.btn_borrar_empleado.Text = "Eliminar";
            this.btn_borrar_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_borrar_empleado.UseVisualStyleBackColor = true;
            // 
            // Frm_menu_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_mod_empleado);
            this.Controls.Add(this.btn_borrar_empleado);
            this.Controls.Add(this.dgv_empleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_habitaciones);
            this.Name = "Frm_menu_empleados";
            this.Text = "Menu Empleados";
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_nvoempleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_buscarempleados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.Button btn_mod_empleado;
        private System.Windows.Forms.Button btn_borrar_empleado;
        private System.Windows.Forms.ToolStripTextBox txt_buscarempleados;
    }
}