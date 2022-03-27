using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListNegativeTestsSources
{
    internal class AddWithIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { -2, 5, new ArrayList(new int[] { 1, 5 })};
            yield return new object[] { 4, 5, new ArrayList(new int[] { 1, 5 })};
            yield return new object[] { 1, 3, new ArrayList(new int[] { })};
        }
    }
}
