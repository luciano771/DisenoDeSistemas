using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTransaccionesBancarias_DiseñoDeSistemas.Strategy
{
    public class StrategyContext
    {

        private IStrategy strategy;

        public StrategyContext(IStrategy strategy)
        { 
            setStrategy(strategy);
        }
        public void setStrategy(IStrategy strategy)
        {
            this.strategy = strategy; 
        }

        public decimal transferir(decimal saldo)
        {
            decimal saldoTransferido = strategy.transferir(saldo); 
            return saldoTransferido;
        }
    }
}
