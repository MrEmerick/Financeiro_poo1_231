using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Conta
    {

        private string _numero;
        private decimal _saldo;
        private static decimal _saldoTotal;
        private static string _contaMaiorSaldo;
        private static decimal _maiorSaldo;

        //Polimorfismo de sobrecarga
        public Conta(string numero)
        {
            _numero = numero;
        }

        public Conta(string numero, decimal saldo) 
        {
            _saldo = saldo;
            _numero = numero;
            _saldoTotal += saldo;
            if (saldo > _maiorSaldo)
            {
                _maiorSaldo = saldo;
                _contaMaiorSaldo = _numero;
            }
        }
       

        public string Numero {
            get => _numero; 
            private set => _numero = value; 
        }
        public decimal Saldo { 
            get => _saldo; 
            private set => _saldo = value; 
        }
        public decimal SaldoTotal { 
            get => _saldoTotal; 
            private set => _saldoTotal = value; }
        public string ContaMaiorSaldo
        {
            get => _contaMaiorSaldo;
        }
        public Cliente Titular { get; set; }
        public void Depositar(decimal valor)
        {
            if(valor < 0)
            {
                Saldo += valor;
            }
        }
       
        public bool Sacar(decimal valorSaque)
        {
            if (_saldo - valorSaque < 0)
            {
                return false;
            }
            _saldo -= valorSaque;
            return true;

        }
        

        
    }
}
