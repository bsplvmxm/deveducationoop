using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class FindMinElementSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(new int[] { 1, 2, 3, 4 }), 1 };
            yield return new object[] { new ArrayList(new int[] { 31, 2 }), 2 };
            yield return new object[] { new ArrayList(new int[] { -5, -94, 2, 77, -82 }), -94 };
        }
    }
}