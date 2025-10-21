using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    internal abstract class StudentDecorator : IStudent
    {
        public IStudent student;

        public StudentDecorator(IStudent student)
        {
            this.student = student;
        }

        public int Calificacion { get; }
        public virtual string showResult()
        {
            return student.showResult();
        }
    }
}
