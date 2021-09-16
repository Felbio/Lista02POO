using System;

namespace Exe08
{
    class Program
    {
        static void Main(string[] args)
        {
            double reajuste;
            Console.WriteLine("Digite o salário do funcionário, em R$:");
            double salario = double.Parse(Console.ReadLine());
            if(salario <= 300){
                reajuste = salario + (salario * 0.30);
                Console.WriteLine("Salário reajustado: R$" + reajuste.ToString("F2"));
            }else{
                reajuste = salario + (salario * 0.15);
                Console.WriteLine("Salário reajustado: R$" + reajuste.ToString("F2"));
            }
            Console.ReadKey();
        }
    }
}
