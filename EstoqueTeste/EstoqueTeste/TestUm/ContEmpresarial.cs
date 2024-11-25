using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueTeste.TestUm
{
    //para herdar os atributos de outras classe adicionei aqui ": nome da classe a qual estou pegando".
    class ContEmpresarial : ContaCom
    {
        public double LoanLimit { get; set; }

        public ContEmpresarial()
        {

        }
        //aqui tem um metodo construtor, para herdar os atributos de outras classe adicionei aqui ": base (atributos)".
        public ContEmpresarial(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {

            //testar se o valor emprestado é menor que o valor limite. 
            if (amount <= LoanLimit)
            {
                //função emprestar valor 
                Balance += amount;
            }   

        }
    }
}
