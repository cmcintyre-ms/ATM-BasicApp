using System;
using System.Collections.Generic;


namespace ATM_BasicApp
{
    
    public class MainMenu
    {
        //public static string name = "Cheryl McIntyre";
        //public static double balance = 10000.00;
        //public static double cashAvailability = 1000.00;
        //public static int transactionLimit = 10;

        
        //public static List<string> transactions = new List<string>();

        public static void MainMenuStartUp(User user)
        {
            var result = user;
            Console.Clear();
            Console.WriteLine("Welcome to MS Bank");
            Console.WriteLine("------------------");
            Console.WriteLine($"Welcome {result.Name}");
            Console.WriteLine("------------------");
            Console.WriteLine();

            Console.WriteLine("Please choose from the following options");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Cash Availablity");
            Console.WriteLine("3. Previous 5 Transactions");
            Console.WriteLine("4. Cash Withdrawl");
            Console.WriteLine("Enter the menu number or press '0' to log out:- ");
            int option = Convert.ToInt32(Console.ReadLine());

            
                switch (option)
                {
                    case 0:
                        return;
                    case 1:
                        ViewBalance(result);
                        break;
                    case 2:
                        CashAvailability(result);
                        break;
                    case 3:
                        PreviousTransactions(result);
                        break;
                    case 4:
                        CashWithdrawl(result);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 - 4 or 0 to exit");
                        break;
                }
            

        }

        private static void CashWithdrawl(User user)
        {
            Console.WriteLine();
            Console.WriteLine($"Current Balance: £{user.Balance}");
            Console.WriteLine($"Number of transactions available: {user.TransactionLimit}");
            Console.WriteLine("-----------------------------------------------------");

            if (user.Balance > user.CashAvailability && user.CashAvailability > 0)
            {
                Console.WriteLine($"Please confirm you would like to withdraw £{user.CashAvailability} from your account:");
                Console.WriteLine("Press Y to confirm or N to return to the Main Menu:");
                string option = Console.ReadLine().ToUpper();


                if (option == "Y")
                {
                    user.Balance -= user.CashAvailability;
                    user.TransactionLimit--;
                    DateTime time = DateTime.Now;
                    user.Transactions.Add($"Transaction confirmed at {time}, Current Balance: {user.Balance}");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("TRANSACTION COMPLETED");
                    Console.WriteLine($"New Balance: {user.Balance}");
                    Console.WriteLine($"Number of transactions available: {user.TransactionLimit}");
                    Console.WriteLine("-----------------------------------------------------");

                    ReturnToMainMenu(user);


                }
                else if (option == "N")
                {
                    MainMenuStartUp(user);
                }
            }
            else if(user.CashAvailability == 0)
            {
                Console.WriteLine("You have reached your cash withdrawl limit for today");
                ReturnToMainMenu(user);
            }
            else
            {
                Console.WriteLine("You do not have sufficent funds to withdrawl");
                ReturnToMainMenu(user);
            }
        }

        private static void PreviousTransactions(User user)
        {
            Console.WriteLine();
            Console.WriteLine("Previous Transactions are as follows:");
            foreach(var transaction in user.Transactions)
            {
                Console.WriteLine(transaction.ToString());
            }
            ReturnToMainMenu(user);
        }

        private static void CashAvailability(User user)
        {
            Console.WriteLine();
            Console.WriteLine($"Your current cash availability for today is £{user.CashAvailability}");
            Console.WriteLine($"You still can make {user.TransactionLimit} transactions today");
            ReturnToMainMenu(user);
        }

        public static void ViewBalance(User user)
        {
            Console.WriteLine();
            Console.WriteLine($"Your current balance is: £{user.Balance}");
            ReturnToMainMenu(user);

        }

        public static void ReturnToMainMenu(User user)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Press 0 to return to the Main Menu or press 9 to exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 0:
                    MainMenuStartUp(user);
                    break;
                case 9:
                    return;
                default:
                    Console.WriteLine("Please enter a valid number");
                    break;
            }
        }
    }
}
