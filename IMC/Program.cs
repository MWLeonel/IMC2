using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double peso;
            double IMC;

            Console.Write("Digite sua Altura(m): ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite seu Peso(kg): ");
            peso = double.Parse(Console.ReadLine());

            IMC = peso / (altura * altura);

            if (IMC < 17)
            {
                Console.WriteLine();
                Console.WriteLine(Math.Round(IMC, 2));
                Console.WriteLine("Você está muito abaixo do peso ideal");
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
            if (IMC >= 17 && IMC <= 18.49)
            {
                Console.WriteLine();
                Console.WriteLine(Math.Round(IMC, 2));
                Console.WriteLine("Você está abaixo do peso ideal");
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
            if (IMC >= 18.5 && IMC <= 24.99)
            {
                Console.WriteLine();
                Console.WriteLine(Math.Round(IMC, 2));
                Console.WriteLine("Você está com peso ideal");
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
            if (IMC >= 25 && IMC <= 29.99)
            {
                Console.WriteLine();
                Console.WriteLine(Math.Round(IMC, 2));
                Console.WriteLine("Você está acima do peso ideal");
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
            if (IMC >= 30 && IMC <= 34.99)
            {
                Console.WriteLine();
                Console.WriteLine(Math.Round(IMC, 2));
                Console.WriteLine("Você está com obesidade I");
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
            if (IMC >= 35 && IMC <= 39.99)
            {
                Console.WriteLine();
                Console.WriteLine(Math.Round(IMC, 2));
                Console.WriteLine("Você está com obesidade II (severa)");
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
            if (IMC >= 40)
            {
                Console.WriteLine();
                Console.WriteLine(Math.Round(IMC, 2));
                Console.WriteLine("Você está com obesidade III (mórbida)");
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
        }
    }
}
