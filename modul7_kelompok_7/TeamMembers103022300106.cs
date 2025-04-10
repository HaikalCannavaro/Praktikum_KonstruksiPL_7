using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_7
{
    public class Members
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public class TeamMembers103022300106
    {
        public List<Members> members { get; set; }
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103022300106.json");
            TeamMembers103022300106 data = JsonSerializer.Deserialize<TeamMembers103022300106>(jsonString);

            Console.WriteLine("Team member list: ");
            foreach (var member in data.members)
            {
                Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
            }
        }    
    }
}
