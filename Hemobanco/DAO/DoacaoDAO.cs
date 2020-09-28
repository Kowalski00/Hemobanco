using Hemobanco.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Hemobanco.DAO
{
    class DoacaoDAO : BaseDAO
    {
        public static void Cadastrar(Doacao d) {
            if (BuscarPorUltimaRealizada(d.Doador.CPF)==null) {
                _context.Doacoes.Add(d);
                _context.SaveChanges();
                Console.WriteLine("Cadastrado.");
            }
            else
            {
                Doacao ultimaDoacao = BuscarPorUltimaRealizada(d.Doador.CPF);
                DateTime atual = DateTime.Now;
                if (atual.Day - ultimaDoacao.RealizadoEm.Day >= 60)
                {
                    _context.Doacoes.Add(d);
                    _context.SaveChanges();
                    Console.WriteLine("Cadastrado.");
                }
                else Console.WriteLine("O período minimo entre duas doção é de 60 dias. Ultima doação realizada em: "+ultimaDoacao.RealizadoEm);
            }
        }
        public static List<Doacao> ListarTodos() => _context.Doacoes.Include(d => d.Sangue).Include(d => d.Doador).ToList();

        public static List<Doacao> BuscarDoacoesPorCPF(string cpf)
        {
            List<Doacao> lst = ListarTodos();

            return lst.FindAll(d => d.Doador.CPF == cpf);
        }

        public static Doacao BuscarPorUltimaRealizada(string cpf) {
            List<Doacao> lst = BuscarDoacoesPorCPF(cpf);
           return lst.OrderBy(d => d.RealizadoEm).LastOrDefault();
        }
    }
}
