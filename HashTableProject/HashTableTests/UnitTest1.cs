using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTableProject;
using System;
using System.Collections.Generic;

namespace HashTableTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorWorks()
        {
            var h = new HashTable<int>();
            h.Add("One", 1);
            Assert.IsTrue(h.KeyExist("One"));

            //h["two"] = 2;
        }

        [TestMethod]
        public void Key_is_exist()
        {
            var h = new HashTable<int>();
            h.Add("One", 1);
            try
            {
                h["One"]=3;
                Assert.Fail("should not get here");
            }
             catch (KeyNotFoundException)
            {
                //Exception is expected here
            }
        }
    }
}
