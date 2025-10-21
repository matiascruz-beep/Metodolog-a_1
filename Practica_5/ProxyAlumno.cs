using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    internal class ProxyAlumno : Alumno, IAlumno
    {
        // Referencia al alumno real
        private IAlumno alumnoReal = null;

        // Datos necesarios para crear el alumno real
        private bool esMuyEstudioso;

        // Constructor
        public ProxyAlumno(string n, double d, double l, double p, comparoAlumno comp, bool muyEstudioso = false) : base(n, d, l, p, comp)
        {
            this.esMuyEstudioso = muyEstudioso;
        }

        // El proxy puede devolver datos simples sin crear al alumno real
        public override int ResponderPregunta(int pregunta) // Se agrega 'override' para solucionar CS0114
        {
            // Creamos el alumno real solo si hace falta responder
            if (alumnoReal == null)
            {
                if (esMuyEstudioso)
                {
                    this.alumnoReal = (AlumnoMuyEstudioso)Program.crearComparable_2();
                    Console.WriteLine("Se ha creado el alumno Estudioso con exito");
                }
                else
                {
                    this.alumnoReal = (Alumno)Program.crearComparable();
                    Console.WriteLine("Se ha creado el alumno con exito");
                }
            }

            // Delegamos la pregunta al alumno real
            return alumnoReal.ResponderPregunta(pregunta);
        }
    }
}

