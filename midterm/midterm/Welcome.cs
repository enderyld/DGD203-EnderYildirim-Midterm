namespace Midterm;

public class Welcome
{
    public string name { get; private set; }
    public void WelcomeMessage()
    {
        Console.WriteLine("What is your name?");
         name = Console.ReadLine();
        Console.WriteLine("Welcome to Math Exam ! "+name+" Lets Start !");
    }
}