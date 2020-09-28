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
            Console.WriteLine("Digite o CPF:");
            string CPF = Console.ReadLine();
            Doador doador = DAO.DoadorDAO.BuscaPorCPF(CPF);
            Console.WriteLine("Insira o tipo do Sangue:");
            string tipoSangue = Console.ReadLine();
            Sangue sangue = DAO.SangueDAO.BuscarPorTipo(tipoSangue);
            Console.WriteLine("Digite a quantidade a ser doada:");
            double qtde = Convert.ToDouble(Console.ReadLine());

            d.Doador = doador;
            d.Sangue = sangue;
            d.QtdSangue = qtde;

            DAO.DoacaoDAO.Cadastrar(d);

            d = new Doacao();


        }
    }
}
