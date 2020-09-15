using System;
using System.Collections.Generic;

namespace MyListNamespace
{
    public class MyList<T>
    {
        private const int initialCapacity = 50;
        private T[] data;
        private int resize = 1;

        public MyList()
        {

            this.data = new T[initialCapacity];
            this.Count = 0;
        }

        public int Count { get; private set; }
        public int Capacity { get { return initialCapacity * resize; } }
        public T this[int index]
        {
            get
            {
                if (index < this.Count)
                    return data[index];
                else throw new IndexOutOfRangeException();
            }
            set { this.data[index] = value; }
        }
        public void Add(T item)
        {
            if (this.Count == initialCapacity * resize)
            {
                resize++;
                Array.Resize(ref this.data, initialCapacity * resize);
            }
            this.data[this.Count] = item;
            this.Count++;

        }
        public void Clear()
        {
            Array.Clear(this.data, 0, this.Count);
            if (this.Count > initialCapacity) Array.Resize(ref this.data, initialCapacity);
            this.Count = 0;
            resize = 1;
        }

        public bool Contains(T item)
        {
            foreach (T data in this.data)
            {
                if (EqualityComparer<T>.Default.Equals(data, item)) { return true; }
            }
            return false;
        }
        public int IndexOf(T item, int startIndex)
        {
            for (int i = startIndex; i < this.Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(this.data[i], item)) { return i; }
            }
            return -1;
        }

        public void Insert(T item, int index)
        {
            if (this.Count == initialCapacity * resize)
            {
                resize++;
                Array.Resize(ref this.data, initialCapacity * resize);
            }
            for (int i = this.Count; i > index; i--)
            {
                this.data[i] = this.data[i - 1];
            }
            this.data[index] = item;
            this.Count++;

        }

        public bool Remove(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(this.data[i], item))
                {
                    for (int j = i; j < this.Count - 1; j++)
                    {
                        this.data[j] = this.data[j + 1];
                    }
                    this.data[this.Count - 1] = default(T);
                    this.Count--;

                    if (this.Count == initialCapacity * resize - initialCapacity)
                    { resize--; Array.Resize(ref this.data, initialCapacity * resize); }
                    return true;
                }
            }
            return false;
        }
        public MyList<T> FindAll(Predicate<T> match)
        {
            MyList<T> returnList = new MyList<T>();
            foreach (T data in this.data)
            {
                if (match(data))
                    returnList.Add(data);
            }
            return returnList;
        }
    }
}

