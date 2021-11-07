using System;

namespace Calc_IMC_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora IMC");

            Console.Write("Digite sua Altura: ");
            string altura = Console.ReadLine();
            double medida = double.Parse(altura);

            Console.Write("Digite seu Peso: ");
            string peso = Console.ReadLine();
            double massa = double.Parse(peso);

            double imc = massa/(medida*medida);

            Console.WriteLine($"Seu IMC é {imc:N2}");

            if (imc < 17)
            {
                Console.WriteLine("Dignóstico: Muito abaixo do peso");
            }            

            else if (imc < 18.49)
            {
                Console.WriteLine("Diagnóstico: Abaixo do peso");
            }

            else if (imc < 24.99)
            {
                Console.WriteLine("Diagnóstico: Peso normal");
            }

            else if (imc < 29.99)
            {
                Console.WriteLine("Diagnóstico: Acima do peso");
            }

            else if (imc < 34.99)
            {
                Console.WriteLine("Diagnóstico: Obesidade I");
            }

            else if (imc < 39.99)
            {
                Console.WriteLine("Diagnóstico: Obesidade II (severa)");
            }

            else
            {
                Console.WriteLine("Diagnóstico: Obesidade III (mórbida)");
            }
        }
    }
}
