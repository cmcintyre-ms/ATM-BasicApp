using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_BasicApp
{
    public class User
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string CardNumber { get; set; }
        public string Pin { get; set; }
        public double CashAvailability { get; set; } = 1000.00;
        public int TransactionLimit { get; set; } = 10;
        public List<string> Transactions { get; set; }

        public static List<User> users = new List<User>()
        {
            new User() { Name = "Lara Croft", Balance = 300.00, CardNumber = "5698745632102365", Pin = "1111",
                Transactions = new List<string>()},
            new User() { Name = "Sarah Dougherty", Balance = 10000.00, CardNumber = "6987123056341036", Pin = "2222",
                Transactions = new List<string>()},
            new User() { Name = "Ezio Auditore", Balance = 0.00, CardNumber = "4369852103698206", Pin = "3333",
                Transactions = new List<string>()}
        };
    }
}
