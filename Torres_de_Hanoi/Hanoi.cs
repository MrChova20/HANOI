using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        private int movimientos = 0;

        public void mover_disco(Pila a, Pila b)
        {
            if (a.Top == b.Top) //estan vacios ambos
            {
                return;
            }
            else if (a.Top > b.Top)
            {
                if (b.isEmpty()) { b.push(a.pop()); }
                else { a.push(b.pop()); }

            }
            else
            {
                if (a.isEmpty()) { a.push(b.pop()); }
                else { b.push(a.pop()); }
            }

            movimientos++;
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
