using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class AddToBeginTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3 });
            ArrayList expectedList = new ArrayList(new int[] { 5, 1, 2, 3 });
            yield return new object[] { value, list, expectedList };

            value = 66;
            list = new ArrayList(new int[] { 2, });
            expectedList = new ArrayList(new int[] { 66, 2 });
            yield return new object[] { value, list, expectedList };

            value = 3;
            list = new ArrayList(new int[] { });
            expectedList = new ArrayList(new int[] { 3 });
            yield return new object[] { value, list, expectedList };
        }
    }
}