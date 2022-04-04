using System;
using System.Collections;
using MyLinkedLists;

namespace MyLists.Tests.LinkedListNegativeTestsSources
{
    internal class ChangeValueByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, 3, new LinkedList() };
            yield return new object[] { 5, 3, new LinkedList(new int[] { 3, 5, 4, 2 } ) };
        }
    }
}
