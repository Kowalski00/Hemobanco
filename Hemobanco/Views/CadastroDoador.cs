using Hemobanco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hemobanco.Views
{
    class CadastroDoador
    {
        public static void Renderizar() {

            Doador d = new Doador();
            Console.WriteLine("[]-- Cadastro de Doador --[]");
            Console.WriteLine("Insira o nome:");
            d.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            d.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o CPF:");
            d.CPF = Console.ReadLine();
            Console.WriteLine("Insira o email:");
            d.Email = Console.ReadLine();
            Console.WriteLine("Digite o endereço:");
            d.Endereco = Console.ReadLine();
            Console.WriteLine("Digite o telefone:");
            d.Telefone = Console.ReadLine();

            DAO.DoadorDAO.Cadastrar(d);

            d = new Doador();
            

        }
    }
}
