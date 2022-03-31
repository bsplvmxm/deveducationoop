using System;
using System.Collections;
using MyLinkedLists;


namespace MyLists.Tests.LinkedListTestsSources
{
    internal class FindMaxElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 3, 4 }), 4 };
            yield return new object[] { new LinkedList(new int[] { 1, 3, 6, 2 }), 6 };
            yield return new object[] { new LinkedList(new int[] { 5, 4, 9, 1, 2 }), 9 };
            yield return new object[] { new LinkedList(new int[] { 1 }), 1 };
        }
    }
}