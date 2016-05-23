using System;

namespace Enigma
{
    internal class Param
    {
        internal static void IsNonNegativeNumber(int i)
        {
            if (i < 0)
            {
                throw new ArgumentException("");
            }
        }
    }
}