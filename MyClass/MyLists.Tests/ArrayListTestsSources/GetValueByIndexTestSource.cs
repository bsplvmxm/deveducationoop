using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class GetValueByIndexSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new ArrayList(new int[] { 1, 2, 3, 4 }), 2 };
            yield return new object[] { 0, new ArrayList(new int[] { 2, 31 }), 2 };
            yield return new object[] { 3, new ArrayList(new int[] { 5, 4, 2, 77, 82 }), 77 };
        }
    }
}