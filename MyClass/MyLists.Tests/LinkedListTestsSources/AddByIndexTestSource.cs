using System;
using System.Collections;
using MyLinkedLists;


namespace MyLists.Tests.LinkedListTestsSources
{
    internal class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, 1, new LinkedList(new int[] { 3, 4 }), new LinkedList(new int[] { 3, 2, 4 }) };
            yield return new object[] { 5, 2, new LinkedList(new int[] { 1, 4, 3, 6 }), new LinkedList(new int[] { 1, 4, 5, 3, 6 }) };
            yield return new object[] { 1, 1, new LinkedList(new int[] { 1 }), new LinkedList(new int[] { 1, 1 }) };
            yield return new object[] { 3, 0, new LinkedList(new int[] { }), new LinkedList(new int[] { 3 }) };
        }
    }
}