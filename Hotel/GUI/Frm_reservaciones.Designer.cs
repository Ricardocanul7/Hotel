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
            this.btn_eliminar_reserv = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_buscar = new System.Windows.Forms.ToolStripTextBox();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.dgv_reservaciones = new System.Windows.Forms.DataGridView();
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
            this.btn_eliminar_reserv,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.txt_buscar,
            this.btn_buscar});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(938, 39);
            this.btn_habitaciones.TabIndex = 1;
            this.btn_habitaciones.Text = "Menu";
            // 
            // btn_reservarhab
            // 
            this.btn_reservarhab.Image = global::Hotel.Properties.Resources._025_hotel_bell;
            this.btn_reservarhab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reservarhab.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_reservarhab.Name = "btn_reservarhab";
            this.btn_reservarhab.Size = new System.Drawing.Size(114, 36);
            this.btn_reservarhab.Text = "Reservar registro";
            this.btn_reservarhab.Click += new System.EventHandler(this.btn_reservarhab_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_modificar_reser
            // 
            this.btn_modificar_reser.Image = global::Hotel.Properties.Resources._036_edit;
            this.btn_modificar_reser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_modificar_reser.Name = "btn_modificar_reser";
            this.btn_modificar_reser.Size = new System.Drawing.Size(121, 36);
            this.btn_modificar_reser.Text = "Modificar registro";
            this.btn_modificar_reser.Click += new System.EventHandler(this.btn_modificar_reser_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_eliminar_reserv
            // 
            this.btn_eliminar_reserv.Image = global::Hotel.Properties.Resources.close;
            this.btn_eliminar_reserv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar_reserv.Name = "btn_eliminar_reserv";
            this.btn_eliminar_reserv.Size = new System.Drawing.Size(113, 36);
            this.btn_eliminar_reserv.Text = "Eliminar registro";
            this.btn_eliminar_reserv.Click += new System.EventHandler(this.btn_eliminar_reserv_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 36);
            this.toolStripLabel1.Text = "Buscar";
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(150, 39);
            // 
            // btn_buscar
            // 
            this.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar.Image = global::Hotel.Properties.Resources.icon_search;
            this.btn_buscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(36, 36);
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_reservaciones
            // 
            this.dgv_reservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_reservaciones.Location = new System.Drawing.Point(0, 39);
            this.dgv_reservaciones.Name = "dgv_reservaciones";
            this.dgv_reservaciones.Size = new System.Drawing.Size(938, 411);
            this.dgv_reservaciones.TabIndex = 2;
            this.dgv_reservaciones.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_reservaciones_CellMouseClick);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox txt_buscar;
        private System.Windows.Forms.ToolStripButton btn_buscar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}