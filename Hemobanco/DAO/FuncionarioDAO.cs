using Hemobanco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hemobanco.DAO
{
    class FuncionarioDAO : BaseDAO
    {
        public static void Cadastrar(Funcionario f) {
            if (BuscarPorCPF(f.CPF) == null)
            {
                _context.Funcionarios.Add(f);
                _context.SaveChanges();
                Console.WriteLine("Funcionário cadastrado.");
            }
            else Console.WriteLine("Já existe um funcionário com este CPF.");
        }

        public static Funcionario BuscarPorCPF(String cpf) => _context.Funcionarios.FirstOrDefault(x => x.CPF == cpf);

        public static List<Funcionario> ListarTodos() => _context.Funcionarios.ToList();

        public static void Alterar(Funcionario f)
        {
            _context.Funcionarios.Update(f);
            _context.SaveChanges();
            Console.WriteLine("Alteração Realizada.");
        }

        public static void RemoverPorCPF(String cpf)
        {
            Funcionario f = BuscarPorCPF(cpf);
            if (f != null)
            {
                Remover(f);
            }
        }

        public static void Remover(Funcionario f) { 
            _context.Funcionarios.Remove(f);
            _context.SaveChanges();
            Console.WriteLine("Removido.");
        }
    }
}
