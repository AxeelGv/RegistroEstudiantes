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
    public partial class FormEstudianteProgram : Form
    {
        public Estudiante Estudiante { get;  set; }

        public FormEstudianteProgram()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre");
                return;
            }

            if (cmbGrado.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un grado");
                return;
            }

            Estudiante = new Estudiante(
                txtNombre.Text,
                (int)numEdad.Value,
                cmbGrado.SelectedItem.ToString(),
                radioBecado.Checked ? "Becado" : "Regular"
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormEstudianteProgram_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
