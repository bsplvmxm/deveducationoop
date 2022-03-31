using System;
using System.Collections;
using MyLinkedLists;


namespace MyLists.Tests.LinkedListTestsSources
{
    internal class DeleteFromBeginTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 3, 4 }), new LinkedList(new int[] { 4 }) };
            yield return new object[] { new LinkedList(new int[] { 1, 4, 3, 6 }), new LinkedList(new int[] { 4, 3, 6 }) };
            yield return new object[] { new LinkedList(new int[] { 1 }), new LinkedList(new int[] { }) };
            yield return new object[] { new LinkedList(new int[] { 2, 5, 4 }), new LinkedList(new int[] { 5, 4 }) };
        }
    }
}