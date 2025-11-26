using System.ComponentModel;
using System.Numerics;

namespace ExercicioFixaxaoVetores10._3
{
    internal class Program
    {

        static string ValidaString()
        {
            string str;
            while (true)
            {
                str = Console.ReadLine();
                if (str == null || str == "")
                {
                    Console.Clear();
                    Console.Write("Inválido! Tente novamente: ");
                    continue;
                }
                break;
            }

            return str;
        }

        /*        static int ValidaInt()
                {
                    int quantidade;
                    while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 1)
                    {
                        Console.Clear();
                        Console.Write("Inválido! Informe apenas números: ");
                    }
                    return quantidade;
                }
        */

        static int ValidaIntQuartos()
        {
            int quantidade;
            while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 1 || quantidade > 10)
            {
                Console.Clear();
                Console.Write("Inválido! Informe apenas números de 1-10: ");
            }
            return quantidade;
        }

        static void Main(string[] args)
        {
            Console.Write("Quantidade de quartos a serem alugados (máx: 10): ");
            int n = ValidaIntQuartos();


            Cliente[] clienteVet = new Cliente[10];
            List<int> indisponiveis = new List<int>();
            for (int i = 0; i < n; i++)
            {


                int j = i + 1;
                Console.WriteLine($"\nAluguel #{j}");

                Console.Write("Nome: ");
                string nome = ValidaString();
                Console.Write("Email: ");
                string email = ValidaString();

                Console.Write("Quarto: ");
                int quarto;
                if (indisponiveis.Count == 0)
                {
                    quarto = ValidaIntQuartos();
                    indisponiveis.Add(quarto);
                }
                else
                {
                    while (true)
                    {
                        bool repete = false;
                        quarto = ValidaIntQuartos();
                        for (int k = 0; k < indisponiveis.Count; k++)
                        {
                            if (indisponiveis[k] == quarto)
                            {
                                repete = true;
                                break;
                            }

                        }
                        if (repete == true)
                        {
                            Console.Clear();
                            Console.Write("Quarto já alugado! Digite outro: ");
                            continue;
                        }
                        else
                        {
                            break;
                        }

                    }
                    indisponiveis.Add(quarto);
                }


                Cliente cliente = new Cliente(quarto, nome, email);
                quarto--;
                clienteVet[quarto] = cliente;
            }// final for cadastro

            Console.WriteLine("Quartos Ocupados: ");

            for (int i = 0; i < 10; i++)
            {

                if (clienteVet[i] != null)
                {
                    Console.WriteLine(clienteVet[i].ToString());
                }
            }


        }    
    }
}