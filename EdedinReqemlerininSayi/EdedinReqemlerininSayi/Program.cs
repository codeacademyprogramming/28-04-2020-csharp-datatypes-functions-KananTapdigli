using System;

namespace EdedinReqemlerininSayi
{
    class Program
    {
        static void Main()
        {
            int daxilEdilenEded;
            int reqemlerininSayi = 0;

            Console.Write("Ededi Daxil Edin: ");
            daxilEdilenEded = Convert.ToInt32(Console.ReadLine());

            if (daxilEdilenEded < 0)
            {
                daxilEdilenEded = daxilEdilenEded * -1;
            }

            while (daxilEdilenEded > 0)
            {
                daxilEdilenEded = daxilEdilenEded / 10;
                reqemlerininSayi++;
            }

            Console.WriteLine("Daxil Edilmis Ededin Reqemlerinin Sayi: " + reqemlerininSayi);
        }
    }
}
