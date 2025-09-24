/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 23/9/2025
 * Time: 20:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Collections.Generic;
using System;

namespace practica_2
{
	//Pila - LIFO (Last In, First Out)
	public class pila : Coleccionable
	{
		private List<Comparable> elementos;
		
		public pila()
		{
			elementos = new List<Comparable>();
		}
		
		public void agregar(Comparable c){
			elementos.Add(c); //hace un push al final
		}
		public int cuantos(){
			return elementos.Count;
		}
		public Comparable minimo(){
			Comparable min = elementos[0];
			foreach (Comparable c in elementos){
				if(c.sosmenor(min)){
					min = c;
				}
			}
			return min;
		}
		public Comparable maximo(){
			Comparable max  = elementos[0];
			foreach(Comparable c in elementos){
				if(c.sosmayor(max)){
					max = c;
				}
			}
			return max;
		}
		public bool contiene(Comparable c){
			foreach(Comparable comp in elementos){
				if(comp.sosigual(c)){
					return true;
				}
			}
			return false;
		}
		public Comparable desapilar(){
			if(elementos.Count == 0) return null;
			Comparable tope = elementos[elementos.Count-1];
			elementos.RemoveAt(elementos.Count-1);
			return tope;
		}
		
		public Iterador crearIterador(){
			return new IteradorListas(new List<Comparable>(elementos));
		}
	}
}
