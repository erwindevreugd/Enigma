using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enigma.Tests
{
    [TestClass]
    public class EncodingTableTests
    {
        public static EncodingTable GetEncodingTable()
        {
            return new EncodingTable();
        }

        [TestMethod]
        public void EncodingTable_CountEqualsEntryCount()
        {
            var encodingTable = GetEncodingTable();

            encodingTable.Add(Key.A, Key.B);

            int expected = 1;
            int actual = encodingTable.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EncodingTable_IsSynchronizedAfterConstruction()
        {
            var encodingTable = GetEncodingTable();

            bool expected = true;
            bool actual = encodingTable.IsSynchronized;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EncodingTable_IsSynchronizedAfterAdding()
        {
            var encodingTable = GetEncodingTable();

            encodingTable.Add(Key.A, Key.B);

            bool expected = true;
            bool actual = encodingTable.IsSynchronized;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EncodingTable_GetInputKeyAtInvalidIndex_ReturnsNullKey()
        {
            var encodingTable = GetEncodingTable();

            Key expected = Key.Null;
            Key actual = encodingTable.GetInputKeyAtIndex(0);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void EncodingTable_GetOutputKeyAtInvalidIndex_ReturnsNullKey()
        {
            var encodingTable = GetEncodingTable();

            Key expected = Key.Null;
            Key actual = encodingTable.GetOutputKeyAtIndex(0);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void EncodingTable_GetInputKeyAtValidIndex_ReturnsKey()
        {
            var encodingTable = GetEncodingTable();
            encodingTable.Add(Key.A, Key.B);

            Key expected = Key.A;
            Key actual = encodingTable.GetInputKeyAtIndex(0);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void EncodingTable_GetOutputKeyAtValidIndex_ReturnsKey()
        {
            var encodingTable = GetEncodingTable();
            encodingTable.Add(Key.A, Key.B);

            Key expected = Key.B;
            Key actual = encodingTable.GetOutputKeyAtIndex(0);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void EncodingTable_GetIndexOfInputKey_ReturnsCorrectIndex()
        {
            var encodingTable = GetEncodingTable();
            encodingTable.Add(Key.A, Key.B);

            int expected = 0;
            int actual = encodingTable.GetIndexOfInputKey(Key.A);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EncodingTable_GetIndexOfOutputKey_ReturnsCorrectIndex()
        {
            var encodingTable = GetEncodingTable();
            encodingTable.Add(Key.A, Key.B);

            int expected = 0;
            int actual = encodingTable.GetIndexOfOutputKey(Key.B);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EncodingTable_GetIndexOfInvalidInputKey_ReturnsMinus1()
        {
            var encodingTable = GetEncodingTable();

            int expected = -1;
            int actual = encodingTable.GetIndexOfInputKey(Key.A);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EncodingTable_GetIndexOfInvalidOutputKey_ReturnsMinus1()
        {
            var encodingTable = GetEncodingTable();

            int expected = -1;
            int actual = encodingTable.GetIndexOfOutputKey(Key.B);

            Assert.AreEqual(expected, actual);
        }
    }
}