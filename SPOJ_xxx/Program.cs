namespace SPOJ_xxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine().ToUpper();
            int wordLength = inputWord.Length;

            for (int i = 0; i < wordLength; i++)
            {
                char currentLetter = inputWord[i];
                int repetitions = 1;

                for (int j = i + 1; j < wordLength; j++)
                {
                    if (inputWord[j] == currentLetter)
                    {
                        repetitions++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (repetitions >= 3)
                {
                    Console.Write($"{repetitions}{currentLetter}");
                    i += repetitions - 1;
                }
                else
                {
                    Console.Write($"{currentLetter}");
                }
            }
        }


    }
}
}