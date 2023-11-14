using System;
using System.Collections.Generic;

namespace DungeonsDragons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> characterInfo = new List<string>();//array for character information 
            //variables with the character, class, and type
            string dragBor = "Dragonborn";
            string dwarf = "Dwarf";
            string elf = "Elf";
            string gnome = "Gnome";
            string halfElf = "Half-Elf";
            string halfing = "Halfing";
            string halfOrc = "Half-Orc";
            string human = "Human";
            string tielfing = "Tielfing";
            string barb = "Barbarian";
            string bard = "Bard";
            string cleric = "Cleric";
            string druid = "Druid";
            string fighter = "Fighter";
            string monk = "Monk";
            string paladin = "Paladin";
            string ranger = "Ranger";
            string rouge = "Rouge";
            string sorcerer = "Sorcerer";
            string warlock = "Warlock";
            string wizard = "Wizard";


            Console.WriteLine("Welcome to the character creation program for Dungeons and Dragons!");//welcome statement
            //statments prompting user input that will be added to array. 
            Console.WriteLine("Please enter your new character name:");
            string charName = Console.ReadLine();

            Console.WriteLine("Please enter the age of " + charName);
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter " + charName + "'s starting level:");
            int level = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter " + charName + "'s gender:");
            string gender = Console.ReadLine();
            //statement for user to choose the race of the character. 
            Console.WriteLine("Please select " + charName + "'s race:");
            Console.WriteLine("Enter 1 for a DragonBorn.");
            Console.WriteLine("Enter 2 for a Dwarf.");
            Console.WriteLine("Enter 3 for a Elf.");
            Console.WriteLine("Enter 4 for a Gnome.");
            Console.WriteLine("Enter 5 for a Half-Elf.");
            Console.WriteLine("Enter 6 for a Halfing.");
            Console.WriteLine("Enter 7 for a Half-Orc.");
            Console.WriteLine("Enter 8 for a Human.");
            Console.WriteLine("Enter 9 for a Tiefling.");
            int race = Convert.ToInt32(Console.ReadLine());
            //switch statement that will let the user know what they chose and add choice to array. 
            switch (race)
            {
                case 1:
                    characterInfo.Add(dragBor);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 2:
                    characterInfo.Add(dwarf);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 3:
                    characterInfo.Add(elf);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 4:
                    characterInfo.Add(gnome);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 5:
                    characterInfo.Add(halfElf);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 6:
                    characterInfo.Add(halfing);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 7:
                    characterInfo.Add(halfOrc);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 8:
                    characterInfo.Add(human);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 9:
                    characterInfo.Add(tielfing);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
            }


            //prompt user to chose the character class. 
            Console.WriteLine("Please select " + charName + "'s class:");
            Console.WriteLine("Enter 1 for a Barbarian.");
            Console.WriteLine("Enter 2 for a Bard.");
            Console.WriteLine("Enter 3 for a Cleric.");
            Console.WriteLine("Enter 4 for a Druid.");
            Console.WriteLine("Enter 5 for a Fighter.");
            Console.WriteLine("Enter 6 for a Monk.");
            Console.WriteLine("Enter 7 for a Paladin.");
            Console.WriteLine("Enter 8 for a Ranger.");
            Console.WriteLine("Enter 9 for a Rouge.");
            Console.WriteLine("Enter 10 for a Sorcerer.");
            Console.WriteLine("Enter 11 for a Warlock.");
            Console.WriteLine("Enter 12 for a Wizard.");
            int charClass = Convert.ToInt32(Console.ReadLine());
            //character class choice will be added to array. Will display a message with character information. 
            switch (charClass)
            {
                case 1:
                    characterInfo.Add(barb);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));

                    break;
                case 2:
                    characterInfo.Add(bard);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 3:
                    characterInfo.Add(cleric);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 4:
                    characterInfo.Add(druid);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 5:
                    characterInfo.Add(fighter);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 6:
                    characterInfo.Add(monk);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 7:
                    characterInfo.Add(paladin);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 8:
                    characterInfo.Add(ranger);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 9:
                    characterInfo.Add(rouge);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 10:
                    characterInfo.Add(sorcerer);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 11:
                    characterInfo.Add(warlock);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;
                case 12:
                    characterInfo.Add(wizard);
                    Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                    break;

            }

        }
    }
}
