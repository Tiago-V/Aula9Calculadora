using System;

namespace Aula_09_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calcular = new Calculadora();

            Adicao somar = new Adicao();
            Subtracao subtrair = new Subtracao();
            Multiplicacao multiplicar = new Multiplicacao();
            Divisao dividir = new Divisao();
            Media mediar = new Media();


            Console.WriteLine("Para subtração digite -, divisão /, multiplicação x, e média 0, e para média nada.");

            switch (calcular.calculo){


                case "x":
                multiplicar.multiplica();
                break;

                case "/":
                dividir.divide();
                break;

                case "-":
                subtrair.subtrai();
                break;

                case "0":
                mediar.mediaV();
                break;
                
                default: 
                somar.soma();
                break;
        }
        Console.ReadLine();
    }
}
}
