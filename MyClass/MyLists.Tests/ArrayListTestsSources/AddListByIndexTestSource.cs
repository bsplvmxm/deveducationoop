using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new ArrayList(new int[] { 1, 2, 3, 4 }), new ArrayList(new int[] { 5, 8 }), new ArrayList(new int[] { 1, 2, 5, 8, 3, 4 }) };
            yield return new object[] { 0, new ArrayList(new int[] { 1, 4 }), new ArrayList(new int[] { 2 }), new ArrayList(new int[] { 2, 1, 4 }) };
            yield return new object[] { 1, new ArrayList(new int[] { 1, }), new ArrayList(new int[] { 6, 7, 8 }), new ArrayList(new int[] { 1, 6, 7, 8 }) };
            yield return new object[] { 0, new ArrayList(new int[] { }), new ArrayList(new int[] { 6, 9 }), new ArrayList(new int[] { 6, 9 }) };
        }
    }
}
