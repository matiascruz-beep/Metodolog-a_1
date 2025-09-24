/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 15/9/2025
 * Time: 16:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace practica_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			pila p = new pila();
			cola c = new cola();
			llenarAlumnos(p);
			llenarAlumnos(c);	
			Console.ReadKey(true);
	}		
		//Ejercicio 2
			public static void llenarAlumnos(Coleccionable c){
			
			string[] nombres = { "Ana", "Luis", "María", "Pedro", "Lucía", "Carlos", "Sofía", "Mateo", "Valentina", "Julián","Matias","Juan"};
			Random rnd = new Random();
			for (int i=0 ; i<19 ; i++){
				
				string nombre = nombres[rnd.Next(nombres.Length)];
        		int dni = rnd.Next(10000000, 50000000);       // DNI al azar
        		int legajo = rnd.Next(1000, 9999);           // Legajo al azar
       			double promedio = Math.Round(rnd.NextDouble() * 10, 2); // Promedio entre 0 y 10 con decimales
				
       			
       			Alumno a = new Alumno(nombre, dni, legajo, promedio, new PorDni());
       			c.agregar(a);
			}
		}
		
		public void imprimirElementos(Coleccionable c){ 
			
			Iterable iter = (Iterable)c;
			
			Iterador it = iter.crearIterador();
			it.primero();
			while(!it.fin()){
				Console.WriteLine(it.actual());
				it.siguiente();
				
			}
		}
}
	
}
