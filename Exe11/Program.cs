using System;

namespace Exe11
{
    class Program
    {
        static void Main(string[] args)
        {
            double totAumento, porcAumento = 0;
            Console.WriteLine("Digite o salario do funcionário:");
            double salario = double.Parse(Console.ReadLine());

            if(salario < 300){
                porcAumento = 0.15;
                totAumento = salario + (salario * porcAumento);
            }else if(salario < 600){
                porcAumento = 0.10;
                totAumento = salario + (salario * porcAumento);
            }else if(salario < 900){
                porcAumento = 0.05;
                totAumento = salario + (salario * porcAumento);
            }else {
                totAumento = salario + (salario * porcAumento);
            }
            Console.WriteLine("Novo salario: R$" + totAumento.ToString("F2"));
            
            Console.ReadKey();
        }
    }
}
