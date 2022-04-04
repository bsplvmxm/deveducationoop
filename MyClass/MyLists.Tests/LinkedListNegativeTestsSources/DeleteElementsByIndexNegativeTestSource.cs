using System;
using System.Collections;
using MyLinkedLists;

namespace MyLists.Tests.LinkedListNegativeTestsSources
{
    internal class DeleteElementsByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, -3, new LinkedList(new int[] { 3, 4, 5 }) };
            yield return new object[] { 2, 10, new LinkedList(new int[] { 1, 3, 6, 7 }) };
            yield return new object[] { 7, 2, new LinkedList(new int[] { 1, 3, 6, 7 }) };
        }
    }
}
