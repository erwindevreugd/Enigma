using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enigma.Tests
{
    [TestClass]
    public class PlugBoardTests
    {
        public static SwappingTable GetSwappingTable()
        {
            return new SwappingTable();
        }

        public static PlugBoard GetPlugBoard()
        {
            var swappingTable = GetSwappingTable();

            return new PlugBoard(swappingTable);
        }

        public static PlugBoard GetPlugBoard(SwappingTable swappingTable)
        {
            return new PlugBoard(swappingTable);
        }

        [TestMethod]
        public void PlugBoard_NoSwaps_EncodeA_ReturnsA()
        {
            var plugBoard = GetPlugBoard();

            Key expected = Key.A;
            Key actual = plugBoard.Encode(Key.A);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void PlugBoard_ABSwapped_EncodeA_ReturnsB()
        {
            var swappingTable = GetSwappingTable();
            swappingTable.Swap(Key.A, Key.B);
            var plugBoard = GetPlugBoard(swappingTable);

            Key expected = Key.B;
            Key actual = plugBoard.Encode(Key.A);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void PlugBoard_ABSwapped_EncodeC_ReturnsC()
        {
            var swappingTable = GetSwappingTable();
            swappingTable.Swap(Key.A, Key.B);
            var plugBoard = GetPlugBoard(swappingTable);

            Key expected = Key.C;
            Key actual = plugBoard.Encode(Key.C);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void PlugBoard_EncodeNullKey_ReturnsNullKey()
        {
            var plugBoard = GetPlugBoard();

            Key expected = Key.Null;
            Key actual = plugBoard.Encode(Key.Null);

            Assert.AreEqual<Key>(expected, actual);
        }
    }
}