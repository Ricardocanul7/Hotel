namespace Hotel.GUI
{
    partial class Frm_reporte_reserva
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
            this.Contenedor_reporte_reservas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Contenedor_reporte_reservas
            // 
            this.Contenedor_reporte_reservas.ActiveViewIndex = -1;
            this.Contenedor_reporte_reservas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contenedor_reporte_reservas.Cursor = System.Windows.Forms.Cursors.Default;
            this.Contenedor_reporte_reservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor_reporte_reservas.Location = new System.Drawing.Point(0, 0);
            this.Contenedor_reporte_reservas.Name = "Contenedor_reporte_reservas";
            this.Contenedor_reporte_reservas.Size = new System.Drawing.Size(800, 450);
            this.Contenedor_reporte_reservas.TabIndex = 0;
            // 
            // Frm_reporte_reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contenedor_reporte_reservas);
            this.Name = "Frm_reporte_reserva";
            this.Text = "Frm_reporte_reserva";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Contenedor_reporte_reservas;
    }
}