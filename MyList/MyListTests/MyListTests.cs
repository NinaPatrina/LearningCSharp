using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyListNamespace;
using System;

namespace MyListTests
{
    [TestClass]
    public class MyListTests
    {
        [TestMethod]
        public void ConstructorWorks()
        {
            var list = new MyList<object>();
            Assert.AreEqual(0, list.Count);
            Assert.IsTrue(list.Capacity > 0);
        }
        

        [TestMethod]
        public void AddWorks()
        {
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.AreEqual(3, list.Count);
            Assert.AreEqual(2, list[1]);
        }

        [TestMethod]
        public void Boundaries_are_checked()
        {
            var list = new MyList<int>();

            try
            {
                int item = list[0];
                Assert.Fail("should not get here");
            }
            catch (IndexOutOfRangeException)
            {
                //Exception is expected here
            }
        }

        [TestMethod]
        public void ListExpantionWorks()
        {
            var list = new MyList<int>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }
            Assert.AreEqual(1000, list.Count);
            Assert.IsTrue(list.Capacity >= 1000);
            Assert.AreEqual(0, list[0]);
            Assert.AreEqual(999, list[999]);
        }

        [TestMethod]
        public void ClearWorks()
        {
            var list = new MyList<int>();
            list.Add(4);
            list.Add(6);
            list.Clear();
            try
            {
                int item = list[0];
                Assert.Fail("should not get here");
            }
            catch (IndexOutOfRangeException)
            {
                //Exception is expected here
            }
        }
        [TestMethod]
        public void ContainsWorks()
        {
            var list = new MyList<int>();
            list.Add(4);
            list.Add(6);
            Assert.IsTrue(list.Contains(6));
        }

        [TestMethod]
        public void IndexOfWorks()
        {
            var list = new MyList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            Assert.AreEqual(5, list.IndexOf(5, 0));

        }
        [TestMethod]
        public void RemoveWorks()
        {
            var list = new MyList<int>();
            for (int i = 0; i < 51; i++)
            {
                list.Add(i);
            }
            list.Remove(6);
            Assert.IsFalse(list.Contains(6));
            Assert.AreEqual(49, list.IndexOf(50, 0));
            Assert.AreEqual(50, list.Capacity);
            Assert.IsTrue(list.Remove(36));
            Assert.IsFalse(list.Remove(56));
        }
        [TestMethod]
        public void InsertWorks()
        {
            var list = new MyList<int>();
            for (int i = 0; i < 50; i++)
            {
                list.Add(i);
            }
            list.Insert(70, 2);
            Assert.AreEqual(51, list.Count);
            Assert.IsTrue(list.Contains(70));
            Assert.AreEqual(2, list.IndexOf(70, 0));
            Assert.AreEqual(100, list.Capacity);
        }

        [TestMethod]
        public void PredicateWorks()
        {
            var list = new MyList<int>();
            for (int i = 0; i < 150; i++)
            {
                list.Add(i);
            }
            var listOfPredicates = new MyList<int>();
            listOfPredicates = list.FindAll(x => x > 20);

            Assert.AreEqual(129, listOfPredicates.Count);
            Assert.IsTrue(listOfPredicates.Contains(21));
            Assert.IsFalse(listOfPredicates.Contains(10));
            Assert.AreEqual(0, listOfPredicates.IndexOf(21, 0));
            Assert.AreEqual(150, list.Capacity);
        }
    }
}

