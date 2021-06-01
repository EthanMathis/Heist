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
            void header()
            {
                Console.WriteLine(@"
 /$$   /$$           /$$             /$$            /$$$$$$                                   
| $$  | $$          |__/            | $$           /$$__  $$                                  
| $$  | $$  /$$$$$$  /$$  /$$$$$$$ /$$$$$$        | $$  \__/  /$$$$$$  /$$$$$$/$$$$   /$$$$$$ 
| $$$$$$$$ /$$__  $$| $$ /$$_____/|_  $$_/        | $$ /$$$$ |____  $$| $$_  $$_  $$ /$$__  $$
| $$__  $$| $$$$$$$$| $$|  $$$$$$   | $$          | $$|_  $$  /$$$$$$$| $$ \ $$ \ $$| $$$$$$$$
| $$  | $$| $$_____/| $$ \____  $$  | $$ /$$      | $$  \ $$ /$$__  $$| $$ | $$ | $$| $$_____/
| $$  | $$|  $$$$$$$| $$ /$$$$$$$/  |  $$$$/      |  $$$$$$/|  $$$$$$$| $$ | $$ | $$|  $$$$$$$
|__/  |__/ \_______/|__/|_______/    \___/         \______/  \_______/|__/ |__/ |__/ \_______/           
            
                                                                                           ");
            }
            header();

            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("");
            Console.Write("How many members are on your crew? ");
            int teammembers;
            while (true)
            {
                string members = Console.ReadLine();
                if (int.TryParse(members, out teammembers))
                {
                    break;
                }
                Console.WriteLine("How about an actual number?");

            }
            Console.Clear();
            for (int k = 0; k < teammembers; k++)
            {

                header();
                Console.Write("Enter a name! ");
                string Name = Console.ReadLine();
                TeamMember Person = new TeamMember(Name);
                Person.GetSkill();
                Person.GetCourage();
                HeistTeam.Add(Person);
                Console.Clear();
            }

            // Console.WriteLine($"You have {HeistTeam.Count} members on your team");
            header();
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
            int DifficultyInt;
            while (true)
            {
                Console.Write("How difficult would you like this heist to be? (0-100) ");
                string DifficultyString = Console.ReadLine();
                if (int.TryParse(DifficultyString, out DifficultyInt) && DifficultyInt > 0 && DifficultyInt < 100)
                {
                    break;
                }
                Console.WriteLine("How about a reasonable number?");
            }


            int Wins = 0;
            int Losses = 0;

            for (int j = 0; j < runs; j++)
            {

                int Difficulty = DifficultyInt;
                int TeamSkillz = 0;

                Random i = new Random();
                int luck = i.Next(-10, 10);
                Difficulty = Difficulty + luck;


                Console.Clear();
                header();
                Console.Write($"Bank difficulty is {Difficulty}, ");



                foreach (TeamMember Person in HeistTeam)
                {
                    // Console.WriteLine($"{Person.Name}'s skill level is {Person.SkillLevel} and their courage level is {Person.Courage}!");
                    TeamSkillz += Person.SkillLevel;
                }

                Console.WriteLine($"Team Skillz {TeamSkillz}");




                if (Difficulty < TeamSkillz)
                {
                    Wins++;
                    Console.WriteLine("You da best! You got all the monies");
                    Console.WriteLine(@"
   ||====================================================================||
   ||//$\\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\//$\\||
   ||(100)==================| FEDERAL RESERVE NOTE |================(100)||
   ||\\$//        ~         '------========--------'                \\$//||
   ||<< /        /$\              // ____ \\                         \ >>||
   ||>>|  12    //L\\            // ///..) \\         L38036133B   12 |<<||
   ||<<|        \\ //           || <||  >\  ||                        |>>||
   ||>>|         \$/            ||  $$ --/  ||        One Hundred     |<<||
||====================================================================||>||
||//$\\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\//$\\||<||
||(100)==================| FEDERAL RESERVE NOTE |================(100)||>||
||\\$//        ~         '------========--------'                \\$//||\||
||<< /        /$\              // ____ \\                         \ >>||)||
||>>|  12    //L\\            // ///..) \\         L38036133B   12 |<<||/||
||<<|        \\ //           || <||  >\  ||                        |>>||=||
||>>|         \$/            ||  $$ --/  ||        One Hundred     |<<||
||<<|      L38036133B        *\\  |\_/  //* series                 |>>||
||>>|  12                     *\\/___\_//*   1989                  |<<||
||<<\      Treasurer     ______/Franklin\________     Secretary 12 />>||
||//$\                 ~|UNITED STATES OF AMERICA|~               /$\\||
||(100)===================  ONE HUNDRED DOLLARS =================(100)||
||\\$//\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\$//||
||====================================================================||
");
                    System.Threading.Thread.Sleep(4000);
                }
                else
                {
                    Losses++;
                    Console.WriteLine($@"
  _________________________
     ||   ||     ||   ||
     ||   ||, , ,||   ||
     ||  (||/|/(\||/  ||
     ||  ||| _'_`|||  ||
     ||   || o o ||   ||
     ||  (||  - `||)  ||
     ||   ||  =  ||   ||
     ||   ||\___/||   ||
     ||___||) , (||___||
    /||---||-\_/-||---||\
   / ||--_||_____||_--|| \
  (_(||)-| S123-45 |-(||)_)
|'''''''''''''''''''''''''''|
|      Do not pass go,      |
|    Do not collect $200    |
|   go straight to jail!!   |
 '''''''''''''''''''''''''''
");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(4000);
                }

            }
            Console.Clear();
            header();
            Console.WriteLine($"Your team was successfull {Wins} times & failed miserably {Losses} times.");
        }
    }
}
