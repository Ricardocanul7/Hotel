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
            this.Grd_Reservaciones = new System.Windows.Forms.DataGridView();
            this.btn_habitaciones = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_nvatransaccion = new System.Windows.Forms.ToolStripButton();
            this.brn_abrir_caja = new System.Windows.Forms.ToolStripButton();
            this.btn_cerrar_caja = new System.Windows.Forms.ToolStripButton();
            this.btn_reporte_caja = new System.Windows.Forms.ToolStripButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Reservaciones)).BeginInit();
            this.btn_habitaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grd_Reservaciones
            // 
            this.Grd_Reservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Reservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Reservaciones.Location = new System.Drawing.Point(0, 25);
            this.Grd_Reservaciones.Name = "Grd_Reservaciones";
            this.Grd_Reservaciones.Size = new System.Drawing.Size(800, 425);
            this.Grd_Reservaciones.TabIndex = 4;
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nvatransaccion,
            this.toolStripSeparator1,
            this.brn_abrir_caja,
            this.toolStripSeparator2,
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_nvatransaccion
            // 
            this.btn_nvatransaccion.Image = global::Hotel.Properties.Resources.cash;
            this.btn_nvatransaccion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nvatransaccion.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_nvatransaccion.Name = "btn_nvatransaccion";
            this.btn_nvatransaccion.Size = new System.Drawing.Size(135, 22);
            this.btn_nvatransaccion.Text = "Agregar Transacción";
            // 
            // brn_abrir_caja
            // 
            this.brn_abrir_caja.Image = global::Hotel.Properties.Resources._023_ladder;
            this.brn_abrir_caja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brn_abrir_caja.Name = "brn_abrir_caja";
            this.brn_abrir_caja.Size = new System.Drawing.Size(79, 22);
            this.brn_abrir_caja.Text = "Abrir Caja";
            // 
            // btn_cerrar_caja
            // 
            this.btn_cerrar_caja.Image = global::Hotel.Properties.Resources._024_safety_box1;
            this.btn_cerrar_caja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cerrar_caja.Name = "btn_cerrar_caja";
            this.btn_cerrar_caja.Size = new System.Drawing.Size(85, 22);
            this.btn_cerrar_caja.Text = "Cerrar Caja";
            this.btn_cerrar_caja.ToolTipText = "Cerrar Caja";
            // 
            // btn_reporte_caja
            // 
            this.btn_reporte_caja.Image = global::Hotel.Properties.Resources._049_notes1;
            this.btn_reporte_caja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reporte_caja.Name = "btn_reporte_caja";
            this.btn_reporte_caja.Size = new System.Drawing.Size(159, 22);
            this.btn_reporte_caja.Text = "Reporte de transacciones";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(505, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(283, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "<< Aquí se mostrarán las últimas transacciones";
            // 
            // Frm_menu_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Grd_Reservaciones);
            this.Controls.Add(this.btn_habitaciones);
            this.Name = "Frm_menu_caja";
            this.Text = "Caja";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Reservaciones)).EndInit();
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grd_Reservaciones;
        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripButton btn_nvatransaccion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton brn_abrir_caja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_cerrar_caja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_reporte_caja;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}