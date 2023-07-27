using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Aplication_project.Classes
{
    internal class Tabuada
    {
        public void InprimeTabuada()
        {
            int numeroDaTabuada;
            Console.WriteLine("Insira o numero que deseja visualizar a tabuada: ");
            numeroDaTabuada = int.Parse(Console.ReadLine());

            for(int i = 0; i < 11 ; i++)
            {
                Console.WriteLine(numeroDaTabuada + " * " + i + " = " + numeroDaTabuada * i);
            }
        }
    }
}
