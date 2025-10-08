/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 30/9/2025
 * Time: 21:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica3
{
	/// <summary>
	/// Description of Observador.
	/// </summary>
	public interface IObservado{
		
		void agregarObservador(IObservador o);
		void quitarObservador(IObservador o);
		//void notificar(string accion);
		void notificar();
	}
	
	public interface IObservador {
		void actualizar(IObservado o);
	}
	
	/*public interface observadorDeProfesores : IObservador{
		
		void actualizar(string accion);
	}*/
	
	
}
