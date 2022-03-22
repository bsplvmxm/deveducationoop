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

        [TestCaseSource(typeof(DeleteFromEndElementsSource))]
        public void DeleteFromEndElementsTest(int count, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteFromEndElements(count);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFromBeginElementsSource))]
        public void DeleteFromBeginElementsTest(int count, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteFromBeginElements(count);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteWithIndexElementsSource))]
        public void DeleteWithIndexElementsTest(int index, int count, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteWithIndexElements(index, count);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(GetLengthSource))]
        public void GetLengthTest(ArrayList list, int expected)
        {
            int actual = list.GetLength();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetValueByIndexSource))]
        public void GetValueByIndexTest(int index, ArrayList list, int expected)
        {
            int actual = list.GetValueByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindFirstIndexByValueSource))]
        public void FindFirstIndexByValueTest(int value, ArrayList list, int expected)
        {
            int actual = list.FindFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ChangeValueByIndexSource))]
        public void ChangeValueByIndexTest(int index, int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.ChangeValueByIndex(index, value);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ReverseArraySource))]
        public void ReverseArrayTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.ReverseArray();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindMaxElementSource))]
        public void FindMaxElementTest(ArrayList list, int expected)
        {
            int actual = list.FindMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindMinElementSource))]
        public void FindMinElementTest(ArrayList list, int expected)
        {
            int actual = list.FindMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMaxElementSource))]
        public void FindIndexOfMaxElementTest(ArrayList list, int expected)
        {
            int actual = list.FindIndexOfMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMinElementSource))]
        public void FindIndexOfMinElementTest(ArrayList list, int expected)
        {
            int actual = list.FindIndexOfMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(SortInAscendingSource))]
        public void SortInAscendingTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.SortInAscending();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(SortInDescendingSource))]
        public void SortInDescendingTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.SortInDescending();

            Assert.AreEqual(expectedList, actualList);
        }
    }
}
