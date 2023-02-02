using System;
using System.Collections.Generic;
using System.Text;

namespace blackJack
{
    class Pomoc
    {
        public static void pomoc()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1) Podaj swoją stawkę");
            Console.WriteLine("2) Masz swoje 2 karty, jak i krupier (jedna jawna, druga nie)");
            Console.WriteLine("3) Wybierasz co robisz używając klawiszy [G] [B] [R]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" * Uzywając PLAY [G]: \n" +
                "   - możasz dobierać karty, a twoim cele jest dobranie jak najbliżej 21 i nie możesz jej przekroczyć, \n" +
                "   - jeśli przekroczysz 21, wtedy zaczyna dobierać krupier i musi dobrać karty tak długo aż będzie mieć 17, \n" +
                "   - w przeciwnym razie ty wygrywasz\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" * Uzywając DOUBLE [B]: \n" +
                "   - podwajasz stawkę, ale musisz dobrać jedną kartę i nie możesz dobierać dalej\n" +
                "   - i tak jak w przypadku PLAY wygrywasz mając najbliżej 21 lub zaczyna grać krupier\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" * Uzywając STAND [R]: \n" +
                "   - przestajesz dobierać karty i zaczyna krupier\n");
            Console.WriteLine("=============================================================");
            Console.WriteLine();

        }
    }
}
