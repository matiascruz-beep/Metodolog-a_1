

using System;

namespace Ejercicio__
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*Comparable n1 = new Numero(10);
			Comparable n2 = new Numero(2);
			Comparable n3 = new Numero(20);
			
			cola c = new cola();
			
			c.agregar(n1);
			c.agregar(n2);
			c.agregar(n3);
			
			Console.WriteLine(c.minimo());
			
			pila p = new pila();
			
			p.agregar(n1);
			p.agregar(n2);
			p.agregar(n3);
			
			Console.WriteLine(p.maximo());
			
			Console.WriteLine(n1.sosigual(n2));*/
			
			//Ejercicio 7
			
			/*pila p = new pila();
			
			cola c = new cola();
			
			llenar(p);
			llenar(c);
			
			informar(p);
			informar(c);*/
			
			//Ejercicio 9
			
			/*pila p = new pila();
			cola c = new cola();
			ColeccionMultiple multiple = new ColeccionMultiple(p,c);
			
			llenar(p);
			llenar(c);
			
			informar(p);
			informar(c);
			
			informar(multiple);
			*/
			
			//Ejercicio 14
			pila p = new pila();
			cola c = new cola();
			ColeccionMultiple multiple = new ColeccionMultiple(p,c);
			
			llenarAlumnos(p);
			llenarAlumnos(c);
			
			informar(multiple);
			
			
			Console.ReadKey();
		}
		
		//Ejercicio 5
		public static void llenar(Coleccionable c){
			
			Random rnd = new Random();
			
			for (int i=0 ; i<20 ; i++){
				
				int num = rnd.Next(1, 101); 
				
				Comparable numq = new Numero(num);
				
				c.agregar(numq);
			}
		}
		
		//Ejercicio 6
		
		public static void informar(Coleccionable c){
			
			double cantidad_elementos = c.cuantos();
			
			Console.WriteLine("Cantidad de elementos del coleecionable: {0}",cantidad_elementos);
			
			Comparable minimo = c.minimo();
			
			Console.WriteLine("El minimo es: {0}", minimo);
			
			Comparable maximo = c.maximo();
			
			Console.WriteLine("El maximo es: {0}", maximo);
			
			Console.Write("Escriba un numero: ");
			
			int num_elegido = int.Parse(Console.ReadLine());
			
			Comparable col = new Numero(num_elegido);
			
			if(c.contiene(col)){
				
				Console.WriteLine("El coleccionable leido esta en la colección");
			}
			else{Console.WriteLine("El coleccionable leido no esta en la colección");}
			
		}
		
		//Ejercicio 13
		
		public static void llenarAlumnos(Coleccionable c){
			
			string[] nombres = { "Ana", "Luis", "María", "Pedro", "Lucía", "Carlos", "Sofía", "Mateo", "Valentina", "Julián","Matias","Juan"};
			Random rnd = new Random();
			for (int i=0 ; i<19 ; i++){
				
				string nombre = nombres[rnd.Next(nombres.Length)];
        		int dni = rnd.Next(10000000, 50000000);       // DNI al azar
        		int legajo = rnd.Next(1000, 9999);           // Legajo al azar
       			double promedio = Math.Round(rnd.NextDouble() * 10, 2); // Promedio entre 0 y 10 con decimales

       			Alumno a = new Alumno(nombre, dni, legajo, promedio);
       			c.agregar(a);
			}
		}
		
	}
}