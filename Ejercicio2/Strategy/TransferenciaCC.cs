using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTransaccionesBancarias_DiseñoDeSistemas.Strategy
{
    public class TransferenciaCC : IStrategy
    {
        public decimal saldo { get; set; }

        public decimal transferir(decimal saldo)
        {
            this.saldo = saldo;
            this.interes();
            return this.saldo;
        }


        public void interes()
        {
            var interesACobrar = this.saldo * 0.01m;
            this.saldo = this.saldo - interesACobrar;
        }
          
    }
}
