namespace Enigma
{
    public sealed class Stator
    {
        private readonly StatorEncodingTable encodingTable;

        public Stator(StatorEncodingTable encodingTable)
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