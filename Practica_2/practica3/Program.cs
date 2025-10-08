using System;
using System.Collections.Generic;

namespace practica3
{
	class Program
	{
	public static void Main(string[] args)
		{
			pila p = new pila();
			/*Console.Write("Ingrese una opcion: ");
			int op = int.Parse(Console.ReadLine());
			pila p = new pila();
			llenar(p,op);
			informar(p,op);*/
			Profesor profesor = new Profesor("Matias",23423423,12);

   			/*Alumno a1 = new Alumno("Ana",23432423,1,9);
        	Alumno a2 = new Alumno("Luis",32423423,2,10);

        	profesor.agregarObservador(a1);
        	profesor.agregarObservador(a2);

        	profesor.hablarALaClase();
        	Console.WriteLine();
        	profesor.escribirEnElPizarron();
        	Console.WriteLine();*/
        	
        	//Ejercicio 14
        		string[] nombres = { "Ana", "Luis", "María", "Pedro", "Lucía", "Carlos", "Sofía", "Mateo", "Valentina", "Julián","Matias","Juan"};
				Random rnd = new Random();
        		for(int i = 0  ; i<19 ; i++){
				string nombre = nombres[rnd.Next(nombres.Length)];
  				int dni = rnd.Next(10000000, 50000000);  // DNI al azar
  				int legajo = rnd.Next(1000, 9999);      // Legajo al azar
    			double promedio = Math.Round(rnd.NextDouble() * 10, 2); // Promedio entre 0 y 10 con decimales
    			Alumno a = new Alumno(nombre, dni, legajo, promedio, new PorDni());
        		profesor.agregarObservador(a);
        		Console.WriteLine(a.Nombre);
        	}
				
			
        	
        	dictadoDeClases(profesor);
        	
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	
	public static void dictadoDeClases(Profesor p){
		for(int i=0 ; i < 4 ; i++){
			p.hablarALaClase();
			p.escribirEnElPizarron();
		}
	}
		
	public static void llenar(Coleccionable c, int opcion){
		
		for (int i=0 ; i<20 ; i++){
		
				Comparable col = fabricaDeComparables.crearComparable(opcion);
				c.agregar(col);
			}
		}
		
	public static void informar(Coleccionable c, int opcion){
			Console.WriteLine(c.cuantos());
			Console.WriteLine(c.minimo());
			Console.WriteLine(c.maximo());
			Comparable comp = fabricaDeComparables.crearPorTeclado(opcion);
			if(c.contiene(comp) == true){
				Console.WriteLine("El coleccionable leido está en la colección");
			}else{
				Console.WriteLine("El coleccionable leido NO está en la colección");
			}
			
		}
	}
}