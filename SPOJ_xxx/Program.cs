namespace SPOJ_xxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int numberOfSum = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int i = 0; i < numberOfSum; i++)
                {
                    string[] line = Console.ReadLine().Split();
                    int a = int.Parse(line[0]);
                    int b = int.Parse(line[1]);
                    sum = a + b;
                    Console.WriteLine(sum);
                }


            }
        }
    }
}
    }
}