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

        [TestCaseSource(typeof(AddToBeginTestSource))]
        public void AddToBeginTest(int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.AddToBegin(value);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddWithIndexTestSource))]
        public void AddWithIndexTest(int index, int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.AddWithIndex(index, value);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFromEndSource))]
        public void DeleteFromEndTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteFromEnd();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFromBeginSource))]
        public void DeleteFromBeginTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteFromBegin();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteWithIndexSource))]
        public void DeleteWithIndexTest(int index, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteWithIndex(index);

            Assert.AreEqual(expectedList, actualList);
        }
    }
}
