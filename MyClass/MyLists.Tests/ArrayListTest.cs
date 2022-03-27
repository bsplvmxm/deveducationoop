using System;
using System.Collections;
using NUnit.Framework;
using MyLists.Tests.ArrayListTestsSources;
using MyLists.Tests.ArrayListNegativeTestsSources;

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

        [TestCaseSource(typeof(AddWithIndexNegativeTestSource))]
        public void AddWithIndex_WhenIndexIsWrong_ShouldThrowNewException(int index, int value, ArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.AddWithIndex(index, value));
        }

        [TestCaseSource(typeof(DeleteFromEndSource))]
        public void DeleteFromEndTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteFromEnd();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowExcWhenListIsEmptyNegativeTestSource))]
        public void DeleteFromEnd_WhenListIsEmpty_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFromEnd());
        }

        [TestCaseSource(typeof(DeleteFromBeginSource))]
        public void DeleteFromBeginTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteFromBegin();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowExcWhenListIsEmptyNegativeTestSource))]
        public void DeleteFromBegin_WhenListIsEmpty_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFromBegin());
        }

        [TestCaseSource(typeof(DeleteWithIndexSource))]
        public void DeleteWithIndexTest(int index, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteWithIndex(index);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteWithIndexNegativeTestSource))]
        public void DeleteWithIndex_WhenIndexWrong_ShouldThrowException(int index, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteWithIndex(index));
        }

        [TestCaseSource(typeof(ThrowWhenListIsEmptyNegativeTestSource))]
        public void DeleteWithIndex_WhenListIsEmpty_ShouldThrowException(int index, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteWithIndex(index));
        }

        [TestCaseSource(typeof(DeleteFromEndElementsSource))]
        public void DeleteFromEndElementsTest(int count, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteFromEndElements(count);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteWhenCountIsWrongNegativeTestSource))]
        public void DeleteFromEndElements_WhenCountIsWrong_ShouldThrowException(int count, ArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteFromEndElements(count));
        }

        [TestCaseSource(typeof(DeleteFromBeginElementsSource))]
        public void DeleteFromBeginElementsTest(int count, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteFromBeginElements(count);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteWhenCountIsWrongNegativeTestSource))]
        public void DeleteFromBeginElements_WhenCountIsWrong_ShouldThrowException(int count, ArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteFromBeginElements(count));
        }

        [TestCaseSource(typeof(DeleteWithIndexElementsSource))]
        public void DeleteWithIndexElementsTest(int index, int count, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteWithIndexElements(index, count);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteWithIndexElementsNegativeTestSource))]
        public void DeleteWithIndexElements_WhenIndexOrCountIsWrongOrListIsEmpty_ShouldThrowException(int index, int count, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteWithIndexElements(index, count));
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

        [TestCaseSource(typeof(GetValueByIndexNegativeTestSource))]
        public void GetValueByIndex_WhenIndexIsWrong_ShouldThrowException(int index, ArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.GetValueByIndex(index));
        }


        [TestCaseSource(typeof(FindFirstIndexByValueSource))]
        public void FindFirstIndexByValueTest(int value, ArrayList list, int expected)
        {
            int actual = list.FindFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ThrowWhenListIsEmptyNegativeTestSource))]
        public void FindFirstIndexByValue_WhenListIsEmpty_ShouldThrowException(int value, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindFirstIndexByValue(value));
        }

        [TestCaseSource(typeof(ChangeValueByIndexSource))]
        public void ChangeValueByIndexTest(int index, int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.ChangeValueByIndex(index, value);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ChangeValueByIndexNegativeTestSource))]
        public void ChangeValueByIndex_WhenIndexIsWrongOrListIsEmpty_ShouldThrowException(int index, int value, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.ChangeValueByIndex(index, value));
        }

        [TestCaseSource(typeof(ReverseArraySource))]
        public void ReverseArrayTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.ReverseArray();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowExcWhenListIsEmptyNegativeTestSource))]
        public void ReverseArray_WhenListIsEmpty_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.ReverseArray());
        }


        [TestCaseSource(typeof(FindMaxElementSource))]
        public void FindMaxElementTest(ArrayList list, int expected)
        {
            int actual = list.FindMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ThrowExcWhenListIsEmptyNegativeTestSource))]
        public void FindMaxElement_WhenListIsEmpty_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindMaxElement());
        }

        [TestCaseSource(typeof(FindMinElementSource))]
        public void FindMinElementTest(ArrayList list, int expected)
        {
            int actual = list.FindMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ThrowExcWhenListIsEmptyNegativeTestSource))]
        public void FindMinElement_WhenListIsEmpty_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindMinElement());
        }

        [TestCaseSource(typeof(FindIndexOfMaxElementSource))]
        public void FindIndexOfMaxElementTest(ArrayList list, int expected)
        {
            int actual = list.FindIndexOfMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ThrowExcWhenListIsEmptyNegativeTestSource))]
        public void FindIndexOfMaxElement_WhenListIsEmpty_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMaxElement());
        }

        [TestCaseSource(typeof(FindIndexOfMinElementSource))]
        public void FindIndexOfMinElementTest(ArrayList list, int expected)
        {
            int actual = list.FindIndexOfMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ThrowExcWhenListIsEmptyNegativeTestSource))]
        public void FindIndexOfMinElement_WhenListIsEmpty_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMinElement());
        }

        [TestCaseSource(typeof(SortInAscendingSource))]
        public void SortInAscendingTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.SortInAscending();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowExcWhenListIsEmptyNegativeTestSource))]
        public void SortInAscending_WhenListIsEmpty_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.SortInAscending());
        }

        [TestCaseSource(typeof(SortInDescendingSource))]
        public void SortInDescendingTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.SortInDescending();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowExcWhenListIsEmptyNegativeTestSource))]
        public void SortInDescending_WhenListIsEmpty_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.SortInDescending());
        }

        [TestCaseSource(typeof(DeleteFirstByValueSource))]
        public void DeleteFirstByValueTest(int value, ArrayList list, int expected)
        {
            int actual = list.DeleteFirstByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ThrowWhenListIsEmptyNegativeTestSource))]
        public void DeleteFirstByValue_WhenListIsEmpty_ShouldThrowException(int value, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFirstByValue(value));
        }

        [TestCaseSource(typeof(DeleteElementsByValueSource))]
        public void DeleteElementsByValueTest(int value, ArrayList list, int expected)
        {
            int actual = list.DeleteElementsByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ThrowWhenListIsEmptyNegativeTestSource))]
        public void DeleteElementsByValue_WhenListIsEmpty_ShouldThrowException(int value, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteElementsByValue(value));
        }

        [TestCaseSource(typeof(AddListToEndTestSource))]
        public void AddListToEndTest(ArrayList list, ArrayList addList, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.AddListToEnd(addList);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowNullExceptionNegativeTestSource))]
        public void AddListToEnd_WhenLinkIsNull_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListToEnd(list));
        }

        [TestCaseSource(typeof(AddListToBeginTestSource))]
        public void AddListToBeginTest(ArrayList list, ArrayList addList, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.AddListToBegin(addList);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ThrowNullExceptionNegativeTestSource))]
        public void AddListToBegin_WhenLinkIsNull_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListToBegin(list));
        }
    }
}
