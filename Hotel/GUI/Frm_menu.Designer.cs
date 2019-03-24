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
            this.MenuStrip_principal = new System.Windows.Forms.ToolStrip();
            this.btn_agregar_habitaciones = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_modificar_hab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_eliminar_hab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_buscar_hab = new System.Windows.Forms.ToolStripButton();
            this.txt_buscar_hab = new System.Windows.Forms.ToolStripTextBox();
            this.dgv_habitaciones = new System.Windows.Forms.DataGridView();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.MenuStrip_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip_principal
            // 
            this.MenuStrip_principal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuStrip_principal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MenuStrip_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_agregar_habitaciones,
            this.toolStripSeparator1,
            this.btn_modificar_hab,
            this.toolStripSeparator2,
            this.btn_eliminar_hab,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.txt_buscar_hab,
            this.btn_buscar_hab});
            this.MenuStrip_principal.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_principal.Name = "MenuStrip_principal";
            this.MenuStrip_principal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip_principal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MenuStrip_principal.Size = new System.Drawing.Size(849, 39);
            this.MenuStrip_principal.TabIndex = 43;
            this.MenuStrip_principal.Text = "Menu";
            // 
            // btn_agregar_habitaciones
            // 
            this.btn_agregar_habitaciones.Image = global::Hotel.Properties.Resources._039_bed;
            this.btn_agregar_habitaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_agregar_habitaciones.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_agregar_habitaciones.Name = "btn_agregar_habitaciones";
            this.btn_agregar_habitaciones.Size = new System.Drawing.Size(141, 36);
            this.btn_agregar_habitaciones.Text = "Agregar Habitaciones";
            this.btn_agregar_habitaciones.Click += new System.EventHandler(this.btn_agregar_habitaciones_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_modificar_hab
            // 
            this.btn_modificar_hab.Image = global::Hotel.Properties.Resources._036_edit;
            this.btn_modificar_hab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_modificar_hab.Name = "btn_modificar_hab";
            this.btn_modificar_hab.Size = new System.Drawing.Size(139, 36);
            this.btn_modificar_hab.Text = "Modificar Habitación";
            this.btn_modificar_hab.Click += new System.EventHandler(this.btn_modificar_hab_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_eliminar_hab
            // 
            this.btn_eliminar_hab.Image = global::Hotel.Properties.Resources.close;
            this.btn_eliminar_hab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar_hab.Name = "btn_eliminar_hab";
            this.btn_eliminar_hab.Size = new System.Drawing.Size(131, 36);
            this.btn_eliminar_hab.Text = "Eliminar Habitación";
            this.btn_eliminar_hab.Click += new System.EventHandler(this.btn_eliminar_hab_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_buscar_hab
            // 
            this.btn_buscar_hab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar_hab.Image = global::Hotel.Properties.Resources.icon_search;
            this.btn_buscar_hab.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_buscar_hab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar_hab.Name = "btn_buscar_hab";
            this.btn_buscar_hab.Size = new System.Drawing.Size(36, 36);
            this.btn_buscar_hab.Text = "Buscar";
            this.btn_buscar_hab.Click += new System.EventHandler(this.btn_buscar_hab_Click);
            // 
            // txt_buscar_hab
            // 
            this.txt_buscar_hab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar_hab.Name = "txt_buscar_hab";
            this.txt_buscar_hab.Size = new System.Drawing.Size(150, 39);
            // 
            // dgv_habitaciones
            // 
            this.dgv_habitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_habitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_habitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_habitaciones.Location = new System.Drawing.Point(0, 39);
            this.dgv_habitaciones.Name = "dgv_habitaciones";
            this.dgv_habitaciones.Size = new System.Drawing.Size(849, 411);
            this.dgv_habitaciones.TabIndex = 44;
            this.dgv_habitaciones.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.seleccionarFila);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 36);
            this.toolStripLabel1.Text = "Buscar";
            // 
            // Frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.dgv_habitaciones);
            this.Controls.Add(this.MenuStrip_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_menu";
            this.Text = "Sistema Hotelero";
            this.MenuStrip_principal.ResumeLayout(false);
            this.MenuStrip_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip MenuStrip_principal;
        private System.Windows.Forms.ToolStripButton btn_agregar_habitaciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_modificar_hab;
        private System.Windows.Forms.ToolStripButton btn_eliminar_hab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_buscar_hab;
        private System.Windows.Forms.ToolStripTextBox txt_buscar_hab;
        private System.Windows.Forms.DataGridView dgv_habitaciones;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

