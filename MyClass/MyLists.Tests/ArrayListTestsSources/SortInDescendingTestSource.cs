using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class SortInDescendingSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 3, 2, 1 }) };
            yield return new object[] { new ArrayList(new int[] { 55, 2, 31, 6 }), new ArrayList(new int[] { 55, 31, 6, 2 }) };
            yield return new object[] { new ArrayList(new int[] { 5, 4, 2, 77 }), new ArrayList(new int[] { 77, 5, 4, 2 }) };
            yield return new object[] { new ArrayList(new int[] { 4, 3, 2 }), new ArrayList(new int[] { 4, 3, 2 }) };
        }
    }
}