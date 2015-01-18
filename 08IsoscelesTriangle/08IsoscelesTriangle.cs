using System;

namespace IsoscelesTriangle

        //Problem 8. Isosceles Triangle
//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

        //     ©

        //    © ©

        //   ©   ©

        //  © © © ©

        //Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding 
//to UTF-8 and assign a Unicode-friendly font in the console.
//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you
//put to fix it.
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            char copyrightSymbol = '\u00A9';
            string symbol = copyrightSymbol.ToString();
            string twoSymbols = (symbol + " " + symbol);
            string threeSymbols = (symbol + "   " + symbol);
            string fourSymbols = (symbol + " " + symbol + " " + symbol + " " + symbol);

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("     {0}\n\n    {1}\n\n   {2}\n\n  {3}\n",
                               symbol, twoSymbols, threeSymbols, fourSymbols);
        }
    }
}