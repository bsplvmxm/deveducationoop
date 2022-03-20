using System;

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
            if (Length + 1>= _array.Length)
            {
                UpSize();
            }
            MoveRight();

            _array[0] = value;
            Length++;
        }

        public void AddWithIndex(int index, int value)
        {
            if (Length + 1 >= _array.Length)
            {
                UpSize();
            }
            MoveRight(index);

            _array[index] = value;
            Length++;
        }

        public void DeleteFromEnd()
        {
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, nthng to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DownSize();
            }
            Length--;
        }

        public void DeleteFromBegin()
        {
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, nthng to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DownSize();
            }
            MoveLeft();

            Length--;
        }

        public void DeleteWithIndex(int index)
        {
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, nthng to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DownSize();
            }
            MoveLeft(index);

            Length--;
        }

        public void DeleteFromEndElements(int count)
        {
            if (Length < count)
            {
                throw new Exception("Length of array < count numbers that u want to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DownSize();
            }
            for (int i = 0; i < count; i++)
            {
                Length--;
            }
        }

        public void DeleteFromBeginElements(int count)
        {
            if (Length < count)
            {
                throw new Exception("Length of array < count numbers that u want to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DownSize();
            }
            for (int i = 0; i < count; i++)
            {
                MoveLeft();
                Length--;
            }

        }

        public void DeleteWithIndexElements(int index, int count)
        {
            if (Length < count || Length < 1)
            {
                throw new Exception("Length of array < count numbers that u want to delete or < 1 => nthng delete");
            }
            if (Length <= _array.Length / 2)
            {
                DownSize();
            }
            for (int i = 0; i < count; i++)
            {
                MoveLeft(index);
                Length--;
            }
        }
        public int GetLength()
        {
            return Length;
        }

        public int GetValueByIndex(int index)
        {
            if (index < 0 || index > Length)
            {
                throw new Exception("index must be >=0 and < Length");
            }
            return _array[index];
        }

        public int FindFirstIndexByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("Length of array == 0, nthng to search");
            }

            int firstIndex = 0;

            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    firstIndex = i;
                    break;
                }
                else
                {
                    firstIndex = -1;
                }
            }
            return firstIndex;
        }

        public void ChangeValueByIndex(int index, int value)
        {
            if (Length == 0)
            {
                throw new Exception("Length of array == 0, nthng to change");
            }
            if (index > Length)
            {
                throw new Exception("Length must be higher than index");
            }    

            _array[index] = value;
        }

        public void ReverseArray()
        {
            if (Length < 1)
            {
                throw new Exception("Length must be > 0");
            }

            int[] newArray = new int[Length];

            for (int i = 0; i < Length; i++)
            {
                newArray[i] += _array[Length - 1 - i];
            }

            _array = newArray;
        }

        public int FindMaxElement()
        {
            if (Length < 1)
            {
                throw new Exception("Length must be > 0");
            }

            int max = _array[0];

            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }

        public int FindMinElement()
        {
            if (Length < 1)
            {
                throw new Exception("Length must be > 0");
            }

            int min = _array[0];

            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
            return min;
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
            CopyArray(newArray);
        }

        private void DownSize()
        {
            int newLength = (int)(_array.Length / 3);
            int[] newArray = new int[newLength];
            CopyArray(newArray);
        }

        private void CopyArray(int[] newArray)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        private void MoveRight(int index = 0)
        {
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
        }

        private void MoveLeft(int index = 0)
        {
            int[] newArray = new int[Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < Length - 1; i++)
            {
                newArray[i] = _array[i + 1];
            }
            _array = newArray;
        }
    }
}
