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

                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Você digitou: {numeroDigitado}");
                Console.WriteLine($"O número secreto era: {numeroSecreto}");
                Console.WriteLine("----------------------------------------");

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
