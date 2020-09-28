using Hemobanco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hemobanco.Views
{
    class ListarFuncionario
    {
        public static void Renderizar()
        {
            int op;
            do
            {
                Console.WriteLine("[]-- Listagem de Funcionários --[]");
                Console.WriteLine("\nOpções: 1 - Listar Todos Funcionários; 2 - Buscar por CPF; 3 - Buscar por Email; 0 - Sair;");
                Console.WriteLine("Digite sua opção: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("[]-- Doadores: ");
                        foreach (Funcionario fun in DAO.FuncionarioDAO.ListarTodos())
                        {
                            fun.ToString();
                        }
                        Console.WriteLine("[]---------------------------------------[]");
                        break;
                    case 2:
                        string cpf;
                        Console.WriteLine("Insira o CPF:");
                        cpf = Console.ReadLine();
                        Funcionario f = DAO.FuncionarioDAO.BuscarPorCPF(cpf);
                        string msg = f != null ? f.ToString() : "Doador não encontrado.";
                        Console.WriteLine(msg);
                        break;
                    case 3:
                        Console.WriteLine("TODO");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("\n[]-- Não existe esta opção.");
                        break;
                }
            } while (op != 0);


        }
    }
}
