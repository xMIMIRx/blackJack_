using System;
using System.Collections.Generic;
using System.Text;

namespace blackJack
{
    class Warunek
    {
        public static void warunekPlay(ref int portfel, int stawka, int[] kG, int[] kK, int sumaG, int sumaK)
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.G:
                    sumaG = sumaG + kG[2];
                    Warunek.text(3, "gracz", kK, kG);
                    if (sumaG > 21)
                    {
                        Warunek.text(3, "krupier", kK, kG);
                        portfel = portfel - stawka;
                        Warunek.wygrana("lose", stawka, portfel);
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    }
                    
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.G:
                            sumaG = sumaG + kG[2] + kG[3];
                            Warunek.text(4, "gracz", kK, kG);
                            if (sumaG > 21)
                            {
                                Warunek.text(4, "krupier", kK, kG);
                                portfel = portfel - stawka;
                                Warunek.wygrana("lose", stawka, portfel);
                                Console.ForegroundColor = ConsoleColor.Black;
                                break;
                            }

                            switch (Console.ReadKey().Key)
                            {
                                case ConsoleKey.G:
                                    sumaG = sumaG + kG[2] + kG[3] + kG[4];
                                    Warunek.text(5, "gracz", kK, kG);
                                    if (sumaG > 21)
                                    {
                                        Warunek.text(5, "krupier", kK, kG);
                                        portfel = portfel - stawka;
                                        Warunek.wygrana("lose", stawka, portfel);
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        break;
                                    }

                                    switch (Console.ReadKey().Key)
                                    {
                                        case ConsoleKey.G:
                                            sumaG = sumaG + kG[2] + kG[3] + kG[4] + kG[5];
                                            Warunek.text(6, "gracz", kK, kG);
                                            if (sumaG > 21)
                                            {
                                                Warunek.text(6, "krupier", kK, kG);
                                                portfel = portfel - stawka;
                                                Warunek.wygrana("lose", stawka, portfel);
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                break;
                                            }

                                            break;

                                        case ConsoleKey.R:
                                            sumaG = sumaG + kG[2] + kG[3] + kG[4] + kG[5];
                                            Warunek.text(6, "krupier", kK, kG);
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            warunekStand(ref portfel, stawka, kG, kK, sumaG);
                                            break;

                                        default:
                                            warunekPlay(ref portfel, stawka, kG, kK, sumaG, sumaK);
                                            break;
                                    }
                                    break;

                                case ConsoleKey.R:
                                    sumaG = sumaG + kG[2] + kG[3] + kG[4];
                                    Warunek.text(5, "krupier", kK, kG);
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    warunekStand(ref portfel, stawka, kG, kK, sumaG);
                                    break;

                                default:
                                    warunekPlay(ref portfel, stawka, kG, kK, sumaG, sumaK);
                                    break;
                            }
                            break;

                        case ConsoleKey.R:
                            sumaG = sumaG + kG[2] + kG[3];
                            Warunek.text(4, "krupier", kK, kG);
                            Console.ForegroundColor = ConsoleColor.Black;
                            warunekStand(ref portfel, stawka, kG, kK, sumaG);
                            break;

                        case ConsoleKey.Enter:
                            break;

                        default:
                            warunekPlay(ref portfel, stawka, kG, kK, sumaG, sumaK);
                            break;
                    }
                    break;

                case ConsoleKey.R:
                    sumaG = sumaG + kG[2];
                    Warunek.text(3, "krupier", kK, kG);
                    warunekStand(ref portfel, stawka, kG, kK, sumaG);
                    break;

