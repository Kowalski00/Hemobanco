using Hemobanco.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hemobanco.DAO
{
    class SangueDAO : BaseDAO
    {
        public static void Cadastrar(Sangue s) {
            if (ValidaTipo(s.SangueTipo))
            {
                if (BuscarPorTipo(s.SangueTipo) == null)
                {
                    _context.Sangues.Add(s);
                    _context.SaveChanges();
                    Console.WriteLine("Cadastrado.");
                }
                else Console.WriteLine("Já existe este tipo cadastrado.");
            }
            else Console.WriteLine("Não existe este tipo de sangue.");
        }
        public static Sangue BuscarPorTipo(string tipo) => _context.Sangues.FirstOrDefault(x => x.SangueTipo == tipo);

        public static bool ValidaTipo(string tipo) {
            if (tipo == "A+" || tipo == "A-" || tipo == "AB+" || tipo == "AB-" || tipo == "B+" || tipo == "B-" || tipo == "O+" || tipo == "O-")
                return true;
            return false;
        }
    }
}
