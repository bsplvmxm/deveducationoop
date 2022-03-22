using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class DeleteFromEndElementsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new ArrayList(new int[] { 1, 2, 3, 4 }), new ArrayList(new int[] { 1, 2 }) };
            yield return new object[] { 1, new ArrayList(new int[] { 2, 31 }), new ArrayList(new int[] { 2 }) };
            yield return new object[] { 3, new ArrayList(new int[] { 5, 4, 2, 77, 82 }), new ArrayList(new int[] { 5, 4 }) };
            yield return new object[] { 5, new ArrayList(new int[] { 5, 4, 2, 77, 82 }), new ArrayList(new int[] { }) };
        }
    }
}