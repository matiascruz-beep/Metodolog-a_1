/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 31/8/2025
 * Time: 20:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio__
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	/// 
//Ejercicio 1
	public interface Comparable
{
    bool sosigual(Comparable c);
    bool sosmayor(Comparable c);
    bool sosmenor(Comparable c);
}

//Ejercicio 2
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