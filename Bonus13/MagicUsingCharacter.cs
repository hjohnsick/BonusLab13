﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    class MagicUsingCharacter :GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter()
        {

        }
        public MagicUsingCharacter(string _name, int _strength, int _intelligence, int _magicalEnergy)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            MagicalEnergy = _magicalEnergy;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
        }
    }
}
