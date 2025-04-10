using System;

namespace modul7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== JSON Deserialization =====\n");

            Console.WriteLine("PART 1: STUDENT DATA");
            DataMahasiswa_103022300081.ReadJSON();
            Console.WriteLine();

            Console.WriteLine("PART 2: TEAM MEMBERS");
            TeamMembers_103022300081.ReadJSON();
            Console.WriteLine();

            Console.WriteLine("PART 3: GLOSSARY");
            GlossaryItem_103022300081.ReadJSON();

            Console.WriteLine("\nPencet tombol apa saja untuk lanjut...");
            Console.ReadKey();
        }
    }
}
