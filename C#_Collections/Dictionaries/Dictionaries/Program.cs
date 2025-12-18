namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //key - value -> KEY is unique
            //it look like a hashtable but this is a generic type
            //that mean can cast the type for key - value

            //initialize dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>();

            //add new item to dictionary
            employees.Add(101, "John Doe");
            employees.Add(102, "Non Smith");
            employees.Add(103, "Miniks Nguyen");
            employees.Add(104, "Harley Carl");
            employees.Add(105, "Jacky Kingsley");

            //access item in the dictionary by key
            string name = employees[103];
            Console.WriteLine($"Hello {name}!");

            //update value of dictionary by key
            employees[102] = "Jane Smith";

            //employees[104] = "Mike Jike";
            if (!employees.ContainsKey(104))
            {
                employees.Add(104, "Mike Jike");
            }

            //remove value of dictionary by key
            employees.Remove(101);

            int count = 101;
            while (employees.ContainsKey(count))
            {
                count++;
            }
            employees.Add(count, "Hana Christ");

            //TryAdd -> return bool : return false if already have
            //otherwise, add and return true
            bool addedCheck = employees.TryAdd(102, "Michal Brims");
            if (!addedCheck)
            {
                Console.WriteLine("Employee with the id of 102 already exists!");
            }

            //use KeyValuePair<> as EntrySet in java
            //that return pair of key - value
            //iterating over a dictionary
            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }


            //Dictionary with complex object
            Dictionary<int, Employee> employees2 = new Dictionary<int, Employee>()
            {
                { 1, new Employee("Jake", 20, 140000) },
                { 2, new Employee("Mickie", 24, 210000) }
            };

            employees2.Add(3, new Employee("Miniks", 20, 240000));
            employees2.Add(4, new Employee("Minie", 24, 200000));
            employees2.Add(5, new Employee("John", 35, 340000));
            employees2.Add(6, new Employee("Hana", 29, 170000));

            //var -> KeyValuePair<int, Employee> 
            foreach (var item in employees2)
            {
                Console.WriteLine($"ID: {item.Key}, named: {item.Value.Name}, " +
                    $"earns {item.Value.Salary} at {item.Value.Age} years old!");
            }

            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas"
            };

            if (codes.TryGetValue("NY", out string state))
            {
                Console.WriteLine($"this is {state}");
            }

            foreach(var item in codes)
            {
                Console.WriteLine($"The statecoe is {item.Key} " +
                    $"and the state name is {item.Value}!");
            }

            Console.ReadKey();
        }
    }
}
