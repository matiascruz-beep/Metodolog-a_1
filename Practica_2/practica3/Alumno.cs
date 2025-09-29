/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 25/9/2025
 * Time: 13:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica3
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public interface comparoAlumno{
	
bool comparar(Alumno a1, Alumno a2);
}

public class Alumno : Comparable
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
        //Alumno al = (Alumno)pe;
        //return this.Legajo == al.Legajo;
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
