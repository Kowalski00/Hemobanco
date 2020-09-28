using Hemobanco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hemobanco.DAO
{
    class BaseDAO
    {
        public static Context _context = SingletonContext.GetInstance();
    }
}
