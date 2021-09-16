using System;

namespace Exe07
{
    class Program
    {
        static void Main(string[] args)
        {
            double aumento;
            Console.WriteLine("Digite o salário do funcionário:");
            double salario = double.Parse(Console.ReadLine());
            if(salario <= 500){
                aumento = salario + (salario * 0.30); 
                Console.WriteLine("O novo salario será: " + aumento.ToString("F2"));

            }else{
                Console.WriteLine("Esse funcionário não tem direito ao aumento!");
            }
            Console.ReadKey();
        }
    }
}
