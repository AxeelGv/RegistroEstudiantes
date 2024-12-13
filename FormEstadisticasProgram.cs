using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiantes
{
    public partial class FormEstadisticasProgram : Form
    {
        public double PromedioEdad { get; set; }
        public Dictionary<string, int> TotalPorGrado { get; set; }
        public double PorcentajeBecados { get; set; }

        public FormEstadisticasProgram()
        {
            InitializeComponent();
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            lblPromedioEdad.Text = $"Promedio de Edad: {PromedioEdad:F2}";
            lblTotalPorGrado.Text = "Total por Grado: " + string.Join(", ", TotalPorGrado);
            lblPorcentajeBecados.Text = $"Porcentaje de Becados: {PorcentajeBecados:F2}%";
        }
    }
}
