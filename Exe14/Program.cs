using System;

namespace Exe14
{
    class Program
    {
        static void Main(string[] args)
        {
            double salFinal, aumento;
            Console.WriteLine("Digite o salário do funcionário:");
            double salario = double.Parse(Console.ReadLine());

            if(salario < 300){
                aumento = salario * 0.50;
                salFinal = salario + aumento;
            }else  if(salario < 500){
                aumento = salario * 0.40;
                salFinal = salario + aumento;
            }else  if(salario < 700){
                aumento = salario * 0.30;
                salFinal = salario + aumento;
            }else  if(salario < 800){
                aumento = salario * 0.20;
                salFinal = salario + aumento;
            }else  if(salario < 1000){
                aumento = salario * 0.10;
                salFinal = salario + aumento;
            }else{
                aumento = salario * 0.05;
                salFinal = salario + aumento;
            }
            Console.WriteLine("Valor do aumento: R$" + aumento.ToString("F2"));
            Console.WriteLine("Novo salário: R$" + salFinal.ToString("F2"));
            Console.ReadKey();
        }
    }
}
