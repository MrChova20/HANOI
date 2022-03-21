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
<<<<<<< HEAD
            if (pickedOption != 1 && pickedOption != 2 && pickedOption != 3)
            {
                Console.WriteLine("Opción no válida");
                Console.ReadKey();
=======
            if (pickedOption != 1 && pickedOption != 2)
            {
                Console.WriteLine("Opción no válida");
                Console.ReadKey(); //Obtiene la siguiente tecla de carácter o de función presionada por el usuario. La tecla presionada se muestra en la ventana de la consola.
>>>>>>> 749a89fc3c65a2cb1d764f3c712a66ff5c8361c4
                return;
            }




<<<<<<< HEAD
            // Specify number of discs
=======
            // numeros de discos
>>>>>>> 749a89fc3c65a2cb1d764f3c712a66ff5c8361c4
            Console.WriteLine("\nIntroduzca el número de discos, por favor: ");
            string keyStroke = Console.ReadLine();
            uint numDiscos = 0;
            while (!UInt32.TryParse(keyStroke, out numDiscos) && keyStroke != "0")
            {
                Console.WriteLine("Introduzca un número válido");
                keyStroke = Console.ReadLine();
            }

<<<<<<< HEAD
            // Initialize stacks (rods)
=======
            // inicializacion de pilas
>>>>>>> 749a89fc3c65a2cb1d764f3c712a66ff5c8361c4
            Pila ini = new Pila(numDiscos);
            Pila aux = new Pila();
            Pila fin = new Pila();

<<<<<<< HEAD
            // Hanoi solver
=======
            // solucionario por casos
>>>>>>> 749a89fc3c65a2cb1d764f3c712a66ff5c8361c4
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

<<<<<<< HEAD
=======

            //escritura por consola

>>>>>>> 749a89fc3c65a2cb1d764f3c712a66ff5c8361c4
            Console.WriteLine("\n- La solución : " + (Math.Pow(2, numDiscos) - 1) + " movimientos.");
            Console.WriteLine("- Implementación: " + numMovimientos.ToString() + " movimientos.");
            Console.ReadKey();  // Restart game upon hitting any key
        }
<<<<<<< HEAD

=======
        //menu inicial 
>>>>>>> 749a89fc3c65a2cb1d764f3c712a66ff5c8361c4
        private static int ShowMenu()
        {
            Console.WriteLine("1) Algoritmo iterativo.");
            Console.WriteLine("2) Algoritmo recursivo.");

            Console.Write("\r\nEscoja una opción: ");

            switch (Console.ReadLine())
<<<<<<< HEAD

=======
                //posibles casos 
>>>>>>> 749a89fc3c65a2cb1d764f3c712a66ff5c8361c4
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
