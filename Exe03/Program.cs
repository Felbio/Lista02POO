using System;

namespace Exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite B:");
            int b = int.Parse(Console.ReadLine());

            if(a < b){
                Console.WriteLine("A é menor que B");
            }else if(b < a){
                Console.WriteLine("B é menor que A");
            }else{
                Console.WriteLine("Ambos são iguais!");
            }
            Console.ReadKey();
        }
    }
}
