namespace assignment_5._2._2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("lets count to ten");
            CountToTen(1);
            Console.WriteLine();
            Console.WriteLine("Counting down from 10");
            Countdown(10);

        }


        static void CountToTen(int n)
        {
            if (n > 10)
            {
                return;
            }
            Console.Write(n + " ");


            CountToTen(n + 1);
        }


        static void Countdown(int n)
        {
            if (n < 0)
            {
                return;
            }
            Console.Write(n + " ");
            Countdown(n - 1);
        }
    }
}

