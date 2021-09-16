using System;

namespace Exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;
            
            Console.WriteLine("Digite a 1ª nota:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2ª nota:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 1ª nota:");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 1ª nota:");
            n4 = double.Parse(Console.ReadLine());
            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("Media: " + media.ToString("F2"));
            if(media >= 7.00){
                Console.WriteLine("Aluno Aprovado!");
            }else{
                Console.WriteLine("Aluno Reprovado!");
            }
            Console.ReadKey();
        }
    }
}
