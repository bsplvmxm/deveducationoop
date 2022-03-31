using System;
using System.Collections;
using MyLinkedLists;


namespace MyLists.Tests.LinkedListTestsSources
{
    internal class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 3, 4 }), new LinkedList(new int[] { 4, 3 }) };
            yield return new object[] { new LinkedList(new int[] { 1, 3, 4 }), new LinkedList(new int[] { 4, 3, 1 }) };
            yield return new object[] { new LinkedList(new int[] { 5, 4, 9, 1 }), new LinkedList(new int[] { 1, 9, 4, 5 }) };          
        }
    }
}