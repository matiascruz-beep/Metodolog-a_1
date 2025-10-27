using System;
using System.ComponentModel;
using System.Data.Common;

namespace Practica_4
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Creo el Aula
            Aula aula = new Aula();

            //creo la colección 
            Pila pila = new Pila();  // Podés usar también Cola cola = new Cola();

            // creo las órdenes
            OrdenEnAula1 ordenInicio = new OrdenInicio(aula);
            OrdenEnAula2 ordenLlegaAlumno = new OrdenLlegaAlumno(aula);
            OrdenEnAula1 ordenAulaLlena = new OrdenAulaLlena(aula);

            //seteo las órdenes en la pila
            pila.setOrdenInicio(ordenInicio);
            pila.setOrdenLlegaAlumno(ordenLlegaAlumno);
            pila.setOrdenAulaLlena(ordenAulaLlena);
            //--------------------------------------------------------------------//

            //Ejercicio 4
            Teacher teach = new Teacher();
            // Lista para guardar los alumnos adaptados que luego vamos a decorar
            List<IStudent> alumnosDecorables = new List<IStudent>();
            Random rnd = new Random();


            //Aca lleno la pila con los estudiantes (es parte del ejercicio 4 pero lo uso para llenar la pila, que es
            //lo que me pide el ejercicio 10 de la practica 5)
            for (int i=0; i<15; i++)
            {
                int nota = rnd.Next(1,11);
                Alumno a = (Alumno)crearComparable();
                a.Calificacion = nota;
                Adaptador adapter = new Adaptador(a);
                pila.agregar(adapter);
                alumnosDecorables.Add(adapter); // guardamos para decorar después

                teach.goToClass(adapter);
            }

            for (int i = 0; i < 15; i++) {
                int nota = rnd.Next(1, 11);
                AlumnoMuyEstudioso a = (AlumnoMuyEstudioso)crearComparable_2();
                a.Calificacion = nota;
                Adaptador adapterc = new Adaptador(a);
                pila.agregar(adapterc);
                alumnosDecorables.Add(adapterc); // guardamos también
                teach.goToClass(adapterc);
            }
            Console.WriteLine("Carga de alumnos finalizada.");


            //Es parte del codigo pero lo comente para ejecutar el ejercicio 10 de la practica 5


            //teach.teachingAClass();

            // MOSTRAR DECORADOS
            /*Console.WriteLine("\n======= RESULTADOS DECORADOS =======\n");

            int orden = 1;
            foreach (var student in alumnosDecorables)
            {
                IStudent decorado = new LegajoDecorator(student);
                decorado = new NotaEnLetrasDecorator(decorado);
                decorado = new EstadoDecorator(decorado);
                decorado = new RecuadroDecorator(decorado);
                decorado = new OrdenDecorator(decorado, orden++);

                Console.WriteLine(decorado.showResult() + "\n");
            }

            //Pruebo la funcionalidad del ejercicio 1 practica 5
            IAlumno a1 = new ProxyAlumno("Lucía", 12345678, 101, 8.5, new PorLegajo(),false);
            IAlumno a2 = new ProxyAlumno("Martín", 87654321, 102, 9.0, new PorLegajo(), true);

            // Hasta ahora NO se crearon los alumnos reales
            Console.WriteLine(a1.Nombre); // Muestra sin instanciar el Alumno real
            Console.WriteLine(a2.Nombre); // idem

            // En este momento se crea el alumno real
            Console.WriteLine(a1.ResponderPregunta(3));
            Console.WriteLine(a2.ResponderPregunta(3));

            */

            Console.ReadKey(true);
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
