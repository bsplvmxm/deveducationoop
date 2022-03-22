using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class FindFirstIndexByValueSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new ArrayList(new int[] { 1, 2, 3, 4 }), 0 };
            yield return new object[] { 2, new ArrayList(new int[] { 31, 2, 2, 3, 2 }), 1 };
            yield return new object[] { 77, new ArrayList(new int[] { 5, 4, 2, 77, 82 }), 3 };
            yield return new object[] { 6, new ArrayList(new int[] { 5, 4, 2, 77, 82 }), -1 };
        }
    }
}