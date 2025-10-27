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
    // Enqueue(T item) → agrega un elemento al final de la cola (FIFO: primero en entrar, primero en salir).
    // Dequeue() → quita y devuelve el primer elemento de la cola (el que estaba esperando más tiempo).

    public class Cola : Coleccionable, Iterable, Ordenable
    {
        private Queue<Comparable> elementos;

        private OrdenEnAula1 ordenInicio;
        private OrdenEnAula2 ordenLlegaAlumno;
        private OrdenEnAula1 ordenAulaLlena;

        public Cola()
        {
            elementos = new Queue<Comparable>();
        }

        public void setOrdenInicio(OrdenEnAula1 o) => ordenInicio = o;
        public void setOrdenLlegaAlumno(OrdenEnAula2 o) => ordenLlegaAlumno = o;
        public void setOrdenAulaLlena(OrdenEnAula1 o) => ordenAulaLlena = o;

        public void agregar(Comparable c)
        {
            bool esPrimero = elementos.Count == 0;

            elementos.Enqueue(c);

            // 1️⃣ Si es el primer elemento
            if (esPrimero && ordenInicio != null)
            {
                ordenInicio.ejecutar();
            }

            // 2️⃣ Siempre llega un alumno
            if (ordenLlegaAlumno != null)
            {
                ordenLlegaAlumno.ejecutar(c);
            }

            // 3️⃣ Cuando hay 40 elementos
            if (elementos.Count == 40 && ordenAulaLlena != null)
            {
                ordenAulaLlena.ejecutar();
            }
        }

        public int cuantos() => elementos.Count;

        public Comparable minimo()
        {
            if (elementos.Count == 0) return null;
            Comparable min = null;
            foreach (Comparable comp in elementos)
                if (min == null || comp.sosmenor(min))
                    min = comp;
            return min;
        }

        public Comparable maximo()
        {
            if (elementos.Count == 0) return null;
            Comparable max = null;
            foreach (Comparable comp in elementos)
                if (max == null || comp.sosmayor(max))
                    max = comp;
            return max;
        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable comp in elementos)
                if (comp.sosigual(c))
                    return true;
            return false;
        }

        public Comparable desencolar()
        {
            if (elementos.Count == 0) return null;
            return elementos.Dequeue();
        }

        public Iterador crearIterador()
        {
            return new IteradorListas(new List<Comparable>(elementos));
        }
    }

}

