using System;

namespace csharp
{
    class Program
    {
       static void Main(){

            var pilha = new pilha();
            pilha.Empilha(1);
            pilha.Empilha(2);
            pilha.Empilha(3);
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
       }
    }
}
 