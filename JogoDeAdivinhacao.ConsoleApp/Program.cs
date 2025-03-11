using System.Runtime.CompilerServices;

namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Jogo de Adivinhação");
                Console.WriteLine("----------------------------------------");

                Random geradorDeNumeros = new Random();
                int numeroSecreto = geradorDeNumeros.Next(1, 21);

                Console.Write("Digite um número entre 1 e 20: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado == numeroSecreto)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Parabéns! Você acertou!");
                    Console.WriteLine("----------------------------------------");
                }
                else if (numeroDigitado > numeroSecreto)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("O número digitado é maior que o número secreto.");
                    Console.WriteLine("----------------------------------------");
                }
                else
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("O número digitado é menor que o número secreto.");
                    Console.WriteLine("----------------------------------------");
                }

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
