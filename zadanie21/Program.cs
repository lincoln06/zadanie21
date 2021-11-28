using System;

namespace zadanie21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napisz coś\n");
            string s = Console.ReadLine();
            Console.WriteLine();
            foreach(char znak in s)
            {
                Console.Write($"{znak}\t");
                if(Char.IsLower(znak))
                {
                    Console.Write("Mała litera\n");
                }
                else
                {
                    if(Char.IsUpper(znak))
                    {
                        Console.Write("Wielka litera\n");
                    }
                    else
                    {
                        if(Char.IsNumber(znak))
                        {
                            Console.Write("Liczba\n");
                        }
                        else
                        {
                            if(Char.IsPunctuation(znak))
                            {
                                Console.Write("Znak interpunkcyjny\n");
                            }
                            else
                            {
                                if(Char.IsWhiteSpace(znak))
                                {
                                    Console.Write("Biały znak\n");
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
