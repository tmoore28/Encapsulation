using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var yourAccount = new BankAccount();
            Console.WriteLine("Current Balance");
            Console.WriteLine(yourAccount.GetBalance());

            yourAccount.Deposit(124.75);
            Console.WriteLine("Current Balance");
            Console.WriteLine(yourAccount.GetBalance());
            Console.ReadKey();
        }
    }
}
