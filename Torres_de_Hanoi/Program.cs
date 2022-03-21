using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.Clear();
            Console.WriteLine(" Opciones \n");

            // Menu pick
            int pickedOption = ShowMenu();
            if (pickedOption != 1 && pickedOption != 2)
            {
                Console.WriteLine("Opción no válida");
                Console.ReadKey(); //Obtiene la siguiente tecla de carácter o de función presionada por el usuario. La tecla presionada se muestra en la ventana de la consola.
                return;
            }




            // numeros de discos
            Console.WriteLine("\nIntroduzca el número de discos, por favor: ");
            string keyStroke = Console.ReadLine();
            uint numDiscos = 0;
            while (!UInt32.TryParse(keyStroke, out numDiscos) && keyStroke != "0")
            {
                Console.WriteLine("Introduzca un número válido");
                keyStroke = Console.ReadLine();
            }

            // inicializacion de pilas
            Pila ini = new Pila(numDiscos);
            Pila aux = new Pila();
            Pila fin = new Pila();

            // solucionario por casos
            Hanoi hanoiGame = new Hanoi();
            uint numMovimientos = 0;
            switch (pickedOption)
            {
                case 1:
                    numMovimientos = hanoiGame.iterativo(numDiscos, ini, aux, fin);
                    break;
                case 2:
                    numMovimientos = hanoiGame.recursivo(numDiscos, ini, aux, fin);
                    break;
                default:
                    break;
            }


            //escritura por consola

            Console.WriteLine("\n- La solución : " + (Math.Pow(2, numDiscos) - 1) + " movimientos.");
            Console.WriteLine("- Implementación: " + numMovimientos.ToString() + " movimientos.");
            Console.ReadKey();  // Restart game upon hitting any key
        }
        //menu inicial 
        private static int ShowMenu()
        {
            Console.WriteLine("1) Algoritmo iterativo.");
            Console.WriteLine("2) Algoritmo recursivo.");

            Console.Write("\r\nEscoja una opción: ");

            switch (Console.ReadLine())
                //posibles casos 
            {
                case "1":
                    return 1;
                case "2":
                    return 2;

                default:
                    return 0;
            }
        }
    }
}
