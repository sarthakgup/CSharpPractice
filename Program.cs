//BY: Sarthak Gupta
//1/9/18    Period: 2

using System;
public class Story
{
    public static void Main()
    {
        string EvilGiantName = "Gargantua"; //Age: 35
        string EvilKidOne = "Gargu"; //Age: 14
        string EvilKidTwo = "Gargi"; //Age: 14
        string EvilWifeName = "Gargitua"; //Age: 22
        string GoodHero = "Sarthak"; // Age: 16
        string Location = "Paradise Lost";
        string Giants = "giants";
        int AgeGiant = 35;
        int AgeWife = 22;
        int AgeHero = 16; //The legend himself
        int AgeKids = 14; //Twins of age 14
        int AgeLocation = 100; //A 100 year old location thriving with evil giants


        Console.WriteLine("Once upon a time, in the land of gaints lived {0}, {1}, {2}."
                            + " and {3}", EvilGiantName, EvilKidOne, EvilKidTwo, EvilWifeName);
        Console.WriteLine("{0} and {1} were the parents. They were of ages {2} and {3} respectively.", EvilGiantName, EvilWifeName, AgeGiant, AgeWife);
        Console.WriteLine("The kid giants were both {0} years old.", AgeKids);
        Console.WriteLine("They lived on the {0} year old island known as {1}.", AgeLocation ,Location);
        Console.WriteLine(" "); //blank space for paragraph indentation
        Console.WriteLine("One day, along game a {1}-year-old brave hero named {0}.", GoodHero, AgeHero);
        Console.WriteLine("{0} was very unsuspecting of the giants. He thought of them as nice giants!", GoodHero);
        Console.WriteLine("Little did he know that these were some of the fiercest {0} around.", Giants);
        Console.WriteLine("He saw as one of the {0} picked up his friend mid-sleep and swallowed him whole!", Giants);
        Console.WriteLine("{0} realized he needed to do something. He could just watch the {1} eat his" + 
                            " friends...", GoodHero, Giants);
        Console.WriteLine(" "); //blank space for paragraph indentation.
        Console.WriteLine("One day, {0} saw {1} and {2} sitting in the grass and playing.", GoodHero, EvilKidOne, EvilKidTwo);
        Console.WriteLine("It struck {0} that this was the best time to exact his revenge!", GoodHero);
        Console.WriteLine("{0} fooled a huge giant into eating the two children for imaginary money.", GoodHero);
        Console.WriteLine(" "); //blank space for paragraph indentation.
        Console.WriteLine(" THE END ");

        // I remembered to include all the neccessary punctuation.


        Console.Read();
    }
}