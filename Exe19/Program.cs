using System;

namespace Exe19
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;            
            Console.WriteLine("Digite teu sexo, M para masculino e F para feminino: ");
            char sex = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite a tua altura: ");
            double alt = double.Parse(Console.ReadLine());
            
                if(sex == 'm'){
                    result = (72.7 * alt) - 58;
                    Console.WriteLine("Teu peso ideal é: " + result.ToString("F2"));
                }else if(sex == 'f'){
                    result = (62.1 * alt) - 44.7;
                    Console.WriteLine("Teu peso ideal é: " + result.ToString("F2"));
                }else{
                Console.WriteLine("Dado Inválido!");
                }
                Console.ReadKey();
        }
    }
}
