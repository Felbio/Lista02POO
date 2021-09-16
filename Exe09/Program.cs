
using System;

namespace Exe09
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo_medio, valor_do_credito;
            Console.WriteLine("Valor do crédito para correntistas do Banco Povao...");
            Console.WriteLine("Digite o saldo médio do cliente, em R$:");

            saldo_medio = double.Parse(Console.ReadLine());
            
            if(saldo_medio > 400){
                 valor_do_credito = saldo_medio * 0.30;
                 }
            else
            if (saldo_medio > 300){
                valor_do_credito = saldo_medio * 0.25;
                }
            else
            if(saldo_medio > 200){
                valor_do_credito = saldo_medio * 0.20;
                }
            else{
                valor_do_credito = saldo_medio * 0.10;
                }

            Console.WriteLine("Crédito liberado = R$" + valor_do_credito.ToString("F2"));
            
            Console.ReadKey();
        }
    }
}
