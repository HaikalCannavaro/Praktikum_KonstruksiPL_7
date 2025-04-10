using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_7
{
    public class Nama
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
    public class address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public class DataMahasiswa103022300085
    {
        public Nama nama { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public List<address> alamat { get; set; }
        public List<Course> courses { get; set; }


        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_1_103022300085.json");
            DataMahasiswa103022300085 data = JsonSerializer.Deserialize<DataMahasiswa103022300085>(jsonString);

            Console.WriteLine($"Data {data.nama.firstName} {data.nama.lastName} : {data.gender}, {data.age}, Alamat : {data.alamat}, {data.alamat.city}{data.alamat.state}");
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var course in data.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }

        }
    }
}
