using System;
using MyLists;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(new int[] { 3, 4, 5 });
            list.WriteArray();
            list.AddListByIndex(new ArrayList(new int[] { 5, 2 }), 1);
            list.WriteArray();




        }
    }
}
