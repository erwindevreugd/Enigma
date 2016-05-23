using System;
using System.Collections.Generic;

namespace Enigma
{
    public class Key : IEquatable<Key>, IEqualityComparer<Key>
    {
        private char character;
        private int value;

        private Key(char c, int value)
        {
            this.character = c;
            this.value = value;
        }

        public static Key Null
        {
            get { return new Key(' ', -1); }
        }

        public static Key A
        {
            get { return new Key('A', 0); }
        }

        public static Key B
        {
            get { return new Key('B', 1); }
        }

        public static Key C
        {
            get { return new Key('C', 2); }
        }

        public static Key D
        {
            get { return new Key('D', 3); }
        }

        public static Key E
        {
            get { return new Key('E', 4); }
        }

        public static Key F
        {
            get { return new Key('F', 5); }
        }

        public static Key G
        {
            get { return new Key('G', 6); }
        }

        public static Key H
        {
            get { return new Key('H', 7); }
        }

        public static Key I
        {
            get { return new Key('I', 8); }
        }

        public static Key J
        {
            get { return new Key('J', 9); }
        }

        public static Key K
        {
            get { return new Key('K', 10); }
        }

        public static Key L
        {
            get { return new Key('L', 11); }
        }

        public static Key M
        {
            get { return new Key('M', 12); }
        }

        public static Key N
        {
            get { return new Key('N', 13); }
        }

        public static Key O
        {
            get { return new Key('O', 14); }
        }

        public static Key P
        {
            get { return new Key('P', 15); }
        }

        public static Key Q
        {
            get { return new Key('Q', 16); }
        }

        public static Key R
        {
            get { return new Key('R', 17); }
        }

        public static Key S
        {
            get { return new Key('S', 18); }
        }

        public static Key T
        {
            get { return new Key('T', 19); }
        }

        public static Key U
        {
            get { return new Key('U', 20); }
        }

        public static Key V
        {
            get { return new Key('V', 21); }
        }

        public static Key W
        {
            get { return new Key('W', 22); }
        }

        public static Key X
        {
            get { return new Key('X', 23); }
        }

        public static Key Y
        {
            get { return new Key('Y', 24); }
        }

        public static Key Z
        {
            get { return new Key('Z', 25); }
        }

        public bool Equals(Key other)
        {
            return this.value == other.value;
        }

        public bool Equals(Key x, Key y)
        {
            return x.value == y.value;
        }

        public int GetHashCode(Key obj)
        {
            return this.value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Key key = obj as Key;

            return key == null ? false : this.value == key.value;
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public override string ToString()
        {
            return this.value.ToString();
        }

        public static int GetKeyValue(Key key)
        {
            return key.value;
        }

        public static bool IsNull(Key key)
        {
            return key.Equals(Key.Null);
        }

        public static explicit operator Key(char c)
        {
            c = char.ToUpper(c);

            switch (c)
            {
                case 'A':
                    return Key.A;

                case 'B':
                    return Key.B;

                case 'C':
                    return Key.C;

                case 'D':
                    return Key.D;

                case 'E':
                    return Key.E;

                case 'F':
                    return Key.F;

                case 'G':
                    return Key.G;

                case 'H':
                    return Key.H;

                case 'I':
                    return Key.I;

                case 'J':
                    return Key.J;

                case 'K':
                    return Key.K;

                case 'L':
                    return Key.L;

                case 'M':
                    return Key.M;

                case 'N':
                    return Key.N;

                case 'O':
                    return Key.O;

                case 'P':
                    return Key.P;

                case 'Q':
                    return Key.Q;

                case 'R':
                    return Key.R;

                case 'S':
                    return Key.S;

                case 'T':
                    return Key.T;

                case 'U':
                    return Key.U;

                case 'V':
                    return Key.V;

                case 'W':
                    return Key.W;

                case 'X':
                    return Key.X;

                case 'Y':
                    return Key.Y;

                case 'Z':
                    return Key.Z;

                default:
                    return Key.Null;
            }
        }
    }
}