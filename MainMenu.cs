using System;
using System.Collections.Generic;


namespace ATM_BasicApp
{
    
    public class MainMenu
    {
        public static double balance = 10000.00;
        public static double cashAvailability = 1000.00;
        public static int transactionLimit = 10;
        public static List<string> transactions = new List<string>();

        public static void MainMenuStartUp()
        {
            Console.Clear();
            Console.WriteLine("Welcome Cheryl");
            Console.WriteLine("--------------");
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
                        ViewBalance();
                        break;
                    case 2:
                        CashAvailability();
                        break;
                    case 3:
                        PreviousTransactions();
                        break;
                    case 4:
                        CashWithdrawl();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 - 4 or 0 to exit");
                        break;
                }
            

        }

        private static void CashWithdrawl()
        {
            Console.WriteLine();
            Console.WriteLine($"Current Balance: £{balance}");
            Console.WriteLine($"Number of transactions available: {transactionLimit}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Please confirm you would like to withdraw £{cashAvailability} from your account:");
            Console.WriteLine("Press Y to confirm or N to return to the Main Menu:");
            string option = Console.ReadLine().ToUpper();

            if(option == "Y")
            {
                balance -= cashAvailability;
                transactionLimit --;
                DateTime time = DateTime.Now;
                transactions.Add($"Transaction confirmed at {time}, Current Balance: {balance}");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("TRANSACTION COMPLETED");
                Console.WriteLine($"New Balance: {balance}");
                Console.WriteLine($"Number of transactions available: {transactionLimit}");
                Console.WriteLine("-----------------------------------------------------");

                Console.WriteLine("Press 0 to return to the Main Menu or press 9 to exit");
                int menuOption = Convert.ToInt32(Console.ReadLine());

                switch (menuOption)
                {
                    case 0:
                        MainMenuStartUp();
                        break;
                    case 9:
                        return;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }


            }
            else if (option == "N")
            {
                MainMenuStartUp();
            }
        }

        private static void PreviousTransactions()
        {
            Console.WriteLine();
            Console.WriteLine("Previous Transactions are as follows:");
            foreach(var transaction in transactions)
            {
                Console.WriteLine(transaction.ToString());
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Press 0 to return to the Main Menu or press 9 to exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 0:
                    MainMenuStartUp();
                    break;
                case 9:
                    return;
                default:
                    Console.WriteLine("Please enter a valid number");
                    break;
            }
        }

        private static void CashAvailability()
        {
            Console.WriteLine();
            Console.WriteLine($"Your current cash availability for today is £{cashAvailability}");
            Console.WriteLine($"You still can make {transactionLimit} transactions today");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Press 0 to return to the Main Menu or press 9 to exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 0:
                    MainMenuStartUp();
                    break;
                case 9:
                    return;
                default:
                    Console.WriteLine("Please enter a valid number");
                    break;
            }
        }

        public static void ViewBalance()
        {
            Console.WriteLine();
            Console.WriteLine($"Your current balance is: £{balance}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Press 0 to return to the Main Menu or press 9 to exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 0:
                    MainMenuStartUp();
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
