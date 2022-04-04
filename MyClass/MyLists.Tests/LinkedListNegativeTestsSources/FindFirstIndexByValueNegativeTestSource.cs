using System;
using System.Collections;
using MyLinkedLists;

namespace MyLists.Tests.LinkedListNegativeTestsSources
{
    internal class FindFirstIndexByValueNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new LinkedList() };
        }
    }
}
