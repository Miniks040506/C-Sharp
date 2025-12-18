using System.Collections;

namespace HashTables
{
    internal class Program
    {
        //Key - Value
        //Auto - Car
        //Hash Table

        static void Main(string[] args)
        {
            //collection != dictionary (generic)
            Hashtable hashtable = new Hashtable();

            Student student1 = new Student(1, "Maria", 98);
            Student student2 = new Student(2, "Jason", 65);
            Student student3 = new Student(3, "Clara", 83);
            Student student4 = new Student(4, "Steve", 78);

            //key - value -> id - student
            hashtable.Add(student1.Id, student1);
            hashtable.Add(student2.Id, student2);
            hashtable.Add(student3.Id, student3);
            hashtable.Add(student4.Id, student4);

            // index start with 1
            Student storeStudent1 = (Student)hashtable[1];
            Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", 
                storeStudent1.Id, storeStudent1.Name, storeStudent1.GPA);

            //like MapEntry in java
            Console.WriteLine("Student list: ");
            foreach(DictionaryEntry entry in hashtable)
            {
                Student temp = (Student) entry.Value;
                Console.WriteLine("Student ID: {0}", temp.Id);
                Console.WriteLine("Student Name: {0}", temp.Name);
                Console.WriteLine("Student GPA: {0}", temp.GPA);
            }

            Console.WriteLine("Student list: ");
            foreach (Student value in hashtable.Values)
            {
                Console.WriteLine("Student ID: {0}", value.Id);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }

            Console.ReadKey();
        }

        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public float GPA { get; set; }

            public Student(int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;
                this.GPA = GPA;
            }
        }
    }
}
