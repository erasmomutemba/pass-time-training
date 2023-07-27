using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Aplication_project.Classes
{
    internal class Factorial
    {
        public void CalculaOFactorial()
        {
            int numeroPorVerificar;
            Console.WriteLine("Incira o numero que dejesa verificar o Factorial: ");
            numeroPorVerificar = int.Parse(Console.ReadLine());

            int factorial = 1;

            for(int i = 1; i <= numeroPorVerificar; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("O Factorial do numero e " + factorial);
        }
    }
}
