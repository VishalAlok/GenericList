using System;
using System.Collections.Generic;
namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MyList = new List<int>();
            MyList.Add(10); MyList.Add(20);
            MyList.Add(30); MyList.Add(40);
            for(int i=0;i<MyList.Count; i++)
                Console.Write(MyList[i] + " ");
            Console.WriteLine();
            MyList.Insert(1, 15);
            for (int i = 0; i < MyList.Count; i++)
                Console.Write(MyList[i] + " ");
            Console.WriteLine();
            MyList.RemoveAt(2);
            foreach(int i in MyList)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
