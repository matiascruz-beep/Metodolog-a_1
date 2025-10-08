/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 29/9/2025
 * Time: 16:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica3
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{

		protected string Nombre{get;set;}
		protected double Dni{get;set;}
		public Persona(string nom , double dn)
		{
			this.Nombre = nom;
			this.Dni = dn;
		}
	}
}
