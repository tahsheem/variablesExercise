using System;

namespace variableExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "David";
            int age = 22;
            char firstInitial = 'D';
            bool loveSports = true;
            double currentTemp = 90;
            decimal weight = 100.35m;

            Console.WriteLine($"My name is {myName} and I am {age} years old! The first Letter of my first is {firstInitial}." +
                $" I love sports which is {loveSports}. Its hot and the current temprature is {currentTemp} degrees." +
                $"Oh and I forgot to mention that I am {weight} pounds.");
        }
    }
}
