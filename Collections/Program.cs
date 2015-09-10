using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays();

            List();

            Queue();

            Stack();

            HashSet();

            LinkedList();

            SortedList();

            DictionaryList();

        }

        private static void DictionaryList()
        {
            //Dictionary with key of Strings and value of List<Employee>
            Console.WriteLine();
            Console.WriteLine("Dictionart with key of Strings and value of List<Employee>");

            var employeesById3 = new Dictionary<String, List<Employee>>();
            employeesById3.Add("Company A", new List<Employee> { new Employee(), new Employee(), new Employee(), new Employee(), new Employee() });
            employeesById3.Add("Company B", new List<Employee> { new Employee(), new Employee(), new Employee() });

            foreach (var item in employeesById3)
            {
                Console.WriteLine("The Count of employees for {0} is {1}", item.Key, item.Value.Count);
            }

            foreach (var item in employeesById3)
            {
                Console.WriteLine("The Capacity of employees for {0} is {1}", item.Key, item.Value.Capacity);
            }
        }

        private static void SortedList()
        {
            //SortedList
            Console.WriteLine();
            Console.WriteLine("SortedList employeesById2");
            Console.WriteLine();

            var employeesById2 = new SortedList<int, Employee>(); //try changing to Dictionay to see the effect

            employeesById2.Add(Employee.Id2(), new Employee { Name = "Tony", Age = 21 });
            employeesById2.Add(Employee.Id2(), new Employee { Name = "Tina", Age = 35 });
            employeesById2.Add(Employee.Id2(), new Employee { Name = "Maude", Age = 67 });
            employeesById2.Add(Employee.Id2(), new Employee { Name = "Michael", Age = 65 });
            employeesById2.Add(Employee.Id2(), new Employee { Name = "Dylan", Age = 34 });


            foreach (var item in employeesById2)
            {
                Console.WriteLine("Id: {0} Name: {1} Age: {2}", item.Key, item.Value.Name, item.Value.Age);
            }
        }

        private static void NewMethod()
        {
            //Dictinary
            Console.WriteLine();
            Console.WriteLine("Dictionary employeesById");
            Console.WriteLine();

            var employeesById = new Dictionary<int, Employee>();

            employeesById.Add(Employee.Id(), new Employee { Name = "Tony", Age = 21 });
            employeesById.Add(Employee.Id(), new Employee { Name = "Tina", Age = 35 });
            employeesById.Add(Employee.Id(), new Employee { Name = "Maude", Age = 67 });
            employeesById.Add(Employee.Id(), new Employee { Name = "Michael", Age = 65 });
            employeesById.Add(Employee.Id(), new Employee { Name = "Dylan", Age = 34 });

            foreach (var item in employeesById)
            {
                Console.WriteLine("Id: {0} Name: {1} Age: {2}", item.Key, item.Value.Name, item.Value.Age);
            }
        }

        private static void LinkedList()
        {
            //LinkedList

            Console.WriteLine("LinkedList Example");

            LinkedList<Employee> list = new LinkedList<Employee>();
            list.AddFirst(new Employee { Name = "john", Age = 14 });
            list.AddFirst(new Employee { Name = "Mike", Age = 17 });

            var first = list.First;
            list.AddAfter(first, new Employee { Name = "Lucy", Age = 19 }); //inserts Lucy after Mike

            foreach (var item in list)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }

        private static void HashSet()
        {
            //HashSet

            Console.WriteLine("HashSet of Employee Example");

            HashSet<Employee> set = new HashSet<Employee>();
            //set.Add(new Employee {Name = "Scott" });
            //set.Add(new Employee {Name = "Scott" }); // this doesn't get ignored even though they have duplicate Name: values

            var employee = new Employee { Name = "Scott" };
            set.Add(employee);
            set.Add(employee); //gets ignored because of duplicate value


            foreach (var item in set)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Stack()
        {
            //Stack

            Console.WriteLine("LIFO with Stack");

            Stack<Employee> stack = new Stack<Employee>();

            stack.Push(new Employee { Name = "Bob" });
            stack.Push(new Employee { Name = "Joe" });
            stack.Push(new Employee { Name = "Mark" });
            stack.Push(new Employee { Name = "Ned" });

            while (stack.Count > 0)
            {
                var employee2 = stack.Pop();
                Console.WriteLine(employee2.Name);
            }
        }

        private static void Queue()
        {
            //Queue

            Console.WriteLine("FIFO with Queue");

            Queue<Employee> queue = new Queue<Employee>();

            queue.Enqueue(new Employee { Name = "Bob" });
            queue.Enqueue(new Employee { Name = "Joe" });
            queue.Enqueue(new Employee { Name = "Mark" });
            queue.Enqueue(new Employee { Name = "Ned" });

            while (queue.Count > 0)
            {
                var employee1 = queue.Dequeue();
                Console.WriteLine(employee1.Name);
                Console.WriteLine("Length of Queue After Dequeue(): {0}", queue.Count);
            }
        }

        private static void List()
        {
            //List
            Console.WriteLine("Printing List Items");

            List<Employee> employeeList = new List<Employee>
            {
                new Employee { Name = "Riza", Age = 32},
                new Employee { Name = "Dhea", Age = 11}
            };

            employeeList.Add(new Employee { Name = "Ulf", Age = 56 });

            foreach (Employee emp in employeeList)
            {
                Console.WriteLine(emp.Name + " " + emp.Age);
            }

            for (int i = 0; i < employeeList.Count; i++)
            {
                Console.WriteLine(employeeList[i].Name + " " + employeeList[i].Age);
            }

            //List and Capacity

            var numbers = new List<int>();
            var capacity = -1;

            try
            {
                while (true)
                {
                    if (numbers.Capacity != capacity)
                    {
                        capacity = numbers.Capacity;
                        Console.WriteLine(capacity);
                    }
                    numbers.Add(1);

                }
            }
            catch (System.OutOfMemoryException e)
            {

                Console.WriteLine(e.Message);
            }
        }

        private static void Arrays()
        {
            //Array
            Employee[] employees = new Employee[]
            {
                new Employee { Name = "Frey", Age = 31},
                new Employee { Name = "Thomas", Age = 32 }

            };

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.Name + " " + emp.Age);
            }

            employees[0].Name = "Michael";

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.Name + " " + emp.Age);
            }

            Array.Resize(ref employees, 5);
        }
    }
}
