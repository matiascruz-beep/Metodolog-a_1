using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practica_4
{
    internal class NotaEnLetrasDecorator : StudentDecorator
    {
        public NotaEnLetrasDecorator(IStudent student)
        : base(student) { }

        private string ConvertirALetras(int nota)
        {
            return nota switch
            {
                10 => "DIEZ",
                9 => "NUEVE",
                8 => "OCHO",
                7 => "SIETE",
                6 => "SEIS",
                5 => "CINCO",
                4 => "CUATRO",
                3 => "TRES",
                2 => "DOS",
                1 => "UNO",
                _ => "SIN NOTA"
            };
        }

       
           public override string showResult()
        {
            string original = student.showResult();

            // Buscar un número en el string original
            //var match = Regex.Match(original, @"\d+");
            //int nota = match.Success ? int.Parse(match.Value) : 0;
            int nota = student.Calificacion;
            string notaLetras = ConvertirALetras(nota);
            return $"{original} ({notaLetras})";
        }
    }

    }

