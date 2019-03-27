namespace Hotel.GUI
{
    partial class frm_agregar_puesto
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
            this.dgv_puestos = new System.Windows.Forms.DataGridView();
            this.txt_Nuevo_Puesto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_guardar_puesto = new System.Windows.Forms.Button();
            this.txt_Buscar_Puesto = new System.Windows.Forms.TextBox();
            this.btn_buscar_puesto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar_puesto = new System.Windows.Forms.Button();
            this.btn_modificar_puesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puestos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_puestos
            // 
            this.dgv_puestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_puestos.Location = new System.Drawing.Point(23, 224);
            this.dgv_puestos.Name = "dgv_puestos";
            this.dgv_puestos.Size = new System.Drawing.Size(316, 130);
            this.dgv_puestos.TabIndex = 0;
            this.dgv_puestos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar_puesto);
            // 
            // txt_Nuevo_Puesto
            // 
            this.txt_Nuevo_Puesto.Location = new System.Drawing.Point(104, 72);
            this.txt_Nuevo_Puesto.Name = "txt_Nuevo_Puesto";
            this.txt_Nuevo_Puesto.Size = new System.Drawing.Size(221, 20);
            this.txt_Nuevo_Puesto.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 40);
            this.label6.TabIndex = 12;
            this.label6.Text = "PUESTOS";
            // 
            // btn_guardar_puesto
            // 
            this.btn_guardar_puesto.Image = global::Hotel.Properties.Resources._035_save;
            this.btn_guardar_puesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar_puesto.Location = new System.Drawing.Point(230, 98);
            this.btn_guardar_puesto.Name = "btn_guardar_puesto";
            this.btn_guardar_puesto.Size = new System.Drawing.Size(95, 38);
            this.btn_guardar_puesto.TabIndex = 22;
            this.btn_guardar_puesto.Text = "       Guardar";
            this.btn_guardar_puesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar_puesto.UseVisualStyleBackColor = true;
            this.btn_guardar_puesto.Click += new System.EventHandler(this.Guardar_Puesto);
            // 
            // txt_Buscar_Puesto
            // 
            this.txt_Buscar_Puesto.Location = new System.Drawing.Point(50, 185);
            this.txt_Buscar_Puesto.Name = "txt_Buscar_Puesto";
            this.txt_Buscar_Puesto.Size = new System.Drawing.Size(156, 20);
            this.txt_Buscar_Puesto.TabIndex = 25;
            // 
            // btn_buscar_puesto
            // 
            this.btn_buscar_puesto.Image = global::Hotel.Properties.Resources.icon_search;
            this.btn_buscar_puesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar_puesto.Location = new System.Drawing.Point(212, 183);
            this.btn_buscar_puesto.Name = "btn_buscar_puesto";
            this.btn_buscar_puesto.Size = new System.Drawing.Size(82, 23);
            this.btn_buscar_puesto.TabIndex = 26;
            this.btn_buscar_puesto.Text = "Buscar";
            this.btn_buscar_puesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar_puesto.UseVisualStyleBackColor = true;
            this.btn_buscar_puesto.Click += new System.EventHandler(this.Buscar_puestos);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nuevo Puesto:";
            // 
            // btn_eliminar_puesto
            // 
            this.btn_eliminar_puesto.Image = global::Hotel.Properties.Resources.close;
            this.btn_eliminar_puesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar_puesto.Location = new System.Drawing.Point(246, 360);
            this.btn_eliminar_puesto.Name = "btn_eliminar_puesto";
            this.btn_eliminar_puesto.Size = new System.Drawing.Size(93, 38);
            this.btn_eliminar_puesto.TabIndex = 28;
            this.btn_eliminar_puesto.Text = "Eliminar";
            this.btn_eliminar_puesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar_puesto.UseVisualStyleBackColor = true;
            this.btn_eliminar_puesto.Click += new System.EventHandler(this.Eliminar_puestos);
            // 
            // btn_modificar_puesto
            // 
            this.btn_modificar_puesto.Image = global::Hotel.Properties.Resources._036_edit;
            this.btn_modificar_puesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar_puesto.Location = new System.Drawing.Point(138, 360);
            this.btn_modificar_puesto.Name = "btn_modificar_puesto";
            this.btn_modificar_puesto.Size = new System.Drawing.Size(102, 38);
            this.btn_modificar_puesto.TabIndex = 29;
            this.btn_modificar_puesto.Text = "Modificar";
            this.btn_modificar_puesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar_puesto.UseVisualStyleBackColor = true;
            this.btn_modificar_puesto.Click += new System.EventHandler(this.Modificar_puesto);
            // 
            // frm_agregar_puesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 410);
            this.Controls.Add(this.btn_eliminar_puesto);
            this.Controls.Add(this.btn_modificar_puesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscar_puesto);
            this.Controls.Add(this.txt_Buscar_Puesto);
            this.Controls.Add(this.btn_guardar_puesto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Nuevo_Puesto);
            this.Controls.Add(this.dgv_puestos);
            this.Name = "frm_agregar_puesto";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_puestos;
        private System.Windows.Forms.TextBox txt_Nuevo_Puesto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_guardar_puesto;
        private System.Windows.Forms.TextBox txt_Buscar_Puesto;
        private System.Windows.Forms.Button btn_buscar_puesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_eliminar_puesto;
        private System.Windows.Forms.Button btn_modificar_puesto;
    }
}