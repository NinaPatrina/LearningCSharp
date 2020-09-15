using System;
using System.Collections.Generic;

namespace HashTableProject
{
    public class HashTable<T>
    {
        private const int initialCapacity = 10;
        public T[] data;
        public string[] keys;

        public HashTable()
        {
            this.keys = new string[initialCapacity];
        }
        public T this[string key]
        {
            get
            {
                foreach (string keys in this.keys)
                {
                    if (keys == key) return this[key];
                }
                throw new KeyNotFoundException();
            }
            set { this[key] = value; }
        }

        public void Add(string key, T value)
        {
            int hash = key.GetHashCode();
            int index = Math.Abs(hash % this.keys.Length);
            this.data[index] = value;
        }

        public bool KeyExist(string key)
        {
            foreach (string keys in this.keys)
            {
                if (keys == key) return true;
            }
            return false;
        }

        //T[] data { get; }
        //string[] key { get; }



        //public void Add(string key, LinkedList<T> value)
        //{
        //    int hashCode = key.GetHashCode();
        //    int index = hashCode % value.Count;
        //    var list = this.data;
        //    list.AddFirst(index);
        //    list.AddAfter(list.First, key);
        //    list.AddAfter(list.First.Next, value);
        //}         
    }
}
