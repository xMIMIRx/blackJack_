using System;
using System.Collections.Generic;
using System.Text;

namespace blackJack
{
    class Tasowanie
    {
        public static int[] tasowanieGracz()
        {
            Random random = new Random();
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11};
            int[] kartyGracza = { tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)] };

            return kartyGracza;
        }

        public static int[] tasowanieKrupier()
        {
            Random random = new Random();
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] kartyKrupiera = { tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)], tab[random.Next(tab.Length)] };

            return kartyKrupiera;
        }
    }
}
