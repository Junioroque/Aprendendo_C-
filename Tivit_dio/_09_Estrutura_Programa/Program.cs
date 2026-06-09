using System;

namespace _09_Estrutura_Programa
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();
            s.Empilhar(1);
            s.Empilhar(10);
            s.Empilhar(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
       
        }
    }
} 
