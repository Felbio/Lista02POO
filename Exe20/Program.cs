using System;

namespace Exe20
{
    class Program
    {
        static void Main(string[] args)
        {
            String cat = null;                       
            
            Console.WriteLine("Digite a tua idade!");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 100){

                if (idade >= 5 && idade <=7){
                    cat = " Infantil";
                }else if (idade >= 8 && idade <= 10){
                    cat = " Juvenil";
                }else if (idade >= 11 && idade <= 15){
                    cat = " Adolescente";
                }else if (idade >= 16 && idade <= 30){
                    cat = " Adulto";
                }else {
                    cat = " Sênior";
                }
                Console.WriteLine("Você tem " + idade + " anos e é nadador" + cat + ".");
            }else{
                Console.WriteLine("Idade inválida!");
            }
            Console.ReadKey();
        }
    }
}
