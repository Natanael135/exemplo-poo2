using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo2.Models
{
    public class Corrente : Conta
    {
        public Corrente(decimal saldoInicial) : base(saldoInicial)
        {
        }

        public decimal taxaSaque { get; set; }
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