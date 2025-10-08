/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 29/9/2025
 * Time: 16:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica3
{
	/// <summary>
	/// Description of FabricaDeProfesores.
	/// </summary>
	public class FabricaDeProfesores : fabricaDeComparables
	{
		public FabricaDeProfesores()
		{
		}
		public override Comparable crearComparable(){
			string[] nombres = { "Ana", "Luis", "María", "Pedro", "Lucía", "Carlos", "Sofía", "Mateo", "Valentina", "Julián","Matias","Juan"};
			Random rnd = new Random();
			string nombre = nombres[rnd.Next(nombres.Length)];
  			int dni = rnd.Next(10000000, 50000000);  // DNI al azar
  			int antiguedad = rnd.Next(0,30);
  			Profesor p = new Profesor(nombre,dni,antiguedad,new PorAntiguedad());
    		return p;
		}
	}
}
