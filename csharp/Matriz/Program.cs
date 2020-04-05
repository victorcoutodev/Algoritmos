using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estudo Matriz");

            int tamanho;

            Console.WriteLine("Informe o tamanho da Matriz identidade:");
            tamanho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n Matriz Identidade\n\n");

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    if(i == j)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
