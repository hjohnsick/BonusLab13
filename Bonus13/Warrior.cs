using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    class Warrior : GameCharacter
    {
        //field & properties
        public string WeaponType { get; set; }

        //overloaded constructors
       public Warrior()
        {

        }

        public Warrior(string _name, int _strength, int _intelligence, string _weaponType)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            WeaponType = _weaponType;

        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Weapon Type: {WeaponType}");
        }
    }
}
