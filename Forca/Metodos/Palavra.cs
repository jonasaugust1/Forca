using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca.Metodos
{
    public class Palavra
    {
        public static string GeraPalavraAleatoria()
        {
            string[] listaPalavras =
            {
                "corinthians",
                "guepardo",
                "sergipe",
                "bermuda",
                "java",
                "mandioca"
            };

            Random random = new Random();

            string palavraEscolhida = listaPalavras[random.Next(listaPalavras.Length)];

            return palavraEscolhida;
        }

        public static string[] Codificar(string palavra)
        {
            string[] lista = new string[palavra.Length];
            Array.Fill(lista, "*");

            return lista;
        }
    }
}
