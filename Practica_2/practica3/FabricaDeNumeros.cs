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
	/// Description of FabricaDeNumeros.
	/// </summary>
	public class FabricaDeNumeros : fabricaDeComparables
	{
		public FabricaDeNumeros(){
			
		}
		
		public override Comparable crearComparable()
		{
			Random rnd = new Random();
			int num = rnd.Next(0, 9999);  // numero al azar
			Numero n = new Numero(num);
			return n;
		}
	}
}
