using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    public interface comparoAlumno
    {

        //bool comparar(Alumno a1, Alumno a2);
        bool sosIgual(Alumno a1, Alumno a2);
        bool sosMenor(Alumno a1, Alumno a2);
        bool sosMayor(Alumno a1, Alumno a2);
    }
}
