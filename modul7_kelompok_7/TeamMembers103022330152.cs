using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;

namespace modul7_kelompok_7
{
    public class Members
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public string nim { get; set; }
    }
    public class TeamMembers103022330152
    {
        public List<Members> member { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103022330152.json");
            TeamMembers103022330152 data = JsonSerializer.Deserialize<TeamMembers103022330152>(jsonString);

            Console.WriteLine("Team Member List :");
            int i = 1;
            foreach (var Members in data.member)
            {
                Console.WriteLine($"Member {i} = {Members.nim}-{Members.firstName},{Members.lastName}" +
                    $" (umur {Members.age}, gender {Members.gender})");
                i++;
            }
        }
    }
}
