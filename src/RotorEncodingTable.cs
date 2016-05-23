namespace Enigma
{
    public class RotorEncodingTable : EncodingTable
    {
        public RotorEncodingTable()
        {
        }

        public int GetKeyOffsetPosition(Key key)
        {
            return this.inputKeys.IndexOf(key);
        }

        public Key ForwardLookup(Key key, int offset)
        {
            int index = this.inputKeys.IndexOf(key);

            if (index == -1)
            {
                return Key.Null;
            }

            index = this.ShiftIndexToOffsetPosition(index, offset);

            return this.outputKeys[index];
        }

        public Key ReverseLookup(Key key, int offset)
        {
            int index = this.outputKeys.IndexOf(key);

            if (index == -1)
            {
                return Key.Null;
            }

            index = this.ShiftIndexToOffsetPosition(index, offset * -1);

            return this.inputKeys[index];
        }

        private int ShiftIndexToOffsetPosition(int index, int offset)
        {
            return (index + offset) % this.Count;
        }
    }
}