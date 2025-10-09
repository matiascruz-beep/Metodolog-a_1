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
            var partes = student.showResult().Split(' ');
            int nota = int.Parse(partes.Last());
            return $"{student.showResult()} ({Estado(nota)})";
        }
    }
}
