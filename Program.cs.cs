using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, dobro;
            Console.WriteLine("Digite um valor inteiro:");
            valor = Convert.ToInt32(Console.ReadLine());

            dobro = valor + valor;

            Console.WriteLine("O dobro do valor é:" + dobro);

            Console.ReadKey();
        }
    }
}
