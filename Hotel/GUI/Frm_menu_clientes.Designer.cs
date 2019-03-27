namespace Hotel.GUI
{
    partial class Frm_menu_clientes
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
            this.btn_eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Actualizar_Empleados = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_buscarclientes = new System.Windows.Forms.ToolStripTextBox();
            this.btn_buscarempleados = new System.Windows.Forms.ToolStripButton();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.btn_habitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
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
            this.btn_eliminar,
            this.toolStripSeparator3,
            this.btn_Actualizar_Empleados,
            this.toolStripSeparator5,
            this.toolStripLabel1,
            this.txt_buscarclientes,
            this.btn_buscarempleados});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(800, 39);
            this.btn_habitaciones.TabIndex = 3;
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
            this.btn_nvoempleado.Size = new System.Drawing.Size(102, 36);
            this.btn_nvoempleado.Text = "Nuevo Cliente";
            this.btn_nvoempleado.Click += new System.EventHandler(this.Agregar_Cliente);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = global::Hotel.Properties.Resources.close;
            this.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(110, 36);
            this.btn_eliminar.Text = "Eliminar Cliente";
            this.btn_eliminar.Click += new System.EventHandler(this.Eliminar_Clientes);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_Actualizar_Empleados
            // 
            this.btn_Actualizar_Empleados.Image = global::Hotel.Properties.Resources._036_edit;
            this.btn_Actualizar_Empleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Actualizar_Empleados.Name = "btn_Actualizar_Empleados";
            this.btn_Actualizar_Empleados.Size = new System.Drawing.Size(120, 36);
            this.btn_Actualizar_Empleados.Text = "Actualiza Clientes";
            this.btn_Actualizar_Empleados.Click += new System.EventHandler(this.Actualizar_Cliente);
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
            // txt_buscarclientes
            // 
            this.txt_buscarclientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscarclientes.Name = "txt_buscarclientes";
            this.txt_buscarclientes.Size = new System.Drawing.Size(150, 39);
            // 
            // btn_buscarempleados
            // 
            this.btn_buscarempleados.Image = global::Hotel.Properties.Resources.icon_search;
            this.btn_buscarempleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_buscarempleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscarempleados.Name = "btn_buscarempleados";
            this.btn_buscarempleados.Size = new System.Drawing.Size(78, 36);
            this.btn_buscarempleados.Text = "Buscar";
            this.btn_buscarempleados.Click += new System.EventHandler(this.Buscar_Clientes);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_clientes.Location = new System.Drawing.Point(0, 39);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(800, 411);
            this.dgv_clientes.TabIndex = 4;
            this.dgv_clientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar_Fila);
            // 
            // Frm_menu_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.btn_habitaciones);
            this.Name = "Frm_menu_clientes";
            this.Text = "Frm_menu_clientes";
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_nvoempleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_eliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Actualizar_Empleados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_buscarclientes;
        private System.Windows.Forms.ToolStripButton btn_buscarempleados;
        private System.Windows.Forms.DataGridView dgv_clientes;
    }
}