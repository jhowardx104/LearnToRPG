# Sesson 0: Object Oriented Programming and You

So you've agreed to come to this course. Lucky you! You're picking up a brand new skill in programming. The goal of this is not to learn it all - none of us know it all and you've picked a skill that is constantly being changed. The goal is instead to learn the basics of what makes up a program, how to learn a programming language, and how to apply that to make a simple program of your own.

For this course, we are going to focus on .NET and C# specifically. At the time of this course, these are industry leading technologies and are a good framework/language respectively to demonstrate what Object Oriented Programming (OOP) is all about.

## Getting started

So, we know what language and framework we are going to use. Let's get your local environment setup. Start by installing Visual Studio Community and the .NET framework. See the [readme](../README.md) for links for those applications. 

- The Visual Studio installed will ask you what modules to install. For the scope of this project, we will want to add a few. Add the ones related to Web Development and Data storage and Processing. Additionally, add in Node.js and the Unity bundle. These aren't going to be needed for awhile, but we may dabble.

## Hello, World!

- Setup Console App with Hello World
- Talk about what was all created with the templates
- Explain what object oriented programming is
  - This is a way of organizing your code into packages of related functionality.
  - Benefits:
    - Faster and easier to execute
    - Easier to read
    - Code becomes reusable
- Explain what an object is
  - Encapsulates data and operations related to its data
- Explain what a class is 
  - A specific type of object with related data and functionality.
- Explain what an instance of a class is
  - An object instance is the "tangible" 1's and 0's that make up your object when we tell the application to create it
- Everything in C# is associated with classes or objects
- What makes up a class?
  - Data
    - Variables/Fields - Names for the objects that store data for you while your program is running
      - ex. A character has an HP variable.
    - Properties - Another similar concept to variables/fields but these have something called getters/setters that are methods that return your data. These are typically used to accomplish something called "encapsulation" - hiding class data from the public and providing access to it through class functionality. We do this for security and design reasons.
  - Functionality
    - Methods, Functions - Names for a chunk of functionality that the software is going to implement. Methods typically do a unit of work, but are not responsible with returning any data. Functions, however, are responsible for doing a unit of work and returning some data.
      - ex. A character may have an attack method.
      - ex. A character may have a getStatusEffects method that returns any of its current status effects
    - Constructor - instructions for what the class should do when it first gets created.
