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
            this.lbl_reservaciones_title = new System.Windows.Forms.ToolStripLabel();
            this.lbl_logo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_reservarhab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_consultar_res = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_checkin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_chekout = new System.Windows.Forms.ToolStripButton();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_habitaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImageScalingSize = new System.Drawing.Size(42, 42);
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_reservaciones_title,
            this.lbl_logo,
            this.toolStripSeparator4,
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
            this.btn_habitaciones.Size = new System.Drawing.Size(938, 64);
            this.btn_habitaciones.TabIndex = 1;
            this.btn_habitaciones.Text = "Menu";
            // 
            // lbl_reservaciones_title
            // 
            this.lbl_reservaciones_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_reservaciones_title.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_reservaciones_title.Name = "lbl_reservaciones_title";
            this.lbl_reservaciones_title.Size = new System.Drawing.Size(204, 61);
            this.lbl_reservaciones_title.Text = "RESERVACIONES";
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 64);
            // 
            // btn_reservarhab
            // 
            this.btn_reservarhab.Image = global::Hotel.Properties.Resources._025_hotel_bell;
            this.btn_reservarhab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reservarhab.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_reservarhab.Name = "btn_reservarhab";
            this.btn_reservarhab.Size = new System.Drawing.Size(156, 61);
            this.btn_reservarhab.Text = "Reservar habitación";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
            // 
            // btn_consultar_res
            // 
            this.btn_consultar_res.Image = global::Hotel.Properties.Resources._027_information;
            this.btn_consultar_res.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_consultar_res.Name = "btn_consultar_res";
            this.btn_consultar_res.Size = new System.Drawing.Size(127, 61);
            this.btn_consultar_res.Text = "Reservaciones";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 64);
            // 
            // btn_checkin
            // 
            this.btn_checkin.Image = global::Hotel.Properties.Resources._005_check_in;
            this.btn_checkin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_checkin.Name = "btn_checkin";
            this.btn_checkin.Size = new System.Drawing.Size(99, 61);
            this.btn_checkin.Text = "Check in";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 64);
            // 
            // btn_chekout
            // 
            this.btn_chekout.Image = global::Hotel.Properties.Resources._004_hotel_stroller;
            this.btn_chekout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_chekout.Name = "btn_chekout";
            this.btn_chekout.Size = new System.Drawing.Size(107, 61);
            this.btn_chekout.Text = "Check out";
            // 
            // button10
            // 
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Image = global::Hotel.Properties.Resources.cama_ocupada;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.Location = new System.Drawing.Point(415, 347);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 64);
            this.button10.TabIndex = 12;
            this.button10.Text = "SUITE LAG 02";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Image = global::Hotel.Properties.Resources.cama_libre;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.Location = new System.Drawing.Point(334, 347);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 64);
            this.button11.TabIndex = 11;
            this.button11.Text = "SUITE JAR 01";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Image = global::Hotel.Properties.Resources.cama_ocupada;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(496, 263);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 64);
            this.button9.TabIndex = 10;
            this.button9.Text = "DUPLEX LAG 03";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Image = global::Hotel.Properties.Resources.cama_limpieza;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(415, 263);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 64);
            this.button5.TabIndex = 9;
            this.button5.Text = "DUPLEX 02";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Image = global::Hotel.Properties.Resources.cama_libre;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(334, 263);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 64);
            this.button6.TabIndex = 8;
            this.button6.Text = "DUPLEX 01";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Image = global::Hotel.Properties.Resources.cama_libre;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(415, 181);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 64);
            this.button7.TabIndex = 7;
            this.button7.Text = "Cabaña DBL  02";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Image = global::Hotel.Properties.Resources.cama_limpieza;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(334, 181);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 64);
            this.button8.TabIndex = 6;
            this.button8.Text = "Cabaña DBL  01";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = global::Hotel.Properties.Resources.cama_libre;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(577, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 64);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cabaña ST 04";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = global::Hotel.Properties.Resources.cama_libre;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(496, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 64);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cabaña ST 03";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::Hotel.Properties.Resources.cama_ocupada;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(415, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cabaña ST 02";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::Hotel.Properties.Resources.cama_libre;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(334, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cabaña ST 01";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(58, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "DISPONIBILIDAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(92, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 108);
            this.label2.TabIndex = 14;
            this.label2.Text = "04";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 51);
            this.label3.TabIndex = 15;
            this.label3.Text = "marzo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 51);
            this.label4.TabIndex = 16;
            this.label4.Text = "2019";
            // 
            // Frm_reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_habitaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_reservaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservaciones";
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripLabel lbl_logo;
        private System.Windows.Forms.ToolStripButton btn_reservarhab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_consultar_res;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_checkin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_chekout;
        private System.Windows.Forms.ToolStripLabel lbl_reservaciones_title;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}