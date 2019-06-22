using System;

namespace Rabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            RabbitClass myRabbit = new RabbitClass();
            Console.WriteLine("Enter one of the colors for first rabbit:blue, red or black: ");
            myRabbit.EyesRabbit = Console.ReadLine();
            
            Console.WriteLine("Enter one of the colors for fur of rabbit:white, brown, black or grey: ");
            myRabbit.FurOfRabbit = Console.ReadLine();

            Console.WriteLine("Enter the gender of rabbit: ");
            myRabbit.Gender = Console.ReadLine();

            Console.WriteLine($"My rabbit has {myRabbit.EyesRabbit} eyes, {myRabbit.FurOfRabbit} fur and {myRabbit.Gender} gender");
            Console.WriteLine($"My rabbit has {myRabbit.AgeOfRabbit} years old.");
            
            Console.WriteLine();
            myRabbit.MoveRabbit();
            Console.WriteLine();
            myRabbit.SleepRabbit();
            Console.WriteLine();
            myRabbit.EatRabbit();
        }
    }
}
