namespace ListManipulate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>() { 15, 3, 20, 10, 8, 17, 25, 12};

            Console.WriteLine("Result - Unsorted List: ");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //sort the list -> ascending sort
            numbers.Sort();

            Console.WriteLine("Result - Sorted List: ");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Predicate<int> isMatched = x => x >= 15;
            List<int> matchedNumbers = numbers.FindAll(isMatched);

            Console.WriteLine("Result - Matched List (>= 15): ");
            foreach (int i in matchedNumbers)
            {
                Console.WriteLine(i);
            }

            //return the bool that is the list has any element > 20
            bool hasNumMatched = numbers.Any(x => x > 20);
            if (hasNumMatched)
            {
                Console.WriteLine("There are > 20 elements in the list!");
            }
            else
            {
                Console.WriteLine("There aren't > 20 elements int the list");
            }

                Console.ReadKey();
        }
    }
}
