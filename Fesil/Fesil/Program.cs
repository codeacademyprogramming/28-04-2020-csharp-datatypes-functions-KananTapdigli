using System;

namespace Fesil
{
    class Program
    {
        static void Main()
        {

            Console.Write("Ayin Nomresini Daxil Edin: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            if (monthNumber > 0 && monthNumber <= 12)
            {
                if (monthNumber >= 3 && monthNumber <= 5)
                {
                    Console.WriteLine(monthNumber + ": " + "Yaz Ayidir");
                }

                else if (monthNumber >= 6 && monthNumber <= 8)
                {
                    Console.WriteLine(monthNumber + ": " + "Yay Ayidir");
                }

                else if (monthNumber >= 9 && monthNumber <= 11)
                {
                    Console.WriteLine(monthNumber + ": " + "Payiz Ayidir");
                }

                else
                {
                    Console.WriteLine(monthNumber + ": " + "Qis Ayidir");
                }
            }

            else
            {
                Console.WriteLine(monthNumber + ": " + "Daxil Edilen Nomreye Uygun Ay Yoxdur");
            }





        }
    }
}
