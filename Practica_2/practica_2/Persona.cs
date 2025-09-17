//Ejercicio 11

using System;

namespace practica_2
{
	public abstract class Persona 
	{
		public string Nombre{get;set;}
		
		public double Dni{get;set;}
		
		public Persona(string n , double d)
		{
			this.Nombre = n;
			this.Dni = d;
		}
		
	}
}
