namespace Hotel.GUI
{
    partial class Frm_configuracion
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
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_tipo_hab = new System.Windows.Forms.DataGridView();
            this.btn_buscar_tipo = new System.Windows.Forms.Button();
            this.txt_buscar_tipo = new System.Windows.Forms.TextBox();
            this.btn_eliminar_tipo = new System.Windows.Forms.Button();
            this.btn_modificar_tipo = new System.Windows.Forms.Button();
            this.btn_guardar_tipo = new System.Windows.Forms.Button();
            this.txt_tipo_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre_tipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_estado_hab = new System.Windows.Forms.DataGridView();
            this.btn_modificar_estado = new System.Windows.Forms.Button();
            this.btn_agregar_estado = new System.Windows.Forms.Button();
            this.txt_buscar_estado = new System.Windows.Forms.TextBox();
            this.btn_buscar_estado = new System.Windows.Forms.Button();
            this.btn_eliminar_estado = new System.Windows.Forms.Button();
            this.txt_estado_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre_estado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipo_hab)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estado_hab)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 40);
            this.label6.TabIndex = 13;
            this.label6.Text = "CONFIGURACIÓN";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(486, 415);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_tipo_hab);
            this.tabPage1.Controls.Add(this.btn_buscar_tipo);
            this.tabPage1.Controls.Add(this.txt_buscar_tipo);
            this.tabPage1.Controls.Add(this.btn_eliminar_tipo);
            this.tabPage1.Controls.Add(this.btn_modificar_tipo);
            this.tabPage1.Controls.Add(this.btn_guardar_tipo);
            this.tabPage1.Controls.Add(this.txt_tipo_id);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_nombre_tipo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(478, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tipo de habitación";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_tipo_hab
            // 
            this.dgv_tipo_hab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipo_hab.Location = new System.Drawing.Point(20, 184);
            this.dgv_tipo_hab.Name = "dgv_tipo_hab";
            this.dgv_tipo_hab.Size = new System.Drawing.Size(287, 199);
            this.dgv_tipo_hab.TabIndex = 35;
            this.dgv_tipo_hab.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_tipo_hab_CellMouseClick);
            // 
            // btn_buscar_tipo
            // 
            this.btn_buscar_tipo.Image = global::Hotel.Properties.Resources.icon_search;
            this.btn_buscar_tipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar_tipo.Location = new System.Drawing.Point(113, 113);
            this.btn_buscar_tipo.Name = "btn_buscar_tipo";
            this.btn_buscar_tipo.Size = new System.Drawing.Size(87, 38);
            this.btn_buscar_tipo.TabIndex = 34;
            this.btn_buscar_tipo.Text = "Buscar";
            this.btn_buscar_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar_tipo.UseVisualStyleBackColor = true;
            this.btn_buscar_tipo.Click += new System.EventHandler(this.btn_buscar_tipo_Click);
            // 
            // txt_buscar_tipo
            // 
            this.txt_buscar_tipo.Location = new System.Drawing.Point(212, 123);
            this.txt_buscar_tipo.Name = "txt_buscar_tipo";
            this.txt_buscar_tipo.Size = new System.Drawing.Size(95, 20);
            this.txt_buscar_tipo.TabIndex = 33;
            // 
            // btn_eliminar_tipo
            // 
            this.btn_eliminar_tipo.Image = global::Hotel.Properties.Resources.close;
            this.btn_eliminar_tipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar_tipo.Location = new System.Drawing.Point(20, 113);
            this.btn_eliminar_tipo.Name = "btn_eliminar_tipo";
            this.btn_eliminar_tipo.Size = new System.Drawing.Size(87, 38);
            this.btn_eliminar_tipo.TabIndex = 31;
            this.btn_eliminar_tipo.Text = "Eliminar";
            this.btn_eliminar_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar_tipo.UseVisualStyleBackColor = true;
            this.btn_eliminar_tipo.Click += new System.EventHandler(this.btn_eliminar_tipo_Click);
            // 
            // btn_modificar_tipo
            // 
            this.btn_modificar_tipo.Image = global::Hotel.Properties.Resources._036_edit;
            this.btn_modificar_tipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar_tipo.Location = new System.Drawing.Point(313, 228);
            this.btn_modificar_tipo.Name = "btn_modificar_tipo";
            this.btn_modificar_tipo.Size = new System.Drawing.Size(87, 38);
            this.btn_modificar_tipo.TabIndex = 30;
            this.btn_modificar_tipo.Text = "Modificar";
            this.btn_modificar_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar_tipo.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_tipo
            // 
            this.btn_guardar_tipo.Image = global::Hotel.Properties.Resources._035_save;
            this.btn_guardar_tipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar_tipo.Location = new System.Drawing.Point(313, 184);
            this.btn_guardar_tipo.Name = "btn_guardar_tipo";
            this.btn_guardar_tipo.Size = new System.Drawing.Size(87, 38);
            this.btn_guardar_tipo.TabIndex = 23;
            this.btn_guardar_tipo.Text = "       Guardar";
            this.btn_guardar_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar_tipo.UseVisualStyleBackColor = true;
            this.btn_guardar_tipo.Click += new System.EventHandler(this.btn_guardar_tipo_Click);
            // 
            // txt_tipo_id
            // 
            this.txt_tipo_id.Enabled = false;
            this.txt_tipo_id.Location = new System.Drawing.Point(260, 43);
            this.txt_tipo_id.Name = "txt_tipo_id";
            this.txt_tipo_id.Size = new System.Drawing.Size(47, 20);
            this.txt_tipo_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // txt_nombre_tipo
            // 
            this.txt_nombre_tipo.Location = new System.Drawing.Point(70, 43);
            this.txt_nombre_tipo.Name = "txt_nombre_tipo";
            this.txt_nombre_tipo.Size = new System.Drawing.Size(130, 20);
            this.txt_nombre_tipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_estado_hab);
            this.tabPage2.Controls.Add(this.btn_modificar_estado);
            this.tabPage2.Controls.Add(this.btn_agregar_estado);
            this.tabPage2.Controls.Add(this.txt_buscar_estado);
            this.tabPage2.Controls.Add(this.btn_buscar_estado);
            this.tabPage2.Controls.Add(this.btn_eliminar_estado);
            this.tabPage2.Controls.Add(this.txt_estado_id);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_nombre_estado);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(478, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estado de habitación";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_estado_hab
            // 
            this.dgv_estado_hab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estado_hab.Location = new System.Drawing.Point(19, 184);
            this.dgv_estado_hab.Name = "dgv_estado_hab";
            this.dgv_estado_hab.Size = new System.Drawing.Size(305, 199);
            this.dgv_estado_hab.TabIndex = 44;
            // 
            // btn_modificar_estado
            // 
            this.btn_modificar_estado.Image = global::Hotel.Properties.Resources._036_edit;
            this.btn_modificar_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar_estado.Location = new System.Drawing.Point(330, 228);
            this.btn_modificar_estado.Name = "btn_modificar_estado";
            this.btn_modificar_estado.Size = new System.Drawing.Size(87, 38);
            this.btn_modificar_estado.TabIndex = 43;
            this.btn_modificar_estado.Text = "Modificar";
            this.btn_modificar_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar_estado.UseVisualStyleBackColor = true;
            // 
            // btn_agregar_estado
            // 
            this.btn_agregar_estado.Image = global::Hotel.Properties.Resources._035_save;
            this.btn_agregar_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar_estado.Location = new System.Drawing.Point(330, 184);
            this.btn_agregar_estado.Name = "btn_agregar_estado";
            this.btn_agregar_estado.Size = new System.Drawing.Size(87, 38);
            this.btn_agregar_estado.TabIndex = 42;
            this.btn_agregar_estado.Text = "       Guardar";
            this.btn_agregar_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar_estado.UseVisualStyleBackColor = true;
            // 
            // txt_buscar_estado
            // 
            this.txt_buscar_estado.Location = new System.Drawing.Point(217, 125);
            this.txt_buscar_estado.Name = "txt_buscar_estado";
            this.txt_buscar_estado.Size = new System.Drawing.Size(107, 20);
            this.txt_buscar_estado.TabIndex = 41;
            // 
            // btn_buscar_estado
            // 
            this.btn_buscar_estado.Image = global::Hotel.Properties.Resources.icon_search;
            this.btn_buscar_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar_estado.Location = new System.Drawing.Point(112, 115);
            this.btn_buscar_estado.Name = "btn_buscar_estado";
            this.btn_buscar_estado.Size = new System.Drawing.Size(87, 38);
            this.btn_buscar_estado.TabIndex = 40;
            this.btn_buscar_estado.Text = "Buscar";
            this.btn_buscar_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar_estado.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_estado
            // 
            this.btn_eliminar_estado.Image = global::Hotel.Properties.Resources.close;
            this.btn_eliminar_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar_estado.Location = new System.Drawing.Point(19, 115);
            this.btn_eliminar_estado.Name = "btn_eliminar_estado";
            this.btn_eliminar_estado.Size = new System.Drawing.Size(87, 38);
            this.btn_eliminar_estado.TabIndex = 39;
            this.btn_eliminar_estado.Text = "Eliminar";
            this.btn_eliminar_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar_estado.UseVisualStyleBackColor = true;
            // 
            // txt_estado_id
            // 
            this.txt_estado_id.Enabled = false;
            this.txt_estado_id.Location = new System.Drawing.Point(277, 45);
            this.txt_estado_id.Name = "txt_estado_id";
            this.txt_estado_id.Size = new System.Drawing.Size(47, 20);
            this.txt_estado_id.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "ID";
            // 
            // txt_nombre_estado
            // 
            this.txt_nombre_estado.Location = new System.Drawing.Point(69, 45);
            this.txt_nombre_estado.Name = "txt_nombre_estado";
            this.txt_nombre_estado.Size = new System.Drawing.Size(130, 20);
            this.txt_nombre_estado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // Frm_configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 531);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Name = "Frm_configuracion";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipo_hab)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estado_hab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_tipo_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guardar_tipo;
        private System.Windows.Forms.Button btn_eliminar_tipo;
        private System.Windows.Forms.TextBox txt_buscar_tipo;
        private System.Windows.Forms.DataGridView dgv_tipo_hab;
        private System.Windows.Forms.Button btn_buscar_tipo;
        private System.Windows.Forms.DataGridView dgv_estado_hab;
        private System.Windows.Forms.Button btn_modificar_estado;
        private System.Windows.Forms.Button btn_agregar_estado;
        private System.Windows.Forms.TextBox txt_buscar_estado;
        private System.Windows.Forms.Button btn_buscar_estado;
        private System.Windows.Forms.Button btn_eliminar_estado;
        private System.Windows.Forms.TextBox txt_estado_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre_estado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_modificar_tipo;
    }
}