namespace SPOJ_xxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTests = int.Parse(Console.ReadLine());
            int[] tab = new int[numberOfTests];

            // Wczytanie liczb do tablicy
            for (int i = 0; i < numberOfTests; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                tab[i] = inputNumber;
            }

            // Sortowanie tablicy w kolejności od największej do najmniejszej
            Array.Sort(tab);
            Array.Reverse(tab);

            // Wyświetlenie posortowanej tablicy
            foreach (int number in tab)
            {
                Console.Write($"{number} ");
            }
        }
    }
}