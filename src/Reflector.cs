namespace Enigma
{
    public sealed class Reflector
    {
        private readonly ReflectorEncodingTable encodingTable;

        public Reflector(ReflectorEncodingTable encodingTable)
        {
            this.encodingTable = encodingTable;
        }

        public Key Encode(Key key)
        {
            Key encodedKey = this.encodingTable.Lookup(key);

            return encodedKey;
        }
    }
}