/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 23/9/2025
 * Time: 20:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace practica_2
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto : Coleccionable, Iterable
	{
		List<Comparable> lista;
		
		public Conjunto()
		{
			lista = new List<Comparable>();
		}
		
		//Metodos
		
		public Comparable minimo(){
			
			if(lista.Count == 0) return null;
			
			Comparable min = null;
			
			foreach (Comparable comp in lista){
				if(min == null || comp.sosmenor(min)){
					min = comp;
				}
			}
			return min;
		}
		
		public Comparable maximo(){
			if(lista.Count == 0) return null;
			
			Comparable max = null;
			
			foreach(Comparable comp in lista){
				
				if(max == null || comp.sosmayor(max)){
					max = comp;
				}
			}
			
			return max;
		}
		
		public bool contiene(Comparable c){
			
			foreach(Comparable comp in lista){
				
				if(comp.sosigual(c)){
					
					return true;
				}
			}
			
			return false;
		}
		
		
		public void agregar(Comparable c){
			if(lista.Contains(c) == false){
				lista.Add(c);
			}
		}
		
		public bool existe(Comparable c){
			return lista.Contains(c);	
		}
	
	
		public int cuantos(){
			return lista.Count;
		}
		
		public Iterador crearIterador(){
			return new IteradorListas(lista);
		}
		
		
		
		
		
		
		
		
	}
}
