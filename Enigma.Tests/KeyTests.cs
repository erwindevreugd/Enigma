using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enigma.Tests
{
    [TestClass]
    public class KeyTests
    {
        [TestMethod]
        public void Key_CharAToKey_ReturnsKeyA()
        {
            Key expected = Key.A;
            Key actual = (Key)'A';

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void Key_CharaToKey_ReturnsKeyA()
        {
            Key expected = Key.A;
            Key actual = (Key)'a';

            Assert.AreEqual<Key>(expected, actual);
        }
    }
}