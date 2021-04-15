using System;
using System.Globalization;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            do{
                string[] vetor = Console.ReadLine().Split(' ');

                double n1 = double.Parse(vetor[0]);
                double n2 = double.Parse(vetor[2]);
                double result;

                char op = char.Parse(vetor[1]);

                if(op == '+'){
                    result = n1 + n2;
                    Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
                }
                else if(op == '-'){
                    result = n1 - n2;
                    Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
                }
                else if(op == 'x' || op == '*'){
                    result = n1 * n2;
                    Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
                }
                else if(op == '/'){
                    result = n1 / n2;
                    Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
                }
                else{
                    Console.WriteLine("Operação inválida.");
                }

                                
            }while(true);
        }
    }
}
