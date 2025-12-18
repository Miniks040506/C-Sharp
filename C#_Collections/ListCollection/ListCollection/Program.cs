namespace ListCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> is a generic collection
            //that mean this is a collection of type, object,...
            //list store the elements in linear sequense
            //lists are dynamic != arrays are static
            //list can resize -> unlimited members
            //List<string> colors = new List<string>();
            //List<string> colors = ["white", "black"];
            List<string> colors = new List<string>() { "white", "black" };

            //Core build-in method/function of List 
            //Add(T item), Remove(T item), Insert(int index, T item), Find(Predicate<T> match)
            //Sort(), Clear(), ToArray(), IndexOf(T item)

            //add color to the  list
            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");
            colors.Add("Yellow");
            colors.Add("Orange");
            colors.Add("red");

            //read list data
            Console.WriteLine("Current colors in the list: ");
            foreach (string color in colors)
            {  
                Console.WriteLine(color);
            }

            //delete first red color
            //colors.Remove("red");

            bool isDeletingSuccessfully = colors.Remove("red");
            while (isDeletingSuccessfully)
            {
                isDeletingSuccessfully = colors.Remove("red");
            }

            Console.WriteLine("Current colors in the list: ");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.ReadKey();
        }
    }
}
