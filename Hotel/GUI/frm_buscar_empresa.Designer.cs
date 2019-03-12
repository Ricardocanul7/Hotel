namespace Hotel.GUI
{
    partial class frm_buscar_empresa
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_buscar_empresa = new System.Windows.Forms.Button();
            this.dgv_buscar_empresas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscar_empresas)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 40);
            this.label6.TabIndex = 32;
            this.label6.Text = "BUSCAR EMPRESA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 20);
            this.textBox1.TabIndex = 33;
            // 
            // btn_buscar_empresa
            // 
            this.btn_buscar_empresa.Image = global::Hotel.Properties.Resources.add1;
            this.btn_buscar_empresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar_empresa.Location = new System.Drawing.Point(423, 74);
            this.btn_buscar_empresa.Name = "btn_buscar_empresa";
            this.btn_buscar_empresa.Size = new System.Drawing.Size(100, 42);
            this.btn_buscar_empresa.TabIndex = 37;
            this.btn_buscar_empresa.Text = "Buscar";
            this.btn_buscar_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar_empresa.UseVisualStyleBackColor = true;
            // 
            // dgv_buscar_empresas
            // 
            this.dgv_buscar_empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buscar_empresas.Location = new System.Drawing.Point(35, 134);
            this.dgv_buscar_empresas.Name = "dgv_buscar_empresas";
            this.dgv_buscar_empresas.Size = new System.Drawing.Size(520, 247);
            this.dgv_buscar_empresas.TabIndex = 38;
            // 
            // frm_buscar_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 394);
            this.Controls.Add(this.dgv_buscar_empresas);
            this.Controls.Add(this.btn_buscar_empresa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Name = "frm_buscar_empresa";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscar_empresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_buscar_empresa;
        private System.Windows.Forms.DataGridView dgv_buscar_empresas;
    }
}