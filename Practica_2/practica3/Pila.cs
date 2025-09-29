/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 29/9/2025
 * Time: 14:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace practica3
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	//Pila - LIFO (Last In, First Out)
public class pila : Coleccionable, Iterable
{
	private List<Comparable> elemento;
	
	public pila()
	{
		elemento = new List<Comparable>();
	}
	
	public void agregar(Comparable c){
		elemento.Add(c); //hace un push al final
	}
	public int cuantos(){
		return elemento.Count;
	}
	public Comparable minimo(){
		Comparable min = elemento[0];
		foreach (Comparable c in elemento){
			if(c.sosmenor(min)){
				min = c;
			}
		}
		return min;
	}
	public Comparable maximo(){
		Comparable max  = elemento[0];
		foreach(Comparable c in elemento){
			if(c.sosmayor(max)){
				max = c;
			}
		}
		return max;
	}
	public bool contiene(Comparable c){
		foreach(Comparable comp in elemento){
			if(comp.sosigual(c)){
				return true;
			}
		}
		return false;
	}
	public Comparable desapilar(){
		if(elemento.Count == 0) return null;
		Comparable tope = elemento[elemento.Count-1];
		elemento.RemoveAt(elemento.Count-1);
		return tope;
	}
	
	public Iterador crearIterador(){
		return new IteradorListas(new List<Comparable>(elemento));
	}
}
}
