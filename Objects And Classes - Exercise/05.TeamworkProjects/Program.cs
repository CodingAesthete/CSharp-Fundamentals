using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] line = Console.ReadLine().Split("-");
                string creator = line[0];
                string name = line[1];
                Team team = new Team();
                team.Creator = creator;
                team.Name = name;
                if (teams.Any(s => s.Name == name))
                {
                    Console.WriteLine($"Team {team.Name} was already created!");
                    continue;
                }
                if (teams.Any(s => s.Creator == creator))
                {
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                    continue;
                }
                teams.Add(team);
                Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
            }
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] line = command.Split("->");
                string user = line[0];
                string team = line[1];
                if (!teams.Any(s => s.Name == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }
                if (teams.Any(s => s.Creator == user) || teams.Any(s => s.Members.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                    continue;
                }
                if (teams.Any(s => s.Name == team))
                {
                    var added = teams.First(s => s.Name == team);
                    added.Members.Add(user);
                }
            }
            var teamsDisband = teams.Where(s => s.Members.Count == 0).Select(s => s.Name);
            foreach (var team in teams.OrderByDescending(s => s.Members.Count).ThenBy(s => s.Name))
            {
                if (team.Members.Count == 0)
                {
                    continue;
                }
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var item in team.Members.OrderBy(s => s))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
            Console.WriteLine($"Teams to disband:");
            foreach (var item in teamsDisband.OrderBy(s => s))
            {
                Console.WriteLine(item);
            }
        }
        public class Team
        {
            public string Creator { get; set; }
            public string Name { get; set; }
            public List<string> Members = new List<string>();
        }
    }
}
