/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 29/9/2025
 * Time: 14:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica3
{
public interface Iterador{
	void primero();
	void siguiente();
	bool fin();
	Comparable actual();
}
}
