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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_Actualizar_Empleados = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_buscarempleados = new System.Windows.Forms.ToolStripTextBox();
            this.btn_buscarempleados = new System.Windows.Forms.ToolStripButton();
            this.btn_agregar_puesto = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
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
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.txt_Actualizar_Empleados,
            this.toolStripSeparator5,
            this.toolStripLabel1,
            this.txt_buscarempleados,
            this.btn_buscarempleados,
            this.btn_agregar_puesto});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(1051, 39);
            this.btn_habitaciones.TabIndex = 2;
            this.btn_habitaciones.Text = "Menu";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_nvoempleado
            // 
            this.btn_nvoempleado.Image = global::Hotel.Properties.Resources.add1;
            this.btn_nvoempleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nvoempleado.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_nvoempleado.Name = "btn_nvoempleado";
            this.btn_nvoempleado.Size = new System.Drawing.Size(118, 36);
            this.btn_nvoempleado.Text = "Nuevo Empleado";
            this.btn_nvoempleado.Click += new System.EventHandler(this.btn_nvoempleado_Click);
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
            this.toolStripButton1.Size = new System.Drawing.Size(126, 36);
            this.toolStripButton1.Text = "Eliminar Empleado";
            this.toolStripButton1.Click += new System.EventHandler(this.Eliminar_Empleado);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // txt_Actualizar_Empleados
            // 
            this.txt_Actualizar_Empleados.Image = global::Hotel.Properties.Resources._036_edit;
            this.txt_Actualizar_Empleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txt_Actualizar_Empleados.Name = "txt_Actualizar_Empleados";
            this.txt_Actualizar_Empleados.Size = new System.Drawing.Size(136, 36);
            this.txt_Actualizar_Empleados.Text = "Actualiza Empleados";
            this.txt_Actualizar_Empleados.Click += new System.EventHandler(this.Modicicar_Empleados);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 36);
            this.toolStripLabel1.Text = "Buscar";
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
            this.btn_buscarempleados.Size = new System.Drawing.Size(78, 36);
            this.btn_buscarempleados.Text = "Buscar";
            this.btn_buscarempleados.Click += new System.EventHandler(this.Buscar_empleados_click);
            // 
            // btn_agregar_puesto
            // 
            this.btn_agregar_puesto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_agregar_puesto.Image = global::Hotel.Properties.Resources.add1;
            this.btn_agregar_puesto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_agregar_puesto.Name = "btn_agregar_puesto";
            this.btn_agregar_puesto.Size = new System.Drawing.Size(63, 36);
            this.btn_agregar_puesto.Text = "Puesto";
            this.btn_agregar_puesto.Click += new System.EventHandler(this.Forms_Puesto);
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
            this.dgv_empleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_empleados.Location = new System.Drawing.Point(0, 39);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.Size = new System.Drawing.Size(1051, 492);
            this.dgv_empleados.TabIndex = 5;
            this.dgv_empleados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar_empleado);
            // 
            // Frm_menu_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 531);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.ToolStripTextBox txt_buscarempleados;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton txt_Actualizar_Empleados;
        private System.Windows.Forms.ToolStripButton btn_agregar_puesto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}