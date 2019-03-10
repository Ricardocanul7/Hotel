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
            this.lbl_reservaciones_title = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_nvoempleado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_actua_empleado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Dgr_empleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_habitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImageScalingSize = new System.Drawing.Size(42, 42);
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_reservaciones_title,
            this.toolStripSeparator4,
            this.btn_nvoempleado,
            this.toolStripSeparator1,
            this.btn_actua_empleado,
            this.toolStripSeparator2});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(800, 49);
            this.btn_habitaciones.TabIndex = 2;
            this.btn_habitaciones.Text = "Menu";
            // 
            // lbl_reservaciones_title
            // 
            this.lbl_reservaciones_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_reservaciones_title.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_reservaciones_title.Name = "lbl_reservaciones_title";
            this.lbl_reservaciones_title.Size = new System.Drawing.Size(157, 46);
            this.lbl_reservaciones_title.Text = "EMPLEADOS";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 49);
            // 
            // btn_nvoempleado
            // 
            this.btn_nvoempleado.Image = global::Hotel.Properties.Resources._025_hotel_bell;
            this.btn_nvoempleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nvoempleado.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_nvoempleado.Name = "btn_nvoempleado";
            this.btn_nvoempleado.Size = new System.Drawing.Size(144, 46);
            this.btn_nvoempleado.Text = "Nuevo Empleado";
            this.btn_nvoempleado.Click += new System.EventHandler(this.btn_nvoempleado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // btn_actua_empleado
            // 
            this.btn_actua_empleado.Image = global::Hotel.Properties.Resources._036_edit;
            this.btn_actua_empleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_actua_empleado.Name = "btn_actua_empleado";
            this.btn_actua_empleado.Size = new System.Drawing.Size(161, 46);
            this.btn_actua_empleado.Text = "Actualizar Empleado";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 49);
            // 
            // Dgr_empleados
            // 
            this.Dgr_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgr_empleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgr_empleados.Location = new System.Drawing.Point(0, 49);
            this.Dgr_empleados.Name = "Dgr_empleados";
            this.Dgr_empleados.Size = new System.Drawing.Size(800, 401);
            this.Dgr_empleados.TabIndex = 3;
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
            // Frm_menu_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgr_empleados);
            this.Controls.Add(this.btn_habitaciones);
            this.Name = "Frm_menu_empleados";
            this.Text = "Menu Empleados";
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripLabel lbl_reservaciones_title;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_nvoempleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_actua_empleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView Dgr_empleados;
        private System.Windows.Forms.Label label1;
    }
}