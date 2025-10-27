using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    internal class Adaptador : Student, IStudent, Comparable
    {
        private Alumno a;

        public Adaptador(Alumno i)
        {
            this.a = i;
        }

        // Propiedad de calificación
        public int Calificacion
        {
            get => a.Calificacion;
        }

        // Métodos IStudent
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
                return a.sosmenor(adaptador.a);
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

        public double GetLegajo()
        {
            return a.Legajo;
        }

        // 🔹 Métodos Comparable para trabajar con Pila/Cola
        public bool sosmenor(Comparable c)
        {
            if (c is Adaptador adaptador)
                return a.sosmenor(adaptador.a);
            throw new InvalidOperationException("Tipo incompatible para comparación");
        }

        public bool sosmayor(Comparable c)
        {
            if (c is Adaptador adaptador)
                return a.sosmayor(adaptador.a);
            throw new InvalidOperationException("Tipo incompatible para comparación");
        }

        public bool sosigual(Comparable c)
        {
            if (c is Adaptador adaptador)
                return a.Legajo == adaptador.a.Legajo; // o cualquier criterio de igualdad
            throw new InvalidOperationException("Tipo incompatible para comparación");
        }
    }
}
