using System;

namespace practica3
{
	public class GeneradorDeDatosAleatorios
	{
		public GeneradorDeDatosAleatorios()
		{
		}
		
		public int numeroAleatorio(int max){
			Random rnd = new Random();
			return rnd.Next(0, max);
		}
		
		public string stringAleatorio(int cant){
			
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    		Random rnd = new Random();
   			 char[] resultado = new char[cant];

   			 for (int i = 0; i < cant; i++)
   			 {
   	     		resultado[i] = chars[rnd.Next(chars.Length)];
   			 }

    		return new string(resultado);
			}
	}
}
