using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enigma.Tests
{
    [TestClass]
    public class RotorTests
    {
        public static Rotor InitRotor()
        {
            RotorEncodingTable encodingTable = RotorEncodingTableTables.IC;
            return new Rotor(encodingTable, new Key[] { Key.E }, 0);
        }

        public static Rotor InitRotor(int rotorShift)
        {
            RotorEncodingTable encodingTable = RotorEncodingTableTables.IC;
            return new Rotor(encodingTable, new Key[] { Key.E }, rotorShift);
        }

        [TestMethod]
        public void Rotor_RotorShift0_FaceKey_ReturnsA()
        {
            Rotor rotor = InitRotor(0);

            Key expected = Key.A;
            Key actual = rotor.FaceKey;

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void Rotor_RotorShift1_FaceKey_ReturnsB()
        {
            Rotor rotor = InitRotor(1);

            Key expected = Key.B;
            Key actual = rotor.FaceKey;

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void Rotor_AdvanceIndex_AdvancesCurrentIndexBy1()
        {
            Rotor rotor = InitRotor();

            rotor.AdvanceIndex();

            int expected = 1;
            int actual = rotor.CurrentIndex;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Rotor_Offset0_ForwardEncodeA_ReturnsD()
        {
            Rotor rotor = InitRotor();

            Key expected = Key.D;
            Key actual = rotor.ForwardEncode(Key.A);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void Rotor_Offset0_ForwardEncodeB_ReturnsM()
        {
            Rotor rotor = InitRotor();

            Key expected = Key.M;
            Key actual = rotor.ForwardEncode(Key.B);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void Rotor_RotorShift1_ForwardEncodeA_ReturnsM()
        {
            Rotor rotor = InitRotor(1);

            Key expected = Key.M;
            Key actual = rotor.ForwardEncode(Key.A);

            Assert.AreEqual<Key>(expected, actual);
        }

        [TestMethod]
        public void Rotor_RotorShift1_ForwardEncodeZ_ReturnsD()
        {
            Rotor rotor = InitRotor(1);

            Key expected = Key.D;
            Key actual = rotor.ForwardEncode(Key.Z);

            Assert.AreEqual<Key>(expected, actual);
        }
    }
}