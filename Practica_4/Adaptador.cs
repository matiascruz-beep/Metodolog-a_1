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
            if (student is Adaptador adaptador)
                return a.sosmenor(adaptador.a); // compara el Alumno interno
            else if (student is Alumno alumno)
                return a.sosmenor(alumno);
            else
                throw new InvalidOperationException("Tipo no compatible para comparación");
        }
        public bool greaterThan(Student student)
        {
            if (student is Adaptador adaptador)
                return a.sosmayor(adaptador.a);
            else if (student is Alumno alumno)
                return a.sosmayor(alumno);
            else
                throw new InvalidOperationException("Tipo no compatible para comparación");
        }



    }
}
