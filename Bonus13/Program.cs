using System;

namespace Bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] gameCharacters = new GameCharacter[5];
                gameCharacters[0] = new Warrior("Aria", 50, 80, "Needle");
            gameCharacters[1] = new Warrior("Daenerys", 65, 75, "dragon");
            gameCharacters[2] = new Wizard("Merlin", 20, 90, 75, 55);
            gameCharacters[3] = new Wizard("Harry", 30, 80, 95, 22);
            gameCharacters[4] = new Wizard("Simon", 18, 100, 88, 60);

            for (int i = 0; i < gameCharacters.Length; i++)
            {
                gameCharacters[i].Play();
                Console.WriteLine();
            }

        }  
    }
}
