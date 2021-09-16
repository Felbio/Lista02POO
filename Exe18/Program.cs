using System;

namespace Exe18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a tua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 18){
                Console.WriteLine("Você é maior de idade!");
            }else{
                Console.WriteLine("Você não atingiu a maioridade!");
            }
            Console.ReadKey();
        }
    }
}