- Variables/Fields, Methods, and Functions will all have certain [Data Types](https://www.w3schools.com/cs/cs_data_types.php) assigned to them. The link before is only a few of them. In addition to the basic types included with C#, custom types(classes you create) are also able to be used for this.

## Most Common Basic Data Types

| Type | Description |
| --- | --- |
| int | Stores whole integer numbers (+/- whole numbers) between the range of approx. +/- 2 billion
| long | Stores whole integer numbers (+/- while numbers) between the range of approx. +/- 9 quintillion
| float | Stores decimal numbers. Used if you need 6-7 decimal digits
| double | Stores decimal numbers. Used if you need 15 decimal digits
| bool | Stores true or false values 
| char | Stores a single letter/character/number surrounded by single quotes
| string | Stores a sequence of characters/letters/numbers surround by double quotes

## Generating output

```C#
Console.WriteLine("This message gets printed to the console");
```

## Accepting input

```C#
var input = Console.ReadLine();
```

## Operators

These are meaningful symbols that will do something to your variables for you. Most commonly, math.

### Arithmetic

This is where the math happens...

| Operator | Name | Example |
| --- | --- | --- |
| + | Addition | x + y |
| - | Subtraction | x - y |
| * | Multiplication | x * y |
| / | Division | x / y |
| % | Modulus | x % y |
| ++ | Increment | x++ |
| -- | Decrement | x-- |

Most of these are self explanatory but for those that aren't:

- Modulus - Returns the remainder of a division problem.
  - ex. 3 % 2 = 1
- Increment - Increases the value of a variable by 1
- Decrement - Decreases the value of a variable by 1
- A note on the addition operator: when this is used with strings, it becomes the concatenation operator instead. This is a fancy way of saying it combines the two strings together into one longer one.
  - ex. "The" + "end" = "Theend" - notice that there is no space in the result because neither string had a space in there. It just puts the two items together. This is something to keep in mind when you're programming and strings look a little off.

### Assignment

This is how you'll assign data to a variable. Some of these are short hand examples for assignment in addition to some sort of operation.

| Operator | Example | Same As |
| --- | --- | --- |
| = | x = 5 | x = 5 |
| += | x += 3 | x = x + 3 |
| -= | x -= 3 | x = x - 3  |
| *= | x *= 3 | x = x * 3  |
| /= | x /= 3 | x = x / 3  |
| %= | x %= 3 | x = x % 3  |

### Comparison

These operators help you compare pieces of data. This is important when we need our program to make decisions for us. For example, is a certain character bald or did you earn enough experience to level up. In these examples, we'd use one of these operators to compare some data.

| Operator | Name | Example |
| --- | --- | --- |
| == | Equal to | x == y |
| != | Not equal | x != y |
| > | Greater than | x > y |
| < | Less than | x < y |
| >= | Greater than or equal to | x >= y |
| <= | Less than or equal to | x <= y |

### Logical

In addition to the comparison operators, sometimes, you'll need to make sure that more than one thing is true like the quest must be completed and the character should be a titan to get that specific helmet. Or, perhaps when we pass out that holy water as a reward, we shouldn't do so if the character is a vampire or ghoul. For this, you'll use a logical operator:

| Operator | Name | Description | Example |
| --- | --- | --- | --- |
| && | Logical and | True if both are true | 1 < 5 && 2 < 5 |
| \|\| | Logical or | True if only one is true | x > 5 \|\| x < 2

## Strings are special

Strings are a basic data type, but they have some nuances that make them a little more complicated than all of the rest. I wanted to note some of the common gotcha's here:

### Combining Strings

As mentioned above, you can use concatenation to combine two strings together, but there is another method called Interpolation that makes your code look cleaner and is often preferred over "adding" them together with the addition operator. See this example:

```C#
string name = "Jake";
Console.WriteLine($"Hello, {name}");
```

The above example creates a string called name with my name in it. I then use interpolation to insert it into the string. The result when the app runs would be:

```text
Hello, Jake
```

### Selecting part of a string

Strings have a list of common functions attached to them that let you split them up for find something in them. For example:

```C#
string str = "Programming rocks!";
Console.WriteLine(str.IndexOf("g"));
```

The example above uses the IndexOf function to see if the string I gave it contains the lower case letter "g". When this runs, the app will start from the left and tell me the position of the first "g" that it finds. This will return to me the number 3. 

Why 3? Computers are weird. They use a 0-based index. This means that the first item in a collection of items (see: Arrays, Collections, Lists) is in position 0, and you count upward from there.

We haven't gotten to arrays yet, but they are often represented with [] at the end of a variable. Strings are technically a collection of char variables, so, in the above example, the code below would print out the letter "g" since it is in spot 3 of that string:

```C#
Console.WriteLine(str[3]);
```

If you combine the knowledge of the IndexOf function with a new one called Substring, you can select a portion of a string.

```C#
string str = "Programming rocks!";
int index = str.IndexOf("g");
Console.WriteLine(str.Substring(index));
```

The above will take the string I've given and return to me the new string, "gramming rocks!". The index will start at the given position and return the remaining characters in the string. We can take this one step farther to tell it to only bring back a certain number of characters.

```C#
string str = "Programming rocks!";
int index = str.IndexOf("g");
Console.WriteLine(str.Substring(index, 4));
```

The above will now start at "g" but only return 4 characters. The result would be "gram".

### Special Characters

Sometimes you'll want to use a special character in a string like a slash, or perhaps you want to add a new line to your string. You can do that with something called an escape character. You just add these to your string and it will add the corresponding character to your string when it prints it out to the console.

| Escape Character | Normal Character | Description |
| --- | --- | --- |
| \' | ' | Single quote
| \" | " | Double quote
| \\\\ | \\ | Backslash
| \n | New Line | Creates a new line in your string 
| \t | Tab | Creates a tab space in your string
| \b | Backspace | Backspaces your string

## Can you make a decision?

Of course not, that's why we are writing these programs to do it for us. And even if we could decide, the computer can do it much faster.

Thats where decision structures and loops come into play. Decision structures will let you control the data flow throughout your application, and loops handle all of your repetitive actions for you.

### Decision structures

Decision structures are really broken into two main types:

- If...else
- Switch

The If...else structure will do something only if a certain condition is met.

```C#
if(x > 3)
{
  Console.WriteLine("X exceeds 3.");
}
```
In the above example, we have a simple if block. If x > 3 then print the message. Simple enough. Now, what if I wanted to print a special message only if x > 10. Let's refactor a little.

```C#
if(x > 10)
{
  Console.WriteLine("Whoa! X is more than 10!");
}
else if (x > 3)
{
  Console.WriteLine("X exceeds 3");
}
```

In this new example, the new message will print out if x > 10; however, any value > 3 but less than or equal to 10 would print out the original "X exceeds 3" message. 

One more time though. Let's refactor this to print out a message if neither case is met using a plain else block. This makes it so the code will print out a message for all conditions, giving feedback to the user.

```C#
if(x > 10)
{
  Console.WriteLine("Whoa! X is more than 10!");
}
else if (x > 3)
{
  Console.WriteLine("X exceeds 3");
}
else
{
  Console.WriteLine("X is less than or equal to 3");
}
```

This last example will now print out a message if x is not greater than 3. 

Switch structures are the other main decision structure and should typically be used when your decision could result in 3+ different results. For example, let's examine the following sample:

```C#
switch(enemy.Weapon.Type)
{
  case "Slashing":
    Console.WriteLine("This deals bonus damage to this player.");
    break;
  case "Bludgeoning":
    Console.WriteLine("This player is resistant to bludgeoning damage.");
    break;
  case "Cold":
    Console.WriteLine("This player is immune to cold.");
    break;
  default:
    break;
}
```

The player was attacked with a weapon, but has some modifiers for slashing, bludgeoning, and cold damage types. The weapon has one type, but you need to handle all of the different effects when the player is attacked in case any of the conditions are met. This could have been done with a chain of if statements, but this is a cleaner solution. 

The break statement is required for switch statements to tell it to break out of the switch block after finishing its work. The default block is optional and will run if none of the other conditions are met.

### Loops

Loops have a few different types that you can use:

- While
- Do...While
- For
- ForEach

The While loop is the most basic of the loops. It will continue to perform the code over and over until it's condition is no longer met. 

```C#
int x = 0;

while(x < 5)
{
  x++;
}
```

The above example will loop, incrementing the variable x each time until it increments to 6. At that point, the condition is no longer met and the code moves on.

The Do...While loop is similar to the While loop, but it will always run once before checking its loop condition.

```C#
int x = 1;
do
{
  x++;
}while(x < 1);
```
The above example has a while loop condition of x < 1. X already equals 1, but since this is a Do...While, it will still perform the operation once. Therefore, x will be incremented to 2, and then the code would move on.

Both of these While loops are good for situations where you may not know how many times you want to loop.

The For loop is good for looping through data when you know how many times you need to loop. 

```C#
for(int i = 0; i < 5; i++)
{
  Console.WriteLine("For has looped");
}
```

The above creates a variable called i starting at 0. This will then print a message, increment i and make sure it is less than 5 still. When it no longer meets that condition, it moves on. This would loop exactly 5 times.

The ForEach loop is great for looping through collections of data (see Arrays, Lists, Collections). 

```C#
foreach(string x in scores)
{
  Console.WriteLine(x);
}
```
The above loop is going to loop through every string in a collection of strings called "scores". Each time, it will assign that value to "x" so that it can be used within the loop. I print that value out to the console. 

## Final Words on This Lesson

This is the part of programming where it becomes a puzzle. You will need to work to piece together combinations of all of the above: 

- Classes
- Fields
- Properties
- Methods
- Functions
- Decision structures
- Loops
- ... more we haven't talked about yet

Every program should be thought of as a pattern. You just pull pieces out and slot new pieces in until you've created a *disaster*piece that you're satisfied with. That's obviously a joke, but this is a very challenging field to get into. You'll always be finding a way to iteratively improve on your work. You'll never be satisfied. But if you always stay curious and have the drive to always keep learning, then you'll do great. 

## Next time on Learn to RPG

- Inheritance, Polymorphism, Interfaces, Abstraction, oh my...

![](https://media.tenor.com/NRbIchgvWlAAAAAC/george-takei-oh-my.gif)