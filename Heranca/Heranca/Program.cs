using System;
using System.Collections.Generic;
using System.Globalization;

namespace Heranca.Entities
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Funcionario> List = new List<Funcionario>();

            Console.Write("Informe a quantidade de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Empregado  #{i} data: ");
                Console.Write("Funcionario é tercerizado (S/N)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int hora = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora:");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'S')
                {

                    Console.Write("Dispesa adicional: ");
                    double dispesaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    List.Add(new FuncionarioTercerizado(nome, hora, valor, dispesaAdicional));
                }
                else
                {
                    List.Add(new Funcionario(nome, hora, valor));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamento: ");
            foreach (Funcionario func in List)
            {
                Console.WriteLine(func.Nome + " - $ " + func.Pagamento().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
