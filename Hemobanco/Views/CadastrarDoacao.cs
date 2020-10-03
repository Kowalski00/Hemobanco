using Hemobanco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hemobanco.Views
{
    class CadastrarDoacao
    {
        public static void Renderizar()
        {

            Doacao d = new Doacao();
            Console.WriteLine("[]-- Realizar Doação --[]");
            Console.WriteLine("Digite o CPF do Doador:");
            string CPF = Console.ReadLine();
            Doador doador = DAO.DoadorDAO.BuscaPorCPF(CPF);
            Console.WriteLine("Insira o tipo do Sangue:");
            string tipoSangue = Console.ReadLine();
            Sangue sangue = DAO.SangueDAO.BuscarPorTipo(tipoSangue);
            Console.WriteLine("Digite a quantidade a ser doada(ml):");
            double qtde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Funcionario realizando a doação (CPF):");
            string cpfFunc = Console.ReadLine();
            Funcionario f = DAO.FuncionarioDAO.BuscarPorCPF(cpfFunc);

            d.Doador = doador;
            d.Sangue = sangue;
            d.QtdSangue = qtde;

            DAO.DoacaoDAO.Cadastrar(d);
            DAO.EstoqueDAO.AtualizarEstoque(d, f);

            d = new Doacao();


        }
    }
}
