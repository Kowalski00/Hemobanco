using Hemobanco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hemobanco.Views
{
    class ListarDoador
    {
        public static void Renderizar() {
            int op;
            do
            {
                Console.WriteLine("\n[]-- Listagem de Doadores --[]");
                Console.WriteLine("\nOpções: 1 - Listar Todos Doadores; 2 - Buscar por CPF; 3 - Buscar por Email; 0 - Sair;");
                Console.WriteLine("Digite sua opção: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (op) {
                    case 1:
                        Console.WriteLine("\n[]-- Doadores: ");
                        Console.WriteLine("[]---------------------------------------[]");
                        List<Doador> lst = DAO.DoadorDAO.ListarTodos();
                        foreach (Doador doador in lst)
                        {
                            Console.WriteLine("    "+doador.ToString());
                        }
                        Console.WriteLine("[]---------------------------------------[]");
                        break;
                    case 2:
                        string cpf;
                        Console.WriteLine("Insira o CPF:");
                        cpf = Console.ReadLine();
                        Doador d = DAO.DoadorDAO.BuscaPorCPF(cpf);
                        string msg = d != null ? d.ToString() : "Doador não encontrado.";
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
