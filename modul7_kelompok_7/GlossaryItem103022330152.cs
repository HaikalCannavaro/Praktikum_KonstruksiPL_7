using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;

namespace modul7_kelompok_7
{
    public class Glossary
    {
        public string title { get; set; }
        public string GlossDiv { get; set; }
    }
    public class GlossDiv
    {
        public string title { get; set; }
        public string GlossList { get; set; }
    }
    public class GlossList
    {
        public string GlossEntry { get; set; }
    }
    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public string GlossDef { get; set; }
        public string GlossSee { get; set; }
    }
    public class GlossDef
    {
        public string para { get; set; }
        public string GlossSeeAlso { get; set; }
    }
    public class GlossaryItem103022330152
    {
        public List<Glossary> glossary { get; set; }
        public List<GlossDiv> glossDiv { get; set; }
        public List<GlossList> glossList { get; set; }
        public List<GlossEntry> glossEntry { get; set; }
        public List<GlossDef> glossDef { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_3_103022330152.json");
            GlossaryItem103022330152 data = JsonSerializer.Deserialize<GlossaryItem103022330152>(jsonString);

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
