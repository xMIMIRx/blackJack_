using System;

namespace blackJack
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tytul.tytul();

            int portfel = 1000;
            if(Console.ReadLine() == "help")
            {
                Pomoc.pomoc();
            }

            do
            {
                int[] kartyGracza = Tasowanie.tasowanieGracz();
                int[] kartyKrupiera = Tasowanie.tasowanieKrupier();


                if (portfel <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("Masz za mało pieniędzy!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                }


                Console.ForegroundColor = ConsoleColor.Cyan;
                int stawka = 0;
                Console.WriteLine(stawka = Stawki.stawki(portfel));


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Twoje kart to: " + kartyGracza[0] + " | " + kartyGracza[1]);
                Console.WriteLine("");


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Kart krupiera to: " + kartyKrupiera[0] + " | *zakryta*");
                Console.WriteLine(""); Console.WriteLine("");


                Console.ForegroundColor = ConsoleColor.Cyan; 
                Console.WriteLine("Co Robisz? Kliknij: [G] [B] [R]");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("[ PLAY - G ] ");
                Console.ForegroundColor = ConsoleColor.Blue; Console.Write("[ DOUBLE - B ] ");
                Console.ForegroundColor = ConsoleColor.Red; Console.Write("[ STAND - R ] ");
                Console.WriteLine(); Console.WriteLine();


                Console.ForegroundColor = ConsoleColor.Cyan;
                Gra.gra(ref portfel, stawka, kartyGracza, kartyKrupiera);
                Console.WriteLine();


            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}