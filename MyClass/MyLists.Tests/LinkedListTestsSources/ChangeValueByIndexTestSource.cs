using System;
using System.Collections;
using MyLinkedLists;


namespace MyLists.Tests.LinkedListTestsSources
{
    internal class ChangeValueByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, 2, new LinkedList(new int[] { 3, 4 }), new LinkedList(new int[] { 3, 2 }) };
            yield return new object[] { 3, 5, new LinkedList(new int[] { 1, 4, 3, 3 }), new LinkedList(new int[] { 1, 4, 3, 5 }) };
            yield return new object[] { 0, 3, new LinkedList(new int[] { 1 }), new LinkedList(new int[] { 3 }) };
            yield return new object[] { 2, 77, new LinkedList(new int[] { 2, 3, 2, 2 }), new LinkedList(new int[] { 2, 3, 77, 2 }) };
        }
    }
}