using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holamundo
{
    class Program
    {
        static void Main(string[] args) {

        int lenght = 10;

        ConsoleColor Color_de_la_consola =ConsoleColor.White;

            for (int i = 0; i < lenght; i++) { 
                Color_de_la_consola = ConsoleColor.White;
                Console.BackgroundColor = Color_de_la_consola;
                Console.WriteLine("Hola mundo");
            }//Imprimir lenght veces hola mundo

            Console.ReadKey();
        }

    }
}