using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            List<TeamMember> HeistTeam = new List<TeamMember>();

            Console.WriteLine("Plan Your Heist!");
            while (true)
            {
                Console.Write("Enter a name! ");
                string Name = Console.ReadLine();
                if (Name.Length > 0)
                {
                    TeamMember Person = new TeamMember(Name);
                    Person.GetSkill();
                    Person.GetCourage();
                    HeistTeam.Add(Person);
                }
                else break;
            }

            Console.WriteLine($"You have {HeistTeam.Count} members on your team");

            Console.Write("How many times are you going to try your crazy plan? ");
            int runs = 0;
            while (true)
            {
                string runstring = Console.ReadLine();
                if (int.TryParse(runstring, out runs))
                {
                    break;
                }
                Console.WriteLine("How about an actual number?");

            }


            for (int j = 0; j < runs; j++)
            {

                int Difficulty = 100;
                int TeamSkillz = 0;

                Random i = new Random();
                int luck = i.Next(-10, 10);
                Difficulty = Difficulty + luck;

                Console.Write($"Bank difficulty is {Difficulty}, ");



                foreach (TeamMember Person in HeistTeam)
                {
                    // Console.WriteLine($"{Person.Name}'s skill level is {Person.SkillLevel} and their courage level is {Person.Courage}!");
                    TeamSkillz += Person.SkillLevel;
                }

                Console.WriteLine($"Team Skillz {TeamSkillz}");


                if (Difficulty < TeamSkillz)
                {
                    Console.WriteLine("You da best! You got all the monies");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Do not pass go. Do not collect $200. Go directly to jail!");
                    Console.WriteLine("");
                }
            }
        }
    }
}
