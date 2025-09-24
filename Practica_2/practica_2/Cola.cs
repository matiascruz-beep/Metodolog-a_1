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
	// Enqueue(T item) → agrega un elemento al final de la cola (FIFO: primero en entrar, primero en salir).
	// Dequeue() → quita y devuelve el primer elemento de la cola (el que estaba esperando más tiempo).
	
	public class cola : Coleccionable, Iterable
	{
		private Queue<Comparable> elementos;
		
		public cola()
		{
			elementos = new Queue<Comparable>();
		}
		
		public void agregar(Comparable c){
			elementos.Enqueue(c);
		}
		public int cuantos(){
			return elementos.Count;
		}
		public Comparable minimo(){
			
			if(elementos.Count == 0) return null;
			
			Comparable min = null;
			
			foreach (Comparable comp in elementos){
				if(min == null || comp.sosmenor(min)){
					min = comp;
				}
			}
			return min;
		}
		
		public Comparable maximo(){
			if(elementos.Count == 0) return null;
			
			Comparable max = null;
			
			foreach(Comparable comp in elementos){
				
				if(max == null || comp.sosmayor(max)){
					max = comp;
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
		
		public Comparable desencolar(){
			
			if(elementos.Count == 0) return null;
			
			return elementos.Dequeue();
		}
		
		public Iterador crearIterador(){
			return new IteradorListas(new List<Comparable>(elementos));
		}
		
		
		
		
	}
}

