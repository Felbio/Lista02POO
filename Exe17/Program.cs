using System;

namespace Exe16
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Seja bem vindo!");
            Console.WriteLine("Digite a tua senha de login:");
            int senha = int.Parse(Console.ReadLine());

            if (senha == 4531){
                Console.WriteLine("Acesso permitido!");
            }else{
                Console.WriteLine("Acesso negado!");
            }
            Console.ReadKey();

        }
    }
}
