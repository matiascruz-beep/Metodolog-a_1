//Ejercicio 11

using System;

namespace Ejercicio__
{
	public abstract class Persona : Comparable
	{
		public string Nombre{get;set;}
		
		public double Dni{get;set;}
		
		public Persona(string n , double d)
		{
			this.Nombre = n;
			this.Dni = d;
		}
		
		
		
		public abstract  bool sosigual(Comparable pe);/*{
			Persona per = (Persona)pe;
			return (this.dni == per.Dni);
		}*/
		
		public abstract  bool sosmayor(Comparable pe);/*{
			
			Persona per = (Persona)pe;
			return (this.dni > per.Dni);
		}*/
		
		public abstract  bool sosmenor(Comparable pe);/*{
			
			Persona per = (Persona)pe;
			return (this.dni < per.Dni);
		}*/
		
	}
}
