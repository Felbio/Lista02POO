using System;

namespace Exe23
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = 0, precoFinal = 0, desconto = 0, notaTot = 0;
            
            Console.WriteLine("Digite o código do produto (entre 1 a 40):");
            int cod = int.Parse(Console.ReadLine());

            if(cod == 0 || cod > 40){
                Console.WriteLine("Código de produto inválido!");
            }else{

             int codigo = cod;
                
                Console.WriteLine("Digite a quantidade de produtos:");
                int quant = int.Parse(Console.ReadLine());             

                if(codigo < 10){
                    preco = 10.00;
                    precoFinal = preco * quant;                
                }else if(codigo < 20){
                    preco = 15.00;
                    precoFinal = preco * quant;
                }else if(codigo < 30){
                    preco = 20.00;
                    precoFinal = preco * quant;
                }else if(codigo < 40){
                    preco = 30.00;
                    precoFinal = preco * quant;
                }


                if(precoFinal < 250){
                    desconto = precoFinal * 0.05;
                    notaTot = precoFinal - desconto;
                }else if(precoFinal < 500){
                    desconto = precoFinal * 0.10;
                    notaTot = precoFinal - desconto;
                }else{
                    desconto = precoFinal * 0.15;
                    notaTot = precoFinal - desconto;
                }           

                Console.WriteLine("Código do produto: #-0" + codigo);
                Console.WriteLine("Quantidade do produto: " + quant);
                Console.WriteLine("Preço unitário do produto: R$" + preco.ToString("F2"));
                Console.WriteLine("Preço total da compra (nota): R$" + precoFinal.ToString("F2"));
                Console.WriteLine("Total do desconto: R$" + desconto.ToString("F2"));
                Console.WriteLine("Preço total da compra com desconto (nota): R$" + notaTot.ToString("F2"));
            }
            
            Console.ReadKey();
        }
    }
}
