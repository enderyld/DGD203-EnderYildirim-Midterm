namespace Midterm;

public class Questions
{
   
    public void _Questions(string name)
    {
         int score = 0;
        string[] questions =
        {
            "What is 5+3",
            "What is 12-5",
            "What is 11*4",
            "What is 60/5 ",
        };
        string[,] choices =
        {
            {"1. 7","2. 8","3. 9","4. 10"},
            {"1. 6", "2. 7", "3. 8", "4. 9"},
            {"1. 33", "2. 44", "3. 55", "4. 66"},
            {"1. 12", "2. 8", "3. 14", "4. 16"},
            
        };
        int[] correctAnswers = { 2, 2, 2, 1};
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"Question {i + 1}: {questions[i]}");
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(choices[i, j]);
            }
            //Chatgpt
            Console.Write("Your answer: ");
            int answer;
            while (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > 4)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                Console.Write("Your answer: ");
            }//

            if (answer == correctAnswers[i])
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong answer.");
            }
        }
        Console.WriteLine($"You Answered All Questions, {name}! You scored {score}/{questions.Length}.\n");

        if (score == questions.Length)
        {
            Console.WriteLine("Amazing! You got a perfect score! ");
        }
        else if (score >= questions.Length / 2)
        {
            Console.WriteLine("Good job! You did well!");
        }
        else
        {
            Console.WriteLine("Better luck next time. Keep practicing!");
        }
    }
}