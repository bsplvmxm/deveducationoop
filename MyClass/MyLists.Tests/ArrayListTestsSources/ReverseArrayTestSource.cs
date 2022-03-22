using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class ReverseArraySource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(new int[] { 1, 2, 3, 4 }), new ArrayList(new int[] { 4, 3, 2, 1 }) };
            yield return new object[] { new ArrayList(new int[] { 2, 31 }), new ArrayList(new int[] { 31, 2 }) };
            yield return new object[] { new ArrayList(new int[] { 5, 4, 2, 77, 82 }), new ArrayList(new int[] { 82, 77, 2, 4, 5 }) };
            yield return new object[] { new ArrayList(new int[] { 3 }), new ArrayList(new int[] { 3 }) };
        }
    }
}