using System;
using System.Collections;
using MyLinkedLists;


namespace MyLists.Tests.LinkedListTestsSources
{
    internal class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new LinkedList(new int[] { 3, 4 }), new LinkedList(new int[] { 3 }) };
            yield return new object[] { 0, new LinkedList(new int[] { 1, 4, 3, 6 }), new LinkedList(new int[] { 4, 3, 6 }) };
            yield return new object[] { 0, new LinkedList(new int[] { 1 }), new LinkedList(new int[] { }) };
            yield return new object[] { 2, new LinkedList(new int[] { 2, 5, 4, 8 }), new LinkedList(new int[] { 2, 5, 8 }) };
        }
    }
}