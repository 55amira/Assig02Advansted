using Microsoft.VisualBasic;
using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assig02Advanced
{
    internal class Program
    {
        public static void PrintStack(Stack<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine($"{item} ");
            }
        }
        public static void PrintQueue<T>(Queue<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine($"{item} ");
            }
        }

        public static void PrintList<T>(List<T> list)
        {
            Console.WriteLine();
            foreach (T item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public static void PrintList (List<int> list)
        {
            Console.WriteLine();
            foreach (int item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public static void RemoveDuplicate(List<int> Arr)
        {
            for (int i = 0; i < Arr.Count; i++)
            {
                for (int j = Arr.Count-1; j > i; j--)
                {
                    if (Arr[i] == Arr[j])
                        Arr.RemoveAt(j);

                }
            }
        }

        public static void RemoveOod(List<int> Arr)
        {
            for(int i = 0;i < Arr.Count; i++)
            {
                if(Arr[i] % 2 != 0)
                    Arr.RemoveAt(i);

            }
        }
        public static void Pushes(Stack<int> stack)
        {
            int number;
            Console.WriteLine("Enter the number of element of stack: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("enter the correct number ");
            }

            int element;
            Console.WriteLine("Enter the element of stack");
            for (int i = 0; i < number; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out element))
                {
                    Console.WriteLine($" enter the correct element {i + 1}:");
                }

                stack.Push(element);
            }

            int target;
            Console.WriteLine("Enter the target  ");

            while (!int.TryParse(Console.ReadLine(), out target))
            {
                Console.WriteLine("enter the correct target ");
            }
            int Count = 0;
            bool found = false;
            foreach (int i in stack)
            {
                Count++;

                if(i == target)
                {
                    Console.WriteLine($"Target was found successfully and the count = {Count} ");
                    found = true;
                    break;
                }
            
            }

            if (!found)
                Console.WriteLine("Target was not found");
        }

        public static List<int> FindIntersection(int[] Arr1, int[] Arr2)
        {
            List<int> intersection = new List<int>();
            Array.Sort(Arr1);
            Array.Sort(Arr2);

            int i = 0, j = 0;


            while (i < Arr1.Length && j < Arr2.Length)
            {
                if (Arr1[i] == Arr2[j])
                {
                    intersection.Add(Arr1[i]);
                    i++;
                    j++;
                }
                else if (Arr1[i] < Arr2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }

            }

            return intersection;
        }

       public static List<int> FindSubListWithSum(List<int> numbers, int targetSum)
       {
            int left = 0, currentSum = 0;
            List<int> subList = new List<int>();

            for (int right = 0; right < numbers.Count; right++)
            {
                currentSum += numbers[right];

                while (currentSum > targetSum && left <= right)
                {
                    currentSum -= numbers[left];
                    left++;
                }

                
                if (currentSum == targetSum)
                {
                    subList = numbers.GetRange(left, right - left + 1);
                    break;
                }
            }

            return subList;
        }
        static void Main(string[] args)
        {

            #region Q1 Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.

            //int size;
            //int number;
            //Console.WriteLine("Enter the size of Array : ");

            //while(!int.TryParse(Console.ReadLine(), out  size))
            //{
            //    Console.WriteLine("enter the correct size ");
            //}

            //Console.WriteLine("Enter the Number of Queries : ");

            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.WriteLine("enter the correct Number ");
            //}

            //int[] Arr = new int[size];
            //Console.WriteLine("Enter the element of Array");
            //for (int i = 0; i < size; i++)
            //{
            //    while (!int.TryParse(Console.ReadLine(), out Arr[i]))
            //    {
            //        Console.WriteLine($" enter the correct element {i + 1}:");
            //    }
            //}


            //Array.Sort(Arr);
            //for (int i = 0; i < number; i++)
            //{
            //    int Q;
            //    int Count = 0;
            //    Console.WriteLine("enter the Query ");
            //    while (!int.TryParse(Console.ReadLine(), out Q))
            //    {
            //        Console.WriteLine("enter the correct Query ");
            //    }

            //    for (int J = 0; J < Arr.Length; J++)
            //    {
            //        if (Arr[J] >= Q)
            //            Count++;

            //    }


            //    Console.WriteLine($"Count = {Count}");
            //}






            #endregion


            #region Q2 Given a number N and an array of N numbers. Determine if it's palindrome or not.
            //int size;

            //Console.WriteLine("Enter the size of Array : ");

            //while (!int.TryParse(Console.ReadLine(), out size))
            //{
            //    Console.WriteLine("enter the correct size ");
            //}

            //int[] Arr = new int[size];
            //Console.WriteLine("Enter the element of Array");


            //for (int i = 0; i < size; i++)
            //{
            //    while (!int.TryParse(Console.ReadLine(), out Arr[i]))
            //    {
            //        Console.WriteLine($" enter the correct element {i + 1}:");
            //    }

            //}

            //bool isPalindrome = true;
            //for (int i = 0; i < size / 2; i++)
            //{
            //    if (Arr[i] != Arr[size - i - 1])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}
            //if (isPalindrome)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion

            #region Q3  Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);   
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //PrintQueue(queue);

            //Stack<int> stack = new Stack<int>();

            //int S = queue.Count;
            //for (int i= 0 ; i < S;i++)
            //{
            //   int x = queue.Dequeue();
            //    stack.Push(x);

            //}
            //Console.WriteLine();
            //PrintStack(stack);
            #endregion


            #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //use stack how ?? i don`t know
            #endregion

            #region Q5 Given an array, implement a function to remove duplicate elements from an array.

            //List<int> Arr =new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 4, };
            //
            //RemoveDuplicate(Arr);
            //PrintList(Arr);


            #endregion

            #region 6. Given an array list , implement a function to remove all odd numbers from it.

            //List<int> Arr = new List<int> { 1, 2, 3, 4, 5, 6,7 };
            //
            //RemoveOod(Arr);
            //PrintList(Arr);
            #endregion

            #region Q7 Implement a queue that can hold different data types.And insert the following data:queue.Enqueue(1)queue.Enqueue(“Apple”)queue.Enqueue(5.28)
            //Queue<Object> queue = new Queue<Object>();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);
            //
            //PrintQueue(queue);

            #endregion

            #region 8. Create a function that pushes a series of integers onto a stack.Then, search for a target integer in the stack. If the target isfound, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”)

            //Stack<int> stack = new Stack<int>();
            //Pushes(stack);


            #endregion


            #region 9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            //int size1;
            // int size2;
            // Console.WriteLine("Enter the size of Array1 : ");

            // while(!int.TryParse(Console.ReadLine(), out  size1))
            // {
            //     Console.WriteLine("enter the correct size ");
            // }

            // Console.WriteLine("Enter the size of Array2 : ");

            // while (!int.TryParse(Console.ReadLine(), out size2))
            // {
            //     Console.WriteLine("enter the correct size ");
            // }

            // int[] Arr1 = new int[size1];
            // Console.WriteLine("Enter the element of Array1");
            // for (int i = 0; i < size1; i++)
            // {
            //     while (!int.TryParse(Console.ReadLine(), out Arr1[i]))
            //     {
            //         Console.WriteLine($" enter the correct element {i + 1}:");
            //     }
            // }


            // int[] Arr2 = new int[size2];
            // Console.WriteLine("Enter the element of Array2");
            // for (int i = 0; i < size2; i++)
            // {
            //     while (!int.TryParse(Console.ReadLine(), out Arr2[i]))
            //     {
            //         Console.WriteLine($" enter the correct element {i + 1}:");
            //     }
            // }

            // List<int> result = FindIntersection(Arr1, Arr2);
            // PrintList( result ); 
            #endregion

            #region 10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

            //int number;
            //Console.WriteLine("Enter the number of element of List: ");

            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.WriteLine("enter the correct number ");
            //}
            //List<int> numbers = new List<int>();
            //int element;
            //Console.WriteLine("Enter the element of List");
            //for (int i = 0; i < number; i++)
            //{
            //    while (!int.TryParse(Console.ReadLine(), out element))
            //    {
            //        Console.WriteLine($" enter the correct element {i + 1}:");
            //    }

            //    numbers.Add(element);
            //}

            //Console.WriteLine("Enter the target sum:");
            //int targetSum;
            //while (!int.TryParse(Console.ReadLine(), out targetSum))
            //{
            //    Console.WriteLine("Enter a valid integer for the target sum:");
            //}


            //List<int> result = FindSubListWithSum(numbers, targetSum);

            //PrintList(result);

            #endregion


            #region 11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

             int K;
            Console.WriteLine("Enter the number Key ");

            while (!int.TryParse(Console.ReadLine(), out K))
            {
                Console.WriteLine("enter the correct Key ");
            }
            List<int> list = new List<int>(queue);


            int index = list.IndexOf(K);
            Console.WriteLine(K);
            Stack<int> stack = new Stack<int>();
            for (int i = 0;i<index;i++)
            {
                stack.Push(queue.Dequeue());
                list.RemoveAt(i);
            }

            Queue<int> result = new Queue<int>(stack);
            result.Enqueue(list[1]);
            result.Enqueue(list[2]);
            Console.WriteLine();
            PrintQueue(result); 
          PrintStack(stack);
            #endregion









        }
    }
}
