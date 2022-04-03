using System;
using System.Collections;
using MyLinkedLists;

namespace MyLists.Tests.LinkedListNegativeTestsSources
{
    internal class ThrowEmptyListNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList() };
        }
    }
}
