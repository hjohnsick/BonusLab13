using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public Wizard ()
        {

        }
        public Wizard(string _name, int _strength, int _intelligence, int _magicalEnergy, int _spellNumber)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            MagicalEnergy = _magicalEnergy;
            SpellNumber = _spellNumber;

        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Spell Number: {SpellNumber}");
        }
    }
}
