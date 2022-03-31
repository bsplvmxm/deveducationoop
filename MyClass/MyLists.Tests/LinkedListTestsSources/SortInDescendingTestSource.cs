using System;
using System.Collections;
using MyLinkedLists;


namespace MyLists.Tests.LinkedListTestsSources
{
    internal class SortInDescendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 3, 4 }), new LinkedList(new int[] { 4, 3 }) };
            yield return new object[] { new LinkedList(new int[] { 1, 5, 2 }), new LinkedList(new int[] { 5, 2, 1 }) };
            yield return new object[] { new LinkedList(new int[] { 5, 4, 9, 1 }), new LinkedList(new int[] { 9, 5, 4, 1 }) };
            yield return new object[] { new LinkedList(new int[] { 9 }), new LinkedList(new int[] { 9 }) };
        }
    }
}