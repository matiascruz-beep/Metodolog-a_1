/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 24/9/2025
 * Time: 19:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica3
{
	/// <summary>
	/// Description of lectorDeDatos.
	/// </summary>
	public class lectorDeDatos
	{
		public lectorDeDatos()
		{
		}
		
		public int numeroPorTeclado(){
			Console.WriteLine("Elija un número: ");
			int num = int.Parse(Console.ReadLine());
			return num;
		}
		
		public string stringPorTeclado(){
			Console.WriteLine("Dame un string: ");
			string str = Console.ReadLine();
			return str;
		}
		
		
	}
}
