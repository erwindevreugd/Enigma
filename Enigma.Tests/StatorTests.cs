using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enigma.Tests
{
    [TestClass]
    public class StatorTests
    {
        public static Stator GetABCStator()
        {
            return new Stator(StatorEncodingTableTables.ABC);
        }

        public static Stator GetQWERTZStator()
        {
            return new Stator(StatorEncodingTableTables.QWERTZ);
        }

        [TestMethod]
        public void Stator_ABCEncodeA_ReturnsA()
        {
            var stator = GetABCStator();

            Key expected = Key.A;
            Key actual = stator.Encode(Key.A);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void Stator_QWERTZEncodeA_ReturnsQ()
        {
            var stator = GetQWERTZStator();

            Key expected = Key.Q;
            Key actual = stator.Encode(Key.A);

            Assert.AreEqual<Key>(expected, actual);
        }
    }
}