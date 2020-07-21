using System;
using Algorithims_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class InOrderStringReversalTests
    {
        [TestMethod]
        public void OneWord()
        {
            var actual = InOrderStringReversal.InOrderReverse("dog");
            var expected = "dog";
            TestUtility.AssertStringsAreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoWords()
        {
            var actual = InOrderStringReversal.InOrderReverse("the dog");
            var expected = "dog the";
            TestUtility.AssertStringsAreEqual(expected, actual);
        }

        [TestMethod]
        public void ThreeWords()
        {
            var actual = InOrderStringReversal.InOrderReverse("the dog house");
            var expected = "house dog the";
            TestUtility.AssertStringsAreEqual(expected, actual);
        }

        [TestMethod]
        public void LettersOnly()
        {
            var actual = InOrderStringReversal.InOrderReverse("d 2 S d A d");
            var expected = "d A d S 2 d";
            TestUtility.AssertStringsAreEqual(expected, actual);
        }

        [TestMethod]
        public void NullString()
        {
            var actual = InOrderStringReversal.InOrderReverse(null);
            String expected = null;
            TestUtility.AssertStringsAreEqual(expected, actual);
        }

        [TestMethod]
        public void EmptyString()
        {
            var actual = InOrderStringReversal.InOrderReverse("");
            var expected = "";
            TestUtility.AssertStringsAreEqual(expected, actual);
        }

        [TestMethod]
        public void MultipleSpaces()
        {
            var actual = InOrderStringReversal.InOrderReverse("the  dog   house");
            var expected = "house   dog  the";
            TestUtility.AssertStringsAreEqual(expected, actual);
        }

        [TestMethod]
        public void OnlySpaces()
        {
            var actual = InOrderStringReversal.InOrderReverse("    ");
            var expected = "    ";
            TestUtility.AssertStringsAreEqual(expected, actual);
        }

        [TestMethod]
        public void StartsWithSpace()
        {
            var actual = InOrderStringReversal.InOrderReverse(" the dog house");
            var expected = "house dog the ";
            TestUtility.AssertStringsAreEqual(expected, actual);
        }

        [TestMethod]
        public void WithTabs()
        {
            var actual = InOrderStringReversal.InOrderReverse("the\tdog house");
            var expected = "house the\tdog";
            TestUtility.AssertStringsAreEqual(expected, actual);
        }

        [TestMethod]
        public void WithLineBreaks()
        {
            var actual = InOrderStringReversal.InOrderReverse("the\ndog house");
            var expected = "house the\ndog";
            TestUtility.AssertStringsAreEqual(expected, actual);
        }
    }
}
