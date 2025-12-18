using System.Collections;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Miniks");
            myArrayList.Add(12.25);
            myArrayList.Add(128);
            myArrayList.Add(13);
            myArrayList.Add(25.3);
            myArrayList.Add("Hello");

            //delete element by obj
            myArrayList.Remove(13);

            //delete element by index
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            Console.WriteLine("Element of myArrayList: ");
            foreach (object  obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double) obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
