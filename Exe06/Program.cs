using System;

namespace Exe06
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, dif = 0, produto;
            Console.WriteLine("Digite o 1º número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha abaixo:\n1- Média dos números\n2- Diferença do maior pelo menor\n3- Produto dos números");
            int opcao = int.Parse(Console.ReadLine());

            if(opcao == 1){
                media = (n1 + n2) / 2;
                Console.WriteLine("A média é " + media.ToString("F2"));

            }else 
            if(opcao == 2){

                if(n1 > n2){
                    Console.WriteLine("O 1º número é maior.");
                    dif = n1 - n2;
                    Console.WriteLine("A diferença entre os dois números é: " + dif.ToString("F2"));
                }else 
                if(n2 > n1){
                    Console.WriteLine("O 2º número é maior.");
                    dif = n2 - n1;
                    Console.WriteLine("A diferença entre os dois números é: " + dif.ToString("F2"));
                }else{
                    Console.WriteLine("Ambos são iguais.");
                    Console.WriteLine("A diferença entre os dois números é: " + dif.ToString("F2"));
                }                
            }else 
            if(opcao == 3){
                produto = n1 * n2;
                Console.WriteLine("O produto dos dois números é: " + produto.ToString("F2"));
                
            }else{
                Console.WriteLine("Opção inválida!\nFim do Programa!");
            }
            Console.ReadKey();
        }
    }
}
