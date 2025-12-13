namespace WeatherSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of days to simulate: ");
            int days;
            while(!int.TryParse(Console.ReadLine(), out days) || days <= 0)
            {
                Console.WriteLine("number of days must be numeric and posible!");
                Console.Write("Enter again: ");
            }

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();
            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                int count;
                if (temperature[i] < 10)
                {
                    count = 3;
                } else if (temperature[i] < 20)
                {
                    count = 1;
                } else if (temperature[i] < 30)
                {
                    count = 2;
                } else
                {
                    count = 0;
                }
                    weatherConditions[i] = conditions[count];
            }

            //temperature.Max();

            //double averageTemp = CalculateAverage(temperature);
            for (int i = 1; i < days; i++)
            {
                Console.WriteLine($"Day {i}: {temperature[i]} Celcius, {weatherConditions[i]}");
            }

            Console.WriteLine($"Average temperature is: {CalculateAverage(temperature)}");
            Console.WriteLine($"The max temp was: {temperature.Max()}");
            Console.WriteLine($"The min temp was: {MinTemperature(temperature)}");
            Console.WriteLine($"Most common condition is: {CountMostCommonCondition(weatherConditions)}");

            Console.ReadKey();
        }

        static string CountMostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }

            return mostCommon;
        }

        static double CalculateAverage(int[] temperature)
        {
            double sum = 0;

            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }

            //foreach(int i in temperature)
            //{
            //    sum += i;
            //}

            // Length is a built in function that 
            //return the length of array
            double average = sum / temperature.Length;

            return average; 
        }

        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];

            foreach(int temp in temperature)
            {
                if (temp < min)
                {
                    min = temp;
                }
            }
            return min;
        }
    }
}
