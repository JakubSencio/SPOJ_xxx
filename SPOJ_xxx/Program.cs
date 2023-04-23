using System.Collections.Concurrent;
using System.Security.Cryptography;

namespace SPOJ_xxx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            string firstWord = parts[0];
            string secondWord = parts[1];

            int lengthFirst = firstWord.Length;

            int lengthSecond = secondWord.Length;


            if(lengthFirst > lengthSecond || lengthFirst == lengthSecond)
            {
                for (int i = 0; i < lengthSecond; i++)
                {
                    Console.Write(firstWord[i]);
                    Console.Write(secondWord[i]);
                }
            }
            else
            {
                for (int i = 0; i < lengthFirst; i++)
                {
                    Console.Write(firstWord[i]);
                    Console.Write(secondWord[i]);
                }
            }

        }
    }
}