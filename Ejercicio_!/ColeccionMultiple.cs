//Ejercicio 8
using System;
using System.Collections.Generic;

namespace Ejercicio__
{
	
	public class ColeccionMultiple : Coleccionable
	{
		private pila p;
		private cola c;
		public ColeccionMultiple(pila pil,cola col)
		{
			this.p = pil;
			this.c = col;
		}
		
		public int cuantos(){
			return (p.cuantos()+c.cuantos());
		}
		
		public Comparable minimo(){
			Comparable min_cola = c.minimo();
			Comparable min_pila = p.minimo();
			
			if(min_cola.sosmenor(min_pila)){return min_cola;}
			else{return min_pila;}
		}
		
		public Comparable maximo(){
			Comparable max_cola = c.maximo();
			Comparable max_pila = p.maximo();
			
			if(max_cola.sosmayor(max_pila)){return max_cola;}
			else{return max_pila;}
		}
		
		public void agregar(Comparable c){}
		
		public bool contiene(Comparable comp){
			return (p.contiene(comp) || c.contiene(comp));
		}
		
	}
}
