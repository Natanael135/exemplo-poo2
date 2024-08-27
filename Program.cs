// See https://aka.ms/new-console-template for more information
using exemplo_poo2.Models;

Console.WriteLine("Hello, World!");


Corrente coc = new Corrente(500M);
coc.Creditar(500.50M);
coc.ExibirSaldo();
coc.Sacar(50M);
coc.ExibirSaldo();

Poupança cop = new Poupança(500M);
cop.Creditar(500.50M);
cop.ExibirSaldo();
cop.Sacar(15M);
cop.ExibirSaldo();