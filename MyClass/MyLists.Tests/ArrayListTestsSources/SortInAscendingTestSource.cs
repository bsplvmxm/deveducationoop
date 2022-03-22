using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class SortInAscendingSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 2, 3 }) };
            yield return new object[] { new ArrayList(new int[] { 55, 2, 31, 6 }), new ArrayList(new int[] { 2, 6, 31, 55 }) };
            yield return new object[] { new ArrayList(new int[] { 5, 4, 2, 77 }), new ArrayList(new int[] { 2, 4, 5, 77 }) };
        }
    }
}