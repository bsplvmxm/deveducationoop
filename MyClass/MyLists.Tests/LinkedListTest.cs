using System;
using System.Collections;
using MyLinkedLists;
using NUnit.Framework;
using MyLists.Tests.LinkedListTestsSources;

namespace MyLists.Tests
{
    public class LinkedListTest
    {
        [TestCaseSource(typeof(AddToEndTestSource))]
        public void AddToEndTest(int value, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.AddToEnd(value);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddToBeginTestSource))]
        public void AddToBeginTest(int value, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.AddToBegin(value);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int value, int index, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.AddByIndex(value, index);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFromEndTestSource))]
        public void DeleteFromEndTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteFromEnd();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFromBeginTestSource))]
        public void DeleteFromBeginTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteFromBegin();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteByIndex(index);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsFromEndTestSource))]
        public void DeleteElementsFromEndTest(int count, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteElementsFromEnd(count);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsFromBeginTestSource))]
        public void DeleteElementsFromBeginTest(int count, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteElementsFromBegin(count);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsByIndexTestSource))]
        public void DeleteElementsByIndexTest(int count, int index, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteElementsByIndex(count, index);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindFirstIndexByValueTestSource))]
        public void FindFirstIndexByValueTest(int value, LinkedList list, int expected)
        {
            int actual = list.FindFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ChangeValueByIndexTestSource))]
        public void ChangeValueByIndexTest(int index, int value, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.ChangeValueByIndex(index, value);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.Reverse();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindMaxElementTestSource))]
        public void FindMaxElementTest(LinkedList list, int expected)
        {
            int actual = list.FindMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindMinElementTestSource))]
        public void FindMinElementTest(LinkedList list, int expected)
        {
            int actual = list.FindMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMaxElementTestSource))]
        public void FindIndexOfMaxElementTest(LinkedList list, int expected)
        {
            int actual = list.FindIndexOfMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMinElementTestSource))]
        public void FindIndexOfMinElementTest(LinkedList list, int expected)
        {
            int actual = list.FindIndexOfMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(SortInAscendingTestSource))]
        public void SortInAscendingTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.SortInAscending();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(SortInDescendingTestSource))]
        public void SortInDescendingTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.SortInDescending();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstByValueTestSource))]
        public void DeleteFirstByValueTest(int value, int expected, LinkedList list, LinkedList expectedList)
        {          
            int actual = list.DeleteFirstByValue(value);
            LinkedList actualList = list;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsByValueTestSource))]
        public void DeleteElementsByValueTest(int value, int expected, LinkedList list, LinkedList expectedList)
        {

            int actual = list.DeleteElementsByValue(value);
            LinkedList actualList = list;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListToEndTestSource))]
        public void AddListToEndTest(LinkedList list, LinkedList addList, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.AddListToEnd(addList);
           
            Assert.AreEqual(expectedList, actualList);
        }
    }
}