                default:
                    warunekPlay(ref portfel, stawka, kG, kK, sumaG, sumaK);
                    break;
            }
        }



        public static void regulaPlay(ref int portfel, int stawka, int[] kG, int[] kK, int sumaG, int sumaK) 
        {
            if (sumaG == 21)
            {
                Warunek.text(3, "krupier", kK, kG);
                Warunek.wygrana("win", stawka, portfel);
            }
            else if (sumaG > 21)
            {
                Warunek.text(3, "krupier", kK, kG);
                Warunek.wygrana("lose", stawka, portfel);
            }
            else if (sumaG < 21 && sumaK < 21)
            {
                if (21 - sumaG < 21 - sumaK)
                {
                    Warunek.text(3, "krupier", kK, kG);
                    Warunek.wygrana("win", stawka, portfel);
                }
                else if (21 - sumaG > 21 - sumaK)
                {
                    Warunek.text(3, "krupier", kK, kG);
                    Warunek.wygrana("lose", stawka, portfel);
                }
            }
            else
            {
                Warunek.text(3, "krupier", kK, kG);
                Warunek.wygrana("win", stawka, portfel);
            }
        }


        
        public static void wygrana(String co, int stawka, int portfel)
        {
            if (co == "win")
            {
                portfel = portfel + stawka;
                Console.WriteLine("Wygrałeś: " + stawka + ". Masz teraz: " + portfel);
            }
            else if (co == "lose")
            {
                portfel = portfel - stawka;
                Console.WriteLine("Przegrałeś: " + stawka + ". Masz teraz: " + portfel);
            }

        }
        public static void text(int liczba, String kto, int[] kK, int[] kG)
        {
            if (kto == "krupier")
            {
                if (liczba == 2)
                {
                    Console.WriteLine("Karty krupiera to: " + kK[0] + " | " + kK[1]);
                }
                else if (liczba == 3)
                {
                    Console.WriteLine("Karty krupiera to: " + kK[0] + " | " + kK[1] + " | " + kK[2]);
                }
                else if (liczba == 4)
                {
                    Console.WriteLine("Karty krupiera to: " + kK[0] + " | " + kK[1] + " | " + kK[2] + " | " + kK[3]);
                }
                else if (liczba == 5)
                {
                    Console.WriteLine("Karty krupiera to: " + kK[0] + " | " + kK[1] + " | " + kK[2] + " | " + kK[3] + " | " + kK[4]);
                }
                else if (liczba == 6)
                {
                    Console.WriteLine("Karty krupiera to: " + kK[0] + " | " + kK[1] + " | " + kK[2] + " | " + kK[3] + " | " + kK[4] + " | " + kK[5]);
                }
                else if (liczba == 7)
                {
                    Console.WriteLine("Karty krupiera to: " + kK[0] + " | " + kK[1] + " | " + kK[2] + " | " + kK[3] + " | " + kK[4] + " | " + kK[5] + " | " + kK[6]);
                }
            }
            else if(kto == "gracz")
            {
                if (liczba == 3)
                {
                    Console.WriteLine("Twoje kart to: " + kG[0] + " | " + kG[1] + " | " + kG[2]);
                }
                else if (liczba == 4)
                {
                    Console.WriteLine("Twoje kart to: " + kG[0] + " | " + kG[1] + " | " + kG[2] + " | " + kG[3]);
                }
                else if (liczba == 5)
                {
                    Console.WriteLine("Twoje kart to: " + kG[0] + " | " + kG[1] + " | " + kG[2] + " | " + kG[3] + " | " + kG[4]);
                }
                else if (liczba == 6)
                {
                    Console.WriteLine("Twoje kart to: " + kG[0] + " | " + kG[1] + " | " + kG[2] + " | " + kG[3] + " | " + kG[4] + " | " + kG[5]);
                }
            }
        }



        // NIC NIE ROBI ALE MOŻE KIEDY INDZIEJ
        /* 
        public static void play(ref int portfel, int stawka, int[] kG, int[] kK, int sumaG) 
        {
            warunekPlay(ref portfel, stawka, kG, kK, sumaG);
        }


        public static void stand(ref int portfel, int stawka, int[] kG, int[] kK, int sumaG)
        {
            warunekPlay(ref portfel, stawka, kG, kK, sumaG);
        }
        */





        public static void warunekDouble(ref int portfel, int stawka, int[] kG, int[] kK, int sumaG)
        {
            stawka = stawka * 2;
            int sumaK1 = kK[0] + kK[1] + kK[2];
            int sumaK2 = kK[0] + kK[1] + kK[2] + kK[3];
            int sumaK3 = kK[0] + kK[1] + kK[2] + kK[3] + kK[4];
            int sumaK4 = kK[0] + kK[1] + kK[2] + kK[3] + kK[4] + kK[5];

            if (sumaG > 21)
            {
                Warunek.text(3, "krupier", kK, kG);
                Warunek.wygrana("lose", stawka, portfel);
            }
            else if (sumaG == 21 || sumaK1 > 21)
            {
                Warunek.text(3, "krupier", kK, kG);
                Warunek.wygrana("win", stawka, portfel);
            }
            else if (sumaG < 21)
            {
                if (sumaK1 >= 17 && sumaK1 <= 21)
                {
                    if (21 - sumaG < 21 - sumaK1)
                    {
                        Warunek.text(3, "krupier", kK, kG);
                        Warunek.wygrana("win", stawka, portfel);
                    }
                    else
                    {
                        Warunek.text(3, "krupier", kK, kG);
                        Warunek.wygrana("lose", stawka, portfel);
                    }
                }
                else if (sumaK2 >= 17 && sumaK2 <= 21)
                {
                    if (21 - sumaG < 21 - sumaK1)
                    {
                        Warunek.text(4, "krupier", kK, kG);
                        Warunek.wygrana("win", stawka, portfel);
                    }
                    else
                    {
                        Warunek.text(4, "krupier", kK, kG);
                        Warunek.wygrana("lose", stawka, portfel);
                    }
                }
                else if (sumaK3 >= 17 && sumaK3 <= 21)
                {
                    if (21 - sumaG < 21 - sumaK1)
                    {
                        Warunek.text(5, "krupier", kK, kG);
                        Warunek.wygrana("win", stawka, portfel);
                    }
                    else
                    {
                        Warunek.text(5, "krupier", kK, kG);
                        Warunek.wygrana("lose", stawka, portfel);
                    }
                }
                else if (sumaK4 >= 17 && sumaK4 <= 21)
                {
                    if (21 - sumaG < 21 - sumaK1)
                    {
                        Warunek.text(6, "krupier", kK, kG);
                        Warunek.wygrana("win", stawka, portfel);
                    }
                    else
                    {
                        Warunek.text(6, "krupier", kK, kG);
                        Warunek.wygrana("lose", stawka, portfel);
                    }
                }
                else
                {
                    Warunek.text(7, "krupier", kK, kG);
                    Warunek.wygrana("lose", stawka, portfel);
                }
            }
        }






        public static void warunekStand(ref int portfel, int stawka, int[] kG, int[] kK, int sumaG)
        {
            int sumaK1 = kK[0] + kK[1];
            int sumaK2 = kK[0] + kK[1] + kK[2];
            int sumaK3 = kK[0] + kK[1] + kK[2] + kK[3];
            int sumaK4 = kK[0] + kK[1] + kK[2] + kK[3] + kK[4];
            int sumaK5 = kK[0] + kK[1] + kK[2] + kK[3] + kK[4] + kK[5];

            if (sumaG > 21)
            {
                Warunek.text(2, "krupier", kK, kG);
                Warunek.wygrana("lose", stawka, portfel);
            }
            else if (sumaG == 21 || sumaK1 > 21)
            {
                Warunek.text(2, "krupier", kK, kG);
                Warunek.wygrana("win", stawka, portfel);
            }
            else if (sumaG < 21)
            {
                if (sumaK1 >= 17 && sumaK1 <= 21)
                {
                    if (21 - sumaG < 21 - sumaK1)
                    {
                        Warunek.text(2, "krupier", kK, kG);
                        Warunek.wygrana("win", stawka, portfel);
                    }
                    else
                    {
                        Warunek.text(2, "krupier", kK, kG);
                        Warunek.wygrana("lose", stawka, portfel);
                    }
                }
                else if (sumaK2 >= 17 && sumaK2 <= 21)
                {
                    if (21 - sumaG < 21 - sumaK2)
                    {
                        Warunek.text(3, "krupier", kK, kG);
                        Warunek.wygrana("win", stawka, portfel);
                    }
                    else
                    {
                        Warunek.text(3, "krupier", kK, kG);
                        Warunek.wygrana("lose", stawka, portfel);
                    }
                }
                else if (sumaK3 >= 17 && sumaK3 <= 21)
                {
                    if (21 - sumaG < 21 - sumaK3)
                    {
                        Warunek.text(4, "krupier", kK, kG);
                        Warunek.wygrana("win", stawka, portfel);
                    }
                    else
                    {
                        Warunek.text(4, "krupier", kK, kG);
                        Warunek.wygrana("lose", stawka, portfel);
                    }
                }
                else if (sumaK4 >= 17 && sumaK4 <= 21)
                {
                    if (21 - sumaG < 21 - sumaK4)
                    {
                        Warunek.text(5, "krupier", kK, kG);
                        Warunek.wygrana("win", stawka, portfel);
                    }
                    else
                    {
                        Warunek.text(5, "krupier", kK, kG);
                        Warunek.wygrana("lose", stawka, portfel);
                    }
                }
                else if (sumaK5 >= 17 && sumaK5 <= 21)
                {
                    if (21 - sumaG < 21 - sumaK5)
                    {
                        Warunek.text(6, "krupier", kK, kG);
                        Warunek.wygrana("win", stawka, portfel);
                    }
                    else
                    {
                        Warunek.text(6, "krupier", kK, kG);
                        Warunek.wygrana("lose", stawka, portfel);
                    }
                }
                else
                {
                    Warunek.text(7, "krupier", kK, kG);
                    Warunek.wygrana("lose", stawka, portfel);
                }
            }
        }
    }
}
