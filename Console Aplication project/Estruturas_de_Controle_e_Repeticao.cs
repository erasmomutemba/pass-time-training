using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Aplication_project
{
    internal class Estruturas_de_Controle_e_Repeticao
    {

        // Par ou Inpar
        public void VerificaParOuInpar()
        {
            int numeroPorVerificar;
            Console.WriteLine("Incira o numero que dejesa verificar: ");
            numeroPorVerificar = int.Parse(Console.ReadLine());

            if (numeroPorVerificar % 2 == 0)
            {
                Console.WriteLine("O numero inserido e par");
            }
            else
                Console.WriteLine("O numero inserido e inpar");
        }
    }
}
