using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiantes
{
    public class GestorEstudiantes
    {
        private List<Estudiante> estudiantes;

        public GestorEstudiantes()
        {
            estudiantes = new List<Estudiante>();
        }

        
        public List<Estudiante> ObtenerEstudiantes()
        {
            return estudiantes;
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
        }

     
        public void EditarEstudiante(int index, Estudiante estudiante)
        {
            if (index >= 0 && index < estudiantes.Count)
            {
                estudiantes[index] = estudiante;
            }
        }

        public void EliminarEstudiante(int index)
        {
            if (index >= 0 && index < estudiantes.Count)
            {
                estudiantes.RemoveAt(index);
            }
        }

        public void CargarDatosIniciales()
        {
            estudiantes.Add(new Estudiante("Abel Marin", 16, "Octavo", "Regular"));
            estudiantes.Add(new Estudiante("Axel Gomez", 11, "Sexto", "Regular"));
            estudiantes.Add(new Estudiante("Julio Lopez", 19, "Undecimo", "Becado"));
        }
    }

}
