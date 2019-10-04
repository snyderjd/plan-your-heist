using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // ### Phase 1
            // The program should...

            // 1.Print the message "Plan Your Heist!".
            // 2.Create a way to store a single team member. A team member will have a _name_, a _skill Level_ and a _courage factor_.The _skill Level_ will be a positive integer and the _courage factor_ will be a decimal between 0.0 and 2.0.
            // 3.Prompt the user to enter a team member's name and save that name.
            // 4.Prompt the user to enter a team member's skill level and save that skill level with the name.
            // 5.Prompt the user to enter a team member's courage factor and save that courage factor with the name.
            // 6.Display the team member's information.

            // ### Phase 2
            // The program should be updated to...

            // 1.Create a way to store several team members.
            // 2.Collect several team members' information.
            // 3.Stop collecting team members when a blank name is entered.
            // 4.Display a message containing the number of members of the team.
            // 5.Display each team member's information.

            Console.WriteLine("Plan your Heist");

            List<Dictionary<string, string>> team = new List<Dictionary<string, string>>();

            // Get the first team member's name
            Console.Write("Name> ");
            string name = Console.ReadLine();

            while(name != "") {

                Console.Write("Skill Level> ");
                string skillLevel = Console.ReadLine();

                Console.Write("Courage Factor> ");
                string courageFactor = Console.ReadLine();

                Dictionary<string, string> member = new Dictionary<string, string>() {
                    {"Name", name},
                    {"Skill Level", skillLevel},
                    {"Courage Factor", courageFactor}
                };

                Console.WriteLine("--------------------");

                team.Add(member);

                // Get the next team member's name
                Console.Write("Name> ");
                name = Console.ReadLine();
            }

            Console.WriteLine($"Team Size: {team.Count}");
            Console.WriteLine("-------------------");

            Console.WriteLine("==== Team Members ====");

            foreach(Dictionary<string, string> member in team) {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Name: {member["Name"]}");
                Console.WriteLine($"Skill: {member["Skill Level"]}");
                Console.WriteLine($"Courage: {member["Courage Factor"]}");
            }

        }
    }
}
