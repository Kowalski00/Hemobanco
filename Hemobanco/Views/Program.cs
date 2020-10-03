using Hemobanco.Models;
using System;

namespace Hemobanco.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            //Dados.Inicializar();

            do
            {
                Console.Clear();
                Console.WriteLine("[]======================================[]");
                Console.WriteLine("               Hemobanco");
                Console.WriteLine("[]======================================[]\n");

                Console.WriteLine("\nMenu");
                Console.WriteLine(" 1- Cadastrar Doador\n 2- Alterar Doador\n 3- Excluir Doador\n 4- Listar Doadores\n 5- Realizar Doação\n 6- Listar Doações\n 7- Cadastrar Funcionário\n 8- Listar Funcionários\n 9- Listar Qtde de Sangue\n 0- Sair\n");
                Console.Write("Selecione uma opção: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        CadastroDoador.Renderizar();
                        break;
                    case 2:
                        //RealizarDoacao.Renderizar();
                        break;
                    case 3:
                        //LisPessoa.RenderizarEmail();
                        break;
                    case 4:
                        ListarDoador.Renderizar();
                        break;
                    case 5:
                        CadastrarDoacao.Renderizar();
                        break;
                    case 6:
                        //LisProduto.Renderizar();
                        break;
                    case 7:
                        CadastrarFuncionario.Renderizar();
                        break;
                    case 8:
                        ListarFuncionario.Renderizar();
                        break;
                    case 9:
                        Console.Write("[]-- Digite um cpf: ");
                        string cpf = Console.ReadLine();
                        //LisVenda.Renderizar(VendaDAO.ListarPorCliente(cpf));
                        break;
                    case 0:
                        Console.WriteLine("\n[]-- Saindo...");
                        break;
                    default:
                        Console.WriteLine("\n[]-- Não existe esta opção...");
                        break;
                }
                Console.Write("\n[]-- Pressione qualquer botão para continuar: ");
                Console.ReadKey();
            } while (op != 0);
        
    }
    }
}
