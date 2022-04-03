using System;
using System.Collections;
using MyLinkedLists;

namespace MyLists.Tests.LinkedListNegativeTestsSources
{
    internal class ThrowNullExceptionNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 3, 4, 5 }), null };
            yield return new object[] { new LinkedList(new int[] { }), null };
        }
    }
}
