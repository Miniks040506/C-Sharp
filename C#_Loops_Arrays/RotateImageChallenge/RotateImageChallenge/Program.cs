namespace RotateImageChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Welcome, i will have you to rotate the image(2d array) with size n");

            Console.Write("Enter n: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("n must be numeric and positive. Please try again: ");
            }

            int[][] image = new int[n][];
            Console.WriteLine("Please enter the array: ");
            for (int i = 0; i < image.Length; i++)
            {
                image[i] = new int[n];
                string line = Console.ReadLine()!;
                string[] pieces = line.Split(' ');
                for (int j = 0; j < pieces.Length; j++)
                {
                    image[i][j] = int.Parse(pieces[j]);
                }
            }

            int length = image.Length;

            for (int i = 0; i < (length + 1) / 2; i++)
            {
                for (int j = 0; j < length / 2; j++)
                {
                    // temp = bottom left
                    int temp = image[n - 1 - j][i];

                    // bottom left = bottom right
                    image[n - 1 - j][i] = image[n - 1 - i][n - 1 - j];

                    // bottom right = top right
                    image[n - 1 - i][n - 1 - j] = image[j][n - 1 - i];

                    // top right = top left
                    image[j][n - 1 - i] = image[i][j];

                    // top left = bottom left
                    image[i][j] = temp;
                }
            }

            Console.WriteLine("\n----------- RESULT -----------");
            foreach (var item in image)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2 + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");

            Console.ReadKey();
        }
    }
}
