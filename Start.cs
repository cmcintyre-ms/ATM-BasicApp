using System;


namespace ATM_BasicApp
{
    internal class Start
    {
        public static string validCardNumber = "5698741032653025";
        public static string validPin = "1234";

        public static void StartUp()
        {
            Console.WriteLine("Welcome to MS Bank");
            Console.WriteLine("------------------");
            Console.WriteLine();

            Console.WriteLine("Please enter your card details: ");
            string cardNumber = Console.ReadLine();
            Console.WriteLine();

            if (CardNumCheck(cardNumber) == false)
            {
                Console.WriteLine("Please enter a valid Card Number");
            }
            else
            {
                Console.WriteLine("Please enter your pin: ");
                string pin = Console.ReadLine();

                if (PinNumCheck(pin) == false)
                {
                    Console.WriteLine("Please enter a vaild pin number");
                }
                else
                {
                    MainMenu.MainMenuStartUp();
                }


            }

        }

        public static bool CardNumCheck(string cardNum)
        {
            if (cardNum == validCardNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool PinNumCheck(string pin)
        {
            if(pin == validPin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public static int CountCardNumber(string cardNumber)
        //{
        //    int i = 0;
        //    int digitCount = 0;
        //    int cardLength = cardNumber.Length;

        //    while (i < cardLength)
        //    {
        //        if (cardNumber[i] >= '0' && cardNumber[i] <= '9')
        //        {
        //            digitCount++;
        //        }
        //        i++;
        //    }
        //    return digitCount;

        //}

        //public static int CountPinNumber(string pin)
        //{
        //    int i = 0;
        //    int digitCount = 0;
        //    int pinLength = pin.Length;

        //    while (i < pinLength)
        //    {
        //        if (pin[i] >= '0' && pin[i] <= '9')
        //        {
        //            digitCount++;
        //        }
        //        i++;
        //    }
        //    return digitCount;
        //}


    }
}

