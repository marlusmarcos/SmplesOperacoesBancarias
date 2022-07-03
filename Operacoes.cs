using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_banco
{
    public class Operacoes
    {
        public double creditar (double valor, Conta conta) {
            if (valor <= 0.0) {
                throw new Exception ("Valor menor ou igual 0!");
            }
             conta.saldo += valor;
            return  conta.saldo;
        }
        public double debitar (double valor, Conta conta) {
            if (valor > conta.saldo) {
                throw new Exception ("Valor em conta menor que não é permitido!");
            }
             conta.saldo -= valor;
            return conta.saldo;
        }

        public double transferir (double valor, Conta emissora, Conta receptora)
        {
            if (valor > emissora.saldo ) {
                throw new Exception ("Valor maior que saldo em conta!");
            }
            else {
                emissora.saldo -= valor;
                receptora.saldo +=valor;
            }
            return receptora.saldo;

        }

    }
}