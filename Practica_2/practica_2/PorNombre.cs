using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2
{

    public class PorNombre : comparoAlumno
    {

        public bool sosIgual(Alumno a1, Alumno a2)
        {
            return a1.Nombre == a2.Nombre;
        }
        public bool sosMenor(Alumno a1, Alumno a2)
        {
            return string.Compare(a1.Nombre, a2.Nombre) < 0;
        }
        public bool sosMayor(Alumno a1, Alumno a2)
        {
            return string.Compare(a1.Nombre, a2.Nombre) > 0;
        }
    }
}
