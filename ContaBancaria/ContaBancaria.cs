using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancaria
{
    class ContaBancaria
    {
        //Constante para armazenar o valor da taxa bancária...
        private static double _TAXA_BANCARIA = 5.00;

        private int _numero;
        private string _titular;
        private double _saldo;

        public ContaBancaria(int numero, string titular) {
            this._numero = numero;
            this._titular = titular;
            this._saldo = 0;
        }

        public ContaBancaria(int numero, string titular, double saldo) {
            this._numero = numero;
            this._titular = titular;
            this._saldo = saldo;
        }

        public int Numero{
            get { return _numero; }
        }

        public string Titular
        {
            get { return _titular; }
        }

        public double Saldo {
            get { return _saldo; }
        }

        public void Deposito(double quantia) {
            if (quantia > 0){
                this._saldo += quantia;
            }
        }

        public void Saque(double quantia) {
            this._saldo -= (quantia + _TAXA_BANCARIA); 
        }

        public override string ToString()
        {
            return "Número da Conta: "+_numero+", "+
                   "Titular: "+_titular+", "+
                   "Saldo: R$ "+_saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
