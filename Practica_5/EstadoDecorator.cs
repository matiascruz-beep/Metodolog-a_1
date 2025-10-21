using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    internal class EstadoDecorator :StudentDecorator
    {
        public EstadoDecorator(IStudent student)
       : base(student) { }

        private string Estado(int nota)
        {
            if (nota >= 7) return "PROMOCIÓN";
            if (nota >= 4) return "APROBADO";
            return "DESAPROBADO";
        }

        public override string showResult()
        {
            string original = student.showResult();
            int nota = student.Calificacion; // tomamos la nota directamente
            string estado = Estado(nota);
            return $"{original} ({estado})";
        }
    }
}
