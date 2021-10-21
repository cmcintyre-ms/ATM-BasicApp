﻿using System;


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

            if (CountCardNumber(cardNumber) != 16)
            {
                Console.WriteLine("Please enter a valid Card Number");
            }
            else
            {
                Console.WriteLine("Please enter your pin: ");
                string pin = Console.ReadLine();

                if (CountPinNumber(pin) != 4)
                {
                    Console.WriteLine("Please enter a vaild pin number");
                }
                else
                {
                    MainMenu.MainMenuStartUp();
                }


            }

        }

        public static int CountCardNumber(string cardNumber)
        {
            int i = 0;
            int digitCount = 0;
            int cardLength = cardNumber.Length;

            while (i < cardLength)
            {
                if (cardNumber[i] >= '0' && cardNumber[i] <= '9')
                {
                    digitCount++;
                }
                i++;
            }
            return digitCount;

        }

        public static int CountPinNumber(string pin)
        {
            int i = 0;
            int digitCount = 0;
            int pinLength = pin.Length;

            while (i < pinLength)
            {
                if (pin[i] >= '0' && pin[i] <= '9')
                {
                    digitCount++;
                }
                i++;
            }
            return digitCount;
        }


    }
}
