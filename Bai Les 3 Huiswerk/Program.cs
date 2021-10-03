using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai_Les_3_Huiswerk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1
            //Stack<string> myStack = new Stack<string>();
            //string lijst = "367+*=";

            //foreach(char c in lijst)
            //{
            //    string cString = c.ToString();

            //    if (cString == "=")
            //    {
            //        Console.WriteLine(myStack.Peek());
            //        myStack.Pop();
            //    }
            //    else if (cString == "+")
            //    {
            //        int i = int.Parse(myStack.Peek());
            //        myStack.Pop();
            //        int j = int.Parse(myStack.Peek());
            //        int newNumber = j + i;
            //        myStack.Pop();
            //        myStack.Push(newNumber.ToString());
            //    }
            //    else if (cString == "*")
            //    {
            //        int i = int.Parse(myStack.Peek());
            //        myStack.Pop();
            //        int j = int.Parse(myStack.Peek());
            //        int newNumber = j * i;
            //        myStack.Pop();
            //        myStack.Push(newNumber.ToString());
            //    }
            //    else if (int.Parse(cString) >= 0)
            //    {
            //        myStack.Push(cString);
            //    }
            //}

            //Opgave 2
            //Stack<int> myStack = new Stack<int>();
            //Queue<int> myQueue = new Queue<int>();
            //myQueue.Enqueue(1);
            //myQueue.Enqueue(2);
            //myQueue.Enqueue(3);
            //myQueue.Enqueue(4);
            //myQueue.Enqueue(5);

            //while(myQueue.Count > 0)
            //{
            //    myStack.Push(myQueue.First());
            //    myQueue.Dequeue();
            //}
            //while(myStack.Count() > 0)
            //{
            //    myQueue.Enqueue(myStack.First());
            //    myStack.Pop();
            //}

            //Opgave 3
            Stack<int> myStack = new Stack<int>();
            Queue<int> myQueue = new Queue<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(11);
            myStack.Push(21);
            while (myStack.Count > 0)
            {

            }
        }
    }
}
