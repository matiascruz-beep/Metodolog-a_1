//Ejercicio 12

using System;

namespace Ejercicio__
{
	public class Alumno : Persona
	{
		public double Legajo{get;set;}
		public double Promedio{get;set;}
		
		public Alumno(string n, double d, double l, double p) : base(n,d)
		{
			this.Legajo = l;
			this.Promedio = p;
		}	
		
		
		
		public override bool sosigual(Comparable pe)
        {
			if(pe.GetType() == typeof(Numero)){
				return false;
			}else{
				
			
            Alumno al = (Alumno)pe;
            return this.Legajo == al.Legajo;
			}
        }

        public override bool sosmayor(Comparable pe)
        {
            Alumno al = (Alumno)pe;
            return this.Legajo > al.Legajo;
        }

        public override bool sosmenor(Comparable pe)
        {
            Alumno al = (Alumno)pe;
            return this.Legajo < al.Legajo;
        }
        
        public override string ToString()
{
        	return string.Format("Nombre: {0}, DNI: {1}, Legajo: {2}, Promedio: {3}", Nombre, Dni, Legajo, Promedio);
}

}
}