using System;
using MyLists;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.WriteArray();
            list.AddToEnd(5);
            list.WriteArray();
            list.AddToEnd(5);
            list.WriteArray();
            list.AddToEnd(5);
            list.WriteArray();
            list.AddToBegin(4);
            list.WriteArray();
            list.AddWithIndex(2, 7);
            list.WriteArray();
            list.DeleteFromEnd();
            list.WriteArray();
            list.DeleteFromEndElements(1);
            list.WriteArray();
            list.DeleteFromBeginElements(2);
            list.WriteArray();
            list.AddToEnd(5);
            list.WriteArray();
            list.AddToEnd(5);
            list.WriteArray();
            list.AddToEnd(4);
            list.WriteArray();
            list.AddToEnd(7);
            list.WriteArray();
            list.AddToEnd(8);
            list.WriteArray();
            list.AddToEnd(1);
            list.WriteArray();
            list.AddToEnd(2);
            list.WriteArray();
            list.DeleteWithIndexElements(2, 2);
            list.WriteArray();
            int res = list.GetValueByIndex(3);
            Console.WriteLine(res);
            int res1 = list.GetLength();
            Console.WriteLine(res1);
            int res2 = list.FindFirstIndexByValue(2);
            Console.WriteLine(res2);
            list.ChangeValueByIndex(2, 9);
            list.WriteArray();
            list.ReverseArray();
            list.WriteArray();
            int maxi = list.FindMaxElement();
            Console.WriteLine(maxi);
            int mini = list.FindMinElement();
            Console.WriteLine(mini);
            int maxind = list.FindIndexOfMaxElement();
            Console.WriteLine(maxind);
            int minind = list.FindIndexOfMinElement();
            Console.WriteLine(minind);
            list.SortInAscending();
            list.WriteArray();
            list.SortInDescending();
            list.WriteArray();
            int res3 = list.DeleteFirstByValue(7);
            Console.WriteLine(res3);
            list.WriteArray();
            list.AddToEnd(2);
            list.WriteArray();
            int res4 = list.DeleteElementsByValue(2);
            Console.WriteLine(res4);
            list.WriteArray();




        }
    }
}
