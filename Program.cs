using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // ### Phase 6
            // The program should be updated to...

            // 1.At the beginning of the program, prompt the user to enter the difficulty level of the bank.
            // 1.At the end of the program, display a report showing the number of successful runs and the number of failed runs.

            Console.WriteLine("Plan your Heist");

            List<TeamMember> team = new List<TeamMember>();

            Console.WriteLine("Enter the bank's difficulty level> ");
            int bankDifficultyStart = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Get the first team member's name
            Console.Write("Name> ");
            string name = Console.ReadLine();

            while(name != "") {

                Console.Write("Skill Level> ");
                string skillLevel = Console.ReadLine();

                Console.Write("Courage Factor> ");
                string courageFactor = Console.ReadLine();

                TeamMember member = new TeamMember();
                member.Name = name;
                member.SkillLevel = int.Parse(skillLevel);
                member.CourageFactor = double.Parse(courageFactor);

                team.Add(member);
                Console.WriteLine();

                // Get the next team member's name
                Console.Write("Name> ");
                name = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Team Size: {team.Count}");

            int teamSkill = 0;
            foreach(TeamMember member in team)
            {
                teamSkill += member.SkillLevel;
            }

            Console.WriteLine("Please enter number of trials> ");
            int numTrials = int.Parse(Console.ReadLine());
            Console.WriteLine();


            HeistReport report = new HeistReport();

            for (int i = 0; i < numTrials; i++)
            {
                // Reset bankDifficulty to original level, generate random luckValue and calc bankDifficulty
                int bankDifficulty = bankDifficultyStart;
                Random generator = new Random();
                int luckValue = generator.Next(-10, 11);
                bankDifficulty += luckValue;

                Console.WriteLine($"Team Skill Level: {teamSkill}");
                Console.WriteLine($"Bank Difficulty: {bankDifficulty}");

                if (bankDifficulty > teamSkill)
                {
                    // Console.WriteLine("Busted! You did not steal any of the money.");
                    // Console.WriteLine("--------------------");
                    report.FailureCount++;
                }
                else
                {
                    // Console.WriteLine("Success! You stole all of the money.");
                    // Console.WriteLine("--------------------");
                    report.SuccessCount++;
                }

            }

            // Print results of the simulation
            report.Print();

        }
    }
}
