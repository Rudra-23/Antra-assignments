namespace Question7;

public class Program
{
    static void Main(string[] args)
    {
        Ball ball1 = new Ball(3, new Color(0, 0, 0));
        Ball ball2 = new Ball(5, new Color(122, 0, 255));
        Ball ball3 = new Ball(8, new Color(0, 255, 0));


        Console.WriteLine("Initial State");
        Console.WriteLine($"Ball1 Throw Count: {ball1.GetThrowCount()}, Ball2 Throw Count: {ball2.GetThrowCount()}, Ball3 Throw Count: {ball3.GetThrowCount()}");

        ball1.Throw();

        ball2.Throw();
        ball2.Throw();

        ball3.Throw();
        ball3.Throw();
        ball3.Throw();

        Console.WriteLine("Adding Throws");
        Console.WriteLine($"Ball1 Throw Count: {ball1.GetThrowCount()}, Ball2 Throw Count: {ball2.GetThrowCount()}, Ball3 Throw Count: {ball3.GetThrowCount()}");

        ball3.Pop();
        Console.WriteLine("After popping ball3");
        Console.WriteLine($"Ball1 Throw Count: {ball1.GetThrowCount()}, Ball2 Throw Count: {ball2.GetThrowCount()}, Ball3 Throw Count: {ball3.GetThrowCount()}");

        ball3.Throw();
        ball3.Throw();
        ball2.Pop();
        Console.WriteLine("After Throwing ball3 again and popping ball2");

        Console.WriteLine($"Ball1 Throw Count: {ball1.GetThrowCount()}, Ball2 Throw Count: {ball2.GetThrowCount()}, Ball3 Throw Count: {ball3.GetThrowCount()}");
    }
}
