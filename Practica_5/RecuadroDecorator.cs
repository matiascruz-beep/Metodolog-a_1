using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    internal class RecuadroDecorator :StudentDecorator
    {
        public RecuadroDecorator(IStudent student)
        : base(student) { }

        public override string showResult()
        {
            string contenido = student.showResult();
            string borde = new string('*', contenido.Length + 4);
            return $"{borde}\n* {contenido} *\n{borde}";
        }
    }
}
