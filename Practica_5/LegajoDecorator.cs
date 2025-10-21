using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    internal class LegajoDecorator : StudentDecorator
    {

        public LegajoDecorator(IStudent student)
            : base(student)
        {
        }

        public override string showResult()
        {
            string legajo = "";

            // Si el student interno es un Adaptador, obtener el legajo desde su Alumno
            if (student is Adaptador adaptador)
            {
                legajo = adaptador.GetLegajo().ToString();
            }

            return $"{student.showResult()} ({legajo})";
        }
    }
}
