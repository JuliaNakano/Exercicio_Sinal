using System;

namespace Exercicio_Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
           //exibir se o numero é negativo, positivo ou zero
            double numerodigitado;
            
            Console.WriteLine("\nO programa consiste em analisar o numero digitado e dizer se é negaivo, positivo ou igual à zero.");
            Console.WriteLine("Para iniciá-lo basta....");
            
            Console.Write("\nDigite um número: ");
            numerodigitado = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if(numerodigitado>0)
            {
                Console.WriteLine("O número digitado é positivo.");
                
            }
            if(numerodigitado==0)
            {
                Console.WriteLine("O número digitado é igual a zero");
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if(numerodigitado<0)
            {
                Console.WriteLine("O número digitado é negativo");
                
            }
           
           Console.ResetColor();
            Console.WriteLine("");



        }
    }
}
