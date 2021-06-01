using System;

namespace Heist
{
  public class TeamMember
  {
    public string Name { get; set; }

    public int SkillLevel { get; set; }

    public double Courage { get; set; }


    public TeamMember(string name)
    {
      Name = name;
      SkillLevel = 0;
      Courage = 0;
    }

    public void GetSkill()
    {
      while (true)
      {
        Console.Write("Enter a skill level! ");
        string SkillString = Console.ReadLine();
        if (int.TryParse(SkillString, out int SkillInt))
        {
          SkillLevel = SkillInt;
          break;
        }
        else
        {
          Console.WriteLine("Please enter a number greater than 0!");
        }
      }

    }

    public void GetCourage()
    {
      while (true)
      {
        Console.Write("Enter a courage level! ");
        string CourageString = Console.ReadLine();
        if (double.TryParse(CourageString, out double CourageInt) && CourageInt > 0 && CourageInt < 2)
        {
          Courage = CourageInt;
          break;
        }
        else
        {
          Console.WriteLine("Please enter a number greater than 0!");
        }

      }
    }
  }
}