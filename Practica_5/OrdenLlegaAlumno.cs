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

        public OrdenLlegaAlumno(Aula a)
        {
            aula = a;
        }

        public void ejecutar(Comparable c)
        {
            if (c is Adaptador adapter)
            {
                aula.nuevoAlumno(adapter); // ✅ Adaptador implementa Student
            }
            else
            {
                throw new InvalidOperationException("Tipo de alumno no soportado");
            }
        }
    }
}
