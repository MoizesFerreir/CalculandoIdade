﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
   class Program
   {
    static void Main(string[] args)
    {
        Console.WriteLine("Programa que calcula a Idade de uma pessoa");
        Pessoa p = new Pessoa();
        Console.Write("Nome da pessoa: ");
        p.Nome = Console.ReadLine();
        Console.Write("Ano de nascimento: ");
        p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
        p.ExibirDados();
    }
   }
}


