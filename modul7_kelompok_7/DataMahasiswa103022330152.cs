using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;

using namespace modul7_kelompok_7
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public class Courses
    {
        public string code { get; set; }
        public string nama { get; set; }
    }
    public class DataMahasiswa103022330152
    {
        public List<Courses> course { get; set; }
        public Address address { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public long gender { get; set; }
        public string age { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_1_103022330152.json");
            DataMahasiswa103022330152 data = JsonSerializer.Deserialize<DataMahasiswa103022330152>(jsonString);

            Console.WriteLine($"Nama {data.firstName} {data.lastName} dengan gender {data.gender} dan umur {data.age}" +
                $" beralamatkan di {data.address.streetAddress}, {data.address.city}, {data.address.state}");
            Console.WriteLine("Daftar Mata kuliah yang diambil :");
            int i = 1;
            foreach (var courses in data.course)
            {
                Console.WriteLine($"MK {i} {courses.code} - {courses.name}");
                i++;
            }
        }
    }
}
