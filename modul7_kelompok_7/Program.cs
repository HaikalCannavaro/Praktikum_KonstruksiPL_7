using modul7_kelompok_7;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022330152 datamhs = new DataMahasiswa103022330152();
        datamhs.ReadJSON();

        TeamMembers103022330152 anggota = new TeamMembers103022330152();
        anggota.ReadJSON();
    }
}