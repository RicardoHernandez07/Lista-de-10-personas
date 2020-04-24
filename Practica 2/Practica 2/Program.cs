using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lista = new string[10];


            for (int i = 0; i < lista.Length; i++)  
            {
                Console.Write($"Ingrese el nombre de 10 personas { (i + 1) }:");
                lista[i] = Console.ReadLine();

            } 
            for (int i = 0 ; i < lista.Length;i++)
            {
                Console.WriteLine($"El nombre de Persona {(i + 1)} es: {lista[i]}");
            }

            Console.ReadLine();
        }
    }
}
