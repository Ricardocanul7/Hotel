namespace Hotel.GUI
{
    partial class Frm_reservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_reservaciones));
            this.btn_habitaciones = new System.Windows.Forms.ToolStrip();
            this.btn_reservarhab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_modificar_reser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgv_reservaciones = new System.Windows.Forms.DataGridView();
            this.btn_eliminar_reserv = new System.Windows.Forms.ToolStripButton();
            this.btn_habitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_reservarhab,
            this.toolStripSeparator1,
            this.btn_modificar_reser,
            this.toolStripSeparator2,
            this.btn_eliminar_reserv});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(938, 25);
            this.btn_habitaciones.TabIndex = 1;
            this.btn_habitaciones.Text = "Menu";
            // 
            // btn_reservarhab
            // 
            this.btn_reservarhab.Image = global::Hotel.Properties.Resources._025_hotel_bell;
            this.btn_reservarhab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reservarhab.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_reservarhab.Name = "btn_reservarhab";
            this.btn_reservarhab.Size = new System.Drawing.Size(130, 22);
            this.btn_reservarhab.Text = "Reservar habitación";
            this.btn_reservarhab.Click += new System.EventHandler(this.btn_reservarhab_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_modificar_reser
            // 
            this.btn_modificar_reser.Image = global::Hotel.Properties.Resources._036_edit;
            this.btn_modificar_reser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_modificar_reser.Name = "btn_modificar_reser";
            this.btn_modificar_reser.Size = new System.Drawing.Size(118, 22);
            this.btn_modificar_reser.Text = "Modificar reserva";
            this.btn_modificar_reser.Click += new System.EventHandler(this.btn_modificar_reser_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dgv_reservaciones
            // 
            this.dgv_reservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_reservaciones.Location = new System.Drawing.Point(0, 25);
            this.dgv_reservaciones.Name = "dgv_reservaciones";
            this.dgv_reservaciones.Size = new System.Drawing.Size(938, 425);
            this.dgv_reservaciones.TabIndex = 2;
            this.dgv_reservaciones.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_reservaciones_CellMouseClick);
            // 
            // btn_eliminar_reserv
            // 
            this.btn_eliminar_reserv.Image = global::Hotel.Properties.Resources.close;
            this.btn_eliminar_reserv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar_reserv.Name = "btn_eliminar_reserv";
            this.btn_eliminar_reserv.Size = new System.Drawing.Size(110, 22);
            this.btn_eliminar_reserv.Text = "Eliminar reserva";
            this.btn_eliminar_reserv.Click += new System.EventHandler(this.btn_eliminar_reserv_Click);
            // 
            // Frm_reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.dgv_reservaciones);
            this.Controls.Add(this.btn_habitaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_reservaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservaciones";
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripButton btn_reservarhab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_modificar_reser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dgv_reservaciones;
        private System.Windows.Forms.ToolStripButton btn_eliminar_reserv;
    }
}