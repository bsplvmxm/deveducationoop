using System;
using System.Collections;
using MyLinkedLists;


namespace MyLists.Tests.LinkedListTestsSources
{
    internal class DeleteElementsByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 4, 2, new LinkedList(new int[] { 3, 4, 4, 3 }), new LinkedList(new int[] { 3, 3 })};
            yield return new object[] { 2, 3, new LinkedList(new int[] { 1, 3, 2, 2, 2, 5 }), new LinkedList(new int[] { 1, 3, 5 })};
            yield return new object[] { 5, 2, new LinkedList(new int[] { 5, 5, 1 }), new LinkedList(new int[] { 1 })};
            yield return new object[] { 1, 0, new LinkedList(new int[] { 5, 77, 23 }), new LinkedList(new int[] { 5, 77, 23 })};
        }
    }
}