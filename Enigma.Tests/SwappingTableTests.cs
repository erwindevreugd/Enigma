using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enigma.Tests
{
    [TestClass]
    public class SwappingTableTests
    {
        public static SwappingTable GetSwappingTable()
        {
            return new SwappingTable();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SwappingTable_SwappingIdenticalKey_ThrowsException()
        {
            var swappingTable = GetSwappingTable();
            swappingTable.Swap(Key.A, Key.A);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SwappingTable_SwappingNullKeyForKey_ThrowsException()
        {
            var swappingTable = GetSwappingTable();
            swappingTable.Swap(Key.Null, Key.A);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SwappingTable_SwappingKeyForNullKey_ThrowsException()
        {
            var swappingTable = GetSwappingTable();
            swappingTable.Swap(Key.A, Key.Null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SwappingTable_DoubleSwap_ThrowsException()
        {
            var swappingTable = GetSwappingTable();
            swappingTable.Swap(Key.A, Key.B);
            swappingTable.Swap(Key.A, Key.B);
        }
    }
}