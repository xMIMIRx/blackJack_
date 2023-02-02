using System;
using System.Collections.Generic;
using System.Text;

namespace blackJack
{
    class Gra
    {
        public int portfel { get; set; }
        public int stawka { get; set; }
        public int[] kG { get; set; }
        public int[] kK { get; set; }
        public static void gra(ref int portfel, int stawka, int[] kG, int[] kK)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            int sumaG;
            int sumaK;
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.G:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" ====== PLAY ====== ");
                    Console.WriteLine("Twoje kart to: " + kG[0] + " | " + kG[1]);

                    sumaG = kG[0] + kG[1];
                    sumaK = kK[0] + kK[1];
                    Warunek.warunekPlay(ref portfel, stawka, kG, kK, sumaG, sumaK);

                    break;

                case ConsoleKey.B:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" ====== DOUBLE ====== ");
                    Console.WriteLine("Twoje kart to: " + kG[0] + " | " + kG[1] + " | " + kG[2]);

                    sumaG = kG[0] + kG[1] + kG[2];
                    Warunek.warunekDouble(ref portfel, stawka, kG, kK, sumaG);

                    break;

                case ConsoleKey.R:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ====== STAND ====== ");
                    Console.WriteLine("Twoje kart to: " + kG[0] + " | " + kG[1]);

                    sumaG = kG[0] + kG[1];
                    Warunek.warunekStand(ref portfel, stawka, kG, kK, sumaG);

                    break;

                default:
                    gra(ref portfel, stawka, kG, kK);
                    break;
            }
        }
    }
}
