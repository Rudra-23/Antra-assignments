
using _02UnderstandingTypes;

/*
    Playing with Console App
 */



Console.WriteLine("What's your favorite color?");
string favoriteColor = Console.ReadLine();

Console.WriteLine("What's your astrology sign?");
string astrologySign = Console.ReadLine();

Console.WriteLine("What's your street address number?");
string streetNumber = Console.ReadLine();

Console.WriteLine($"Your hacker name is {favoriteColor + astrologySign + streetNumber}.");



/*Practice number sizes and ranges*/

Console.WriteLine("\n Question 1");
TypesInfo typesInfo = new TypesInfo();
typesInfo.GetInfo();

Console.WriteLine("\n Question 2");
string time = typesInfo.ConvertCenturiesToTime(5);
Console.WriteLine(time);
