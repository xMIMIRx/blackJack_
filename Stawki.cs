using System;
using System.Collections.Generic;
using System.Text;

namespace blackJack
{
    class Stawki
    {
        public int portfel { get; set; }
        public static int stawki(int portfel)
        {
            Console.Write("Za ile grasz? (" + portfel + "): ");

            string wartosc = Console.ReadLine();
            int stawka;
            int q = 1;
            bool czyInt = int.TryParse(wartosc, out q);

            if (czyInt)
            {
                stawka = Convert.ToInt32(wartosc);
                if (stawka > portfel || stawka <= 0)
                {
                    return stawki(portfel);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    return stawka;
                }
            }
            else
            {
                return stawki(portfel);
            }
        }
    }
}
