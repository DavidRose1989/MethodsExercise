namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}! Where do you go at night?");
            var night = Console.ReadLine();

            Console.WriteLine($"Thanks {userName}! what time do you come back?");
            var time = Console.ReadLine();

            Console.WriteLine($"Wow {userName}, why do you come back?!");
            var come = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is what you did lastnight");


            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"night:{night}");
            Console.WriteLine($"time: {time}");
            Console.WriteLine($"come: {come}");

            var answer = Methods.Sum(1, 1);
            Console.WriteLine($"The answer is {answer}");

            
            var addAnswer = Methods.Sum(2, 4);
            Console.WriteLine(addAnswer);

            
            var multiplyAnswer = Methods.Multiply(2, 10);
            Console.WriteLine(multiplyAnswer);



        }
    }               
}
