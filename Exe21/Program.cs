using System;

namespace Exe21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Digite o preço do produto:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Código de origem do produto:");
            int cod = int.Parse(Console.ReadLine());

            if(cod == 0 || cod > 30){
                Console.WriteLine("Este código não existe!\nPor favor, reinicie o programa!");
            }else{
                int codigo = cod;
                double pre = preco;
                String procedencia = null;
                if(codigo == 1){
                    procedencia = " Sul ";
                }else  if(codigo == 2){
                    procedencia = " Norte ";
                }else  if(codigo == 3){
                    procedencia = " Leste ";
                }else  if(codigo == 4){
                    procedencia = " Oeste ";
                }else   if(codigo >= 5 && codigo <= 6){
                    procedencia = " Nordeste ";
                }else if(codigo >= 7 && codigo <= 9){
                    procedencia = " Suldeste ";
                }else if(codigo >= 10 && codigo <= 20){
                    procedencia = " Centro-Oeste ";
                }else if(codigo >= 21 && codigo <= 30){
                    procedencia = " Nordeste ";
                } 
                Console.WriteLine(" Produto de R$" + pre.ToString("F2"));
                Console.WriteLine(" É de procedência da regiao" + procedencia + ".");
            }
            Console.ReadKey();
        }
    }
}
