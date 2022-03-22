using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class ChangeValueByIndexSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, 5, new ArrayList(new int[] { 1, 2, 3, 4 }), new ArrayList(new int[] { 1, 5, 3, 4 }) };
            yield return new object[] { 0, 13, new ArrayList(new int[] { 2, 31 }), new ArrayList(new int[] { 13, 31 }) };
            yield return new object[] { 3, 255, new ArrayList(new int[] { 5, 4, 2, 77, 82 }), new ArrayList(new int[] { 5, 4, 2, 255, 82 }) };
            yield return new object[] { 0, 43, new ArrayList(new int[] { 3 }), new ArrayList(new int[] { 43 }) };
        }
    }
}