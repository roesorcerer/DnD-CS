using System;
using System.Collections.Generic;

namespace Mod5Lab2
{

    public abstract class CharacterInfo//base class
    {
        public abstract void Fighter();//fighter method to explain the fighterclass
        public abstract void Paladin();//paladin class 

    }
    public class Second : CharacterInfo
    {
        public override void Fighter()//override fighter class with text
        {
            Console.WriteLine("You are looking at the fighter style classes. Be warned, you will be in the thick of all the fighting!");
            Console.WriteLine("Class: Fighter\nDescription: A master of of martial combat, skilled with a varity of weapons and armor.\nHit Die: d10\nPrimary Ability: Strength and Dexterity\n" +
                "Saving Throw Proficiencies: Strength and Constitution\nArmor and Weapon Profiences: All armor, shields, simple and martial weapons.");
            Console.WriteLine("Would you like to continue with the fighter class?");

        }
        public override void Paladin()//override the paladin class with text
        {
            Console.WriteLine("You are looking at the paladin style classes. Be warned, you will be a rightous fighter with healing abilities!");
            Console.WriteLine("Class: Paladin\nDescription: A holy warrior bound to a sacred oath.\nHit Die: d10\nPrimary Ability: Strength and Charisma\n" +
                "Saving Throw Proficiencies: Wisdom and Charisma\nArmor and Weapon Profiences: All armor, shields, simple and martial weapons.");
            Console.WriteLine("Would you like to continue with the paladin class?");
        }

    }

    public class Fighter : Character//class for fighter selection strings dependent on Character class. 
    {
        public string diety = "Please choose the diety you would like ";

        public string divineSpell1 = "'s first divine spell ";

        public string divineSpell2 = "'s second divine spell ";

        public string healing1 = "'s type of healing ";
    }

    public class Wizard : Character//class for wizard 
    {
        public string powerSource = "'s type of power source(Magic, Nature, Demonic) ";

        public string arcaneSpell1 = "'s first arcane spell ";

        public string arcaneSpell2 = "'s second arcane spell ";
    }
    public class Paladin : Character//class for paladin
    {
        public string divineSpell1 = "'s first divine spell ";

        public string divineSpell2 = "'s second divine spell ";

        public string healingSpell1 = "'s first healing spell ";
    }

    public class Character//chacter class with character creation method. 
    {
            static void Main(string[] args)
            {

            Second info = new();

            Paladin paladinClass = new();//arrays by class
            Fighter fighterClass = new();
            Wizard wizardClass = new();
            List<string> characterInfo = new();//list for character information 
            List<string> FighterInfo = new();
            List<string> WizardInfo = new();
            List<string> PaladinInfo = new();
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
                    Console.WriteLine("");
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
            int charClass;

            do
            {

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
                Console.WriteLine("Press 0 to end.");
                charClass = Convert.ToInt32(Console.ReadLine());

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
                        info.Fighter();//will pull from the fighter overridden class. 
                        string selection = Console.ReadLine();
                        if (selection.Equals("Yes"))//if yes you can create fighter
                        {
                            characterInfo.Add(fighter);
                            Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                            Console.WriteLine(fighterClass.diety);
                            string dietyInput = Console.ReadLine();
                            FighterInfo.Add(dietyInput);
                            Console.WriteLine(charName + fighterClass.divineSpell1);
                            string divineSpell1Input = Console.ReadLine();
                            FighterInfo.Add(divineSpell1Input);
                            Console.WriteLine(charName + fighterClass.divineSpell2);
                            string divineSpell2Input = Console.ReadLine();
                            FighterInfo.Add(divineSpell2Input);
                            Console.WriteLine(charName + fighterClass.healing1);
                            string healing1Input = Console.ReadLine();
                            FighterInfo.Add(healing1Input);
                            Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo) + " and will have the following character qualities: " + string.Join(" ", FighterInfo));
                            break;
                        }
                        else if (selection.Equals("No"))//if no will loop to choose another class. 
                        {
                            Console.WriteLine("Please make alternate selection");
                            break;
                        }
                        break;
                    case 6:
                        characterInfo.Add(monk);
                        Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                        break;
                    case 7:
                        info.Paladin();//paladin method pulled from overridden paladin class
                        selection = Console.ReadLine();
                        if (selection.Equals("Yes"))//if yes will create character
                        {
                            characterInfo.Add(paladin);
                            Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                            Console.WriteLine(charName + paladinClass.divineSpell1);
                            string divineSpell1Input = Console.ReadLine();
                            PaladinInfo.Add(divineSpell1Input);
                            Console.WriteLine(charName + paladinClass.divineSpell2);
                            string divineSpell2Input = Console.ReadLine();
                            PaladinInfo.Add(divineSpell2Input);
                            Console.WriteLine(charName + paladinClass.healingSpell1);
                            string healing1Input = Console.ReadLine();
                            PaladinInfo.Add(healing1Input);
                            Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo) + " and will have the following character qualities: " + string.Join(" ", PaladinInfo));
                            characterInfo.Add(string.Join(" ", PaladinInfo));

                        }
                        else if (selection.Equals("No"))//if no will prompt to select a different class. 
                        {
                            Console.WriteLine("Please make alternate selection");
                            continue;
                        }
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
                    case 12://wizard stayed the same from previous week assignment. I did not create a new class for this. 
                        characterInfo.Add(wizard);
                        Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo));
                        Console.WriteLine(charName + wizardClass.powerSource);
                        string powerInput = Console.ReadLine();
                        WizardInfo.Add(powerInput);
                        Console.WriteLine(charName + wizardClass.arcaneSpell1);
                        string arcaneSpell1Input = Console.ReadLine();
                        WizardInfo.Add(arcaneSpell1Input);
                        Console.WriteLine(charName + wizardClass.arcaneSpell2);
                        string arcaneSpell2Input = Console.ReadLine();
                        WizardInfo.Add(arcaneSpell2Input);
                        Console.WriteLine(charName + " will be a " + string.Join(" ", characterInfo) + " and will have the following character qualities: " + string.Join(" ", WizardInfo));
                        break;
                }
            }
            while (charClass != 0);
            Console.WriteLine("You have created:" + string.Join(" ", characterInfo));//output again to show what was selected. 
            Console.WriteLine("Thanks for using the character creation program for Dungeons and Dragons!");//ending message
            return;
        }
     }
}
