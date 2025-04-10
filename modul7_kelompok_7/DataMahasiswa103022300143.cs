using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_7
{
    public class nama
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }
    }
    public class Address
    {
        public string streetAddress {get;set;}
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class DataMahasiswa103022300143
    {
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\konstruksi perangkat lunak\\Praktikum_KonstruksiPL_7\\modul7_kelompok_7\\jurnal7_1_103022300143.json");
            nama mhs = JsonSerializer.Deserialize<nama>(jsonString);

            Console.WriteLine($"Nama: {mhs.firstname} {mhs.lastname}");
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
