using System;
using System.Text;

namespace PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main()
        {

            for (int i = 0; i <= 255; i++)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine((char)i);
            }
        }
    }
}
