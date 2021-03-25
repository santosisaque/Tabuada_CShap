using System;

namespace EX_4n_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int valor1, valor2, atvextra, soma;
            double media;
            Console.Write("Escolha a tabuada: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEscolha o limite da tabuada: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            for(i=1; i<=valor2; i++)
            {
                Console.WriteLine("{0} x {1}={2}", valor1.ToString(), i.ToString(), (valor1 * i).ToString());
            }

        
            
        }
    }
}