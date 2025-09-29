/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 29/9/2025
 * Time: 14:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica3
{
	/// <summary>
	/// Description of Coleccionable.
	/// </summary>

		public interface Coleccionable
		{
			int cuantos();
			Comparable minimo();
			Comparable maximo();
			void agregar(Comparable c);
			bool contiene(Comparable c);
	
	
		}
    }

