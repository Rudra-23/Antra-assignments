using Exercise03;
/* Q1. FizzBuzz */
Console.WriteLine("\n Question 1");
FizzBuzz fizzBuzz = new FizzBuzz();
fizzBuzz.GenerateFizzBuzz(100);

/* Q2. Print a pyramid */
Console.WriteLine("\n Question 2");
StarPattern starPattern = new StarPattern();
starPattern.PrintPattern(5);

/*Q3. Guess the number */
Console.WriteLine("\n Question 3");
NumberGuesser numberGuesser = new NumberGuesser();
numberGuesser.GuessNumber();

/*Q4. Get Age  */
Console.WriteLine("\n Question 4");
Dates dates = new Dates();
dates.CalculateAge(new DateTime(2000, 11, 23));

/*Q4. Greetings */
Console.WriteLine("\n Question 5");
dates.Greet();

/*Q5. Count till 24*/
for(int times = 1; times <=4;  times++)
{
    for(int i = 0; i <= 24; i = i + times)
    {
        if (i != 0) Console.Write(',');
        Console.Write(i);
    }
    Console.WriteLine();
}