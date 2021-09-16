using System;

namespace Exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            double dif = 0;
            Console.WriteLine("Digite o primeiro numero:");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha uma opção:\n1- Média\n2- Diferença de maior e menor\n3- Produto\n4- Divisão ");
            int escolha = int.Parse(Console.ReadLine());
            
            if(escolha == 1){
            double media = (n1 + n2) / 2;
            Console.WriteLine("A media é " + media.ToString("F2"));
            }else 
            if(escolha == 2){                        
                if(n1 > n2){
                    dif = n1 - n2;
                    Console.WriteLine("O primeiro número é maior!"); 
                    Console.WriteLine("A diferença é " + dif.ToString("F2"));              
                }else if(n2 > n1){
                    dif = n2 - n1;
                    Console.WriteLine("O segundo número é maior!");
                    Console.WriteLine("A diferença é " + dif.ToString("F2"));      
                }else{
                    Console.WriteLine("Ambos são iguais");                
                    Console.WriteLine("A diferença é " + dif.ToString("F2"));
                }
            }else 
            if(escolha == 3){
                double produto = n1 * n2;
                Console.WriteLine("O produto é " + produto.ToString("F2"));
            }else 
            if(escolha == 4){            
                if(n2 == 0){
                    Console.WriteLine("Divisão impossivel!");
                }else{
                double divisao = n1 / n2; 
                Console.WriteLine("A divisão é " + divisao.ToString("F2"));
                }

            }
            else{
                Console.WriteLine("Opção inválida!");
            }           
            Console.ReadKey();
        }
    }
}
