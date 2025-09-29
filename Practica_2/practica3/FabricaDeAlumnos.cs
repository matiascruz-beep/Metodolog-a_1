/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 25/9/2025
 * Time: 14:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica3
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos : fabricaDeComparables
	{
		public FabricaDeAlumnos()
		{
		}
		
		public override Comparable crearComparable(){
			string[] nombres = { "Ana", "Luis", "María", "Pedro", "Lucía", "Carlos", "Sofía", "Mateo", "Valentina", "Julián","Matias","Juan"};
			Random rnd = new Random();
			string nombre = nombres[rnd.Next(nombres.Length)];
  			int dni = rnd.Next(10000000, 50000000);  // DNI al azar
  			int legajo = rnd.Next(1000, 9999);      // Legajo al azar
    		double promedio = Math.Round(rnd.NextDouble() * 10, 2); // Promedio entre 0 y 10 con decimales
    		Alumno a = new Alumno(nombre, dni, legajo, promedio, new PorDni());
    		return a;
		}
	}
}
