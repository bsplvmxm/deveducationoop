using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListNegativeTestsSources
{
    internal class GetValueByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { -2, new ArrayList(new int[] { 3, 5 }) };
            yield return new object[] { 4, new ArrayList(new int[] { 1, 8 }) };
            yield return new object[] { 1, new ArrayList(new int[] { }) };
        }
    }
}
