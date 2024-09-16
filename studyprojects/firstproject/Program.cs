using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try { 
                
                Console.Write("Digite o primeiro número: ");
                string n1 = Console.ReadLine();
                int number1 = int.Parse(n1);

                Console.Write("Digite o segundo número: ");
                string n2 = Console.ReadLine();
                int number2 = int.Parse(n2);

                Console.Write("Digite o operador um dos operadores +,-,*,/: ");
                string operador = Console.ReadLine();
                int result = 0;

                switch (operador)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        result = number1 / number2;
                        break;
                    default:
                        Console.WriteLine("Operador inválido");
                        break;

                }
                Console.WriteLine($"O resultado é: {result}");
                } catch {
                    Console.WriteLine("Desculpe, parace que você digitou um valor errado");

                }






            }
        }
    }
}
