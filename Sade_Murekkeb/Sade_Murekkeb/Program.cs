using System;

namespace Sade_Murekkeb
{
    class Program
    {
        static void Main()
        {

            int daxilEdilenEded;
            int maxBolen;
            bool sade = true;


            Console.Write("Eded Daxil Edin : ");
            daxilEdilenEded = Convert.ToInt32(Console.ReadLine());


            if (daxilEdilenEded <= 1)
            {
                Console.WriteLine(daxilEdilenEded + ": " + "Hec birine aid deyil");
            }


            else
            {

                maxBolen = (daxilEdilenEded + 1) / 2;

                for (int i = 2; i < maxBolen; i++)
                {

                    if (daxilEdilenEded % i == 0)
                    {
                        sade = false;
                        break;
                    }

                    else
                    {
                        sade = true;
                    }

                }

                if (sade)
                {
                    Console.WriteLine(daxilEdilenEded + ": " + "Sadedir");
                }

                else
                {
                    Console.WriteLine(daxilEdilenEded + ": " + "Murekkebdir");
                }

            }
        }
    }
}
