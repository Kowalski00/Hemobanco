using Hemobanco.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hemobanco.DAO
{
    class DoadorDAO 
    {
        private static Context _context = SingletonContext.GetInstance();

        public static void Cadastrar(Doador d) {
            if (BuscaPorCPF(d.CPF) == null)
            {
                _context.Doadores.Add(d);
                _context.SaveChanges();
                Console.WriteLine("Cadastro Realizado.");
            }
            else Console.WriteLine("Já existe um cadastro com esse CPF.");
            
        }

        public static List<Doador> ListarTodos() => _context.Doadores.ToList();

        public static Doador BuscaPorCPF(String cpf) => _context.Doadores.FirstOrDefault(x => x.CPF == cpf);

        public static void Alterar(Doador d) {
            _context.Doadores.Update(d);
            _context.SaveChanges();
            Console.WriteLine("Alteração Realizada.");
        }

        public static void RemoverPorCPF(String cpf) {
            Doador d = BuscaPorCPF(cpf);
            if (d != null) {
                Remover(d);
            }
        }
        public static void Remover(Doador d)
        {
            _context.Doadores.Remove(d);
            _context.SaveChanges();
            Console.WriteLine("Remoção Realizada.");
        }

    }
}
