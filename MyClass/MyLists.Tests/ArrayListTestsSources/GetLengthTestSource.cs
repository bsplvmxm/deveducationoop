using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class GetLengthSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(new int[] { 1, 2, 3, 4 }), 4 };
            yield return new object[] { new ArrayList(new int[] { 2, 31 }), 2 };
            yield return new object[] { new ArrayList(new int[] { 5, 4, 2, 77, 82 }), 5 };
            yield return new object[] { new ArrayList(new int[] { }), 0};
        }
    }
}