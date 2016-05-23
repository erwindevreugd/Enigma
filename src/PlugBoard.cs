namespace Enigma
{
    public sealed class PlugBoard
    {
        private readonly SwappingTable swappingTable;

        public PlugBoard(SwappingTable swappingTable)
        {
            this.swappingTable = swappingTable;
        }

        /// <summary>
        /// Encodes the given key.
        /// If the given key exist in the plug board swapping table
        /// it wil return the linked key, else, it returns the given key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Key Encode(Key key)
        {
            int index = this.swappingTable.GetIndexOfInputKey(key);

            if (index == -1)
            {
                return key;
            }

            return this.swappingTable.GetOutputKeyAtIndex(index);
        }
    }
}