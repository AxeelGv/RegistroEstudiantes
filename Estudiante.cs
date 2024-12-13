using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiantes
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Grado { get; set; }
        public string Estado { get; set; } 

        public Estudiante(string nombre, int edad, string grado, string estado)
        {
            Nombre = nombre;
            Edad = edad;
            Grado = grado;
            Estado = estado;
        }
    }
}
