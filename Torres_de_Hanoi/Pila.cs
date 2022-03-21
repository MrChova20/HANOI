using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; } 
        public int Top { get; set; } 

        public List<Disco> Elementos { get; set; }

        public Pila()
        {
            Elementos = new List<Disco>();
        }

        public Pila(uint numeroPila)
        {
            Elementos = new List<Disco>();

            Disco iter;
            for (int i = (int)numeroPila; i >= 1; --i)
            {
                iter = new Disco(i);
                Elementos.Add(iter);
                Top = iter.Valor;
                Size++;
            }
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = d.Valor;
            Size++;
        }

        public Disco pop()
        {
            if (!isEmpty())
            {
                Disco last = Elementos[--Size];
                Elementos.RemoveAt(Size);
                Top = !isEmpty() ? Elementos[Size - 1].Valor : 0;  //ternaria 

                //here is also a short-hand if else, which is known as the ternary operator because it consists of three operands. It can be used to replace multiple lines of code with a single line. It is often used to replace simple if else statements:

                // variable = (condition) ? expressionTrue : expressionFalse;
                return last;
            }

            return null;
        }

        public bool isEmpty()
        {
            return (Elementos.Count == 0 || Size <= 0);
        }
    }
}
