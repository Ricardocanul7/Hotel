namespace Hotel.GUI
{
    partial class Frm_menu_caja
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
            this.btn_nvatransaccion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_cerrar_caja = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_reporte_caja = new System.Windows.Forms.ToolStripButton();
            this.dgv_transacciones = new System.Windows.Forms.DataGridView();
            this.btn_habitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nvatransaccion,
            this.toolStripSeparator1,
            this.btn_cerrar_caja,
            this.toolStripSeparator3,
            this.btn_reporte_caja});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(800, 25);
            this.btn_habitaciones.TabIndex = 3;
            this.btn_habitaciones.Text = "Menu";
            // 
            // btn_nvatransaccion
            // 
            this.btn_nvatransaccion.Image = global::Hotel.Properties.Resources.cash;
            this.btn_nvatransaccion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nvatransaccion.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_nvatransaccion.Name = "btn_nvatransaccion";
            this.btn_nvatransaccion.Size = new System.Drawing.Size(135, 22);
            this.btn_nvatransaccion.Text = "Agregar Transacción";
            this.btn_nvatransaccion.Click += new System.EventHandler(this.btn_nvatransaccion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_cerrar_caja
            // 
            this.btn_cerrar_caja.Image = global::Hotel.Properties.Resources._024_safety_box1;
            this.btn_cerrar_caja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cerrar_caja.Name = "btn_cerrar_caja";
            this.btn_cerrar_caja.Size = new System.Drawing.Size(85, 22);
            this.btn_cerrar_caja.Text = "Cerrar Caja";
            this.btn_cerrar_caja.ToolTipText = "Cerrar Caja";
            this.btn_cerrar_caja.Click += new System.EventHandler(this.btn_cerrar_caja_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_reporte_caja
            // 
            this.btn_reporte_caja.Image = global::Hotel.Properties.Resources._049_notes1;
            this.btn_reporte_caja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reporte_caja.Name = "btn_reporte_caja";
            this.btn_reporte_caja.Size = new System.Drawing.Size(159, 22);
            this.btn_reporte_caja.Text = "Reporte de transacciones";
            // 
            // dgv_transacciones
            // 
            this.dgv_transacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transacciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_transacciones.Location = new System.Drawing.Point(0, 25);
            this.dgv_transacciones.Name = "dgv_transacciones";
            this.dgv_transacciones.Size = new System.Drawing.Size(800, 425);
            this.dgv_transacciones.TabIndex = 4;
            this.dgv_transacciones.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.seleccionarRegistro);
            // 
            // Frm_menu_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_transacciones);
            this.Controls.Add(this.btn_habitaciones);
            this.Name = "Frm_menu_caja";
            this.Text = "Caja";
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripButton btn_nvatransaccion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_cerrar_caja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_reporte_caja;
        private System.Windows.Forms.DataGridView dgv_transacciones;
    }
}