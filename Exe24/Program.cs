using System;

namespace Exe24
{
    class Program
    {
        static void Main(string[] args)
        {         
            String situacao = null;
            Console.WriteLine("Digite o produto: \n1-Limpeza\n2-Alimentos\n3-Roupas");
            int escol = int.Parse(Console.ReadLine());

            if(escol == 1){
                Console.WriteLine(" 'R' para utilizará o freezer e 'N' para não utilizar:");
                situacao = Console.ReadLine();

                if(situacao == "r"){
                    Console.WriteLine("Você escolheu o produto de limpeza!");
                    Console.WriteLine("Certamente utilizará o freezer!");
                }else if(situacao == "n"){
                    Console.WriteLine("Você escolheu o produto de limpeza!");
                    Console.WriteLine("Certamente não utilizará o freezer!");
                }else{
                Console.WriteLine("Opção inválida!");
                }
            }else
            if(escol == 2){
                Console.WriteLine(" 'R' para utilizará o freezer e 'N' para não utilizar:");
                situacao = Console.ReadLine();

                if(situacao == "r"){
                    Console.WriteLine("Você escolheu o produto alimentício!");
                    Console.WriteLine("Certamente utilizará o freezer!");
                }else if(situacao == "n"){
                    Console.WriteLine("Você escolheu o produto alimentício!");
                    Console.WriteLine("Certamente não utilizará o freezer!");
                }else{
                Console.WriteLine("Opção inválida!");
                }
            }else
            if(escol == 3){
                Console.WriteLine(" 'R' para utilizará o freezer e 'N' para não utilizar:");
                situacao = Console.ReadLine();

                if(situacao == "r"){
                    Console.WriteLine("Você escolheu roupas!");
                    Console.WriteLine("Certamente utilizará o freezer!");
                }else if(situacao == "n"){
                    Console.WriteLine("Você escolheu roupas!");
                    Console.WriteLine("Certamente não utilizará o freezer!");
                }else{
                Console.WriteLine("Opção inválida!");
                }
            }else{
                Console.WriteLine("Opção inválida!");
            }
            Console.ReadKey();              
        }
    }
}
