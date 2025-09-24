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
