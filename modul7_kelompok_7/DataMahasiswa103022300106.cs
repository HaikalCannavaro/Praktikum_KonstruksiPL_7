using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_7
{
    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }
    }

    public class Address
    {
        public string streetAddress { get; set; }
        public  string city { get; set; }
        public string state { get; set; }
    }
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public class DataMahasiswa103022300106
    {
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_1_103022300106.json");
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine($"Nama: {mhs.firstName} {mhs.lastName}");
            Console.WriteLine($"Gender: {mhs.gender}");
            Console.WriteLine($"Umur: {mhs.age}");
            Console.WriteLine($"Alamat: {mhs.address.streetAddress}, {mhs.address.city}, {mhs.address.state}");
            Console.WriteLine("Daftar Mata Kuliah: ");
            foreach (var course in mhs.courses)
            {
                Console.WriteLine($"- Kode Mata Kuliah: {course.code}, Nama Mata Kuliah: {course.name}");
            }
        }
    }
}
