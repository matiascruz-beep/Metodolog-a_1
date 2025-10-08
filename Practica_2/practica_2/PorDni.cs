using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2
{

    public class PorDni : comparoAlumno
    {

        public bool sosIgual(Alumno a1, Alumno a2)
        {
            return a1.Dni == a2.Dni;
        }
        public bool sosMenor(Alumno a1, Alumno a2)
        {
            return a1.Dni < a2.Dni;
        }
        public bool sosMayor(Alumno a1, Alumno a2)
        {
            return a1.Dni > a2.Dni;
        }
    }
}
