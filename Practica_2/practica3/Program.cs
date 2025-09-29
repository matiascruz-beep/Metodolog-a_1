using System;

namespace practica3
{
	class Program
	{
	public static void Main(string[] args)
		{
			Console.Write("Ingrese una opcion: ");
			int op = int.Parse(Console.ReadLine());
			pila p = new pila();
			llenar(p,op);
			informar(p,op);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	
	
	
	
	
	
		
	public static void llenar(Coleccionable c, int opcion){
		
		for (int i=0 ; i<20 ; i++){
		
				Comparable col = fabricaDeComparables.crearComparable(opcion);
				c.agregar(col);
				
			}
		}
		
	public static void informar(Coleccionable c, int opcion){
			Console.WriteLine(c.cuantos());
			Console.WriteLine(c.minimo());
			Console.WriteLine(c.maximo());
			Comparable comp = fabricaDeComparables.crearPorTeclado(opcion);
			if(c.contiene(comp) == true){
				Console.WriteLine("El coleccionable leido está en la colección");
			}else{
				Console.WriteLine("El coleccionable leido NO está en la colección");
			}
			
		}
	}
}