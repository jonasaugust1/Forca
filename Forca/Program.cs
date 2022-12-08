using Forca.Metodos;

namespace Forca
{
    public class Program
    {
        static void Main(string[] args)
        {
            int tentativas = 7;

            string palavra = Palavra.GeraPalavraAleatoria();

            string[] lista = Palavra.Codificar(palavra);
            
            Console.WriteLine($"Palavra com {lista.Length} letras: ");
           
            Console.WriteLine(string.Join("", lista));

            string palavraDigitada = "";
         
            while(tentativas > 0)
            {
                string letra = string.Empty;
                try
                {
                    Console.WriteLine("Digite uma letra");
                    letra = Console.ReadLine().ToLower();

                    if (letra == null) throw new Exception();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Nenhuma letra digitada");
                }
               

                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i].ToString() == letra)
                    {
                        lista[i] = palavra[i].ToString();

                        palavraDigitada = String.Join("", lista);

                        Console.WriteLine(palavraDigitada + "\n");
                    }
                }

                if(palavraDigitada == palavra)
                {
                    Console.WriteLine("Parabéns, você ganhou!!");
                    break;
                }

                if (!palavra.Contains(letra))
                {
                    tentativas--;
                    Desenho.Desenhar(tentativas);
                }
            }

            if (tentativas == 0) Console.WriteLine("Acabou suas chances. Você perdeu!");
        }

       
    }
}