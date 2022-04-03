using System;
using System.Collections;
using MyLinkedLists;

namespace MyLists.Tests.LinkedListTestsSources
{
    internal class AddListToBeginTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 3, 4 }), new LinkedList(new int[] { 2, 3, 4 }), new LinkedList(new int[] { 2, 3, 4, 3, 4 }) };
            yield return new object[] { new LinkedList(new int[] { 1, 4, 3 }), new LinkedList(new int[] { 5, 1, 4, 3 }), new LinkedList(new int[] { 5, 1, 4, 3, 1, 4, 3 }) };
            yield return new object[] { new LinkedList(new int[] { 1 }), new LinkedList(new int[] { 1, 1 }), new LinkedList(new int[] { 1, 1, 1 }) };
            yield return new object[] { new LinkedList(new int[] { 5 }), new LinkedList(new int[] { 3 }), new LinkedList(new int[] { 3, 5 }) };
        }
    }
}
