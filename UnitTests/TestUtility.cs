using Algorithims_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    internal static class TestUtility
    {
        public static void AssertListsAreEqual(List<int> expected, List<int> actual)
        {
            Assert.IsFalse(expected == null || actual == null || expected.Count != actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i], $"Unequal values at index {i} of the list. Expected {expected[i]} but recieved {actual[i]}");
            }
        }

        internal static void AssertLinkedListsAreEqual(Algorithims_Practice.LinkedList<int> expected, Algorithims_Practice.LinkedList<int> actual)
        {
            Assert.IsFalse(expected == null || actual == null || expected.GetLength() != actual.GetLength());
            for (var i = 0; i < expected.GetLength(); i++)
            {
                Assert.AreEqual(expected.Get(i).Value, actual.Get(i).Value, $"Unequal values at index {i} of the list. Expected {expected.Get(i).Value} but recieved {actual.Get(i).Value}");
            }
        }

        public static void AssertStringsAreEqual(String expected, String actual)
        {
            Assert.IsTrue((expected == null && actual == null) || !(expected == null || actual == null));
            Assert.IsTrue(String.Equals(expected, actual));
            
        }

        public static void AssertArraysAreEqual(int[] expected, int[] actual)
        {
            Assert.IsFalse(expected == null || actual == null || expected.Length != actual.Length);
            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], $"Unequal values at index {i} of the array. Expected {expected[i]} but recieved {actual[i]}");
            }
        }
    }
}
