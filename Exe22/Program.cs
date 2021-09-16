
using System;

namespace Exe22
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, peso, grupo_de_risco;
            Console.WriteLine("Grupos de risco por idade e peso...");
            Console.WriteLine("Digite a idade da pessoa em anos:");
            idade = DoubleAggregator.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso da pessoa em kg:");
            peso = DoubleAggregator.Parse(Console.ReadLine());

            if(idade < 20){
                if (peso <= 60 ){grupo_de_risco = 9;}
                else if (peso <= 90) {grupo_de_risco = 8;}
                else{grupo_de_risco = 7;}
            }
            else
            {
                 if(idade < 50){
                if (peso <= 60 ){grupo_de_risco = 6;}
                else if (peso <= 90) {grupo_de_risco = 5;}
                else{grupo_de_risco = 4;}
                 }
            }else
            {
                 if(idade < 60){
                if (peso <= 60 ){grupo_de_risco = 3;}
                else if (peso <= 90) {grupo_de_risco = 2;}
                else{grupo_de_risco = 1;}
            }
            }
            Console.WriteLine("Pessoa pertence ao grupo de risco: " + grupo_de_risco);
            Console.ReadKey();

        }
    }
}
    
