using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    internal class LegajoDecorator : StudentDecorator
    {
        private string legajo;

        public LegajoDecorator(IStudent student, string legajo)
            : base(student)
        {
            this.legajo = legajo;
        }

        public override string showResult()
        {
            return $"{student.showResult()} ({legajo})";
        }
    }
}
