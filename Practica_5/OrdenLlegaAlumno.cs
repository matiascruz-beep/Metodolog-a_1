using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    internal class OrdenLlegaAlumno : OrdenEnAula2
    {
        Aula aula;

        public OrdenLlegaAlumno()
        {
            aula = new Aula();
        }

        public void ejecutar(Comparable a)
        {
            aula.nuevoAlumno((Alumno)a);
        }
    }
}
