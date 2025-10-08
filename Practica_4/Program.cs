using System;
using System.ComponentModel;
using System.Data.Common;

namespace Practica_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Ejercicio 4
            Teacher teach = new Teacher();

            for(int i=0; i<10; i++)
            {
                Alumno a = (Alumno)crearComparable();
                Adaptador adapter = new Adaptador(a);
            
                teach.goToClass(adapter);
            }

            for (int i = 0; i < 10; i++) {

                AlumnoMuyEstudioso a = (AlumnoMuyEstudioso)crearComparable_2();
                Adaptador adapterc = new Adaptador(a);
                teach.goToClass(adapterc);
            }

            teach.teachingAClass();

        }


        public static Comparable crearComparable()
        {
            string[] nombres = { "Ana", "Luis", "María", "Pedro", "Lucía", "Carlos", "Sofía", "Mateo", "Valentina", "Julián", "Matias", "Juan" };
            Random rnd = new Random();
            string nombre = nombres[rnd.Next(nombres.Length)];
            int dni = rnd.Next(10000000, 50000000);  // DNI al azar
            int legajo = rnd.Next(1000, 9999);      // Legajo al azar
            double promedio = Math.Round(rnd.NextDouble() * 10, 2); // Promedio entre 0 y 10 con decimales
            Alumno a = new Alumno(nombre, dni, legajo, promedio, new PorDni());
            return a;
        }

        public static Comparable crearComparable_2()
        {
            string[] nombres = { "Ana", "Luis", "María", "Pedro", "Lucía", "Carlos", "Sofía", "Mateo", "Valentina", "Julián", "Matias", "Juan" };
            Random rnd = new Random();
            string nombre = nombres[rnd.Next(nombres.Length)];
            int dni = rnd.Next(10000000, 50000000);  // DNI al azar
            int legajo = rnd.Next(1000, 9999);      // Legajo al azar
            double promedio = Math.Round(rnd.NextDouble() * 10, 2); // Promedio entre 0 y 10 con decimales
            AlumnoMuyEstudioso a = new AlumnoMuyEstudioso(nombre, dni, legajo, promedio, new PorDni());
            return a;
        }
    }

}
