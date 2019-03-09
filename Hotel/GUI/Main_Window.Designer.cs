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
            this.panel_izquierdo = new System.Windows.Forms.Panel();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.panel_user_info = new System.Windows.Forms.Panel();
            this.lbl_nombre_usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cerrar_sesion = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_titulo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel_MenuStrip = new System.Windows.Forms.Panel();
            this.btn_habitaciones = new System.Windows.Forms.ToolStrip();
            this.btn_habitciones = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_reservaciones = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_empleados = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_caja = new System.Windows.Forms.ToolStripButton();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_izquierdo.SuspendLayout();
            this.panel_user_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_titulo.SuspendLayout();
            this.panel_MenuStrip.SuspendLayout();
            this.btn_habitaciones.SuspendLayout();
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
            // panel_izquierdo
            // 
            this.panel_izquierdo.BackColor = System.Drawing.Color.Black;
            this.panel_izquierdo.Controls.Add(this.btn_config);
            this.panel_izquierdo.Controls.Add(this.btn_inicio);
            this.panel_izquierdo.Controls.Add(this.panel_user_info);
            this.panel_izquierdo.Controls.Add(this.btn_cerrar_sesion);
            this.panel_izquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_izquierdo.Location = new System.Drawing.Point(0, 54);
            this.panel_izquierdo.Name = "panel_izquierdo";
            this.panel_izquierdo.Size = new System.Drawing.Size(200, 529);
            this.panel_izquierdo.TabIndex = 1;
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.Color.Black;
            this.btn_config.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_config.FlatAppearance.BorderSize = 0;
            this.btn_config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_config.Location = new System.Drawing.Point(0, 187);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(200, 41);
            this.btn_config.TabIndex = 4;
            this.btn_config.Text = "CONFIGURACIÓN";
            this.btn_config.UseVisualStyleBackColor = false;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.Black;
            this.btn_inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inicio.FlatAppearance.BorderSize = 0;
            this.btn_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_inicio.Location = new System.Drawing.Point(0, 146);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(200, 41);
            this.btn_inicio.TabIndex = 3;
            this.btn_inicio.Text = "INICIO";
            this.btn_inicio.UseVisualStyleBackColor = false;
            // 
            // panel_user_info
            // 
            this.panel_user_info.Controls.Add(this.lbl_nombre_usuario);
            this.panel_user_info.Controls.Add(this.pictureBox1);
            this.panel_user_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user_info.Location = new System.Drawing.Point(0, 0);
            this.panel_user_info.Name = "panel_user_info";
            this.panel_user_info.Size = new System.Drawing.Size(200, 146);
            this.panel_user_info.TabIndex = 2;
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(40, 92);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(116, 25);
            this.lbl_nombre_usuario.TabIndex = 1;
            this.lbl_nombre_usuario.Text = "Juanito L.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hotel.Properties.Resources.iconfinder_InterfaceExpendet_09_592608;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cerrar_sesion
            // 
            this.btn_cerrar_sesion.BackColor = System.Drawing.Color.Crimson;
            this.btn_cerrar_sesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cerrar_sesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_sesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cerrar_sesion.Location = new System.Drawing.Point(0, 488);
            this.btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            this.btn_cerrar_sesion.Size = new System.Drawing.Size(200, 41);
            this.btn_cerrar_sesion.TabIndex = 1;
            this.btn_cerrar_sesion.Text = "CERRAR SESIÓN";
            this.btn_cerrar_sesion.UseVisualStyleBackColor = false;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Silver;
            this.panel_logo.BackgroundImage = global::Hotel.Properties.Resources.GardSoft_logo;
            this.panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(200, 54);
            this.panel_logo.TabIndex = 0;
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
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(22, 15);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(65, 25);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Titulo";
            // 
            // panel_MenuStrip
            // 
            this.panel_MenuStrip.BackColor = System.Drawing.Color.GhostWhite;
            this.panel_MenuStrip.Controls.Add(this.btn_habitaciones);
            this.panel_MenuStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_MenuStrip.Location = new System.Drawing.Point(220, 114);
            this.panel_MenuStrip.Name = "panel_MenuStrip";
            this.panel_MenuStrip.Size = new System.Drawing.Size(875, 51);
            this.panel_MenuStrip.TabIndex = 2;
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImageScalingSize = new System.Drawing.Size(42, 42);
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btn_habitaciones.Size = new System.Drawing.Size(875, 49);
            this.btn_habitaciones.TabIndex = 1;
            this.btn_habitaciones.Text = "Menu";
            // 
            // btn_habitciones
            // 
            this.btn_habitciones.Image = global::Hotel.Properties.Resources._039_bed;
            this.btn_habitciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_habitciones.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_habitciones.Name = "btn_habitciones";
            this.btn_habitciones.Size = new System.Drawing.Size(122, 46);
            this.btn_habitciones.Text = "Habitaciones";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // btn_reservaciones
            // 
            this.btn_reservaciones.Image = global::Hotel.Properties.Resources._020_bell_ring;
            this.btn_reservaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reservaciones.Name = "btn_reservaciones";
            this.btn_reservaciones.Size = new System.Drawing.Size(127, 46);
            this.btn_reservaciones.Text = "Reservaciones";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 49);
            // 
            // btn_empleados
            // 
            this.btn_empleados.Image = global::Hotel.Properties.Resources._022_reception;
            this.btn_empleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(111, 46);
            this.btn_empleados.Text = "Empleados";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 49);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Hotel.Properties.Resources._031_broom;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(135, 46);
            this.toolStripButton2.Text = "Mantenimiento";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 49);
            // 
            // btn_caja
            // 
            this.btn_caja.Image = global::Hotel.Properties.Resources._024_safety_box;
            this.btn_caja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_caja.Name = "btn_caja";
            this.btn_caja.Size = new System.Drawing.Size(76, 46);
            this.btn_caja.Text = "Caja";
            this.btn_caja.ToolTipText = "Caja";
            // 
            // panel_principal
            // 
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal.Location = new System.Drawing.Point(220, 165);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(875, 478);
            this.panel_principal.TabIndex = 3;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 663);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.panel_MenuStrip);
            this.Controls.Add(this.panel_titulo);
            this.Controls.Add(this.panel1);
            this.Name = "Main_Window";
            this.Text = "Sistema de gestión de habitaciones";
            this.panel1.ResumeLayout(false);
            this.panel_izquierdo.ResumeLayout(false);
            this.panel_user_info.ResumeLayout(false);
            this.panel_user_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_titulo.ResumeLayout(false);
            this.panel_titulo.PerformLayout();
            this.panel_MenuStrip.ResumeLayout(false);
            this.panel_MenuStrip.PerformLayout();
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_izquierdo;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_titulo;
        private System.Windows.Forms.Panel panel_MenuStrip;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_cerrar_sesion;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Panel panel_user_info;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nombre_usuario;
        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripButton btn_habitciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_reservaciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_empleados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_caja;
        private System.Windows.Forms.Panel panel_principal;
    }
}