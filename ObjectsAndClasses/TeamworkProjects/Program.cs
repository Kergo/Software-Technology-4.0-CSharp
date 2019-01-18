using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{

    public class Team
    {
        public Team(string name, string creatorname)
        {
            Name = name;
            CreatorName = creatorname;
            Members = new List<string>();
        }
        public string Name { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var teams = new List<Team>();

            for (int i = 0; i < count; i++)
            {
                string[] splitedInput = Console.ReadLine().Split("-");

                string creatorName = splitedInput[0];   
                string teamName = splitedInput[1];   

                //bool isTeamNamePresent = teams.Select(x => x.Name).Contains(teamName);
                                        //THE SAME
                bool isTeamNamePresent = teams.Any(x => x.Name == teamName);
                bool isCreatorNamePresent = teams.Any(x => x.CreatorName == creatorName);

                if (isTeamNamePresent == false && isCreatorNamePresent == false)
                {
                    Team team = new Team(teamName, creatorName);
                    teams.Add(team);
                    System.Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
                else if (isTeamNamePresent)
                {
                    System.Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isCreatorNamePresent)
                {
                    System.Console.WriteLine($"{creatorName} cannot create another team!");
                }
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {

                string[] tockens = input.Split("->");
                string user = tockens[0];
                string teamName = tockens[1];

                bool isTeamPresentet = teams.Any(x => x.Name == teamName);
                bool isAlreadyMember = teams.Any(x => x.Members.Contains(user) || x.CreatorName == user);

                if (!isTeamPresentet)
                {
                    System.Console.WriteLine($"Team {teamName} does not exist!");
                }
                if (isAlreadyMember)
                {
                    System.Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                if (isTeamPresentet && !isAlreadyMember)
                {
                    int indexOfTeam = teams.FindIndex(x => x.Name == teamName);
                    teams[indexOfTeam].Members.Add(user);
                }

                input = Console.ReadLine();
            }

            var teamsWithMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)
                .ToList();

            var teamsWithoutMembers = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var team in teamsWithMembers)
            {
                System.Console.WriteLine(team.Name);
                System.Console.WriteLine("- " + team.CreatorName);
                System.Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => $"-- {x}")));
            } 

            System.Console.WriteLine("Teams to disband:");

            foreach (var team in teamsWithoutMembers)
            {
                System.Console.WriteLine(team.Name);
            }     
        }
    }
}
