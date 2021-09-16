using System;

namespace Exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2)/2;

            if (media >= 7){
                Console.WriteLine("Aluno aprovado!");
                }
            else if(media >= 4){
                Console.WriteLine("Exame!");
                }
            else{
                Console.WriteLine("Aluno reprovado!");
                }
            Console.ReadKey();
        }
    }
}
