using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo2.Models
{
    public class Poupança : Conta
    {
        public Poupança(decimal saldoInicial) : base(saldoInicial)
        {
        }
        public override void Creditar(decimal deposito)
        {
            saldo += deposito;
        }

        public override void Sacar(decimal saque)
        {
            saldo -= saque;
        }
    }
}