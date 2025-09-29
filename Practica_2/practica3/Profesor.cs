/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 29/9/2025
 * Time: 16:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica3
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor : Persona
	{
		int antiguedad;
		public Profesor(string n, int d, int anti) : base(n,d)
		{
			this.antiguedad = anti;
		}
		
		public void hablarALaClase(){
			
			Console.WriteLine("Hablando de algun tema");
		}
		
		public void escribirEnElPizarron(){
			
			Console.WriteLine("Escribiendo en el pizarron");
		}
	}
}
