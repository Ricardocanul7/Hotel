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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_izquierdo = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.btn_mantenimiento = new System.Windows.Forms.Button();
            this.btn_habitaciones = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_caja = new System.Windows.Forms.Button();
            this.btn_reservaciones = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_user_info = new System.Windows.Forms.Panel();
            this.lbl_nombre_usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cerrar_sesion = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_titulo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_izquierdo.SuspendLayout();
            this.panel_user_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(250, 708);
            this.panel1.TabIndex = 0;
            // 
            // panel_izquierdo
            // 
            this.panel_izquierdo.BackColor = System.Drawing.Color.Black;
            this.panel_izquierdo.Controls.Add(this.button3);
            this.panel_izquierdo.Controls.Add(this.btn_clientes);
            this.panel_izquierdo.Controls.Add(this.btn_empleados);
            this.panel_izquierdo.Controls.Add(this.btn_mantenimiento);
            this.panel_izquierdo.Controls.Add(this.btn_habitaciones);
            this.panel_izquierdo.Controls.Add(this.button2);
            this.panel_izquierdo.Controls.Add(this.btn_caja);
            this.panel_izquierdo.Controls.Add(this.btn_reservaciones);
            this.panel_izquierdo.Controls.Add(this.button1);
            this.panel_izquierdo.Controls.Add(this.panel_user_info);
            this.panel_izquierdo.Controls.Add(this.btn_cerrar_sesion);
            this.panel_izquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_izquierdo.Location = new System.Drawing.Point(0, 54);
            this.panel_izquierdo.Name = "panel_izquierdo";
            this.panel_izquierdo.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panel_izquierdo.Size = new System.Drawing.Size(250, 654);
            this.panel_izquierdo.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = global::Hotel.Properties.Resources._031_broom1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 513);
            this.button3.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button3.Size = new System.Drawing.Size(250, 48);
            this.button3.TabIndex = 18;
            this.button3.Text = "  SERVICIOS            ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Abrir_Servicios);
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.Color.Black;
            this.btn_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_clientes.Image = global::Hotel.Properties.Resources.team1;
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.Location = new System.Drawing.Point(0, 465);
            this.btn_clientes.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_clientes.Size = new System.Drawing.Size(250, 48);
            this.btn_clientes.TabIndex = 17;
            this.btn_clientes.Text = "CLIENTES            ";
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_empleados
            // 
            this.btn_empleados.BackColor = System.Drawing.Color.Black;
            this.btn_empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_empleados.FlatAppearance.BorderSize = 0;
            this.btn_empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleados.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_empleados.Image = global::Hotel.Properties.Resources._022_reception1;
            this.btn_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empleados.Location = new System.Drawing.Point(0, 417);
            this.btn_empleados.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_empleados.Size = new System.Drawing.Size(250, 48);
            this.btn_empleados.TabIndex = 16;
            this.btn_empleados.Text = "EMPLEADOS     ";
            this.btn_empleados.UseVisualStyleBackColor = false;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // btn_mantenimiento
            // 
            this.btn_mantenimiento.BackColor = System.Drawing.Color.Black;
            this.btn_mantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_mantenimiento.FlatAppearance.BorderSize = 0;
            this.btn_mantenimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_mantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mantenimiento.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mantenimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_mantenimiento.Image = global::Hotel.Properties.Resources.add1;
            this.btn_mantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mantenimiento.Location = new System.Drawing.Point(0, 369);
            this.btn_mantenimiento.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_mantenimiento.Name = "btn_mantenimiento";
            this.btn_mantenimiento.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_mantenimiento.Size = new System.Drawing.Size(250, 48);
            this.btn_mantenimiento.TabIndex = 15;
            this.btn_mantenimiento.Text = "           EMPRESAS";
            this.btn_mantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mantenimiento.UseVisualStyleBackColor = false;
            this.btn_mantenimiento.Click += new System.EventHandler(this.btn_mantenimiento_Click);
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.BackColor = System.Drawing.Color.Black;
            this.btn_habitaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_habitaciones.FlatAppearance.BorderSize = 0;
            this.btn_habitaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_habitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_habitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_habitaciones.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_habitaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_habitaciones.Image = global::Hotel.Properties.Resources._039_bed1;
            this.btn_habitaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 321);
            this.btn_habitaciones.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_habitaciones.Size = new System.Drawing.Size(250, 48);
            this.btn_habitaciones.TabIndex = 14;
            this.btn_habitaciones.Text = "HABITACIONES";
            this.btn_habitaciones.UseVisualStyleBackColor = false;
            this.btn_habitaciones.Click += new System.EventHandler(this.btn_habitaciones_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 15F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 289);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 3, 20, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button2.Size = new System.Drawing.Size(250, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "Catálogos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_caja
            // 
            this.btn_caja.BackColor = System.Drawing.Color.Black;
            this.btn_caja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_caja.FlatAppearance.BorderSize = 0;
            this.btn_caja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_caja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caja.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_caja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_caja.Image = global::Hotel.Properties.Resources._024_safety_box2;
            this.btn_caja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_caja.Location = new System.Drawing.Point(0, 241);
            this.btn_caja.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_caja.Name = "btn_caja";
            this.btn_caja.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_caja.Size = new System.Drawing.Size(250, 48);
            this.btn_caja.TabIndex = 12;
            this.btn_caja.Text = "CAJA                  ";
            this.btn_caja.UseVisualStyleBackColor = false;
            this.btn_caja.Click += new System.EventHandler(this.btn_caja_Click);
            // 
            // btn_reservaciones
            // 
            this.btn_reservaciones.BackColor = System.Drawing.Color.Black;
            this.btn_reservaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reservaciones.FlatAppearance.BorderSize = 0;
            this.btn_reservaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_reservaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_reservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservaciones.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reservaciones.Image = global::Hotel.Properties.Resources._020_bell_ring1;
            this.btn_reservaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reservaciones.Location = new System.Drawing.Point(0, 193);
            this.btn_reservaciones.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_reservaciones.Name = "btn_reservaciones";
            this.btn_reservaciones.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_reservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_reservaciones.Size = new System.Drawing.Size(250, 48);
            this.btn_reservaciones.TabIndex = 11;
            this.btn_reservaciones.Text = "REGISTROS      ";
            this.btn_reservaciones.UseVisualStyleBackColor = false;
            this.btn_reservaciones.Click += new System.EventHandler(this.btn_reservaciones_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 15F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 3, 20, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(250, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Menu usuario";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel_user_info
            // 
            this.panel_user_info.Controls.Add(this.lbl_nombre_usuario);
            this.panel_user_info.Controls.Add(this.pictureBox1);
            this.panel_user_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user_info.Location = new System.Drawing.Point(0, 15);
            this.panel_user_info.Name = "panel_user_info";
            this.panel_user_info.Size = new System.Drawing.Size(250, 146);
            this.panel_user_info.TabIndex = 2;
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(40, 106);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(116, 25);
            this.lbl_nombre_usuario.TabIndex = 1;
            this.lbl_nombre_usuario.Text = "Juanito L.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hotel.Properties.Resources.usuarios;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cerrar_sesion
            // 
            this.btn_cerrar_sesion.BackColor = System.Drawing.Color.Crimson;
            this.btn_cerrar_sesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cerrar_sesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_sesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cerrar_sesion.Image = global::Hotel.Properties.Resources._018_power;
            this.btn_cerrar_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar_sesion.Location = new System.Drawing.Point(0, 613);
            this.btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            this.btn_cerrar_sesion.Size = new System.Drawing.Size(250, 41);
            this.btn_cerrar_sesion.TabIndex = 1;
            this.btn_cerrar_sesion.Text = "CERRAR SESIÓN";
            this.btn_cerrar_sesion.UseVisualStyleBackColor = false;
            this.btn_cerrar_sesion.Click += new System.EventHandler(this.btn_cerrar_sesion_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(115)))));
            this.panel_logo.BackgroundImage = global::Hotel.Properties.Resources.logo_xs;
            this.panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(250, 54);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_titulo
            // 
            this.panel_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(115)))));
            this.panel_titulo.Controls.Add(this.lbl_titulo);
            this.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_titulo.Location = new System.Drawing.Point(270, 60);
            this.panel_titulo.Name = "panel_titulo";
            this.panel_titulo.Size = new System.Drawing.Size(825, 54);
            this.panel_titulo.TabIndex = 1;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_titulo.Location = new System.Drawing.Point(22, 15);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(92, 25);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "TITULO";
            // 
            // panel_principal
            // 
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal.Location = new System.Drawing.Point(270, 114);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(825, 654);
            this.panel_principal.TabIndex = 3;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 788);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.panel_titulo);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Window";
            this.Text = "Sistema de gestión de habitaciones";
            this.panel1.ResumeLayout(false);
            this.panel_izquierdo.ResumeLayout(false);
            this.panel_user_info.ResumeLayout(false);
            this.panel_user_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_titulo.ResumeLayout(false);
            this.panel_titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_izquierdo;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_titulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_cerrar_sesion;
        private System.Windows.Forms.Panel panel_user_info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nombre_usuario;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_reservaciones;
        private System.Windows.Forms.Button btn_caja;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_habitaciones;
        private System.Windows.Forms.Button btn_mantenimiento;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button button3;
    }
}