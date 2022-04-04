using System;
using System.Collections;
using MyLinkedLists;
using NUnit.Framework;
using MyLists.Tests.LinkedListTestsSources;
using MyLists.Tests.LinkedListNegativeTestsSources;

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

        [TestCaseSource(typeof(ThrowEmptyListNegativeTestSource))]
        public void DeleteFromEndTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFromEnd());
        }

        [TestCaseSource(typeof(DeleteFromBeginTestSource))]
        public void DeleteFromBeginTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteFromBegin();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowEmptyListNegativeTestSource))]
        public void DeleteFromBeginTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFromBegin());
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

        [TestCaseSource(typeof(ThrowArgumentExceptionWhenCountIsWrongNegativeTestSource))]
        public void DeleteElementsFromEndTest_WhenCountIsWrong_ShouldThrowArgumentException(int count, LinkedList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsFromEnd(count));
        }

        [TestCaseSource(typeof(DeleteElementsFromBeginTestSource))]
        public void DeleteElementsFromBeginTest(int count, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteElementsFromBegin(count);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowArgumentExceptionWhenCountIsWrongNegativeTestSource))]
        public void DeleteElementsFromBeginTest_WhenCountIsWrong_ShouldThrowArgumentException(int count, LinkedList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsFromBegin(count));
        }


        [TestCaseSource(typeof(DeleteElementsByIndexTestSource))]
        public void DeleteElementsByIndexTest(int count, int index, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteElementsByIndex(count, index);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsByIndexNegativeTestSource))]
        public void DeleteElementsByIndexTest_WhenIndexOrCountIsWrong_ShouldThrowArgumentException(int count, int index, LinkedList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsByIndex(count, index));
        }

        [TestCaseSource(typeof(FindFirstIndexByValueTestSource))]
        public void FindFirstIndexByValueTest(int value, LinkedList list, int expected)
        {
            int actual = list.FindFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindFirstIndexByValueNegativeTestSource))]
        public void FindFirstIndexByValueTest_WhenListIsEmpty_ShouldThrowException(int value, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.FindFirstIndexByValue(value));
        }

        [TestCaseSource(typeof(ChangeValueByIndexTestSource))]
        public void ChangeValueByIndexTest(int index, int value, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.ChangeValueByIndex(index, value);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ChangeValueByIndexNegativeTestSource))]
        public void ChangeValueByIndexTest_WhenListIsEmptyOrIndexIsWrong_ShouldThrowException(int index, int value, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.ChangeValueByIndex(index, value));
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.Reverse();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowEmptyListNegativeTestSource))]
        public void ReverseTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.Reverse());
        }

        [TestCaseSource(typeof(FindMaxElementTestSource))]
        public void FindMaxElementTest(LinkedList list, int expected)
        {
            int actual = list.FindMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ThrowEmptyListNegativeTestSource))]
        public void FindMaxElementTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.FindMaxElement());
        }

        [TestCaseSource(typeof(FindMinElementTestSource))]
        public void FindMinElementTest(LinkedList list, int expected)
        {
            int actual = list.FindMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ThrowEmptyListNegativeTestSource))]
        public void FindMinElementTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.FindMinElement());
        }

        [TestCaseSource(typeof(FindIndexOfMaxElementTestSource))]
        public void FindIndexOfMaxElementTest(LinkedList list, int expected)
        {
            int actual = list.FindIndexOfMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ThrowEmptyListNegativeTestSource))]
        public void FindIndexOfMaxElementTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMaxElement());
        }

        [TestCaseSource(typeof(FindIndexOfMinElementTestSource))]
        public void FindIndexOfMinElementTest(LinkedList list, int expected)
        {
            int actual = list.FindIndexOfMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ThrowEmptyListNegativeTestSource))]
        public void FindIndexOfMinElementTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMinElement());
        }

        [TestCaseSource(typeof(SortInAscendingTestSource))]
        public void SortInAscendingTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.SortInAscending();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowEmptyListNegativeTestSource))]
        public void SortInAscendingTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.SortInAscending());
        }

        [TestCaseSource(typeof(SortInDescendingTestSource))]
        public void SortInDescendingTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.SortInDescending();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowEmptyListNegativeTestSource))]
        public void SortInDescendingTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.SortInDescending());
        }

        [TestCaseSource(typeof(DeleteFirstByValueTestSource))]
        public void DeleteFirstByValueTest(int value, int expected, LinkedList list, LinkedList expectedList)
        {          
            int actual = list.DeleteFirstByValue(value);
            LinkedList actualList = list;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowExceptionWhenListIsEmptyWithValueNegativeTestSource))]
        public void DeleteFirstByValueTest_WhenListIsEmpty_ShouldThrowException(int value, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFirstByValue(value));
        }

        [TestCaseSource(typeof(DeleteElementsByValueTestSource))]
        public void DeleteElementsByValueTest(int value, int expected, LinkedList list, LinkedList expectedList)
        {

            int actual = list.DeleteElementsByValue(value);
            LinkedList actualList = list;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowExceptionWhenListIsEmptyWithValueNegativeTestSource))]
        public void DeleteElementsByValueTest_WhenListIsEmpty_ShouldThrowException(int value, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteElementsByValue(value));
        }

        [TestCaseSource(typeof(AddListToEndTestSource))]
        public void AddListToEndTest(LinkedList list, LinkedList addList, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.AddListToEnd(addList);
           
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowNullExceptionNegativeTestSource))]
        public void AddListToEndTest_WhenOneOfListIsNull_ShouldThrowNullException(LinkedList list, LinkedList addList)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListToEnd(addList));
        }

        [TestCaseSource(typeof(AddListToBeginTestSource))]
        public void AddListToBeginTest(LinkedList list, LinkedList addList, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.AddListToBegin(addList);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowNullExceptionNegativeTestSource))]
        public void AddListToBeginTest_WhenOneOfListIsNull_ShouldThrowNullException(LinkedList list, LinkedList addList)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListToBegin(addList));
        }

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndexTest(int index, LinkedList list, LinkedList addList, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.AddListByIndex(index, addList);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowNullExceptionWithIndexNegativeTestSource))]
        public void AddListByIndexTest_WhenOneOfListIsNull_ShouldThrowNullException(int index, LinkedList list, LinkedList addList)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListByIndex(index, addList));
        }

        [TestCaseSource(typeof(ThrowArgumentExceptionWrongIndexNegativeTestSource))]
        public void AddListByIndexTest_WhenrIndexIsWrong_ShouldThrowArgumentException(int index, LinkedList list, LinkedList addList)
        {
            Assert.Throws<ArgumentException>(() => list.AddListByIndex(index, addList));
        }
    }
}
