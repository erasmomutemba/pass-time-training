using Console_Aplication_project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Aplication_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chamadas dos metodos de outras classes

            // Par ou Inpar
            //Estruturas_de_Controle_e_Repeticao estruturas = new Estruturas_de_Controle_e_Repeticao();
            //estruturas.VerificaParOuInpar();

            //// Media de Numeros na lista
            //CalculaMedia calculaMedia = new CalculaMedia();
            //calculaMedia.CalculaMediaNaLista();

            //// Tabuada 
            //Tabuada tabuada = new Tabuada();
            //tabuada.InprimeTabuada();

            // Numero Primo
            //NumeroPrimo numeroPrimo = new NumeroPrimo();
            //numeroPrimo.VerificaNumeroPrimo();

            // Factorial
            Factorial factorial = new Factorial();
            factorial.CalculaOFactorial();
        }        
    }
}
