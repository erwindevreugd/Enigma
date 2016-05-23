using System;

namespace Enigma
{
    public sealed class Rotor
    {
        private readonly RotorEncodingTable encodingTable;
        private readonly Key[] turnoverPositions;
        private readonly int rotorShift;
        private int index = 0;

        /// <summary>
        /// Initializes a new instance of the Rotor class.
        /// </summary>
        /// <param name="encodingTable">The encoding table used by this rotor to encode keys.</param>
        /// <param name="turnoverPositions">Array of keys where the rotor will raise the step event.</param>
        /// <param name="rotorShift">This value shifts the input column of the encoding table
        /// in respect to the output column.</param>
        public Rotor(RotorEncodingTable encodingTable, Key[] turnoverPositions, int rotorShift)
        {
            this.encodingTable = encodingTable;
            this.turnoverPositions = turnoverPositions;
            this.rotorShift = rotorShift;
        }

        public event EventHandler<EventArgs> Step;

        /// <summary>
        /// Gets the current face key.
        /// This property is adjusted by the rotor shift value.
        /// </summary>
        public Key FaceKey
        {
            get
            {
                var index = (this.CurrentIndex + this.RotorShift) % this.Positions;
                return this.encodingTable.GetInputKeyAtIndex(index);
            }

            set
            {
                this.index = this.encodingTable.GetIndexOfInputKey(value);
            }
        }

        /// <summary>
        /// Gets the number of rotor positions.
        /// </summary>
        public int Positions
        {
            get
            {
                return this.encodingTable.Count;
            }
        }

        /// <summary>
        /// Gets the rotor's turnover positions.
        /// </summary>
        public Key[] TurnoverPositions
        {
            get
            {
                return this.turnoverPositions;
            }
        }

        /// <summary>
        /// Gets the rotor's current index.
        /// This value is not adjusted by the rotor shift value.
        /// </summary>
        public int CurrentIndex
        {
            get
            {
                return this.index;
            }
        }

        /// <summary>
        /// Gets the rotor shift value.
        /// </summary>
        public int RotorShift
        {
            get
            {
                return this.rotorShift;
            }
        }

        public Key ForwardEncode(Key key)
        {
            var index = (this.CurrentIndex + this.RotorShift) % this.Positions;
            return this.encodingTable.ForwardLookup(key, index);
        }

        public Key ReflectedEncode(Key key)
        {
            var index = (this.CurrentIndex + this.RotorShift) % this.Positions;
            return this.encodingTable.ReverseLookup(key, index);
        }

        /// <summary>
        /// Advances the rotor's index by 1.
        /// </summary>
        public void AdvanceIndex()
        {
            this.index++;

            if (this.index > this.encodingTable.Count - 1)
            {
                this.ResetIndexPosition();
            }

            this.EvaluateIndexPosition();
        }

        /// <summary>
        /// Resets the rotor's index position to 0.
        /// </summary>
        private void ResetIndexPosition()
        {
            this.index = 0;
        }

        private void EvaluateIndexPosition()
        {
            Key currentFaceKey = this.FaceKey;
            for (int i = 0; i < this.turnoverPositions.Length; i++)
            {
                if (this.turnoverPositions[i].Equals(currentFaceKey))
                {
                    this.RaiseStepEvent();
                }
            }
        }

        private void RaiseStepEvent()
        {
            EventHandler<EventArgs> handler = this.Step;

            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }
    }
}