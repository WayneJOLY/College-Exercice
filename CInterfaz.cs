using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Eugene_de_Mazenod
{
    public class CInterfaz
    {
        static CInterfaz ()
        {
           Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static string DarOpcion()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*    Bien Venido a College Eugene de Mazenod        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("\n\n");
            Console.WriteLine("[A] Agregar   Estudiante");
            Console.WriteLine("[B] Lista de  Estudiante");
            Console.WriteLine("[C] Cantidad de Estudiante Ingresado");
            Console.WriteLine("[D] Mejor  Estudiante ");
            Console.WriteLine("[E] Promedio general de la Clase  ");

            return CInterfaz.PedirDato("Ingrese la Opcion Elegida");
        }


        public static string PedirDato(string nombre)
        {
            Console.WriteLine("Ingre se "+ nombre);
            string dato=Console.ReadLine();

            while( dato == null )
            {
                Console.WriteLine(nombre + " Es Obligatorio \n");
                Console.WriteLine("Ingre se " + nombre );
                dato = Console.ReadLine();  
            }
            return dato;
        }
    }
}
