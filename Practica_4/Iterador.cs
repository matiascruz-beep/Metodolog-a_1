/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 23/9/2025
 * Time: 20:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_4
{
	/// <summary>
	/// Description of Iterador.
	/// </summary>
	public interface Iterador{
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();
	}
}
