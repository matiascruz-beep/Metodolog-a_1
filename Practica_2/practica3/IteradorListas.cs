/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 29/9/2025
 * Time: 14:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace practica3
{
	/// <summary>
	/// Description of IteradorListas.
	/// </summary>
	public class IteradorListas : Iterador
{
	int i;
	private List<Comparable> lista;
	public IteradorListas(List<Comparable> list2)
	{
		lista = list2;
	}
	
	public void primero(){
		i = 0;
	}
	
	public void siguiente(){
		
		i = i+1;
	}
	
	public bool fin(){
		
		return (i == lista.Count-1);
	}
	
	public Comparable actual(){
		
		return lista[i];
	}
	
	
	
}
}
