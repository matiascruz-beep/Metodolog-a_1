

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
			
			pila p = new pila();
			
			cola c = new cola();
			
			llenar(p);
			llenar(c);
			
			informar(p);
			informar(c);
			
			
			
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
	}
}