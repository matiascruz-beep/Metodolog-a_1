using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{

    public class PorPromedio : comparoAlumno
    {

        public bool sosIgual(Alumno a1, Alumno a2)
        {
            return a1.Promedio == a2.Promedio;
        }
        public bool sosMenor(Alumno a1, Alumno a2)
        {
            return a1.Promedio < a2.Promedio;
        }
        public bool sosMayor(Alumno a1, Alumno a2)
        {
            return a1.Promedio > a2.Promedio;
        }
    }
}
