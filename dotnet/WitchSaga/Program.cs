using System;
using WitchSaga.Extensions;
using WitchSaga.Models;

namespace WitchSaga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~ Witch Saga! ~~~~\r\n");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Person A");
            Console.ResetColor();
            Console.WriteLine("Age of death:");
            string ageOfDeathA = Console.ReadLine();
            Console.WriteLine("Year of death:");
            string yearOfDeathA = Console.ReadLine();
            Console.WriteLine("------------------------------------\r\n");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Person B");
            Console.ResetColor();
            Console.WriteLine("Age of death:");
            string ageOfDeathB = Console.ReadLine();
            Console.WriteLine("Year of death:");
            string yearOfDeathB = Console.ReadLine();
            Console.WriteLine("------------------------------------\r\n");


            var peopleObject = new People()
            {
                PersonA = new Person(ageOfDeathA.ToInt(), yearOfDeathA.ToInt()),
                PersonB = new Person(ageOfDeathB.ToInt(), yearOfDeathB.ToInt())
            };

            var witchSaga = new Core.WitchSaga(peopleObject);

            double averageKilled = witchSaga.FindAverageOfPeopleKilled();

            Console.ForegroundColor = averageKilled <= 0 ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"Average number of people the witch killed: {averageKilled}");

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
