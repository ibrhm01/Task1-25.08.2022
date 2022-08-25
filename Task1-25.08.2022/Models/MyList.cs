using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_25._08._2022.Models
{
    class MyList<T>
    {
        private int _capacity;
        public int Capacity { get { return _capacity; } set { if (value > 0) _capacity = value; } }
        private int _count;
        public int Count { get { return _count; } }
        private T[] _arr;
        public T this[int index]
        {
            get
            {
                if (index < Count) return _arr[index];
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < Count)
                {
                    _arr[index] = value;
                    return;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public MyList()
        {
            Capacity = 1;
            _arr = new T[Capacity];
        }
        public MyList(int Capacity)
        {
            this.Capacity = Capacity;
            _arr = new T[Capacity];
        }

        public void Add(T value)
        {

            if (Count == _arr.Length)
            {
                Array.Resize(ref _arr, _arr.Length + Capacity);
            }
            _count++;
            _arr[Count - 1] = value;


        }
        public void Clear()
        {
            _arr = new T[0];
            _count = 0;
        }
        public bool Exist(T value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_arr[i].Equals(value)) return true;
            }
            return false;
        }
        public bool Remove(T value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_arr[i].Equals(value))
                {
                    for (; i < Count - 1; i++)
                    {
                        _arr[i] = _arr[i + 1];
                    }
                    _count--;
                    return true;
                }
            }
            return false;
        }

        public void Reverse()
        {
            int n = Count - 1;
            for (int i = 0; i < n; i++)
            {
                T temp = _arr[i];
                _arr[i] = _arr[n];
                _arr[n] = temp;
                n--;
            }
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_arr[i].Equals(value)) return i;
            }
            return -1;
        }

        public int LastIndexOf(T value)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                if (_arr[i].Equals(value)) return i;
            }
            return -1;
        }

    }
}
