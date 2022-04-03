using System;
using System.Collections;
using MyLinkedLists;

namespace MyLists.Tests.LinkedListTestsSources
{
    internal class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new LinkedList(new int[] { 3, 4 }), new LinkedList(new int[] { 2, 3, 4 }), new LinkedList(new int[] { 3, 2, 3, 4, 4 }) };
            yield return new object[] { 0, new LinkedList(new int[] { 1, 4, 3 }), new LinkedList(new int[] { 5, 1, 4, 3 }), new LinkedList(new int[] { 5, 1, 4, 3, 1, 4, 3 }) };
            yield return new object[] { 1, new LinkedList(new int[] { 1 }), new LinkedList(new int[] { 1, 1 }), new LinkedList(new int[] { 1, 1, 1 }) };
            yield return new object[] { 2, new LinkedList(new int[] { 5, 8, 2, 9 }), new LinkedList(new int[] { 3 }), new LinkedList(new int[] { 5, 8, 3, 2, 9 }) };
        }
    }
}
