using System;


namespace ATM_BasicApp
{
    internal class Start
    {
        

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
                    var result = User.users.Find(i => i.CardNumber == cardNumber);
                    MainMenu.MainMenuStartUp(result);
                }


            }

        }

        public static bool CardNumCheck(string cardNum)
        {
            var result = User.users.Find(i => i.CardNumber == cardNum);
            if (result != null)
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
            var result = User.users.Find(i => i.Pin == pin);
            if(result != null)
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

