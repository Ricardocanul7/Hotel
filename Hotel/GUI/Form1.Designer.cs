namespace Hotel
{
    partial class Frm_menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_menu));
            this.btn_habitaciones = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_logo = new System.Windows.Forms.ToolStripLabel();
            this.btn_habitciones = new System.Windows.Forms.ToolStripButton();
            this.btn_reservaciones = new System.Windows.Forms.ToolStripButton();
            this.btn_empleados = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btn_caja = new System.Windows.Forms.ToolStripButton();
            this.btn_habitaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImageScalingSize = new System.Drawing.Size(42, 42);
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_logo,
            this.btn_habitciones,
            this.toolStripSeparator1,
            this.btn_reservaciones,
            this.toolStripSeparator2,
            this.btn_empleados,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.btn_caja});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(849, 64);
            this.btn_habitaciones.TabIndex = 0;
            this.btn_habitaciones.Text = "Menu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 64);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 64);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 64);
            // 
            // lbl_logo
            // 
            this.lbl_logo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl_logo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_logo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lbl_logo.Image = global::Hotel.Properties.Resources.GardSoft_logo;
            this.lbl_logo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_logo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_logo.Size = new System.Drawing.Size(200, 61);
            this.lbl_logo.Text = "Aquí va el LOGO";
            this.lbl_logo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_habitciones
            // 
            this.btn_habitciones.Image = global::Hotel.Properties.Resources._039_bed;
            this.btn_habitciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_habitciones.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_habitciones.Name = "btn_habitciones";
            this.btn_habitciones.Size = new System.Drawing.Size(122, 61);
            this.btn_habitciones.Text = "Habitaciones";
            // 
            // btn_reservaciones
            // 
            this.btn_reservaciones.Image = global::Hotel.Properties.Resources._020_bell_ring;
            this.btn_reservaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reservaciones.Name = "btn_reservaciones";
            this.btn_reservaciones.Size = new System.Drawing.Size(127, 61);
            this.btn_reservaciones.Text = "Reservaciones";
            // 
            // btn_empleados
            // 
            this.btn_empleados.Image = global::Hotel.Properties.Resources._022_reception;
            this.btn_empleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(111, 61);
            this.btn_empleados.Text = "Empleados";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Hotel.Properties.Resources._031_broom;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(135, 61);
            this.toolStripButton2.Text = "Mantenimiento";
            // 
            // btn_caja
            // 
            this.btn_caja.Image = global::Hotel.Properties.Resources._024_safety_box;
            this.btn_caja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_caja.Name = "btn_caja";
            this.btn_caja.Size = new System.Drawing.Size(76, 61);
            this.btn_caja.Text = "Caja";
            this.btn_caja.ToolTipText = "Caja";
            // 
            // Frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.btn_habitaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_menu";
            this.Text = "Sistema Hotelero";
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripButton btn_habitciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_reservaciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_empleados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_caja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel lbl_logo;
    }
}

