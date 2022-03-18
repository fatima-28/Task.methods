using System;

namespace ftm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2.Bir string qebul edib, onu sözbəsöz reverse edən
            //    metod yazın. Məs: input - "Ibrahim yaxşı oğlandı"
            //    , output - "miharbİ ışxay ıdnalğo"
            Reverse("hello guys");
        }
        static void Reverse(string text)
        {
            string newword = string.Empty;
            string[] space = text.Split(' ');
            for (int i = 0; i < space.Length; i++)
            {
                Console.WriteLine(space[i]);
                newword += space[i];
                for (int j = newword.Length - 1; j < newword.Length; j--)
                {
                    Console.WriteLine(newword[j]);
                }
            }
        }

    }
}