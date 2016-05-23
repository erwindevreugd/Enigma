using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enigma.Tests
{
    [TestClass]
    public class ReflectorTests
    {
        public static ReflectorEncodingTable GetEncodingTable()
        {
            return ReflectorEncodingTableTables.UKW;
        }

        public static Reflector GetReflector()
        {
            var encodingTable = GetEncodingTable();

            return new Reflector(encodingTable);
        }

        [TestMethod]
        public void Reflector_EncodeKeyA_ReturnsKeyQ()
        {
            var reflector = GetReflector();

            Key expected = Key.Q;
            Key actual = reflector.Encode(Key.A);

            Assert.AreEqual<Key>(expected, actual);
        }
    }
}