using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Plan Your Heist!");
            Console.Write("Enter a name!");
            string Name = Console.ReadLine();

            TeamMember Person = new TeamMember(Name);

            Person.GetSkill();
            Person.GetCourage();

            Console.WriteLine($"{Person.Name}'s skill level is {Person.SkillLevel} and their courage level is {Person.Courage}!");
        }
    }
}
