using System;

namespace BankAccountData

    //Problem 11. Bank Account Data
    //A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
    //bank name, IBAN, 3 credit card numbers associated with the account.
    //Declare the variables needed to keep the information for a single bank account using the appropriate data types 
    //and descriptive names.

{
    class BankAccountData
    {
        static void Main()
        {
            string holderName = "Georgi Dimitrov Rizov";
            decimal balance = 941.34m;
            string bankName ="DSK";
            string iban = "BG28STSA9312321383430";
            ulong firstCreditCard = 4444444444444444;
            ulong secondCreditCard = 5555555555555555;
            ulong thirdCreditCard = 6666666666666666;

            Console.WriteLine(" Holder name: {0}\n Balance: {1} BGN\n Bank Name: {2}\n IBAN: {3}\n First Credit Card: {4}\n Second Credit Card: {5}\n Third Credit Card: {6}\n", 
                                holderName, balance, bankName, iban, firstCreditCard, secondCreditCard, thirdCreditCard);
                                

        }
    }
}
