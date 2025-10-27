using System.Collections.Generic;
using System;

namespace Practica_4
{

    public class Aula
    {
        Teacher teacher;



        public Aula()
        {
            teacher = new Teacher();
        }

        public void comenzar()
        {
            Console.WriteLine("Creando teacher");

            teacher = new Teacher();
        }

        public void nuevoAlumno(Student a)
        {
            teacher.goToClass((Student)a);
        }

        public void claseLista()
        {
            teacher.teachingAClass();
        }


    }
}