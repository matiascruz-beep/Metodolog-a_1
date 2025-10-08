using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    internal class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string n, double d, double l, double p, comparoAlumno comp) : base(n,d,l,p,comp) {
        
        }
        public override int ResponderPregunta(int pregunta)
        {
            return pregunta;
        }
    }
}
