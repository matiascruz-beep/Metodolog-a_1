/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 24/9/2025
 * Time: 19:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica3
{
	/// <summary>
	/// Description of fabricaDeComparables.
	/// </summary>
	public abstract class fabricaDeComparables
	{
		
		public static Comparable crearComparable(int opcion){
			
			fabricaDeComparables comparable = null;
			
			if(opcion == 1){
				
				comparable = new FabricaDeAlumnos();
			}
			if(opcion == 2){
				
				comparable = new FabricaDeNumeros();
			}
			
			return comparable.crearComparable();
		}
		
	public abstract Comparable crearComparable();
		//Metodos
		public static Comparable crearAleatorio(int opcion){
			
			if(opcion == 1){
			string[] nombres = { "Ana", "Luis", "María", "Pedro", "Lucía", "Carlos", "Sofía", "Mateo", "Valentina", "Julián","Matias","Juan"};
			Random rnd = new Random();
			string nombre = nombres[rnd.Next(nombres.Length)];
  			int dni = rnd.Next(10000000, 50000000);  // DNI al azar
  			int legajo = rnd.Next(1000, 9999);      // Legajo al azar
    		double promedio = Math.Round(rnd.NextDouble() * 10, 2); // Promedio entre 0 y 10 con decimales
    		Alumno a = new Alumno(nombre, dni, legajo, promedio, new PorDni());
    		return a;
			}
			else if (opcion ==2){
				
				Random rnd = new Random();
				int num = rnd.Next(0, 9999);  // numero al azar
				Numero n = new Numero(num);
				return n;
			}
			else{
				return null;
				}
				
		}
		
		public static Comparable crearPorTeclado(int opcion){
			
			if(opcion == 1){
				
				Console.WriteLine("Nombre: ");
				string nom = Console.ReadLine();
				Console.WriteLine("Dni: ");
				double dni = double.Parse(Console.ReadLine());
				Console.WriteLine("Legajo: ");
				int leg = int.Parse(Console.ReadLine());
				Console.WriteLine("Promedio: ");
				double prom = double.Parse(Console.ReadLine());
				
				Alumno a = new Alumno(nom,dni,leg,prom);
				
				return a;
				
			}
			else if(opcion == 2){
				
				Console.WriteLine("Ingrese numero: ");
				int num = int.Parse(Console.ReadLine());
				
				Numero n = new Numero(num);
				
				return n;
			}
			else{
				return null;
			}
		}
		

		
		
		
	}
}
