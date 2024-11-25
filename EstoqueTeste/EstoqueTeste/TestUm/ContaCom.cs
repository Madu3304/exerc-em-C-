using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueTeste.TestUm
{
    class ContaCom
    {
        public int Number {  get; set; }    
        public string Holder { get; set; }
        public double Balance { get; set; }

        public ContaCom()
        {
        }

        public ContaCom(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {

            Balance -= amount;
        }

        public void Deposito(double amount)
        {
            Balance += amount;
        }
    }
}
