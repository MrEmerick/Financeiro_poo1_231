using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Cliente
    {
        public Cliente(string nome, string cpf, int anoNascimento)
        {
            if (2023 - anoNascimento < 18)
                throw new ArgumentException("O cliente deve ser maior de idade");
            if (cpf.Length != 11)
                throw new ArgumentException("CPF inválido!");

           
           
            Nome = nome;
            Cpf = cpf;
            AnoNascimento = anoNascimento;
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public int AnoNascimento { get; private set; }

    }

}
