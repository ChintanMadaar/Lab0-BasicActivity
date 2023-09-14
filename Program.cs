namespace BasicActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int low;
            int high;
            Console.Write("Enter a low number: ");
            low = int.Parse(Console.ReadLine());

            while (low < 0)
            {
                Console.WriteLine("Low number must be positive");
                Console.WriteLine("Enter a low number: ");
                low = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter a high number: ");
            high = int.Parse(Console.ReadLine());
            while (high < low)
            {
                Console.WriteLine("High number must be greater than low ");
                Console.Write("Enter a high number: ");
                high = int.Parse(Console.ReadLine());
            }
            int difference = high - low;
            Console.WriteLine("The difference between low and high is " + difference);
            int[] numbers = new int[difference];
            for (int n = low, i = 0; n <= high && i < difference; n++, i++)
            {
                numbers[i] = n;
            }
            StreamWriter streamWriter = File.CreateText("numbers.txt");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                streamWriter.WriteLine(numbers[i]);
            }
            streamWriter.Close();
            Console.WriteLine("Wrote to file: numbers.txt");
            foreach (int n in numbers)
            {
                if (IsPrime(n))
                {
                    Console.WriteLine($"{n} is a prime number.");
                }
            }
        }
        static bool IsPrime(int n)
        {
            for (int denominator = n - 1; denominator > 1; denominator--)
            {
                int remainder = n % denominator;
                if (remainder == 0)
                    return false;
            }
            return true;
        }
    }
}