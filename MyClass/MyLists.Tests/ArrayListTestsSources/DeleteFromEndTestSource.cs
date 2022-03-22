using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class DeleteFromEndSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {           
            ArrayList list = new ArrayList(new int[] { 1, 2, 3 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2 });
            yield return new object[] { list, expectedList };
  
            list = new ArrayList(new int[] { 2, 31 });
            expectedList = new ArrayList(new int[] { 2 });
            yield return new object[] { list, expectedList };
    
            list = new ArrayList(new int[] { 5, 4, 2, 77 });
            expectedList = new ArrayList(new int[] { 5, 4, 2 });
            yield return new object[] { list, expectedList };
        }
    }
}