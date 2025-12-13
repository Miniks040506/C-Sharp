namespace Arrays_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays and use for and foreach to traverse the array
            Console.WriteLine("     Arrays with for and foreach");
            Console.WriteLine("-------------------------------------");

            //declare array
            int[] myArray = new int[10];
            //int[] myArray = [1, 2, 3, 4, 5];
            //int[] myArray = { 1, 2, 3, 4, 5};
            //int[] myArray = new int[] { 1, 2, 3, 4, 5 };

            Random rd = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rd.Next(1, 101);
            }

            int index = 0;
            // use foreach to traverse all item in the array, list
            foreach (var item in myArray)
            {
                Console.WriteLine($"myArray[{index++}] = {item}");
            }

            string[] daysOfWeek = new string[] {"Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Saturday", "sunday" };

            Console.WriteLine("\n-------------------------------------\n");
            Thread.Sleep(500);
            foreach (var day in daysOfWeek)
            {
                Console.WriteLine("Today is " + day);
                Thread.Sleep(500);
            }

            //2D Array
            int[,] my2DArray = new int[3, 3];
            int[,] arr2 = new int[3, 3] { {1, 2, 3}, { 4, 5, 6 }, { 7, 8, 9 } };
            // [1] [2] [3]
            // [4] [5] [6]
            // [7] [8] [9]

            //3D Array 
            int[,,] my3DArray = new int[3, 3, 3];
            string[,,] arr3 = new string[2, 3, 3]
            {
                {
                    { "000", "001", "002" },
                    { "010", "011", "012" },
                    { "020", "021", "022" }
                },
                {
                    { "100", "101", "102" },
                    { "110", "111", "112" },
                    { "120", "121", "122" }
                }
            };

            
            //jagged array: array int array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3] {1, 2, 3};
            jaggedArray[1] = new int[3] {4, 5, 6};
            jaggedArray[2] = new int[3] {7, 8, 9};


            Console.ReadKey();
        }
    }
}
