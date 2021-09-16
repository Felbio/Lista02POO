using System;

namespace Exe15
{
    class Program
    {
        static void Main(string[] args)
        {
            double invFinal = 0, rendiment = 0;
            Console.WriteLine("Descreva o tipo de investimento:");
            Console.WriteLine("1- Poupança \n2- Fundos de renda fixa");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do investimento:");
            double invest = double.Parse(Console.ReadLine());

            if(opcao == 1){
                Console.WriteLine("Poupança");
                rendiment = invest * 0.03;
                invFinal = invest + rendiment;
            }else if(opcao == 2){
                Console.WriteLine("Fundo de renda fixa");
                rendiment = invest * 0.04;
                invFinal = invest + rendiment;            
            }else{
                Console.WriteLine("Opção inválida!");
            }

            Console.WriteLine("Investimento inicial: R$" + invest.ToString("F2"));
            Console.WriteLine("Rendimento: R$" + rendiment.ToString("F2"));
            Console.WriteLine("Investimento Final: R$" + invFinal.ToString("F2"));
            Console.ReadKey();
        }
    }
}
