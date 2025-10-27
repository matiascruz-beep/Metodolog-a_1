/*
 * Created by SharpDevelop.
 * User: mati1
 * Date: 23/9/2025
 * Time: 20:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Collections.Generic;
using System;

namespace Practica_4
{
    //Pila - LIFO (Last In, First Out)
    public class Pila : Coleccionable, Iterable, Ordenable
    {
        private List<Comparable> elemento;

        private OrdenEnAula1 ordenInicio;
        private OrdenEnAula2 ordenLlegaAlumno;
        private OrdenEnAula1 ordenAulaLlena;

        public Pila()
        {
            elemento = new List<Comparable>();
        }

        public void setOrdenInicio(OrdenEnAula1 o) { ordenInicio = o; }
        public void setOrdenLlegaAlumno(OrdenEnAula2 o) => ordenLlegaAlumno = o;
        public void setOrdenAulaLlena(OrdenEnAula1 o) => ordenAulaLlena = o;

        public void agregar(Comparable c)
        {
            bool esPrimero = elemento.Count == 0;

            elemento.Add(c); // push al final

            // 1️⃣ Si es el primer elemento → ejecutar OrdenInicio
            if (esPrimero && ordenInicio != null)
            {
                ordenInicio.ejecutar();
            }

            // 2️⃣ Siempre se ejecuta OrdenLlegaAlumno
            if (ordenLlegaAlumno != null)
            {
                ordenLlegaAlumno.ejecutar(c);
            }

            // 3️⃣ Si llega al elemento 40 → ejecutar OrdenAulaLlena
            if (elemento.Count == 40 && ordenAulaLlena != null)
            {
                ordenAulaLlena.ejecutar();
            }
        }

        public int cuantos() => elemento.Count;

        public Comparable minimo()
        {
            Comparable min = elemento[0];
            foreach (Comparable c in elemento)
                if (c.sosmenor(min))
                    min = c;
            return min;
        }

        public Comparable maximo()
        {
            Comparable max = elemento[0];
            foreach (Comparable c in elemento)
                if (c.sosmayor(max))
                    max = c;
            return max;
        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable comp in elemento)
                if (comp.sosigual(c))
                    return true;
            return false;
        }

        public Comparable desapilar()
        {
            if (elemento.Count == 0) return null;
            Comparable tope = elemento[elemento.Count - 1];
            elemento.RemoveAt(elemento.Count - 1);
            return tope;
        }

        public Iterador crearIterador()
        {
            return new IteradorListas(new List<Comparable>(elemento));
        }
    }

}
