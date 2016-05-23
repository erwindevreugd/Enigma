using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enigma.Tests
{
    [TestClass]
    public class RotorEncodingTableTests
    {
        public static RotorEncodingTable GetEncodingTable()
        {
            return RotorEncodingTableTables.IC;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RotorEncodingTable_AddingLeftNullKey_ThrowsException()
        {
            var encodingTable = new RotorEncodingTable();

            encodingTable.Add(Key.Null, Key.A);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RotorEncodingTable_AddingRightNullKey_ThrowsException()
        {
            var encodingTable = new RotorEncodingTable();

            encodingTable.Add(Key.A, Key.Null);
        }

        [TestMethod]
        public void RotorEncodingtable_ForwardLookupInvalidKey_ReturnsNullKey()
        {
            var encodingTable = new RotorEncodingTable();

            Key expected = Key.Null;
            Key actual = encodingTable.ForwardLookup(Key.A, 0);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void RotorEncodingTable_ReverseLookupInvalidKey_ReturnsNullKey()
        {
            var encodingTable = new RotorEncodingTable();

            Key expected = Key.Null;
            Key actual = encodingTable.ReverseLookup(Key.A, 0);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void RotorEncodingTable_ForwardLookupAWithOffset0_ReturnsD()
        {
            var encodingTable = GetEncodingTable();

            Key expected = Key.D;
            Key actual = encodingTable.ForwardLookup(Key.A, 0);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void RotorEncodingTable_ReverseLookupDWithOffset0_ReturnsD()
        {
            var encodingTable = GetEncodingTable();

            Key expected = Key.A;
            Key actual = encodingTable.ReverseLookup(Key.D, 0);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void RotorEncodingTable_ForwardLookupAWithOffset1_ReturnsM()
        {
            var encodingTable = GetEncodingTable();

            Key expected = Key.M;
            Key actual = encodingTable.ForwardLookup(Key.A, 1);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void RotorEncodingTable_ReverseLookupMWithOffset1_ReturnsA()
        {
            var encodingTable = GetEncodingTable();

            Key expected = Key.A;
            Key actual = encodingTable.ReverseLookup(Key.M, 1);

            Assert.AreEqual<Key>(expected, actual);
        }
    }
}