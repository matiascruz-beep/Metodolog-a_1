using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    internal class OrdenDecorator :StudentDecorator
    {
        private int orden;

        public OrdenDecorator(IStudent student, int orden)
            : base(student)
        {
            this.orden = orden;
        }

        public override string showResult()
        {
            return $"{orden}) {student.showResult()}";
        }
    }
}
