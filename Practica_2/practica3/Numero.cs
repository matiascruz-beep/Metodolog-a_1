/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 25/9/2025
 * Time: 13:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica3
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	public class Numero : Comparable
{
    private int valor;

    public Numero(int valor)
    {
        this.valor = valor;
    }

    public bool sosigual(Comparable c)
    {
        Numero num = (Numero)c;  // casteo
        return this.valor == num.valor;
    }

    public bool sosmayor(Comparable c)
    {
        Numero num = (Numero)c;
        return this.valor > num.valor;
    }

    public bool sosmenor(Comparable c)
    {
        Numero num = (Numero)c;
        return this.valor < num.valor;
    }

    public override string ToString()
    {
        return valor.ToString();
    }
}
}
