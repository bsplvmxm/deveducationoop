﻿using System;

namespace MyLists
{
    public class ArrayList
    {
        public int Length { get; private set; }

        private int[] _array;

        public ArrayList()
        {
            _array = new int[10];
            Length = 0;
        }

        public void AddToEnd(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }

        public void AddToBegin(int value)
        {
            if (Length + 1 >= _array.Length)
            {
                UpSize();
            }
            int index = 0;
            int[] newArray = new int[Length + 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < Length; i++)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
            _array[0] = value;
            Length++;
        }

        public void WriteArray()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }

        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        private void CopyArray(int[] newArray)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
    }
}