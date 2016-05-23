namespace Enigma
{
    public class StatorEncodingTable : EncodingTable
    {
        public StatorEncodingTable()
        {
        }

        public Key Lookup(Key key)
        {
            int index = this.inputKeys.IndexOf(key);

            if (index == -1)
            {
                return Key.Null;
            }

            return this.outputKeys[index];
        }
    }
}