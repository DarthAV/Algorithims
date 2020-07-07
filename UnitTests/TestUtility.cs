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
                Assert.AreEqual(expected[i], actual[i], $"Unequal values at index {i} of the list");
            }
        }
    }
}
