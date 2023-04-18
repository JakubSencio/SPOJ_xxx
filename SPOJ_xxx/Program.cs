namespace SPOJ_xxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int howManyTimes = int.Parse(Console.ReadLine());
            for(int j = 0; j < howManyTimes; j++)
            {
                string input = Console.ReadLine();
                string[] inputNumbers = input.Split(' ');
                int[] tab = new int[inputNumbers.Length];

                for (int i = 0; i < inputNumbers.Length; i++)
                {
                    tab[i] = int.Parse(inputNumbers[i]);
                }

                Array.Sort(tab);
                Array.Reverse(tab);

                foreach (int number in tab)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine(" ");
            }

        }
    }
}