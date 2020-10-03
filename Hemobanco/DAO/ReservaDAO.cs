using Hemobanco.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hemobanco.DAO
{
    class ReservaDAO : BaseDAO
    {
        public static void CadastrarReserva(Reserva reserva) {
            if (EstoqueDisponivel(reserva.sangue, reserva.Quantidade))
            {
                _context.Reservas.Add(reserva);
                _context.SaveChanges();
                EstoqueDAO.ReservaEstoque(reserva);
                Console.WriteLine("Reserva realizada.");
            }
            else
                Console.WriteLine("Não há estoque disponível. Reserva não realizada.");

        }


        public static bool EstoqueDisponivel(Sangue s, int qtd) {
            Estoque estoque = _context.Estoques.FirstOrDefault(e => e.sangue == s);
            if (estoque.Quantidade > qtd)
                return true;
            return false;
        }
    }
}
