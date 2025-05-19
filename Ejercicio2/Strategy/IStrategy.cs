using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTransaccionesBancarias_DiseñoDeSistemas.Strategy
{
    public interface IStrategy
    {
        public decimal transferir(decimal saldo); 
    }
}
