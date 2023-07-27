using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Aplication_project.Classes
{
    internal class CalculaMedia
    {
        private List<int> listaDeNumeros = new List<int>();
        public void CalculaMediaNaLista()
        {
            listaDeNumeros.Add(1);
            listaDeNumeros.Add(2);
            listaDeNumeros.Add(3);
            listaDeNumeros.Add(4);
            listaDeNumeros.Add(5);

            float media;
            media = listaDeNumeros.Sum() / listaDeNumeros.Count();

            foreach (int i in listaDeNumeros)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("A media dos numero apresentados e " + media);
        }
    }
}
