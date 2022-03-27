using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListNegativeTestsSources
{
    internal class ThrowWhenListIsEmptyNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new ArrayList(new int[] { }) };
            yield return new object[] { 0, new ArrayList(new int[] { }) };
            yield return new object[] { -3, new ArrayList(new int[] { }) };
        }
    }
}
