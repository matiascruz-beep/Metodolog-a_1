/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 29/9/2025
 * Time: 16:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace practica3
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	/// 
	public interface comparoProfe{
	
bool comparar(Profesor a1, Profesor a2);
}
	public class Profesor : Persona,Comparable,IObservado
	{
		
		//Lista de observadores
		public List<IObservador> observadores = new List<IObservador>();
		public string Estado { get; private set; }
		
		public void agregarObservador(IObservador o){
			observadores.Add(o);
		}
		
		public void quitarObservador(IObservador o){
			observadores.Remove(o);
		}
		
		public void notificar(){
			foreach(IObservador o in observadores){
				o.actualizar(this);
			}
		}
		
		public int Antiguedad{get;set;}
		public comparoProfe comparador;
		
		
		public Profesor(string n, int d, int anti) : base(n,d)
		{
			this.Antiguedad = anti;
			this.comparador = null;
		}
		public Profesor(string n, int d, int anti, comparoProfe comp) : base(n,d)
		{
			this.Antiguedad = anti;
			this.comparador = comp;
		}
		public void hablarALaClase(){
			
			Estado = "hablando";
			Console.WriteLine("Hablando de algun tema");
			notificar();
		}
		
		public void escribirEnElPizarron(){
			
			Estado = "escribiendo";
			Console.WriteLine("Escribiendo en el pizarron");
			notificar();
		}
		
		//Metodo para cambiar la estrategia
	
	public void cambiarComparador(comparoProfe nuevoComp){
		
		comparador = nuevoComp;
	}
	
	public bool sosigual(Comparable pe)
    {
        //Alumno al = (Alumno)pe;
        //return this.Legajo == al.Legajo;
        if(comparador == null){
           	throw new InvalidOperationException("No se ha asignado una estrategia de comparacion al profesor");
        }
        return comparador.comparar(this , (Profesor)pe);
        
    }

    public bool sosmayor(Comparable pe)
    {
        Profesor al = (Profesor)pe;
        return this.Antiguedad > al.Antiguedad;
    }

    public bool sosmenor(Comparable pe)
    {
        Profesor al = (Profesor)pe;
        return this.Antiguedad < al.Antiguedad;
    }
    
     public override string ToString()
	{
       	return string.Format("Nombre: {0}, DNI: {1}, Antiguedad: {2}", Nombre, Dni, Antiguedad );
	}
	}
	
	public class PorAntiguedad : comparoProfe{
		
		public bool comparar(Profesor p1, Profesor p2){
			
			return p1.Antiguedad == p2.Antiguedad;
		}
	}
}
