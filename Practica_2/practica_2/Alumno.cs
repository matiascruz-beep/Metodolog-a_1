//Ejercicio 1

using System;

namespace practica_2
{
	
	public interface comparoAlumno{
		
	int comparar(Alumno a1, Alumno a2);
	}
	
	public class Alumno
	{
		public string Nombre{get;set;}
		public double Dni{get;set;}
		public double Legajo{get;set;}
		public double Promedio{get;set;}
		
		public comparoAlumno comparador;
		
		public Alumno(string n, double d, double l, double p, comparoAlumno comp)
		{
			this.Nombre = n;
			this.Dni = d;
			this.Legajo = l;
			this.Promedio = p;
			this.comparador = comp;
		}
		
		//Metodo para cambiar la estrategia
		
		public void cambiarComparador(comparoAlumno nuevoComp){
			
			comparador = nuevoComp;
		}

	}
	
	public class PorLegajo : comparoAlumno{
		
		public int comparar(Alumno a1, Alumno a2){
			
			return a1.Legajo.CompareTo(a2.Legajo);
			
			//devuelve -1 si a1 es menor que a2
			//devuelve  1 si a1 es mayor que a2
			//Devuelve 0 si son iguales
		}
	}
	
	public class PorDni : comparoAlumno{
		
		public int comparar(Alumno a1 , Alumno a2){
			
			return a1.Dni.CompareTo(a1.Dni);
		}
	}
	
	public class PorPromedio : comparoAlumno{
		
		public int comparar(Alumno a1 , Alumno a2){
			
			return a1.Promedio.CompareTo(a1.Promedio);
		}
	}
	
	public class PorNombre : comparoAlumno{
		
		public int comparar(Alumno a1 , Alumno a2){
			
			return a1.Nombre.CompareTo(a1.Nombre);
		}
	}
	
	
	
	
	
}