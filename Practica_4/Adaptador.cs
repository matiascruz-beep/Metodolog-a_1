using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    internal class Adaptador : Student
    {
        Alumno a;

        public Adaptador(Alumno i)
        {
            this.a = i;
        }

        public string getName()
        {
            return a.Nombre.ToString();
        }
        public int yourAnswerIs(int question)
        {
            return a.ResponderPregunta(question);
        }
        public void setScore(int score)
        {
            a.Calificacion = score;
        }
        public string showResult()
        {
            return a.MostrarCalificacion();
        }
        public bool equals(Student student)
        {
            return student == this;
        }
        public bool lessThan(Student student)
        {
            return a.sosmenor((Alumno)student);
        }
        public bool greaterThan(Student student)
        {
            return a.sosmayor((Alumno)student);
        }



    }
}
