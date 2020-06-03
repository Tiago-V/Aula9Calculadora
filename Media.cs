using System;

namespace Aula_09_Calculadora
{
    public class Media : Calculadora
    {

        //Operações nas classes filhas

        public double soma = 0;
        public double media = 0;
        public double valores;
        public int valMedia {get; set;} //Valor Média

        public void mediaV(){

        System.Console.WriteLine("Insira a quantia de itens para a média: ");
        valMedia = Int32.Parse(System.Console.ReadLine());
        
            for(int i=1 ; i<=valMedia ; i++){
            Console.WriteLine("Insira o valor do item "+i+":");
            double valores = Double.Parse(Console.ReadLine());

            soma += valores;

            }
            media = soma / valMedia;
            Console.WriteLine("Valor da média igual a "+media+"!");
        

        }
    }
}