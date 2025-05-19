using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTransaccionesBancarias_DiseñoDeSistemas.Strategy
{
    public class clientStrategy
    {
        public static void Main(string[] args)
        {
            decimal saldoATransferir = 1200.00m;
            IStrategy strategy = new TransferenciaCA();
            StrategyContext context = new StrategyContext(strategy);
            decimal resultado = context.transferir(saldoATransferir);
            Console.WriteLine("Transferencia a cuenta caja ahorro de $" + Math.Round(resultado, 2) + " fue exitosa.");

            strategy = new TransferenciaCC();
            context.setStrategy(strategy);
            context.transferir(saldoATransferir);
            resultado = context.transferir(saldoATransferir); 
            Console.WriteLine("Transferencia a cuenta corriente de $" + Math.Round(resultado, 2) + " fue exitosa.");


        }
    }
}
