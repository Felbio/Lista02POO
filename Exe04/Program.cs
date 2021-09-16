using System;

namespace Exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite B:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite C:");
            int c = int.Parse(Console.ReadLine());
            if(a > b && a > c){
                Console.WriteLine("A é maior!");
            }else if(b > a && b > c){
                Console.WriteLine("B é maior!");
            }else if(c > a && c > b){
                Console.WriteLine("C é maior!");
            }else{
                Console.WriteLine("A, B e C são iguais!");
            }
            Console.ReadKey();
        }
    }
}
