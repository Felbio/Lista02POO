using System;

namespace Exe10
{
    class Program
    {
        static void Main(string[] args)
        {
            double porcImposto = 0, porcDistrib = 0, valFinal = 0; 
            Console.WriteLine("Digite o valor do carro:");
            double valCar = double.Parse(Console.ReadLine());
            if(valCar < 12000){
                porcDistrib = 0.05;
                valFinal = valCar + (valCar * porcImposto) + (valCar * porcDistrib);
            }else if(valCar < 25000){
                porcImposto = 0.15;
                porcDistrib = 0.10;
                valFinal = valCar + (valCar * porcImposto) + (valCar * porcDistrib);
            }else{
                porcImposto = 0.15;
                porcDistrib = 0.20;
                valFinal = valCar + (valCar * porcImposto) + (valCar * porcDistrib);
            }
            Console.WriteLine("Valor final do carro: R$ " + valFinal.ToString("F2"));

            Console.ReadKey();
        }
    }
}
