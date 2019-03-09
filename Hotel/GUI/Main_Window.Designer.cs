namespace Hotel.GUI
{
    partial class Main_Window
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_titulo = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_izquierdo = new System.Windows.Forms.Panel();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_izquierdo);
            this.panel1.Controls.Add(this.panel_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 583);
            this.panel1.TabIndex = 0;
            // 
            // panel_titulo
            // 
            this.panel_titulo.BackColor = System.Drawing.Color.Silver;
            this.panel_titulo.Controls.Add(this.lbl_titulo);
            this.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo.Location = new System.Drawing.Point(220, 60);
            this.panel_titulo.Name = "panel_titulo";
            this.panel_titulo.Size = new System.Drawing.Size(875, 54);
            this.panel_titulo.TabIndex = 1;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Silver;
            this.panel_logo.BackgroundImage = global::Hotel.Properties.Resources.GardSoft_logo;
            this.panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(200, 54);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_izquierdo
            // 
            this.panel_izquierdo.BackColor = System.Drawing.Color.SlateGray;
            this.panel_izquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_izquierdo.Location = new System.Drawing.Point(0, 54);
            this.panel_izquierdo.Name = "panel_izquierdo";
            this.panel_izquierdo.Size = new System.Drawing.Size(200, 529);
            this.panel_izquierdo.TabIndex = 1;
            // 
            // panel_principal
            // 
            this.panel_principal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal.Location = new System.Drawing.Point(220, 114);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(875, 529);
            this.panel_principal.TabIndex = 2;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(22, 11);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(71, 29);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Titulo";
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 663);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.panel_titulo);
            this.Controls.Add(this.panel1);
            this.Name = "Main_Window";
            this.Text = "Sistema de gestión de habitaciones";
            this.panel1.ResumeLayout(false);
            this.panel_titulo.ResumeLayout(false);
            this.panel_titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_izquierdo;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_titulo;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Label lbl_titulo;
    }
}