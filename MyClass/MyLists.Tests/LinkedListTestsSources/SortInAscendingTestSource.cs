using System;
using System.Collections;
using MyLinkedLists;


namespace MyLists.Tests.LinkedListTestsSources
{
    internal class SortInAscendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 3, 4 }), new LinkedList(new int[] { 3, 4 }) };
            yield return new object[] { new LinkedList(new int[] { 1, 5, 2 }), new LinkedList(new int[] { 1, 2, 5 }) };
            yield return new object[] { new LinkedList(new int[] { 5, 4, 9, 1 }), new LinkedList(new int[] { 1, 4, 5, 9 }) };
            yield return new object[] { new LinkedList(new int[] { 9 }), new LinkedList(new int[] { 9 }) };
        }
    }
}