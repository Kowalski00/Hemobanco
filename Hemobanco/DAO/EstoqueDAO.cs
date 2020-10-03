using Hemobanco.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Hemobanco.DAO
{
    class EstoqueDAO : BaseDAO
    {
        public static void AtualizarEstoque(Doacao d, Funcionario f) {
            Estoque estoque = BuscarEstoquePorSangue(d.Sangue);
            if (estoque == null) {
                Estoque e = new Estoque(d.Sangue);
                _context.Estoques.Add(e);
                _context.SaveChanges();
                Console.WriteLine($"Estoque do sangue {1} cadastrado", d.Sangue);
            }
            estoque = BuscarEstoquePorSangue(d.Sangue);
            estoque.Quantidade = d.QtdSangue + estoque.Quantidade;
                estoque.Func = f;

                _context.Estoques.Update(estoque);
                _context.SaveChanges();
            
        
        }

        public static void ReservaEstoque(Reserva reserva) {
            Estoque estoque = BuscarEstoquePorSangue(reserva.sangue);
            estoque.Quantidade = estoque.Quantidade - reserva.Quantidade;
            _context.Estoques.Update(estoque);
            _context.SaveChanges();
        }

        public static Estoque BuscarEstoquePorSangue(Sangue s) {
            return _context.Estoques.FirstOrDefault(x => x.sangue == s);
        }

        public static Estoque BuscarPorFuncionario(Funcionario f) => _context.Estoques.FirstOrDefault(x => x.Func == f);

        public static List<Estoque> ListarTodos() => _context.Estoques.Include(s => s.sangue).Include(f => f.Func).ToList(); 
    }
}
