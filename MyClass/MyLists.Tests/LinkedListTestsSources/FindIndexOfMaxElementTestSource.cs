using System;
using System.Collections;
using MyLinkedLists;


namespace MyLists.Tests.LinkedListTestsSources
{
    internal class FindIndexOfMaxElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 3, 4 }), 1 };
            yield return new object[] { new LinkedList(new int[] { 1, 3, 6, 2 }), 2 };
            yield return new object[] { new LinkedList(new int[] { 5, 4, 9, 1, 2 }), 2 };
            yield return new object[] { new LinkedList(new int[] { 1 }), 0 };
        }
    }
}