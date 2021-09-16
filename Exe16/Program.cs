using System;

namespace EXE16
{
    class Program
    {
        static void Main(string[] args)
        {
            double desconto = 0, precoFinal;
            String descont = null;
        
            Console.WriteLine("Digite o preço atual do produto:");
            double precoAtual = double.Parse(Console.ReadLine());

            if (precoAtual < 30)
            {
                precoFinal = precoAtual - desconto;
                descont = "Sem desconto.";
            }
            else if (precoAtual < 100)
            {
                desconto = precoAtual * 0.10;
                precoFinal = precoAtual - desconto;
                descont = "Desconto de 10 %.";
            }
            else
            {
                desconto = precoAtual * 0.15;
                precoFinal = precoAtual - desconto;
                descont = "Desconto de 15 %.";
            }
            Console.WriteLine("Preço atual: R$" + precoAtual.ToString("F2"));
            Console.WriteLine(descont);
            Console.WriteLine("Desconto: R$" + desconto.ToString("F2"));
            Console.WriteLine("Preço final: R$" + precoFinal.ToString("F2"));
            Console.ReadKey();
        }
    }
}
