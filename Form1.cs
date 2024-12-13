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
    public partial class Form1 : Form
    {
        private List<Estudiante> estudiantes;

        public Form1()
        {
            InitializeComponent();
            estudiantes = new List<Estudiante>();
        }

        private GestorEstudiantes gestor;

        private void Form1_Load(object sender, EventArgs e)
        {
            gestor = new GestorEstudiantes();
            gestor.CargarDatosIniciales();
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            dataGridViewEstudiantes.DataSource = null;
            dataGridViewEstudiantes.DataSource = gestor.ObtenerEstudiantes();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            var estudiantes = gestor.ObtenerEstudiantes();
            var promedioEdad = Estadisticas.CalcularPromedioEdad(estudiantes);
            var totalPorGrado = Estadisticas.TotalPorGrado(estudiantes);
            var porcentajeBecados = Estadisticas.CalcularPorcentajeBecados(estudiantes);

            var formEstadisticas = new FormEstadisticasProgram
            {
                PromedioEdad = promedioEdad,
                TotalPorGrado = totalPorGrado,
                PorcentajeBecados = porcentajeBecados
            };

            formEstadisticas.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormEstudianteProgram formEstudiante = new FormEstudianteProgram();

            if (formEstudiante.ShowDialog() == DialogResult.OK)
            {
                if (formEstudiante.Estudiante == null)
                {
                    MessageBox.Show("El estudiante no se ha creado correctamente.");
                    return;
                }

                estudiantes.Add(formEstudiante.Estudiante);
                ActualizarDataGridView(); 
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEstudiantes.CurrentRow != null)
            {
                int index = dataGridViewEstudiantes.CurrentRow.Index;
                var estudianteSeleccionado = gestor.ObtenerEstudiantes()[index];

                var formEstudiante = new FormEstudianteProgram
                {
                    Estudiante = estudianteSeleccionado
                };

                if (formEstudiante.ShowDialog() == DialogResult.OK)
                {
                    gestor.EditarEstudiante(index, formEstudiante.Estudiante);
                    ActualizarTabla();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEstudiantes.CurrentRow != null)
            {
                int index = dataGridViewEstudiantes.CurrentRow.Index;
                gestor.EliminarEstudiante(index);
                ActualizarTabla();
            }
        }

        private void ActualizarDataGridView()
        {
            dataGridViewEstudiantes.DataSource = null;
            dataGridViewEstudiantes.DataSource = estudiantes; 
        }

        private void dataGridViewEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
