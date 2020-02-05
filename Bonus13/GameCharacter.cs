using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    abstract class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

       // public GameCharacter(string _name, int _strength, int _intelligence)
       // {
          //  name = _name;
           // strength = _strength;
            //intelligence = _intelligence;
        //}

        public virtual void Play()
        {
            Console.WriteLine($"Character: {Name} \nStrength: {Strength} \n Intelligence: {Intelligence}");
        }


    }
}
