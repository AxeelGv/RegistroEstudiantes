using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiantes
{
    public class Estadisticas
    {
        public static double CalcularPromedioEdad(List<Estudiante> estudiantes)
        {
            return estudiantes.Any() ? estudiantes.Average(e => e.Edad) : 0;
        }

        public static Dictionary<string, int> TotalPorGrado(List<Estudiante> estudiantes)
        {
            return estudiantes.GroupBy(e => e.Grado)
                              .ToDictionary(g => g.Key, g => g.Count());
        }

        public static double CalcularPorcentajeBecados(List<Estudiante> estudiantes)
        {
            if (!estudiantes.Any()) return 0;
            int totalBecados = estudiantes.Count(e => e.Estado == "Becado");
            return (double)totalBecados / estudiantes.Count * 100;
        }
    }
}
