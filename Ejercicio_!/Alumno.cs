//Ejercicio 12

using System;

namespace Ejercicio__
{
	public class Alumno : Persona
	{
		private double legajo;
		private double promedio;
		
		
		public Alumno(string n, double d, double l, double p) : base(n,d)
		{
			this.legajo = l;
			this.promedio = p;
		}
		
		public double Legajo{get;set;}
		public double Promedio{get;set;}
		
		
	}
}
