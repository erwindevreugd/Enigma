using System;

namespace Enigma
{
    public class SwappingTable : EncodingTable
    {
        public SwappingTable()
        {
        }

        public void Swap(Key key1, Key key2)
        {
            if (key1.Equals(key2))
            {
                throw new ArgumentException("Cannot swap the same key");
            }

            this.Add(key1, key2);
        }
    }
}