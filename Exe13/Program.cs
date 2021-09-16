using System;

namespace Exe13
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoFinal, porc;
            String classific;
            Console.WriteLine("Digite o valor do preço do produto:");
            double preco = double.Parse(Console.ReadLine());

            if(preco < 50){
                porc = 0.05;
                precoFinal = preco + (preco * porc);                
            }else if(preco < 100){
                porc = 0.10;
                precoFinal = preco + (preco * porc);                
            }else{
                 porc = 0.15;
                precoFinal = preco + (preco * porc);   
            }

                if(precoFinal < 80){
                    classific = " Barato ";
                }else if(precoFinal < 120){
                    classific = " Normal ";
                }else if(precoFinal < 200){
                    classific = " Caro ";
                }else{ 
                    classific = " Muito Caro ";
                }

                Console.WriteLine("Preço final: R$" + precoFinal.ToString("F2"));
                Console.WriteLine("Classificação: Preço" + classific);

                Console.ReadKey();
        }
    }
}
