using System;

namespace MyLists
{
    public class ArrayList
    {
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        public int Length { get; private set; }

        private int[] _array;

        public ArrayList()
        {
            _array = new int[10];
            Length = 0;
        }

        public ArrayList(int value)
        {
            _array = new int[10];
            _array[0] = value;
            Length = 1;
        }

        public ArrayList(int[] array)
        {
            if (array==null || array.Length==0)
            {
                _array = new int[10];
                Length = 0;
            }
            else
            {
                _array = array;
                Length = array.Length;
                UpSize();
            }
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
            if (index > Length || index < 0)
            {
                throw new ArgumentException("index > length or < 0");
            }

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
            if (Length == 0)
            {
                throw new Exception("Length of array == 0, nthng to delete");
            }        
            Length--;
        }

        public void DeleteFromBegin()
        {
            if (Length == 0)
            {
                throw new Exception("Length of array == 0, nthng to delete");
            }
            MoveLeft();
            Length--;
        }

        public void DeleteWithIndex(int index)
        {
            if (Length == 0 || index > Length || index < 0)
            {
                throw new Exception("Length of array == 0, nthng to delete or index is wrong");
            }
            MoveLeft(index);
            Length--;
        }

        public void DeleteFromEndElements(int count)
        {
            if (Length < count)
            {
                throw new ArgumentException("Length of array < count numbers that u want to delete");
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
                throw new ArgumentException("Length of array < count numbers that u want to delete");
            }

            for (int i = 0; i < count; i++)
            {
                MoveLeft();
                Length--;
            }

        }

        public void DeleteWithIndexElements(int index, int count)
        {
            if (Length < count || Length == 0 || index > Length || index < 0)
            {
                throw new Exception("Length of array < count numbers that u want to delete or < 1 or index is wrong");
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
                throw new ArgumentException("index is wrong");
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
            if (index > Length || index < 0)
            {
                throw new Exception("Length must be higher than index");
            }    

            _array[index] = value;
        }

        public void ReverseArray()
        {
            if (Length == 0)
            {
                throw new Exception("Length must be > 0, nthng to find");
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
            if (Length == 0)
            {
                throw new Exception("Length must be > 0, nthng to find");
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
            if (Length == 0)
            {
                throw new Exception("Length must be > 0, nthng to find");
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

        public int FindIndexOfMaxElement()
        {
            if (Length == 0)
            {
                throw new Exception("Length must be > 0, nthng to find");
            }

            int max = _array[0];
            int indexMax = 0;

            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                    indexMax = i;
                }
            }
            return indexMax;
        }

        public int FindIndexOfMinElement()
        {
            if (Length == 0)
            {
                throw new Exception("Length must be > 0, nthng to find");
            }

            int min = _array[0];
            int indexMin = 0;

            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                    indexMin = i;
                }
            }
            return indexMin;
        }

        public void SortInAscending()
        {
            if (Length == 0)
            {
                throw new Exception("Length must be > 0, nthng to find");
            }
         
            int tmp;

            for (int i = 0; i < Length; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        tmp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
        }

        public void SortInDescending()
        {
            if (Length == 0)
            {
                throw new Exception("Length must be > 0, nthng to find");
            }

            int tmp;

            for (int i = 0; i < Length - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[j] > _array[max])
                    {
                        max = j;
                    }
                }
                tmp = _array[max];
                _array[max] = _array[i];
                _array[i] = tmp;
            }
        }

        public int DeleteFirstByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("Length of array == 0, nthng to delete");
            }

            int firstIndex = 0;

            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    firstIndex = i;
                    DeleteWithIndex(firstIndex);
                    break;
                }
                else
                {
                    firstIndex = -1;
                }
            }
            return firstIndex;
        }

        public int DeleteElementsByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("Length of array == 0, nthng to delete");
            }

            int count = 0;

            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i - count] = _array[i];
                }
            }
            Length -= count;

            return count;
        }

        public void AddListToEnd(ArrayList list)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }

            AddList(list);
        }

        public void AddListToBegin(ArrayList list)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }

            AddListWithIndex(list);
        }

        public void AddListByIndex(ArrayList list, int index)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }
            if (index < 0 || index > Length)
            {
                throw new ArgumentException("index is wrong");
            }

            AddListWithIndex(list, index);
        }

        public void WriteArray()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            string str = "";

            for (int i = 0; i < Length; i++)
            {
                str += $"{_array[i]} ";
            }

            return str;
        }

        public override bool Equals(object obj)
        {
            bool isEqual = true;

            if (obj == null || !(obj is ArrayList))
            {
                isEqual = false;
            }
            else
            {
                ArrayList list = (ArrayList)obj;

                if (list.Length != this.Length)
                {
                    isEqual = false;
                }
                else
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            isEqual = false;
                        }
                    }
                }
            }
            return isEqual;
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

        private void AddListWithIndex(ArrayList list, int index = 0)
        {
            int[] newArray = new int[list.Length + _array.Length];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < list.Length + index; i++)
            {
                newArray[i] = list[i - index];
            }
            for (int i = index + list.Length; i < newArray.Length; i++)
            {
                newArray[i] = _array[i - list.Length];
            }
            Length += list.Length;
            _array = newArray;
        }

        private void AddList(ArrayList list)
        {
            int[] newArray = new int[list.Length + this.Length];
            for (int i = 0; i < this.Length; i++)
            {
                newArray[i] = this[i];
            }
            for (int i = this.Length; i < newArray.Length; i++)
            {
                newArray[i] = list[i - Length];
            }
            Length += list.Length;
            _array = newArray;
        }
    }
}
