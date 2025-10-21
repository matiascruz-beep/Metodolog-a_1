using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    internal class OrdenInicio : OrdenEnAula1
    {
        private Aula a;

        public OrdenInicio(Aula a)
        {
            this.a = new Aula();
        }   
        public void ejecutar()
        {
            a.comenzar();
        }
    }
}
