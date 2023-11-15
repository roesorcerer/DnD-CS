# Module 05 Lab Assignment 2: Abstract Class Creation

## Description

This code represents a character creation program for Dungeons and Dragons (D&D). It allows you to create a character by selecting a name, age, gender, race, and class for your D&D adventure. The program provides information about the selected character's attributes and abilities based on the chosen class.

## Instructions

1. **Character Information**
    - Enter your character's name, age, and gender as prompted.
    - Select your character's race from the options provided.
    
2. **Character Class Selection**
    - Choose a character class from the available options.
    - Each class has unique attributes and abilities.
    - Some classes (Fighter and Paladin) have additional choices to make.

3. **Fighter and Paladin Class Options**
    - If you choose Fighter or Paladin, you will be prompted to make further selections, such as deity, divine spells, and healing abilities.

4. **Character Creation**
    - The program will display your character's information, including race, class, and any additional choices you made.

5. **Repeat or End**
    - You can create multiple characters or end the program by pressing '0' when prompted for class selection.

## Class Structure

- `CharacterInfo` (Abstract Class): Defines abstract methods for Fighter and Paladin classes.
- `Second` (Derived Class): Implements Fighter and Paladin methods.
- `Fighter`, `Wizard`, `Paladin` (Derived Classes): Define additional attributes specific to their respective classes.
- `Character` (Main Class): Contains the main program logic, character creation process, and user interaction.

## How to Run

To run this program, compile and execute the code in a C# development environment that supports .NET.

Enjoy creating your D&D characters with this character creation program! Have fun in your adventures in the world of Dungeons and Dragons!

For any questions or issues, please contact [Rowan Stratton].

---

**Note**: This README provides an overview of the code and instructions for using it. Please ensure that you have the necessary development environment set up to run the code successfully.
