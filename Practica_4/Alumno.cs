//Ejercicio 1

using System;

namespace Practica_4
{
	
	
	public class Alumno : Comparable
	{
		public string Nombre{get;set;}
		public string Apellido { get; set; }
		public double Dni{get;set;}
		public double Legajo{get;set;}
		public double Promedio{get;set;}
		public int Calificacion { get; set; }


		
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
		
		public bool sosigual(Comparable pe)
        {
            //Alumno al = (Alumno)pe;
            //return this.Legajo == al.Legajo;
            if(comparador == null){
            	throw new InvalidOperationException("No se ha asignado una estrategia de comparacion al alumno");
            }
            return comparador.sosIgual(this , (Alumno)pe);
            
        }

        public bool sosmayor(Comparable pe)
        {
            if (comparador == null)
                throw new InvalidOperationException("No se ha asignado una estrategia de comparacion al alumno");
            return comparador.sosMayor(this, (Alumno)pe);
        }

		public bool sosmenor(Comparable pe)
		{
			if (comparador == null)
				throw new InvalidOperationException("No se ha asignado una estrategia de comparacion al alumno");
			return comparador.sosMenor(this, (Alumno)pe);
		}

        public override string ToString()
		{
        	return string.Format("Nombre: {0}, DNI: {1}, Legajo: {2}, Promedio: {3}", Nombre, Dni, Legajo, Promedio);
		}

		public virtual int ResponderPregunta(int pregunta)
		{
			Random rnd = new Random();
			int num = rnd.Next(1, 4);
			return num;
		}

		public string MostrarCalificacion()
		{
			return string.Format("Nombre: {0}, Calificacion: {1}", Nombre, Calificacion);
		}
	}
	
	
	
	
	
	
	
	

	
	
	
	
	
}