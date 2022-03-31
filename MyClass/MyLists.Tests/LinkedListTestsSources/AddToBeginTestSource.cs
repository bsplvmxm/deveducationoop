using System;
using System.Collections;
using MyLinkedLists;


namespace MyLists.Tests.LinkedListTestsSources
{
    internal class AddToBeginTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new LinkedList(new int[] { 3, 4 }), new LinkedList(new int[] { 2, 3, 4 }) };
            yield return new object[] { 5, new LinkedList(new int[] { 1, 4, 3 }), new LinkedList(new int[] { 5, 1, 4, 3 }) };
            yield return new object[] { 1, new LinkedList(new int[] { 1 }), new LinkedList(new int[] { 1, 1 }) };
            yield return new object[] { 3, new LinkedList(new int[] { }), new LinkedList(new int[] { 3 }) };
        }
    }
}