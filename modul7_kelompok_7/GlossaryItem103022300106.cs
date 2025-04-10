using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_7
{
    public class Glossary
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }
    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }
    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }
    public class GlossDef
    {
        public string para { get; set; }
        public string[] GlossSeeAlso { get; set; }
    }

    public class GlossaryItem103022300106
    {
        public Glossary glossary { get; set; }
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_3_103022300106.json");
            GlossaryItem103022300106 data = JsonSerializer.Deserialize<GlossaryItem103022300106>(jsonString);

            var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("**GlossEntry Data**");
            Console.WriteLine($"ID: {entry.ID}");
            Console.WriteLine($"SortAs: {entry.SortAs}");
            Console.WriteLine($"GlossTerm: {entry.GlossTerm}");
            Console.WriteLine($"Acronym: {entry.Acronym}");
            Console.WriteLine($"Abbrev: {entry.Abbrev}");
            Console.WriteLine($"Para: {entry.GlossDef.para}");
            Console.WriteLine("GlossSeeAlso: " + string.Join(", ", entry.GlossDef.GlossSeeAlso));
            Console.WriteLine($"GlossSee: {entry.GlossSee}");
        }
    }

}
