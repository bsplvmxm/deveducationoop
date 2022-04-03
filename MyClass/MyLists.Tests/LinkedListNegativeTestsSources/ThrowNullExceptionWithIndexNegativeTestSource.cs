using System;
using System.Collections;
using MyLinkedLists;

namespace MyLists.Tests.LinkedListNegativeTestsSources
{
    internal class ThrowNullExceptionWithIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new LinkedList(new int[] { 3, 4, 5 }), null };
            yield return new object[] { 2, new LinkedList(new int[] { 1, 3, 6, 7 }), null };
        }
    }
}
