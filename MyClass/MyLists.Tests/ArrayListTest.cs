using System;
using System.Collections;
using NUnit.Framework;
using MyLists.Tests.ArrayListTestsSources;

namespace MyLists.Tests
{
    class ArrayListTest
    {
        [TestCaseSource(typeof(AddToEndTestSource))]
        public void AddToEndTest(int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.AddToEnd(value);

            Assert.AreEqual(expectedList, actualList);
        }
    }
}
