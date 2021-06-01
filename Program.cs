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

      foreach (TeamMember Person in HeistTeam)
      {
        Console.WriteLine($"{Person.Name}'s skill level is {Person.SkillLevel} and their courage level is {Person.Courage}!");
      }
    }
  }
}
