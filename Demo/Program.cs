using System.Collections;

namespace Demo
{
    internal class Program
    {
        public static int SumArrayList( ArrayList list)
        {
            int sum = 0;
            if ( list is not null)
            {
               
                for (int i=0; i<list.Count;i++)
                {
                    sum += (int)list[i]; //unboxing -unsafe

                }
               
            }
            return sum;
        }

        public static int SumList(List<int> list)
        {
            int sum = 0;
            if (list is not null)
            {

                for (int i = 0; i < list.Count; i++)
                {
                    sum += (int)list[i]; //unboxing -unsafe

                }

            }
            return sum;
        }
        public static void PrintArrayList(ArrayList list)
        {
            Console.WriteLine();
            foreach (int  item in list)
            {
                Console.Write($"{item} ");
            }
           
        }

        public static void PrintList<T>(List<T> list)
        {
            Console.WriteLine("null");
            foreach (T item in list)
            {
                Console.Write($"<- {item} -> ");
            }
            Console.WriteLine("null");
        }


        public static void PrintLinkedList(LinkedList<int> list)
        {
            Console.Write("null");
            foreach (int item in list)
            {
                Console.Write($"<- {item} -> ");
            }
            Console.WriteLine("null");
        }

        public static void PrintStack(Stack<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine($"{item} ");
            }
        }
        public static void PrintQueue(Queue<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine($"{item} ");
            }
        }
        static void Main(string[] args)
            {
                  //int[] Numbers = { 1, 2, 3, 4, 5 };
                  //Numbers[1]= 12;
                  //Console.WriteLine(Numbers[1]);
                  //
                  //ArrayList list = new ArrayList();
                  //ArrayList list = new ArrayList(new int[] { 1, 2, 3 });
                  //ArrayList list = new ArrayList(6);
                  
                  // ArrayList list = new ArrayList();
                  //list.Add(1);
                  //list.Add(2);
                  //list.Add(3);
                  //list.Add(4);
                  
                  //Console.WriteLine($"Count :: {list.Count} Capacity :: {list.Capacity}");
                  
                  //list.Add(4);
                  //list.Add(4);
                  //list.Add(4);
                  //list.Add(4);
                  
                  //Console.WriteLine($"Count :: {list.Count} Capacity :: {list.Capacity}");
                  
                  //list.Add(4);
                  //Console.WriteLine($"Count :: {list.Count} Capacity :: {list.Capacity}");
                  
                  //Console.WriteLine(list.IsFixedSize);
                  //Console.WriteLine(list.IsReadOnly);
                  //list[1] = 10;
                  
                  //list.AddRange(new int[] { 1, 2, 3 });   
                  //PrintArrayList(list);
                  
                  //int X = list.BinarySearch(2);
                  //Console.WriteLine(X);
                  
                  //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 21, Salary = 12000 };
                  //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 24, Salary = 15000 };
                  //Employee E03 = new Employee() { Id = 3, Name = "Mona", Age = 23, Salary = 14000 };
                  //Employee E04 = new Employee() { Id = 4, Name = "Hady", Age = 22, Salary = 13000 };
                  //
                  //ArrayList list = new ArrayList();
                  //list.AddRange(new Employee[] { E01 ,E02 ,E03 ,E04});
                  
                  // int index =list.BinarySearch(E02,new EmployeeCompareName());
                  //int index = list.BinarySearch(new Employee() {Name="Mona" }, new EmployeeCompareName());
                  //int index = list.BinarySearch(0,4,new Employee() { Name = "Mona" }, new EmployeeCompareName());
                  //Console.WriteLine(index);
                  
                  //  Console.WriteLine("====================");
                  //foreach (Employee item in list)
                  //{
                  //    Console.WriteLine(item);
                  //}
                  
                  
                  //ArrayList list = new ArrayList();
                  //list.Add(1);
                  //list.Add(2);
                  //list.Add(3);
                  //list.Add(4);
                  
                  //Console.WriteLine($"Count :: {list.Count} Capacity :: {list.Capacity}");
                  //list.Clear();
                  //Console.WriteLine($"Count :: {list.Count} Capacity :: {list.Capacity}");
                  
                  //bool Flage =list.Contains(1);
                  //Console.WriteLine(Flage);
                  
                  //int[] Arr = new int[8];
                  //list.CopyTo( Arr, 0 );
                  //list.CopyTo( Arr);
                  
                  //ArrayList list = new ArrayList();
                  //list.Add(1);
                  //list.Add(2);
                  //list.Add(3);
                  //list.Add(4);
                  
                  //list.Add("Hello World");
                  
                  //int Sum = SumArrayList(list);
                  //Console.WriteLine(Sum);
                  
                  //List<int> list = new List<int>(new int[]{ 1, 2, 3, 4});
                  //List<int> list = new List<int>();
                  //list.Add(1);
                  //list.Add(2);
                  //list.Add(3);
                  //list.Add(4);
                  
                  //PrintList(list);
                  
                  //int Sum = SumList(list);
                  //Console.WriteLine(Sum);
                  
                  //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 21, Salary = 12000 };
                  //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 24, Salary = 15000 };
                  //Employee E03 = new Employee() { Id = 3, Name = "Mona", Age = 23, Salary = 14000 };
                  //Employee E04 = new Employee() { Id = 4, Name = "Hady", Age = 22, Salary = 13000 };
                  //
                  //List<Employee> list = new List<Employee>() { E01,E01,E02,E03 };
                  
                  // int index =list.BinarySearch(E02);
                  //int index = list.BinarySearch(new Employee() {Name="Mona" }, new EmployeeCompareName());
                  //int index = list.BinarySearch(0,4,new Employee() { Name = "Mona" }, new EmployeeCompareName());
                  //Console.WriteLine(index);
                  
                 // LinkedList<int> list = new LinkedList<int>();
                 // list.AddFirst(1);
                 // list.AddFirst(2);
                 // 
                 // LinkedListNode<int> node = new LinkedListNode<int>(3);
                 // 
                 // list.AddLast(node);
                  
                  //list.AddAfter(node,4);
                  
                  //LinkedListNode<int> result = list.Find(1);
                  //list.AddBefore(result, 4);
                  
                  //list.AddLast(1);
                  //list.AddLast(2);
                  // PrintLinkedList(list);
                  
                  //Console.WriteLine(list.First.Value);
                  //Console.WriteLine(list.Last.Value);
                  //Console.WriteLine(list.First.Next.Value);
                  
                 //Stack<int> stack = new Stack<int>();    
                 //stack.Push(1);
                 //stack.Push(2);
                 //stack.Push(3);
                 //stack.Push(4);
                 //stack.Push(5);
                 //
                 ////int Top = stack.Peek();
                 ////Console.WriteLine(Top);
                 //int pop = stack.Pop();    
                 //
                 //PrintStack(stack);
                 //
                 Queue<int> queue = new Queue<int>();
                   queue.Enqueue(1);
                   queue.Enqueue(2);
                   queue.Enqueue(3);   
                   queue.Enqueue(4);   
                   queue.Enqueue(5);

                   PrintQueue(queue);
                   queue.Peek();    
                  queue.Dequeue();

                  
         }
    }
}
