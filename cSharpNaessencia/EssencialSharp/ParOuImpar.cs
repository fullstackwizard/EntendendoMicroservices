using System;

namespace ParOuImpar
{
    internal class ParOuImpar 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um n�mero para verificar se � Par ou �mpar:");

            double numero = ObterNumero("Digite o N�mero: ");

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O n�mero {numero} � Par.");
            }
            else
            {
                Console.WriteLine($"O n�mero {numero} � �mpar.");
            }
        }

        static double ObterNumero(string mensagem)
        {
            Console.Write(mensagem);

            return double.TryParse(Console.ReadLine(), out double resultado) ? resultado : 0;
        }
        
}

/* Metodo Direto 

{
            Console.Write("Digite um n�mero: ");
            double.TryParse(Console.ReadLine(), out double numero);

            Console.WriteLine($"O n�mero {numero} � {(numero % 2 == 0 ? "Par" : "�mpar")}.");
        }

*/