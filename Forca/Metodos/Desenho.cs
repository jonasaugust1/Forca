using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca.Metodos
{
    public class Desenho
    {
        public static void Desenhar(int tentativas)
        {
            Console.WriteLine("  ___     ");
            Console.WriteLine(" |/      |    ");
  
            if (tentativas == 6)
            {
                Console.WriteLine(" |      (_)   ");
                Console.WriteLine(" |            ");
                Console.WriteLine(" |            ");
                Console.WriteLine(" |            ");
            }

            if (tentativas == 5)
            {
                Console.WriteLine(" |      (_)   ");
                Console.WriteLine(" |       |    ");
                Console.WriteLine(" |            ");
                Console.WriteLine(" |            ");
            }

            if (tentativas == 4)
            {
                Console.WriteLine(" |      (_)   ");
                Console.WriteLine(" |      \\|    ");
                Console.WriteLine(" |            ");
                Console.WriteLine(" |            ");
            }

            if (tentativas == 3)
            {
                Console.WriteLine(" |      (_)   ");
                Console.WriteLine(" |      \\|/    ");
                Console.WriteLine(" |            ");
                Console.WriteLine(" |            ");
            }

            if (tentativas == 2)
            {
                Console.WriteLine(" |      (_)   ");
                Console.WriteLine(" |      \\|/    ");
                Console.WriteLine(" |       |    ");
                Console.WriteLine(" |           ");
            }

            if (tentativas == 1)
            {
                Console.WriteLine(" |      (_)   ");
                Console.WriteLine(" |      \\|/    ");
                Console.WriteLine(" |       |    ");
                Console.WriteLine(" |      /     ");
            }

            if (tentativas == 0)
            {
                Console.WriteLine(" |      (_)   ");
                Console.WriteLine(" |      \\|/    ");
                Console.WriteLine(" |       |    ");
                Console.WriteLine(" |      / \\   ");
            }

            Console.WriteLine($"Tentativas restantes: {tentativas}");
            Console.WriteLine("\n");
        }
    }
}
