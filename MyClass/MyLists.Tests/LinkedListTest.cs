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
    }
}
