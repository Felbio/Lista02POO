using System;

namespace Exe12
{
    class Program
    {
        static void Main(string[] args)
        {
            double gratificação = 0, imposto = 0.07, salFinal;
            Console.WriteLine("Digite o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());
            if(salario < 350){
                gratificação = 100.00;
                salFinal = salario - (salario * imposto) + gratificação;
            }else if(salario < 600){
                gratificação = 75.00;
                salFinal = salario - (salario * imposto) + gratificação;
            }else if(salario < 900){
                gratificação = 50.00;
                salFinal = salario - (salario * imposto) + gratificação;
            }else{
                gratificação = 35.00;
                salFinal = salario - (salario * imposto) + gratificação;
            }
            Console.WriteLine("Salario final: R$" + salFinal.ToString("F2"));

            Console.ReadKey();
        }
    }
}
