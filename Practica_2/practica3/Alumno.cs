/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 25/9/2025
 * Time: 13:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace practica3
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public interface comparoAlumno{
	
bool comparar(Alumno a1, Alumno a2);
}

public class Alumno : Comparable, IObservador
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
	public Alumno(string n, double d, double l, double p)
	{
		this.Nombre = n;
		this.Dni = d;
		this.Legajo = l;
		this.Promedio = p;
		this.comparador = null;
	}
	
	//Metodo para cambiar la estrategia
	
	public void cambiarComparador(comparoAlumno nuevoComp){
		
		comparador = nuevoComp;
	}
	
	public bool sosigual(Comparable pe)
    {
        if(comparador == null){
           	throw new InvalidOperationException("No se ha asignado una estrategia de comparacion al alumno");
        }
        return comparador.comparar(this , (Alumno)pe);
        
    }

    public bool sosmayor(Comparable pe)
    {
        Alumno al = (Alumno)pe;
        return this.Legajo > al.Legajo;
    }

    public bool sosmenor(Comparable pe)
    {
        Alumno al = (Alumno)pe;
        return this.Legajo < al.Legajo;
    }
    
     public override string ToString()
	{
       	return string.Format("Nombre: {0}, DNI: {1}, Legajo: {2}, Promedio: {3}", Nombre, Dni, Legajo, Promedio);
	}
     
     public void prestarAtencion(){
     	Console.WriteLine("Prestando Atencion");
     }
     
     public void distraerse(){
     	List<string> lista = new List<string>{"Mirando el celular","Dibujando en el margen de la carpeta","Tirando aviones de papel"};
     	Random rnd = new Random();
     	int num = rnd.Next(0,3);
     	
     	string frase = lista[num];
     	
     	Console.WriteLine(frase);
     }
      public void actualizar(IObservado o)
    {
        Profesor profe = (Profesor)o; // casteamos porque sabemos que es Profesor
        if (profe.Estado == "hablando")
        	this.prestarAtencion();
        else if (profe.Estado == "escribiendo")
        	this.distraerse();
    }
}

public class PorLegajo : comparoAlumno{
	
	public bool comparar(Alumno a1, Alumno a2){
		
		return a1.Legajo == a2.Legajo;

	}
}

public class PorDni : comparoAlumno{
	
	public bool comparar(Alumno a1 , Alumno a2){
		
		return a1.Dni == a2.Dni;
	}
}

public class PorPromedio : comparoAlumno{
	
	public bool comparar(Alumno a1 , Alumno a2){
		
		return a1.Promedio == a2.Promedio;
	}
}

public class PorNombre : comparoAlumno{
	
	public bool comparar(Alumno a1 , Alumno a2){
		
		return a1.Nombre == a2.Nombre;
	}
}
	
}
