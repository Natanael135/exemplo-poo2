using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo2.Models
{
    public abstract class Conta
    {
        public Conta(decimal saldoInicial)
        {
            saldo += saldoInicial;
        }
        protected Decimal saldo { get; set; }
        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu Saldo é: {saldo} Reais");
        }

        public abstract void Creditar(decimal deposito);
        public abstract void Sacar(decimal saque);

    }
}