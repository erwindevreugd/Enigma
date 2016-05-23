using System;
using System.Collections.Generic;

namespace Enigma
{
    public class EncodingTable
    {
        protected readonly List<Key> inputKeys;
        protected readonly List<Key> outputKeys;

        public EncodingTable()
        {
            this.inputKeys = new List<Key>();
            this.outputKeys = new List<Key>();
        }

        public int Count
        {
            get
            {
                return this.inputKeys.Count;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return this.inputKeys.Count == this.outputKeys.Count;
            }
        }

        public void Add(Key inputKey, Key outputKey)
        {
            if (Key.IsNull(inputKey) | Key.IsNull(outputKey))
            {
                throw new ArgumentException("Cannot add the Null key to an encoding table");
            }

            if (this.inputKeys.Contains(inputKey) | this.outputKeys.Contains(outputKey))
            {
                throw new ArgumentException("Duplicate keys are not allowed");
            }

            this.inputKeys.Add(inputKey);
            this.outputKeys.Add(outputKey);
        }

        public Key GetInputKeyAtIndex(int index)
        {
            if (index > this.Count - 1)
            {
                return Key.Null;
            }

            return this.inputKeys[index];
        }

        public Key GetOutputKeyAtIndex(int index)
        {
            if (index > this.Count - 1)
            {
                return Key.Null;
            }

            return this.outputKeys[index];
        }

        public int GetIndexOfInputKey(Key key)
        {
            return this.inputKeys.IndexOf(key);
        }

        public int GetIndexOfOutputKey(Key key)
        {
            return this.outputKeys.IndexOf(key);
        }
    }
}