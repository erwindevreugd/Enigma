using System.Collections.Generic;

namespace Enigma
{
    public sealed class Spindle
    {
        public List<Rotor> rotors;

        public Spindle(Rotor rotor1, Rotor rotor2, Rotor rotor3)
        {
            this.rotors = new List<Rotor>();
            this.rotors.Add(rotor1);
            this.rotors.Add(rotor2);
            this.rotors.Add(rotor3);
        }
    }
}