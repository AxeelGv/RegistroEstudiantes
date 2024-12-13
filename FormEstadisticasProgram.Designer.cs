namespace RegistroEstudiantes
{
    partial class FormEstadisticasProgram
    {
        private System.Windows.Forms.Label lblPromedioEdad;
        private System.Windows.Forms.Label lblTotalPorGrado;
        private System.Windows.Forms.Label lblPorcentajeBecados;

        private void InitializeComponent()
        {
            this.lblPromedioEdad = new System.Windows.Forms.Label();
            this.lblTotalPorGrado = new System.Windows.Forms.Label();
            this.lblPorcentajeBecados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPromedioEdad
            // 
            this.lblPromedioEdad.AutoSize = true;
            this.lblPromedioEdad.Location = new System.Drawing.Point(20, 20);
            this.lblPromedioEdad.Name = "lblPromedioEdad";
            this.lblPromedioEdad.Size = new System.Drawing.Size(97, 13);
            this.lblPromedioEdad.TabIndex = 0;
            this.lblPromedioEdad.Text = "Promedio de Edad:";
            // 
            // lblTotalPorGrado
            // 
            this.lblTotalPorGrado.AutoSize = true;
            this.lblTotalPorGrado.Location = new System.Drawing.Point(20, 60);
            this.lblTotalPorGrado.Name = "lblTotalPorGrado";
            this.lblTotalPorGrado.Size = new System.Drawing.Size(84, 13);
            this.lblTotalPorGrado.TabIndex = 1;
            this.lblTotalPorGrado.Text = "Total por Grado:";
            // 
            // lblPorcentajeBecados
            // 
            this.lblPorcentajeBecados.AutoSize = true;
            this.lblPorcentajeBecados.Location = new System.Drawing.Point(20, 100);
            this.lblPorcentajeBecados.Name = "lblPorcentajeBecados";
            this.lblPorcentajeBecados.Size = new System.Drawing.Size(121, 13);
            this.lblPorcentajeBecados.TabIndex = 2;
            this.lblPorcentajeBecados.Text = "Porcentaje de Becados:";
            // 
            // FormEstadisticas
            // 
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.lblPromedioEdad);
            this.Controls.Add(this.lblTotalPorGrado);
            this.Controls.Add(this.lblPorcentajeBecados);
            this.Name = "FormEstadisticas";
            this.Text = "Estadísticas";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
