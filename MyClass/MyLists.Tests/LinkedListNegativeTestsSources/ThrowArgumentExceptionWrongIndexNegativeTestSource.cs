using System;
using System.Collections;
using MyLinkedLists;


namespace MyLists.Tests.LinkedListNegativeTestsSources
{
    internal class ThrowArgumentExceptionWrongIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { -3, new LinkedList(new int[] { 3, 4, 5 }), new LinkedList(new int[] { 3, 2, 5 }) };
            yield return new object[] { 5, new LinkedList(new int[] { 1, 3, 6, 7 }), new LinkedList(new int[] { 1, 4, 5 }) };
        }
    }
}
