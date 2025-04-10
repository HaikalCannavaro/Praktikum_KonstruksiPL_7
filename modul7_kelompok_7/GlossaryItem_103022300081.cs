using System;
using System.IO;
using System.Text.Json;

namespace modul7

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

public class GlossDiv
{
    public string title { get; set; }
    public GlossEntry GlossEntry { get; set; }
}

public class GlossaryRoot
{
    public string title { get; set; }
    public GlossDiv GlossDiv { get; set; }
}

public class GlossaryItem_103022300081
{
    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_3_103022300081.json");
        GlossaryRoot glossary = JsonSerializer.Deserialize<GlossaryRoot>(jsonString);

        GlossEntry entry = glossary.GlossDiv.GlossEntry;

        Console.WriteLine("Glossary Entry Details:");
        Console.WriteLine($"ID: {entry.ID}");
        Console.WriteLine($"Term: {entry.GlossTerm}");
        Console.WriteLine($"Acronym: {entry.Acronym}");
        Console.WriteLine($"Abbreviation: {entry.Abbrev}");
        Console.WriteLine($"Definition: {entry.GlossDef.para}");
        Console.WriteLine("See Also:");
        foreach (var see in entry.GlossDef.GlossSeeAlso)
        {
            Console.WriteLine($"  - {see}");
        }
        Console.WriteLine($"See: {entry.GlossSee}");
    }
}
