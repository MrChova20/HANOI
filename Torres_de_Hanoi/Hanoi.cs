using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        private uint movimientos = 0;

        public void mover_disco(Pila a, Pila b)
        {
            if (a.Top == b.Top) // Estan vacios ambos
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

        public uint iterativo(uint n, Pila ini, Pila fin, Pila aux)
        {
            if (n == 0) { return movimientos; }

            else if (!esPar(n))
            {
                while (!estaSolucionado(fin, n))
                {
                    mover_disco(ini, fin);
                    if (estaSolucionado(fin, n)) { break; }
                    //The break statement can also be used to jump out of a loop.
                    mover_disco(ini, aux);
                    mover_disco(aux, fin);
                    if (estaSolucionado(fin, n)) { break; }
                }
            }
            else
            {
                while (!estaSolucionado(fin, n))
                {
                    mover_disco(ini, aux);
                    mover_disco(ini, fin);
                    if (estaSolucionado(fin, n)) { break; }
                    mover_disco(aux, fin);
                    if (estaSolucionado(fin, n)) { break; }
                }
            }

            return movimientos;
        }



        public uint recursivo(uint n, Pila ini, Pila fin, Pila aux)
        {
            if (n == 0) { return movimientos; }
            if (n == 1) { mover_disco(ini, fin); }

            if (n == 0) { return movimientos; }       // caso general
            if (n == 1) { mover_disco(ini, fin); }  // caso base

            else
            {
                recursivo(n - 1, ini, aux, fin);
                mover_disco(ini, fin);
                recursivo(n - 1, aux, fin, ini);
            }

            return movimientos;
        }

        public bool estaSolucionado(Pila p, uint n)
        {
            return (p.Size == n);
        }

        public bool esPar(uint val)
        {
            return (val % 2 == 0);
        }
    }
}
