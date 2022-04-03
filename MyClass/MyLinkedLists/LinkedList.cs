using System;

namespace MyLinkedLists
{
    public class LinkedList
    {
        private Node _root;

        private Node _tail;

        public int this[int index]
        {
            get
            {
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                return crnt.Value;
            }

            set
            {

            }
        }

        public int Length
        {
            get
            {
                int count = 0;
                Node crnt = _root;

                while (crnt != null)
                {
                    crnt = crnt.Next;
                    count++;
                }

                return count;
            }

            private set
            {

            }
        }

        public LinkedList()
        {
            _root = null;
            _tail = null;
        }

        public LinkedList(int value)
        {
            _root = new Node(value);
            _tail = _root;
        }

        public LinkedList(int[] values)
        {
            if (values.Length == 0)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                _root = new Node(values[0]);
                _tail = _root;

                for (int i = 1; i < values.Length; i++)
                {
                    AddToEnd(values[i]);
                }
            }
        }

        public void AddToEnd(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
        }

        public void AddToBegin(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                Node crnt = _root;
                _root = new Node(value);
                _root.Next = crnt;
            }
        }

        public void AddByIndex(int value, int index)
        {
            if (index < 0 || index > Length)
            {
                throw new ArgumentException("index is wrong");
            }
            else if (index == 0)
            {
                AddToBegin(value);
            }
            else
            {
                Node prev = GetNodeByIndex(index - 1);
                Node next = GetNodeByIndex(index);
                Node newNode = new Node(value);

                prev.Next = newNode;
                newNode.Next = next;
            }
        }

        public void DeleteFromEnd()
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to delete");
            }
            if (Length == 1)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                Node prevLast = GetNodeByIndex(Length - 2);
                prevLast.Next = null;
                _tail = prevLast;
            }
        }

        public void DeleteFromBegin()
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to delete");
            }

            _root = _root.Next;
        }

        public void DeleteByIndex(int index)
        {
            if (index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            else if (index == 0)
            {
                _root = _root.Next;
            }
            else
            {
                Node prevDel = GetNodeByIndex(index - 1);
                Node nextDel = GetNodeByIndex(index + 1);
                prevDel.Next = nextDel;
            }
        }

        public void DeleteElementsFromEnd(int count)
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to delete");
            }
            if (count > Length)
            {
                throw new ArgumentException("count is wrong, count mustn't be higher then Length");
            }
            if (Length == 1)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Node prevLast = GetNodeByIndex(Length - 2);
                    prevLast.Next = null;
                    _tail = prevLast;
                }
            }
        }

        public void DeleteElementsFromBegin(int count)
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to delete");
            }
            if (count > Length)
            {
                throw new ArgumentException("count is wrong, count mustn't be higher then Length");
            }
            for (int i = 0; i < count; i++)
            {
                _root = _root.Next;
            }
        }

        public void DeleteElementsByIndex(int count, int index)
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to delete");
            }
            if (index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            Node prevDel = GetNodeByIndex(index - 1);
            Node nextDel = GetNodeByIndex(index + count);

            if (index == 0)
            {
                _root = nextDel;
            }
            else
            {
                prevDel.Next = nextDel;
            }
            _tail = GetNodeByIndex(Length - 1);
        }

        public int FindFirstIndexByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to find");
            }

            int firstIndex = -1;
            Node crnt = _root;

            for (int i = 0; i < Length; i++)
            {
                if (crnt.Value == value)
                {
                    firstIndex = i;
                    break;
                }

                crnt = crnt.Next;
            }

            return firstIndex;
        }

        public void ChangeValueByIndex(int index, int value)
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to change");
            }
            if (index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            Node editValue = GetNodeByIndex(index);
            editValue.Value = value;          
        }

        public void Reverse()
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to reverse");
            }

            Node crnt = _root;
            Node tmp;

            while (crnt.Next != null)
            {
                tmp = crnt.Next;
                crnt.Next = tmp.Next;
                tmp.Next = _root;
                _root = tmp;
            }
            _tail = crnt;
        }

        public int FindMaxElement()
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to find");
            }

            Node crnt = _root;
            int max = crnt.Value;

            while (crnt != null)
            {
                if (crnt.Value > max)
                {
                    max = crnt.Value;
                }
                crnt = crnt.Next;
            }

            return max;
        }

        public int FindMinElement()
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to find");
            }

            Node crnt = _root;
            int min = crnt.Value;

            while (crnt != null)
            {
                if (crnt.Value < min)
                {
                    min = crnt.Value;
                }
                crnt = crnt.Next;
            }

            return min;
        }

        public int FindIndexOfMaxElement()
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to find");
            }

            Node crnt = _root;
            int max = crnt.Value;
            int index = 0;
            int indexOfMax = 0;

            while (crnt != null)
            {
                if (crnt.Value > max)
                {
                    max = crnt.Value;
                    indexOfMax = index;
                }
                index++;
                crnt = crnt.Next;
            }

            return indexOfMax;
        }

        public int FindIndexOfMinElement()
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to find");
            }

            Node crnt = _root;
            int min = crnt.Value;
            int index = 0;
            int indexOfMin = 0;

            while (crnt != null)
            {
                if (crnt.Value < min)
                {
                    min = crnt.Value;
                    indexOfMin = index;
                }
                index++;
                crnt = crnt.Next;
            }

            return indexOfMin;
        }

        public void SortInAscending()
        {
            int l = Length;
            Node crnt;
            Node prev;

            for (int i = l - 2; i >= 0; i--)
            {
                if (i == 0)
                {
                    crnt = _root;

                    if (crnt.Next != null && crnt.Value > crnt.Next.Value)
                    {
                        _root = crnt.Next;
                        crnt.Next = _root.Next;
                        _root.Next = crnt;
                    }
                    prev = _root;
                }
                else
                {
                    prev = GetNodeByIndex(i - 1);
                    crnt = prev.Next;
                }

                while (crnt.Next != null && crnt.Value > crnt.Next.Value)
                {
                    prev.Next = crnt.Next;
                    crnt.Next = prev.Next.Next;
                    prev.Next.Next = crnt;

                    prev = prev.Next;
                }
            }

            _tail = GetNodeByIndex(l - 1);
        }

        public void SortInDescending()
        {
            int l = Length;
            Node crnt;
            Node prev;

            for (int i = l - 2; i >= 0; i--)
            {
                if (i == 0)
                {
                    crnt = _root;

                    if (crnt.Next != null && crnt.Value < crnt.Next.Value)
                    {
                        _root = crnt.Next;
                        crnt.Next = _root.Next;
                        _root.Next = crnt;
                    }
                    prev = _root;
                }
                else
                {
                    prev = GetNodeByIndex(i - 1);
                    crnt = prev.Next;
                }

                while (crnt.Next != null && crnt.Value < crnt.Next.Value)
                {
                    prev.Next = crnt.Next;
                    crnt.Next = prev.Next.Next;
                    prev.Next.Next = crnt;

                    prev = prev.Next;
                }
            }

            _tail = GetNodeByIndex(l - 1);
        }

        public int DeleteFirstByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to delete");
            }

            Node crnt = _root;

            for (int i = 0; i < Length; i++)
            {
                int index = i;

                if (crnt.Value == value)
                {
                    DeleteByIndex(index);
                    return index;
                }
                crnt = crnt.Next;
            }
            _tail = GetNodeByIndex(Length - 1);
            return -1;
        }

        public int DeleteElementsByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to delete");
            }

            Node crnt = _root;

            int count = 0;
            int index = 0;

            while (crnt != null)
            {
                index = FindFirstIndexByValue(value);

                if (index != -1)
                {
                    DeleteByIndex(index);
                    count++;
                }
                
                crnt = crnt.Next;
            }
            _tail = GetNodeByIndex(Length - 1);
            return count;
        }

        public override string ToString()
        {
            string s = "";
            Node crnt = _root;

            while (crnt != null)
            {
                s += $"{crnt.Value} ";
                crnt = crnt.Next;
            }

            return s;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is LinkedList))
            {
                return false;
            }

            LinkedList list = (LinkedList)obj;

            if (list.Length != this.Length)
            {
                return false;
            }

            Node thisCrnt = this._root;
            Node listCrnt = list._root;

            while (thisCrnt != null)
            {
                if (thisCrnt.Value != listCrnt.Value)
                {
                    return false;
                }

                thisCrnt = thisCrnt.Next;
                listCrnt = listCrnt.Next;
            }

            return true;
        }

        private Node GetNodeByIndex(int index)
        {
            Node crnt = _root;

            for (int i = 1; i <= index; i++)
            {
                crnt = crnt.Next;
            }

            return crnt;
        }
    }
}
