using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Aplication_project.Classes
{
    internal class NumeroPrimo
    {
        public void VerificaNumeroPrimo()
        {
            bool numeroPrimo = true;

            int numeroPorVerificar;
            Console.WriteLine("Incira o numero que dejesa verificar se e primo: ");
            numeroPorVerificar = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numeroPorVerificar; i++)
            {
                if (numeroPorVerificar % i == 0 && i != 1 && i != numeroPorVerificar)
                    numeroPrimo = false;
            }

            if (numeroPrimo)
                Console.WriteLine("O numero e primo...");
            else
                Console.WriteLine("O numero nao e primo...");
        }
    }
}
