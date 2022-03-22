using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class AddWithIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            int value = 5;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 5, 3 });
            yield return new object[] { index, value, list, expectedList };

            index = 1;
            value = 66;
            list = new ArrayList(new int[] { 2 });
            expectedList = new ArrayList(new int[] { 2, 66 });
            yield return new object[] { index, value, list, expectedList };

            index = 0;
            value = 3;
            list = new ArrayList(new int[] { });
            expectedList = new ArrayList(new int[] { 3 });
            yield return new object[] { index, value, list, expectedList };
        }
    }
}