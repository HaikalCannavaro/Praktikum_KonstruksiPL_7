using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace modul7
public class TeamMembers
{
    public string nim { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
    public string gender { get; set; }
}

public class TeamMembersRoot
{
    public List<TeamMember> teamMembers { get; set; }
}

public class TeamMembers_103022300081
{
    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_2_103022300081.json");
        TeamMembersRoot data = JsonSerializer.Deserialize<TeamMembersRoot>(jsonString);

        Console.WriteLine("Team member list:");
        foreach (var member in data.teamMembers)
        {
            Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
        }
    }
}
