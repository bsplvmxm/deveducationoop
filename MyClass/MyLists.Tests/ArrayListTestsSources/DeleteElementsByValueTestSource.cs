using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class DeleteElementsByValueSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new ArrayList(new int[] { 1, 2, 3, 4, 2 }), 2 };
            yield return new object[] { 6, new ArrayList(new int[] { 31, 2, 5, 6, 6, 6 }), 3 };
            yield return new object[] { 4, new ArrayList(new int[] { -5, -94, 2, 77, -82 }), 0 };
            yield return new object[] { -5, new ArrayList(new int[] { -5, -94, 2, 77, -82 }), 1 };
        }
    }
}