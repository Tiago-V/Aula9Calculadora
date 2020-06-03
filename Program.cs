using System;

namespace Aula_09_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Adicao somar = new Adicao();

            System.Console.WriteLine("Somar");
            System.Console.WriteLine();

            System.Console.WriteLine("Insira o primeiro valor: ");
            somar.valor1 = Int32.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Insira o segundo valor: ");
            somar.valor2 = Int32.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"Valor da soma = {somar.soma()}");
        }
    }
}
