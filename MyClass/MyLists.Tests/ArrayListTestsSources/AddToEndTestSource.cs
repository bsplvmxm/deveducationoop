using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class AddToEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 5 });
            yield return new object[] { value, list, expectedList };
        }
    }
}
