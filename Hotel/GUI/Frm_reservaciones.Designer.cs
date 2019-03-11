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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Grd_Reservaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reservarhab = new System.Windows.Forms.ToolStripButton();
            this.btn_consultar_res = new System.Windows.Forms.ToolStripButton();
            this.btn_checkin = new System.Windows.Forms.ToolStripButton();
            this.btn_chekout = new System.Windows.Forms.ToolStripButton();
            this.btn_habitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Reservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_reservarhab,
            this.toolStripSeparator1,
            this.btn_consultar_res,
            this.toolStripSeparator2,
            this.btn_checkin,
            this.toolStripSeparator3,
            this.btn_chekout});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(938, 25);
            this.btn_habitaciones.TabIndex = 1;
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
            // Grd_Reservaciones
            // 
            this.Grd_Reservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Reservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Reservaciones.Location = new System.Drawing.Point(0, 25);
            this.Grd_Reservaciones.Name = "Grd_Reservaciones";
            this.Grd_Reservaciones.Size = new System.Drawing.Size(938, 425);
            this.Grd_Reservaciones.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "<< Aquí se visualizara la tabla de reservaiones actuales";
            // 
            // btn_reservarhab
            // 
            this.btn_reservarhab.Image = global::Hotel.Properties.Resources._025_hotel_bell;
            this.btn_reservarhab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reservarhab.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_reservarhab.Name = "btn_reservarhab";
            this.btn_reservarhab.Size = new System.Drawing.Size(130, 22);
            this.btn_reservarhab.Text = "Reservar habitación";
            // 
            // btn_consultar_res
            // 
            this.btn_consultar_res.Image = global::Hotel.Properties.Resources._027_information;
            this.btn_consultar_res.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_consultar_res.Name = "btn_consultar_res";
            this.btn_consultar_res.Size = new System.Drawing.Size(101, 22);
            this.btn_consultar_res.Text = "Reservaciones";
            // 
            // btn_checkin
            // 
            this.btn_checkin.Image = global::Hotel.Properties.Resources._005_check_in;
            this.btn_checkin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_checkin.Name = "btn_checkin";
            this.btn_checkin.Size = new System.Drawing.Size(73, 22);
            this.btn_checkin.Text = "Check in";
            // 
            // btn_chekout
            // 
            this.btn_chekout.Image = global::Hotel.Properties.Resources._004_hotel_stroller;
            this.btn_chekout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_chekout.Name = "btn_chekout";
            this.btn_chekout.Size = new System.Drawing.Size(81, 22);
            this.btn_chekout.Text = "Check out";
            // 
            // Frm_reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grd_Reservaciones);
            this.Controls.Add(this.btn_habitaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_reservaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservaciones";
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Reservaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripButton btn_reservarhab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_consultar_res;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_checkin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_chekout;
        private System.Windows.Forms.DataGridView Grd_Reservaciones;
        private System.Windows.Forms.Label label1;
    }
}