using Hemobanco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hemobanco.Views
{
    class CadastrarFuncionario
    {
        public static void Renderizar()
        {

            Funcionario f = new Funcionario();
            Console.WriteLine("[]-- Cadastro de Doador --[]");
            Console.WriteLine("Insira o nome:");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF:");
            f.CPF = Console.ReadLine();
            Console.WriteLine("Insira o email:");
            f.Email = Console.ReadLine();

            DAO.FuncionarioDAO.Cadastrar(f);

            f = new Funcionario();


        }
    }
}
