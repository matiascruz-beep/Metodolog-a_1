

using System;

namespace Ejercicio__
{
	class Program
	{
		public static void Main(string[] args)
		{
			Comparable n1 = new Numero(10);
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
			
			Console.WriteLine(n1.sosigual(n2));
			Console.ReadKey();
		}
		
		//Ejercicio 5
		public void llenar(Coleccionable c){
			
			Random rnd = new Random();
			
			for (int i=0 ; i<20 ; i++){
				
				int num = rnd.Next(1, 101); 
				
				Comparable numq = new Numero(num);
				
				c.agregar(numq);
			}
		}
		
		//Ejercicio 6
		
		public void informar(Coleccionable c){
			
			double cantidad_elementos = c.cuantos();
			
			Console.WriteLine("Cantidad de elementos del coleecionable: {0}",cantidad_elementos);
			
		}
	}
}