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
    }
}
